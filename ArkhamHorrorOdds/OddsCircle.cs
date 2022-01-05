using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsCircle
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra)
        {
            if(difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            if(scenario == 0)
                Estate(bag, difficulty, skill, bonus, test);
            else if(scenario == 1)
                Hour(bag, difficulty, skill, bonus, test);
            else if(scenario == 2)
                Door(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 3)
                Name(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 4)
                Sin(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 5)
                Good(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 6)
                Union(bag, difficulty, skill, bonus, test);
            else if(scenario == 7)
                Chaos(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 8)
                Throne(bag, difficulty, skill, bonus, test, extra);
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if(blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Estate(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if(difficulty == 0)
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
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Door(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 0);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Name(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Sin(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[11] > 0 && difficulty != 0)
                result += WinChecker.SkullRedraw(bag, totalTokens);
            return;
        }
        private static void Good(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            if(difficulty != 0)
            {
                if(bag[13] > 0)
                    result += WinChecker.UnknownTablet(bag, totalTokens);
                if(bag[14] > 0)
                    result += WinChecker.UnknownElderThing(bag, totalTokens);
            }
            return;
        }
        private static void Union(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[11] > 0)
                result += WinChecker.UnknownSkull(bag, totalTokens);
            return;
        }
        private static void Chaos(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Throne(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, Math.Max((extra + 1) / 2, 2));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, Math.Max(extra, 2));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 6);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if(bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
    }
}