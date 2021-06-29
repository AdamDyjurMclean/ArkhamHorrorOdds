using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class ScenarioNames
    {
        static string[] notz = { "The Gathering", "The Midnight Masks", "The Devourer Below" };
        static string[] tdl = { "Extracurricular Activity", "The House Always Wins", "The Miskatonic Museum", "The Essex County Express",
        "Blood on the Altar", "Undimensioned and Unseen", "Where Doom Awaits", "Lost in Time and Space" };
        public static string[] getList(int campaign)
        {
            switch (campaign)
            {
                case 0:
                    return notz;
                case 1:
                    return tdl;
                default:
                    return new string[]{ };

            }
        }
    }
}