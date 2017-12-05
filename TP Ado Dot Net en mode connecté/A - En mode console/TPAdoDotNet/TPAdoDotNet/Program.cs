using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace TPAdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Connection();
            SqlCommand();
            Console.ReadLine();
        }

        public static void Connection()
        {
            string sConnection = "user=root;password=siojjr;database=baseAnniversaire;host=localhost";
            MySqlConnection connection = new MySqlConnection(sConnection);
            connection.Open();
           
        }

        static void SqlCommand()
        {
            string sCmdCount = "select count(*) from anniversaire";
            //MySqlCommand cmdCount = new MySqlCommand(sCmdCount, Connection().connection);
            int count = Convert.ToInt32(cmdCount.ExecuteScalar());
            Console.WriteLine("Il y a {0} enregistrement dans la table anniversaire", count);
        }
    }
}
