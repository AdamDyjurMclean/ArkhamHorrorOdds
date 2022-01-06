using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsDreamTest
    {
        [TestMethod]
        public void Beyond_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 2}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 3, 2, 1, 2, 4, 5);
            Assert.AreEqual("87.5% to win.", result);
        }
        [TestMethod]
        public void Nightmare_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 2}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                1, 0, 3, 2, 1, 2, -4, 5);
            Assert.AreEqual("75% to win.\n 6.25% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Kadath_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 1}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 1, 4, 2, 1, 3, 4, 0);
            Assert.AreEqual("66.67% to win.\n 5.56% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Shapes_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 1}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                3, 1, 3, 4, 2, 4, -4, 0);
            Assert.AreEqual("66.67% to win.\n 5.56% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Moon_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 1}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 2, 5, 0, 1, 2, 3, 0);
            Assert.AreEqual("78.95% to win.\n 5.26% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Point_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 2}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 1}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 2, 5, 0, 1, 2, 3, 0);
            Assert.AreEqual("57.89% to win.\n 5.26% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Gods_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 3}, {12, 1}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 1}, {18, 1}},
                6, 3, 4, 3, 1, 3, 2, 2);
            Assert.AreEqual("60.87% to win.\n 4.35% for Cultest redraw.\n 4.35% for bless redraw. 4.35% for curse redraw.", result);
        }
        [TestMethod]
        public void Weaver_IsCorrect()
        {
            String result = OddsDream.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 1}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 3}, {12, 1}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 4, 3, 1, 3, 2, 0);
            Assert.AreEqual("76.19% to win.\n 4.76% for Cultest redraw.", result);
        }
    }
}
