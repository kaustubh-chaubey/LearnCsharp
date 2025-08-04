using Linq.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Data
{
    class DataFlow
    {
        private static string? _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static List<BrokerLogInDump> GetUsers()
        {
            var users = new List<BrokerLogInDump>();
            string connStr = _connectionString;
            string query = "select * from BrokerLogInDump";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new BrokerLogInDump
                    {
                        Id = (int)reader["Id"],
                        BrokerId = reader["BrokerId"].ToString(),
                        UserId = reader["UserId"].ToString()
                    });
                }
            }

            return users;
        }
    }
}
