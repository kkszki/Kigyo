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
           
            
            

            if (Console.ReadLine() == "s")
            {
                Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] = " x ";
                Program.Most_fej_x++;
           
                

               

            }

            if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] == " b ")
            {
               
                Program.poziciok.RemoveAt(0);
            }
     


            Program.poziciok.Add(new Kigyo.Pozicio(Program.Most_fej_x, Program.Most_fej_y));


            Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] = " a ";


            Console.Clear();


        }
    }
}
