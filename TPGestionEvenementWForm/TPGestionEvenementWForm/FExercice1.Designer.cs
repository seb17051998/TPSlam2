﻿namespace TPGestionEvenementWForm
{
    partial class FExercice1
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
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaisie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(98, 222);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(76, 28);
            this.btnAfficher.TabIndex = 0;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message :";
            // 
            // tbSaisie
            // 
            this.tbSaisie.Location = new System.Drawing.Point(74, 98);
            this.tbSaisie.Name = "tbSaisie";
            this.tbSaisie.Size = new System.Drawing.Size(169, 20);
            this.tbSaisie.TabIndex = 2;
            // 
            // FExercice1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbSaisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficher);
            this.Name = "FExercice1";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaisie;
    }
}

