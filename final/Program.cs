﻿namespace final
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


                    Console.Write("Type of Task: ");
                    workTask.TaskType = Console.ReadLine();


                    Console.Write("Task Due: ");
                    workTask.TaskDue = Console.ReadLine();

                    tasks.Add(workTask);
                    Console.WriteLine("Task Added to List");
                }
               else  if (menu == 2)
                {
                  SchoolTask schoolTask= new SchoolTask();
                    Console.Write("School Task Name: ");
                    schoolTask.TaskName = Console.ReadLine();


                    Console.Write("Type of Task: ");
                    schoolTask.TaskName = Console.ReadLine();


                    Console.Write("Task Due: ");
                    schoolTask.TaskName = Console.ReadLine();

                    tasks.Add(schoolTask);
                    Console.WriteLine("Task Added to List");
                }
            }
        }
    }
}
