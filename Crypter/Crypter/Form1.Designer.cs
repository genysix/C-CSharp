namespace Crypter
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
            this.btnGenere = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCrypte = new System.Windows.Forms.Button();
            this.btnDecrypte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenere
            // 
            this.btnGenere.Location = new System.Drawing.Point(12, 13);
            this.btnGenere.Name = "btnGenere";
            this.btnGenere.Size = new System.Drawing.Size(135, 23);
            this.btnGenere.TabIndex = 0;
            this.btnGenere.Text = "Générer clés";
            this.btnGenere.UseVisualStyleBackColor = true;
            this.btnGenere.Click += new System.EventHandler(this.btnGenere_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCrypte
            // 
            this.btnCrypte.Location = new System.Drawing.Point(12, 54);
            this.btnCrypte.Name = "btnCrypte";
            this.btnCrypte.Size = new System.Drawing.Size(270, 23);
            this.btnCrypte.TabIndex = 2;
            this.btnCrypte.Text = "Crypter des fichiers...";
            this.btnCrypte.UseVisualStyleBackColor = true;
            this.btnCrypte.Click += new System.EventHandler(this.btnCrypte_Click);
            // 
            // btnDecrypte
            // 
            this.btnDecrypte.Location = new System.Drawing.Point(12, 94);
            this.btnDecrypte.Name = "btnDecrypte";
            this.btnDecrypte.Size = new System.Drawing.Size(270, 23);
            this.btnDecrypte.TabIndex = 3;
            this.btnDecrypte.Text = "Décrypter le fichier...";
            this.btnDecrypte.UseVisualStyleBackColor = true;
            this.btnDecrypte.Click += new System.EventHandler(this.btnDecrypte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 136);
            this.Controls.Add(this.btnDecrypte);
            this.Controls.Add(this.btnCrypte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCrypte;
        private System.Windows.Forms.Button btnDecrypte;
    }
}

