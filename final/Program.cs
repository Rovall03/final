namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Task> tasks = new List<Task>();
            while (true)
            {
                Console.WriteLine("Task Managent Sytem");
                int menu = 0;
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1 Add a Work Task: ");
                Console.WriteLine("2 Add a School Task: ");
                Console.WriteLine("3 Display all Task : ");
                Console.WriteLine("4 Romove Task from List ");
                 Console.WriteLine("5 Exit");
                Console.Write("Your choice: ");

                try
                { menu = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                if (menu ==1)
                {
                    WorkTask workTask = new WorkTask();
                    Console.Write("Work Task Name: ");
                    workTask.TaskName = Console.ReadLine();
                                        
                }
            }
        }
    }
}
