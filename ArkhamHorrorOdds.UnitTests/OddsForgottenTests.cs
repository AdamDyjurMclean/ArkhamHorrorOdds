using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsForgottenTests
    {
        [TestMethod]
        public void Wild_NoPoison_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 4, 0, 1, 2, 3, 2, 3, 0);
            Assert.AreEqual("71.43% to win.", result);
        }
        [TestMethod]
        public void Wild_Poison_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 4, 0, 1, 2, 3, 2, 3, 1);
            Assert.AreEqual("64.29% to win.", result);
        }
        [TestMethod]
        public void Doom_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 3}, {-1, 1}, {-2, 2}, {-3, 1}, {-4, 0}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 1}, {18, 0}},
                1, 1, 5, 2, 1, 4, -3, 3, 0, 0);
            Assert.AreEqual("75% to win.\n 6.25% for Elder Thing, unknown result.\n 6.25% for bless redraw. ", result);
        }
        [TestMethod]
        public void Threads_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 1}, {-2, 1}, {-3, 2}, {-4, 1}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 2, 3, 3, 1, 3, 2, 0, 0, 0);
            Assert.AreEqual("81.25% to win.", result);
        }
        [TestMethod]
        public void Boundary_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 1}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 0}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                3, 3, 2, 3, 1, 2, -2, 0, 0, 0);
            Assert.AreEqual("52.94% to win.\n 11.76% for Tablet redraw.", result);
        }
        [TestMethod]
        public void Heart_NoPoison_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 0, 3, 1, 1, 2, -2, 0, 0, 0);
            Assert.AreEqual("81.25% to win.", result);
        }
        [TestMethod]
        public void Heart_Poison_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 2}, {-2, 1}, {-3, 1}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 2}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 0, 3, 1, 1, 2, -2, 0, 0, 1);
            Assert.AreEqual("68.75% to win.", result);
        }
        [TestMethod]
        public void Archives_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 3}, {-1, 1}, {-2, 2}, {-3, 1}, {-4, 0}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 0}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 1}},
                5, 1, 2, 2, 1, 2, 4, 0, 0, 0);
            Assert.AreEqual("68.75% to win.\n 6.25% for curse redraw.", result);
        }
        [TestMethod]
        public void Yoth_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 1}, {-2, 1}, {-3, 2}, {-4, 1}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                6, 2, 4, 2, 1, 3, 3, 4, 0, 0);
            Assert.AreEqual("62.5% to win.\n 12.5% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Aeons_IsCorrect()
        {
            String result = OddsForgotten.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 1}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 0}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 3}, {13, 0}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 2, 3, 1, 2, -3, 0, 0, 0);
            Assert.AreEqual("72.22% to win.", result);
        }
    }
}
