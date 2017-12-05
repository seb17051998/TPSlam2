using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_3
{
    public partial class FExercice3 : Form
    {
        public FExercice3()
        {
            InitializeComponent();
            this.tb_change.TextChanged += new EventHandler(tb_change_TextChanged);
        }

        void tb_change_TextChanged(object sender, EventArgs e)
        {
            tb_change.Text = "Le nom change"; 
        }
    }
}
