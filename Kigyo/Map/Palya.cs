using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.Map
{
    internal class Palya
    {
        public static string[,] PalyaGeneralo(int sorok, int oszlopok)
        {
            string[,] palya = new string[sorok, oszlopok];

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {

                    palya[i, j] = $"[{i},{j}]";
                }
            }



            return palya;
        }


    }
}
