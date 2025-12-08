using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    internal class Connection
    {
        private static string connectionString =
            "data source=DESKTOP-F711K41\\GI2; initial catalog=PharmaPlusNew; integrated security=true; trustServerCertificate=true;";
        public static SqlConnection GetConnexion()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
