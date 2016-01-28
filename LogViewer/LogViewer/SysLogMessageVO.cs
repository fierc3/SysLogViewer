using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogViewer
{
    [Serializable]
    public class SysLogMessageVO
    {
        public String message { get; set; }
        public String date { get; set; }
        public String time { get; set; }
        public String source { get; set; }
        public String severity { get; set; }
        public String facility { get; set; }
        public Boolean visible { get; set; }

        public String getFieldBySearch(String search)
        {
            // switch statement
            switch (search.ToLower())
            {
                case "message":
                    return message;
                case "date":
                    return date;
                case "time":
                    return time;
                case "ip-address source":
                    return source;
                case "severity":
                    return severity;
                case "facility":
                    return facility;
            }
            return message;
        }

    }
}
