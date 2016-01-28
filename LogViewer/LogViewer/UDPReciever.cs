// -----------------------------------------------------------------------
// <copyright file="UDPReciever.cs" company="VFI">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace LogViewer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net.Sockets;
    using System.Net;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class UDPReciever
    {

        static UdpClient client;
        IPEndPoint sourceIp;
        LogHandler handler = new LogHandler();

        public void beginReceivingUdp(int port)
        {
            client = new UdpClient(port);
            sourceIp = new IPEndPoint(IPAddress.Any, port);
            bool isComplete = true;
            IAsyncResult udpCallback = null;
            try
            {
                while (true)
                {
                    if (isComplete)
                    {
                        udpCallback = client.BeginReceive(new AsyncCallback(callback), null);
                        isComplete = false;
                    }
                    else
                    {
                        if (udpCallback.IsCompleted == true) { isComplete = true; }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("W10.001.01 Exception during receiving of udp, Exception[" + ex + "]");
            }
        }

        public void callback(IAsyncResult async)
        {
            string rawMsg = Encoding.ASCII.GetString(client.EndReceive(async, ref sourceIp));
            handler.processNewRawMsg(rawMsg, Convert.ToString(sourceIp.Address));

        }

    }
}
