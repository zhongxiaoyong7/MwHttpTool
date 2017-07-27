using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mw.HttpTool.Model
{
    public class RequestLog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string RequestHead { get; set; }
        public string RequestType { get; set; }
        public string RequestBody { get; set; }
        public string Response { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
