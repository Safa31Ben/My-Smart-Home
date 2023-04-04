namespace AdminGUI
{
    partial class CameraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            this.cameraPanel = new System.Windows.Forms.Panel();
            this.liveBox = new System.Windows.Forms.PictureBox();
            this.cameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPanel
            // 
            this.cameraPanel.BackColor = System.Drawing.Color.White;
            this.cameraPanel.Controls.Add(this.liveBox);
            this.cameraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraPanel.Location = new System.Drawing.Point(0, 0);
            this.cameraPanel.Name = "cameraPanel";
            this.cameraPanel.Size = new System.Drawing.Size(592, 517);
            this.cameraPanel.TabIndex = 2;
            // 
            // liveBox
            // 
            this.liveBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveBox.Location = new System.Drawing.Point(0, 0);
            this.liveBox.Name = "liveBox";
            this.liveBox.Size = new System.Drawing.Size(592, 517);
            this.liveBox.TabIndex = 2;
            this.liveBox.TabStop = false;
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 517);
            this.Controls.Add(this.cameraPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.cameraPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liveBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cameraPanel;
        private System.Windows.Forms.PictureBox liveBox;
    }
}