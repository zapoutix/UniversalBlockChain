using Chain.Library.Helpers;
using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Library
{
    [MessagePackObject(keyAsPropertyName: true)]
    public abstract class BaseBlock : IBlock
    {
        public BaseBlock(string previousHash, string nonce)
        {
            this.PreviousHash = previousHash;
            this.Nonce = nonce;
        }

        public string PreviousHash { get; }

        public string Nonce { get; }

        public abstract byte[] Serialize();


        public string GetHash()
        {
            var bytes = Serialize();
            return HashHelper.GetHash(bytes);
        }
    }
}
