using System;

namespace Smart_Home_bib
{
    [Serializable()]
    public class Compte
    {
        private int id;
        private string password;
        private string nom;
        private string prenom;
        private string username;

        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Compte(string password, string username, string nom, string prenom)
        {
            Password = password;
            Username = username;
            Nom = nom;
            Prenom = prenom;
        }

        public Compte(int id, string username, string nom, string prenom)
        {
            Id = id;
            Username = username;
            Nom = nom;
            Prenom = prenom;
        }
        //les Comptes des habitaux 
    }
}
