using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsDunwich
    {
        static double totalTokens = 0;
        static double[] winLoss;
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
                Extra(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 1)
                House(bag, difficulty, skill, bonus, test);
            else if(scenario == 2)
                Museum(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 3)
                Essex(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 4)
                Blood(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 5)
                Undimensioned(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 6)
                Doom(bag, difficulty, skill, bonus, test, extra, extra2);
            else
                Lost(bag, difficulty, skill, bonus, test, extra, extra2);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Extra(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, -extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 0);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[14] > 0)
                result += WinChecker.UnknownElderThing(bag, totalTokens);
            return;
        }
        private static void House(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Museum(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 5);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Essex(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0 && difficulty != 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Blood(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, Math.Min(extra, 4));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[13] > 0 && difficulty != 0)
                result += WinChecker.TabletRedraw(bag, totalTokens);
            return;
        }
        private static void Undimensioned(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 5);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            if (bag[13] > 0)
            {
                result += WinChecker.TabletChoice(bag, totalTokens);
            }
            return;
        }
        private static void Doom(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if (difficulty == 0)
            {
                if(extra2 == 2)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                if (extra2 == 2)
                    winLoss[1] += bag[13];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            if (bag[14] > 0)
                result += WinChecker.UnknownElderThing(bag, totalTokens);
            return;
        }
        private static void Lost(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, extra);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, extra2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra2 + extra2);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
    }
}