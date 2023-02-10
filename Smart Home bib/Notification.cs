using System;

namespace Smart_Home_bib
{
    [Serializable()]
    public class Notification
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime date;

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date { get; set;}

        public Notification(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Date = DateTime.Now;
        }

        public Notification(int id, string nom, string prenom, DateTime date)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Date = date;
        }
    }
}
