using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsBag
    {
        static int skill = 0;
        static int test = 0;
        private static bool Check( int value)
        {
            if(Math.Max(skill + value, 0) >= test)
                return true;
            else
                return false;
        }
        public static double[] Numbers(Dictionary<int, int> bag, int skillValue, int testValue, int star)
        {
            int wins = 0;
            int losses = 0;
            skill = skillValue;
            test = testValue;
            for(int i = -8; i <= 1; i++)
            {
                if (Check(i))
                    wins += bag[i];
                else
                    losses += bag[i];
            }
            if(Check(star))
                wins += bag[16];
            else
                losses += bag[16];
            return new double[] { wins, losses };
        }
    }
}
