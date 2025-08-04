using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Model
{
    class BrokerLogInDump
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? BrokerId { get; set; }
        public string? JsonDump { get; set; }
        public string? Token { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
