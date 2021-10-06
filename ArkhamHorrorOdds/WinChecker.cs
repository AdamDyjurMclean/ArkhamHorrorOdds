using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class WinChecker
    {
        public static string BlessCurseString(Dictionary<int, int> bag, double totalTokens)
        {
            string result = "";
            if (bag[17] > 0)
            {
                string blessOdds = Math.Round(bag[17] / totalTokens * 100, 2).ToString();
                result = blessOdds + "% for bless redraw. ";

            }
            if (bag[18] > 0)
            {
                string curseOdds = Math.Round(bag[18] / totalTokens * 100, 2).ToString();
                result += $"{curseOdds}% for curse redraw.";
            }
            return result;
        }
        public static double[] StandardCheck(double[] winLoss, Dictionary<int, int> bag, int token, int skill, int test, int reduce)
        {
            if (Math.Max(skill - reduce, 0) >= test)
                winLoss[0] += bag[token];
            else
                winLoss[1] += bag[token];
            return winLoss;
        }
    }
}
