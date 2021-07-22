using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class ScenarioNames
    {
        static readonly string[] notz = { "The Gathering", "The Midnight Masks", "The Devourer Below" };
        static readonly string[] tdl = { "Extracurricular Activity", "The House Always Wins", "The Miskatonic Museum", "The Essex County Express",
        "Blood on the Altar", "Undimensioned and Unseen", "Where Doom Awaits", "Lost in Time and Space" };
        static readonly string[] tfa = { "The Untamed Wilds", "The Doom of Eztli", "Threads of Fate", "The Boundary Beyond", "Heart of the Elders",
        "The City of Archives", "The Depths of Yoth", "Shattered Aeons" };
        public static string[] getList(int campaign)
        {
            switch (campaign)
            {
                case 0:
                    return notz;
                case 1:
                    return tdl;
                case 2:
                    return new string[] { "unfinished"};
                case 3:
                    return tfa;
                default:
                    return new string[]{ };
            }
        }
    }
}