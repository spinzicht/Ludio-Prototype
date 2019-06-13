using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Tasks
{
    public class Section : Task
    {
        public override int Progress => throw new NotImplementedException();

        public override bool IsDone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
