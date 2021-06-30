using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorOdds
{
    public static class TokenNumber
    {
        public static int convert(int input)
        {
            switch (input)
            {
                case 0:
                    return 1;
                case 1:
                    return 0;
                case 2:
                    return -1;
                case 3:
                    return -2;
                case 4:
                    return -3;
                case 5:
                    return -4;
                case 6:
                    return -5;
                case 7:
                    return -6;
                case 8:
                    return -8;
                case 9:
                    return 11;
                case 10:
                    return 12;
                case 11:
                    return 13;
                case 12:
                    return 14;
                case 13:
                    return 15;
                case 14:
                    return 16;
                default:
                    return 100;
            }
                
        }
    }
}
