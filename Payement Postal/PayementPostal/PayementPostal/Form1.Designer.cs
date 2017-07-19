namespace PayementPostal
{
    partial class frmPayementPostal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayementPostal));
            this.PictureBoxBVR = new System.Windows.Forms.PictureBox();
            this.tbxNumeroReference = new System.Windows.Forms.TextBox();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.tbxCompte = new System.Windows.Forms.TextBox();
            this.tbxVersementPour = new System.Windows.Forms.TextBox();
            this.tbxVersePar = new System.Windows.Forms.TextBox();
            this.btnValideLigneCode = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lblCheckDonneesBVR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBVR)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxBVR
            // 
            this.PictureBoxBVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxBVR.BackgroundImage")));
            this.PictureBoxBVR.Location = new System.Drawing.Point(43, 39);
            this.PictureBoxBVR.Name = "PictureBoxBVR";
            this.PictureBoxBVR.Size = new System.Drawing.Size(542, 382);
            this.PictureBoxBVR.TabIndex = 0;
            this.PictureBoxBVR.TabStop = false;
            // 
            // tbxNumeroReference
            // 
            this.tbxNumeroReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNumeroReference.Location = new System.Drawing.Point(277, 162);
            this.tbxNumeroReference.MaxLength = 26;
            this.tbxNumeroReference.Name = "tbxNumeroReference";
            this.tbxNumeroReference.Size = new System.Drawing.Size(293, 13);
            this.tbxNumeroReference.TabIndex = 1;
            this.tbxNumeroReference.Text = "5037236461912148";
            this.tbxNumeroReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(55, 222);
            this.tbxMontant.MaxLength = 11;
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(200, 20);
            this.tbxMontant.TabIndex = 2;
            this.tbxMontant.Text = "123.55";
            // 
            // tbxCompte
            // 
            this.tbxCompte.Location = new System.Drawing.Point(148, 193);
            this.tbxCompte.MaxLength = 11;
            this.tbxCompte.Multiline = true;
            this.tbxCompte.Name = "tbxCompte";
            this.tbxCompte.Size = new System.Drawing.Size(107, 17);
            this.tbxCompte.TabIndex = 3;
            this.tbxCompte.Text = "01-432-5";
            // 
            // tbxVersementPour
            // 
            this.tbxVersementPour.Location = new System.Drawing.Point(55, 76);
            this.tbxVersementPour.Multiline = true;
            this.tbxVersementPour.Name = "tbxVersementPour";
            this.tbxVersementPour.Size = new System.Drawing.Size(167, 76);
            this.tbxVersementPour.TabIndex = 4;
            // 
            // tbxVersePar
            // 
            this.tbxVersePar.Location = new System.Drawing.Point(276, 245);
            this.tbxVersePar.Multiline = true;
            this.tbxVersePar.Name = "tbxVersePar";
            this.tbxVersePar.Size = new System.Drawing.Size(223, 71);
            this.tbxVersePar.TabIndex = 5;
            // 
            // btnValideLigneCode
            // 
            this.btnValideLigneCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValideLigneCode.Location = new System.Drawing.Point(441, 386);
            this.btnValideLigneCode.Name = "btnValideLigneCode";
            this.btnValideLigneCode.Size = new System.Drawing.Size(129, 23);
            this.btnValideLigneCode.TabIndex = 7;
            this.btnValideLigneCode.Text = "Valider la ligne de code";
            this.btnValideLigneCode.UseVisualStyleBackColor = true;
            this.btnValideLigneCode.Click += new System.EventHandler(this.btnValideLigneCode_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.débiteurToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(828, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.créerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.créerToolStripMenuItem.Text = "Créer";
            // 
            // débiteurToolStripMenuItem
            // 
            this.débiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem});
            this.débiteurToolStripMenuItem.Name = "débiteurToolStripMenuItem";
            this.débiteurToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.débiteurToolStripMenuItem.Text = "Débiteur";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(43, 433);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 9;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.ImageKey = "(aucun)";
            this.btnPrecedent.Location = new System.Drawing.Point(276, 485);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(64, 57);
            this.btnPrecedent.TabIndex = 10;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(346, 485);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(64, 57);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(416, 485);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(64, 57);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(486, 485);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(64, 57);
            this.btnSuivant.TabIndex = 13;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // lblCheckDonneesBVR
            // 
            this.lblCheckDonneesBVR.BackColor = System.Drawing.Color.White;
            this.lblCheckDonneesBVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheckDonneesBVR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckDonneesBVR.Location = new System.Drawing.Point(50, 386);
            this.lblCheckDonneesBVR.Name = "lblCheckDonneesBVR";
            this.lblCheckDonneesBVR.Size = new System.Drawing.Size(385, 23);
            this.lblCheckDonneesBVR.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(88, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 13);
            this.textBox1.TabIndex = 15;
            // 
            // frmPayementPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 626);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCheckDonneesBVR);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnValideLigneCode);
            this.Controls.Add(this.tbxVersePar);
            this.Controls.Add(this.tbxVersementPour);
            this.Controls.Add(this.tbxCompte);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.tbxNumeroReference);
            this.Controls.Add(this.PictureBoxBVR);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPayementPostal";
            this.Text = "Payement Postal";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBVR)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxBVR;
        private System.Windows.Forms.TextBox tbxNumeroReference;
        private System.Windows.Forms.TextBox tbxMontant;
        private System.Windows.Forms.TextBox tbxCompte;
        private System.Windows.Forms.TextBox tbxVersementPour;
        private System.Windows.Forms.TextBox tbxVersePar;
        private System.Windows.Forms.Button btnValideLigneCode;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débiteurToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.Label lblCheckDonneesBVR;
        private System.Windows.Forms.TextBox textBox1;
    }
}

