namespace AdminGUI
{
    partial class AdminGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGUI));
            this.températureBox = new System.Windows.Forms.TextBox();
            this.Températurelabel = new System.Windows.Forms.Label();
            this.HumiditiLabel = new System.Windows.Forms.Label();
            this.HimiditéBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ProjectTitel = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.picPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comptesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.histoBtn = new System.Windows.Forms.Button();
            this.ConsulterCameraBtn = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.Button();
            this.headPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.picPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // températureBox
            // 
            this.températureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.températureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.températureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.températureBox.Location = new System.Drawing.Point(187, 535);
            this.températureBox.Name = "températureBox";
            this.températureBox.ReadOnly = true;
            this.températureBox.Size = new System.Drawing.Size(114, 23);
            this.températureBox.TabIndex = 4;
            this.températureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Températurelabel
            // 
            this.Températurelabel.AutoSize = true;
            this.Températurelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Températurelabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Températurelabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Températurelabel.Location = new System.Drawing.Point(62, 528);
            this.Températurelabel.Name = "Températurelabel";
            this.Températurelabel.Padding = new System.Windows.Forms.Padding(3);
            this.Températurelabel.Size = new System.Drawing.Size(129, 28);
            this.Températurelabel.TabIndex = 5;
            this.Températurelabel.Text = "Température";
            this.Températurelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumiditiLabel
            // 
            this.HumiditiLabel.AutoSize = true;
            this.HumiditiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.HumiditiLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HumiditiLabel.Location = new System.Drawing.Point(64, 589);
            this.HumiditiLabel.Name = "HumiditiLabel";
            this.HumiditiLabel.Padding = new System.Windows.Forms.Padding(3);
            this.HumiditiLabel.Size = new System.Drawing.Size(93, 28);
            this.HumiditiLabel.TabIndex = 7;
            this.HumiditiLabel.Text = "Humidité";
            // 
            // HimiditéBox
            // 
            this.HimiditéBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.HimiditéBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HimiditéBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HimiditéBox.Location = new System.Drawing.Point(187, 589);
            this.HimiditéBox.Name = "HimiditéBox";
            this.HimiditéBox.ReadOnly = true;
            this.HimiditéBox.Size = new System.Drawing.Size(113, 23);
            this.HimiditéBox.TabIndex = 6;
            this.HimiditéBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1178, 694);
            this.mainPanel.TabIndex = 11;
            // 
            // ProjectTitel
            // 
            this.ProjectTitel.AutoSize = true;
            this.ProjectTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectTitel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectTitel.Location = new System.Drawing.Point(41, 9);
            this.ProjectTitel.Name = "ProjectTitel";
            this.ProjectTitel.Size = new System.Drawing.Size(229, 34);
            this.ProjectTitel.TabIndex = 0;
            this.ProjectTitel.Text = "My Smart Home";
            this.ProjectTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.navPanel.Controls.Add(this.picPanel);
            this.navPanel.Controls.Add(this.pictureBox2);
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Controls.Add(this.comptesBtn);
            this.navPanel.Controls.Add(this.Températurelabel);
            this.navPanel.Controls.Add(this.panel1);
            this.navPanel.Controls.Add(this.panel2);
            this.navPanel.Controls.Add(this.histoBtn);
            this.navPanel.Controls.Add(this.ConsulterCameraBtn);
            this.navPanel.Controls.Add(this.notificationBtn);
            this.navPanel.Controls.Add(this.HumiditiLabel);
            this.navPanel.Controls.Add(this.températureBox);
            this.navPanel.Controls.Add(this.HimiditéBox);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 50);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(300, 694);
            this.navPanel.TabIndex = 11;
            // 
            // picPanel
            // 
            this.picPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picPanel.Controls.Add(this.pictureBox3);
            this.picPanel.Location = new System.Drawing.Point(24, 10);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(250, 200);
            this.picPanel.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::AdminGUI.Properties.Resources.domicile;
            this.pictureBox3.InitialImage = global::AdminGUI.Properties.Resources.domicile;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::AdminGUI.Properties.Resources.humidite_32;
            this.pictureBox2.Image = global::AdminGUI.Properties.Resources.humidite_32;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(20, 582);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::AdminGUI.Properties.Resources.temperature_32;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(21, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comptesBtn
            // 
            this.comptesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comptesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.comptesBtn.FlatAppearance.BorderSize = 0;
            this.comptesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.comptesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.comptesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comptesBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.comptesBtn.ForeColor = System.Drawing.Color.Black;
            this.comptesBtn.Image = global::AdminGUI.Properties.Resources.comptes_32;
            this.comptesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comptesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comptesBtn.Location = new System.Drawing.Point(0, 228);
            this.comptesBtn.Name = "comptesBtn";
            this.comptesBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.comptesBtn.Size = new System.Drawing.Size(300, 60);
            this.comptesBtn.TabIndex = 10;
            this.comptesBtn.Text = "  Consulter Comptes";
            this.comptesBtn.UseVisualStyleBackColor = true;
            this.comptesBtn.Click += new System.EventHandler(this.comptesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(307, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 76);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(307, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 76);
            this.panel2.TabIndex = 12;
            // 
            // histoBtn
            // 
            this.histoBtn.FlatAppearance.BorderSize = 0;
            this.histoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.histoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.histoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.histoBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.histoBtn.ForeColor = System.Drawing.Color.Black;
            this.histoBtn.Image = global::AdminGUI.Properties.Resources.historique_32;
            this.histoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.histoBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.histoBtn.Location = new System.Drawing.Point(0, 292);
            this.histoBtn.Name = "histoBtn";
            this.histoBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.histoBtn.Size = new System.Drawing.Size(300, 60);
            this.histoBtn.TabIndex = 2;
            this.histoBtn.Text = "    Consulter Historique";
            this.histoBtn.UseVisualStyleBackColor = true;
            this.histoBtn.Click += new System.EventHandler(this.histoBtn_Click);
            // 
            // ConsulterCameraBtn
            // 
            this.ConsulterCameraBtn.FlatAppearance.BorderSize = 0;
            this.ConsulterCameraBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ConsulterCameraBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ConsulterCameraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsulterCameraBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.ConsulterCameraBtn.ForeColor = System.Drawing.Color.Black;
            this.ConsulterCameraBtn.Image = global::AdminGUI.Properties.Resources.camera_32;
            this.ConsulterCameraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsulterCameraBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConsulterCameraBtn.Location = new System.Drawing.Point(0, 429);
            this.ConsulterCameraBtn.Name = "ConsulterCameraBtn";
            this.ConsulterCameraBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ConsulterCameraBtn.Size = new System.Drawing.Size(300, 60);
            this.ConsulterCameraBtn.TabIndex = 8;
            this.ConsulterCameraBtn.Text = "  Consulter Camera";
            this.ConsulterCameraBtn.UseVisualStyleBackColor = true;
            this.ConsulterCameraBtn.Click += new System.EventHandler(this.ConsulterCameraBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.FlatAppearance.BorderSize = 0;
            this.notificationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.notificationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.notificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.notificationBtn.ForeColor = System.Drawing.Color.Black;
            this.notificationBtn.Image = global::AdminGUI.Properties.Resources.notification_32;
            this.notificationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notificationBtn.Location = new System.Drawing.Point(0, 360);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.notificationBtn.Size = new System.Drawing.Size(300, 60);
            this.notificationBtn.TabIndex = 3;
            this.notificationBtn.Text = "      Consulter Notification";
            this.notificationBtn.UseVisualStyleBackColor = true;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.headPanel.Controls.Add(this.minimizeBtn);
            this.headPanel.Controls.Add(this.closeBtn);
            this.headPanel.Controls.Add(this.ProjectTitel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1478, 50);
            this.headPanel.TabIndex = 11;
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
            this.closeBtn.Location = new System.Drawing.Point(1418, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 50);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
            this.minimizeBtn.Location = new System.Drawing.Point(1358, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(60, 50);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.picPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button histoBtn;
        private System.Windows.Forms.Button notificationBtn;
        private System.Windows.Forms.TextBox températureBox;
        private System.Windows.Forms.Label Températurelabel;
        private System.Windows.Forms.Label HumiditiLabel;
        private System.Windows.Forms.TextBox HimiditéBox;
        private System.Windows.Forms.Button ConsulterCameraBtn;
        private System.Windows.Forms.Button comptesBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label ProjectTitel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button minimizeBtn;
    }
}

