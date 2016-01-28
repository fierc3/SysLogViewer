// -----------------------------------------------------------------------
// <copyright file="Prompt.cs" company="VFI">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace LogViewer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 100 };
            CheckBox checkKiwi = new CheckBox() { Left = 25, Top = 125, Width = 200, Text = "Use alternative Kiwi Format" };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(checkKiwi);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            String format = "syslog";


            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (checkKiwi.Checked)
                {
                    format = "kiwi";
                }
                return textBox.Text + ";" + format;
            }
            else
            {
                return "";
            }
        }
    }
}
