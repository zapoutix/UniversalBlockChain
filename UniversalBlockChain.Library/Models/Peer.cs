using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalBlockChain.Library.Models
{
    public class Peer
    {
        public string IpAddress { get; set; }

        public int Port { get; set; }

        public bool IsMasterNode { get; set; }

        public DateTime LastQueryReceived { get; set; }

        public DateTime LastQuerySent { get; set; }

        public TimeSpan StartAt { get; set; }
    }
}
