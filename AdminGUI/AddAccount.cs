using System;
using System.Windows.Forms;

using Server_bib;
using Smart_Home_bib;

namespace AdminGUI
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                "tcp://localhost:8090/Server");
            if (string.IsNullOrEmpty(this.passwordField.Text) && string.IsNullOrEmpty(this.usernameField.Text) &&
                string.IsNullOrEmpty(this.nomField.Text) && string.IsNullOrEmpty(this.prenomField.Text))
                this.msgBox.Text = "Les champs ne doit pas être vide.";
            else
            {
                o.ajouterCompte(new Compte(this.passwordField.Text, this.usernameField.Text, this.nomField.Text, this.prenomField.Text));
                this.Close();
            }

            /*this.compteTable.Rows.Clear();
            List<Compte> compteList = o.consulterCompte();
            foreach (var compte in compteList)
            {
                this.compteTable.Rows.Add(compte.Id.ToString(), compte.Username, compte.Nom, compte.Prenom);
            }*/
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
