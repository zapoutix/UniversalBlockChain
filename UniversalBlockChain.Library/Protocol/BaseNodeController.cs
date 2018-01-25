using System;
using System.Collections.Generic;
using System.Text;
using UniversalBlockChain.Library.Contracts;

namespace UniversalBlockChain.Library.Protocol
{
    public class BaseNodeController : System.Web.Mvc.Controller, INodeController
    {
        protected bool AddPeer(string ip, string port, bool isMasterNode)
        {
            //Check if peer already added

            //If not
                //Add peer
                //Boardast
            return true;
        }
    }
}
