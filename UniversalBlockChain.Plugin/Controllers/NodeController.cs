using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UniversalBlockChain.Library.Contracts;

namespace UniversalBlockChain.Plugin.Controllers
{
    [Route("UBC")]
    public class NodeController : System.Web.Mvc.Controller, INodeController
    {
        [HttpGet("peers")]
        public System.Web.Mvc.JsonResult GetPeers()
        {
            return "Hello from Index method of Home Controller";
        }

        [HttpPost("peers")]
        public IActionResult PostPeer()
        {
            return new OkResult();
        }

    }
}
