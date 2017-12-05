using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPWindowsForm
{
    public partial class fm_principal : Form
    {
        public fm_principal()
        {
            InitializeComponent();
        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_saisie.Text))
            {
                MessageBox.Show("Vous avez rien mis dans la zone de saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lb_liste.Items.Add(tb_saisie.Text);
                tb_saisie.Text = "";
                tb_saisie.Focus();
            }
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {
            if (lb_liste.SelectedIndex != -1)
            {
                lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vous avez pas sélectionné un Item dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

      
    }
}
