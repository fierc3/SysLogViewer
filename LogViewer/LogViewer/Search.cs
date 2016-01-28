// -----------------------------------------------------------------------
// <copyright file="Search.cs" company="VFI">
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
    public class Search
    {
        String searchTerm;
        String searchField;
        List<SysLogMessageVO> activeList = new List<SysLogMessageVO>();
        public Search(List<SysLogMessageVO> fullList, String searchTerm, String searchField)
        {
            activeList.AddRange(fullList);
            this.searchTerm = searchTerm;
            this.searchField = searchField;
        }

        public List<SysLogMessageVO> getActiveList()
        {
            foreach (SysLogMessageVO vo in activeList)
            {
                if (!vo.getFieldBySearch(searchField).ToLower().Contains(searchTerm.ToLower()))
                {
                    vo.visible = false;
                }
            }
            return activeList;
        }
    }
}
