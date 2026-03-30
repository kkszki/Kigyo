using Kigyo;
using Kigyo.Kigyo;
using Kigyo.View;
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
            utolsoIrany = ConsoleKey.Q;
            if (Console.KeyAvailable)
            {
                
                utolsoIrany = Console.ReadKey(true).Key;
            }

       
            switch (utolsoIrany)
            {

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:

                    if (Program.Most_fej_x + 1 >= Program.x_palya)
                    {
                        Console.WriteLine("Neki ment a szélének");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                        break;
                    }



                    if (Program.aktualis_palya[Program.Most_fej_x+1,Program.Most_fej_y]== "🟫" || Program.aktualis_palya[Program.Most_fej_x + 1, Program.Most_fej_y] == "🟥") 
                    { Program.Most_fej_x++;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                    }


                    






                        break;

                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (Program.Most_fej_x - 1 < 0)
                    {
                        Console.WriteLine("Neki ment a szélének");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                        break;
                    }



                    if (Program.aktualis_palya[Program.Most_fej_x - 1, Program.Most_fej_y] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x - 1, Program.Most_fej_y] == "\U0001f7e5")
                    {
                        Program.Most_fej_x--;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                    }



                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:


                    if (Program.Most_fej_y -1 < 0)
                    {
                        Console.WriteLine("Neki ment a szélének");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                        break;
                    }


                    if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y - 1] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y - 1] == "\U0001f7e5")
                    {
                        Program.Most_fej_y--;
                        Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                    }
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:

                    if (Program.Most_fej_y  +1 >= Program.y_palya)
                    {
                        Console.WriteLine("Neki ment a szélének");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Program.fut = false;
                        break;
                    }


                    if (Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y + 1] == "\U0001f7eb" || Program.aktualis_palya[Program.Most_fej_x, Program.Most_fej_y + 1] == "\U0001f7e5")
                    { 

                        Program.Most_fej_y++;
                    Elhagyottmezo();
                    }
                    else
                    {
                        Console.WriteLine("Átment volna magán a kígyó!");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
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
            List<Pozicio> pozicioklista = new List<Pozicio>();
           

            for (int i = 0; i < Program.x_palya; i++)
            {
                for (int j = 0; j < Program.y_palya; j++)
                {
                    if (Program.aktualis_palya[i, j] == "\U0001f7eb")
                    {
                        pozicioklista.Add(new Pozicio(i, j));
                    }

                }
            }

            if (pozicioklista.Count() == 0 )
            {

                Program.fut=false;
                Program.teljesitve = true;
                


            }
            else
            {
                Random rnd = new Random();
                int random = rnd.Next(0, pozicioklista.Count());

               
                    Program.aktualis_palya[pozicioklista[random].X_fej, pozicioklista[random].Y_fej] = "🟥";
               
               
            }
            
        }
    }
}
