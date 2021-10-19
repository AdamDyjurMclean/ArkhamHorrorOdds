﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    class OddsDream
    {
        static double totalTokens = 0;
        static double[] winLoss;
        static string result = "";
        public static string ScenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test, int extra, int extra2)
        {
            if (difficulty == 1)
                difficulty--;
            totalTokens = bag.Sum(x => x.Value);
            winLoss = OddsBag.Numbers(bag, skill + bonus, test, star);
            winLoss[1] += bag[15];
            string blessCurse = WinChecker.BlessCurseString(bag, totalTokens);
            if (scenario == 0)
                Beyond(bag, difficulty, skill, bonus, test, extra, extra2);
            if (blessCurse != "")
                result += $"\n {blessCurse}";
            return result;
        }
        private static void Beyond(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int test, int extra, int extra2)
        {
            winLoss = WinChecker.StandardCheck(winLoss, bag, 12, skill + bonus, test, extra2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 13, skill + bonus, test, 2);
            winLoss = WinChecker.StandardCheck(winLoss, bag, 14, skill + bonus, test, 0);
            if (difficulty == 0)
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, (extra + 1) / 2);
            else
                winLoss = WinChecker.StandardCheck(winLoss, bag, 11, skill + bonus, test, extra);
            result = WinChecker.ResultString(winLoss, totalTokens);
            return;
        }
    }
}