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
        public static string ResultString(double[] winLoss, double totalTokens)
        {
            double chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            string result = chance.ToString() + "% to win.";
            return result;
        }
        public static string CultestRedraw(Dictionary<int, int> bag, double totalTokens) //Night S2
        {
            string cultest = Math.Round((bag[12] / totalTokens * 100), 2).ToString();
            string result = $"\n {cultest}% for Cultest redraw.";
            return result;
        }
        public static string ElderThing(Dictionary<int, int> bag, double totalTokens) //Night S3
        {
            string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
            string result = $"\n {elder}% for Elder Thing.";
            return result;
        }
        public static string UnknownElderThing(Dictionary<int, int> bag, double totalTokens) //Dunwitch S1
        {
            string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
            string result = $"\n {elder}% for Elder Thing, unknown result.";
            return result;
        }
        public static string TabletRedraw(Dictionary<int, int> bag, double totalTokens) //Dunwitch S5
        {
            string tablet = Math.Round((bag[13] / totalTokens * 100), 2).ToString();
            string result = $"\n {tablet}% for Tablet redraw.";
            return result;
        }
        public static string TabletChoice(Dictionary<int, int> bag, double totalTokens) //Dunwitch S6
        {
            string tablet = Math.Round((bag[13] / totalTokens * 100), 2).ToString();
            string result = $"\n {tablet}% for Tablet choice.";
            return result;
        }
    }
}
