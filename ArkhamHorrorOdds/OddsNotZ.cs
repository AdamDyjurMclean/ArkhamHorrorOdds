using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class OddsNotZ
    {
        static int totalTokens = 0;
        public static string scenarioCheck(Dictionary<int, int> bag, int scenario, int difficulty, int skill, int bonus, int star, int test)
        {
            totalTokens = bag.Sum(x => x.Value);
            if (scenario == 0)
                return gathering(bag, difficulty, skill, bonus, star, test);
            return "";
        }
        public static string gathering(Dictionary<int, int> bag, int difficulty, int skill, int bonus, int star, int test)
        {
            int[] winLoss = OddsBag.numbers(bag, skill + bonus, test, star);
            return winLoss[0].ToString() + " " + winLoss[1].ToString();
        }
    }
}
