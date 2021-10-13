using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    class OddsCircle
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            if (scenario == 0)
                Estate(bag, difficulty, skill, bonus, test);
            else if (scenario == 1)
                Hour(bag, difficulty, skill, bonus, test);
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            return result;
        }
        private static void Estate(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Hour(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}