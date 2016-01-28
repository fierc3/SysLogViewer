namespace LogViewer
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblField = new System.Windows.Forms.Label();
            this.pickerToDate = new System.Windows.Forms.DateTimePicker();
            this.pickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFacility = new System.Windows.Forms.ComboBox();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.chkUseSearch = new System.Windows.Forms.CheckBox();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chkUseFilter = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogSnapshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLogSnapshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOuput = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFacility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblTo);
            this.splitContainer1.Panel1.Controls.Add(this.lblFrom);
            this.splitContainer1.Panel1.Controls.Add(this.cmbField);
            this.splitContainer1.Panel1.Controls.Add(this.lblField);
            this.splitContainer1.Panel1.Controls.Add(this.pickerToDate);
            this.splitContainer1.Panel1.Controls.Add(this.pickerFromDate);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFacility);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSeverity);
            this.splitContainer1.Panel1.Controls.Add(this.chkUseSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchTerm);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.chkUseFilter);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listOuput);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 491);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(203, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(112, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Severity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Facility";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(20, 291);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(20, 247);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 13;
            this.lblFrom.Text = "From:";
            // 
            // cmbField
            // 
            this.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbField.Enabled = false;
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "Date",
            "Time",
            "IP-Address Source",
            "Severity",
            "Facility",
            "Message"});
            this.cmbField.Location = new System.Drawing.Point(10, 393);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(154, 21);
            this.cmbField.TabIndex = 10;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(9, 377);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(69, 13);
            this.lblField.TabIndex = 11;
            this.lblField.Text = "Search Field:";
            // 
            // pickerToDate
            // 
            this.pickerToDate.Enabled = false;
            this.pickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerToDate.Location = new System.Drawing.Point(136, 284);
            this.pickerToDate.Name = "pickerToDate";
            this.pickerToDate.Size = new System.Drawing.Size(200, 20);
            this.pickerToDate.TabIndex = 7;
            // 
            // pickerFromDate
            // 
            this.pickerFromDate.Enabled = false;
            this.pickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFromDate.Location = new System.Drawing.Point(136, 241);
            this.pickerFromDate.Name = "pickerFromDate";
            this.pickerFromDate.Size = new System.Drawing.Size(200, 20);
            this.pickerFromDate.TabIndex = 6;
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacility.Enabled = false;
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.ItemHeight = 13;
            this.cmbFacility.Items.AddRange(new object[] {
            "None",
            "kern",
            "user",
            "mail",
            "daemon",
            "auth",
            "syslog",
            "lpr",
            "news",
            "uucp",
            "clock",
            "authpriv",
            "ftp",
            "ntp",
            "logaudit",
            "logalert",
            "cron",
            "local0",
            "local1",
            "local2",
            "lcoal3",
            "local4",
            "local5",
            "local6",
            "local7"});
            this.cmbFacility.Location = new System.Drawing.Point(23, 181);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(141, 21);
            this.cmbFacility.TabIndex = 5;
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.AllowDrop = true;
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.Enabled = false;
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "None",
            "Emergency",
            "Alert",
            "Critical",
            "Error",
            "Warning",
            "Notice",
            "Information",
            "Debug"});
            this.cmbSeverity.Location = new System.Drawing.Point(23, 117);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(141, 21);
            this.cmbSeverity.TabIndex = 4;
            // 
            // chkUseSearch
            // 
            this.chkUseSearch.AutoSize = true;
            this.chkUseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseSearch.Location = new System.Drawing.Point(10, 339);
            this.chkUseSearch.Name = "chkUseSearch";
            this.chkUseSearch.Size = new System.Drawing.Size(92, 17);
            this.chkUseSearch.TabIndex = 9;
            this.chkUseSearch.Text = "Use Search";
            this.chkUseSearch.UseVisualStyleBackColor = true;
            this.chkUseSearch.CheckedChanged += new System.EventHandler(this.chkUseSearch_CheckedChanged);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Enabled = false;
            this.txtSearchTerm.Location = new System.Drawing.Point(12, 431);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(324, 20);
            this.txtSearchTerm.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 415);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Term:";
            // 
            // chkUseFilter
            // 
            this.chkUseFilter.AutoSize = true;
            this.chkUseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseFilter.Location = new System.Drawing.Point(10, 65);
            this.chkUseFilter.Name = "chkUseFilter";
            this.chkUseFilter.Size = new System.Drawing.Size(80, 17);
            this.chkUseFilter.TabIndex = 3;
            this.chkUseFilter.Text = "Use Filter";
            this.chkUseFilter.UseVisualStyleBackColor = true;
            this.chkUseFilter.CheckedChanged += new System.EventHandler(this.chkUseFilter_CheckedChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.sendEmail,
            this.saveLogSnapshotToolStripMenuItem,
            this.loadLogSnapshotToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // sendEmail
            // 
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(174, 22);
            this.sendEmail.Text = "send Email With Logs";
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // saveLogSnapshotToolStripMenuItem
            // 
            this.saveLogSnapshotToolStripMenuItem.Name = "saveLogSnapshotToolStripMenuItem";
            this.saveLogSnapshotToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveLogSnapshotToolStripMenuItem.Text = "Save Log Snapshot";
            this.saveLogSnapshotToolStripMenuItem.Click += new System.EventHandler(this.saveLogSnapshotToolStripMenuItem_Click);
            // 
            // loadLogSnapshotToolStripMenuItem
            // 
            this.loadLogSnapshotToolStripMenuItem.Name = "loadLogSnapshotToolStripMenuItem";
            this.loadLogSnapshotToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadLogSnapshotToolStripMenuItem.Text = "Load Log Snapshot";
            this.loadLogSnapshotToolStripMenuItem.Click += new System.EventHandler(this.loadLogSnapshotToolStripMenuItem_Click);
            // 
            // listOuput
            // 
            this.listOuput.AllowColumnReorder = true;
            this.listOuput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDate,
            this.cTime,
            this.cSource,
            this.cSeverity,
            this.cFacility,
            this.cMsg});
            this.listOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOuput.GridLines = true;
            this.listOuput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listOuput.LabelEdit = true;
            this.listOuput.LabelWrap = false;
            this.listOuput.Location = new System.Drawing.Point(0, 0);
            this.listOuput.Name = "listOuput";
            this.listOuput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listOuput.Size = new System.Drawing.Size(844, 491);
            this.listOuput.TabIndex = 18;
            this.listOuput.UseCompatibleStateImageBehavior = false;
            this.listOuput.View = System.Windows.Forms.View.Details;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 100;
            // 
            // cTime
            // 
            this.cTime.Text = "Time";
            // 
            // cSource
            // 
            this.cSource.Text = "IP-Address Source";
            this.cSource.Width = 108;
            // 
            // cSeverity
            // 
            this.cSeverity.Text = "Severity";
            this.cSeverity.Width = 75;
            // 
            // cFacility
            // 
            this.cFacility.Text = "Facility";
            this.cFacility.Width = 139;
            // 
            // cMsg
            // 
            this.cMsg.Tag = "1";
            this.cMsg.Text = "Message";
            this.cMsg.Width = 358;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Syslog Snapshot files|*.sog";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Syslog Snapshot files|*.sog";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 491);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogForm";
            this.Text = "LogViewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.CheckBox chkUseFilter;
        public System.Windows.Forms.ListView listOuput;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cTime;
        private System.Windows.Forms.ColumnHeader cSource;
        private System.Windows.Forms.ColumnHeader cSeverity;
        internal System.Windows.Forms.ColumnHeader cFacility;
        private System.Windows.Forms.ColumnHeader cMsg;
        private System.Windows.Forms.CheckBox chkUseSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.DateTimePicker pickerToDate;
        private System.Windows.Forms.DateTimePicker pickerFromDate;
        private System.Windows.Forms.ComboBox cmbFacility;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmail;
        private System.Windows.Forms.ToolStripMenuItem saveLogSnapshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLogSnapshotToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

