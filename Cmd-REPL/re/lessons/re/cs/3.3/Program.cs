// See https://aka.ms/new-console-template for more information

List<string> tasks = new List<string>();
bool addingTasks = true;

Console.WriteLine("--- Todo List");
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
        input = Console.ReadLine();
        tasks.Add(input);
    }
    else if (input == "2")
    {
        addingTasks = false;
    }
    else
    {
        Console.WriteLine("Invalid option. Try again.\n");
    }

    Console.WriteLine("\nPrinting List");

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"* {tasks[i]}");
    }

}
