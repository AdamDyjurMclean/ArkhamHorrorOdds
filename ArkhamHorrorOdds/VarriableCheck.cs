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
            if(difficulty == 1 || difficulty == 3)
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
                    new int[] { 1, 5, 2 },
                    new int[] { 1, 6, 0 },
                    new int[] { 1, 6, 2 },
                    new int[] { 1, 7, 0 },
                    new int[] { 1, 7, 2 },
                    new int[] { 2, 0, 0 },
                    new int[] { 2, 0, 2 },
                    new int[] { 2, 1, 0 },
                    new int[] { 2, 1, 2 },
                    new int[] { 2, 2, 0 },
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 3, 0 },
                    new int[] { 2, 3, 2 },
                    new int[] { 2, 4, 0 },
                    new int[] { 2, 4, 2 },
                    new int[] { 2, 5, 0 },
                    new int[] { 2, 5, 2 },
                    new int[] { 2, 6, 0 },
                    new int[] { 2, 6, 2 },
                    new int[] { 2, 7, 0 },
                    new int[] { 2, 7, 2 },
                    new int[] { 3, 0, 0 },
                    new int[] { 3, 0, 2 },
                    new int[] { 3, 1, 0 },
                    new int[] { 3, 1, 2 },
                    new int[] { 3, 2, 0 },
                    new int[] { 3, 2, 2 },
                    new int[] { 3, 3, 0 },
                    new int[] { 3, 3, 2 },
                    new int[] { 3, 4, 0 },
                    new int[] { 3, 4, 2 },
                    new int[] { 3, 5, 0 },
                    new int[] { 3, 5, 2 },
                    new int[] { 3, 6, 0 },
                    new int[] { 3, 6, 2 },
                    new int[] { 3, 7, 0 },
                    new int[] { 3, 7, 2 },
                    new int[] { 4, 2, 0 },
                    new int[] { 4, 2, 2 },
                    new int[] { 4, 3, 0 },
                    new int[] { 4, 3, 2 },
                    new int[] { 4, 4, 0 },
                    new int[] { 4, 5, 0 },
                    new int[] { 4, 5, 2 },
                    new int[] { 4, 7, 0 },
                    new int[] { 4, 7, 2 },
                    new int[] { 4, 8, 0 },
                    new int[] { 4, 8, 2 },
                    new int[] { 5, 0, 0 },
                    new int[] { 5, 0, 2 },
                    new int[] { 5, 1, 0 },
                    new int[] { 5, 1, 2 },
                    new int[] { 5, 2, 0 },
                    new int[] { 5, 2, 2 },
                    new int[] { 5, 3, 0 },
                    new int[] { 5, 3, 2 }
                };
            if(jaggedArray.Any(x => x.SequenceEqual(new int[] {campaign, scenerio, difficulty })))
                return true;
            return false;
        }
        public static string Label(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[] array = new int[] { campaign, scenerio, difficulty };
            if(Enumerable.SequenceEqual(array, new int[] { 0, 0, 0 }))
                return "Ghouls";
            else if(Enumerable.SequenceEqual(array, new int[] { 0, 1, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 2, 0 }) ||
                Enumerable.SequenceEqual(array, new int[] { 2, 6, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 2, 0 }) || 
                Enumerable.SequenceEqual(array, new int[] { 4, 5, 0 }))
                return "Highest Doom";
            else if(Enumerable.SequenceEqual(array, new int[] { 0, 1, 2 }) || Enumerable.SequenceEqual(array, new int[] { 2, 2, 2 }) || 
                Enumerable.SequenceEqual(array, new int[] { 3, 2, 2 }) || Enumerable.SequenceEqual(array, new int[] { 2, 4, 0 }) ||
                Enumerable.SequenceEqual(array, new int[] { 2, 6, 2 }) || Enumerable.SequenceEqual(array, new int[] { 2, 4, 2 }) || 
                Enumerable.SequenceEqual(array, new int[] { 4, 5, 2 }))
                return "Total Doom";
            else if(Enumerable.SequenceEqual(array, new int[] { 0, 2, 0 }))
                return "Monsters";
            else if(Enumerable.SequenceEqual(array, new int[] { 1, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 0, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 1, 2, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 2, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 1, 4, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 4, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 1, 6, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 6, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 1, 7, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 7, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 3, 1, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 1, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 3, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 3, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 3, 4, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 4, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 3, 7, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 7, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 4, 2, 0 }) || Enumerable.SequenceEqual(array, new int[] { 4, 2, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 4, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 4, 3, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 5, 1, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 1, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 5, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 3, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 2, 7, 0 }))
                return "Skull Value";
            else if(Enumerable.SequenceEqual(array, new int[] { 1, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 3, 2 }))
                return "Agenda #";
            else if(Enumerable.SequenceEqual(array, new int[] { 1, 5, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 5, 2 }))
                return "Broods";
            else if(Enumerable.SequenceEqual(array, new int[] { 2, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 0, 2 }) ||
                    Enumerable.SequenceEqual(array, new int[] { 2, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 3, 2 }) || 
                    Enumerable.SequenceEqual(array, new int[] { 2, 7, 2 }))
                return "Horror";
            else if(Enumerable.SequenceEqual(array, new int[] { 2, 1, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 1, 2 }))
                return "Shroud";
            else if(Enumerable.SequenceEqual(array, new int[] { 2, 5, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 5, 2 }))
                return "# from start";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 0, 2 }))
                return "Vengeance #";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 5, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 5, 2 }))
                return "Hand Size";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 6, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 6, 2 }))
                return "Depth level";
            else if(Enumerable.SequenceEqual(array, new int[] { 4, 4, 0 }))
                return "Unfinished#";
            else if(Enumerable.SequenceEqual(array, new int[] { 4, 7, 0 }) || Enumerable.SequenceEqual(array, new int[] { 4, 7, 2 }))
                return "Total D+B";
            else if(Enumerable.SequenceEqual(array, new int[] { 4, 8, 0 }) || Enumerable.SequenceEqual(array, new int[] { 4, 8, 2 }))
                return "Azathoth#";
            else if(Enumerable.SequenceEqual(array, new int[] { 5, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 0, 2 }))
                return "Hand Size:";
            else if (Enumerable.SequenceEqual(array, new int[] { 5, 2, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 2, 2 }))
                return "Signs#";
            return "";
        }
        public static bool Check2(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[][] jaggedArray =
                {
                    new int[] { 1, 6, 0 },
                    new int[] { 1, 6, 2 },
                    new int[] { 1, 7, 0 },
                    new int[] { 1, 7, 2 },
                    new int[] { 2, 3, 0 },
                    new int[] { 2, 3, 2 },
                    new int[] { 3, 0, 0 },
                    new int[] { 3, 0, 2 },
                    new int[] { 3, 1, 0 },
                    new int[] { 3, 1, 2 },
                    new int[] { 3, 6, 0 },
                    new int[] { 3, 6, 2 },
                    new int[] { 5, 0, 0 },
                    new int[] { 5, 0, 2 },
                    new int[] { 5, 1, 0 },
                    new int[] { 5, 1, 2 }
                };
            if(jaggedArray.Any(x => x.SequenceEqual(new int[] { campaign, scenerio, difficulty })))
                return true;
            return false;
        }
        public static string Label2(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[] array = new int[] { campaign, scenerio, difficulty };
            if(Enumerable.SequenceEqual(array, new int[] { 1, 6, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 6, 2 }))
                return "Agenda #";
            else if(Enumerable.SequenceEqual(array, new int[] { 1, 7, 0 }) || Enumerable.SequenceEqual(array, new int[] { 1, 7, 2 }) ||
                Enumerable.SequenceEqual(array, new int[] { 2, 3, 0 }) || Enumerable.SequenceEqual(array, new int[] { 2, 3, 2 }))
                return "Shroud Value";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 0, 2 }))
                return "Locations";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 1, 0 }))
                return "Location #";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 1, 2 }))
                return "Doom #";
            else if(Enumerable.SequenceEqual(array, new int[] { 3, 6, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 6, 2 }))
                return "Vengeance";
            else if (Enumerable.SequenceEqual(array, new int[] { 5, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 0, 2 }))
                return "Revealed#";
            else if (Enumerable.SequenceEqual(array, new int[] { 5, 1, 0 }) || Enumerable.SequenceEqual(array, new int[] { 5, 1, 2 }))
                return "Infested#";
            return "";
        }
        public static bool Check3(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[][] jaggedArray =
                {
                    new int[] { 3, 0, 0 },
                    new int[] { 3, 0, 2 }
                };
            if(jaggedArray.Any(x => x.SequenceEqual(new int[] { campaign, scenerio, difficulty })))
                return true;
            return false;
        }
        public static string Label3(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[] array = new int[] { campaign, scenerio, difficulty };
            if(Enumerable.SequenceEqual(array, new int[] { 3, 0, 0 }) || Enumerable.SequenceEqual(array, new int[] { 3, 0, 2 }))
                return "Exploration #";
            return "";
        }
        public static bool CheckP(int campaign, int scenerio, int difficulty)
        {
            if(difficulty == 1 || difficulty == 3)
                difficulty--;
            int[][] jaggedArray =
                {
                    new int[] { 2, 6, 0 },
                    new int[] { 2, 6, 2 },
                    new int[] { 3, 0, 0 },
                    new int[] { 3, 0, 2 },
                    new int[] { 3, 4, 0 },
                    new int[] { 3, 4, 2 },
                    new int[] { 3, 7, 0 },
                    new int[] { 3, 7, 2 }
                };
            if(jaggedArray.Any(x => x.SequenceEqual(new int[] { campaign, scenerio, difficulty })))
                return true;
            return false;
        }
    }
}
