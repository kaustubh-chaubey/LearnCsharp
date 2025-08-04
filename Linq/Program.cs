using Linq.Services;
using System.Configuration;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        var brokerService = new BrokerLogInServices();
        brokerService.ShowAdultUsers();
    }
}