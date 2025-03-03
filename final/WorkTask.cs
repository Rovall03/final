namespace final
{/// <summary>
/// clas for work task 
/// </summary>
    internal class WorkTask : Task
    {/// <summary>
    /// info for work task 
    /// </summary>
        public override void TaskInfo()
        {
            Console.WriteLine($"Task: {TaskName},Due: {TaskDue}, Type of Task: {TaskType}");
        }
    }
}
