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
        public static int x_palya = 10;
        public static int y_palya = 10;
        public static string[,] aktualis_palya = Palya.PalyaGeneralo(Program.x_palya, Program.y_palya);
        public static bool fut=true;
        public static int Most_fej_x = 0;
        public static int Most_fej_y = 0;
        public static int KigyoHossza = 1;
        public static bool teljesitve = false;
        
        
        public static List<Pozicio> poziciok = new List<Pozicio>()
        {
            new Pozicio(0,0) 
        };
       
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;
            Parameterek.PalyaMeret();
            Controller.Terkep.TerkepBeallit();
            aktualis_palya = Palya.PalyaGeneralo(Program.x_palya, Program.y_palya);
            
            KigyoController.RandomGyumolcs();
            while (fut)
            {

                Fo.MainProgram();


            }
            Console.Clear();
            Megjelenites.FoMegjelenites();

        
            Console.WriteLine("Játék Vége!");
            if (teljesitve)
            {
                Console.WriteLine("Telejesítve");
            }
            Console.ReadLine();



        }
    }
}
