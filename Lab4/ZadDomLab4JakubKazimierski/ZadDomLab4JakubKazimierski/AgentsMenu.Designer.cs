﻿namespace ZadDomLab4JakubKazimierski
{
    partial class AgentsMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertIdLabel = new System.Windows.Forms.Label();
            this.AgentIdTextBox = new System.Windows.Forms.TextBox();
            this.AgentUpdateNameLabel = new System.Windows.Forms.Label();
            this.SurnameUpdateLabel = new System.Windows.Forms.Label();
            this.RankUpdateLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.RankTextBox = new System.Windows.Forms.TextBox();
            this.UpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDataGridView)).BeginInit();
            this.UpdateGroupBox.SuspendLayout();
            this.InsertGroupBox.SuspendLayout();
            this.DeleteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgentsDataGridView
            // 
            this.AgentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgentsDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.AgentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AgentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AgentsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.AgentsDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.AgentsDataGridView.Name = "AgentsDataGridView";
            this.AgentsDataGridView.ReadOnly = true;
            this.AgentsDataGridView.RowHeadersWidth = 46;
            this.AgentsDataGridView.Size = new System.Drawing.Size(697, 602);
            this.AgentsDataGridView.TabIndex = 0;
            // 
            // InsertIdLabel
            // 
            this.InsertIdLabel.Location = new System.Drawing.Point(6, 24);
            this.InsertIdLabel.Name = "InsertIdLabel";
            this.InsertIdLabel.Size = new System.Drawing.Size(100, 44);
            this.InsertIdLabel.TabIndex = 1;
            this.InsertIdLabel.Text = "Insert Agent\'s ID ";
            this.InsertIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentIdTextBox
            // 
            this.AgentIdTextBox.Location = new System.Drawing.Point(127, 35);
            this.AgentIdTextBox.Name = "AgentIdTextBox";
            this.AgentIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.AgentIdTextBox.TabIndex = 2;
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
            // SurnameUpdateLabel
            // 
            this.SurnameUpdateLabel.Location = new System.Drawing.Point(6, 120);
            this.SurnameUpdateLabel.Name = "SurnameUpdateLabel";
            this.SurnameUpdateLabel.Size = new System.Drawing.Size(100, 23);
            this.SurnameUpdateLabel.TabIndex = 5;
            this.SurnameUpdateLabel.Text = "Last Name";
            this.SurnameUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankUpdateLabel
            // 
            this.RankUpdateLabel.Location = new System.Drawing.Point(15, 169);
            this.RankUpdateLabel.Name = "RankUpdateLabel";
            this.RankUpdateLabel.Size = new System.Drawing.Size(100, 23);
            this.RankUpdateLabel.TabIndex = 6;
            this.RankUpdateLabel.Text = "Agent Rank";
            this.RankUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(127, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(127, 122);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // RankTextBox
            // 
            this.RankTextBox.Location = new System.Drawing.Point(127, 169);
            this.RankTextBox.Name = "RankTextBox";
            this.RankTextBox.Size = new System.Drawing.Size(100, 22);
            this.RankTextBox.TabIndex = 9;
            // 
            // UpdateGroupBox
            // 
            this.UpdateGroupBox.Controls.Add(this.UpdateButton);
            this.UpdateGroupBox.Controls.Add(this.InsertIdLabel);
            this.UpdateGroupBox.Controls.Add(this.RankTextBox);
            this.UpdateGroupBox.Controls.Add(this.AgentIdTextBox);
            this.UpdateGroupBox.Controls.Add(this.RankUpdateLabel);
            this.UpdateGroupBox.Controls.Add(this.SurnameTextBox);
            this.UpdateGroupBox.Controls.Add(this.AgentUpdateNameLabel);
            this.UpdateGroupBox.Controls.Add(this.NameTextBox);
            this.UpdateGroupBox.Controls.Add(this.SurnameUpdateLabel);
            this.UpdateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.UpdateGroupBox.Location = new System.Drawing.Point(715, 12);
            this.UpdateGroupBox.Name = "UpdateGroupBox";
            this.UpdateGroupBox.Size = new System.Drawing.Size(258, 247);
            this.UpdateGroupBox.TabIndex = 10;
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
            this.InsertGroupBox.Location = new System.Drawing.Point(715, 265);
            this.InsertGroupBox.Name = "InsertGroupBox";
            this.InsertGroupBox.Size = new System.Drawing.Size(258, 247);
            this.InsertGroupBox.TabIndex = 11;
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
            this.InsertBirthLabel.Location = new System.Drawing.Point(6, 18);
            this.InsertBirthLabel.Name = "InsertBirthLabel";
            this.InsertBirthLabel.Size = new System.Drawing.Size(115, 47);
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
            this.InsertRankLabel.Text = "Agent Rank";
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
            this.DeleteGroupBox.Location = new System.Drawing.Point(715, 518);
            this.DeleteGroupBox.Name = "DeleteGroupBox";
            this.DeleteGroupBox.Size = new System.Drawing.Size(258, 96);
            this.DeleteGroupBox.TabIndex = 12;
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
            this.DeleteIDLabel.Location = new System.Drawing.Point(6, 18);
            this.DeleteIDLabel.Name = "DeleteIDLabel";
            this.DeleteIDLabel.Size = new System.Drawing.Size(100, 35);
            this.DeleteIDLabel.TabIndex = 11;
            this.DeleteIDLabel.Text = "Insert Agent\'s ID ";
            this.DeleteIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(985, 626);
            this.Controls.Add(this.DeleteGroupBox);
            this.Controls.Add(this.InsertGroupBox);
            this.Controls.Add(this.UpdateGroupBox);
            this.Controls.Add(this.AgentsDataGridView);
            this.Name = "AgentsMenu";
            this.Text = "AgentsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDataGridView)).EndInit();
            this.UpdateGroupBox.ResumeLayout(false);
            this.UpdateGroupBox.PerformLayout();
            this.InsertGroupBox.ResumeLayout(false);
            this.InsertGroupBox.PerformLayout();
            this.DeleteGroupBox.ResumeLayout(false);
            this.DeleteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AgentsDataGridView;
        private System.Windows.Forms.Label InsertIdLabel;
        private System.Windows.Forms.TextBox AgentIdTextBox;
        private System.Windows.Forms.Label AgentUpdateNameLabel;
        private System.Windows.Forms.Label SurnameUpdateLabel;
        private System.Windows.Forms.Label RankUpdateLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox RankTextBox;
        private System.Windows.Forms.GroupBox UpdateGroupBox;
        private System.Windows.Forms.Button UpdateButton;
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