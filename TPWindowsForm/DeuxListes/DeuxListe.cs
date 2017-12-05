using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeuxListes
{
    public partial class DeuxListe : Form
    {
        public DeuxListe()
        {
            InitializeComponent();
            this.btnAjouterListe1.Click += new EventHandler(btnAjouterListe1_Click);
            this.btnSupprimerListe1.Click += new EventHandler(btnSupprimerListe1_Click);
            this.btnAjouterListe2.Click += new EventHandler(btnAjouterListe2_Click);
            this.btnSupprimerListe2.Click += new EventHandler(btnSupprimerListe2_Click);
            this.btnDroite.Click += new EventHandler(btnDroite_Click);
            this.btnGauche.Click += new EventHandler(btnGauche_Click);
            this.btnQuitter.Click += new EventHandler(btnQuitter_Click);
            this.listbox1.DoubleClick += new EventHandler(listbox1_DoubleClick);
            this.listbox2.DoubleClick += new EventHandler(listbox2_DoubleClick);   

        }

        void listbox2_DoubleClick(object sender, EventArgs e)
        {
            if (listbox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vous avez rien sélectionné");
            }
            else
            {
                listbox1.Items.Add(listbox2.Text);
                listbox2.Items.RemoveAt(listbox2.SelectedIndex);

            }
        }

        void listbox1_DoubleClick(object sender, EventArgs e)
        {
            if (listbox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vous avez rien sélectionné");
            }
            else
            {
                listbox2.Items.Add(listbox1.Text);
                listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
        }

        void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btnGauche_Click(object sender, EventArgs e)
        {
            if (listbox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vous avez rien sélectionné");
            }
            else
            {
                listbox1.Items.Add(listbox2.Text);
                listbox2.Items.RemoveAt(listbox2.SelectedIndex);
                
            }
        }

        void btnDroite_Click(object sender, EventArgs e)
        {
            if (listbox1.SelectedIndex ==-1)
            {
                MessageBox.Show("Vous avez rien sélectionné");
            }
            else 
            {
            listbox2.Items.Add(listbox1.Text);
            listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
        }

        void btnSupprimerListe2_Click(object sender, EventArgs e)
        {
            if (listbox2.SelectedIndex !=-1)
            {
                listbox2.Items.RemoveAt(listbox2.SelectedIndex);
            }
            else 
            {
                MessageBox.Show("Vous avez rien sélectionné");                
            }
        }

        void btnAjouterListe2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb2.Text))
            {
                MessageBox.Show("Veuillez saisir un texte !");
            }
            else
            {
                listbox2.Items.Add(tb2.Text);
            }
        }

        void btnSupprimerListe1_Click(object sender, EventArgs e)
        {
            if (listbox1.SelectedIndex != -1)
            {
                listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vous avez rien sélectionné");
            }
        }

        void btnAjouterListe1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb1.Text))
            {
                MessageBox.Show("Veuillez saisir un texte !");
            }
            else
            {
                listbox1.Items.Add(tb1.Text);
            }
        }
    }
}
