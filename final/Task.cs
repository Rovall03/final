using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{/// <summary>
/// class for task
/// </summary>
 public abstract class Task
    {
        private  string _taskName;
        private string _taskDue;
        private string _taskType;
        /// <summary>
        /// get set info for name
        /// </summary>
       public string TaskName
        {
            get { return _taskName; }
            set { 
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Enter Task Name");
                _taskName = value; }
        }
        /// <summary>
        /// get sets info for due dates 
        /// </summary>
        public string TaskDue
        {
            get { return _taskDue; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Must have a due date");
                _taskDue = value; }
        }
        /// <summary>
        /// get sets info for  type of task 
        /// </summary>
        public string TaskType 
        { get  { return _taskType; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Must input type ");
                _taskType = value; }
        }
      /// <summary>
      /// inof for each task 
      /// </summary>
      public abstract void  TaskInfo();

        
    }
}
