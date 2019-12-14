namespace ZadDomLab4JakubKazimierski
{
    partial class MainMenu
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
            this.AgentListButton = new System.Windows.Forms.Button();
            this.CriminalsButton = new System.Windows.Forms.Button();
            this.UndercoverAgentsButton = new System.Windows.Forms.Button();
            this.BadgePictureBox = new System.Windows.Forms.PictureBox();
            this.FBIlogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BadgePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBIlogoPictureBox)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
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
            // AgentListButton
            // 
            this.AgentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgentListButton.Font = new System.Drawing.Font("Stencil", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentListButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AgentListButton.Location = new System.Drawing.Point(364, 48);
            this.AgentListButton.Name = "AgentListButton";
            this.AgentListButton.Size = new System.Drawing.Size(416, 85);
            this.AgentListButton.TabIndex = 3;
            this.AgentListButton.Text = "AGENTS";
            this.AgentListButton.UseVisualStyleBackColor = true;
            // 
            // CriminalsButton
            // 
            this.CriminalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriminalsButton.Font = new System.Drawing.Font("Stencil", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriminalsButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CriminalsButton.Location = new System.Drawing.Point(364, 167);
            this.CriminalsButton.Name = "CriminalsButton";
            this.CriminalsButton.Size = new System.Drawing.Size(416, 85);
            this.CriminalsButton.TabIndex = 4;
            this.CriminalsButton.Text = "CRIMINALS";
            this.CriminalsButton.UseVisualStyleBackColor = true;
            // 
            // UndercoverAgentsButton
            // 
            this.UndercoverAgentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndercoverAgentsButton.Font = new System.Drawing.Font("Stencil", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndercoverAgentsButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.UndercoverAgentsButton.Location = new System.Drawing.Point(364, 286);
            this.UndercoverAgentsButton.Name = "UndercoverAgentsButton";
            this.UndercoverAgentsButton.Size = new System.Drawing.Size(416, 85);
            this.UndercoverAgentsButton.TabIndex = 5;
            this.UndercoverAgentsButton.Text = "UNDERCOVER AGENTS";
            this.UndercoverAgentsButton.UseVisualStyleBackColor = true;
            // 
            // BadgePictureBox
            // 
            this.BadgePictureBox.Image = global::ZadDomLab4JakubKazimierski.Properties.Resources.BADGE;
            this.BadgePictureBox.Location = new System.Drawing.Point(815, 48);
            this.BadgePictureBox.Name = "BadgePictureBox";
            this.BadgePictureBox.Size = new System.Drawing.Size(263, 323);
            this.BadgePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BadgePictureBox.TabIndex = 6;
            this.BadgePictureBox.TabStop = false;
            // 
            // FBIlogoPictureBox
            // 
            this.FBIlogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FBIlogoPictureBox.Image = global::ZadDomLab4JakubKazimierski.Properties.Resources.LofoFBI2;
            this.FBIlogoPictureBox.Location = new System.Drawing.Point(15, 48);
            this.FBIlogoPictureBox.Name = "FBIlogoPictureBox";
            this.FBIlogoPictureBox.Size = new System.Drawing.Size(343, 324);
            this.FBIlogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FBIlogoPictureBox.TabIndex = 2;
            this.FBIlogoPictureBox.TabStop = false;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.FBIlogoPictureBox);
            this.ButtonsPanel.Controls.Add(this.BadgePictureBox);
            this.ButtonsPanel.Controls.Add(this.AgentListButton);
            this.ButtonsPanel.Controls.Add(this.UndercoverAgentsButton);
            this.ButtonsPanel.Controls.Add(this.CriminalsButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(13, 198);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(1150, 396);
            this.ButtonsPanel.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1175, 607);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.UnderTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FBI";
            ((System.ComponentModel.ISupportInitialize)(this.BadgePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FBIlogoPictureBox)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UnderTitleLabel;
        private System.Windows.Forms.PictureBox FBIlogoPictureBox;
        private System.Windows.Forms.Button AgentListButton;
        private System.Windows.Forms.Button CriminalsButton;
        private System.Windows.Forms.Button UndercoverAgentsButton;
        private System.Windows.Forms.PictureBox BadgePictureBox;
        private System.Windows.Forms.Panel ButtonsPanel;
    }
}

