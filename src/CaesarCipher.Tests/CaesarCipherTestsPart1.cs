﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class CaesarCipherTestsPart1
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
        public void CaesarCipher_encodes_hello_world_with_4_shift()
        {
            var result = caesarCipher.Encode("Hello, World!", 4);
            Assert.AreEqual("Lipps, Asvph!", result);
        }

        [TestMethod]
        public void CaesarCipher_encode_does_not_alter_numbers()
        {
            var result = caesarCipher.Encode("ABC123", 1);
            Assert.AreEqual("BCD123", result);
        }
        [TestMethod]
        public void CaesarCipher_encode_Rot13()
        {
            var result = caesarCipher.Encode("The Quick Brown Fox Jumps Over The Lazy Dog", 13);
            Assert.AreEqual("Gur Dhvpx Oebja Sbk Whzcf Bire Gur Ynml Qbt", result);
        }
        [TestMethod]
        public void CaesarCipher_encodde_SpecialCharacter_ä()
        {
            var result = caesarCipher.Encode("Käse", 1);
            Assert.AreEqual("Lbftf", result);
        }

    }
}
