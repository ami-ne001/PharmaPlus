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
        public int ID_DetailsCommande { get; set; }
        public int ID_Commande { get; set; }
        public int ID_Lot { get; set; }
        public int Quantite { get; set; }
        public decimal PrixVente { get; set; }

        public void InsererDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"INSERT INTO DetailsCommandes 
                                 (ID_Commande, ID_Lot, Quantite, PrixVente)
                                 VALUES (@ID_Commande, @ID_Lot, @Quantite, @PrixVente)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Commande", ID_Commande);
                    cmd.Parameters.AddWithValue("@ID_Lot", ID_Lot);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@PrixVente", PrixVente);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MettreAJourDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"UPDATE DetailsCommandes SET
                                 ID_Lot = @ID_Lot,
                                 Quantite = @Quantite,
                                 PrixVente = @PrixVente
                                 WHERE ID_DetailsCommande = @ID_DetailsCommande";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_DetailsCommande", ID_DetailsCommande);
                    cmd.Parameters.AddWithValue("@ID_Lot", ID_Lot);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@PrixVente", PrixVente);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerDetail()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM DetailsCommandes WHERE ID_DetailsCommande = @ID_DetailsCommande";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_DetailsCommande", ID_DetailsCommande);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<DetailsCommande> ListerDetailsParCommande(int idCommande)
        {
            List<DetailsCommande> details = new List<DetailsCommande>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM DetailsCommandes WHERE ID_Commande = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idCommande);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new DetailsCommande
                            {
                                ID_DetailsCommande = Convert.ToInt32(reader["ID_DetailsCommande"]),
                                ID_Commande = Convert.ToInt32(reader["ID_Commande"]),
                                ID_Lot = Convert.ToInt32(reader["ID_Lot"]),
                                Quantite = Convert.ToInt32(reader["Quantite"]),
                                PrixVente = Convert.ToDecimal(reader["PrixVente"])
                            });
                        }
                    }
                }
            }

            return details;
        }
    }
}
