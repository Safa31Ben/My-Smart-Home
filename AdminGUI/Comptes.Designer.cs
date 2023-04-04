namespace AdminGUI
{
    partial class Comptes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comptes));
            this.comptePanel = new System.Windows.Forms.Panel();
            this.compteTab = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprémier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newAccountBtn = new System.Windows.Forms.Button();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comptePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compteTab)).BeginInit();
            this.SuspendLayout();
            // 
            // comptePanel
            // 
            this.comptePanel.BackColor = System.Drawing.Color.White;
            this.comptePanel.Controls.Add(this.compteTab);
            this.comptePanel.Controls.Add(this.newAccountBtn);
            this.comptePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comptePanel.Location = new System.Drawing.Point(0, 0);
            this.comptePanel.Name = "comptePanel";
            this.comptePanel.Size = new System.Drawing.Size(1001, 727);
            this.comptePanel.TabIndex = 12;
            // 
            // compteTab
            // 
            this.compteTab.AllowUserToAddRows = false;
            this.compteTab.AllowUserToDeleteRows = false;
            this.compteTab.AllowUserToResizeColumns = false;
            this.compteTab.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.compteTab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.compteTab.BackgroundColor = System.Drawing.Color.White;
            this.compteTab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compteTab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compteTab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.compteTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compteTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.nom,
            this.prenom,
            this.supprémier});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compteTab.DefaultCellStyle = dataGridViewCellStyle8;
            this.compteTab.GridColor = System.Drawing.Color.Black;
            this.compteTab.Location = new System.Drawing.Point(30, 97);
            this.compteTab.MultiSelect = false;
            this.compteTab.Name = "compteTab";
            this.compteTab.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compteTab.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.compteTab.RowHeadersVisible = false;
            this.compteTab.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compteTab.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.compteTab.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.compteTab.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.compteTab.RowTemplate.Height = 28;
            this.compteTab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.compteTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.compteTab.Size = new System.Drawing.Size(971, 630);
            this.compteTab.TabIndex = 9;
            this.compteTab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compteTab_CellContentClick);
            // 
            // id
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 45;
            // 
            // username
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.username.DefaultCellStyle = dataGridViewCellStyle4;
            this.username.HeaderText = "Nom de utilisateur";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.username.Width = 135;
            // 
            // nom
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.nom.DefaultCellStyle = dataGridViewCellStyle5;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nom.Width = 155;
            // 
            // prenom
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.prenom.DefaultCellStyle = dataGridViewCellStyle6;
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prenom.Width = 175;
            // 
            // supprémier
            // 
            this.supprémier.DataPropertyName = "supprémier";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.supprémier.DefaultCellStyle = dataGridViewCellStyle7;
            this.supprémier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprémier.HeaderText = "Supprémier";
            this.supprémier.Name = "supprémier";
            this.supprémier.ReadOnly = true;
            this.supprémier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supprémier.Text = "Supprémier";
            this.supprémier.UseColumnTextForButtonValue = true;
            this.supprémier.Width = 110;
            // 
            // newAccountBtn
            // 
            this.newAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.newAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.newAccountBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.newAccountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.newAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAccountBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountBtn.Location = new System.Drawing.Point(790, 19);
            this.newAccountBtn.Name = "newAccountBtn";
            this.newAccountBtn.Size = new System.Drawing.Size(180, 60);
            this.newAccountBtn.TabIndex = 1;
            this.newAccountBtn.Text = "Ajouter Compte";
            this.newAccountBtn.UseVisualStyleBackColor = false;
            this.newAccountBtn.Click += new System.EventHandler(this.newAccountBtn_Click);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "supprémier";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Supprémier";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = global::AdminGUI.Properties.Settings.Default.Supprémier;
            // 
            // Comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 727);
            this.Controls.Add(this.comptePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comptes";
            this.Text = "Comptes";
            this.comptePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compteTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comptePanel;
        private System.Windows.Forms.DataGridView compteTab;
        private System.Windows.Forms.Button newAccountBtn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewButtonColumn supprémier;
    }
}