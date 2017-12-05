using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdoDotNetForm
{
    public class classAnniversaire
    {
        private DateTime dateAnniversaire;
        private int id;
        private string nom;
        private string nomPseudonyme;
        private string prenom;
        private string prenomPseudonyme;

        public classAnniversaire(int id, DateTime dateAnniversaire, string prenomPseudonyme, string nomPseudonyme, string prenom, string nom)
        {
            this.id = id;
            this.dateAnniversaire = dateAnniversaire;
            this.prenomPseudonyme = prenomPseudonyme;
            this.nomPseudonyme = nomPseudonyme;
            this.prenom = prenom;
            this.nom=nom;
        }

        public classAnniversaire(DateTime dateAnniversaire, string prenomPseudonyme, string nomPseudonyme, string prenom, string nom)
        {
            this.dateAnniversaire = dateAnniversaire;
            this.prenomPseudonyme = prenomPseudonyme;
            this.nomPseudonyme = nomPseudonyme;
            this.prenom = prenom;
            this.nom = nom;
        }

        public DateTime GetDateAnniversaire()
        {
            return dateAnniversaire;
        }

        public int GetID()
        {
            return id;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetNomPseudonyme()
        {
            return nomPseudonyme;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public string GetPrenomPseudonyme()
        {
            return prenomPseudonyme;
        }

        public override string ToString()
        {
            return string.Format(GetID() + " " + GetNomPseudonyme() + " " + GetPrenomPseudonyme() + " " + GetNom() + " " + GetPrenom() + " " + GetDateAnniversaire());
        }

    }
}
