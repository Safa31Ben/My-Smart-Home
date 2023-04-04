using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Server_bib;
using Smart_Home_bib;

namespace Porte
{
    public partial class Porte : Form
    {
        public Porte()
        {
            InitializeComponent();
        }

        private async void accessBtn_Click(object sender, EventArgs e)
        {
            ReceptionNotification o = (ReceptionNotification)Activator.GetObject(typeof(ReceptionNotification),
               "tcp://localhost:8090/Envoi Notification");

            if (string.IsNullOrEmpty(this.nomBox.Text) && string.IsNullOrEmpty(this.prenomBox.Text))
                this.msgBox.Text = "Les champs ne doit pas être vide.";
            else
            {
                o.sendNotification(new Notification(this.nomBox.Text, this.prenomBox.Text));
                this.msgBox.Text = this.nomBox.Text + " " + this.prenomBox.Text + ", attendez que l'administrateur de la maison vous ouvre la porte.";
                await Task.Delay(180000);
                this.nomBox.Clear();
                this.prenomBox.Clear();
                this.msgBox.Clear();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
