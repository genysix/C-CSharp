namespace BufferCirculaire
{
    partial class BufferCirculaire
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
            this.tbxCaractere = new System.Windows.Forms.TextBox();
            this.lblCaractereLu = new System.Windows.Forms.Label();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxCaractere
            // 
            this.tbxCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCaractere.Location = new System.Drawing.Point(68, 46);
            this.tbxCaractere.MaxLength = 1;
            this.tbxCaractere.Name = "tbxCaractere";
            this.tbxCaractere.Size = new System.Drawing.Size(65, 62);
            this.tbxCaractere.TabIndex = 0;
            this.tbxCaractere.Text = "A";
            this.tbxCaractere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCaractereLu
            // 
            this.lblCaractereLu.Location = new System.Drawing.Point(65, 128);
            this.lblCaractereLu.Name = "lblCaractereLu";
            this.lblCaractereLu.Size = new System.Drawing.Size(68, 23);
            this.lblCaractereLu.TabIndex = 1;
            this.lblCaractereLu.Text = "Caractère lu";
            this.lblCaractereLu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(68, 169);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(65, 23);
            this.btnPut.TabIndex = 2;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(194, 169);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(66, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblCaractere
            // 
            this.lblCaractere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblCaractere.Location = new System.Drawing.Point(194, 46);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(66, 62);
            this.lblCaractere.TabIndex = 4;
            this.lblCaractere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrors
            // 
            this.lblErrors.Location = new System.Drawing.Point(191, 128);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(68, 23);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Errors";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BufferCirculaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 252);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.lblCaractereLu);
            this.Controls.Add(this.tbxCaractere);
            this.Name = "BufferCirculaire";
            this.Text = "Buffer Circulaire Version 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCaractere;
        private System.Windows.Forms.Label lblCaractereLu;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.Label lblErrors;
    }
}

