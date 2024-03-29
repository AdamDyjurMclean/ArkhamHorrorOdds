﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsInnsmouth
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2, int extra3)
        {
            if(difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if(scenario == 0)
                Pit(bag, difficulty, skill, bonus, test, extra3);
            else if(scenario == 1)
                Elina(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 2)
                Deep(bag, difficulty, skill, bonus, test, extra, extra2);
            else if(scenario == 3)
                Devil(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 4)
                Gear(bag, difficulty, skill, bonus, test, extra);
            else if(scenario == 5)
                Light(bag, difficulty, skill, bonus, test, extra3);
            else if (scenario == 6)
                Dagon(bag, difficulty, skill, bonus, test, extra);
            else if (scenario == 7)
                Maelstrom(bag, difficulty, skill, bonus, test, extra);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Pit(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 3);
            if(difficulty == 0)
            {
                if(extra == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else if(extra == 1)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
            }
            else
            {
                if (extra == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else if (extra == 1)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 4);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Elina(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            if(difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Deep(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra2);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra * 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, extra2 * 2);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Devil(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            }
            else
            {
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra + 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 5);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Gear(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            if(difficulty == 0)
            {
                if(extra > 6)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 1);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            }
            else
            {
                if (extra > 6)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
        private static void Light(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            if(extra == 0)
            {
                if(difficulty == 0)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (extra != 0 && bag[11] > 0)
                result += WinChecker.SkullRedraw(bag, totalTokens);
            return;
        }
        private static void Dagon(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 3);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 4);
            if(difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra * 2);
            result = WinChecker.ResultString(winLoss, totalTokens);
            if (bag[12] > 0)
                result += WinChecker.CultestRedraw(bag, totalTokens);
            return;
        }
        private static void Maelstrom(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra)
        {
            if(difficulty == 0)
            {
                if(extra < 4)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 1);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 3);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 5);
            }
            else
            {
                if (extra < 4)
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 2);
                else
                    winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, 4);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 5);
                winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 6);
            }
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}
