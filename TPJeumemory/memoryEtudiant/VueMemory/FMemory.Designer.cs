namespace VueMemory
{
    partial class FMemory
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreCoupsJoués = new System.Windows.Forms.TextBox();
            this.tbNombrePairesTrouvées = new System.Windows.Forms.TextBox();
            this.tbMeilleurScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre de coups joués :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "meilleur score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nombre de paires trouvées :";
            // 
            // tbNombreCoupsJoués
            // 
            this.tbNombreCoupsJoués.Location = new System.Drawing.Point(157, 210);
            this.tbNombreCoupsJoués.Name = "tbNombreCoupsJoués";
            this.tbNombreCoupsJoués.ReadOnly = true;
            this.tbNombreCoupsJoués.Size = new System.Drawing.Size(40, 20);
            this.tbNombreCoupsJoués.TabIndex = 3;
            this.tbNombreCoupsJoués.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNombrePairesTrouvées
            // 
            this.tbNombrePairesTrouvées.Location = new System.Drawing.Point(157, 231);
            this.tbNombrePairesTrouvées.Name = "tbNombrePairesTrouvées";
            this.tbNombrePairesTrouvées.ReadOnly = true;
            this.tbNombrePairesTrouvées.Size = new System.Drawing.Size(40, 20);
            this.tbNombrePairesTrouvées.TabIndex = 4;
            this.tbNombrePairesTrouvées.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMeilleurScore
            // 
            this.tbMeilleurScore.Location = new System.Drawing.Point(157, 252);
            this.tbMeilleurScore.Name = "tbMeilleurScore";
            this.tbMeilleurScore.ReadOnly = true;
            this.tbMeilleurScore.Size = new System.Drawing.Size(40, 20);
            this.tbMeilleurScore.TabIndex = 5;
            this.tbMeilleurScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 278);
            this.Controls.Add(this.tbMeilleurScore);
            this.Controls.Add(this.tbNombrePairesTrouvées);
            this.Controls.Add(this.tbNombreCoupsJoués);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMemory";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreCoupsJoués;
        private System.Windows.Forms.TextBox tbNombrePairesTrouvées;
        private System.Windows.Forms.TextBox tbMeilleurScore;


    }
}

