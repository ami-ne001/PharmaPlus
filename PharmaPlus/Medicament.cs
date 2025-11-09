using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trials
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

        public void InsererMedicament(SqlConnection conn)
        {
            string query = $"INSERT INTO Medicaments (Nom, Reference, Categorie, Fabricant, QuantiteTotale, SeuilAlerteStock) " +
                           $"VALUES ('{Nom}', '{Reference}', '{Categorie}', '{Fabricant}', {QuantiteTotale}, {SeuilAlerteStock})";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void MettreAJourMedicament(SqlConnection conn)
        {
            string query = $"UPDATE Medicaments SET " +
                           $"Nom = '{Nom}', " +
                           $"Reference = '{Reference}', " +
                           $"Categorie = '{Categorie}', " +
                           $"Fabricant = '{Fabricant}', " +
                           $"QuantiteTotale = {QuantiteTotale}, " +
                           $"SeuilAlerteStock = {SeuilAlerteStock} " +
                           $"WHERE ID_Medicament = {ID_Medicament}";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void SupprimerMedicament(SqlConnection conn)
        {
            string query = $"DELETE FROM Medicaments WHERE ID_Medicament = {ID_Medicament}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public static List<Medicament> ListerMedicaments(SqlConnection conn)
        {
            List<Medicament> liste = new List<Medicament>();
            string query = "SELECT * FROM Medicaments";

            SqlCommand cmd = new SqlCommand(query, conn);
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

            reader.Close();
            return liste;
        }

        public bool VerifierStockAlerte()
        {
            return QuantiteTotale <= SeuilAlerteStock;
        }

        public void AjouterLot(SqlConnection conn, LotMedicament lot)
        {
            string query = $"INSERT INTO LotsMedicaments (ID_Medicament, NumeroLot, DatePeremption, Prix, QuantiteLot) " +
                           $"VALUES ({ID_Medicament}, '{lot.NumeroLot}', '{lot.DatePeremption:yyyy-MM-dd}', {lot.Prix}, {lot.QuantiteLot})";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            QuantiteTotale += lot.QuantiteLot;
            MettreAJourMedicament(conn);
        }

        public static void MettreAJourQuantiteTotale(SqlConnection conn, int idMedicament)
        {
            // Calculer la somme des quantités de tous les lots pour ce médicament
            string queryTotal = $"SELECT SUM(QuantiteLot) FROM LotsMedicaments WHERE ID_Medicament = {idMedicament}";
            SqlCommand cmdTotal = new SqlCommand(queryTotal, conn);

            object result = cmdTotal.ExecuteScalar();
            int nouvelleQuantite = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

            // Mettre à jour la quantité totale dans la table Medicaments
            string queryUpdate = $"UPDATE Medicaments SET QuantiteTotale = {nouvelleQuantite} WHERE ID_Medicament = {idMedicament}";
            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
            cmdUpdate.ExecuteNonQuery();
        }

    }
}
