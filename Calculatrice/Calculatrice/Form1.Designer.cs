namespace Calculatrice
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
            this.btnCalcul = new System.Windows.Forms.Button();
            this.lblReponse = new System.Windows.Forms.Label();
            this.tbCalcul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(97, 185);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(75, 23);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Location = new System.Drawing.Point(94, 109);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(0, 13);
            this.lblReponse.TabIndex = 1;
            // 
            // tbCalcul
            // 
            this.tbCalcul.Location = new System.Drawing.Point(39, 58);
            this.tbCalcul.Name = "tbCalcul";
            this.tbCalcul.Size = new System.Drawing.Size(233, 20);
            this.tbCalcul.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbCalcul);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.btnCalcul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label lblReponse;
        private System.Windows.Forms.TextBox tbCalcul;
    }
}

