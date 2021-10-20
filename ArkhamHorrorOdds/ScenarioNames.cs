using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class ScenarioNames
    {
        public static string[] GetList(int campaign)
        {
            switch (campaign)
            {
                case 0:
                    return new string[] { "The Gathering", "The Midnight Masks", "The Devourer Below" };
                case 1:
                    return new string[] { "Extracurricular Activity", "The House Always Wins", "The Miskatonic Museum", "The Essex County Express",
                        "Blood on the Altar", "Undimensioned and Unseen", "Where Doom Awaits", "Lost in Time and Space" };
                case 2:
                    return new string[] { "Curtain Call", "The Last King", "Echoes of the Past", "The Unspeakable Oath", "A Phantom of Truth",
                        "The Pallid Mask", "Black Stars Rise", "Dim Carcosa"};
                case 3:
                    return new string[] { "The Untamed Wilds", "The Doom of Eztli", "Threads of Fate", "The Boundary Beyond", "Heart of the Elders",
                        "The City of Archives", "The Depths of Yoth", "Shattered Aeons" };
                case 4:
                    return new string[] { "Disappearance at the Twilight Estate", "The Witching Hour", "At Death’s Doorstep", "The Secret Name",
                        "The Wages of Sin", "For the Greater Good", "Union and Disillusion", "In the Clutches of Chaos", "Before the Black Throne"};
                case 5:
                    return new string[] { "Beyond the Gates of Sleep", "Waking Nightmare", "The Search for Kadath", "A Thousand Shapes of Horror",
                        "Dark Side of the Moon", "Point of No Return", "Where the Gods Dwell", "Weaver of the Cosmos"};
                case 6:
                    return new string[] { "The Pit of Despair", "The Vanishing of Elina Harper", "In Too Deep", "Devil Reef",
                        "Horror in High Gear", "A Light in the Fog", "The Lair of Dagon", "Into the Maelstrom"};
                default:
                    return new string[]{ };
            }
        }
    }
}