using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

using Server_bib;
using Smart_Home_bib;

namespace Server
{
    public class ServerImp : MarshalByRefObject, GestionAcces, ReceptionNotification
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

        public List<Compte> consulterCompte()
        {
            MySqlConnection conn = GetBDConnection();
            List<Compte> compteList = new List<Compte>();
            try
            {
                string req = "SELECT * FROM compte";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
           
                while (reader.Read())
                {
                    compteList.Add(new Compte(
                        int.Parse(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString()
                        ));
                }
                Console.WriteLine("Consultation des compte des utilisateurs.");
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
            return compteList;
        }
        
        public void ajouterCompte(Smart_Home_bib.Compte compte)
        {
            MySqlConnection conn = GetBDConnection();
            try
            {
                string req = "INSERT into compte(id, username, password, nom, prenom) VALUES (@id, @username ,@pawssword,@nom,@prenom)";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@id", compte.Id);
                cmd.Parameters.AddWithValue("@pawssword", compte.Password);
                cmd.Parameters.AddWithValue("@username", compte.Username);
                cmd.Parameters.AddWithValue("@nom", compte.Nom);
                cmd.Parameters.AddWithValue("@prenom", compte.Prenom);
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Un compte d'utilisateur est ajouté.");
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
        }

        public List<HistoriqueAccess> consulterHistoriqueAcces()
        {
            MySqlConnection conn = GetBDConnection();
            List<HistoriqueAccess> historiqueAccessList = null;
            try
            {
                string req = "SELECT * FROM historiqueaccess";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                historiqueAccessList = new List<HistoriqueAccess>();
                while (reader.Read())
                {
                    historiqueAccessList.Add(new HistoriqueAccess(int.Parse(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        DateTime.Parse(reader[3].ToString())));
                }
                Console.WriteLine("Consultation de l'historique d'accès à la maison.");
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
            return historiqueAccessList;
        }

        public List<Notification> consulterNotification()
        {
            MySqlConnection conn = GetBDConnection();
            List<Notification> notificationList = null;
            try
            {
                string req = "SELECT * FROM notification";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                notificationList = new List<Notification>();
      
                while (reader.Read())
                {
                    notificationList.Add(new Notification(
                        int.Parse(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        DateTime.Parse(reader[3].ToString())
                        ));
                }
                Console.WriteLine("Consultation des notifications de demande d'accès à la maison.");
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
            return notificationList;
        }
    
        public void sendNotification(Notification notification)
        {
            MySqlConnection conn = GetBDConnection();
            string req = "INSERT into notification (nom, prenom,date) VALUES (@nom,@prenom,@date)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@nom", notification.Nom);
                cmd.Parameters.AddWithValue("@prenom", notification.Prenom);
                cmd.Parameters.AddWithValue("@date", notification.Date);
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Une notification ajoutée");
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
        }

        public void donneePermission(int idNotification)
        {
            MySqlConnection conn = GetBDConnection();
            try
            {
                string req = "DELETE FROM notification WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@id", idNotification);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Une permission d'acces est donnée.");
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
        }

        public void enregisterAcces(HistoriqueAccess historiqueAccess)
        {
            MySqlConnection conn = GetBDConnection();
            try
            {
                string req = "INSERT into historiqueaccess(nom, prenom, date) VALUES (@nom,@prenom,@date)";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@nom", historiqueAccess.Nom);
                cmd.Parameters.AddWithValue("@prenom", historiqueAccess.Prenom);
                cmd.Parameters.AddWithValue("@date", historiqueAccess.Date);
                cmd.ExecuteNonQuery();

                Console.WriteLine("L'accès de " + historiqueAccess.Nom + " " + historiqueAccess.Prenom + " est enregistrée");
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
        }

        public void deleteCompte(int id)
        {
            MySqlConnection conn = GetBDConnection();
            try
            {
                string req = "DELETE FROM compte WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Un compte d'utilisateur est supprimée.");
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
        }

        public string login(string username, string motDePass)
        {
            MySqlConnection conn = GetBDConnection();
            string admin = "";
            try
            {
                string req = "SELECT * FROM admin WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", motDePass);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    admin = reader[0].ToString();
                Console.WriteLine("L'administrateur de la maison s'est connecté à l'application de gestion de la maison.");
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
            return admin;
        }
    }
}