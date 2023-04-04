namespace AdminGUI
{
    partial class HistoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoForm));
            this.histoTable = new System.Windows.Forms.DataGridView();
            this.IDhisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomHisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomHisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.histoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // histoTable
            // 
            this.histoTable.AllowUserToAddRows = false;
            this.histoTable.AllowUserToDeleteRows = false;
            this.histoTable.AllowUserToResizeColumns = false;
            this.histoTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.histoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.histoTable.BackgroundColor = System.Drawing.Color.White;
            this.histoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.histoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.histoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.histoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.histoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDhisto,
            this.NomHisto,
            this.prenomHisto,
            this.dateHisto});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.histoTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.histoTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.histoTable.Location = new System.Drawing.Point(45, 10);
            this.histoTable.Name = "histoTable";
            this.histoTable.ReadOnly = true;
            this.histoTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.histoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.histoTable.RowHeadersVisible = false;
            this.histoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.histoTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.histoTable.RowTemplate.Height = 28;
            this.histoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.histoTable.Size = new System.Drawing.Size(975, 688);
            this.histoTable.TabIndex = 0;
            // 
            // IDhisto
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.IDhisto.DefaultCellStyle = dataGridViewCellStyle3;
            this.IDhisto.HeaderText = "ID";
            this.IDhisto.Name = "IDhisto";
            this.IDhisto.ReadOnly = true;
            this.IDhisto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDhisto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDhisto.Width = 50;
            // 
            // NomHisto
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.NomHisto.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomHisto.HeaderText = "Nom";
            this.NomHisto.Name = "NomHisto";
            this.NomHisto.ReadOnly = true;
            this.NomHisto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomHisto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NomHisto.Width = 170;
            // 
            // prenomHisto
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.prenomHisto.DefaultCellStyle = dataGridViewCellStyle5;
            this.prenomHisto.HeaderText = "Prenom";
            this.prenomHisto.Name = "prenomHisto";
            this.prenomHisto.ReadOnly = true;
            this.prenomHisto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prenomHisto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prenomHisto.Width = 200;
            // 
            // dateHisto
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dateHisto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateHisto.HeaderText = "Date";
            this.dateHisto.Name = "dateHisto";
            this.dateHisto.ReadOnly = true;
            this.dateHisto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateHisto.Width = 180;
            // 
            // HistoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 688);
            this.Controls.Add(this.histoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoForm";
            this.Text = "HistoForm";
            ((System.ComponentModel.ISupportInitialize)(this.histoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView histoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDhisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomHisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomHisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHisto;

    }
}