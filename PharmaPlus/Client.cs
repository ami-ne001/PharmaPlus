using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class Client
    {
        public int ID_Client { get; set; }
        public string CodeClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }

        // Liste des commandes du client
        // public List<Commande> Commandes { get; set; } = new List<Commande>();

        public void InsererClient()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "INSERT INTO Clients (CodeClient, Nom, Prenom, Telephone, Adresse) " +
                               "VALUES (@CodeClient, @Nom, @Prenom, @Telephone, @Adresse); " +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeClient", CodeClient);
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Prenom", Prenom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? (object)DBNull.Value);

                    ID_Client = (int)cmd.ExecuteScalar();
                }
            }
        }

        public void MettreAJourClient()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "UPDATE Clients SET " +
                               "CodeClient = @CodeClient, " +
                               "Nom = @Nom, " +
                               "Prenom = @Prenom, " +
                               "Telephone = @Telephone, " +
                               "Adresse = @Adresse " +
                               "WHERE ID_Client = @ID_Client";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeClient", CodeClient);
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Prenom", Prenom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Client", ID_Client);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerClient()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM Clients WHERE ID_Client = @ID_Client";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Client> ListerClients()
        {
            List<Client> liste = new List<Client>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Clients ORDER BY Nom, Prenom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client
                            {
                                ID_Client = Convert.ToInt32(reader["ID_Client"]),
                                CodeClient = reader["CodeClient"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                            liste.Add(c);
                        }
                    }
                }
            }

            return liste;
        }

        public static Client RechercherParCode(string codeClient)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Clients WHERE CodeClient = @CodeClient";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeClient", codeClient);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Client
                            {
                                ID_Client = Convert.ToInt32(reader["ID_Client"]),
                                CodeClient = reader["CodeClient"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static Client RechercherParID(int idClient)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Clients WHERE ID_Client = @ID_Client";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Client", idClient);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Client
                            {
                                ID_Client = Convert.ToInt32(reader["ID_Client"]),
                                CodeClient = reader["CodeClient"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static List<Client> RechercherParNom(string nomOuPrenom)
        {
            List<Client> liste = new List<Client>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Clients " +
                               "WHERE Nom LIKE @Recherche OR Prenom LIKE @Recherche " +
                               "ORDER BY Nom, Prenom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Recherche", $"%{nomOuPrenom}%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client
                            {
                                ID_Client = Convert.ToInt32(reader["ID_Client"]),
                                CodeClient = reader["CodeClient"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                            liste.Add(c);
                        }
                    }
                }
            }

            return liste;
        }

        public static bool CodeClientExiste(string codeClient)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT COUNT(*) FROM Clients WHERE CodeClient = @CodeClient";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeClient", codeClient);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        public static int CompterClients()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT COUNT(*) FROM Clients";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void ChargerCommandes()
        {

        }

        public string NomComplet()
        {
            return $"{Nom} {Prenom}".Trim();
        }

        public override string ToString()
        {
            return $"[{CodeClient}] {NomComplet()} - Tél: {Telephone ?? "N/A"}";
        }
    }
}