using System.Data;
using MySqlConnector;

namespace FinanceRepository
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);
    }
}
