using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class FournisseurMedicament
    {
        public int ID_FournisseurMedicament { get; set; }
        public int ID_Fournisseur { get; set; }
        public int ID_Medicament { get; set; }
        public decimal? PrixAchat { get; set; } // Prix d'achat (nullable)

        // Propriétés supplémentaires pour l'affichage
        public string? NomFournisseur { get; set; }
        public string? NomMedicament { get; set; }
        public string? ReferenceMedicament { get; set; }

        /// <summary>
        /// Ajouter une relation fournisseur-médicament
        /// </summary>
        public void AjouterRelation()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                // Vérifier si la relation existe déjà
                string checkQuery = "SELECT COUNT(*) FROM FournisseursMedicaments WHERE ID_Fournisseur = @ID_Fournisseur AND ID_Medicament = @ID_Medicament";
                
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ID_Fournisseur", ID_Fournisseur);
                    checkCmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new Exception("Ce médicament est déjà associé à ce fournisseur.");
                    }
                }

                // Ajouter la relation
                string query = @"INSERT INTO FournisseursMedicaments (ID_Fournisseur, ID_Medicament) 
                                 VALUES (@ID_Fournisseur, @ID_Medicament);
                                 SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", ID_Fournisseur);
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);

                    ID_FournisseurMedicament = (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Supprimer une relation fournisseur-médicament
        /// </summary>
        public static void SupprimerRelation(int idFournisseur, int idMedicament)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM FournisseursMedicaments WHERE ID_Fournisseur = @ID_Fournisseur AND ID_Medicament = @ID_Medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", idFournisseur);
                    cmd.Parameters.AddWithValue("@ID_Medicament", idMedicament);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Lister tous les médicaments fournis par un fournisseur spécifique
        /// </summary>
        public static List<Medicament> ListerMedicamentsParFournisseur(int idFournisseur)
        {
            List<Medicament> medicaments = new List<Medicament>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"SELECT m.* 
                                FROM Medicaments m
                                INNER JOIN FournisseursMedicaments fm ON m.ID_Medicament = fm.ID_Medicament
                                WHERE fm.ID_Fournisseur = @ID_Fournisseur
                                ORDER BY m.Nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", idFournisseur);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicaments.Add(new Medicament
                            {
                                ID_Medicament = Convert.ToInt32(reader["ID_Medicament"]),
                                Nom = reader["Nom"].ToString(),
                                Reference = reader["Reference"].ToString(),
                                Categorie = reader["Categorie"].ToString(),
                                Fabricant = reader["Fabricant"].ToString(),
                                QuantiteTotale = Convert.ToInt32(reader["QuantiteTotale"]),
                                SeuilAlerteStock = Convert.ToInt32(reader["SeuilAlerteStock"])
                            });
                        }
                    }
                }
            }

            return medicaments;
        }

        /// <summary>
        /// Lister tous les fournisseurs qui fournissent un médicament spécifique
        /// </summary>
        public static List<Fournisseur> ListerFournisseursParMedicament(int idMedicament)
        {
            List<Fournisseur> fournisseurs = new List<Fournisseur>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"SELECT f.* 
                                FROM Fournisseurs f
                                INNER JOIN FournisseursMedicaments fm ON f.ID_Fournisseur = fm.ID_Fournisseur
                                WHERE fm.ID_Medicament = @ID_Medicament
                                ORDER BY f.Nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medicament", idMedicament);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fournisseurs.Add(new Fournisseur
                            {
                                ID_Fournisseur = Convert.ToInt32(reader["ID_Fournisseur"]),
                                CodeFournisseur = reader["CodeFournisseur"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Telephone = reader["Telephone"].ToString(),
                                Adresse = reader["Adresse"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }

            return fournisseurs;
        }

        /// <summary>
        /// Vérifier si une relation existe déjà
        /// </summary>
        public static bool RelationExiste(int idFournisseur, int idMedicament)
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT COUNT(*) FROM FournisseursMedicaments WHERE ID_Fournisseur = @ID_Fournisseur AND ID_Medicament = @ID_Medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Fournisseur", idFournisseur);
                    cmd.Parameters.AddWithValue("@ID_Medicament", idMedicament);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}
