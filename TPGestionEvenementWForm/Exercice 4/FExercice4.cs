using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_4
{
    public partial class FExercice4 : Form
    {
        public FExercice4()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(FExercice4_MouseDown);
            
            
        }

        void FExercice4_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("x: " + e.X.ToString() + " y: " + e.Y.ToString() + " button: " + e.Button.ToString());
        }

      



 
    }
}
