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

        static ConsoleKey utolsoIrany = ConsoleKey.Q;
        public static void UpdatePosition()
        {

            if (Console.KeyAvailable)
            {
                
                utolsoIrany = Console.ReadKey(true).Key;
            }

       
            switch (utolsoIrany)
            {

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:

                    if (Program.aktualis_palya[Program.Most_fej_x+1,Program.Most_fej_y]== "🟫" || Program.aktualis_palya[Program.Most_fej_x + 1, Program.Most_fej_y] == "🟥") 
                    { Program.Most_fej_x++;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Program.fut = false;
                    }






                        break;

                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (Program.aktualis_palya[Program.Most_fej_x - 1, Program.Most_fej_y] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x - 1, Program.Most_fej_y] == "\U0001f7e5")
                    {
                        Program.Most_fej_x--;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Program.fut = false;
                    }



                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y - 1] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y - 1] == "\U0001f7e5")
                    {
                        Program.Most_fej_y--;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Program.fut = false;
                    }
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y + 1] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y + 1] == "\U0001f7e5")
                    { 

                        Program.Most_fej_y++;
                    Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Program.fut = false;
                      
                    }
                    break;

                   
            }




            System.Threading.Thread.Sleep(400);








            if (Program.fut)
            {


                Console.Clear();
            }


        }


        public static void Elhagyottmezo()
        {
            if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] != "\U0001f7e5")
            {
                Program.aktualis_palya[Program.poziciok[0].X_fej, Program.poziciok[0].Y_fej] = "\U0001f7eb";
                Program.poziciok.RemoveAt(0);
                


            }
            else if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] == "\U0001f7e5")
            {
                RandomGyumolcs();
            }

                for (int i = 0; i < Program.poziciok.Count; i++)
                {
                    Program.aktualis_palya[Program.poziciok[i].X_fej, Program.poziciok[i].Y_fej] = "\U0001f7e9";
                }

            Program.poziciok.Add(new Kigyo.Pozicio(Program.Most_fej_x, Program.Most_fej_y));


            Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y] = "\U0001f7e9";
        }

        public static void RandomGyumolcs()
        {
            Random rnd = new Random();
            int ranom_x = rnd.Next(0, Program.x_palya);
            int ranom_y = rnd.Next(0, Program.y_palya);
            while (Program.aktualis_palya[ranom_x, ranom_y] != "\U0001f7eb")
            {
                ranom_x = rnd.Next(0, Program.x_palya);
                ranom_y = rnd.Next(0, Program.y_palya);
            }
            Program.aktualis_palya[ranom_x, ranom_y] = "🟥";
        }
    }
}
