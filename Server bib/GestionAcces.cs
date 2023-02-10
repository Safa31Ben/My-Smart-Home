using System.Collections.Generic;

using Smart_Home_bib;

namespace Server_bib
{
    public interface GestionAcces
    {
        void ajouterCompte(Compte compte);
        List<Compte> consulterCompte();
        List<HistoriqueAccess> consulterHistoriqueAcces();
        List<Notification> consulterNotification();
        void donneePermission(int idNotification);
        void enregisterAcces(HistoriqueAccess historiqueAccess);
        void deleteCompte(int id);
        string login(string username, string motDePass);
    }
}
