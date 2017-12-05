namespace TPWinFormFiche2
{
    partial class rechercher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_rechercher = new System.Windows.Forms.Label();
            this.tb_rechercher = new System.Windows.Forms.TextBox();
            this.bt_Suivant = new System.Windows.Forms.Button();
            this.bt_Precedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_rechercher
            // 
            this.lb_rechercher.AutoSize = true;
            this.lb_rechercher.Location = new System.Drawing.Point(12, 22);
            this.lb_rechercher.Name = "lb_rechercher";
            this.lb_rechercher.Size = new System.Drawing.Size(72, 13);
            this.lb_rechercher.TabIndex = 0;
            this.lb_rechercher.Text = "Rechercher : ";
            // 
            // tb_rechercher
            // 
            this.tb_rechercher.Location = new System.Drawing.Point(90, 19);
            this.tb_rechercher.Name = "tb_rechercher";
            this.tb_rechercher.Size = new System.Drawing.Size(242, 20);
            this.tb_rechercher.TabIndex = 1;
            // 
            // bt_Suivant
            // 
            this.bt_Suivant.Location = new System.Drawing.Point(350, 20);
            this.bt_Suivant.Name = "bt_Suivant";
            this.bt_Suivant.Size = new System.Drawing.Size(79, 19);
            this.bt_Suivant.TabIndex = 2;
            this.bt_Suivant.Text = "Suivant";
            this.bt_Suivant.UseVisualStyleBackColor = true;
            // 
            // bt_Precedent
            // 
            this.bt_Precedent.Location = new System.Drawing.Point(351, 45);
            this.bt_Precedent.Name = "bt_Precedent";
            this.bt_Precedent.Size = new System.Drawing.Size(79, 19);
            this.bt_Precedent.TabIndex = 3;
            this.bt_Precedent.Text = "Précédent";
            this.bt_Precedent.UseVisualStyleBackColor = true;
            // 
            // rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 79);
            this.Controls.Add(this.bt_Precedent);
            this.Controls.Add(this.bt_Suivant);
            this.Controls.Add(this.tb_rechercher);
            this.Controls.Add(this.lb_rechercher);
            this.Name = "rechercher";
            this.Text = "rechercher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rechercher;
        private System.Windows.Forms.TextBox tb_rechercher;
        private System.Windows.Forms.Button bt_Suivant;
        private System.Windows.Forms.Button bt_Precedent;
    }
}