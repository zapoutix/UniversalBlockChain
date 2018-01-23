using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalBlockChain.Library.Contracts
{
    public interface IPlugin
    {
        Guid UniqueId { get; }
        string Name { get; }
        string Description { get; }
        string Code { get; }

    }
}
