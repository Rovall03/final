using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class SchoolTask : Task
    {
        public override void TaskInfo()
        {
            Console.WriteLine($"Task: {TaskName},Due: {TaskDue}, Type of Task: {TaskType}");
        }
    }
}
