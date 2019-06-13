using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Users
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Token { get; private set; }

        public User(string name, string token)
        {
            Name = name;
            Token = token;
        }
    }
}