using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalBlockChain.Library
{
    public interface IBlock
    {
        string PreviousHash { get; }

        string Nonce { get; }

        string GetHash();
    }
}
