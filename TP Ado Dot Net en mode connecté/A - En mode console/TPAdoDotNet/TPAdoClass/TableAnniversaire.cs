using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TPAdoClass
{
    class TableAnniversaire
    {
        private MySqlConnection connection;
        private MySqlCommand selectAnniversaire;
        private MySqlCommand deleteAnniversaire;
        private MySqlCommand insertAnniversaire;
        private MySqlCommand updateAnniversaire;
        
        

        public TableAnniversaire()
        {
            connection = ConnectionJoyeuxAnniversaire.GetConnection();
        }

        public int ComptesOccurences()
        {
            string sCmdCount="select count(*) from anniversaire";
            selectAnniversaire = new MySqlCommand(sCmdCount,connection);
            int result = Convert.ToInt32(selectAnniversaire.ExecuteScalar());
            return result;
            
            
        }

        public int CompteOccurence(int annee)
        {
            string sCmdCountAnnee = "select count(*) from anniversaire where year(dateAnniversaire)=@annee";
            selectAnniversaire = new MySqlCommand(sCmdCountAnnee, connection);
            MySqlParameter pAnnee = new MySqlParameter("@annee", annee);
            selectAnniversaire.Parameters.Add(pAnnee);
            int result = Convert.ToInt32(selectAnniversaire.ExecuteScalar());
            return result;
        }

        public void Delete(int id)
        {
            string delAnniv="delete from anniversaire where id=@id";
            deleteAnniversaire = new MySqlCommand(delAnniv, connection);
            MySqlParameter pId = new MySqlParameter("@id", id);
            deleteAnniversaire.Parameters.Add(pId);
            deleteAnniversaire.ExecuteNonQuery();
            
        }

        public List<Anniversaire> LeNomPatronymiqueCommencePar(string debutNom)
        {
            string selectNomPat = "select nom, prenom, nomPseudonyme,prenomPseudonyme, dateAnniversaire from anniversaire where nom like '" + @debutNom + "%'";
            selectAnniversaire = new MySqlCommand(selectNomPat, connection);
            MySqlParameter debNom = new MySqlParameter("@debutNom", debutNom);
            selectAnniversaire.Parameters.Add(debNom);
            MySqlDataReader readDebNom = selectAnniversaire.ExecuteReader();
            while (readDebNom.Read())
            {
                Console.WriteLine(readDebNom["nom"]);
                Console.WriteLine(readDebNom["prenom"]);
                Console.WriteLine(readDebNom["nomPseudonyme"]);
                Console.WriteLine(readDebNom["prenomPseudonyme"]);
                Console.WriteLine(readDebNom["dateAnniversaire"]);
                Console.WriteLine(" ");
            }
            return null;
            
                 
            
        }
        
        public List<Anniversaire> QuiEstNeCeJour(int jour, int mois)
        {
            string selectNeJour = "select nom, prenom, nomPseudonyme,prenomPseudonyme, dateAnniversaire from anniversaire where day(dateAnniversaire)=@day and month(dateAnniversaire)=@month";
            selectAnniversaire = new MySqlCommand(selectNeJour, connection);
            MySqlParameter pDay = new MySqlParameter("@day", jour);
            MySqlParameter pMonth = new MySqlParameter("@month", mois);
            selectAnniversaire.Parameters.Add(pDay);
            selectAnniversaire.Parameters.Add(pMonth);
            MySqlDataReader readMoDay = selectAnniversaire.ExecuteReader();
            while (readMoDay.Read())
            {
                Console.WriteLine(readMoDay["nom"]);
                Console.WriteLine(readMoDay["prenom"]);
                Console.WriteLine(readMoDay["nomPseudonyme"]);
                Console.WriteLine(readMoDay["prenomPseudonyme"]);
                Console.WriteLine(readMoDay["dateAnniversaire"]);
                Console.WriteLine(" ");
            }
            return null;
        }

        public int Insert(Anniversaire nouvelAnniversaire)
        {
            string insertCmd = "insert into anniversaire (dateAnniversaire, nomPseudonyme, prenomPseudonyme,nom,prenom) values (@dateAnniversaire,@nomPseudonyme,@prenomPseudonyme,@nom,@prenom)";
            insertAnniversaire = new MySqlCommand(insertCmd, connection);           
            MySqlParameter pDateAnniversaire = new MySqlParameter("@dateAnniversaire", nouvelAnniversaire.GetDateAnniversaire());
            MySqlParameter pNomPseudonyme = new MySqlParameter("@nomPseudonyme", nouvelAnniversaire.GetNomPseudonyme());
            MySqlParameter pPrenomPseudonyme = new MySqlParameter("@prenomPseudonyme", nouvelAnniversaire.GetPrenomPseudonyme());
            MySqlParameter pNom = new MySqlParameter("@nom", nouvelAnniversaire.GetNom());
            MySqlParameter pPrenom = new MySqlParameter("@prenom", nouvelAnniversaire.GetPrenom());
            insertAnniversaire.Parameters.Add(pDateAnniversaire);
            insertAnniversaire.Parameters.Add(pNomPseudonyme);
            insertAnniversaire.Parameters.Add(pPrenomPseudonyme);
            insertAnniversaire.Parameters.Add(pNom);
            insertAnniversaire.Parameters.Add(pPrenom);
            int result = insertAnniversaire.ExecuteNonQuery();
            Console.WriteLine("Ajout effectué");
            return result;

            
        }

        public void Update(Anniversaire unAnniversaire)
        {
            string updateCmd = "update anniversaire set dateAnniversaire=@dateAnniversaire, nomPseudonyme=@nomPseudonyme, prenomPseudonyme=@prenomPseudonyme, nom=@nom, prenom=@prenom where id=@id";
            updateAnniversaire = new MySqlCommand(updateCmd, connection);
            MySqlParameter pDateAnniversaire = new MySqlParameter("@dateAnniversaire", unAnniversaire.GetDateAnniversaire());
            MySqlParameter pNomPseudonyme = new MySqlParameter("@nomPseudonyme", unAnniversaire.GetNomPseudonyme());
            MySqlParameter pPrenomPseudonyme = new MySqlParameter("@prenomPseudonyme", unAnniversaire.GetPrenomPseudonyme());
            MySqlParameter pNom = new MySqlParameter("@nom", unAnniversaire.GetNom());
            MySqlParameter pPrenom = new MySqlParameter("@prenom", unAnniversaire.GetPrenom());
            MySqlParameter pId = new MySqlParameter("@id", unAnniversaire.GetID());
            updateAnniversaire.Parameters.Add(pDateAnniversaire);
            updateAnniversaire.Parameters.Add(pNomPseudonyme);
            updateAnniversaire.Parameters.Add(pPrenomPseudonyme);
            updateAnniversaire.Parameters.Add(pNom);
            updateAnniversaire.Parameters.Add(pPrenom);
            updateAnniversaire.Parameters.Add(pId);
            updateAnniversaire.ExecuteNonQuery();
            Console.WriteLine("Modification effectué");


        }

       
    }
}
