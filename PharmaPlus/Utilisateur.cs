using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PharmaPlus
{
    // Classe de base Utilisateur
    internal class Utilisateur
    {
        public int ID_Utilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }

        public static string HashMotDePasse(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void InscrireUtilisateur()
        {
            string motDePasseHash = HashMotDePasse(MotDePasse);

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "INSERT INTO Utilisateurs (NomUtilisateur, MotDePasse, Nom, Prenom, Role) " +
                           "VALUES (@NomUtilisateur, @MotDePasse, @Nom, @Prenom, @Role); " +
                           "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NomUtilisateur", NomUtilisateur);
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasseHash);
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Prenom", Prenom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", Role);

                    ID_Utilisateur = (int)cmd.ExecuteScalar();
                }
            }
        }

        public static Utilisateur SeConnecter(string nomUtilisateur, string motDePasse)
        {
            // string motDePasseHash = HashMotDePasse(motDePasse);

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Utilisateurs WHERE NomUtilisateur = @NomUtilisateur AND MotDePasse = @MotDePasse";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NomUtilisateur", nomUtilisateur);
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Utilisateur
                            {
                                ID_Utilisateur = Convert.ToInt32(reader["ID_Utilisateur"]),
                                NomUtilisateur = reader["NomUtilisateur"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Role = reader["Role"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };
                        }
                    }
                }
                return null; // Échec de connexion
            }
        }

        public void ModifierProfil()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "UPDATE Utilisateurs SET Nom = @Nom, Prenom = @Prenom WHERE ID_Utilisateur = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Prenom", Prenom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID", ID_Utilisateur);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ChangerMotDePasse(string nouveauMotDePasse)
        {
            string motDePasseHash = HashMotDePasse(nouveauMotDePasse);

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "UPDATE Utilisateurs SET MotDePasse = @MotDePasse WHERE ID_Utilisateur = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasseHash);
                    cmd.Parameters.AddWithValue("@ID", ID_Utilisateur);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EnregistrerHistorique(string action)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "INSERT INTO Historique (ID_Utilisateur, Action) VALUES (@ID, @Action)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID_Utilisateur);
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}