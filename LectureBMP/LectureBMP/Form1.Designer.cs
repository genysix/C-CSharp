namespace LectureBMP
{
    partial class Form1
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
            this.grpBoxMessage = new System.Windows.Forms.GroupBox();
            this.lblMessageCache = new System.Windows.Forms.Label();
            this.lblHauteur = new System.Windows.Forms.Label();
            this.lblLargeur = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.openFileDialogBMP = new System.Windows.Forms.OpenFileDialog();
            this.lblNomFichier = new System.Windows.Forms.Label();
            this.grpBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMessage
            // 
            this.grpBoxMessage.Controls.Add(this.lblMessageCache);
            this.grpBoxMessage.Controls.Add(this.lblHauteur);
            this.grpBoxMessage.Controls.Add(this.lblLargeur);
            this.grpBoxMessage.Controls.Add(this.lblTaille);
            this.grpBoxMessage.Controls.Add(this.lblSignature);
            this.grpBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.grpBoxMessage.Name = "grpBoxMessage";
            this.grpBoxMessage.Size = new System.Drawing.Size(1134, 148);
            this.grpBoxMessage.TabIndex = 0;
            this.grpBoxMessage.TabStop = false;
            this.grpBoxMessage.Text = "Message";
            // 
            // lblMessageCache
            // 
            this.lblMessageCache.AutoSize = true;
            this.lblMessageCache.Location = new System.Drawing.Point(6, 110);
            this.lblMessageCache.Name = "lblMessageCache";
            this.lblMessageCache.Size = new System.Drawing.Size(92, 13);
            this.lblMessageCache.TabIndex = 5;
            this.lblMessageCache.Text = "Message caché : ";
            // 
            // lblHauteur
            // 
            this.lblHauteur.AutoSize = true;
            this.lblHauteur.Location = new System.Drawing.Point(6, 88);
            this.lblHauteur.Name = "lblHauteur";
            this.lblHauteur.Size = new System.Drawing.Size(54, 13);
            this.lblHauteur.TabIndex = 3;
            this.lblHauteur.Text = "Hauteur : ";
            // 
            // lblLargeur
            // 
            this.lblLargeur.AutoSize = true;
            this.lblLargeur.Location = new System.Drawing.Point(6, 65);
            this.lblLargeur.Name = "lblLargeur";
            this.lblLargeur.Size = new System.Drawing.Size(52, 13);
            this.lblLargeur.TabIndex = 2;
            this.lblLargeur.Text = "Largeur : ";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(6, 47);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(41, 13);
            this.lblTaille.TabIndex = 1;
            this.lblTaille.Text = "Taille : ";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(6, 25);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(61, 13);
            this.lblSignature.TabIndex = 0;
            this.lblSignature.Text = "Signature : ";
            // 
            // openFileDialogBMP
            // 
            this.openFileDialogBMP.FileName = "openFileDialog1";
            // 
            // lblNomFichier
            // 
            this.lblNomFichier.AutoSize = true;
            this.lblNomFichier.Location = new System.Drawing.Point(18, 171);
            this.lblNomFichier.Name = "lblNomFichier";
            this.lblNomFichier.Size = new System.Drawing.Size(72, 13);
            this.lblNomFichier.TabIndex = 4;
            this.lblNomFichier.Text = "Nom Fichier : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 223);
            this.Controls.Add(this.lblNomFichier);
            this.Controls.Add(this.grpBoxMessage);
            this.Name = "Form1";
            this.Text = "Lecture BMP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxMessage.ResumeLayout(false);
            this.grpBoxMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMessage;
        private System.Windows.Forms.Label lblLargeur;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblHauteur;
        private System.Windows.Forms.OpenFileDialog openFileDialogBMP;
        private System.Windows.Forms.Label lblNomFichier;
        private System.Windows.Forms.Label lblMessageCache;
    }
}

