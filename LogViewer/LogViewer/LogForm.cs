using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace LogViewer
{
    public partial class LogForm : Form
    {
        Task taskUpdate = null;

        LogViewController controller = new LogViewController();
        public LogForm()
        {
            String token = (Prompt.ShowDialog("Enter Port Number:", "Enter Port"));
            if (token.Contains(';'))
            {
                if (token.Split(';')[1].Contains("kiwi"))
                {
                    LogHandler.useKiwi = true;
                }
            }
            int port = 0;
            try
            {
                port = Convert.ToInt32(token.Split(';')[0]);
                if(port == 0){
                    throw new InvalidOperationException();
                }

            }
            catch (Exception ex)
            {
                port = 514;
                MessageBox.Show(this, "Invaild Port entered, using default 514");
            }
            Action actionUpdate = () =>
            {
                controller.init(port);

            };
            taskUpdate = new Task(actionUpdate, new CancellationTokenSource().Token);
            taskUpdate.Start();
            InitializeComponent();
            System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Interval = 666;
            aTimer.Enabled = true;



        }

        private void updateOutput()
        {
            ListViewItem[] list = controller.getCurrentLogList(chkUseFilter.Checked, cmbSeverity.Text.ToLower(), cmbFacility.Text.ToLower(), pickerFromDate.Text, pickerToDate.Text, chkUseSearch.Checked, txtSearchTerm.Text.ToLower(), cmbField.Text.ToLower());
            if (list.Length != 0)
            {
                printToolStripMenuItem.Enabled = true;
                sendEmail.Enabled = true;
                saveLogSnapshotToolStripMenuItem.Enabled = true;
            }
            else
            {
                printToolStripMenuItem.Enabled = false;
                sendEmail.Enabled = false;
                saveLogSnapshotToolStripMenuItem.Enabled = false;
            }
            if (listOuput.Items.Count != list.Length)
            {
                listOuput.Items.Clear();
                listOuput.Items.AddRange(list);
                if (listOuput.Items.Count != 0)
                {
                    listOuput.Items[listOuput.Items.Count - 1].EnsureVisible();
                }
            }
            else if (listOuput.Items.Count != 0 && (!listOuput.Items[listOuput.Items.Count - 1].SubItems[1].Text.Contains(list[list.Length - 1].SubItems[1].Text) || !listOuput.Items[listOuput.Items.Count - 1].SubItems[5].Text.Contains(list[list.Length - 1].SubItems[5].Text)))
            {
                listOuput.Items.Clear();
                listOuput.Items.AddRange(list);
                listOuput.Items[listOuput.Items.Count - 1].EnsureVisible();
            }
        }



        private void chkUseFilter_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbFacility.Enabled = controller.toggleEnabled(cmbFacility.Enabled);
            cmbSeverity.Enabled = controller.toggleEnabled(cmbSeverity.Enabled);
            pickerFromDate.Enabled = controller.toggleEnabled(pickerFromDate.Enabled);
            pickerToDate.Enabled = controller.toggleEnabled(pickerToDate.Enabled);
        }

        private void chkUseSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchTerm.Enabled = controller.toggleEnabled(txtSearchTerm.Enabled);
            cmbField.Enabled = controller.toggleEnabled(cmbField.Enabled);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.showPrintDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            LogViewController.wantReceive = true;
        }

        private void OnTimedEvent(Object source, EventArgs e)
        {
            updateOutput();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            LogViewController.wantReceive = false;
        }

        private void saveLogSnapshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                controller.saveLogs(saveFileDialog1.FileName);
            }
        }

        private void loadLogSnapshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                controller.loadLogs(openFileDialog1.FileName);
            }
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            controller.showMailDialog();
        }

    }
}
