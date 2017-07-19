namespace ExCryptage
{
    partial class frmCryptage
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
            this.btnGenererClefs = new System.Windows.Forms.Button();
            this.btnCrypterFichiers = new System.Windows.Forms.Button();
            this.btnDecrypterFichiers = new System.Windows.Forms.Button();
            this.tbxClefs = new System.Windows.Forms.TextBox();
            this.ofdFichierACrypter = new System.Windows.Forms.OpenFileDialog();
            this.ofdFichierADecrypter = new System.Windows.Forms.OpenFileDialog();
            this.odfRepertoireClefs = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdClefPublique = new System.Windows.Forms.OpenFileDialog();
            this.ofdClefSymetriqueCryptee = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnGenererClefs
            // 
            this.btnGenererClefs.Location = new System.Drawing.Point(25, 38);
            this.btnGenererClefs.Name = "btnGenererClefs";
            this.btnGenererClefs.Size = new System.Drawing.Size(99, 23);
            this.btnGenererClefs.TabIndex = 0;
            this.btnGenererClefs.Text = "Générer clés";
            this.btnGenererClefs.UseVisualStyleBackColor = true;
            this.btnGenererClefs.Click += new System.EventHandler(this.btnGenererClefs_Click);
            // 
            // btnCrypterFichiers
            // 
            this.btnCrypterFichiers.Location = new System.Drawing.Point(25, 67);
            this.btnCrypterFichiers.Name = "btnCrypterFichiers";
            this.btnCrypterFichiers.Size = new System.Drawing.Size(205, 23);
            this.btnCrypterFichiers.TabIndex = 1;
            this.btnCrypterFichiers.Text = "Crypter des fichiers...";
            this.btnCrypterFichiers.UseVisualStyleBackColor = true;
            this.btnCrypterFichiers.Click += new System.EventHandler(this.btnCrypterFichiers_Click);
            // 
            // btnDecrypterFichiers
            // 
            this.btnDecrypterFichiers.Location = new System.Drawing.Point(25, 96);
            this.btnDecrypterFichiers.Name = "btnDecrypterFichiers";
            this.btnDecrypterFichiers.Size = new System.Drawing.Size(205, 23);
            this.btnDecrypterFichiers.TabIndex = 2;
            this.btnDecrypterFichiers.Text = "Décrypter le fichier...";
            this.btnDecrypterFichiers.UseVisualStyleBackColor = true;
            this.btnDecrypterFichiers.Click += new System.EventHandler(this.btnDecrypterFichiers_Click);
            // 
            // tbxClefs
            // 
            this.tbxClefs.Location = new System.Drawing.Point(130, 41);
            this.tbxClefs.Name = "tbxClefs";
            this.tbxClefs.Size = new System.Drawing.Size(100, 20);
            this.tbxClefs.TabIndex = 3;
            // 
            // ofdFichierACrypter
            // 
            this.ofdFichierACrypter.FileName = "openFileDialogCrypteFichier";
            this.ofdFichierACrypter.Title = "Fichier à crypter";
            // 
            // ofdFichierADecrypter
            // 
            this.ofdFichierADecrypter.FileName = "openFileDialogDecryptFichier";
            this.ofdFichierADecrypter.Title = "Fichier à decrypter";
            // 
            // odfRepertoireClefs
            // 
            this.odfRepertoireClefs.Description = "Répertoire des clefs";
            // 
            // ofdClefPublique
            // 
            this.ofdClefPublique.Filter = "Clef publique | *Publique.xml";
            this.ofdClefPublique.Tag = "*Publique.xml";
            this.ofdClefPublique.Title = "Clef Publique";
            // 
            // ofdClefSymetriqueCryptee
            // 
            this.ofdClefSymetriqueCryptee.Filter = "Clef publique | *Publique.xml";
            this.ofdClefSymetriqueCryptee.Tag = "*Publique.xml";
            this.ofdClefSymetriqueCryptee.Title = "Clef Publique";
            // 
            // frmCryptage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.tbxClefs);
            this.Controls.Add(this.btnDecrypterFichiers);
            this.Controls.Add(this.btnCrypterFichiers);
            this.Controls.Add(this.btnGenererClefs);
            this.Name = "frmCryptage";
            this.Text = "Cryptage v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenererClefs;
        private System.Windows.Forms.Button btnCrypterFichiers;
        private System.Windows.Forms.Button btnDecrypterFichiers;
        private System.Windows.Forms.TextBox tbxClefs;
        private System.Windows.Forms.OpenFileDialog ofdFichierACrypter;
        private System.Windows.Forms.OpenFileDialog ofdFichierADecrypter;
        private System.Windows.Forms.FolderBrowserDialog odfRepertoireClefs;
        private System.Windows.Forms.OpenFileDialog ofdClefPublique;
        private System.Windows.Forms.OpenFileDialog ofdClefSymetriqueCryptee;
    }
}

