using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TPAdoClass
{
    static class ConnectionJoyeuxAnniversaire
    {
        //Données membres
        static string sConnection;
        static MySqlConnection connection;

        static ConnectionJoyeuxAnniversaire()
        {
            sConnection = "user=root;password=siojjr;database=baseAnniversaire;host=localhost";
            connection = new MySqlConnection(sConnection);
            
        }

        public static MySqlConnection GetConnection()
        {
            return ConnectionJoyeuxAnniversaire.connection;
        }
    }
}
