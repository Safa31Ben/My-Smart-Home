using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Server_bib;
using Smart_Home_bib;

namespace AdminGUI
{
    public partial class Comptes : Form
    {
        public Comptes()
        {
            InitializeComponent();
            GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces), 
                "tcp://localhost:8090/Server");
            List<Compte> compteList = o.consulterCompte();
            foreach (var compte in compteList)
            {
                compteTab.Rows.Add(compte.Id.ToString(), compte.Username, compte.Nom, compte.Prenom);
            }
        }

        private void newAccountBtn_Click(object sender, EventArgs e)
        {
            new AddAccount().Show();
        }

        private void compteTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                if (compteTab.Columns[e.ColumnIndex].Name == "supprémier")
                {
                    GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces), 
                    "tcp://localhost:8090/Server");
                    o.deleteCompte(int.Parse(compteTab.CurrentRow.Cells[0].Value.ToString()));
                    compteTab.Rows.Clear();
                    List<Compte> compteList = o.consulterCompte();
                    foreach (var compte in compteList)
                    {
                        compteTab.Rows.Add(compte.Id.ToString(), compte.Username, compte.Nom, compte.Prenom);
                    }
                }
            }
        }
    }
}
