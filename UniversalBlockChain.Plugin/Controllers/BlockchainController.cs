using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using UniversalBlockChain.Library.Contracts;

namespace UniversalBlockChain.Plugin.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("UBC")]
    class BlockchainController : Controller, IBlockchainController
    {
    }
}
