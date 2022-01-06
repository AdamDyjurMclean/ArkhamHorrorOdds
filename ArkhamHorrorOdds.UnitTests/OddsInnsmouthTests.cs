using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsInnsmouthTests
    {
        [TestMethod]
        public void Pit_Unflooded_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 3, 2, 2, 3, -3, 0, 0);
            Assert.AreEqual("85% to win.", result);
        }
        [TestMethod]
        public void Pit_Flooded_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                0, 0, 3, 2, 2, 3, -3, 0, 2);
            Assert.AreEqual("75% to win.", result);
        }
        [TestMethod]
        public void Elina_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                1, 0, 2, 3, 1, 3, 2, 0, 0);
            Assert.AreEqual("75% to win.", result);
        }
        [TestMethod]
        public void Deep_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 1}, {18, 2}},
                2, 1, 2, 4, 1, 3, 2, 4, 0);
            Assert.AreEqual("69.57% to win.\n 4.35% for bless redraw. 8.7% for curse redraw.", result);
        }
        [TestMethod]
        public void Devil_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                3, 1, 4, 2, 1, 4, 3, 4, 0);
            Assert.AreEqual("55% to win.", result);
        }
        [TestMethod]
        public void Gear_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                4, 2, 3, 2, 1, 2, 8, 0, 0);
            Assert.AreEqual("76.19% to win.", result);
        }
        [TestMethod]
        public void Light_Unflooded_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 2, 3, 2, 1, 3, 0, 0, 0);
            Assert.AreEqual("57.14% to win.", result);
        }
        [TestMethod]
        public void Light_PartiallyFlooded_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                5, 2, 3, 2, 1, 3, 0, 0, 1);
            Assert.AreEqual("47.62% to win.\n 9.52% for Skull redraw.", result);
        }
        [TestMethod]
        public void Dagon_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                6, 3, 1, 4, 0, 2, 2, 0, 0);
            Assert.AreEqual("45.45% to win.\n 9.09% for Cultest redraw.", result);
        }
        [TestMethod]
        public void Maelstrom_IsCorrect()
        {
            String result = OddsInnsmouth.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2}, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 2}, {13, 2}, {14, 2}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                7, 3, 5, 2, 1, 4, 2, 0, 0);
            Assert.AreEqual("45.45% to win.", result);
        }
    }
}
