using Ludio.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Tasks
{
    public class Tutorial : Task
    {
        public string Name { get; set; }
        public Tutor Tutor { get; set; }
        public string Thumbnail { get; set; }

        public override int Progress { get; }
        public override bool IsDone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}