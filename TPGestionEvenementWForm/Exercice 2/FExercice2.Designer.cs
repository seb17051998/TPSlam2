namespace Exercice_2
{
    partial class FExercice2
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
            this.btnBonjour = new System.Windows.Forms.Button();
            this.btnMonsieur = new System.Windows.Forms.Button();
            this.btnBjrMr = new System.Windows.Forms.Button();
            this.tbBonjour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBonjour
            // 
            this.btnBonjour.Location = new System.Drawing.Point(23, 45);
            this.btnBonjour.Name = "btnBonjour";
            this.btnBonjour.Size = new System.Drawing.Size(69, 26);
            this.btnBonjour.TabIndex = 0;
            this.btnBonjour.Text = "Bonjour";
            this.btnBonjour.UseVisualStyleBackColor = true;
            // 
            // btnMonsieur
            // 
            this.btnMonsieur.Location = new System.Drawing.Point(23, 94);
            this.btnMonsieur.Name = "btnMonsieur";
            this.btnMonsieur.Size = new System.Drawing.Size(69, 26);
            this.btnMonsieur.TabIndex = 1;
            this.btnMonsieur.Text = "Monsieur";
            this.btnMonsieur.UseVisualStyleBackColor = true;
            // 
            // btnBjrMr
            // 
            this.btnBjrMr.Location = new System.Drawing.Point(23, 144);
            this.btnBjrMr.Name = "btnBjrMr";
            this.btnBjrMr.Size = new System.Drawing.Size(112, 26);
            this.btnBjrMr.TabIndex = 2;
            this.btnBjrMr.Text = "Bonjour, Monsieur";
            this.btnBjrMr.UseVisualStyleBackColor = true;
            // 
            // tbBonjour
            // 
            this.tbBonjour.Location = new System.Drawing.Point(132, 96);
            this.tbBonjour.Name = "tbBonjour";
            this.tbBonjour.Size = new System.Drawing.Size(125, 20);
            this.tbBonjour.TabIndex = 3;
            // 
            // FExercice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 195);
            this.Controls.Add(this.tbBonjour);
            this.Controls.Add(this.btnBjrMr);
            this.Controls.Add(this.btnMonsieur);
            this.Controls.Add(this.btnBonjour);
            this.Name = "FExercice2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBonjour;
        private System.Windows.Forms.Button btnMonsieur;
        private System.Windows.Forms.Button btnBjrMr;
        private System.Windows.Forms.TextBox tbBonjour;
    }
}

