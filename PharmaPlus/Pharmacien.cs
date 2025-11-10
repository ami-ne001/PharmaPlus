using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PharmaPlus
{
    // Classe Pharmacien héritant d'Utilisateur
    internal class Pharmacien : Utilisateur
    {
        public Pharmacien()
        {
            Role = "Pharmacien";
        }

        // Ajouter un médicament
        public void AjouterMedicament(SqlConnection conn, Medicament medicament)
        {
            medicament.InsererMedicament(conn);
            EnregistrerHistorique(conn, $"Ajout du médicament: {medicament.Nom} (Réf: {medicament.Reference})");
        }

        // Modifier un médicament
        public void ModifierMedicament(SqlConnection conn, Medicament medicament)
        {
            medicament.MettreAJourMedicament(conn);
            EnregistrerHistorique(conn, $"Modification du médicament ID: {medicament.ID_Medicament}");
        }

        // Supprimer un médicament
        public void SupprimerMedicament(SqlConnection conn, Medicament medicament)
        {
            medicament.SupprimerMedicament(conn);
            EnregistrerHistorique(conn, $"Suppression du médicament ID: {medicament.ID_Medicament}");
        }

        // Ajouter un lot de médicament
        public void AjouterLot(SqlConnection conn, LotMedicament lot)
        {
            lot.InsererLot(conn);
            EnregistrerHistorique(conn, $"Ajout du lot: {lot.NumeroLot} pour médicament ID: {lot.ID_Medicament}");
        }

        // Modifier un lot
        public void ModifierLot(SqlConnection conn, LotMedicament lot)
        {
            lot.MettreAJourLot(conn);
            EnregistrerHistorique(conn, $"Modification du lot ID: {lot.ID_Lot}");
        }

        // Supprimer un lot
        public void SupprimerLot(SqlConnection conn, LotMedicament lot)
        {
            lot.SupprimerLot(conn);
            EnregistrerHistorique(conn, $"Suppression du lot ID: {lot.ID_Lot}");
        }

        // Consulter les médicaments en alerte de stock
        public List<Medicament> ConsulterStockAlerte(SqlConnection conn)
        {
            List<Medicament> medicaments = Medicament.ListerMedicaments(conn);
            List<Medicament> alertes = new List<Medicament>();

            foreach (var med in medicaments)
            {
                if (med.VerifierStockAlerte())
                {
                    alertes.Add(med);
                }
            }

            return alertes;
        }

        // Consulter les lots périmés ou proches de la péremption
        public List<LotMedicament> ConsulterLotsPeremption(SqlConnection conn, int joursAvantAlerte = 30)
        {
            List<LotMedicament> lotsPerimes = new List<LotMedicament>();
            DateTime dateAlerte = DateTime.Now.AddDays(joursAvantAlerte);

            string query = "SELECT * FROM LotsMedicaments WHERE DatePeremption <= @DateAlerte ORDER BY DatePeremption";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DateAlerte", dateAlerte);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lotsPerimes.Add(new LotMedicament
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

            return lotsPerimes;
        }

        // Consulter l'historique des actions
        public static List<string> ConsulterHistorique(SqlConnection conn, int? idUtilisateur = null)
        {
            List<string> historique = new List<string>();
            string query = idUtilisateur.HasValue
                ? "SELECT * FROM Historique WHERE ID_Utilisateur = @ID ORDER BY DateAction DESC"
                : "SELECT h.*, u.NomUtilisateur FROM Historique h " +
                  "JOIN Utilisateurs u ON h.ID_Utilisateur = u.ID_Utilisateur " +
                  "ORDER BY h.DateAction DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (idUtilisateur.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ID", idUtilisateur.Value);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string utilisateur = idUtilisateur.HasValue ? "" : $"[{reader["NomUtilisateur"]}] ";
                        string action = reader["Action"].ToString();
                        DateTime date = Convert.ToDateTime(reader["DateAction"]);
                        historique.Add($"{date:dd/MM/yyyy HH:mm} - {utilisateur}{action}");
                    }
                }
            }

            return historique;
        }
    }
}