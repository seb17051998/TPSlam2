namespace TPWinFormFiche2
{
    partial class fm_principal
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
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.mn_principal = new System.Windows.Forms.MenuStrip();
            this.sousMenu_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenu_Edition = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_retablir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_copier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_couper = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_coller = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.od_enregistrer = new System.Windows.Forms.SaveFileDialog();
            this.od_enregistrerRapide = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_rechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_texte.Location = new System.Drawing.Point(0, 24);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(284, 238);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            // 
            // mn_principal
            // 
            this.mn_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sousMenu_fichier,
            this.sousMenu_Edition});
            this.mn_principal.Location = new System.Drawing.Point(0, 0);
            this.mn_principal.Name = "mn_principal";
            this.mn_principal.Size = new System.Drawing.Size(284, 24);
            this.mn_principal.TabIndex = 1;
            this.mn_principal.Text = "menuStrip1";
            // 
            // sousMenu_fichier
            // 
            this.sousMenu_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_nouveau,
            this.mi_ouvrir,
            this.mi_enregistrer,
            this.mi_enregistrerSous,
            this.toolStripSeparator1,
            this.mi_quitter});
            this.sousMenu_fichier.Name = "sousMenu_fichier";
            this.sousMenu_fichier.Size = new System.Drawing.Size(54, 20);
            this.sousMenu_fichier.Text = "Fichier";
            // 
            // mi_nouveau
            // 
            this.mi_nouveau.Name = "mi_nouveau";
            this.mi_nouveau.Size = new System.Drawing.Size(175, 22);
            this.mi_nouveau.Text = "Nouveau";
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.Size = new System.Drawing.Size(175, 22);
            this.mi_ouvrir.Text = "Ouvrir";
            // 
            // mi_enregistrer
            // 
            this.mi_enregistrer.Name = "mi_enregistrer";
            this.mi_enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_enregistrer.Size = new System.Drawing.Size(175, 22);
            this.mi_enregistrer.Text = "-Enregistrer";
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.Size = new System.Drawing.Size(175, 22);
            this.mi_enregistrerSous.Text = "Enregistrer sous...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.Size = new System.Drawing.Size(175, 22);
            this.mi_quitter.Text = "Quitter";
            // 
            // sousMenu_Edition
            // 
            this.sousMenu_Edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_annuler,
            this.mi_retablir,
            this.mi_copier,
            this.mi_couper,
            this.mi_coller,
            this.toolStripSeparator2,
            this.mi_rechercher});
            this.sousMenu_Edition.Name = "sousMenu_Edition";
            this.sousMenu_Edition.Size = new System.Drawing.Size(56, 20);
            this.sousMenu_Edition.Text = "Edition";
            // 
            // mi_annuler
            // 
            this.mi_annuler.Name = "mi_annuler";
            this.mi_annuler.Size = new System.Drawing.Size(152, 22);
            this.mi_annuler.Text = "Annuler";
            // 
            // mi_retablir
            // 
            this.mi_retablir.Name = "mi_retablir";
            this.mi_retablir.Size = new System.Drawing.Size(152, 22);
            this.mi_retablir.Text = "Rétablir";
            // 
            // mi_copier
            // 
            this.mi_copier.Name = "mi_copier";
            this.mi_copier.Size = new System.Drawing.Size(152, 22);
            this.mi_copier.Text = "Copier";
            // 
            // mi_couper
            // 
            this.mi_couper.Name = "mi_couper";
            this.mi_couper.Size = new System.Drawing.Size(152, 22);
            this.mi_couper.Text = "Couper";
            // 
            // mi_coller
            // 
            this.mi_coller.Name = "mi_coller";
            this.mi_coller.Size = new System.Drawing.Size(152, 22);
            this.mi_coller.Text = "Coller";
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_rechercher
            // 
            this.mi_rechercher.Name = "mi_rechercher";
            this.mi_rechercher.Size = new System.Drawing.Size(152, 22);
            this.mi_rechercher.Text = "Rechercher";
            // 
            // fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.mn_principal);
            this.MainMenuStrip = this.mn_principal;
            this.Name = "fm_principal";
            this.Text = "Mon petit éditeur";
            this.mn_principal.ResumeLayout(false);
            this.mn_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip mn_principal;
        private System.Windows.Forms.ToolStripMenuItem sousMenu_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.SaveFileDialog od_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem mi_nouveau;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrer;
        private System.Windows.Forms.SaveFileDialog od_enregistrerRapide;
        private System.Windows.Forms.ToolStripMenuItem sousMenu_Edition;
        private System.Windows.Forms.ToolStripMenuItem mi_annuler;
        private System.Windows.Forms.ToolStripMenuItem mi_retablir;
        private System.Windows.Forms.ToolStripMenuItem mi_copier;
        private System.Windows.Forms.ToolStripMenuItem mi_couper;
        private System.Windows.Forms.ToolStripMenuItem mi_coller;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mi_rechercher;
    }
}

