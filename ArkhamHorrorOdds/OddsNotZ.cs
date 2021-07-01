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
            if (totalTokens == 0)
            {
                if (skill + bonus >= test)
                    return "1";
                else
                    return "0";
            }
            winLoss = OddsBag.numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            if(bag[17] > 0)
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
            result = chance.ToString() + "% to win.";
            if (Math.Max(skill + bonus, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            winLoss[1] += bag[15];
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
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
                result = chance.ToString() + "% to win.";
                string cultest = Math.Round((bag[12] / totalTokens * 100), 2).ToString();
                result += $"\n {cultest}% for cultest redraw.";
            }
            return;
        }
        private static void Masks(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus - extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (Math.Max(skill + bonus - 2, 0) >= test)
                winLoss[0] += bag[12];
            else
                winLoss[1] += bag[12];
            if (Math.Max(skill + bonus, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            winLoss[1] += bag[15];
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
            }
            else
            {
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
        }
        private static void Devourer(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                if (Math.Max(skill + bonus - extra, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
            }
            else
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - 5, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            if(bag[15] > 0)
            {
                string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
                result += $"\n {elder}% for Elder Thing redraw.";
            }
        }
    }
}
