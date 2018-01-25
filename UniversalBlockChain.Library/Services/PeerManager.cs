using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalBlockChain.Library.Models;

namespace UniversalBlockChain.Library.Services
{
    public class PeerManager
    {
        private static PeerManager _instance;
        public static PeerManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PeerManager();

                return _instance;
            }
        }

        public IEnumerable<Peer> GetPeers()
        {
            return Peers;
        }

        public PeerManager()
        {
            Peers = new List<Peer>();
        }

        private List<Peer> Peers { get; set; }

        public bool Contains(Peer p)
        {
            //TODO 0 better check => is masternde
            return Peers.Select(o => o.IpAddress).Contains(p.IpAddress);
        }

        public bool AddPeer(Peer p)
        {
            if (!Contains(p))
            { 
                Peers.Add(p);
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
