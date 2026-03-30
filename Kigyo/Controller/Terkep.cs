using Kigyo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.Controller
{
    internal class Terkep
    {

        public static void TerkepBeallit()
        {
           
             
            switch (Parameterek.akutalis_menupont)
            {
                case 0:
                    Program.x_palya = 5;
                    Program.y_palya = 5;
                    break;
                case 1:
                    Program.x_palya = 10;
                    Program.y_palya = 10;
                    break;

                case 2:
                    Program.x_palya = 15;
                    Program.y_palya = 15;
                    break;
                case 3:
                    Console.WriteLine("Adja meg az x szélességet: ");

                    bool siker = false;
                    while (!siker)
                    {
                        try
                        {
                            Program.x_palya = int.Parse(Console.ReadLine());
                            siker = true; 
                        }
                        catch
                        {
                            Console.WriteLine("Hibás bemenet! Számot kértem:");
                        }
                    }
                    Console.WriteLine("Adja meg az y szélességet: ");

                    siker = false;
                    while (!siker)
                    {
                        try
                        {
                            Program.y_palya = int.Parse(Console.ReadLine());
                            siker = true;
                        }
                        catch
                        {
                            Console.WriteLine("Hibás bemenet! Számot kértem:");
                        }
                    }



                    break;

            }
        }
    }
}
