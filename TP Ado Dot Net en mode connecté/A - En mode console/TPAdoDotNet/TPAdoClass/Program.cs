using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPAdoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int annee, mois, jour, id;
            string nomPseudonyme, prenomPseudonyme, nom, prenom;
            
            
            

            ConnectionJoyeuxAnniversaire.GetConnection().Open();
            
            TableAnniversaire annivCount = new TableAnniversaire();
            Console.WriteLine(annivCount.ComptesOccurences());
            //Console.WriteLine("Il y a {0} enregistrement",annivCount.ComptesOccurences());
            //Console.WriteLine(annivCount.LeNomPatronymiqueCommencePar("a"));
            
            //ConnectionJoyeuxAnniversaire.GetConnection().Close();
            //ConnectionJoyeuxAnniversaire.GetConnection().Open();
            //Console.WriteLine(annivCount.QuiEstNeCeJour(17,05));
            //Insertion
            //Console.WriteLine("Saisir année de naissance, mois de naissance, jour de naissance ,nomPseudonyme,prenomPseudonyme,nom,prenom");

            //annee = Convert.ToInt32(Console.ReadLine());
            //mois = Convert.ToInt32(Console.ReadLine());
            //jour = Convert.ToInt32(Console.ReadLine());
            //nomPseudonyme = Console.ReadLine();
            //prenomPseudonyme = Console.ReadLine();
            //nom = Console.ReadLine();
            //prenom = Console.ReadLine();
            //id = Convert.ToInt32(Console.ReadLine());
            //DateTime dateAnniversaire = new DateTime(annee, mois, jour);
            //Anniversaire monAnniv = new Anniversaire(id, dateAnniversaire, prenomPseudonyme, nomPseudonyme, prenom, nom);
            //annivCount.Update(monAnniv);
            //annivCount.Insert(monAnniv);
            //annivCount.Delete(1662);
            


            Console.ReadLine();
        }
    }
}
