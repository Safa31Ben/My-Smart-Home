using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Server_bib;

namespace AdminGUI
{
    public partial class HistoForm : Form
    {
        public HistoForm()
        {
            InitializeComponent();

            GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                "tcp://localhost:8090/Server");
            List<HistoriqueAccess> historiqueAccesList = o.consulterHistoriqueAcces();
            
            histoTable.Rows.Clear();
            foreach (var historiqueAcces in historiqueAccesList)
            {
                histoTable.Rows.Add(historiqueAcces.Id.ToString(), historiqueAcces.Nom, historiqueAcces.Prenom, historiqueAcces.Date.ToString());
            }
        }
    }
}
