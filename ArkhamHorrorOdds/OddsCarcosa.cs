using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    class OddsCarcosa
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static double chance = 0;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if (scenario == 0)
                Curtain(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 1)
                King(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 2)
                Past(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 3)
                Oath(bag, difficulty, skill, bonus, test, extra, extra2);
            else if (scenario == 4)
                Truth(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Curtain(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
            {
                if (extra >= 3)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, Math.Max(extra, 1));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 5);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void King(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[11] > 0)
                result += WinChecker.SkullRedraw(bag, totalTokens);
            return;
        }
        private static void Past(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Oath(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, extra2);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[14] > 0)
                result += WinChecker.ElderThing(bag, totalTokens);            
            if (bag[11] > 0 && difficulty != 0)
                result += WinChecker.SkullRedraw(bag, totalTokens);
            return;
        }
        private static void Truth(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, Math.Min(extra, 5));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}