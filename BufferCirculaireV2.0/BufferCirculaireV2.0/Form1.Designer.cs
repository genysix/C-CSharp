namespace BufferCirculaireV2._0
{
    partial class frmBufferCirculaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.lblCaractereLu = new System.Windows.Forms.Label();
            this.tbxCaractere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblErrors
            // 
            this.lblErrors.Location = new System.Drawing.Point(135, 94);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(68, 23);
            this.lblErrors.TabIndex = 11;
            this.lblErrors.Text = "Errors";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaractere
            // 
            this.lblCaractere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblCaractere.Location = new System.Drawing.Point(138, 12);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(66, 62);
            this.lblCaractere.TabIndex = 10;
            this.lblCaractere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(138, 135);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(66, 23);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(12, 135);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(65, 23);
            this.btnPut.TabIndex = 8;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // lblCaractereLu
            // 
            this.lblCaractereLu.Location = new System.Drawing.Point(9, 94);
            this.lblCaractereLu.Name = "lblCaractereLu";
            this.lblCaractereLu.Size = new System.Drawing.Size(68, 23);
            this.lblCaractereLu.TabIndex = 7;
            this.lblCaractereLu.Text = "Caractère lu";
            this.lblCaractereLu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCaractere
            // 
            this.tbxCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCaractere.Location = new System.Drawing.Point(12, 12);
            this.tbxCaractere.MaxLength = 1;
            this.tbxCaractere.Name = "tbxCaractere";
            this.tbxCaractere.Size = new System.Drawing.Size(65, 62);
            this.tbxCaractere.TabIndex = 6;
            this.tbxCaractere.Text = "A";
            this.tbxCaractere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBufferCirculaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 215);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.lblCaractereLu);
            this.Controls.Add(this.tbxCaractere);
            this.Name = "frmBufferCirculaire";
            this.Text = "Buffer Circulaire V2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Label lblCaractereLu;
        private System.Windows.Forms.TextBox tbxCaractere;
    }
}

