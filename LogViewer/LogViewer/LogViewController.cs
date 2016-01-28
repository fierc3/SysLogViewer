using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using LogViewer.Properties;

namespace LogViewer
{
    class LogViewController
    {
        public static Boolean wantReceive = false;
        static List<SysLogMessageVO> logList = new List<SysLogMessageVO>();
        LogHandler handler = new LogHandler();
        Printer printer = new Printer();
        List<SysLogMessageVO> activeList;

        public void init(int port)
        {
            handler.initLogReceiver(port);
        }

        public Boolean toggleEnabled(Boolean currentValue)
        {
            if (currentValue == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal void addLogToList(SysLogMessageVO msg)
        {
            logList.Add(msg);
        }

        public ListViewItem[] getCurrentLogList(Boolean wantFilter, String serverity, String facility, String fromDate, String toDate, Boolean wantSearch, String searchTerm, String searchField)
        {
            if (serverity.Contains("none"))
            {
                serverity = "";
            }
            if (facility.Contains("none"))
            {
                facility = "";
            }
            activeList = new List<SysLogMessageVO>(logList);
            resetMsg(activeList);
            if (wantFilter)
            {
                Filter filter = new Filter(activeList, serverity, facility, fromDate, toDate);
                activeList = filter.getActiveList();
            }
            if (wantSearch)
            {
                if (searchTerm.ToLower().Equals("instantkharma"))
                {

                }
                Search search = new Search(activeList, searchTerm, searchField);
                activeList = search.getActiveList();
            }

            List<ListViewItem> activeListViewItemList = new List<ListViewItem>();
            foreach (SysLogMessageVO vo in activeList)
            {
                if (vo.visible)
                {
                    ListViewItem item1 = new ListViewItem(vo.date);
                    item1.SubItems.Add(vo.time);
                    item1.SubItems.Add(vo.source);
                    item1.SubItems.Add(vo.severity);
                    item1.SubItems.Add(vo.facility);
                    item1.SubItems.Add(vo.message);
                    activeListViewItemList.Add(item1);
                }
            }

            return activeListViewItemList.ToArray();
        }

        public void resetMsg(List<SysLogMessageVO> toBeResetList)
        {
            foreach (SysLogMessageVO vo in toBeResetList)
            {
                vo.visible = true;
            }
        }

        internal void showPrintDialog()
        {
            if (activeList.Count != 0)
            {
                Printer printer = new Printer();
                printer.print(activeList);
            }
            else
            {
                MessageBox.Show("Kann keine leere List drucken");
            }
        }

        internal void saveLogs(String path)
        {
            try
            {
                BinaryHandler.WriteToBinaryFile<List<SysLogMessageVO>>(path, logList, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei Speicherung des Snapshots: Exception[" + ex.Message + "]");
            }
        }

        internal void loadLogs(String path)
        {
            try
            {
                logList = BinaryHandler.ReadFromBinaryFile<List<SysLogMessageVO>>(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei Loading des Snapshots: Exception[" + ex.Message + "]");
            }
        }

        public void showMailDialog()
        {
            try
            {
                MailForm mailform = new MailForm(activeList);
                mailform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("W11.001.03" + ex);
            }
        }

    }
}
