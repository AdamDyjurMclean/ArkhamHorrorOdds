using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsForgotten
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2, int extra3, int extra4)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if (scenario == 0)
                Wild(bag, difficulty, skill, bonus, test, extra, extra2, extra3, extra4);
            else if(scenario == 1)
                Doom(bag, skill, bonus, test, extra, extra2);
            else if (scenario == 2)
                Threads(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 3)
                Boundary(bag, skill, bonus, test, extra);
            else if (scenario == 4)
                Heart(bag, difficulty, skill, bonus, test, extra, extra4);
            else if (scenario == 5)
                Archives(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 6)
                Yoth(bag, difficulty, skill, bonus, test, extra, extra2);
            else if (scenario == 7)
                Aeons(bag, difficulty, skill, bonus, test, extra, extra4);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Wild(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2, int extra3, int extra4)
        {
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, Math.Min(extra2, 5));
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, Math.Min(extra3, 5));
                if (extra4 == 1)
                    winLoss[1] += bag[14];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, extra2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, Math.Max(extra3, 3));
                if (extra4 == 1)
                    winLoss[1] += bag[14];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Doom(Dictionary<int, int> bag, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, extra2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, extra2);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[14] > 0)
                result += WinChecker.UnknownElderThing(bag, totalTokens);
            return;
        }
        private static void Threads(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Boundary(Dictionary<int, int> bag, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            if (bag[13] > 0)
                result += WinChecker.TabletRedraw(bag, totalTokens);
            return;
        }
        private static void Heart(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra4)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Archives(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            if (difficulty == 0)
            {
                if(extra < 5)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
            }
            else
            {
                if (extra < 5)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else
                    winLoss[1] += bag[11];
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Yoth(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            if (extra2 > 2)
                winLoss[1] += bag[14];
            else
            {
                if (difficulty == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            if (bag[13] > 0)
                result += WinChecker.TabletRedraw(bag, totalTokens);
            return;
        }
        private static void Aeons(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra4)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, -extra);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 2);
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}