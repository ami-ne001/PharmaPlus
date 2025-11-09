using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PharmaPlus;

namespace trials
{
    internal class LotMedicament
    {
        public int ID_Lot { get; set; }
        public int ID_Medicament { get; set; }
        public string NumeroLot { get; set; }
        public DateTime DatePeremption { get; set; }
        public decimal Prix { get; set; }
        public int QuantiteLot { get; set; }

        public void InsererLot(SqlConnection conn)
        {
            string query = $"INSERT INTO LotsMedicaments (ID_Medicament, NumeroLot, DatePeremption, Prix, QuantiteLot) " +
                           $"VALUES ({ID_Medicament}, '{NumeroLot}', '{DatePeremption:yyyy-MM-dd}', {Prix}, {QuantiteLot})";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            // Met à jour la quantité totale du médicament parent
            Medicament.MettreAJourQuantiteTotale(conn, ID_Medicament);
        }


        public void MettreAJourLot(SqlConnection conn)
        {
            string query = $"UPDATE LotsMedicaments SET " +
                           $"ID_Medicament = {ID_Medicament}, " +
                           $"NumeroLot = '{NumeroLot}', " +
                           $"DatePeremption = '{DatePeremption:yyyy-MM-dd}', " +
                           $"Prix = {Prix}, " +
                           $"QuantiteLot = {QuantiteLot} " +
                           $"WHERE ID_Lot = {ID_Lot}";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            Medicament.MettreAJourQuantiteTotale(conn, ID_Medicament);
        }

        public static List<LotMedicament> ListerTousLesLots(SqlConnection conn)
        {
            List<LotMedicament> lots = new List<LotMedicament>();
            string query = "SELECT * FROM LotsMedicaments";

            SqlCommand cmd = new SqlCommand(query, conn);
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

            reader.Close();
            return lots;
        }

        public void SupprimerLot(SqlConnection conn)
        {
            string query = $"DELETE FROM LotsMedicaments WHERE ID_Lot = {ID_Lot}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            // Mettre à jour la quantité totale du médicament parent
            Medicament m = new Medicament { ID_Medicament = ID_Medicament };
            Medicament.MettreAJourQuantiteTotale(conn, ID_Medicament);
        }
    }
}
