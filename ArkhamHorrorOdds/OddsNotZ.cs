﻿using System;
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
        public static string scenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra)
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
                return gathering(bag, difficulty, skill, bonus, star, test, extra);
            return "";
        }
        public static string gathering(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int star, int test, int extra)
        {
            if(difficulty == 0)
            {
                if (Math.Max(skill + bonus - extra, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill - 1, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill - 2, 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                if (Math.Max(skill, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[15];
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
                if (Math.Max(skill + bonus, 0) >= test)
                    winLoss[0] += bag[14];
                winLoss[1] += bag[15];
                chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
                result = chance.ToString() + "% to win.";
                string cultest = Math.Round((bag[12] / totalTokens * 100), 2).ToString();
                result += $"\n {cultest}% for cultest redraw.";
            }
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
    }
}
