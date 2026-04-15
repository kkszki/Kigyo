using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.View
{
    internal class Parameterek
    {
        public static int akutalis_menupont = 0;
        public static void PalyaMeret()
        {
            List<string> palyaOpciok = new List<string>()
                {
                    "5*5 pálya",
                    "10*10 pálya",
                    "15*15 pálya",
                    "Egyéb"
                };

            bool kivalaszt = true;
            

            while (kivalaszt)
            {
                Console.Clear(); // Letöröljük az előző állapotot
          
                // Menü kirajzolása
                for (int i = 0; i < palyaOpciok.Count; i++)
                {
                    if (i == akutalis_menupont)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(palyaOpciok[i]); 
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{palyaOpciok[i]}");
                    }
                }

   
                ConsoleKey gomb = Console.ReadKey(true).Key;
                switch (gomb)
                {
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                      
                        if (akutalis_menupont < palyaOpciok.Count - 1)
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
        }





        
    }
}
