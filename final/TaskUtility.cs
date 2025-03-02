using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class TaskUtility
    {
        public static void TaskInfo(string name)
        {
            Console.WriteLine($"Task: {name}");

        }
        public static void TaskInfo(string name,string dueDate)
        {
            TaskInfo(name);
            Console.WriteLine($"Due Date: {dueDate}"); 
        
        }
        public static void TaskInfo(string name, string dueDate,string type)
        {
            TaskInfo(name,dueDate);
            Console.WriteLine($"Type of Task: {type}");

        }


    }
}
