using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{/// <summary>
/// class for school task 
/// </summary>
    internal class SchoolTask : Task
    {/// <summary>
    /// info for school task
    /// </summary>
        public override void TaskInfo()
        {
            Console.WriteLine($"Task: {TaskName},Due: {TaskDue}, Type of Task: {TaskType}");
        }
    }
}
