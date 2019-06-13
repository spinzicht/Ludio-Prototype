using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludio.Data.Tasks
{
    public abstract class Task
    {
        protected Task ParentTask { get; set; }

        public abstract int Progress { get; }

        public abstract bool IsDone { get; set; }

        public Task(Task parentTask = null)
        {
            ParentTask = parentTask;
        }

        public virtual Task NextTask()
        {
            return ParentTask?.NextTask() ?? null;
        }
    }
}