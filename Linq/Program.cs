using System.Configuration;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            Console.WriteLine("Connected to database!");

        }
    }
}