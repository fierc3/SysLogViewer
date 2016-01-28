// -----------------------------------------------------------------------
// <copyright file="Filter.cs" company="VFI">
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
    public class Filter
    {
        String serverity = "";
        String facility = "";
        String fromDate = "";
        String toDate = "";

        List<SysLogMessageVO> activeList = new List<SysLogMessageVO>();
        public Filter(List<SysLogMessageVO> fullList, String serverity, String facility, String fromDate, String toDate)
        {
            activeList.AddRange(fullList);
            this.facility = facility;
            this.serverity = serverity;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        public List<SysLogMessageVO> getActiveList()
        {
            int originalSize=activeList.Count;
            for (int iterator = 0; iterator < originalSize;iterator++)
            {
                SysLogMessageVO vo = activeList[iterator];
                vo.visible = true;
                DateTime voDate = Convert.ToDateTime(vo.date);
                DateTime filterFromDate = Convert.ToDateTime(fromDate.Split(' ')[0]);
                DateTime filterToDate = Convert.ToDateTime(toDate.Split(' ')[0]);
                if ((voDate >= filterFromDate) && (voDate <= filterToDate))
                {

                    if (!vo.severity.ToLower().Contains(serverity))
                    {
                        vo.visible = false;
                    }
                    else if (!vo.facility.ToLower().Contains(facility))
                    {
                        vo.visible = false;
                    }
                }
                else
                {
                    vo.visible = false;
                }

            }

            return activeList;
        }
    }
}
