using Kigyo;
using Kigyo.Kigyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.Controller
{
    internal class KigyoController
    {
        public static void UpdatePosition()
        {
           
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    
                    Program.Most_fej_x++;
                    break;

                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    
                    Program.Most_fej_x--;
                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    Program.Most_fej_y--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    Program.Most_fej_y++;
                    break;


            }


            
            if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] != " ☆ ")
            {
                Program.aktualis_palya[Program.poziciok[0].X_fej, Program.poziciok[0].Y_fej] = " ☐ ";
                Program.poziciok.RemoveAt(0);
            }

            for (int i = 0; i < Program.poziciok.Count; i++)
            {
                Program.aktualis_palya[Program.poziciok[i].X_fej, Program.poziciok[i].Y_fej] = " ☒ ";
            }
           

            

            
     


            Program.poziciok.Add(new Kigyo.Pozicio(Program.Most_fej_x, Program.Most_fej_y));


            Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] = " ☒ ";


            Console.Clear();


        }
    }
}
