using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Server_bib;
using Smart_Home_bib;

namespace AdminGUI
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();

            GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                "tcp://localhost:8090/Server");

            List<Notification> notificationList = o.consulterNotification();
            notificationTab.Rows.Clear();
            foreach (var notification in notificationList)
            {
                notificationTab.Rows.Add(notification.Id.ToString(),
                    notification.Nom, notification.Prenom, notification.Date.ToString());
            }
        }

        private void notificationTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (notificationTab.Columns[e.ColumnIndex].Name == "supprémier")
                {
                    GestionAcces o = (GestionAcces)Activator.GetObject(typeof(GestionAcces),
                    "tcp://localhost:8090/Server");
                    o.donneePermission(int.Parse(notificationTab.CurrentRow.Cells[0].Value.ToString()));
                    o.enregisterAcces(new HistoriqueAccess(notificationTab.CurrentRow.Cells[1].Value.ToString(),
                        notificationTab.CurrentRow.Cells[2].Value.ToString()));
                    notificationTab.Rows.Clear();

                    List<Notification> notificationList = o.consulterNotification();
                    foreach (var notification in notificationList)
                    {
                        notificationTab.Rows.Add(notification.Id.ToString(), notification.Nom,
                            notification.Prenom, notification.Date.ToString());
                    }
                }
            }
        }
    }
}
