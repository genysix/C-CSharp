namespace ClefRSA
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
            this.tbxNbPremier1 = new System.Windows.Forms.TextBox();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.tbxNbPremier2 = new System.Windows.Forms.TextBox();
            this.lblNbPremier1 = new System.Windows.Forms.Label();
            this.lblNbPremier2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxE = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblInformations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNbPremier1
            // 
            this.tbxNbPremier1.Location = new System.Drawing.Point(122, 12);
            this.tbxNbPremier1.Name = "tbxNbPremier1";
            this.tbxNbPremier1.Size = new System.Drawing.Size(100, 20);
            this.tbxNbPremier1.TabIndex = 1;
            this.tbxNbPremier1.Text = "29";
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(122, 116);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(100, 23);
            this.btnGenerer.TabIndex = 5;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // tbxNbPremier2
            // 
            this.tbxNbPremier2.Location = new System.Drawing.Point(122, 38);
            this.tbxNbPremier2.Name = "tbxNbPremier2";
            this.tbxNbPremier2.Size = new System.Drawing.Size(100, 20);
            this.tbxNbPremier2.TabIndex = 2;
            this.tbxNbPremier2.Text = "37";
            // 
            // lblNbPremier1
            // 
            this.lblNbPremier1.Location = new System.Drawing.Point(24, 12);
            this.lblNbPremier1.Name = "lblNbPremier1";
            this.lblNbPremier1.Size = new System.Drawing.Size(92, 17);
            this.lblNbPremier1.TabIndex = 5;
            this.lblNbPremier1.Text = "Nb Premier 1 : (p)";
            // 
            // lblNbPremier2
            // 
            this.lblNbPremier2.Location = new System.Drawing.Point(24, 41);
            this.lblNbPremier2.Name = "lblNbPremier2";
            this.lblNbPremier2.Size = new System.Drawing.Size(92, 17);
            this.lblNbPremier2.TabIndex = 6;
            this.lblNbPremier2.Text = "Nb Premier 2 : (q)";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(24, 67);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 17);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message :";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(122, 64);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(100, 20);
            this.tbxMessage.TabIndex = 3;
            this.tbxMessage.Text = "HELLO";
            // 
            // tbxE
            // 
            this.tbxE.Location = new System.Drawing.Point(122, 90);
            this.tbxE.Name = "tbxE";
            this.tbxE.Size = new System.Drawing.Size(100, 20);
            this.tbxE.TabIndex = 4;
            this.tbxE.Text = "71";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(24, 90);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 17);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "E :";
            // 
            // lblInformations
            // 
            this.lblInformations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformations.Location = new System.Drawing.Point(24, 155);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(291, 33);
            this.lblInformations.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 197);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbxE);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblNbPremier2);
            this.Controls.Add(this.lblNbPremier1);
            this.Controls.Add(this.tbxNbPremier2);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.tbxNbPremier1);
            this.Name = "Form1";
            this.Text = "Cryptage V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxNbPremier1;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.TextBox tbxNbPremier2;
        private System.Windows.Forms.Label lblNbPremier1;
        private System.Windows.Forms.Label lblNbPremier2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxE;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblInformations;
    }
}

