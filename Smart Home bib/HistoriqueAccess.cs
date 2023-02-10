using System;

namespace Server_bib
{
    [Serializable()]
    public class HistoriqueAccess
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime date;

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date { get; set; }

        public HistoriqueAccess(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Date = DateTime.Now;
        }
        
        public HistoriqueAccess(int id, string nom, string prenom, DateTime date)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Date = date;
        }
    }
}
