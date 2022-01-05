using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsCarcosaTests
    {
        [TestMethod]
        public void Curtain_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 0}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 3, 0, 1, 2, 1, 0, 0);
            Assert.AreEqual("80% to win.", result);
        }
        [TestMethod]
        public void King_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 0}, {13, 2}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                1, 1, 3, 2, 2, 3, 2, 0, 0);
            Assert.AreEqual("52.94% to win.\n 17.65% for Skull redraw.", result);
        }
        [TestMethod]
        public void Past_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 2}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 2, 5, 1, 1, 3, 3, 0, 0);
            Assert.AreEqual("72.22% to win.", result);
        }
        [TestMethod]
        public void Oath_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 3}, {12, 0}, {13, 0}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                3, 3, 2, 2, 1, 2, 2, 3, 0);
            Assert.AreEqual("31.58% to win.\n 10.53% for Elder Thing.\n 15.79% for Skull redraw.", result);
        }
        [TestMethod]
        public void Truth_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 2}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 0, 2, 2, 1, 2, 3, 0, 0);
            Assert.AreEqual("76.47% to win.", result);
        }
        [TestMethod]
        public void Mask_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 0}, {13, 0}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 1, 1, 3, 0, 2, 3, 0, 0);
            Assert.AreEqual("52.94% to win.", result);
        }
        [TestMethod]
        public void Stars_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 3}, {12, 0}, {13, 2}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                6, 2, 4, 2, 1, 3, 2, 0, 1);
            Assert.AreEqual("72.22% to win.\n 11.11% for Tablet redraw.", result);
        }
        [TestMethod]
        public void Dim_IsCorrect()
        {
            String result = OddsCarcosa.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 3}, {12, 2}, {13, 0}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 4, 0, 0, 2, 3, 0, 0);
            Assert.AreEqual("31.58% to win.", result);
        }
    }
}
