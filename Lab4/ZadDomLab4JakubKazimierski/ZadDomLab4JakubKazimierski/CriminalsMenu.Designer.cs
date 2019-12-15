namespace ZadDomLab4JakubKazimierski
{
    partial class CriminalsMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CriminalsGridView = new System.Windows.Forms.DataGridView();
            this.UpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertIdLabel = new System.Windows.Forms.Label();
            this.RankTextBox = new System.Windows.Forms.TextBox();
            this.CriminalIdTextBox = new System.Windows.Forms.TextBox();
            this.RankUpdateLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AgentUpdateNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameUpdateLabel = new System.Windows.Forms.Label();
            this.InsertGroupBox = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.InsertBirthLabel = new System.Windows.Forms.Label();
            this.InsertRankTextBox = new System.Windows.Forms.TextBox();
            this.InsertBirthTextBox = new System.Windows.Forms.TextBox();
            this.InsertRankLabel = new System.Windows.Forms.Label();
            this.InsertSurnameTextBox = new System.Windows.Forms.TextBox();
            this.InsertNameLabel = new System.Windows.Forms.Label();
            this.InsertNameTextButton = new System.Windows.Forms.TextBox();
            this.InsertSurnameLabel = new System.Windows.Forms.Label();
            this.DeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.DeleteIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsGridView)).BeginInit();
            this.UpdateGroupBox.SuspendLayout();
            this.InsertGroupBox.SuspendLayout();
            this.DeleteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CriminalsGridView
            // 
            this.CriminalsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CriminalsGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.CriminalsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriminalsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CriminalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CriminalsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CriminalsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CriminalsGridView.Location = new System.Drawing.Point(12, 12);
            this.CriminalsGridView.Name = "CriminalsGridView";
            this.CriminalsGridView.RowHeadersWidth = 46;
            this.CriminalsGridView.Size = new System.Drawing.Size(698, 602);
            this.CriminalsGridView.TabIndex = 0;
            // 
            // UpdateGroupBox
            // 
            this.UpdateGroupBox.Controls.Add(this.UpdateButton);
            this.UpdateGroupBox.Controls.Add(this.InsertIdLabel);
            this.UpdateGroupBox.Controls.Add(this.RankTextBox);
            this.UpdateGroupBox.Controls.Add(this.CriminalIdTextBox);
            this.UpdateGroupBox.Controls.Add(this.RankUpdateLabel);
            this.UpdateGroupBox.Controls.Add(this.SurnameTextBox);
            this.UpdateGroupBox.Controls.Add(this.AgentUpdateNameLabel);
            this.UpdateGroupBox.Controls.Add(this.NameTextBox);
            this.UpdateGroupBox.Controls.Add(this.SurnameUpdateLabel);
            this.UpdateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.UpdateGroupBox.Location = new System.Drawing.Point(716, 12);
            this.UpdateGroupBox.Name = "UpdateGroupBox";
            this.UpdateGroupBox.Size = new System.Drawing.Size(258, 247);
            this.UpdateGroupBox.TabIndex = 11;
            this.UpdateGroupBox.TabStop = false;
            this.UpdateGroupBox.Text = "Update";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(57, 211);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(146, 23);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertIdLabel
            // 
            this.InsertIdLabel.Location = new System.Drawing.Point(6, 33);
            this.InsertIdLabel.Name = "InsertIdLabel";
            this.InsertIdLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertIdLabel.TabIndex = 1;
            this.InsertIdLabel.Text = "Insert Criminal\'s ID ";
            this.InsertIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankTextBox
            // 
            this.RankTextBox.Location = new System.Drawing.Point(127, 169);
            this.RankTextBox.Name = "RankTextBox";
            this.RankTextBox.Size = new System.Drawing.Size(100, 22);
            this.RankTextBox.TabIndex = 9;
            // 
            // CriminalIdTextBox
            // 
            this.CriminalIdTextBox.Location = new System.Drawing.Point(127, 35);
            this.CriminalIdTextBox.Name = "CriminalIdTextBox";
            this.CriminalIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.CriminalIdTextBox.TabIndex = 2;
            // 
            // RankUpdateLabel
            // 
            this.RankUpdateLabel.Location = new System.Drawing.Point(15, 169);
            this.RankUpdateLabel.Name = "RankUpdateLabel";
            this.RankUpdateLabel.Size = new System.Drawing.Size(100, 23);
            this.RankUpdateLabel.TabIndex = 6;
            this.RankUpdateLabel.Text = "Criminal Rank";
            this.RankUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(127, 122);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // AgentUpdateNameLabel
            // 
            this.AgentUpdateNameLabel.Location = new System.Drawing.Point(6, 78);
            this.AgentUpdateNameLabel.Name = "AgentUpdateNameLabel";
            this.AgentUpdateNameLabel.Size = new System.Drawing.Size(100, 23);
            this.AgentUpdateNameLabel.TabIndex = 4;
            this.AgentUpdateNameLabel.Text = "Name";
            this.AgentUpdateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(127, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // SurnameUpdateLabel
            // 
            this.SurnameUpdateLabel.Location = new System.Drawing.Point(6, 120);
            this.SurnameUpdateLabel.Name = "SurnameUpdateLabel";
            this.SurnameUpdateLabel.Size = new System.Drawing.Size(100, 23);
            this.SurnameUpdateLabel.TabIndex = 5;
            this.SurnameUpdateLabel.Text = "Last Name";
            this.SurnameUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertGroupBox
            // 
            this.InsertGroupBox.Controls.Add(this.InsertButton);
            this.InsertGroupBox.Controls.Add(this.InsertBirthLabel);
            this.InsertGroupBox.Controls.Add(this.InsertRankTextBox);
            this.InsertGroupBox.Controls.Add(this.InsertBirthTextBox);
            this.InsertGroupBox.Controls.Add(this.InsertRankLabel);
            this.InsertGroupBox.Controls.Add(this.InsertSurnameTextBox);
            this.InsertGroupBox.Controls.Add(this.InsertNameLabel);
            this.InsertGroupBox.Controls.Add(this.InsertNameTextButton);
            this.InsertGroupBox.Controls.Add(this.InsertSurnameLabel);
            this.InsertGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.InsertGroupBox.Location = new System.Drawing.Point(716, 265);
            this.InsertGroupBox.Name = "InsertGroupBox";
            this.InsertGroupBox.Size = new System.Drawing.Size(258, 247);
            this.InsertGroupBox.TabIndex = 12;
            this.InsertGroupBox.TabStop = false;
            this.InsertGroupBox.Text = "Insert";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(57, 211);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(146, 23);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // InsertBirthLabel
            // 
            this.InsertBirthLabel.Location = new System.Drawing.Point(6, 28);
            this.InsertBirthLabel.Name = "InsertBirthLabel";
            this.InsertBirthLabel.Size = new System.Drawing.Size(115, 33);
            this.InsertBirthLabel.TabIndex = 1;
            this.InsertBirthLabel.Text = "Birth (YYYY-MM-DD)";
            this.InsertBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertRankTextBox
            // 
            this.InsertRankTextBox.Location = new System.Drawing.Point(127, 169);
            this.InsertRankTextBox.Name = "InsertRankTextBox";
            this.InsertRankTextBox.Size = new System.Drawing.Size(100, 22);
            this.InsertRankTextBox.TabIndex = 9;
            // 
            // InsertBirthTextBox
            // 
            this.InsertBirthTextBox.Location = new System.Drawing.Point(127, 35);
            this.InsertBirthTextBox.Name = "InsertBirthTextBox";
            this.InsertBirthTextBox.Size = new System.Drawing.Size(100, 22);
            this.InsertBirthTextBox.TabIndex = 2;
            // 
            // InsertRankLabel
            // 
            this.InsertRankLabel.Location = new System.Drawing.Point(15, 169);
            this.InsertRankLabel.Name = "InsertRankLabel";
            this.InsertRankLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertRankLabel.TabIndex = 6;
            this.InsertRankLabel.Text = "Criminal Rank";
            this.InsertRankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertSurnameTextBox
            // 
            this.InsertSurnameTextBox.Location = new System.Drawing.Point(127, 122);
            this.InsertSurnameTextBox.Name = "InsertSurnameTextBox";
            this.InsertSurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.InsertSurnameTextBox.TabIndex = 8;
            // 
            // InsertNameLabel
            // 
            this.InsertNameLabel.Location = new System.Drawing.Point(6, 78);
            this.InsertNameLabel.Name = "InsertNameLabel";
            this.InsertNameLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertNameLabel.TabIndex = 4;
            this.InsertNameLabel.Text = "Name";
            this.InsertNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertNameTextButton
            // 
            this.InsertNameTextButton.Location = new System.Drawing.Point(127, 78);
            this.InsertNameTextButton.Name = "InsertNameTextButton";
            this.InsertNameTextButton.Size = new System.Drawing.Size(100, 22);
            this.InsertNameTextButton.TabIndex = 7;
            // 
            // InsertSurnameLabel
            // 
            this.InsertSurnameLabel.Location = new System.Drawing.Point(6, 120);
            this.InsertSurnameLabel.Name = "InsertSurnameLabel";
            this.InsertSurnameLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertSurnameLabel.TabIndex = 5;
            this.InsertSurnameLabel.Text = "Last Name";
            this.InsertSurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteGroupBox
            // 
            this.DeleteGroupBox.Controls.Add(this.DeleteButton);
            this.DeleteGroupBox.Controls.Add(this.DeleteIdTextBox);
            this.DeleteGroupBox.Controls.Add(this.DeleteIDLabel);
            this.DeleteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeleteGroupBox.Location = new System.Drawing.Point(716, 518);
            this.DeleteGroupBox.Name = "DeleteGroupBox";
            this.DeleteGroupBox.Size = new System.Drawing.Size(258, 96);
            this.DeleteGroupBox.TabIndex = 13;
            this.DeleteGroupBox.TabStop = false;
            this.DeleteGroupBox.Text = "Delete";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(57, 56);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(146, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteIdTextBox
            // 
            this.DeleteIdTextBox.Location = new System.Drawing.Point(127, 30);
            this.DeleteIdTextBox.Name = "DeleteIdTextBox";
            this.DeleteIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.DeleteIdTextBox.TabIndex = 11;
            // 
            // DeleteIDLabel
            // 
            this.DeleteIDLabel.Location = new System.Drawing.Point(6, 30);
            this.DeleteIDLabel.Name = "DeleteIDLabel";
            this.DeleteIDLabel.Size = new System.Drawing.Size(100, 23);
            this.DeleteIDLabel.TabIndex = 11;
            this.DeleteIDLabel.Text = "Insert Criminal\'s ID ";
            this.DeleteIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CriminalsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(986, 622);
            this.Controls.Add(this.DeleteGroupBox);
            this.Controls.Add(this.InsertGroupBox);
            this.Controls.Add(this.UpdateGroupBox);
            this.Controls.Add(this.CriminalsGridView);
            this.Name = "CriminalsMenu";
            this.Text = "CriminalsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsGridView)).EndInit();
            this.UpdateGroupBox.ResumeLayout(false);
            this.UpdateGroupBox.PerformLayout();
            this.InsertGroupBox.ResumeLayout(false);
            this.InsertGroupBox.PerformLayout();
            this.DeleteGroupBox.ResumeLayout(false);
            this.DeleteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CriminalsGridView;
        private System.Windows.Forms.GroupBox UpdateGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label InsertIdLabel;
        private System.Windows.Forms.TextBox RankTextBox;
        private System.Windows.Forms.TextBox CriminalIdTextBox;
        private System.Windows.Forms.Label RankUpdateLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label AgentUpdateNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameUpdateLabel;
        private System.Windows.Forms.GroupBox InsertGroupBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label InsertBirthLabel;
        private System.Windows.Forms.TextBox InsertRankTextBox;
        private System.Windows.Forms.TextBox InsertBirthTextBox;
        private System.Windows.Forms.Label InsertRankLabel;
        private System.Windows.Forms.TextBox InsertSurnameTextBox;
        private System.Windows.Forms.Label InsertNameLabel;
        private System.Windows.Forms.TextBox InsertNameTextButton;
        private System.Windows.Forms.Label InsertSurnameLabel;
        private System.Windows.Forms.GroupBox DeleteGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteIdTextBox;
        private System.Windows.Forms.Label DeleteIDLabel;
    }
}