namespace ZadDomLab4JakubKazimierski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UnderTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Niagara Engraved", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1151, 110);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "FBI";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnderTitleLabel
            // 
            this.UnderTitleLabel.Font = new System.Drawing.Font("Onyx", 47.7757F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderTitleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.UnderTitleLabel.Location = new System.Drawing.Point(12, 119);
            this.UnderTitleLabel.Name = "UnderTitleLabel";
            this.UnderTitleLabel.Size = new System.Drawing.Size(1151, 76);
            this.UnderTitleLabel.TabIndex = 1;
            this.UnderTitleLabel.Text = "DATA BASE";
            this.UnderTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZadDomLab4JakubKazimierski.Properties.Resources.LofoFBI2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1175, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UnderTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "FBI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UnderTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

