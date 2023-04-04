using System;
using System.Windows.Forms;

using Server_bib;

namespace AdminGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void accessBtn_Click(object sender, EventArgs e)
        {
            GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                "tcp://localhost:8090/Server");
            string admin = o.login(this.usernameBox.Text, this.passwordBox.Text);
            if (!string.IsNullOrEmpty(admin))
            {
                new AdminGUI().Show();
                this.Hide();
            }
            else
                this.msgBox.Text = "Les information sont inccorect"; 
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
