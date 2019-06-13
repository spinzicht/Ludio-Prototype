using Ludio.Data.Tasks;
using Ludio.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Clients
{
    public class Client
    {
        public User User { get; set; }
        public List<Program> Programs { get; } = new List<Program>();
        public string DataFolder { get; set; }

        public Client()
        {
        }
    }
}
