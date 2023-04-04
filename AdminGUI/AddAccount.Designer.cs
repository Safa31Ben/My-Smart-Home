namespace AdminGUI
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nomField = new System.Windows.Forms.TextBox();
            this.prenomField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.fromPanel = new System.Windows.Forms.Panel();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fromPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 24);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nom";
            // 
            // nomField
            // 
            this.nomField.Location = new System.Drawing.Point(174, 24);
            this.nomField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomField.Name = "nomField";
            this.nomField.Size = new System.Drawing.Size(168, 32);
            this.nomField.TabIndex = 1;
            // 
            // prenomField
            // 
            this.prenomField.Location = new System.Drawing.Point(174, 80);
            this.prenomField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prenomField.Name = "prenomField";
            this.prenomField.Size = new System.Drawing.Size(168, 32);
            this.prenomField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prenom";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(174, 137);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(168, 32);
            this.passwordField.TabIndex = 5;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 137);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 23);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Mot de pass";
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.ajouterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.ajouterBtn.FlatAppearance.BorderSize = 2;
            this.ajouterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ajouterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ajouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterBtn.ForeColor = System.Drawing.Color.Black;
            this.ajouterBtn.Location = new System.Drawing.Point(118, 249);
            this.ajouterBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(125, 47);
            this.ajouterBtn.TabIndex = 6;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = false;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(174, 195);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(168, 32);
            this.usernameField.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 199);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(199, 23);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Nome de utilisation";
            // 
            // fromPanel
            // 
            this.fromPanel.Controls.Add(this.msgBox);
            this.fromPanel.Controls.Add(this.nomField);
            this.fromPanel.Controls.Add(this.nameLabel);
            this.fromPanel.Controls.Add(this.usernameField);
            this.fromPanel.Controls.Add(this.label1);
            this.fromPanel.Controls.Add(this.usernameLabel);
            this.fromPanel.Controls.Add(this.prenomField);
            this.fromPanel.Controls.Add(this.ajouterBtn);
            this.fromPanel.Controls.Add(this.passwordLabel);
            this.fromPanel.Controls.Add(this.passwordField);
            this.fromPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fromPanel.Location = new System.Drawing.Point(0, 42);
            this.fromPanel.Name = "fromPanel";
            this.fromPanel.Size = new System.Drawing.Size(356, 345);
            this.fromPanel.TabIndex = 10;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.White;
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Location = new System.Drawing.Point(0, 314);
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.Size = new System.Drawing.Size(356, 25);
            this.msgBox.TabIndex = 9;
            this.msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(356, 42);
            this.headerPanel.TabIndex = 12;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBtn.Location = new System.Drawing.Point(314, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 42);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ajouter un compte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.fromPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(358, 389);
            this.mainPanel.TabIndex = 13;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeBtn.Location = new System.Drawing.Point(272, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(42, 42);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 389);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.fromPanel.ResumeLayout(false);
            this.fromPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nomField;
        private System.Windows.Forms.TextBox prenomField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel fromPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button minimizeBtn;
    }
}