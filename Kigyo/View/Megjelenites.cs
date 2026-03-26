using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.View
{
    internal class Megjelenites
    {
        public static void FoMegjelenites()
        {
            for (int i = 0; i < Program.x; i++)
            {
                for (int j = 0; j < Program.y; j++)
                {
                    Console.Write(Program.aktualis_palya[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
