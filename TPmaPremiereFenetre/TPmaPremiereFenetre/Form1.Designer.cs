namespace TPmaPremiereFenetre
{
    partial class MaPremiereFenetre
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
            this.btnZou = new System.Windows.Forms.Button();
            this.gbLangue = new System.Windows.Forms.GroupBox();
            this.rdbAllemand = new System.Windows.Forms.RadioButton();
            this.rdbAnglais = new System.Windows.Forms.RadioButton();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.gbLangue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZou
            // 
            this.btnZou.Location = new System.Drawing.Point(527, 191);
            this.btnZou.Name = "btnZou";
            this.btnZou.Size = new System.Drawing.Size(150, 50);
            this.btnZou.TabIndex = 0;
            this.btnZou.Text = "Zou";
            this.btnZou.UseVisualStyleBackColor = true;
            //this.btnZou.Click += new System.EventHandler(this.btnZou_Click);
            // 
            // gbLangue
            // 
            this.gbLangue.Controls.Add(this.rdbAllemand);
            this.gbLangue.Controls.Add(this.rdbAnglais);
            this.gbLangue.Location = new System.Drawing.Point(225, 32);
            this.gbLangue.Name = "gbLangue";
            this.gbLangue.Size = new System.Drawing.Size(250, 112);
            this.gbLangue.TabIndex = 1;
            this.gbLangue.TabStop = false;
            this.gbLangue.Text = "gbLangue";
            // 
            // rdbAllemand
            // 
            this.rdbAllemand.AutoSize = true;
            this.rdbAllemand.Location = new System.Drawing.Point(7, 56);
            this.rdbAllemand.Name = "rdbAllemand";
            this.rdbAllemand.Size = new System.Drawing.Size(68, 17);
            this.rdbAllemand.TabIndex = 1;
            this.rdbAllemand.TabStop = true;
            this.rdbAllemand.Text = "Allemand";
            this.rdbAllemand.UseVisualStyleBackColor = true;
            // 
            // rdbAnglais
            // 
            this.rdbAnglais.AutoSize = true;
            this.rdbAnglais.Location = new System.Drawing.Point(7, 32);
            this.rdbAnglais.Name = "rdbAnglais";
            this.rdbAnglais.Size = new System.Drawing.Size(59, 17);
            this.rdbAnglais.TabIndex = 0;
            this.rdbAnglais.TabStop = true;
            this.rdbAnglais.Text = "Anglais";
            this.rdbAnglais.UseVisualStyleBackColor = true;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(356, 207);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saisir votre prénom";
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.Location = new System.Drawing.Point(24, 279);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(86, 31);
            this.lblBonjour.TabIndex = 4;
            this.lblBonjour.Text = "label2";
            // 
            // MaPremiereFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.gbLangue);
            this.Controls.Add(this.btnZou);
            this.Name = "MaPremiereFenetre";
            this.Text = "Bonjour";
            this.gbLangue.ResumeLayout(false);
            this.gbLangue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZou;
        private System.Windows.Forms.GroupBox gbLangue;
        private System.Windows.Forms.RadioButton rdbAllemand;
        private System.Windows.Forms.RadioButton rdbAnglais;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBonjour;
    }
}

