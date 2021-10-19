using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsBag
    {
        public static double[] Numbers(Dictionary<int, int> bag, int skill, int test, int star)
        {
            int wins = 0;
            int losses = 0;
            if(Math.Max(skill + 1, 0) >= test)
                wins += bag[1];
            else
                losses += bag[1];
            if(Math.Max(skill, 0) >= test)
                wins += bag[0];
            else
                losses += bag[0];
            if(Math.Max(skill - 1, 0) >= test)
                wins += bag[-1];
            else
                losses += bag[-1];
            if(Math.Max(skill - 2, 0) >= test)
                wins += bag[-2];
            else
                losses += bag[-2];
            if(Math.Max(skill - 3, 0) >= test)
                wins += bag[-3];
            else
                losses += bag[-3];
            if(Math.Max(skill - 4, 0) >= test)
                wins += bag[-4];
            else
                losses += bag[-4];
            if(Math.Max(skill - 5, 0) >= test)
                wins += bag[-5];
            else
                losses += bag[-5];
            if(Math.Max(skill - 6, 0) >= test)
                wins += bag[-6];
            else
                losses += bag[-6];
            if(Math.Max(skill - 7, 0) >= test)
                wins += bag[-7];
            else
                losses += bag[-7];
            if(Math.Max(skill - 8, 0) >= test)
                wins += bag[-8];
            else
                losses += bag[-8];
            if(Math.Max(skill + star, 0) >= test)
                wins += bag[16];
            else
                losses += bag[16];
            return new double[]{ wins, losses };
        }
    }
}
