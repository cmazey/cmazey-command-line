using System;

class Program {
  public static void Main (string[] args) {
    
   // See https://sehs.io for more information
    string[] sodas = new string[5];

    for (int i = 0; i < sodas.Length; i++)
    {
        Console.Write("Enter a soda: ");
        sodas[i] = Console.ReadLine();
    }

    Console.WriteLine("\nHere are your drinks: ");

    for (int i = 0; i < sodas.Length; i++)
    {
        Console.WriteLine($"{sodas[i]}");
    }

    Console.WriteLine("\nPress enter to continue/");
    Console.ReadLine();

    string[] tasks = new string[100];
    bool addingTasks = true;
    int taskCount = 0;

    Console.WriteLine("--- Todo List ---");

    while (addingTasks)
    {
        Console.WriteLine("-Menu-");
        Console.WriteLine("1) Add a task");
        Console.WriteLine("2) Finish");
        Console.Write("-> ");
        string input = Console.ReadLine();
    
        if (input == "1")
        {

            Console.Write("Enter task: ");
            tasks[taskCount] = Console.ReadLine();
            taskCount++;

        }
        else if (input == "2")
        {

            addingTasks = false;

        }
        else
        {

            Console.WriteLine("Invalid option. Try again.\n");

        }

        if (taskCount == 100)
        {
            Console.WriteLine("List is full...");
            addingTasks = false;
        }

    }

    Console.WriteLine("\nPrinting List");

    for (int i = 0; i < taskCount; i++)
    {
        Console.WriteLine($"* {tasks[i]}");
    }
  }
}