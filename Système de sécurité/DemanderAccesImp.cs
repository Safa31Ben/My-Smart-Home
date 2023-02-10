using System;
using MySql.Data.MySqlClient;

using Système_de_sécurité_bib;
using Smart_Home_bib;

namespace Système_de_sécurité
{
    class DemanderAccesImp : MarshalByRefObject, DemanderAcces
    {
        public MySqlConnection GetBDConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost; Database=smarthome; Uid=root; Pwd=Sa31052001Fa;");
            try
            {
                conn.Open();
                Console.WriteLine("La connexion de la base de données est ouverte.");
            }
            catch (Exception e)
            {
                Console.WriteLine("La connexion de la base de données n'est pas ouverte " + e.Message);
            }
            return conn;
        }

        public Compte DemanderAcces(string username, string motDePass)
        {
            MySqlConnection conn = GetBDConnection();
            Compte compte = null;

            try
            {
                string req = "SELECT * FROM compte WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", motDePass);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    compte = new Compte(
                        int.Parse(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString()
                        );
                Console.WriteLine("L'utilisateur avec le nom d'utilisateur " + username + " demande d'accès à la maison");
            }
             catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("La connexion de la base de données est fermée.");
                Console.WriteLine("**********************************************");
            }
            return compte;
        }
    }
}
