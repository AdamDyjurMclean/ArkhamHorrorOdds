using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class TextBoxString
    {
        public static string textBox(Dictionary<int, int> bag)
        {
            string bagContains = "";
            if (bag[1] == 1)
                bagContains += $"{bag[1]} \t +1 token\n";
            else if (bag[1] > 1)
                bagContains += $"{bag[1]} \t +1 tokens\n";
            if (bag[0] == 1)
                bagContains += $"{bag[0]} \t 0 token\n";
            else if (bag[0] > 1)
                bagContains += $"{bag[0]} \t 0 tokens\n";
            if (bag[-1] == 1)
                bagContains += $"{bag[-1]} \t -1 token\n";
            else if (bag[-1] > 1)
                bagContains += $"{bag[-1]} \t -1 tokens\n";
            if (bag[-2] == 1)
                bagContains += $"{bag[-2]} \t -2 token\n";
            else if (bag[-2] > 1)
                bagContains += $"{bag[-2]} \t -2 tokens\n";
            if (bag[-3] == 1)
                bagContains += $"{bag[-3]} \t -3 token\n";
            else if (bag[-3] > 1)
                bagContains += $"{bag[-3]} \t -3 tokens\n";
            if (bag[-4] == 1)
                bagContains += $"{bag[-4]} \t -4 token\n";
            else if (bag[-4] > 1)
                bagContains += $"{bag[-4]} \t -4 tokens\n";
            if (bag[-5] == 1)
                bagContains += $"{bag[-5]} \t -5 token\n";
            else if (bag[-5] > 1)
                bagContains += $"{bag[-5]} \t -5 tokens\n";
            if (bag[-6] == 1)
                bagContains += $"{bag[-6]} \t -6 token\n";
            if (bag[-7] == 1)
                bagContains += $"{bag[-7]} \t -7 token\n";
            if (bag[-8] == 1)
                bagContains += $"{bag[-8]} \t -8 token\n";
            if (bag[11] == 1)
                bagContains += $"{bag[11]} \t Skull token\n";
            else if (bag[11] > 1)
                bagContains += $"{bag[11]} \t Skull tokens\n";
            if (bag[12] == 1)
                bagContains += $"{bag[12]} \t Cultest token\n";
            else if (bag[12] > 1)
                bagContains += $"{bag[12]} \t Cultest tokens\n";
            if (bag[13] == 1)
                bagContains += $"{bag[13]} \t Tablet token\n";
            else if (bag[13] > 1)
                bagContains += $"{bag[13]} \t Tablet tokens\n";
            if (bag[14] == 1)
                bagContains += $"{bag[14]} \t Elder Thing token\n";
            else if (bag[14] > 1)
                bagContains += $"{bag[14]} \t Elder Thing tokens\n";
            if (bag[15] == 1)
                bagContains += $"{bag[15]} \t Auto Fail token\n";
            if (bag[16] == 1)
                bagContains += $"{bag[16]} \t Elder Sign token\n";
            return bagContains;
        }
    }
}
