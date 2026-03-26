using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kigyo.Map;
using Kigyo.View;

namespace Kigyo
{
    internal class Program
    {
        public static int x_palya = 5;
        public static int y_palya = 5;
        public static string[,] aktualis_palya = Palya.PalyaGeneralo(x_palya, y_palya);

        static void Main(string[] args)
        {
            Megjelenites.FoMegjelenites();
        }
    }
}
