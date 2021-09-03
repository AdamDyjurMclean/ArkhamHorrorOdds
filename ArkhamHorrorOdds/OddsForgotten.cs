﻿using System;
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
        static double chance = 0;
        static string result = "";
        static string blessCurse = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2, int extra3, int extra4)
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
                if (Math.Max(skill + bonus - extra, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - Math.Min(extra2, 5), 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - Math.Min(extra3, 5), 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                if(extra4 == 1)
                    winLoss[1] += bag[14];
                else
                {
                    if (Math.Max(skill + bonus - 2, 0) >= test)
                        winLoss[0] += bag[14];
                    else
                        winLoss[1] += bag[14];
                }
            }
            else
            {
                if (Math.Max(skill + bonus - extra - 1, 0) >= test)
                    winLoss[0] += bag[11];
                else
                    winLoss[1] += bag[11];
                if (Math.Max(skill + bonus - extra2, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if (Math.Max(skill + bonus - Math.Max(extra3, 3), 0) >= test)
                    winLoss[0] += bag[13];
                else
                    winLoss[1] += bag[13];
                if (extra4 == 1)
                    winLoss[1] += bag[14];
                else
                {
                    if (Math.Max(skill + bonus - 3, 0) >= test)
                        winLoss[0] += bag[14];
                    else
                        winLoss[1] += bag[14];
                }
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Doom(Dictionary<int, int> bag, int skill, int bonus, int test, int extra, int extra2)
        {
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (Math.Max(skill + bonus - extra2, 0) >= test)
                winLoss[0] += (bag[12] + bag[13]);
            else
                winLoss[1] += (bag[12] + bag[13]);
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            if (bag[14] > 0)
            {
                string elder = Math.Round((bag[14] / totalTokens * 100), 2).ToString();
                result += $"\n {elder}% for Elder Thing, unknown result.";
            }
            return;
        }
        private static void Threads(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus - extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (Math.Max(skill + bonus - 2, 0) >= test)
                winLoss[0] += bag[12] + bag[13];
            else
                winLoss[1] += bag[12] + bag[13];
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[14];
            }
            else
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[14];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Boundary(Dictionary<int, int> bag, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (Math.Max(skill + bonus - 4, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.\n";
            if (bag[12] > 0)
            {
                string cultestOdds = Math.Round(bag[12] / totalTokens * 100, 2).ToString();
                result += $"{cultestOdds}% for cultest redraw.";
            }
            if (bag[13] > 0)
            {
                string cultestOdds = Math.Round(bag[13] / totalTokens * 100, 2).ToString();
                result += $" {cultestOdds}% for tablet redraw.";
            }
            return;
        }
        private static void Heart(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra4)
        {
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[12];
                else
                    winLoss[1] += bag[12];
                if(extra4 == 1)
                    winLoss[1] += bag[13];
                else
                {
                    if (Math.Max(skill + bonus - 2, 0) >= test)
                        winLoss[0] += bag[13];
                    else
                        winLoss[1] += bag[13];
                }
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
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                {
                    if (Math.Max(skill + bonus - 3, 0) >= test)
                        winLoss[0] += bag[13];
                    else
                        winLoss[1] += bag[13];
                }
                if (Math.Max(skill + bonus - 4, 0) >= test)
                    winLoss[0] += bag[14];
                else
                    winLoss[1] += bag[14];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Archives(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if (Math.Max(skill + bonus - 2, 0) >= test)
                winLoss[0] += bag[12] + bag[13];
            else
                winLoss[1] += bag[12] + bag[13];
            if (Math.Max(skill + bonus - 3, 0) >= test)
                winLoss[0] += bag[14];
            else
                winLoss[1] += bag[14];
            if (difficulty == 0)
            {
                if(extra < 5)
                {
                    if (Math.Max(skill + bonus - 1, 0) >= test)
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
            }
            else
            {
                if (extra < 5)
                {
                    if (Math.Max(skill + bonus - 2, 0) >= test)
                        winLoss[0] += bag[11];
                    else
                        winLoss[1] += bag[11];
                }
                else
                    winLoss[1] += bag[11];
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.";
            return;
        }
        private static void Yoth(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            if (Math.Max(skill + bonus - extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (extra2 > 2)
                winLoss[1] += bag[14];
            else
            {
                if (difficulty == 0)
                {
                    if (Math.Max(skill + bonus - 2, 0) >= test)
                        winLoss[0] += bag[14];
                    else
                        winLoss[1] += bag[14];
                }
                else
                {
                    if (Math.Max(skill + bonus - 4, 0) >= test)
                        winLoss[0] += bag[14];
                    else
                        winLoss[1] += bag[14];
                }
            }
            chance = Math.Round(winLoss[0] / totalTokens * 100, 2);
            result = chance.ToString() + "% to win.\n";
            if (bag[12] > 0)
            {
                string cultestOdds = Math.Round(bag[12] / totalTokens * 100, 2).ToString();
                result += $"{cultestOdds}% for cultest redraw.";
            }
            if (bag[13] > 0)
            {
                string cultestOdds = Math.Round(bag[13] / totalTokens * 100, 2).ToString();
                result += $" {cultestOdds}% for tablet redraw.";
            }
            return;
        }
        private static void Aeons(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra4)
        {
            if (Math.Max(skill + bonus + extra, 0) >= test)
                winLoss[0] += bag[11];
            else
                winLoss[1] += bag[11];
            if (difficulty == 0)
            {
                if (Math.Max(skill + bonus - 2, 0) >= test)
                    winLoss[0] += bag[12] + bag[14];
                else
                    winLoss[1] += bag[12] + bag[14];
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                {
                    if (Math.Max(skill + bonus - 2, 0) >= test)
                        winLoss[0] += bag[13];
                    else
                        winLoss[1] += bag[13];
                }
            }
            else
            {
                if (Math.Max(skill + bonus - 3, 0) >= test)
                    winLoss[0] += bag[12] + bag[14];
                else
                    winLoss[1] += bag[12] + bag[14];
                if (extra4 == 1)
                    winLoss[1] += bag[13];
                else
                {
                    if (Math.Max(skill + bonus - 3, 0) >= test)
                        winLoss[0] += bag[13];
                    else
                        winLoss[1] += bag[13];
                }
            }
        }
    }
}
