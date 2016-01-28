namespace LogViewer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Mail;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    using System.Net.Security;
    using System.Windows.Forms;

    public class Mailer
    {
        MailAddress fromAddress = null;
        MailAddress toAddress = null;
        string fromPassword = "";
        public Mailer(string To)
        {
            fromAddress = new MailAddress("syslog@gmx.ch");
            toAddress = new MailAddress(To);
            fromPassword = "slvsslvs";
        }
        public void sendMail(List<SysLogMessageVO> logList)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "mail.gmx.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Timeout = 5000,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure,
                        Subject = "SysLog",
                        Body = HtmlCreator.getHtmlLogList(logList),
                        IsBodyHtml = true
                    })
                {

                    smtp.Send(message);
                };
                MessageBox.Show("Email versendet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-Mail senden fehlgeschlagen!, Exception["+ex+"]");
            }
        }


    }

}
