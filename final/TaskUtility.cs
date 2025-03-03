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
                       
        public static void TaskInfo(string name, string dueDate,string type)
        {
            
            Console.WriteLine($"Type of Task: {type},Due Date: {dueDate},Task: {name}");

        }


    }
}
