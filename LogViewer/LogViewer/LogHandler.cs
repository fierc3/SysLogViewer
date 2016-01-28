// -----------------------------------------------------------------------
// <copyright file="LogHandler.cs" company="VFI">
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
    public class LogHandler
    {
        public static Boolean useKiwi = false;

        public void initLogReceiver(int port)
        {
            UDPReciever UdpReceiver = new UDPReciever();
            UdpReceiver.beginReceivingUdp(port);
        }

        internal void processNewRawMsg(string rawMsg, string sourceip)
        {
            if (LogViewController.wantReceive)
            {
                SysLogMessageVO msgVo;
                if (useKiwi)
                {
                    msgVo = kiwiConvertToSysLogMessageVo(rawMsg, sourceip);
                }
                else
                {
                    msgVo = syslogConvertToSysLogMessageVo(rawMsg, sourceip);
                }
                LogViewController controller = new LogViewController();
                controller.addLogToList(msgVo);
            }
        }

        public SysLogMessageVO syslogConvertToSysLogMessageVo(String msg, String sourceip)
        {
            SysLogMessageVO msgVo = new SysLogMessageVO();
            msgVo.source = sourceip;
            msgVo.message = msg.Split('>')[1];
            String temp = msg.Split('<')[1].Split('>')[0];
            int priority = Int32.Parse(temp, System.Globalization.NumberStyles.Integer);
            int serverity = priority % 8;
            int facility = priority - serverity;
            msgVo.severity = "" + Enum.GetName(typeof(Severity), serverity);
            msgVo.facility = "" + Enum.GetName(typeof(Facility), facility / 8);
            msgVo.date = DateTime.Now.ToString("d");
            msgVo.time = DateTime.Now.ToString("t");
            msgVo.visible = true;
            return msgVo;
        }

        public SysLogMessageVO kiwiConvertToSysLogMessageVo(String msg, String sourceip)
        {
            SysLogMessageVO msgVo = new SysLogMessageVO();
            msgVo.source = sourceip;
            msgVo.message = msg.Split("\t".ToCharArray())[3];
            msgVo.severity = msg.Split("\t".ToCharArray())[1].Split(".".ToCharArray())[1];
            msgVo.facility = msg.Split("\t".ToCharArray())[1].Split(".".ToCharArray())[0];
            msgVo.date = DateTime.Now.ToString("d");
            msgVo.time = DateTime.Now.ToString("t");
            msgVo.visible = true;
            return msgVo;
        }

    }
}
