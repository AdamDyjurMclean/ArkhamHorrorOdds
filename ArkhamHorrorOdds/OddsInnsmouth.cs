using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    class OddsInnsmouth
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if (scenario == 0)
                Pit(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Pit(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            if(difficulty == 0)
            {
                if(extra == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else if(extra == 1)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
            }
            else
            {
                if (extra == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else if (extra == 1)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}
