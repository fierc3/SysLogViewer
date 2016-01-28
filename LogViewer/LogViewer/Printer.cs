using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace LogViewer
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    public class Printer
    {

        public void print(List<SysLogMessageVO> logList)
        {
            WebBrowser webBrowserForPrinting = new WebBrowser();
            webBrowserForPrinting.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(PrintDocument);
            webBrowserForPrinting.DocumentText = HtmlCreator.getHtmlLogList(logList);
        }

        private void PrintDocument(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            Form tempForm = new Form();
            WebBrowser preview = ((WebBrowser)sender);
            tempForm.Size = Screen.PrimaryScreen.Bounds.Size;
            preview.Size = Screen.PrimaryScreen.Bounds.Size;
            tempForm.Controls.Add(preview);
            tempForm.Show();
            tempForm.Visible = false;
            preview.Show();
            preview.ShowPrintPreviewDialog();
            preview.Dispose();
        }

    }

}
