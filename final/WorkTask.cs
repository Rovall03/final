namespace final
{
    internal class WorkTask : Task
    {
        public override void TaskInfo()
        {
            Console.WriteLine($"Task: {TaskName},Due: {TaskDue}, Type of Task: {TaskType}");
        }
    }
}
