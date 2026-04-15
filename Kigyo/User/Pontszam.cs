using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Kigyo.User;

namespace Kigyo.User
{
    internal class Pontszam
    {
        private static string connectionString =
            "server=localhost;database=snake;uid=root;pwd=;";

        public static string Nev()
        {
            Console.WriteLine("Név?: ");
            string nev = Console.ReadLine();
            return nev;
        }

        public static void PontSave(string nev, int pont)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO snake (Nev, Pont) VALUES (@nev, @pont)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.Parameters.AddWithValue("@pont", pont);

                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine($"Pontszám elmentve: {nev} - {pont}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB hiba: " + ex.Message);
            }
        }

        public void ShowPontList(List<UserPont> ponts)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("┌──────┬─────────────────────────┬──────────────────────────────────────────┐");
            Console.WriteLine("│  Id  │           Név           │                 Pontszám                 │");
            Console.WriteLine("│      │                         │                                          │");
            Console.WriteLine("├──────┼─────────────────────────┼──────────────────────────────────────────┤");

            bool first = true;
            foreach (var pont in ponts)
            {
                if (!first)
                {
                    Console.WriteLine("├──────┼─────────────────────────┼──────────────────────────────────────────┤");
                }

                Console.WriteLine($"│{pont.Id,-6}│{pont.Nev,-25}│{pont.Pont,-42}│");
                first = false;
            }

            Console.WriteLine("└──────┴─────────────────────────┴──────────────────────────────────────────┘");


        }
    }
}
