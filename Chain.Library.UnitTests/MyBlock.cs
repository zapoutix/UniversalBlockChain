using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Library.UnitTests
{
    [MessagePackObject(keyAsPropertyName: true)]
    public class MyBlock : BaseBlock
    {
        public MyBlock(string previousHash, string nonce, IEnumerable<string> messages)
            : base(previousHash, nonce)
        {
            this.Messages = messages;
        }

        public IEnumerable<string> Messages { get; set; }

        public override byte[] Serialize()
        {
            return MessagePackSerializer.Serialize(this);
        }
    }
}
