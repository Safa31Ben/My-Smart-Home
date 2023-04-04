using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Système_de_surveillance_bib;

namespace AdminGUI
{
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();
            loadform(new Comptes());
            ConsulterTémpHumidié();
        }
        
        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
         
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private async void ConsulterTémpHumidié()
        {
            ConsulterHumidite oh = (ConsulterHumidite)Activator.GetObject(typeof(ConsulterHumidite),
                "tcp://localhost:8085/température et humidité");
            ConsulterTempérature ot = (ConsulterTempérature)Activator.GetObject(typeof(ConsulterTempérature),
                "tcp://localhost:8085/température et humidité"); 
            while (true)
            {
                this.HimiditéBox.Text = oh.getHumidite().ToString() + " %";
                this.températureBox.Text = ot.getTemperature().ToString() + " °C"; 
                await Task.Delay(500);
            }
        }
  
        private void histoBtn_Click(object sender, EventArgs e)
        {
            CameraForm.colseCamera();
            loadform(new HistoForm());
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            CameraForm.colseCamera();
            loadform(new NotificationForm());
        }

        private void ConsulterCameraBtn_Click(object sender, EventArgs e)
        {
            CameraForm.colseCamera();
            loadform(new CameraForm());
        }

        private void comptesBtn_Click(object sender, EventArgs e)
        {
            CameraForm.colseCamera();
            loadform(new Comptes());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            CameraForm.colseCamera();
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
