using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class DefaultBags
    {
        public static int[] bagStart(int campaign, int difficulty)
        {
            if (campaign == 0)
                return notzBags(difficulty);
            else if (campaign == 1)
                return dlBags(difficulty);
            return new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        private static int[] notzBags(int difficulty)
        {
            if (difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 2, 1, 1, 0, 1, 1 };
        }

        private static int[] dlBags(int difficulty)
        {
            if (difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else if (difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else if (difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 2, 0, 0, 0, 1, 1 };
        }
    }
}
