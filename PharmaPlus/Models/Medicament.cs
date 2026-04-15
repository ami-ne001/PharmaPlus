using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PharmaPlus;

namespace PharmaPlus
{
    internal class Medicament
    {
        public int ID_Medicament { get; set; }
        public string Nom { get; set; }
        public string Reference { get; set; }
        public string Categorie { get; set; }
        public string Fabricant { get; set; }
        public int QuantiteTotale { get; set; }
        public int SeuilAlerteStock { get; set; }
        public List<LotMedicament> Lots { get; set; } = new List<LotMedicament>();

        public void InsererMedicament()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "INSERT INTO Medicaments (Nom, Reference, Categorie, Fabricant, QuantiteTotale, SeuilAlerteStock) " +
                               "VALUES (@Nom, @Reference, @Categorie, @Fabricant, @QuantiteTotale, @SeuilAlerteStock)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Reference", Reference ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Categorie", Categorie ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fabricant", Fabricant ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@QuantiteTotale", QuantiteTotale);
                    cmd.Parameters.AddWithValue("@SeuilAlerteStock", SeuilAlerteStock);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MettreAJourMedicament()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "UPDATE Medicaments SET " +
                               "Nom = @Nom, " +
                               "Reference = @Reference, " +
                               "Categorie = @Categorie, " +
                               "Fabricant = @Fabricant, " +
                               "QuantiteTotale = @QuantiteTotale, " +
                               "SeuilAlerteStock = @SeuilAlerteStock " +
                               "WHERE ID_Medicament = @ID_Medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", Nom ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Reference", Reference ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Categorie", Categorie ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fabricant", Fabricant ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@QuantiteTotale", QuantiteTotale);
                    cmd.Parameters.AddWithValue("@SeuilAlerteStock", SeuilAlerteStock);
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerMedicament()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM Medicaments WHERE ID_Medicament = @ID_Medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Medicament> ListerMedicaments()
        {
            List<Medicament> liste = new List<Medicament>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Medicaments";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Medicament m = new Medicament
                        {
                            ID_Medicament = Convert.ToInt32(reader["ID_Medicament"]),
                            Nom = reader["Nom"].ToString(),
                            Reference = reader["Reference"].ToString(),
                            Categorie = reader["Categorie"].ToString(),
                            Fabricant = reader["Fabricant"].ToString(),
                            QuantiteTotale = Convert.ToInt32(reader["QuantiteTotale"]),
                            SeuilAlerteStock = Convert.ToInt32(reader["SeuilAlerteStock"])
                        };
                        liste.Add(m);
                    }
                }
            }

            return liste;
        }


        public bool VerifierStockAlerte()
        {
            return QuantiteTotale <= SeuilAlerteStock;
        }

        public void AjouterLot(LotMedicament lot)
        {
            lot.ID_Medicament = this.ID_Medicament;
            lot.InsererLot();
            MettreAJourQuantiteTotale();
        }

        public void MettreAJourQuantiteTotale()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string queryTotal = "SELECT ISNULL(SUM(QuantiteLot), 0) FROM LotsMedicaments WHERE ID_Medicament = @ID_Medicament";

                using (SqlCommand cmdTotal = new SqlCommand(queryTotal, conn))
                {
                    cmdTotal.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    int nouvelleQuantite = Convert.ToInt32(cmdTotal.ExecuteScalar());

                    string queryUpdate = "UPDATE Medicaments SET QuantiteTotale = @QuantiteTotale WHERE ID_Medicament = @ID_Medicament";

                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@QuantiteTotale", nouvelleQuantite);
                        cmdUpdate.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    this.QuantiteTotale = nouvelleQuantite;
                }
            }
        }

        public void ChargerLots()
        {
            Lots = LotMedicament.ListerLotsParMedicament(ID_Medicament);
        }
    }
}
