using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdoDotNetForm
{
    public partial class btnAnneeEtMois : Form
    {
        MySqlConnection connexion;
        int id;
        public btnAnneeEtMois()
        {
            InitializeComponent();
            
            string sCnx = "user=root;password=siojjr;database=baseAnniversaire;host=localhost";
            this.connexion = new MySqlConnection(sCnx);
            LoadAllAnniversaire();
            CountAnniversaire();
            for(int i=1; i<32;i++)
            {
                this.cboxJour.Items.Add(i);
            }

            for (int month= 1; month <= 12; month++)
            {
                this.cboxMois.Items.Add(month);
            }
            this.btnResultatDate.Click += new EventHandler(btnResultatDate_Click);
            this.btnResultatLettres.Click += new EventHandler(btnResultatLettres_Click);
            this.btnAfficherTout.Click += new EventHandler(btnAfficherTout_Click);
            this.btnMoisAnnee.Click += new EventHandler(btnMoisAnnee_Click);
            this.btnAffParAn.Click += new EventHandler(btnAffParAn_Click);
            this.btMoisetAnnee.Click += new EventHandler(btMoisetAnnee_Click);
        }

        void btMoisetAnnee_Click(object sender, EventArgs e)
        {
            lb_Anniversaire_Recherche.Items.Clear();
            Affichermois();
            Afficherannee();
            CountMois();
            CountAnneeCache();

        }

        void btnAffParAn_Click(object sender, EventArgs e)
        {
            CountAnnee();
            AfficherAnniversaireParAnnee();
        }

        void btnMoisAnnee_Click(object sender, EventArgs e)
        {
            lb_Anniversaire_Recherche.Items.Clear();
            CountAnniversaireMoisAnnee();
            AfficherAnniversaireMoisDeAnnee();
        }

        void btnAfficherTout_Click(object sender, EventArgs e)
        {
            LoadAllAnniversaire();
            CountAnniversaire();
        }

        void btnResultatLettres_Click(object sender, EventArgs e)
        {
            lb_Anniversaire_Recherche.Items.Clear();
            this.connexion.Open();
            string debutNom= tbSaisieNom.Text;
            string sRechNom = "select * from anniversaire where nom like '" + @debutNom + "%'";
            MySqlCommand rechNom = new MySqlCommand(sRechNom, connexion);
            MySqlParameter dNom = new MySqlParameter("@debutNom", tbSaisieNom.Text);
            rechNom.Parameters.Add(dNom);
            MySqlDataReader readerNom = rechNom.ExecuteReader();
            classAnniversaire annivNom;
            while (readerNom.Read())
            {

                int id = Convert.ToInt32(readerNom["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(readerNom["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(readerNom["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(readerNom["prenomPseudonyme"]);
                string nom = Convert.ToString(readerNom["nom"]);
                string prenom = Convert.ToString(readerNom["prenom"]);
                annivNom = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(annivNom.ToString());
            }
            this.connexion.Close();
        }

        void btnResultatDate_Click(object sender, EventArgs e)
        {
            this.connexion.Open();
            lb_Anniversaire_Recherche.Items.Clear();
            string sCmdresultDate="select * from anniversaire where month(dateAnniversaire)=@mois and day(dateAnniversaire)=@jour";
            MySqlCommand cmdResultDate = new MySqlCommand(sCmdresultDate, connexion);
            MySqlParameter pJour = new MySqlParameter("@jour", cboxJour.Text);
            MySqlParameter pMois = new MySqlParameter("@mois", cboxMois.Text);
            cmdResultDate.Parameters.Add(pJour);
            cmdResultDate.Parameters.Add(pMois);
            MySqlDataReader selectAnnivRead = cmdResultDate.ExecuteReader();
            classAnniversaire anniv;

            while (selectAnnivRead.Read())
            {
                int id = Convert.ToInt32(selectAnnivRead["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(selectAnnivRead["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(selectAnnivRead["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(selectAnnivRead["prenomPseudonyme"]);
                string nom = Convert.ToString(selectAnnivRead["nom"]);
                string prenom = Convert.ToString(selectAnnivRead["prenom"]);
                anniv = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(anniv.ToString());

            }
            
            connexion.Close();
            CountJourMois();
        }

        public void LoadAllAnniversaire()
        {
            lb_Anniversaire_Recherche.Items.Clear();
            this.connexion.Open();

            string sCmdSelect = "select * from anniversaire";
            MySqlCommand selectAnniversaire = new MySqlCommand(sCmdSelect, connexion);
            MySqlDataReader selectAnnivRead = selectAnniversaire.ExecuteReader();




            classAnniversaire anniv;
            while (selectAnnivRead.Read())
            {
                int id = Convert.ToInt32(selectAnnivRead["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(selectAnnivRead["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(selectAnnivRead["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(selectAnnivRead["prenomPseudonyme"]);
                string nom = Convert.ToString(selectAnnivRead["nom"]);
                string prenom = Convert.ToString(selectAnnivRead["prenom"]);
                anniv = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(anniv.ToString());


            }
            connexion.Close();
            //CompteOccurences();

        }

        public void CountAnniversaire()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire";
            MySqlCommand compteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            int compteOccurResult = Convert.ToInt32(compteOccurences.ExecuteScalar());
            this.lbTypeAffichage.Text = "Nombre total d'enregistrements";
            this.lbValeur.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
             
        }

        public void CountAnniversaireMoisAnnee()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire where month(dateAnniversaire)=@month and year(dateAnniversaire)=@year";
            MySqlCommand compteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pmonth = new MySqlParameter("@month", cboxMois.Text);
            MySqlParameter pannee = new MySqlParameter("@year", tbAnnee.Text);
            compteOccurences.Parameters.Add(pmonth);
            compteOccurences.Parameters.Add(pannee);
            int compteOccurResult = Convert.ToInt32(compteOccurences.ExecuteScalar());
            this.lbTypeAffichage.Text = "Mois et année : ";
            this.lbValeur.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();

        }

        public void AfficherAnniversaireMoisDeAnnee()
        {
            this.connexion.Open();
            string sCompteOccurences = "select * from anniversaire where month(dateAnniversaire)=@month and year(dateAnniversaire)=@year";
            MySqlCommand compteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pmonth = new MySqlParameter("@month", cboxMois.Text);
            MySqlParameter pannee = new MySqlParameter("@year", tbAnnee.Text);
            compteOccurences.Parameters.Add(pmonth);
            compteOccurences.Parameters.Add(pannee);
            MySqlDataReader selectAnnivRead = compteOccurences.ExecuteReader();
            classAnniversaire annivMoisAnneeRead;
            while (selectAnnivRead.Read())
            {
                int id = Convert.ToInt32(selectAnnivRead["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(selectAnnivRead["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(selectAnnivRead["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(selectAnnivRead["prenomPseudonyme"]);
                string nom = Convert.ToString(selectAnnivRead["nom"]);
                string prenom = Convert.ToString(selectAnnivRead["prenom"]);
                annivMoisAnneeRead = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(annivMoisAnneeRead.ToString());


            }
            connexion.Close();

            
        }

        public void CountJourMois()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire where day(dateAnniversaire)=@day and month(dateAnniversaire)=@month";
            MySqlCommand compteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pmonth = new MySqlParameter("@month", cboxMois.Text);
            MySqlParameter pjour = new MySqlParameter("@day", cboxJour.Text);
            compteOccurences.Parameters.Add(pmonth);
            compteOccurences.Parameters.Add(pjour);
            int compteOccurResult = Convert.ToInt32(compteOccurences.ExecuteScalar());
            this.lbTypeAffichage.Text = "Mois et Jours : ";
            this.lbValeur.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
        }

        public void CountAnnee()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire where year(dateAnniversaire)=@annee";
            MySqlCommand cmdCompteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pAnnee = new MySqlParameter("@annee", tbAnnee.Text);
            cmdCompteOccurences.Parameters.Add(pAnnee);
            int compteOccurResult = Convert.ToInt32(cmdCompteOccurences.ExecuteScalar());
            this.lbTypeAffichage.Text = "Par année : ";
            this.lbValeur.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
        }

        public void AfficherAnniversaireParAnnee()
        {
            lb_Anniversaire_Recherche.Items.Clear();
            this.connexion.Open();
            string sCompteOccurences = "select * from anniversaire where year(dateAnniversaire)=@annee";
            MySqlCommand cmdCompteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pAnnee = new MySqlParameter("@annee", tbAnnee.Text);
            cmdCompteOccurences.Parameters.Add(pAnnee);
            MySqlDataReader selectAnnivRead = cmdCompteOccurences.ExecuteReader();
            classAnniversaire annivMoisAnneeRead;
            while (selectAnnivRead.Read())
            {
                int id = Convert.ToInt32(selectAnnivRead["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(selectAnnivRead["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(selectAnnivRead["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(selectAnnivRead["prenomPseudonyme"]);
                string nom = Convert.ToString(selectAnnivRead["nom"]);
                string prenom = Convert.ToString(selectAnnivRead["prenom"]);
                annivMoisAnneeRead = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(annivMoisAnneeRead.ToString());
            }
            connexion.Close(); 
        }
        
        public void Affichermois()
        {
            
            this.connexion.Open();
            string sCmdMois = "select * from anniversaire where month(dateAnniversaire)=@month";
            MySqlCommand cmdMois = new MySqlCommand(sCmdMois, connexion);
            MySqlParameter pMois = new MySqlParameter("@month", cboxMois.Text);
            cmdMois.Parameters.Add(pMois);
            MySqlDataReader readerMois = cmdMois.ExecuteReader();
            classAnniversaire mois;
            while (readerMois.Read())
            {
                int id = Convert.ToInt32(readerMois["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(readerMois["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(readerMois["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(readerMois["prenomPseudonyme"]);
                string nom = Convert.ToString(readerMois["nom"]);
                string prenom = Convert.ToString(readerMois["prenom"]);
                mois = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(mois.ToString());

            }
            this.connexion.Close();
        }

        public void Afficherannee()
        {
            this.connexion.Open();
            string sCmdAnnee = "select * from anniversaire where year(dateAnniversaire)=@year";
            MySqlCommand cmdAnnee = new MySqlCommand(sCmdAnnee, connexion);
            MySqlParameter pAnnee = new MySqlParameter("@year", tbAnnee.Text);
            cmdAnnee.Parameters.Add(pAnnee);
            MySqlDataReader readerAnnee = cmdAnnee.ExecuteReader();
            classAnniversaire annee;
            while (readerAnnee.Read())
            {
                int id = Convert.ToInt32(readerAnnee["id"]);
                DateTime dateAnniversaire = Convert.ToDateTime(readerAnnee["dateAnniversaire"]);
                string nomPseudonyme = Convert.ToString(readerAnnee["nomPseudonyme"]);
                string prenomPseudonyme = Convert.ToString(readerAnnee["prenomPseudonyme"]);
                string nom = Convert.ToString(readerAnnee["nom"]);
                string prenom = Convert.ToString(readerAnnee["prenom"]);
                annee = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lb_Anniversaire_Recherche.Items.Add(annee.ToString());

            }
            this.connexion.Close();
        }

        public void CountMois()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire where month(dateAnniversaire)=@mois";
            MySqlCommand cmdCompteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pMois = new MySqlParameter("@mois", cboxMois.Text);
            cmdCompteOccurences.Parameters.Add(pMois);
            int compteOccurResult = Convert.ToInt32(cmdCompteOccurences.ExecuteScalar());
            this.lbTypeAffichage.Text = "Par mois : ";
            this.lbValeur.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
        }

        public void CountAnneeCache()
        {
            this.connexion.Open();
            string sCompteOccurences = "select count(*) from anniversaire where year(dateAnniversaire)=@annee";
            MySqlCommand cmdCompteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            MySqlParameter pannee = new MySqlParameter("@annee", tbAnnee.Text);
            cmdCompteOccurences.Parameters.Add(pannee);
            int compteOccurResult = Convert.ToInt32(cmdCompteOccurences.ExecuteScalar());
            this.lbcache.Text = " et par année : ";
            this.lbValeurCaché.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
        }
        
    }
}
