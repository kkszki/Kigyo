using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kigyo.Controller;
using Kigyo.Kigyo;
using Kigyo.Map;
using Kigyo.View;

namespace Kigyo
{
    internal class Program
    {
        public static int x_palya = 5;
        public static int y_palya = 5;
        public static string[,] aktualis_palya = Palya.PalyaGeneralo(x_palya, y_palya);

        public static int Most_fej_x = 0;
        public static int Most_fej_y = 0;
        public static List<Pozicio> poziciok = new List<Pozicio>()
        {
            new Pozicio(0,0) 
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Fo.MainProgram();
            }


        }
    }
}
