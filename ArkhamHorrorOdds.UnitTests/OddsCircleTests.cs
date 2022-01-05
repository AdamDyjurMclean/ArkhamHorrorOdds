using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsCircleTests
    {
        [TestMethod]
        public void Estate_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 1}, {18, 1}},
                0, 0, 3, 0, 1, 2, -3);
            Assert.AreEqual("53.33% to win.\n 6.67% for bless redraw. 6.67% for curse redraw.", result);
        }
        [TestMethod]
        public void Hour_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                1, 0, 3, 0, 1, 2, 0);
            Assert.AreEqual("78.57% to win.", result);
        }
        [TestMethod]
        public void Door_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 1, 5, 0, 2, 3, -3);
            Assert.AreEqual("68.75% to win.", result);
        }
        [TestMethod]
        public void Name_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                3, 1, 3, 2, 1, 3, -2);
            Assert.AreEqual("68.75% to win.\n 6.25% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Sin_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 2, 4, 1, 0, 4, 0);
            Assert.AreEqual("29.41% to win.\n 11.76% for Skull redraw.", result);
        }
        [TestMethod]
        public void Good_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 2, 5, 2, 1, 4, 4);
            Assert.AreEqual("60% to win.\n 6.67% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Union_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                6, 3, 3, 3, 1, 2, 0);
            Assert.AreEqual("68.75% to win.\n 12.5% for Skull, unknown result.", result);
        }
        [TestMethod]
        public void Chaos_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 4, 1, 1, 3, 4);
            Assert.AreEqual("37.5% to win.\n 6.25% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Throne_IsCorrect()
        {
            String result = OddsCircle.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                8, 3, 5, 2, 1, 4, 5);
            Assert.AreEqual("50% to win.\n 6.25% for Cultest redraw.", result);
        }
    }
}
