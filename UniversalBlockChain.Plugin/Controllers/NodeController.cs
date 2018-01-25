using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UniversalBlockChain.Library.Contracts;
using UniversalBlockChain.Library.Services;

namespace UniversalBlockChain.Plugin.Controllers
{
    [Route("UBC")]
    public class NodeController : System.Web.Mvc.Controller, INodeController
    {
        [HttpGet("peers")]
        public System.Web.Mvc.JsonResult GetPeers()
        {
            var peers = PeerManager.Instance.GetPeers();
            return Json(peers);
        }

        [HttpPost("peers")]
        public IActionResult PostPeer()
        {
            return new OkResult();
        }

    }
}
