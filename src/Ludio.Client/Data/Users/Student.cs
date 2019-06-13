using Ludio.Data.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Users
{
    public class Student : User
    {
        public Student(string name, string token) : base(name, token) { }

        public List<Tutorial> Tutorials { get; private set; } = new List<Tutorial>();
    }
}