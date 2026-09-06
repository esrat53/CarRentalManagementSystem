using Microsoft.Data.SqlClient;

namespace CarRentalManagementSystem.Database
{
    public class DatabaseHelper
    {
        private readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
