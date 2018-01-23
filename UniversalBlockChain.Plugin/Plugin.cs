using System;
using System.Collections.Generic;
using System.Text;
using UniversalBlockChain.Library.Contracts;

namespace UniversalBlockChain.Plugin
{
    public class Plugin : IPlugin
    {
        public Guid UniqueId => new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

        public string Name => "TestCoin";

        public string Description => "TestCoin Description";

        public string Code => "UBC";
    }
}
