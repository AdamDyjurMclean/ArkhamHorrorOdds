using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class DefaultBags
    {
        public static int[] BagStart(int campaign, int difficulty)
        {
            if(campaign == 0)
                return NotzBags(difficulty);
            else if(campaign == 1)
                return DlBags(difficulty);
            else if(campaign == 2)
                return PtCBags(difficulty);
            else if(campaign == 3)
                return FABags(difficulty);
            else if(campaign == 4)
                return CUBags(difficulty);
            else if (campaign == 5)
                return DEBags(difficulty);
            else if (campaign == 6)
                return ICBags(difficulty);
            return new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        private static int[] NotzBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 2, 1, 1, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 2, 1, 1, 0, 1, 1 };
        }

        private static int[] DlBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 2, 1, 0, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 2, 1, 0, 0, 1, 1 };
        }
        private static int[] PtCBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 3, 0, 0, 0, 1, 1 };
        }
        private static int[] FABags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 2, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 3, 1, 2, 1, 0, 1, 0, 0, 0, 2, 0, 0, 1, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 1, 2, 1, 1, 2, 1, 0, 1, 0, 0, 2, 0, 0, 1, 1, 1 };
            else
                return new int[] { 0, 1, 1, 2, 2, 2, 0, 1, 0, 1, 2, 0, 0, 1, 1, 1 };
        }
        private static int[] CUBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 2, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 2, 2, 1, 1, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 2, 2, 2, 2, 1, 1, 0, 0, 0, 2, 0, 0, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 1, 1, 0, 1, 0, 1, 2, 0, 0, 0, 1, 1 };
        }
        private static int[] DEBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 2, 2, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 2, 2, 1, 1, 0, 0, 0, 0, 0, 1, 2, 0, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 2, 2, 2, 2, 1, 1, 0, 0, 0, 0, 1, 2, 0, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 1, 2, 1, 1, 0, 1, 0, 1, 2, 0, 1, 1 };
        }
        private static int[] ICBags(int difficulty)
        {
            if(difficulty == 0)
                return new int[] { 2, 3, 3, 2, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1 };
            else if(difficulty == 1)
                return new int[] { 1, 2, 3, 2, 1, 1, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1 };
            else if(difficulty == 2)
                return new int[] { 0, 3, 2, 2, 2, 1, 1, 0, 0, 0, 2, 2, 2, 2, 1, 1 };
            else
                return new int[] { 0, 1, 2, 2, 2, 2, 1, 1, 0, 1, 2, 2, 2, 2, 1, 1 };
        }
    }
}
