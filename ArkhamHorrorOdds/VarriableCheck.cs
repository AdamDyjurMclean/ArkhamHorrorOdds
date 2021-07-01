using System;
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
                    new int[] { 0, 0, 0 }
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
                return "Ghouls #";
            return "";
        }
    }
}
