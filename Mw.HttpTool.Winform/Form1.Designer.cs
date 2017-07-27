namespace Mw.HttpTool.Winform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbUrl = new MetroFramework.Controls.MetroTextBox();
            this.mtbBody = new MetroFramework.Controls.MetroTextBox();
            this.mtbResponse = new MetroFramework.Controls.MetroTextBox();
            this.mbtnRequest = new MetroFramework.Controls.MetroButton();
            this.mcbRequestType = new MetroFramework.Controls.MetroComboBox();
            this.mbtmEmptyResponse = new MetroFramework.Controls.MetroButton();
            this.mcbHistory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tvResponse = new System.Windows.Forms.TreeView();
            this.mtcResponse = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mtcBody = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tvBody = new System.Windows.Forms.TreeView();
            this.mtcHeader = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.mgHeader = new MetroFramework.Controls.MetroGrid();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.tvHeader = new System.Windows.Forms.TreeView();
            this.mcbEmptyResponse = new MetroFramework.Controls.MetroCheckBox();
            this.mtcResponse.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.mtcBody.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.mtcHeader.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgHeader)).BeginInit();
            this.metroTabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "请求地址：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "请求数据：";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 287);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "返回数据：";
            // 
            // mtbUrl
            // 
            // 
            // 
            // 
            this.mtbUrl.CustomButton.Image = null;
            this.mtbUrl.CustomButton.Location = new System.Drawing.Point(499, 2);
            this.mtbUrl.CustomButton.Name = "";
            this.mtbUrl.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUrl.CustomButton.TabIndex = 1;
            this.mtbUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbUrl.CustomButton.UseSelectable = true;
            this.mtbUrl.CustomButton.Visible = false;
            this.mtbUrl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbUrl.Lines = new string[] {
        "http://www.kuaidi100.com/query?type=yuantong&postid=11111111111"};
            this.mtbUrl.Location = new System.Drawing.Point(119, 93);
            this.mtbUrl.MaxLength = 32767;
            this.mtbUrl.Name = "mtbUrl";
            this.mtbUrl.PasswordChar = '\0';
            this.mtbUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUrl.SelectedText = "";
            this.mtbUrl.SelectionLength = 0;
            this.mtbUrl.SelectionStart = 0;
            this.mtbUrl.ShortcutsEnabled = true;
            this.mtbUrl.Size = new System.Drawing.Size(525, 28);
            this.mtbUrl.TabIndex = 3;
            this.mtbUrl.Text = "http://www.kuaidi100.com/query?type=yuantong&postid=11111111111";
            this.mtbUrl.UseSelectable = true;
            this.mtbUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbBody
            // 
            this.mtbBody.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.mtbBody.CustomButton.Image = null;
            this.mtbBody.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.mtbBody.CustomButton.Name = "";
            this.mtbBody.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.mtbBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbBody.CustomButton.TabIndex = 1;
            this.mtbBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbBody.CustomButton.UseSelectable = true;
            this.mtbBody.CustomButton.Visible = false;
            this.mtbBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtbBody.Lines = new string[0];
            this.mtbBody.Location = new System.Drawing.Point(0, 0);
            this.mtbBody.MaxLength = 32767;
            this.mtbBody.Multiline = true;
            this.mtbBody.Name = "mtbBody";
            this.mtbBody.PasswordChar = '\0';
            this.mtbBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbBody.SelectedText = "";
            this.mtbBody.SelectionLength = 0;
            this.mtbBody.SelectionStart = 0;
            this.mtbBody.ShortcutsEnabled = true;
            this.mtbBody.Size = new System.Drawing.Size(255, 110);
            this.mtbBody.TabIndex = 99;
            this.mtbBody.UseSelectable = true;
            this.mtbBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbResponse
            // 
            // 
            // 
            // 
            this.mtbResponse.CustomButton.Image = null;
            this.mtbResponse.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.mtbResponse.CustomButton.Name = "";
            this.mtbResponse.CustomButton.Size = new System.Drawing.Size(245, 245);
            this.mtbResponse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbResponse.CustomButton.TabIndex = 1;
            this.mtbResponse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbResponse.CustomButton.UseSelectable = true;
            this.mtbResponse.CustomButton.Visible = false;
            this.mtbResponse.Lines = new string[0];
            this.mtbResponse.Location = new System.Drawing.Point(0, 0);
            this.mtbResponse.MaxLength = 32767;
            this.mtbResponse.Multiline = true;
            this.mtbResponse.Name = "mtbResponse";
            this.mtbResponse.PasswordChar = '\0';
            this.mtbResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbResponse.SelectedText = "";
            this.mtbResponse.SelectionLength = 0;
            this.mtbResponse.SelectionStart = 0;
            this.mtbResponse.ShortcutsEnabled = true;
            this.mtbResponse.Size = new System.Drawing.Size(525, 250);
            this.mtbResponse.TabIndex = 99;
            this.mtbResponse.UseSelectable = true;
            this.mtbResponse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbResponse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnRequest
            // 
            this.mbtnRequest.Location = new System.Drawing.Point(650, 162);
            this.mbtnRequest.Name = "mbtnRequest";
            this.mbtnRequest.Size = new System.Drawing.Size(121, 29);
            this.mbtnRequest.TabIndex = 6;
            this.mbtnRequest.Text = "请求";
            this.mbtnRequest.UseSelectable = true;
            this.mbtnRequest.Click += new System.EventHandler(this.mbtnRequest_Click);
            // 
            // mcbRequestType
            // 
            this.mcbRequestType.FormattingEnabled = true;
            this.mcbRequestType.ItemHeight = 23;
            this.mcbRequestType.Items.AddRange(new object[] {
            "Get",
            "Post"});
            this.mcbRequestType.Location = new System.Drawing.Point(650, 93);
            this.mcbRequestType.Name = "mcbRequestType";
            this.mcbRequestType.Size = new System.Drawing.Size(121, 29);
            this.mcbRequestType.TabIndex = 7;
            this.mcbRequestType.UseSelectable = true;
            this.mcbRequestType.SelectedIndexChanged += new System.EventHandler(this.mcbRequestType_SelectedIndexChanged);
            // 
            // mbtmEmptyResponse
            // 
            this.mbtmEmptyResponse.Location = new System.Drawing.Point(650, 536);
            this.mbtmEmptyResponse.Name = "mbtmEmptyResponse";
            this.mbtmEmptyResponse.Size = new System.Drawing.Size(121, 29);
            this.mbtmEmptyResponse.TabIndex = 8;
            this.mbtmEmptyResponse.Text = "清空";
            this.mbtmEmptyResponse.UseSelectable = true;
            this.mbtmEmptyResponse.Click += new System.EventHandler(this.mbtmEmptyResponse_Click);
            // 
            // mcbHistory
            // 
            this.mcbHistory.FormattingEnabled = true;
            this.mcbHistory.ItemHeight = 23;
            this.mcbHistory.Location = new System.Drawing.Point(119, 58);
            this.mcbHistory.Name = "mcbHistory";
            this.mcbHistory.Size = new System.Drawing.Size(525, 29);
            this.mcbHistory.TabIndex = 9;
            this.mcbHistory.UseSelectable = true;
            this.mcbHistory.SelectedIndexChanged += new System.EventHandler(this.mcbHistory_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "历史记录：";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(572, 578);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(205, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "惠州马克威士智能科技有限公司";
            // 
            // tvResponse
            // 
            this.tvResponse.Location = new System.Drawing.Point(0, 0);
            this.tvResponse.Name = "tvResponse";
            this.tvResponse.Size = new System.Drawing.Size(521, 250);
            this.tvResponse.TabIndex = 99;
            // 
            // mtcResponse
            // 
            this.mtcResponse.Controls.Add(this.metroTabPage1);
            this.mtcResponse.Controls.Add(this.metroTabPage2);
            this.mtcResponse.Location = new System.Drawing.Point(115, 276);
            this.mtcResponse.Name = "mtcResponse";
            this.mtcResponse.SelectedIndex = 1;
            this.mtcResponse.Size = new System.Drawing.Size(529, 299);
            this.mtcResponse.TabIndex = 13;
            this.mtcResponse.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mtbResponse);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(521, 257);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "文本展示";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tvResponse);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(521, 257);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "树形展示";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mtcBody
            // 
            this.mtcBody.Controls.Add(this.metroTabPage3);
            this.mtcBody.Controls.Add(this.metroTabPage4);
            this.mtcBody.Location = new System.Drawing.Point(384, 127);
            this.mtcBody.Name = "mtcBody";
            this.mtcBody.SelectedIndex = 1;
            this.mtcBody.Size = new System.Drawing.Size(260, 155);
            this.mtcBody.TabIndex = 14;
            this.mtcBody.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.mtbBody);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(252, 113);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "Body";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.tvBody);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(252, 113);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "树形展示";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // tvBody
            // 
            this.tvBody.Location = new System.Drawing.Point(0, 0);
            this.tvBody.Name = "tvBody";
            this.tvBody.Size = new System.Drawing.Size(252, 110);
            this.tvBody.TabIndex = 99;
            // 
            // mtcHeader
            // 
            this.mtcHeader.Controls.Add(this.metroTabPage5);
            this.mtcHeader.Controls.Add(this.metroTabPage6);
            this.mtcHeader.Location = new System.Drawing.Point(122, 127);
            this.mtcHeader.Name = "mtcHeader";
            this.mtcHeader.SelectedIndex = 0;
            this.mtcHeader.Size = new System.Drawing.Size(260, 155);
            this.mtcHeader.TabIndex = 15;
            this.mtcHeader.UseSelectable = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.mgHeader);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(252, 113);
            this.metroTabPage5.TabIndex = 0;
            this.metroTabPage5.Text = "Header";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // mgHeader
            // 
            this.mgHeader.AllowUserToResizeRows = false;
            this.mgHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgHeader.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgHeader.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgHeader.EnableHeadersVisualStyles = false;
            this.mgHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgHeader.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgHeader.Location = new System.Drawing.Point(0, 0);
            this.mgHeader.Name = "mgHeader";
            this.mgHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgHeader.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgHeader.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgHeader.RowTemplate.Height = 23;
            this.mgHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mgHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgHeader.Size = new System.Drawing.Size(252, 110);
            this.mgHeader.TabIndex = 99;
            // 
            // Key
            // 
            this.Key.HeaderText = "键";
            this.Key.Name = "Key";
            this.Key.Width = 80;
            // 
            // Value
            // 
            this.Value.HeaderText = "值";
            this.Value.Name = "Value";
            this.Value.Width = 135;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.tvHeader);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(252, 113);
            this.metroTabPage6.TabIndex = 1;
            this.metroTabPage6.Text = "树形展示";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // tvHeader
            // 
            this.tvHeader.Location = new System.Drawing.Point(0, 0);
            this.tvHeader.Name = "tvHeader";
            this.tvHeader.Size = new System.Drawing.Size(252, 110);
            this.tvHeader.TabIndex = 100;
            // 
            // mcbEmptyResponse
            // 
            this.mcbEmptyResponse.AutoSize = true;
            this.mcbEmptyResponse.Location = new System.Drawing.Point(660, 314);
            this.mcbEmptyResponse.Name = "mcbEmptyResponse";
            this.mcbEmptyResponse.Size = new System.Drawing.Size(114, 15);
            this.mcbEmptyResponse.TabIndex = 16;
            this.mcbEmptyResponse.Text = "请求时自动清空";
            this.mcbEmptyResponse.UseSelectable = true;
            this.mcbEmptyResponse.CheckedChanged += new System.EventHandler(this.mcbEmptyResponse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mcbEmptyResponse);
            this.Controls.Add(this.mtcHeader);
            this.Controls.Add(this.mtcBody);
            this.Controls.Add(this.mtcResponse);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mcbHistory);
            this.Controls.Add(this.mbtmEmptyResponse);
            this.Controls.Add(this.mcbRequestType);
            this.Controls.Add(this.mbtnRequest);
            this.Controls.Add(this.mtbUrl);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HTTP模拟工具";
            this.mtcResponse.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.mtcBody.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.mtcHeader.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgHeader)).EndInit();
            this.metroTabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbUrl;
        private MetroFramework.Controls.MetroTextBox mtbBody;
        private MetroFramework.Controls.MetroTextBox mtbResponse;
        private MetroFramework.Controls.MetroButton mbtnRequest;
        private MetroFramework.Controls.MetroComboBox mcbRequestType;
        private MetroFramework.Controls.MetroButton mbtmEmptyResponse;
        private MetroFramework.Controls.MetroComboBox mcbHistory;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TreeView tvResponse;
        private MetroFramework.Controls.MetroTabControl mtcResponse;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl mtcBody;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.TreeView tvBody;
        private MetroFramework.Controls.MetroTabControl mtcHeader;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroGrid mgHeader;
        private MetroFramework.Controls.MetroCheckBox mcbEmptyResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private System.Windows.Forms.TreeView tvHeader;
    }
}

