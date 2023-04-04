using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Server_bib;
using Smart_Home_bib;
using Système_de_sécurité_bib;
using Système_de_surveillance_bib;

namespace Personne
{
    public partial class PersonneGUI : Form
    {
        public PersonneGUI()
        {
            InitializeComponent();
        }

        private void accessBtn_Click_1(object sender, EventArgs e)
        {
            DemanderAcces o = (DemanderAcces)Activator.GetObject(typeof(DemanderAcces), 
                "tcp://localhost:8088/Demander acces");
            Compte compte = o.DemanderAcces(this.usernameBox.Text, this.passwordBox.Text);

            if (compte != null)
            {
                this.msgBox.Text = "Bienvenu " + compte.Prenom + " " + compte.Nom;
                this.usernameBox.Clear();
                this.passwordBox.Clear();
              
                GestionAcces oha = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                "tcp://localhost:8090/Server");
                oha.enregisterAcces(new HistoriqueAccess( compte.Nom, compte.Prenom));

                consulterTemp();
            }
            else
            {
                this.msgBox.Text = "Les information sont inccorect";
                this.humiBox.Clear();
                this.tempBox.Clear();
            }
            
        }

        async void consulterTemp () {
            ConsulterHumidite oh = (ConsulterHumidite)Activator.GetObject(typeof(ConsulterHumidite),
               "tcp://localhost:8085/température et humidité");
            ConsulterTempérature ot = (ConsulterTempérature)Activator.GetObject(typeof(ConsulterTempérature),
                    "tcp://localhost:8085/température et humidité");
            
            while (true)
            {
                this.humiBox.Text = oh.getHumidite().ToString() + " %";
                this.tempBox.Text = ot.getTemperature().ToString() + " °C";  
                await Task.Delay(500);
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
