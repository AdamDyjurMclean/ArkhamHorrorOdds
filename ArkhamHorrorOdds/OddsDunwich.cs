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
        static double chance = 0;
        static string result = "";
        static string blessCurse = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            if (totalTokens == 0)
            {
                if (skill + bonus >= test)
                    return "1";
                else
                    return "0";
            }
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            if (bag[17] > 0)
            {
                string blessOdds = Math.Round(bag[17] / totalTokens * 100, 2).ToString();
                blessCurse = blessOdds + "% for bless redraw. ";

            }
            if (bag[18] > 0)
            {
                string curseOdds = Math.Round(bag[18] / totalTokens * 100, 2).ToString();
                blessCurse += $"{curseOdds}% for curse redraw.";
            }
            if (scenario == 0)
                Extra(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 1)
                House(bag, difficulty, skill, bonus, test);
            else if(scenario == 2)
                Museum(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 3)
                Essex(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Extra(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 1, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
            }
            else
            {
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
            }
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[12];
            else
                winLoss[1] += bag[12];
            if (Math.Max(skill + bonus, 0) >= test)
                winLoss[0] += bag[13];
            else
                winLoss[1] += bag[13];
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            if (bag[14] > 0)
            {
                string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
                result += $"\n {elder}% for Elder Thing, unknown result.";
            }
            return;
        }
        private static void House(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test)
        {
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
            }
            else
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
            }
            if (Math.Max(skill + bonus - 3, 0) >= test)
                winLoss[0] += bag[12];
            else
                winLoss[1] += bag[12];
            if (Math.Max(skill + bonus - 2, 0) >= test)
                winLoss[0] += bag[13];
            else
                winLoss[1] += bag[13];
            if (Math.Max(skill + bonus, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Museum(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if(difficulty == 0)
            {
                if (Math.Max(skill + bonus - 1, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[14];
            }
            else
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                if (Math.Max(skill + bonus - 5, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[14];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Essex(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus - 3, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - extra, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 1, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
                result = chance.ToString() + "% to win.";
            }
            else
            {
                if (Math.Max(skill + bonus - extra - 1, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
                result = chance.ToString() + "% to win.";
                if (bag[12] > 0)
                {
                    string cultestOdds = Math.Round(bag[12] / totalTokens * 100, 2).ToString();
                    blessCurse += $"{cultestOdds}% for curse redraw.";
                }
            }
        }
    }
}
