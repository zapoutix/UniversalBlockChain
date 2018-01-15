using MessagePack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Chain.Library.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHash_WhenSameBlock_CheckHashAreEqual()
        {
            //Actors
            MyBlock genesis = new MyBlock(null, "once", new List<string>
                    {
                        "message1",
                        "message2",
                        "message3",
                        "message4"
                    });


            MyBlock genesis2 = new MyBlock(null, "once", new List<string>
                    {
                        "message1",
                        "message2",
                        "message3",
                        "message4"
                    });

            //Activities
            string hash1  = genesis.GetHash();
            string hash2 = genesis2.GetHash();

            //Asserts
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetHash_WhenNotSameBlock_CheckHashAreNotEqual()
        {
            //Actors
            MyBlock genesis = new MyBlock(null, "once", new List<string>
                    {
                        "message1a",
                    });


            MyBlock genesis2 = new MyBlock(null, "once", new List<string>
                    {
                        "message1b",
                    });

            //Activities
            string hash1 = genesis.GetHash();
            string hash2 = genesis2.GetHash();

            //Asserts
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}
