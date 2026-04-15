using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kigyo.Controller;
using Kigyo.Kigyo;
using Kigyo.Map;
using Kigyo.View;
using Kigyo.User;

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
       
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int akutalis_menupont = 0;

            List<string> Opciok = new List<string>()
            {
                "Jéték indítása",
                "Legjobb eredmények",
                "Kilépés"
            };

            bool kivalaszt = true;


            while (kivalaszt)
            {
                Console.Clear(); // Letöröljük az előző állapotot
                Console.WriteLine("Üdvözöljük! ");
                Console.WriteLine("");

                // Menü kirajzolása
                for (int i = 0; i < Opciok.Count; i++)
                {
                    if (i == akutalis_menupont)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Opciok[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{Opciok[i]}");
                    }
                }


                ConsoleKey gomb = Console.ReadKey(true).Key;
                switch (gomb)
                {
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:

                        if (akutalis_menupont < Opciok.Count - 1)
                        {
                            akutalis_menupont++;
                        }
                        break;

                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:

                        if (akutalis_menupont > 0)
                        {
                            akutalis_menupont--;
                        }
                        break;

                    case ConsoleKey.Enter:
                        kivalaszt = false;
                        break;
                }
            }

            Console.Clear();

            switch (akutalis_menupont)
            {
                case 0:
                    Game();
                    break;
                case 1:
                    List<UserPont> ponts = UserPont.GetPontList();
                    new Pontszam().ShowPontList(ponts);
                    Console.ReadLine();
                    Program.Main();
                    break;
                case 2:
                    Console.WriteLine("Viszlát!");
                    Environment.Exit(0);
                    break;
            }

        }

        static void Game() 
        {
            Console.OutputEncoding = Encoding.UTF8;
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


            int pont = Program.poziciok.Count - 1;
            Console.WriteLine($"Pontszám: {pont}");
            string name = Pontszam.Nev();

            if (pont > 1)
            {
                Pontszam.PontSave(name, pont);
            }

            Console.ReadLine();
        }
    }
}
