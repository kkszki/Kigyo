using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo.User
{
    internal class UserPont
    {
        private int id;
        private string nev;
        private int pont;

        public UserPont(int id, string nev, int pont)
        {
            Id = id;
            Nev = nev;
            Pont = pont;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Pont { get => pont; set => pont = value; }

        public static List<UserPont> GetPontList()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=snake;");
            conn.Open();
            string comd = "SELECT * FROM snake  ;";
            MySqlCommand cmd = new MySqlCommand(comd, conn);
            List<UserPont> pontok = new List<UserPont>();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pontok.Add(new UserPont(
                        reader.GetInt32("id"),
                        reader.GetString("nev"),
                        reader.GetInt32("pont")
                    ));
                }

                conn.Close();
                return pontok;
            }
        }


    }
}
