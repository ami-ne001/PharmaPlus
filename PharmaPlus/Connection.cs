using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class Connection
    {
        private static string connectionString =
            "data source=DATTEBAYO\\SQLEXPRESS; initial catalog=PharmaPlusNew; integrated security=true; trustServerCertificate=true;";
        public static SqlConnection GetConnexion()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
