using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class WinChecker
    {
        public static double[] StandardCheck(double[] winLoss, Dictionary<int, int> bag, int token, int skill, int test, int reduce)
        {
            if (Math.Max(skill - reduce, 0) >= test)
                winLoss[0] += bag[token];
            else
                winLoss[1] += bag[token];
            return winLoss;
        }
    }
}
