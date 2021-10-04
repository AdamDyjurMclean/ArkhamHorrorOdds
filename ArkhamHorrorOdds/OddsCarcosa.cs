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
            blessCurse = "";
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
                Curtain(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Curtain(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (difficulty == 0)
            {
                if (extra >= 3)
                {
                    if (Math.Max(skill + bonus - 3, 0) >= test)
                        winLoss[0] += bag[11];
                    else
                        winLoss[1] += bag[11];
                }
                else
                {
                    if (Math.Max(skill + bonus - 1, 0) >= test)
                        winLoss[0] += bag[11];
                    else
                        winLoss[1] += bag[11];
                }
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[12] + bag[13] + bag[14];
                else
                    winLoss[1] += bag[12] + bag[13] + bag[14];
            }
            else
            {
                if (Math.Max(skill + bonus - Math.Max(1, extra), 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - 5, 0) >= test)
                    winLoss[0] += bag[12] + bag[13] + bag[14];
                else
                    winLoss[1] += bag[12] + bag[13] + bag[14];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
    }
}
