namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Task> tasks = new List<Task>();
            while (true)
            {
                
                if (tasks.Count >= 50)
                {
                    break;
                }
                
                Console.WriteLine("Task Managent Sytem");
                int menu = 0;
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1 Add a Work Task: ");
                Console.WriteLine("2 Add a School Task: ");
                Console.WriteLine("3 Display all Task : ");
                Console.WriteLine("4 Update Task: ");
                Console.WriteLine("5 Romove Task from List ");
                Console.WriteLine("6 Exit");
                Console.Write("Your choice: ");
                
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                if (menu == 1)
                {
                    WorkTask workTask = new WorkTask();
                    Console.Write("Work Task Name: ");
                    workTask.TaskName = Console.ReadLine();


                    Console.Write("Type of Task: ");
                    workTask.TaskType = Console.ReadLine();


                    Console.Write("Task Due: ");
                    workTask.TaskDue = Console.ReadLine();

                    tasks.Add(workTask);
                    Console.WriteLine("Task Added to List");
                }
                else if (menu == 2)
                {
                    SchoolTask schoolTask = new SchoolTask();
                    Console.Write("School Task Name: ");
                    schoolTask.TaskName = Console.ReadLine();


                    Console.Write("Type of Task: ");
                    schoolTask.TaskType = Console.ReadLine();


                    Console.Write("Task Due: ");
                    schoolTask.TaskDue = Console.ReadLine();

                    tasks.Add(schoolTask);
                    Console.WriteLine("Task added to list");
                }
                else if (menu == 3)
                {
                    foreach (Task task in tasks)
                    {
                        task.TaskInfo();
                    }
                }
                else if (menu == 4)
                {
                    Console.Write("Name of task to update:");
                    string taskName = Console.ReadLine();
                    for (int i = 0; i < tasks.Count; i++)
                    {

                        if (tasks[i].TaskName.ToLower() == taskName.ToLower())
                        {
                            Console.Write("New task Name: ");
                            tasks[i].TaskName = Console.ReadLine();
                            Console.Write("New  type of task: ");
                            tasks[i].TaskType = Console.ReadLine();
                            Console.Write("New due date: ");
                            tasks[i].TaskDue = Console.ReadLine();
                            break;
                        }
                        else if (i == tasks.Count - 1)
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                }

                else if (menu == 5)

                {
                    Console.Write("Nmae of Task to Remove ");
                    string taskName = Console.ReadLine();

                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i].TaskName.ToLower() == taskName.ToLower())
                        {
                            {
                                tasks.Remove(tasks[i]);
                                Console.WriteLine("Task removed ");
                                break;
                            }
                        }
                        else if (i == tasks.Count - 1)
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                }
                else if (menu == 6)
                { 
                    Console.WriteLine("Goodbye");
                    break;
                }

            }
        }
    }
}


        
    

