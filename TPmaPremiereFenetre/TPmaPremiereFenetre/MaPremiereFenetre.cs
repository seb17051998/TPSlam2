using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPmaPremiereFenetre
{
    public partial class MaPremiereFenetre : Form
    {
        public MaPremiereFenetre()
        {
            InitializeComponent();
            this.lblBonjour.Text = "Veuillez saisir votre prénom en cochant la langue souhaité";
            this.rdbAnglais.Checked = true;
            this.btnZou.Click += new EventHandler(btnZou_Click);
            this.btnZou.Click += MaprocedureZou;

            

        }

        public void MaprocedureZou(object sender, System.EventArgs e)
        {
            if (rdbAnglais.Checked)
            {
                MessageBox.Show("Hello my friend " + txtPrenom.Text);
            }

            else
            {
                MessageBox.Show("Hallo mein Freund " + txtPrenom.Text);
            }
        }

        void btnZou_Click(object sender, EventArgs e)
        {
            if (rdbAnglais.Checked)
            {
                this.lblBonjour.Text = "Hello my friend " + txtPrenom.Text;
            }

            else 
            {
               this.lblBonjour.Text = "Hallo mein Freund "+ txtPrenom.Text;
            }
        }

        //private void btnZou_Click(object sender, EventArgs e)
        //{
        //    if (rdbAnglais.Checked)
        //    {
        //        this.lblBonjour.Text = "Hello my friend " + txtPrenom.Text;
        //    }

        //    else 
        //    {
        //        this.lblBonjour.Text = "Hallo mein Freund "+ txtPrenom.Text;
        //    }

        //}

    }
}
