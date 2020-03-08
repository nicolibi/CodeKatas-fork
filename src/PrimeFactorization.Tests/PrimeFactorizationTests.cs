using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactorization.Tests
{
    [TestClass]
    public class PrimeFactorizationTests
    {
        private PrimeFactorization PrimeFactorization;
        private List<int> GenerateCompareList(params int[] factors)
        {
            List<int> PrimefactorCompare = new List<int>();
            for (int i = 0; i < factors.Length; i++)
            {
                PrimefactorCompare.Add(factors[i]);
            }
            return PrimefactorCompare;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            PrimeFactorization = new PrimeFactorization();
        }


        [TestCleanup]
        public void TestCleanup()
        {
            PrimeFactorization = null;
        }

        [TestMethod]
        public void PrimeFactorization_2_returns_2()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(2);
            List<int> expectedResult = GenerateCompareList(2);
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PrimeFactorization_4_returns_2_2()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(4);
            List<int> expectedResult = GenerateCompareList(2, 2);
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PrimeFactorization_6_returns_2_3()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(6);
            List<int> expectedResult = GenerateCompareList(2, 3);
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PrimeFactorization_8_returns_2_2_2()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(8);
            List<int> expectedResult = GenerateCompareList(2, 2, 2);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PrimeFactorization_9_returns_3_3()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(9);
            List<int> expectedResult = GenerateCompareList(3, 3);
            CollectionAssert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void PrimeFactorization_18_returns_2_3_3()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(18);
            List<int> expectedResult = GenerateCompareList(2, 3, 3);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PrimeFactorization_30_returns_5_6()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(6);
            List<int> expectedResult = GenerateCompareList(2, 3);
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PrimeFactorization_31_returns_31()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(31);
            List<int> expectedResult = GenerateCompareList(31);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PrimeFactorization_32_returns_5x2()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(32);
            List<int> expectedResult = GenerateCompareList(2, 2, 2, 2, 2);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PrimeFactorization_33_returns_3_11()
        {
            List<int> result = PrimeFactorization.GetPrimeFactors(33);
            List<int> expectedResult = GenerateCompareList(3, 11);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
