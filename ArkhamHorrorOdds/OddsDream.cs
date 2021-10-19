using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    class OddsDream
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2)
        {
            if(difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if(scenario == 0)
                Beyond(bag, difficulty, skill, bonus, test, extra, extra2);
            else if(scenario == 1)
                Nightmare(bag, difficulty, skill, bonus, test, extra, extra2);
            else if(scenario == 2)
                Kadath(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 3)
                Shapes(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 4)
                Moon(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 5)
                Point(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Beyond(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, extra2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, (extra + 1) / 2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Nightmare(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 0);
            if(difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra2 + 1);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Kadath(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, -2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, -1);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Shapes(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, -2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, -1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Moon(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, (extra + 1) / 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, -1);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Point(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, -1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 0);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
    }
}
