namespace ZadDomLab4JakubKazimierski
{
    partial class UndercoverAgentsMenu
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
            this.UndercoverAgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertIdLabel = new System.Windows.Forms.Label();
            this.AgentIdTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AgentUpdateNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameUpdateLabel = new System.Windows.Forms.Label();
            this.InsertGroupBox = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.InsertCriminalIdTextBox = new System.Windows.Forms.TextBox();
            this.InsertCriminalIdLabel = new System.Windows.Forms.Label();
            this.InsertSurnameTextBox = new System.Windows.Forms.TextBox();
            this.InsertNameLabel = new System.Windows.Forms.Label();
            this.InsertNameTextButton = new System.Windows.Forms.TextBox();
            this.InsertSurnameLabel = new System.Windows.Forms.Label();
            this.DeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.DeleteIDLabel = new System.Windows.Forms.Label();
            this.CriminalsUndercoverdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UndercoverAgentsDataGridView)).BeginInit();
            this.UpdateGroupBox.SuspendLayout();
            this.InsertGroupBox.SuspendLayout();
            this.DeleteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsUndercoverdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UndercoverAgentsDataGridView
            // 
            this.UndercoverAgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UndercoverAgentsDataGridView.Location = new System.Drawing.Point(12, 7);
            this.UndercoverAgentsDataGridView.Name = "UndercoverAgentsDataGridView";
            this.UndercoverAgentsDataGridView.RowHeadersWidth = 46;
            this.UndercoverAgentsDataGridView.Size = new System.Drawing.Size(364, 607);
            this.UndercoverAgentsDataGridView.TabIndex = 1;
            // 
            // UpdateGroupBox
            // 
            this.UpdateGroupBox.Controls.Add(this.UpdateButton);
            this.UpdateGroupBox.Controls.Add(this.InsertIdLabel);
            this.UpdateGroupBox.Controls.Add(this.AgentIdTextBox);
            this.UpdateGroupBox.Controls.Add(this.SurnameTextBox);
            this.UpdateGroupBox.Controls.Add(this.AgentUpdateNameLabel);
            this.UpdateGroupBox.Controls.Add(this.NameTextBox);
            this.UpdateGroupBox.Controls.Add(this.SurnameUpdateLabel);
            this.UpdateGroupBox.Location = new System.Drawing.Point(382, 12);
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
            this.InsertIdLabel.Text = "Insert Agent\'s ID ";
            this.InsertIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentIdTextBox
            // 
            this.AgentIdTextBox.Location = new System.Drawing.Point(127, 35);
            this.AgentIdTextBox.Name = "AgentIdTextBox";
            this.AgentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgentIdTextBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(127, 159);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // AgentUpdateNameLabel
            // 
            this.AgentUpdateNameLabel.Location = new System.Drawing.Point(6, 100);
            this.AgentUpdateNameLabel.Name = "AgentUpdateNameLabel";
            this.AgentUpdateNameLabel.Size = new System.Drawing.Size(100, 23);
            this.AgentUpdateNameLabel.TabIndex = 4;
            this.AgentUpdateNameLabel.Text = "Name";
            this.AgentUpdateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(127, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // SurnameUpdateLabel
            // 
            this.SurnameUpdateLabel.Location = new System.Drawing.Point(6, 159);
            this.SurnameUpdateLabel.Name = "SurnameUpdateLabel";
            this.SurnameUpdateLabel.Size = new System.Drawing.Size(100, 23);
            this.SurnameUpdateLabel.TabIndex = 5;
            this.SurnameUpdateLabel.Text = "Last Name";
            this.SurnameUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertGroupBox
            // 
            this.InsertGroupBox.Controls.Add(this.InsertButton);
            this.InsertGroupBox.Controls.Add(this.InsertCriminalIdTextBox);
            this.InsertGroupBox.Controls.Add(this.InsertCriminalIdLabel);
            this.InsertGroupBox.Controls.Add(this.InsertSurnameTextBox);
            this.InsertGroupBox.Controls.Add(this.InsertNameLabel);
            this.InsertGroupBox.Controls.Add(this.InsertNameTextButton);
            this.InsertGroupBox.Controls.Add(this.InsertSurnameLabel);
            this.InsertGroupBox.Location = new System.Drawing.Point(382, 265);
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
            // InsertCriminalIdTextBox
            // 
            this.InsertCriminalIdTextBox.Location = new System.Drawing.Point(127, 169);
            this.InsertCriminalIdTextBox.Name = "InsertCriminalIdTextBox";
            this.InsertCriminalIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsertCriminalIdTextBox.TabIndex = 9;
            // 
            // InsertCriminalIdLabel
            // 
            this.InsertCriminalIdLabel.Location = new System.Drawing.Point(15, 166);
            this.InsertCriminalIdLabel.Name = "InsertCriminalIdLabel";
            this.InsertCriminalIdLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertCriminalIdLabel.TabIndex = 6;
            this.InsertCriminalIdLabel.Text = "Agent Criminal ID";
            this.InsertCriminalIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertSurnameTextBox
            // 
            this.InsertSurnameTextBox.Location = new System.Drawing.Point(127, 102);
            this.InsertSurnameTextBox.Name = "InsertSurnameTextBox";
            this.InsertSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsertSurnameTextBox.TabIndex = 8;
            // 
            // InsertNameLabel
            // 
            this.InsertNameLabel.Location = new System.Drawing.Point(6, 36);
            this.InsertNameLabel.Name = "InsertNameLabel";
            this.InsertNameLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertNameLabel.TabIndex = 4;
            this.InsertNameLabel.Text = "Name";
            this.InsertNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertNameTextButton
            // 
            this.InsertNameTextButton.Location = new System.Drawing.Point(127, 39);
            this.InsertNameTextButton.Name = "InsertNameTextButton";
            this.InsertNameTextButton.Size = new System.Drawing.Size(100, 20);
            this.InsertNameTextButton.TabIndex = 7;
            // 
            // InsertSurnameLabel
            // 
            this.InsertSurnameLabel.Location = new System.Drawing.Point(6, 99);
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
            this.DeleteGroupBox.Location = new System.Drawing.Point(382, 518);
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
            this.DeleteIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeleteIdTextBox.TabIndex = 11;
            // 
            // DeleteIDLabel
            // 
            this.DeleteIDLabel.Location = new System.Drawing.Point(6, 30);
            this.DeleteIDLabel.Name = "DeleteIDLabel";
            this.DeleteIDLabel.Size = new System.Drawing.Size(100, 23);
            this.DeleteIDLabel.TabIndex = 11;
            this.DeleteIDLabel.Text = "Insert Agent\'s ID ";
            this.DeleteIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CriminalsUndercoverdataGridView
            // 
            this.CriminalsUndercoverdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriminalsUndercoverdataGridView.Location = new System.Drawing.Point(646, 12);
            this.CriminalsUndercoverdataGridView.Name = "CriminalsUndercoverdataGridView";
            this.CriminalsUndercoverdataGridView.RowHeadersWidth = 46;
            this.CriminalsUndercoverdataGridView.Size = new System.Drawing.Size(327, 597);
            this.CriminalsUndercoverdataGridView.TabIndex = 14;
            // 
            // UndercoverAgentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 621);
            this.Controls.Add(this.CriminalsUndercoverdataGridView);
            this.Controls.Add(this.DeleteGroupBox);
            this.Controls.Add(this.InsertGroupBox);
            this.Controls.Add(this.UpdateGroupBox);
            this.Controls.Add(this.UndercoverAgentsDataGridView);
            this.Name = "UndercoverAgentsMenu";
            this.Text = "UndercoverAgentsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.UndercoverAgentsDataGridView)).EndInit();
            this.UpdateGroupBox.ResumeLayout(false);
            this.UpdateGroupBox.PerformLayout();
            this.InsertGroupBox.ResumeLayout(false);
            this.InsertGroupBox.PerformLayout();
            this.DeleteGroupBox.ResumeLayout(false);
            this.DeleteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsUndercoverdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UndercoverAgentsDataGridView;
        private System.Windows.Forms.GroupBox UpdateGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label InsertIdLabel;
        private System.Windows.Forms.TextBox AgentIdTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label AgentUpdateNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameUpdateLabel;
        private System.Windows.Forms.GroupBox InsertGroupBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox InsertCriminalIdTextBox;
        private System.Windows.Forms.Label InsertCriminalIdLabel;
        private System.Windows.Forms.TextBox InsertSurnameTextBox;
        private System.Windows.Forms.Label InsertNameLabel;
        private System.Windows.Forms.TextBox InsertNameTextButton;
        private System.Windows.Forms.Label InsertSurnameLabel;
        private System.Windows.Forms.GroupBox DeleteGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteIdTextBox;
        private System.Windows.Forms.Label DeleteIDLabel;
        private System.Windows.Forms.DataGridView CriminalsUndercoverdataGridView;
    }
}