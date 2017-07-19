namespace Steganos
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
            this.ofdOpener = new System.Windows.Forms.OpenFileDialog();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblHiddenText = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnShowHiddenText = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdOpener
            // 
            this.ofdOpener.DefaultExt = "bmp";
            this.ofdOpener.FileName = "ChoisirFichierImageBMP";
            this.ofdOpener.Filter = "bmp files (*.bmp) | *.bmp";
            this.ofdOpener.InitialDirectory = "C:\\";
            this.ofdOpener.Title = "Choisir un fichier image (bmp)";
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblHiddenText);
            this.pnl.Location = new System.Drawing.Point(154, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(456, 206);
            this.pnl.TabIndex = 0;
            // 
            // lblHiddenText
            // 
            this.lblHiddenText.AutoSize = true;
            this.lblHiddenText.Location = new System.Drawing.Point(11, 9);
            this.lblHiddenText.Name = "lblHiddenText";
            this.lblHiddenText.Size = new System.Drawing.Size(88, 13);
            this.lblHiddenText.TabIndex = 4;
            this.lblHiddenText.Text = "Information box : ";
            this.lblHiddenText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 12);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(122, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choisir un fichier";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnShowHiddenText
            // 
            this.btnShowHiddenText.Location = new System.Drawing.Point(12, 41);
            this.btnShowHiddenText.Name = "btnShowHiddenText";
            this.btnShowHiddenText.Size = new System.Drawing.Size(122, 23);
            this.btnShowHiddenText.TabIndex = 1;
            this.btnShowHiddenText.Text = "Afficher le text caché";
            this.btnShowHiddenText.UseVisualStyleBackColor = true;
            this.btnShowHiddenText.Click += new System.EventHandler(this.btnShowHiddenText_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImage.Location = new System.Drawing.Point(12, 116);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(122, 102);
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(9, 97);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(120, 13);
            this.lblImage.TabIndex = 3;
            this.lblImage.Text = "Aperçu de votre image :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 230);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.btnShowHiddenText);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "Steganos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpener;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnShowHiddenText;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblHiddenText;
    }
}

