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
                    new int[] { 0, 2, 0 },
                    new int[] { 1, 0, 0 },
                    new int[] { 1, 0, 2 },
                    new int[] { 1, 2, 0 },
                    new int[] { 1, 2, 2 },
                    new int[] { 1, 3, 0 },
                    new int[] { 1, 3, 2 },
                    new int[] { 1, 4, 0 },
                    new int[] { 1, 4, 2 },
                    new int[] { 1, 5, 0 },
                    new int[] { 1, 5, 2 }
                };
            if (jaggedArray.Any(x => x.SequenceEqual(new int[] {campaign, scenerio, difficulty })))
                return true;
            return false;
        }
        public static string Label(int campaign, int scenerio, int difficulty)
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
            else if (Enumerable.SequenceEqual(array, new int[] { 1, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 0, 2 }))
                return "Skull Value";
            else if (Enumerable.SequenceEqual(array, new int[] { 1, 2, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 2, 2 }))
                return "Skull Value";
            else if (Enumerable.SequenceEqual(array, new int[] { 1, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 3, 2 }))
                return "Agenda #";
            else if (Enumerable.SequenceEqual(array, new int[] { 1, 4, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 4, 2 }))
                return "Skull Value";
            else if (Enumerable.SequenceEqual(array, new int[] { 1, 5, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 5, 2 }))
                return "Broods";
            return "";
        }
    }
}
