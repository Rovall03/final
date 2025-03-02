using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
 public abstract class Task
    {
        private  string _taskName;
        private string _taskDue;
        private string _taskType;


       public string TaskName
        {
            get { return _taskName; }
            set { 
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Enter Task Name");
                _taskName = value; }
        }
        public string TaskDue
        {
            get { return _taskDue; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Must have a due date");
                _taskDue = value; }
        }
        public string TaskType 
        { get  { return _taskType; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Must input type ");
                _taskType = value; }
        }
      
      public abstract void  TaskInfo();

        
    }
}
