using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class Fournisseur
    {
        public int ID_Fournisseur { get; set; }
        public string CodeFournisseur { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        // Liste des médicaments fournis
        public List<Medicament> Medicaments { get; set; } = new List<Medicament>();

        public void InsererFournisseur()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"INSERT INTO Fournisseurs 
                                (CodeFournisseur, Nom, Telephone, Email, Adresse)
                                VALUES (@CodeFournisseur, @Nom, @Telephone, @Email, @Adresse);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeFournisseur", CodeFournisseur);
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? (object)DBNull.Value);

                    ID_Fournisseur = (int)cmd.ExecuteScalar();
                }
            }
        }

        public void MettreAJourFournisseur()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"UPDATE Fournisseurs SET 
                                CodeFournisseur = @CodeFournisseur,
                                Nom = @Nom,
                                Telephone = @Telephone,
                                Email = @Email,
                                Adresse = @Adresse
                                WHERE ID_Fournisseur = @ID_Fournisseur";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeFournisseur", CodeFournisseur);
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", ID_Fournisseur);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerFournisseur()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM Fournisseurs WHERE ID_Fournisseur = @ID_Fournisseur";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", ID_Fournisseur);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Fournisseur> ListerFournisseurs()
        {
            List<Fournisseur> liste = new List<Fournisseur>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Fournisseurs ORDER BY Nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fournisseur f = new Fournisseur
                        {
                            ID_Fournisseur = Convert.ToInt32(reader["ID_Fournisseur"]),
                            CodeFournisseur = reader["CodeFournisseur"].ToString(),
                            Nom = reader["Nom"].ToString(),
                            Telephone = reader["Telephone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Adresse = reader["Adresse"].ToString()
                        };

                        liste.Add(f);
                    }
                }
            }

            return liste;
        }

        public static Fournisseur RechercherParID(int id)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Fournisseurs WHERE ID_Fournisseur = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Fournisseur
                            {
                                ID_Fournisseur = Convert.ToInt32(reader["ID_Fournisseur"]),
                                CodeFournisseur = reader["CodeFournisseur"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static Fournisseur RechercherParCode(string code)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Fournisseurs WHERE CodeFournisseur = @Code";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", code);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Fournisseur
                            {
                                ID_Fournisseur = Convert.ToInt32(reader["ID_Fournisseur"]),
                                CodeFournisseur = reader["CodeFournisseur"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static List<Fournisseur> RechercherParNom(string recherche)
        {
            List<Fournisseur> liste = new List<Fournisseur>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"SELECT * FROM Fournisseurs 
                                 WHERE Nom LIKE @Recherche 
                                 ORDER BY Nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Recherche", "%" + recherche + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fournisseur f = new Fournisseur
                            {
                                ID_Fournisseur = Convert.ToInt32(reader["ID_Fournisseur"]),
                                CodeFournisseur = reader["CodeFournisseur"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Adresse = reader["Adresse"].ToString()
                            };

                            liste.Add(f);
                        }
                    }
                }
            }

            return liste;
        }

        public static bool CodeExiste(string code)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT COUNT(*) FROM Fournisseurs WHERE CodeFournisseur = @Code";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", code);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public override string ToString()
        {
            return $"[{CodeFournisseur}] {Nom} - Tél: {Telephone ?? "N/A"}";
        }
    }
}
