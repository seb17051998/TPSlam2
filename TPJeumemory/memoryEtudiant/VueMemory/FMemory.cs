using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace VueMemory
{
    public partial class FMemory : Form
    {
        Button[,] memoryButton;
        Button[] memoryClick;

        // permet de mémoriser qu'un joueur a clické sur deux boutons
        // de manière consécutive.
        // donc qu'il a joué un coup de memory.
        int click;
        // nombre de coups joués par le joueur dans une partie
        int nombreCoupsJoués;
        // nombre de paires de lettres trouvées par le joueur
        int nombrePairesTrouvées;
        // le meilleur score (plus petit nombre de coups) réalisé par le joueur
        int meilleurScore;

        public FMemory()
        {
            InitializeComponent();
            this.meilleurScore = 9999;
            initialiserBoutons();
            initialiserMemory();
        }

        public void initialiserBoutons()
        {
            int tabIndex = 0;
            int xPosition = 20;
            int yPosition = 20;
            this.memoryClick = new Button[2];
            this.memoryButton = new Button[4, 4];
            this.click = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // on crée un bouton un bouton 
                    // dans chaque poste du tableau de boutons
                    // chaque bouton a une position spécifique
                    // mais tous les boutons ont la même taille.
                    this.memoryButton[i, j] = new Button();
                    this.memoryButton[i, j].Location = new Point(xPosition, yPosition);
                    this.memoryButton[i, j].Size = new Size(45, 45);
                    this.memoryButton[i, j].TabIndex = tabIndex;
                    this.memoryButton[i, j].UseVisualStyleBackColor = true;
                    this.Controls.Add(this.memoryButton[i, j]);
                    this.memoryButton[i, j].Click += new EventHandler(FMemory_Click);
                    tabIndex = tabIndex + 1;
                    xPosition = xPosition + 45;
                }
                yPosition = yPosition + 45;
                xPosition = 20;
            }
        }

        void FMemory_Click(object sender, EventArgs e)
        {
            // cette procédure est appelée chaque fois qu'un joueur click sur un bouton
            // elle n'est appelée qu'une seule fois par click
            Button unButton;

            switch (click)
            {
                // cas du premier click sur le premier bouton
                case 0:
                    // dans le cas où c'est un nouveau coup on cache au joueur les valeurs du coup précédent
                    if (memoryClick[0] != null)
                        memoryClick[0].Text = "";
                    if (memoryClick[1] != null)
                        memoryClick[1].Text = "";
                    unButton = (Button)sender;
                    // on affiche à l'utilisateur la valeur contenue dans le bouton sur lequel il a clické
                    unButton.Text = unButton.Name;
                    // on mémorise le bouton sur lequel on vient de clicker
                    memoryClick[0] = unButton;
                    // on comptabilise un click pour exécuter le code du case 2: lors du prochain click
                    this.click = this.click + 1;
                    break;
                // cas du deuxième click sur le deuxième bouton
                   case 1:
                    unButton = (Button)sender;
                    // on affiche à l'utilisateur la valeur contenue dans le bouton sur lequel il a clické
                    unButton.Text = unButton.Name;
                    // on mémorise le bouton sur lequel on vient de clicker
                    memoryClick[1] = unButton;
                    // dans le cas où l'on vient de trouver deux boutons contenant la même lettre
                    if (memoryClick[0].Text == memoryClick[1].Text)
                    {
                        // on interdit à l'utilisateur de clicker à nouveau sur ces boutons
                        memoryClick[0].Enabled = false;
                        memoryClick[1].Enabled = false;
                        memoryClick[0] = null;
                        memoryClick[1] = null;
                    }
                    this.click = 0;
                    break;
            }
        }

        public void initialiserMemory()
        {
            // les lettres sont stockés dans les boutons du memory
            // mais ne sont pas affichées au joueur.
            memoryButton[0,0].Name = "A";
            memoryButton[0,1].Name = "D";
            memoryButton[0,2].Name = "H";
            memoryButton[0,3].Name = "B";

            memoryButton[1, 0].Name = "F";
            memoryButton[1, 1].Name = "G";
            memoryButton[1, 2].Name = "C";
            memoryButton[1, 3].Name = "E";

            memoryButton[2, 0].Name = "E";
            memoryButton[2, 1].Name = "C";
            memoryButton[2, 2].Name = "G";
            memoryButton[2, 3].Name = "F";

            memoryButton[3, 0].Name = "B";
            memoryButton[3, 1].Name = "H";
            memoryButton[3, 2].Name = "D";
            memoryButton[3, 3].Name = "A";
        }
    }
}
