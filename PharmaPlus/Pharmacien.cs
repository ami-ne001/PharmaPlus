using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PharmaPlus
{
    internal class Pharmacien : Utilisateur
    {
        public Pharmacien()
        {
            Role = "Pharmacien";
        }

        public void AjouterMedicament(Medicament medicament)
        {
            medicament.InsererMedicament();
            // Only log if user is identified
            if (ID_Utilisateur > 0)
            {
                EnregistrerHistorique($"Ajout du médicament: {medicament.Nom} (Réf: {medicament.Reference})");
            }
        }

        public void ModifierMedicament(Medicament medicament)
        {
            medicament.MettreAJourMedicament();
            if (ID_Utilisateur > 0)
            {
                EnregistrerHistorique($"Modification du médicament ID: {medicament.ID_Medicament}");
            }
        }

        public void SupprimerMedicament(Medicament medicament)
        {
            medicament.SupprimerMedicament();
            if (ID_Utilisateur > 0)
            {
                EnregistrerHistorique($"Suppression du médicament ID: {medicament.ID_Medicament}");
            }
        }

        public void AjouterLot(LotMedicament lot)
        {
            lot.InsererLot();
            if (ID_Utilisateur > 0)
            {
                EnregistrerHistorique($"Ajout du lot: {lot.NumeroLot} pour médicament ID: {lot.ID_Medicament}");
            }
        }

        public void ModifierLot(LotMedicament lot)
        {
            lot.MettreAJourLot();
            if (ID_Utilisateur > 0)
            {
                EnregistrerHistorique($"Modification du lot ID: {lot.ID_Lot}");
            }
        }

        public List<Medicament> ConsulterStockAlerte()
        {
            List<Medicament> medicaments = Medicament.ListerMedicaments();
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

        public List<LotMedicament> ConsulterLotsPeremption(int joursAvantAlerte = 30)
        {
            List<LotMedicament> lotsPerimes = new List<LotMedicament>();
            DateTime dateAlerte = DateTime.Now.AddDays(joursAvantAlerte);

            using (SqlConnection conn = Connection.GetConnexion())
            {
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
        }

        public static List<string> ConsulterHistorique(int? idUtilisateur = null)
        {
            List<string> historique = new List<string>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
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
}