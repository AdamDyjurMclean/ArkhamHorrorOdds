using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class VarriableCheckTests
    {
        [TestMethod]
        public void Check_IsInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check(2, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_IsNotInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check(1, 1, 0);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check2_IsInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check2(3, 6, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check2_IsNotInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check2(4, 1, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check3_IsInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check3(3, 0, 0);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check3_IsNotInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.Check3(4, 1, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckP_IsInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.CheckP(3, 4, 0);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckP_IsNotInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.CheckP(1, 1, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckFlood_IsInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.CheckFlood(6, 5, 0);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckFlood_IsNotInArray_ReturnsTrue()
        {
            bool result = VarriableCheck.CheckFlood(2, 5, 2);
            Assert.IsFalse(result);
        }
    }
}
