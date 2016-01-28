using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogViewer
{
    public partial class MailForm : Form
    {
        List<SysLogMessageVO> logList;

        public MailForm(List<SysLogMessageVO> logList)
        {
            InitializeComponent();
            this.logList = logList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Mailer SendMail = new Mailer(tbTo.Text);
            SendMail.sendMail(logList);
            this.Close();
        }


        private Form f = new Form();
        public void executeEasterEgg()
        {
            try
            {
                f = new Form();
                Random numGenerator = new Random();
                int randomPicker = numGenerator.Next(0, secretEasterEggs.Length);
                String url = secretEasterEggs[randomPicker];
                f.Width = 245;
                f.Location = this.Location;
                f.Height = 245;
                PictureBox picture = new PictureBox();
                picture.Width = 245;
                picture.Height = 245;
                picture.Load(url);
                f.Controls.Add(picture);
                f.Visible = true;
                f.Show();
                f.Text = "Sending in Progress....";
            }
            catch (Exception ex)
            {
                Console.Write("W11.001.01 Failed loading Easteregg, Exception[" + ex + "]");
            }
        }
        public void stopEasterEgg()
        {
            try
            {

                f.Close();
            }
            catch (Exception ex)
            {
                Console.Write("W11.001.02 Failed stopping Easteregg, Exception[" + ex + "]");
            }
        }

        String[] secretEasterEggs = {   @"http://31.media.tumblr.com/20b83c7ceec91ce860758f33654b0bc7/tumblr_inline_nkien9O3ae1t6l70x.gif",
                                        @"https://s-media-cache-ak0.pinimg.com/originals/2e/dc/90/2edc90c8a24fafbac36ffea01c393b1c.jpg",
                                        @"https://31.media.tumblr.com/92ef6ba09b920751ac31aa6883711f3b/tumblr_n8fa0jMam31s1nsuro1_500.gif",
                                        @"https://45.media.tumblr.com/3fe5bb9f3720a48d3041287af8e8fb04/tumblr_n6gkayQDKY1tbu5tyo1_250.gif",
                                        @"https://s-media-cache-ak0.pinimg.com/originals/73/65/51/73655117f46ea51721ffbdd66d594960.jpg",
                                        @"http://25.media.tumblr.com/tumblr_m750w8w6fR1rsp4nlo1_250.gif",
                                        @"http://33.media.tumblr.com/cb38d84dd2cebe91fe25640ce33abbfb/tumblr_inline_o0jyx2BLds1sq554e_500.gif",
                                        @"http://49.media.tumblr.com/3f8bd58f8dc8edc705c84ab53180761b/tumblr_nn7r6dxmaw1smvngpo1_400.gif"
                                    };

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            stopEasterEgg();
        }

        private void onLoad(object sender, EventArgs e)
        {
            executeEasterEgg();
        }

    }
}
