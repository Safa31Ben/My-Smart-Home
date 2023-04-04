namespace AdminGUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.headPanel = new System.Windows.Forms.Panel();
            this.ProjectTitel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.accessBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.headPanel.Controls.Add(this.ProjectTitel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(342, 55);
            this.headPanel.TabIndex = 34;
            // 
            // ProjectTitel
            // 
            this.ProjectTitel.AutoSize = true;
            this.ProjectTitel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitel.Location = new System.Drawing.Point(99, 18);
            this.ProjectTitel.Name = "ProjectTitel";
            this.ProjectTitel.Size = new System.Drawing.Size(229, 34);
            this.ProjectTitel.TabIndex = 1;
            this.ProjectTitel.Text = "My Smart Home";
            this.ProjectTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.White;
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox.Location = new System.Drawing.Point(0, 256);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.Size = new System.Drawing.Size(342, 50);
            this.msgBox.TabIndex = 33;
            this.msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accessBtn
            // 
            this.accessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.accessBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.accessBtn.FlatAppearance.BorderSize = 2;
            this.accessBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.accessBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.accessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accessBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessBtn.ForeColor = System.Drawing.Color.Black;
            this.accessBtn.Location = new System.Drawing.Point(105, 193);
            this.accessBtn.Margin = new System.Windows.Forms.Padding(5);
            this.accessBtn.Name = "accessBtn";
            this.accessBtn.Padding = new System.Windows.Forms.Padding(2);
            this.accessBtn.Size = new System.Drawing.Size(132, 35);
            this.accessBtn.TabIndex = 32;
            this.accessBtn.Text = "Access";
            this.accessBtn.UseVisualStyleBackColor = false;
            this.accessBtn.Click += new System.EventHandler(this.accessBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(167, 146);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(164, 32);
            this.passwordBox.TabIndex = 31;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 23);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Mot de pass";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(168, 91);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(164, 32);
            this.usernameBox.TabIndex = 29;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(9, 94);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(187, 23);
            this.idLabel.TabIndex = 28;
            this.idLabel.Text = "Nom de utilisateur";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.usernameBox);
            this.formPanel.Controls.Add(this.headPanel);
            this.formPanel.Controls.Add(this.idLabel);
            this.formPanel.Controls.Add(this.msgBox);
            this.formPanel.Controls.Add(this.passwordLabel);
            this.formPanel.Controls.Add(this.accessBtn);
            this.formPanel.Controls.Add(this.passwordBox);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formPanel.Location = new System.Drawing.Point(0, 32);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(342, 306);
            this.formPanel.TabIndex = 35;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.formPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(344, 340);
            this.mainPanel.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 34);
            this.panel2.TabIndex = 12;
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
            this.closeBtn.Location = new System.Drawing.Point(295, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 34);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.minimizeBtn.Location = new System.Drawing.Point(248, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(47, 34);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 340);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label ProjectTitel;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button accessBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeBtn;
    }
}