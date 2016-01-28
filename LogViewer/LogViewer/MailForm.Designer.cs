namespace LogViewer
{
    partial class MailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gmxBox = new System.Windows.Forms.PictureBox();
            this.lblGmx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gmxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(15, 107);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(363, 20);
            this.tbTo.TabIndex = 2;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(12, 149);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(366, 23);
            this.btnSendMail.TabIndex = 6;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "syslog@gmx.net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // gmxBox
            // 
            this.gmxBox.Image = global::LogViewer.Properties.Resources.gmx_freemail_e_mail_fuer_alle_schweiz;
            this.gmxBox.Location = new System.Drawing.Point(263, 24);
            this.gmxBox.Name = "gmxBox";
            this.gmxBox.Size = new System.Drawing.Size(133, 66);
            this.gmxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gmxBox.TabIndex = 12;
            this.gmxBox.TabStop = false;
            // 
            // lblGmx
            // 
            this.lblGmx.AutoSize = true;
            this.lblGmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmx.Location = new System.Drawing.Point(240, 13);
            this.lblGmx.Name = "lblGmx";
            this.lblGmx.Size = new System.Drawing.Size(73, 13);
            this.lblGmx.TabIndex = 13;
            this.lblGmx.Text = "Powered by";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 219);
            this.Controls.Add(this.lblGmx);
            this.Controls.Add(this.gmxBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MailForm";
            this.Text = "Send Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onClosing);
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gmxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gmxBox;
        private System.Windows.Forms.Label lblGmx;
    }
}