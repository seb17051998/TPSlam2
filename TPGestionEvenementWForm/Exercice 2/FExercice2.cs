using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_2
{
    public partial class FExercice2 : Form
    {
        public FExercice2()
        {
            InitializeComponent();
            this.btnBonjour.Click += new EventHandler(btnBonjour_Click);
            this.btnMonsieur.Click += new EventHandler(btnMonsieur_Click);
            this.btnBjrMr.Click += new EventHandler(btnBjrMr_Click);
        }

        void btnBjrMr_Click(object sender, EventArgs e)
        {
            tbBonjour.Text = "Bonjour, Monsieur";
        }

        void btnMonsieur_Click(object sender, EventArgs e)
        {
            tbBonjour.Text = "Monsieur";
        }

        void btnBonjour_Click(object sender, EventArgs e)
        {
            tbBonjour.Text = "Bonjour";
        }
    }
}
