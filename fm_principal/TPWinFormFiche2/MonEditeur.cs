using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TPWinFormFiche2
{
    public partial class fm_principal : Form
    {
        public fm_principal()
        {
            InitializeComponent();
            this.mi_quitter.Click += new EventHandler(mi_quitter_Click);
            this.mi_ouvrir.Click += new EventHandler(mi_ouvrir_Click);
            this.mi_enregistrerSous.Click += new EventHandler(mi_enregistrerSous_Click);
            this.mi_enregistrer.Click += new EventHandler(mi_enregistrer_Click);
            this.mi_nouveau.Click += new EventHandler(mi_nouveau_Click);
            this.mi_copier.Click += new EventHandler(mi_copier_Click);
            this.mi_coller.Click += new EventHandler(mi_coller_Click);
            this.mi_couper.Click += new EventHandler(mi_couper_Click);
            this.mi_annuler.Click += new EventHandler(mi_annuler_Click);
            this.mi_retablir.Click += new EventHandler(mi_retablir_Click);
            this.mi_rechercher.Click += new EventHandler(mi_rechercher_Click);
            
        }

        void mi_rechercher_Click(object sender, EventArgs e)
        {
            rechercher search = new rechercher();
            search.Show();

            /*for (int index = rt_texte.SelectionStart + 1; index < rt_texte.Text.Length; index++)
            {
                rt_texte.Find(rt_texte.Text, index, rt_texte.Text.Length, RichTextBoxFinds.None);
                rt_texte.Focus();

            }*/

        }

        void mi_retablir_Click(object sender, EventArgs e)
        {
            rt_texte.Redo();
        }

        void mi_annuler_Click(object sender, EventArgs e)
        {
            rt_texte.Undo();
        }

        void mi_couper_Click(object sender, EventArgs e)
        {
            rt_texte.Cut();
        }

        void mi_coller_Click(object sender, EventArgs e)
        {
            rt_texte.Paste();    
        }

        void mi_copier_Click(object sender, EventArgs e)
        {
            rt_texte.Copy();
        }

        

        void mi_nouveau_Click(object sender, EventArgs e)
        {
            
            DialogResult dlResult = MessageBox.Show("Voulez vous faire un nouveau fichier ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch(dlResult)
            {
                case DialogResult.Yes:
                    fm_principal fx = new fm_principal();
                    fx.Show();
                    break;

            }

        }

        void mi_enregistrer_Click(object sender, EventArgs e)
        {
            
           
            rt_texte.SaveFile(od_enregistrer.FileName, RichTextBoxStreamType.PlainText);
        }

        void mi_enregistrerSous_Click(object sender, EventArgs e)
        {
            od_enregistrer.Filter = "Fichier texte (*.txt)|*.txt";
            if (od_enregistrer.ShowDialog() == DialogResult.OK)
            {
                
                rt_texte.SaveFile(od_enregistrer.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        

        void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
                
            }
        }

        void mi_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
