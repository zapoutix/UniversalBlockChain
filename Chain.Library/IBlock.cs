using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Library
{
    public interface IBlock
    {
        string PreviousHash { get; }

        string Nonce { get; }

        string GetHash();
    }
}
