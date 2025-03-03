namespace final
{
    internal class Program
    {/// <summary>
    /// main for task sytem
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {

//list for task 
            List<Task> tasks = new List<Task>();
            while (true)
            {
                /// keeps list to 50 max 
                if (tasks.Count >= 50)
                {
                    break;
                }
                ///menu 
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
                /// if 1 is inout ask for info on work task to be added
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
                ///if 2 is selected ask for input of school task to be addded
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
                //3 runs through list and displays all items added to list 
                else if (menu == 3)
                {
                    foreach (Task task in tasks)
                    {
                        task.TaskInfo();
                    }
                }
                ///4  gives option to update listr item 
                else if (menu == 4)
                {
                    Console.Write("Name of task to update:");
                    string taskName = Console.ReadLine();
                    //runs through list 
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        //finds matching item 
                        if (tasks[i].TaskName.ToLower() == taskName.ToLower())
                        {                     
                            /// takes in put and creats new updated item to list removes old item

                            Console.Write("New task Name: ");
                            tasks[i].TaskName = Console.ReadLine();
                            Console.Write("New  type of task: ");
                            tasks[i].TaskType = Console.ReadLine();
                            Console.Write("New due date: ");
                            tasks[i].TaskDue = Console.ReadLine();
                            break;

                        }
                        //if item not on list give error 
                        else if (i == tasks.Count - 1)
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                }
                ///5 gives option to remove item by inputting name 
                else if (menu == 5)

                {
                    Console.Write("Name of Task to Remove ");
                    string taskName = Console.ReadLine();
                    //runs through list and if checks if any items match 
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i].TaskName.ToLower() == taskName.ToLower())
                        {
                            {
                                ///removes item when found
                                tasks.Remove(tasks[i]);
                                Console.WriteLine("Task removed ");
                                break;// breaks when item is found and removed 
                            }
                        }
                        //error if item is not found 
                        else if (i == tasks.Count - 1)
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                }
                ///exit 
                else if (menu == 6)
                { 
                    Console.WriteLine("Goodbye");
                    break;
                }

            }
        }
    }
}


        
    

