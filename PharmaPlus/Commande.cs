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
        public int ID_Utilisateur { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal MontantTotal { get; set; }

        public List<DetailsCommande> Details { get; set; } = new List<DetailsCommande>();

        public void InsererCommande()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string query = @"INSERT INTO Commandes (ID_Utilisateur, DateCommande, MontantTotal)
                                 VALUES (@ID_Utilisateur, @DateCommande, @MontantTotal);
                                 SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Utilisateur", ID_Utilisateur);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);

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
                                 ID_Utilisateur = @ID_Utilisateur,
                                 DateCommande = @DateCommande,
                                 MontantTotal = @MontantTotal
                                 WHERE ID_Commande = @ID_Commande";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Utilisateur", ID_Utilisateur);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);
                    cmd.Parameters.AddWithValue("@ID_Commande", ID_Commande);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerCommande()
        {
            using (SqlConnection conn = Connection.GetConnexion())
            {
                string deleteDetails = "DELETE FROM DetailsCommande WHERE ID_Commande = @ID_Commande";
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
                            ID_Utilisateur = Convert.ToInt32(reader["ID_Utilisateur"]),
                            DateCommande = Convert.ToDateTime(reader["DateCommande"]),
                            MontantTotal = Convert.ToDecimal(reader["MontantTotal"])
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
