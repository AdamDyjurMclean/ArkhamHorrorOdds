using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsNotZ
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static double chance = 0;
        static string result = "";
        static string blessCurse = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            blessCurse = "";
            if (bag[17] > 0)
            {
                string blessOdds = Math.Round(bag[17] / totalTokens * 100, 2).ToString();
                blessCurse = blessOdds + "% for bless redraw. ";

            }
            if(bag[18] > 0)
            {
                string curseOdds = Math.Round(bag[18] / totalTokens * 100, 2).ToString();
                blessCurse += $"{curseOdds}% for curse redraw.";
            }
            if (scenario == 0)
                Gathering(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 1)
                Masks(bag, difficulty, skill, bonus, test, extra);
            else
                Devourer(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Gathering(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            if (difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill+bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            if (bag[12] > 0 && difficulty != 0)
            {
                string cultest = Math.Round((bag[12] / totalTokens * 100), 2).ToString();
                result += $"\n {cultest}% for cultest redraw.";
            }
            return;
        }
        private static void Masks(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Devourer(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 5);
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            if(bag[14] > 0)
            {
                string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
                result += $"\n {elder}% for Elder Thing.";
            }
            return;
        }
    }
}