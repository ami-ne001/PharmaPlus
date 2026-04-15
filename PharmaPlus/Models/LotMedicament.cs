using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PharmaPlus;

namespace PharmaPlus
{
    internal class LotMedicament
    {
        public int ID_Lot { get; set; }
        public int ID_Medicament { get; set; }
        public string NumeroLot { get; set; }
        public DateTime DatePeremption { get; set; }
        public decimal Prix { get; set; }
        public int QuantiteLot { get; set; }

        public void InsererLot()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "INSERT INTO LotsMedicaments (ID_Medicament, NumeroLot, DatePeremption, Prix, QuantiteLot) " +
                               "VALUES (@ID_Medicament, @NumeroLot, @DatePeremption, @Prix, @QuantiteLot)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    cmd.Parameters.AddWithValue("@NumeroLot", NumeroLot ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DatePeremption", DatePeremption);
                    cmd.Parameters.AddWithValue("@Prix", Prix);
                    cmd.Parameters.AddWithValue("@QuantiteLot", QuantiteLot);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MettreAJourLot()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "UPDATE LotsMedicaments SET " +
                               "ID_Medicament = @ID_Medicament, " +
                               "NumeroLot = @NumeroLot, " +
                               "DatePeremption = @DatePeremption, " +
                               "Prix = @Prix, " +
                               "QuantiteLot = @QuantiteLot " +
                               "WHERE ID_Lot = @ID_Lot";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medicament", ID_Medicament);
                    cmd.Parameters.AddWithValue("@NumeroLot", NumeroLot ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DatePeremption", DatePeremption);
                    cmd.Parameters.AddWithValue("@Prix", Prix);
                    cmd.Parameters.AddWithValue("@QuantiteLot", QuantiteLot);
                    cmd.Parameters.AddWithValue("@ID_Lot", ID_Lot);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void SupprimerLot()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "DELETE FROM LotsMedicaments WHERE ID_Lot = @ID_Lot";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Lot", ID_Lot);
                    cmd.ExecuteNonQuery();
                }
            }

            Medicament m = new Medicament { ID_Medicament = ID_Medicament };
            m.MettreAJourQuantiteTotale();
        }

        public static List<LotMedicament> ListerTousLesLots()
        {
            List<LotMedicament> lots = new List<LotMedicament>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM LotsMedicaments";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lots.Add(new LotMedicament
                        {
                            ID_Lot = Convert.ToInt32(reader["ID_Lot"]),
                            ID_Medicament = Convert.ToInt32(reader["ID_Medicament"]),
                            NumeroLot = reader["NumeroLot"].ToString(),
                            DatePeremption = Convert.ToDateTime(reader["DatePeremption"]),
                            Prix = Convert.ToDecimal(reader["Prix"]),
                            QuantiteLot = Convert.ToInt32(reader["QuantiteLot"])
                        });
                    }
                }
            }

            return lots;
        }

        public static List<LotMedicament> ListerLotsParMedicament(int idMedicament)
        {
            List<LotMedicament> lots = new List<LotMedicament>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM LotsMedicaments WHERE ID_Medicament = @ID_Medicament ORDER BY DatePeremption";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Medicament", idMedicament);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lots.Add(new LotMedicament
                            {
                                ID_Lot = Convert.ToInt32(reader["ID_Lot"]),
                                ID_Medicament = Convert.ToInt32(reader["ID_Medicament"]),
                                NumeroLot = reader["NumeroLot"].ToString(),
                                DatePeremption = Convert.ToDateTime(reader["DatePeremption"]),
                                Prix = Convert.ToDecimal(reader["Prix"]),
                                QuantiteLot = Convert.ToInt32(reader["QuantiteLot"])
                            });
                        }
                    }
                }
            }

            return lots;
        }


    }
}
