using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class TokenNumberTests
    {
        [TestMethod]
        public void One_IsCorrect()
        {
            int result = TokenNumber.Convert(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Five_IsCorrect()
        {
            int result = TokenNumber.Convert(6);
            Assert.AreEqual(-5, result);
        }
        [TestMethod]
        public void Six_IsCorrect()
        {
            int result = TokenNumber.Convert(7);
            Assert.AreEqual(-6, result);
        }
        [TestMethod]
        public void Eight_IsCorrect()
        {
            int result = TokenNumber.Convert(9);
            Assert.AreEqual(-8, result);
        }
    }
}
