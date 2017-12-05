namespace AdoDotNetForm
{
    partial class Anniversaire
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
            this.lbAnniversaire = new System.Windows.Forms.ListBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.dateAnnivlabel = new System.Windows.Forms.Label();
            this.pseudoPrenom = new System.Windows.Forms.Label();
            this.pseudoNom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDateAnniversaire = new System.Windows.Forms.TextBox();
            this.tbPseudoNom = new System.Windows.Forms.TextBox();
            this.tbPseudoPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrénom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_compteurEnregistrement = new System.Windows.Forms.Label();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAnniversaire
            // 
            this.lbAnniversaire.FormattingEnabled = true;
            this.lbAnniversaire.Location = new System.Drawing.Point(15, 12);
            this.lbAnniversaire.Name = "lbAnniversaire";
            this.lbAnniversaire.Size = new System.Drawing.Size(348, 368);
            this.lbAnniversaire.TabIndex = 0;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(378, 16);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(21, 13);
            this.idlabel.TabIndex = 1;
            this.idlabel.Text = "id :";
            // 
            // dateAnnivlabel
            // 
            this.dateAnnivlabel.AutoSize = true;
            this.dateAnnivlabel.Location = new System.Drawing.Point(378, 52);
            this.dateAnnivlabel.Name = "dateAnnivlabel";
            this.dateAnnivlabel.Size = new System.Drawing.Size(184, 13);
            this.dateAnnivlabel.TabIndex = 2;
            this.dateAnnivlabel.Text = "Date anniversaire format(aaaa-mm-jj) :";
            // 
            // pseudoPrenom
            // 
            this.pseudoPrenom.AutoSize = true;
            this.pseudoPrenom.Location = new System.Drawing.Point(378, 143);
            this.pseudoPrenom.Name = "pseudoPrenom";
            this.pseudoPrenom.Size = new System.Drawing.Size(112, 13);
            this.pseudoPrenom.TabIndex = 3;
            this.pseudoPrenom.Text = "Pseudonyme prénom :";
            // 
            // pseudoNom
            // 
            this.pseudoNom.AutoSize = true;
            this.pseudoNom.Location = new System.Drawing.Point(378, 96);
            this.pseudoNom.Name = "pseudoNom";
            this.pseudoNom.Size = new System.Drawing.Size(97, 13);
            this.pseudoNom.TabIndex = 4;
            this.pseudoNom.Text = "Pseudonyme nom :";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(378, 192);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(35, 13);
            this.nom.TabIndex = 5;
            this.nom.Text = "Nom :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(376, 239);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(49, 13);
            this.prenom.TabIndex = 6;
            this.prenom.Text = "Prénom :";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(405, 13);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(241, 20);
            this.tbID.TabIndex = 7;
            // 
            // tbDateAnniversaire
            // 
            this.tbDateAnniversaire.Location = new System.Drawing.Point(568, 49);
            this.tbDateAnniversaire.Name = "tbDateAnniversaire";
            this.tbDateAnniversaire.Size = new System.Drawing.Size(168, 20);
            this.tbDateAnniversaire.TabIndex = 8;
            // 
            // tbPseudoNom
            // 
            this.tbPseudoNom.Location = new System.Drawing.Point(478, 96);
            this.tbPseudoNom.Name = "tbPseudoNom";
            this.tbPseudoNom.Size = new System.Drawing.Size(168, 20);
            this.tbPseudoNom.TabIndex = 9;
            // 
            // tbPseudoPrenom
            // 
            this.tbPseudoPrenom.Location = new System.Drawing.Point(496, 140);
            this.tbPseudoPrenom.Name = "tbPseudoPrenom";
            this.tbPseudoPrenom.Size = new System.Drawing.Size(153, 20);
            this.tbPseudoPrenom.TabIndex = 10;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(419, 189);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(223, 20);
            this.tbNom.TabIndex = 11;
            // 
            // tbPrénom
            // 
            this.tbPrénom.Location = new System.Drawing.Point(429, 236);
            this.tbPrénom.Name = "tbPrénom";
            this.tbPrénom.Size = new System.Drawing.Size(213, 20);
            this.tbPrénom.TabIndex = 12;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(369, 319);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(95, 27);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(496, 319);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 27);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(620, 319);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 27);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(496, 363);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(95, 27);
            this.btnActualiser.TabIndex = 16;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(620, 363);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(95, 27);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre d\'enregistrements : ";
            // 
            // lb_compteurEnregistrement
            // 
            this.lb_compteurEnregistrement.AutoSize = true;
            this.lb_compteurEnregistrement.Location = new System.Drawing.Point(140, 389);
            this.lb_compteurEnregistrement.Name = "lb_compteurEnregistrement";
            this.lb_compteurEnregistrement.Size = new System.Drawing.Size(29, 13);
            this.lb_compteurEnregistrement.TabIndex = 19;
            this.lb_compteurEnregistrement.Text = "NaN";
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(200, 387);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(88, 27);
            this.btn_Rechercher.TabIndex = 20;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            // 
            // Anniversaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(765, 415);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.lb_compteurEnregistrement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbPrénom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPseudoPrenom);
            this.Controls.Add(this.tbPseudoNom);
            this.Controls.Add(this.tbDateAnniversaire);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.pseudoNom);
            this.Controls.Add(this.pseudoPrenom);
            this.Controls.Add(this.dateAnnivlabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.lbAnniversaire);
            this.Name = "Anniversaire";
            this.Text = "Anniversaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnniversaire;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label dateAnnivlabel;
        private System.Windows.Forms.Label pseudoPrenom;
        private System.Windows.Forms.Label pseudoNom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbDateAnniversaire;
        private System.Windows.Forms.TextBox tbPseudoNom;
        private System.Windows.Forms.TextBox tbPseudoPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrénom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_compteurEnregistrement;
        private System.Windows.Forms.Button btn_Rechercher;
    }
}

