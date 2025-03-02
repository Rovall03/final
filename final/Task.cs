using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
 public abstract class Task
    {
       public string TaskName { get; set; }
        public string TaskDue { get; set; }
        public string TaskType { get; set; }

        public Task() { }


    }
}
