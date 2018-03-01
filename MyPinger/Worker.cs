using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace MyPinger
{
    public class Worker
    {
        Random rand = new Random();

        public void work(object obj)
        {
            HostTime ht = (HostTime)obj;
            try
            {
                while (true)
                {
                    Ping ping = new Ping();
                    Thread.Sleep(ht.timeout * 1500);
                    PingReply pr = ping.Send(ht.host, 500);
                    ProcessChanged(ht.index, pr.Status + " - " + rand.Next());
                }
            }
            catch (PingException ex)
            {
                ProcessError(ex.Message);
            }
        }

        public event Action<int, string> ProcessChanged;
        public event Action<string> ProcessError;
    }
}
