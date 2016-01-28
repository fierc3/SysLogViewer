// -----------------------------------------------------------------------
// <copyright file="HtmlCreator.cs" company="VFI">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace LogViewer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class HtmlCreator
    {
        public static String getHtmlLogList(List<SysLogMessageVO> logList)
        {
            String html = "<h2>SYSLOGs</h2><table border='3'><tr><td>Date</td><td>Time</td><td>IP Address source</td><td>Severity</td>"
                + "<td>Facility</td><td>Message</td></tr>";

            foreach (SysLogMessageVO log in logList)
            {
                if (log.visible == true)
                {
                    html += "<tr><td>" + log.date + "</td>" + "<td>" + log.time + "</td>" + "<td>" + log.source + "</td>" +
                        "<td>" + log.severity + "</td>" + "<td>" + log.facility + "</td>" + "<td>" + log.message + "</td></tr>";
                }
            }
            html += "</table>";

            return html;
        }
    }
}
