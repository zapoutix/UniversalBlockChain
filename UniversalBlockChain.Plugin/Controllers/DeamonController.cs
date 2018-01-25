using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UniversalBlockChain.Library.Contracts;

namespace UniversalBlockChain.Plugin.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("UBC")]
    public class DeamonController : System.Web.Mvc.Controller, IDeamonController
    {
        [HttpGet("ping")]
        public IActionResult GetPing()
        {
            return new OkResult();
        }
    }
}
