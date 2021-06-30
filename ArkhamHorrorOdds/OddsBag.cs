using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsBag
    {
        public static int[] numbers(Dictionary<int, int> bag, int skill, int test, int star)
        {
            int wins = 0;
            int losses = 0;
            if (skill + 1 >= test)
                wins += bag[1];
            else
                losses += bag[1];
            if (skill >= test)
                wins += bag[0];
            else
                losses += bag[0];
            if (skill - 1 >= test)
                wins += bag[-1];
            else
                losses += bag[-1];
            if (skill - 2 >= test)
                wins += bag[-2];
            else
                losses += bag[-2];
            if (skill - 3 >= test)
                wins += bag[-3];
            else
                losses += bag[-3];
            if (skill - 4 >= test)
                wins += bag[-2];
            else
                losses += bag[-4];
            if (skill - 5 >= test)
                wins += bag[-5];
            else
                losses += bag[-5];
            if (skill - 6 >= test)
                wins += bag[-6];
            else
                losses += bag[-6];
            if (skill - 7 >= test)
                wins += bag[-7];
            else
                losses += bag[-7];
            if (skill - 8 >= test)
                wins += bag[-8];
            else
                losses += bag[-8];
            if (skill + star >= test)
                wins += bag[16];
            else
                losses += bag[16];
            return new int[]{ wins, losses };
        }
    }
}
