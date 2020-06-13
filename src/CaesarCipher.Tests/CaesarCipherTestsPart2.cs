using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class CaesarCipherTestsPart2
    {
        private CaesarCipher caesarCipher;

        [TestInitialize]
        public void TestInitialize()
        {
            caesarCipher = new CaesarCipher();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            caesarCipher = null;
        }

        [TestMethod]
        public void CaesarCipher_decodes_hello_world_with_4_shift()
        {
            //var result = caesarCipher.Decode("Lipps, Asvph!", 4);
            var result = caesarCipher.Decode("Asvph!", 4);
            //Assert.AreEqual("Hello, World!", result);
            Assert.AreEqual("World!", result);
        }

        [TestMethod]
        public void CaesarCipher_dncode_does_not_alter_numbers()
        {
            var result = caesarCipher.Decode("BCD123", 1);
            Assert.AreEqual("ABC123", result);
        }
    }
}
