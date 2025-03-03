using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class TaskUtility
    {/// <summary>
    /// task in wuth the name date due and  type of task 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="dueDate"></param>
    /// <param name="type"></param>
                       
        public static void TaskInfo(string name, string dueDate,string type)
        {
            
            Console.WriteLine($"Type of Task: {type},Due Date: {dueDate},Task: {name}");

        }


    }
}
