using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPinger
{
    public class HostTime
    {
        public string host { get; set; }
        public int timeout { get; set; }
        public int index { get; set; }

        public HostTime()
        {
        }

        public HostTime (string host, int timeout, int index)
        {
            this.host = host;
            this.timeout = timeout;
            this.index = index;
        }
    }
}
