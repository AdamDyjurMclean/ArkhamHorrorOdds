using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArkhamHorrorOdds.UnitTests
{
    [TestClass]
    public class OddsNotZTests
    {
        [TestMethod]
        public void Scenario1_Test1_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}}, 
                0, 0, 2, 2, 1, 3, 2);
            Assert.AreEqual("62.5% to win.", result);
        }
        [TestMethod]
        public void Scenario1_Test2_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 1}, {0, 2}, {-1, 3}, {-2, 2}, {-3, 1}, {-4, 1}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 0}, {15, 1}, {16, 1}, {17, 1}, {18, 0}},
                0, 1, 2, 2, 1, 3, 2);
            Assert.AreEqual("47.06% to win.\n 5.88% for bless redraw. ", result);
        }
        [TestMethod]
        public void Scenario2_Test1_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 3}, {-1, 2 }, {-2, 2}, {-3, 2}, {-4, 1}, {-5, 1}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 0}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                1, 2, 4, 2, 1, 3, 2);
            Assert.AreEqual("76.47% to win.", result);
        }
        [TestMethod]
        public void Scenario2_Test2_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 0}, {0, 1}, {-1, 2 }, {-2, 2}, {-3, 2}, {-4, 2}, {-5, 1}, {-6, 1}, {-7, 0}, {-8, 1},
                {11, 2}, {12, 1}, {13, 1}, {14, 0}, {15, 1}, {16, 1}, {17, 1}, {18, 1}},
                1, 3, 4, 2, 1, 3, 2);
            Assert.AreEqual("55% to win.\n 5% for bless redraw. 5% for curse redraw.", result);
        }
        [TestMethod]
        public void Scenario3_Test1_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 0, 4, 2, 1, 3, 2);
            Assert.AreEqual("88.24% to win.\n 5.88% for Elder Thing.", result);
        }
        [TestMethod]
        public void Scenario3_Test2_IsCorrect()
        {
            String result = OddsNotZ.ScenarioCheck(new Dictionary<int, int>(){
                {1, 2}, {0, 3}, {-1, 3}, {-2, 2}, {-3, 0}, {-4, 0}, {-5, 0}, {-6, 0}, {-7, 0}, {-8, 0},
                {11, 2}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 0}, {18, 0}},
                2, 2, 4, 2, 1, 3, 2);
            Assert.AreEqual("76.47% to win.\n 5.88% for Elder Thing.", result);
        }
    }
}
