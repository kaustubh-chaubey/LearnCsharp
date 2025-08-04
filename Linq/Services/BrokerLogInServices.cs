using Linq.Data;
using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Services
{
    class BrokerLogInServices
    {
        public void ShowAdultUsers()
        {
            List<BrokerLogInDump> _data = DataFlow.GetUsers();

            var adults = _data
                .Where(u => Convert.ToInt32(u.BrokerId) > 0)
                .OrderBy(u => Convert.ToInt32(u.BrokerId))
                .ToList();

            Console.WriteLine("Data flow: ");
            foreach (var user in adults)
            {
                Console.WriteLine($"Broker Id: {user.BrokerId}  UserId: {user.UserId}");
            }
        }
    }
}
