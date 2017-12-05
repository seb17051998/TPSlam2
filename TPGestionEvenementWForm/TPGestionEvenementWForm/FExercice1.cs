using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPGestionEvenementWForm
{
    public partial class FExercice1 : Form
    {
        public FExercice1()
        {
            InitializeComponent();
            this.btnAfficher.Click += new EventHandler(btnAfficher_Click);
        }

        void btnAfficher_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbSaisie.Text);
        }
    }
}
