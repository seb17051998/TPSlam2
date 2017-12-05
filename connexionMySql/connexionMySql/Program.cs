using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace connexionMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCnx="user=root;password=siojjr;database=basePersonne;host=localhost";
            MySqlConnection connexion = new MySqlConnection(sCnx);
            //connexion.Open();
            int choix;
            bool quitter=false;
            while (quitter == false)
            {
                Console.WriteLine("1 : Insérer une personne");
                Console.WriteLine("2 : Modifier une personne");
                Console.WriteLine("3 : Supprimer une personne");
                Console.WriteLine("4 : Nombre de personnes");
                Console.WriteLine("5 : Afficher la liste des personnes");
                Console.WriteLine("6 : Afficher la liste des personnes dans l'ordre alphabétique");
                Console.WriteLine("Faites votre choix");
                choix = Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        connexion.Open();
                        Console.WriteLine("Saisir id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir Nom");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Saisir l'age");
                        int age = Convert.ToInt32(Console.ReadLine());
                        string sCmd = "insert into Personne(id,nom,age) values (@id, @nom, @age)";
                        MySqlCommand cmd = new MySqlCommand(sCmd, connexion);
                        MySqlParameter pId = new MySqlParameter("@id", id);
                        MySqlParameter pNom = new MySqlParameter("@nom", nom);
                        MySqlParameter pAge = new MySqlParameter("@age", age);
                        cmd.Parameters.Add(pId);
                        cmd.Parameters.Add(pNom);
                        cmd.Parameters.Add(pAge);
                        cmd.ExecuteNonQuery();
                        connexion.Close();
                        Console.WriteLine("Ajout effectué");
                        break;
                    case 2:
                        connexion.Open();
                        Console.WriteLine("Saisir l'id");
                        int idMod = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir le nom");
                        string nomMod = Console.ReadLine();
                        Console.WriteLine("Saisir l'age");
                        int ageMod = Convert.ToInt32(Console.ReadLine());
                        string sCmdMod = "update Personne set nom=@nom, age=@age where id=@id";
                        MySqlCommand cmdMod = new MySqlCommand(sCmdMod, connexion);
                        MySqlParameter pIdMod = new MySqlParameter("@id", idMod);
                        MySqlParameter pNomMod = new MySqlParameter("@nom", nomMod);
                        MySqlParameter pAgeMod = new MySqlParameter("@age", ageMod);
                        cmdMod.Parameters.Add(pIdMod);
                        cmdMod.Parameters.Add(pNomMod);
                        cmdMod.Parameters.Add(pAgeMod);
                        cmdMod.ExecuteNonQuery();
                        connexion.Close();
                        Console.WriteLine("Modification effectué");
                        break;
                    case 3:
                        connexion.Open();
                        Console.WriteLine("Saisir l'id de la personne à supprimer");
                        int idDel = Convert.ToInt32(Console.ReadLine());
                        string sCmdDel = "delete from Personne where id=@id";
                        MySqlCommand cmdDel = new MySqlCommand(sCmdDel, connexion);
                        MySqlParameter pIdDel = new MySqlParameter("@id", idDel);
                        cmdDel.Parameters.Add(pIdDel);
                        cmdDel.ExecuteNonQuery();
                        connexion.Close();
                        Console.WriteLine("Suppression effectué");
                        break;
                    case 4:
                        connexion.Open();
                        string sCmdCount = "select count(*) from personne";
                        MySqlCommand cmdCount = new MySqlCommand(sCmdCount, connexion);
                        int count = Convert.ToInt32(cmdCount.ExecuteScalar());
                        Console.WriteLine("il y a {0} personnes enregistrés au total", count);
                        Console.ReadLine();
                        connexion.Close();
                        break;
                    case 5:
                        connexion.Open();
                        MySqlCommand cmdSelect = new MySqlCommand("select id,nom,age from personne", connexion);
                        MySqlDataReader reader = cmdSelect.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(reader[0]);
                            Console.WriteLine(reader[1]);
                            Console.WriteLine(reader[2]);
                        }
                        Console.ReadLine();
                        connexion.Close();
                        break;
                    case 6:
                        connexion.Open();
                        MySqlCommand cmdGroupBy = new MySqlCommand("select id,nom,age from personne group by(nom)", connexion);
                        MySqlDataReader readerGrpBy = cmdGroupBy.ExecuteReader();
                        while (readerGrpBy.Read())
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(readerGrpBy[0]);
                            Console.WriteLine(readerGrpBy[1]);
                            Console.WriteLine(readerGrpBy[2]);
                        }
                        Console.ReadLine();
                        connexion.Close();
                        break;



                }
            }
            
        }
    }
}
