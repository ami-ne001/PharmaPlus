using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class Commande
    {
        public int ID_Commande { get; set; }
        public int ID_Client { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal MontantTotal { get; set; }
        public string Statut { get; set; } = "En Attente";

        public List<DetailsCommande> Details { get; set; } = new List<DetailsCommande>();

        public void InsererCommande()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"INSERT INTO Commandes (ID_Client, DateCommande, MontantTotal, Statut)
                                 VALUES (@ID_Client, @DateCommande, @MontantTotal, @Statut);
                                 SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);
                    cmd.Parameters.AddWithValue("@Statut", Statut);

                    ID_Commande = (int)cmd.ExecuteScalar();
                }
            }

            // Ajouter les détails après création
            foreach (var d in Details)
            {
                d.ID_Commande = ID_Commande;
                d.InsererDetail();
            }
        }

        public void MettreAJourCommande()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"UPDATE Commandes SET 
                                 ID_Client = @ID_Client,
                                 DateCommande = @DateCommande,
                                 MontantTotal = @MontantTotal,
                                 Statut = @Statut
                                 WHERE ID_Commande = @ID_Commande";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);
                    cmd.Parameters.AddWithValue("@Statut", Statut);
                    cmd.Parameters.AddWithValue("@ID_Commande", ID_Commande);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerCommande()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string deleteDetails = "DELETE FROM DetailsCommandes WHERE ID_Commande = @ID_Commande";
                string deleteCommande = "DELETE FROM Commandes WHERE ID_Commande = @ID_Commande";

                using (SqlCommand cmd1 = new SqlCommand(deleteDetails, conn))
                using (SqlCommand cmd2 = new SqlCommand(deleteCommande, conn))
                {
                    cmd1.Parameters.AddWithValue("@ID_Commande", ID_Commande);
                    cmd2.Parameters.AddWithValue("@ID_Commande", ID_Commande);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
            }
        }

        public static List<Commande> ListerCommandes()
        {
            var liste = new List<Commande>();

            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = "SELECT * FROM Commandes ORDER BY DateCommande DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        liste.Add(new Commande
                        {
                            ID_Commande = Convert.ToInt32(reader["ID_Commande"]),
                            ID_Client = Convert.ToInt32(reader["ID_Client"]),
                            DateCommande = Convert.ToDateTime(reader["DateCommande"]),
                            MontantTotal = Convert.ToDecimal(reader["MontantTotal"]),
                            Statut = reader["Statut"]?.ToString() ?? "En Attente"
                        });
                    }
                }
            }

            return liste;
        }

        public void ChargerDetails()
        {
            Details = DetailsCommande.ListerDetailsParCommande(ID_Commande);
        }
    }
}
