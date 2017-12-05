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
    public partial class Anniversaire : Form
    {
        MySqlConnection connexion;
        int id;

        
        public Anniversaire()
        {
            InitializeComponent();
            string sCnx = "user=root;password=siojjr;database=baseAnniversaire;host=localhost";
            this.connexion = new MySqlConnection(sCnx); 
            LoadAllAnniversaire();
            
            
            this.btnActualiser.Click += new EventHandler(btnActualiser_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnModifier.Click += new EventHandler(btnModifier_Click);
            this.btnAjouter.Click += new EventHandler(btnAjouter_Click);
            this.btn_Rechercher.Click += new EventHandler(btn_Rechercher_Click);
                

            //SelectAnniversaire();
            
   

            
        }

        void btn_Rechercher_Click(object sender, EventArgs e)
        {
            btnAnneeEtMois rechercher = new btnAnneeEtMois();
            rechercher.Show();
        }

        void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier(); 
            
        }

        void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer la personne ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Supprimer();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        void btnActualiser_Click(object sender, EventArgs e)
        {
            
            LoadAllAnniversaire();
            CompteOccurences();
            this.lbAnniversaire.SelectedIndexChanged += new EventHandler(lbAnniversaire_SelectedIndexChanged);
        }

        void lbAnniversaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllAnniversaire();
            CompteOccurences();
        }

        public void LoadAllAnniversaire()
        {
            lbAnniversaire.Items.Clear();
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
                string nom= Convert.ToString(selectAnnivRead["nom"]);
                string prenom= Convert.ToString(selectAnnivRead["prenom"]);
                anniv = new classAnniversaire(id, dateAnniversaire, nomPseudonyme, prenomPseudonyme, nom, prenom);
                lbAnniversaire.Items.Add(anniv.ToString());
                
                
            }
            connexion.Close();
            CompteOccurences();

        }

        public int CompteOccurences()
        {
            this.connexion.Open();
            string sCompteOccurences ="select count(*) from anniversaire";
            MySqlCommand compteOccurences = new MySqlCommand(sCompteOccurences, connexion);
            int compteOccurResult = Convert.ToInt32(compteOccurences.ExecuteScalar());
            this.lb_compteurEnregistrement.Text = Convert.ToString(compteOccurResult);
            this.connexion.Close();
            return compteOccurResult;
 
        }

        public void Supprimer()
        {
            try
            {
                this.connexion.Open();
                string sCmdSupp = "delete from anniversaire where id=@id";
                MySqlCommand cmdSupprimer = new MySqlCommand(sCmdSupp, connexion);
                MySqlParameter pId = new MySqlParameter("@id", tbID.Text);
                cmdSupprimer.Parameters.Add(pId);
                cmdSupprimer.ExecuteNonQuery();
                this.connexion.Close();
                this.tbID.Clear();
                this.tbDateAnniversaire.Clear();
                this.tbNom.Clear();
                this.tbPrénom.Clear();
                this.tbPseudoNom.Clear();
                this.tbPseudoPrenom.Clear();
                LoadAllAnniversaire();

            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de la suppression d'une personne, veuillez vérifier votre saisie.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Modifier()
        {
            try
            {
                this.connexion.Open();
                string sCmdModifier = "update anniversaire set dateAnniversaire=@dateAnniversaire, nomPseudonyme=@nomPseudonyme, prenomPseudonyme=@prenomPseudonyme, nom=@nom, prenom=@prenom where id=@id";
                MySqlCommand cmdModifier = new MySqlCommand(sCmdModifier, connexion);
                MySqlParameter pDateAnniversaire = new MySqlParameter("@dateAnniversaire", tbDateAnniversaire.Text);
                MySqlParameter pNomPseudonyme = new MySqlParameter("@nomPseudonyme", tbPseudoNom.Text);
                MySqlParameter pPrenomPseudonyme = new MySqlParameter("@prenomPseudonyme", tbPseudoPrenom.Text);
                MySqlParameter pNom = new MySqlParameter("@nom", tbNom.Text);
                MySqlParameter pPrenom = new MySqlParameter("@prenom", tbPrénom.Text);
                MySqlParameter pId = new MySqlParameter("@id", tbID.Text);
                cmdModifier.Parameters.Add(pDateAnniversaire);
                cmdModifier.Parameters.Add(pNomPseudonyme);
                cmdModifier.Parameters.Add(pPrenomPseudonyme);
                cmdModifier.Parameters.Add(pNom);
                cmdModifier.Parameters.Add(pPrenom);
                cmdModifier.Parameters.Add(pId);
                cmdModifier.ExecuteNonQuery();
                this.connexion.Close();
                this.tbID.Clear();
                this.tbDateAnniversaire.Clear();
                this.tbNom.Clear();
                this.tbPrénom.Clear();
                this.tbPseudoNom.Clear();
                this.tbPseudoPrenom.Clear();
                LoadAllAnniversaire();
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de la modification d'une personne, veuillez vérifier votre saisie.", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        public void Ajouter()
        {
            try
            {
                this.connexion.Open();
                string insertCmd = "insert into anniversaire (dateAnniversaire, nomPseudonyme, prenomPseudonyme,nom,prenom) values (@dateAnniversaire,@nomPseudonyme,@prenomPseudonyme,@nom,@prenom)";
                MySqlCommand insertAnniversaire = new MySqlCommand(insertCmd, connexion);
                MySqlParameter pDateAnniversaire = new MySqlParameter("@dateAnniversaire", tbDateAnniversaire.Text);
                MySqlParameter pNomPseudonyme = new MySqlParameter("@nomPseudonyme", tbPseudoNom.Text);
                MySqlParameter pPrenomPseudonyme = new MySqlParameter("@prenomPseudonyme", tbPseudoPrenom.Text);
                MySqlParameter pNom = new MySqlParameter("@nom", tbNom.Text);
                MySqlParameter pPrenom = new MySqlParameter("@prenom", tbPrénom.Text);
                insertAnniversaire.Parameters.Add(pDateAnniversaire);
                insertAnniversaire.Parameters.Add(pNomPseudonyme);
                insertAnniversaire.Parameters.Add(pPrenomPseudonyme);
                insertAnniversaire.Parameters.Add(pNom);
                insertAnniversaire.Parameters.Add(pPrenom);
                int result = insertAnniversaire.ExecuteNonQuery();
                this.connexion.Close();
                LoadAllAnniversaire();
                this.tbID.Clear();
                this.tbDateAnniversaire.Clear();
                this.tbNom.Clear();
                this.tbPrénom.Clear();
                this.tbPseudoNom.Clear();
                this.tbPseudoPrenom.Clear();
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout d'une personne, veuillez vérifier votre saisie.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





       
    }
}
