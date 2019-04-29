using Amib.Threading;
using MetroFramework.Forms;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Data.SQLite;
using Mw.HttpTool.Model;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Configuration;
//using DapperExtensions;

namespace Mw.HttpTool.Winform
{
    public partial class Form1 : MetroForm
    {
        //http://blog.sina.com.cn/s/blog_a3e16b1101013z3i.html 窗体初始化ComboBox触发三次
        int mcbHistoryCount = 0;

        public Form1()
        {
            InitializeComponent();

            //string strJson= string.Format( "[{\"floors\": [{\"map\": \"f1-123.png\", \"name\": \"test\", \"floor\": \"1\"}], \"name\": \"test\", \"id\": \"852801\"}, {\"floors\": [{\"map\": \"f0-floorone.png\", \"name\": \"FOne\", \"floor\": \"0\"}],\"name\": \"LibFloor\", \"id\": \"765026\"},{\"floors\": [{\"map\": \"f0-home.png\", \"name\": \"house\", \"floor\": \"0\"}], \"name\": \"Home\", \"id\": \"810320\"}]");

            //BindTreeView(treeView1, strJson);
            //BindTreeView(treeView1, strJson);

            SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
            sb.DataSource = Directory.GetCurrentDirectory() + @"\HttpTool.db";

            SQLiteConnection con = new SQLiteConnection(sb.ToString());
            //SQLiteConnection con = new SQLiteConnection(sb.ToString());
            con.Open();

            string sql = "select * from RequestLog order by UpdateTime desc limit 0,100";
            //IList<ISort> sort = new List<ISort>
            //{
            //    Predicates.Sort<RequestLog>(p => p.UpdateTime,false)
            //};
            //sort.Add(new Sort { PropertyName = "UpdateTime", Ascending = false });

            //IEnumerable<RequestLog> list = con.GetPage<RequestLog>(null, sort,0,100);

            IEnumerable<RequestLog> list = con.Query<RequestLog>(sql);

            mcbHistory.DataSource = list;
            mcbHistory.ValueMember = "Id";
            mcbHistory.DisplayMember = "Url";
            con.Close();
            if (list.Count() == 0)//当窗体初始化ComboBox没有绑定到数据时，SelectedIndexChanged事件不会触发3次
            {
                mcbHistoryCount = 2;
                mcbRequestType.Text = "Get";
            }

            mtcResponse.SelectedIndex = 0;
            mtcBody.SelectedIndex = 0;
            mtcHeader.SelectedIndex = 0;

            bool isEmptyResponse = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsEmptyResponse"]);
            if (isEmptyResponse)
            {
                mcbEmptyResponse.Checked = true;
            }
            else
            {
                mcbEmptyResponse.Checked = false;
            }


        }

        /// <summary>
        /// 请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonData"></param>
        /// <param name="methodType"></param>
        /// <returns></returns>
        private string RequestData(string url, Dictionary<string, string> headerData, string jsonData, Method methodType)
        {
            string urlHead = "";
            string urlTail = "";
            if (url.IndexOf("http://") == 0)
            {
                urlHead = "http://";
                urlTail = url.Substring("http://".Length);
            }
            else if (url.IndexOf("https://") == 0)
            {
                urlHead = "https://";
                urlTail = url.Substring("https://".Length);
            }
            else
            {
                urlHead = "http://";
                urlTail = url;
            }

            var client = new RestClient(urlHead + urlTail.Split('/')[0]);
            var request = new RestRequest(url.Substring(url.LastIndexOf(urlTail.Split('/')[0]) + urlTail.Split('/')[0].Length + 1), methodType);
            if (methodType == Method.POST)
                request.AddParameter("application/json;charset=utf-8", jsonData, ParameterType.RequestBody);

            foreach (var item in headerData)
            {
                request.AddHeader(item.Key, item.Value);
            }

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            return content.ToString();
        }

        /// <summary>
        /// 绑定树形控件
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="strJson"></param>
        private void BindTreeView(TreeView treeView, string strJson)
        {
            treeView.Nodes.Clear();

            //string strJson = "1";//抛异常
            //string strJson = "{}";
            //string strJson = "{\"errcode\":0,\"errmsg\":\"查询成功\",\"datas\":[{\"c_ResourceType\":\"BootLogo\",\"c_Url\":\"/Upload/Magazine/4e09315d-7d92-4e6a-984d-80f684a24da8.jpg\"}]}";
            //string strJson = "[{\"DeviceCode\":\"430BE-B3C6A-4E953-9F972-FC741\",\"RoomNum\":\"777\"},{\"DeviceCode\":\"BF79F -09807-EEA31-2499E-31A98\",\"RoomNum\":\"888\"}]";

            if (IsJOjbect(strJson))
            {
                JObject jo = (JObject)JsonConvert.DeserializeObject(strJson);

                foreach (var item in jo)
                {
                    TreeNode tree;
                    if (item.Value.GetType() == typeof(JObject))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                    else if (item.Value.GetType() == typeof(JArray))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                    else
                    {
                        tree = new TreeNode(item.Key + ":" + item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                }
            }
            if (IsJArray(strJson))
            {
                JArray ja = (JArray)JsonConvert.DeserializeObject(strJson);
                int i = 0;
                foreach (JObject item in ja)
                {
                    TreeNode tree = new TreeNode("Array [" + (i++) + "]");
                    foreach (var itemOb in item)
                    {
                        TreeNode treeOb;
                        if (itemOb.Value.GetType() == typeof(JObject))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);

                        }
                        else if (itemOb.Value.GetType() == typeof(JArray))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);
                        }
                        else
                        {
                            treeOb = new TreeNode(itemOb.Key + ":" + itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);
                        }
                    }
                    treeView.Nodes.Add(tree);
                }
            }
            treeView.ExpandAll();
        }

        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="parantNode"></param>
        /// <param name="value"></param>
        public void AddTreeChildNode(ref TreeNode parantNode, string value)
        {
            if (IsJOjbect(value))
            {
                JObject jo = (JObject)JsonConvert.DeserializeObject(value);
                foreach (var item in jo)
                {
                    TreeNode tree;
                    if (item.Value.GetType() == typeof(JObject))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                    else if (item.Value.GetType() == typeof(JArray))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                    else
                    {
                        tree = new TreeNode(item.Key + ":" + item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                }
            }
            if (IsJArray(value))
            {
                JArray ja = (JArray)JsonConvert.DeserializeObject(value);
                int i = 0;
                foreach (JObject item in ja)
                {
                    TreeNode tree = new TreeNode("Array [" + (i++) + "]");
                    parantNode.Nodes.Add(tree);
                    foreach (var itemOb in item)
                    {
                        TreeNode treeOb;
                        if (itemOb.Value.GetType() == typeof(JObject))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);

                        }
                        else if (itemOb.Value.GetType() == typeof(JArray))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);
                        }
                        else
                        {
                            treeOb = new TreeNode(itemOb.Key + ":" + itemOb.Value.ToString());
                            tree.Nodes.Add(treeOb);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 判断是否JOjbect类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsJOjbect(string value)
        {
            try
            {
                JObject ja = JObject.Parse(value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否JArray类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsJArray(string value)
        {
            try
            {
                JArray ja = JArray.Parse(value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 取mgHeader列表数据
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetHeaderData()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            int row = mgHeader.Rows.Count;//得到总行数    
            if (row > 1)
            {
                int cell = mgHeader.Rows[1].Cells.Count;//得到总列数    
                for (int i = 0; i < row; i++)//得到总行数并在之内循环    
                {
                    for (int j = 0; j < cell; j++)//得到总列数并在之内循环    
                    {
                        //对比TexBox中的值是否与dataGridView中的值相同（上面这句）    
                        this.mgHeader.CurrentCell = this.mgHeader[j, i];//定位到相同的单元格    
                        if (j == 0)
                        {
                            if (this.mgHeader.CurrentCell.Value != null)
                            {
                                //Debug.WriteLine(this.metroGrid1.CurrentCell.Value.ToString() + "_" + this.metroGrid1[1, i].Value.ToString());
                                if (!dic.ContainsKey(this.mgHeader.CurrentCell.Value.ToString()))
                                {
                                    string value = "";
                                    if (this.mgHeader[1, i].Value != null)
                                    {
                                        value = this.mgHeader[1, i].Value.ToString();
                                    }
                                    dic.Add(this.mgHeader.CurrentCell.Value.ToString(), value);
                                }
                            }
                        }
                    }
                }
            }

            return dic;
        }

        private void mcbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("mcbHistoryCount:" + mcbHistoryCount);
            RequestLog siEntiy = (RequestLog)mcbHistory.SelectedItem;
            if (mcbHistoryCount == 2)
            {
                SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
                sb.DataSource = Directory.GetCurrentDirectory() + @"\HttpTool.db";
                SQLiteConnection con = new SQLiteConnection(sb.ToString());
                con.Open();

                RequestLog entity = con.Query<RequestLog>("select * from RequestLog where Id=" + siEntiy.Id + " order by UpdateTime desc limit 0,10").SingleOrDefault();
                //RequestLog entity = con.Get<RequestLog>(siEntiy.Id);

                mtbUrl.Text = entity.Url;

                mtbBody.Text = entity.RequestBody; ;
                BindTreeView(tvBody, mtbBody.Text);

                mcbRequestType.Text = siEntiy.RequestType;

                if (!mcbEmptyResponse.Checked)
                {
                    mtbResponse.Text = siEntiy.Response + "\r\n\r\n" + mtbResponse.Text;
                }
                else
                {
                    mtbResponse.Text = siEntiy.Response;
                }
                BindTreeView(tvResponse, siEntiy.Response);

                if (siEntiy.RequestType == "Get")
                {
                    //txtRequestData.Enabled = false;
                    //txtRequestData.BackColor = Color.Gray;

                    //treeView2.Enabled = false;
                    //treeView2.BackColor = Color.Gray;

                    mtcBody.Enabled = false;
                    mtcBody.BackColor = Color.Gray;
                }

                tvHeader.Nodes.Clear();
                mgHeader.Rows.Clear();
                List<RequestHeader> list = con.Query<RequestHeader>("select * from RequestHeader where RequestLogID=" + siEntiy.Id).ToList();
                foreach (var item in list)
                {
                    mgHeader.Rows.Add(item.Key, item.Value);
                    tvHeader.Nodes.Add(item.Key + ":" + item.Value);
                }

                con.Close();
            }
            else
            {
                ++mcbHistoryCount;
            }
        }

        private void mbtnRequest_Click(object sender, EventArgs e)
        {
            SmartThreadPool smartThreadPool = new SmartThreadPool();

            Dictionary<string, string> dicHeader = GetHeaderData();

            // Queue the work item
            IWorkItemResult<string> wir;
            switch (mcbRequestType.Text)
            {
                case "Post":
                    wir = smartThreadPool.QueueWorkItem(RequestData, mtbUrl.Text, dicHeader, mtbBody.Text, Method.POST);
                    break;
                default:
                case "Get":
                    wir = smartThreadPool.QueueWorkItem(RequestData, mtbUrl.Text, dicHeader, mtbBody.Text, Method.GET);
                    break;
            }

            BindTreeView(tvBody, mtbBody.Text);

            // Do some other work here

            // Get the result of the operation

            //mtbResponse.Text = wir.Result + "\r\n\r\n" + mtbResponse.Text;

            BindTreeView(tvResponse, wir.Result);

            smartThreadPool.Shutdown();

            SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
            sb.DataSource = Directory.GetCurrentDirectory() + @"\HttpTool.db";
            SQLiteConnection con = new SQLiteConnection(sb.ToString());
            con.Open();
            string sql = "select * from RequestLog where Url='" + mtbUrl.Text.Trim() + "'";
            if (con.Query<RequestLog>(sql).Count<RequestLog>() > 0)
            {
                con.Execute("update RequestLog set RequestType=@RequestType,RequestBody=@RequestBody,Response=@Response,UpdateTime=@UpdateTime where Url=@Url ",
                new
                {
                    Url = mtbUrl.Text.Trim(),
                    RequestBody = mtbBody.Text,
                    Response = wir.Result,
                    UpdateTime = DateTime.Now,
                    RequestType = mcbRequestType.Text
                });


            }
            else
            {
                con.Execute(" insert into RequestLog(Url,RequestType,RequestBody,Response,CreateTime,UpdateTime)values(@Url,@RequestType,@RequestBody,@Response,@CreateTime,@UpdateTime)"
                , new
                {
                    Url = mtbUrl.Text.Trim(),
                    RequestBody = mtbBody.Text,
                    Response = wir.Result,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    RequestType = mcbRequestType.Text
                });
            }

            //RequestLog entity;
            //var predicate = Predicates.Field<RequestLog>(f => f.Url, Operator.Eq, txtUrl.Text);
            //if (con.GetList<RequestLog>(predicate).Count() > 0)
            //{
            //    entity = con.Get<RequestLog>(new { Url = txtUrl.Text });
            //    entity.UpdateTime = DateTime.Now;
            //    entity.RequestBody = txtRequestData.Text;
            //    entity.Response = wir.Result;
            //    entity.RequestType = cbRequest.Text;
            //    con.Update<RequestLog>(entity);

            //}
            //else
            //{
            //    entity = new RequestLog()
            //    {
            //        CreateTime = DateTime.Now,
            //        RequestBody = txtRequestData.Text,
            //        RequestType = cbRequest.Text,
            //        Response = wir.Result,
            //        Url = txtUrl.Text
            //    };
            //    con.Insert(entity);
            //}

            RequestLog entity = con.Query<RequestLog>(sql).SingleOrDefault();
            con.Execute("delete from RequestHeader where RequestLogID=@RequestLogID",
            new
            {
                RequestLogID = entity.Id
            });
            foreach (var item in dicHeader)
            {
                con.Execute(" insert into RequestHeader(RequestHeaderID,Key,Value,RequestLogID)values(@RequestHeaderID,@Key,@Value,@RequestLogID)"
                , new
                {
                    RequestHeaderID = Guid.NewGuid().ToString(),
                    Key = item.Key,
                    Value = item.Value,
                    RequestLogID = entity.Id,
                });
            }


            Thread.Sleep(50);
            this.Invoke(new MethodInvoker(delegate
            {
                //cbHistory.DataSource = con.Query<RequestLog>("select * from RequestLog order by UpdateTime desc limit 0, 100");
                //IList<ISort> sort = new List<ISort>();
                //sort.Add(new Sort { PropertyName = "UpdateTime", Ascending = false });
                //IEnumerable<RequestLog> list =con.GetPage<RequestLog>(null, sort, 0, 100).ToList()

                IEnumerable<RequestLog> list = con.Query<RequestLog>("select * from RequestLog order by UpdateTime desc limit 0, 100");
                mcbHistory.DataSource = list;
                mcbHistory.ValueMember = "Id";
                mcbHistory.DisplayMember = "Url";
                mcbHistory.Refresh();
            }));

            con.Close();
        }

        private void mcbRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mcbRequestType.Text == "Get")
            {
                //txtRequestData.Enabled = false;
                //txtRequestData.BackColor = Color.Gray;

                mtcBody.Enabled = false;
                mtcBody.BackColor = Color.Gray;
            }
            else
            {
                //txtRequestData.Enabled = true;
                //txtRequestData.BackColor = Color.White;

                mtcBody.Enabled = true;
                mtcBody.BackColor = Color.White;
            }
        }

        private void mbtmEmptyResponse_Click(object sender, EventArgs e)
        {
            mtbResponse.Text = "";
            tvResponse.Nodes.Clear();
        }

        private void mcbEmptyResponse_CheckedChanged(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["IsEmptyResponse"].Value = mcbEmptyResponse.Checked.ToString();
            cfa.Save();
        }
    }
}
