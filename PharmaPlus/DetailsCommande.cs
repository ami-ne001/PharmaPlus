using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class DetailsCommande
    {
        public int ID_Detail { get; set; }
        public int ID_Commande { get; set; }
        public int ID_Medicament { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }

        public void InsererDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"INSERT INTO DetailsCommande 
                                 (ID_Commande, ID_Medicament, Quantite, PrixUnitaire)
                                 VALUES (@ID_Commande, @ID_Medicament, @Quantite, @PrixUnitaire)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Commande", ID_Commande);
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@PrixUnitaire", PrixUnitaire);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MettreAJourDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"UPDATE DetailsCommande SET
                                 ID_Medicament = @ID_Medicament,
                                 Quantite = @Quantite,
                                 PrixUnitaire = @PrixUnitaire
                                 WHERE ID_Detail = @ID_Detail";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Detail", ID_Detail);
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@PrixUnitaire", PrixUnitaire);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM DetailsCommande WHERE ID_Detail = @ID_Detail";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Detail", ID_Detail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<DetailsCommande> ListerDetailsParCommande(int idCommande)
        {
            List<DetailsCommande> details = new List<DetailsCommande>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM DetailsCommande WHERE ID_Commande = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idCommande);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new DetailsCommande
                            {
                                ID_Detail = Convert.ToInt32(reader["ID_Detail"]),
                                ID_Commande = Convert.ToInt32(reader["ID_Commande"]),
                                ID_Medicament = Convert.ToInt32(reader["ID_Medicament"]),
                                Quantite = Convert.ToInt32(reader["Quantite"]),
                                PrixUnitaire = Convert.ToDecimal(reader["PrixUnitaire"])
                            });
                        }
                    }
                }
            }

            return details;
        }
    }
}
