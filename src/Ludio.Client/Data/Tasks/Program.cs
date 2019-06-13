using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Tasks
{
    public class Program : Task
    {
        public string Name { get; set; }
        public List<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
        public override int Progress
        {
            get
            {
                int progress = 0;
                Tutorials.ForEach(x => progress += x.Progress);
                return progress / Tutorials.Count;
            }
        }

        public override bool IsDone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
