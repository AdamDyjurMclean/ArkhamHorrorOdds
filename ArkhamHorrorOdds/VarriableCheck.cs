﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class VarriableCheck
    {
        public static bool Check(int campaign, int scenerio, int difficulty)
        {
            if (difficulty == 1 || difficulty == 3)
                difficulty--;
            int[][] jaggedArray =
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 0, 1, 2 },
                    new int[] { 0, 2, 0 }
                };
            if (jaggedArray.Any(x => x.SequenceEqual(new int[] {campaign, scenerio, difficulty })))
                return true;
            return false;
        }
        public static string label(int campaign, int scenerio, int difficulty)
        {
            if (difficulty == 1 || difficulty == 3)
                difficulty--;
            int[] array = new int[] { campaign, scenerio, difficulty };
            if (Enumerable.SequenceEqual(array, new int[] { 0, 0, 0 }))
                return "Ghouls";
            else if (Enumerable.SequenceEqual(array, new int[] { 0, 1, 0 }))
                return "Highest Doom";
            else if (Enumerable.SequenceEqual(array, new int[] { 0, 1, 2 }))
                return "Total Doom";
            else if (Enumerable.SequenceEqual(array, new int[] { 0, 2, 0 }))
                return "Monsters";
            return "";
        }
    }
}
