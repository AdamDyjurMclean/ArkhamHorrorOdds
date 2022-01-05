using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsDunwichTests
    {
        [TestMethod]
        public void Extra_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 3, 2, 2, 3, -3, 0);
            Assert.AreEqual("86.67% to win.", result);
        }
        [TestMethod]
        public void House_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 1}, {18, 0}},
                1, 1, 3, 4, 1, 4, 0, 0);
            Assert.AreEqual("82.35% to win.\n 5.88% for bless redraw. ", result);
        }
        [TestMethod]
        public void Museum_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 2}},
                2, 2, 3, 1, 1, 3, -3, 0);
            Assert.AreEqual("33.33% to win.\n 11.11% for curse redraw.", result);
        }
        [TestMethod]
        public void Essex_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 1}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 1}, {18, 2}},
                3, 3, 3, 2, 1, 2, 2, 0);
            Assert.AreEqual("50% to win.\n 5% for Cultest redraw.\n 5% for bless redraw. 10% for curse redraw.", result);
        }
        [TestMethod]
        public void Blood_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 0, 2, 2, 1, 3, -4, 0);
            Assert.AreEqual("68.75% to win.", result);
        }
        [TestMethod]
        public void Undimensioned_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 1, 1, 4, 1, 3, 2, 0);
            Assert.AreEqual("68.75% to win.\n 6.25% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Doom_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                6, 2, 4, 2, 1, 4, -3, 3);
            Assert.AreEqual("42.11% to win.\n 5.26% for Cultest redraw.\n 5.26% for Elder Thing, unknown result.", result);
        }
        [TestMethod]
        public void Lost_IsCorrect()
        {
            String result = OddsDunwich.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 3}, {12, 2}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 4, 4, 1, 4, -2, 3);
            Assert.AreEqual("52.38% to win.\n 9.52% for Cultest redraw.", result);
        }
    }
}
