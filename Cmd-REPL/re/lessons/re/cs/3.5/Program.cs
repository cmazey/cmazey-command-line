// See https://aka.ms/new-console-template for more information
bool managingInventory = true;
List<string> inventory = new List<string>()
{
    "axe",
    "shovel",
    "axe",
    "rope",
    "tent",
    "grill",
    "poncho",
    "sleeping bag",
    "flint",
    "sleeping bag"
};

Console.WriteLine("--- Inventory Manager ---");

while (managingInventory)
{
    Console.WriteLine("\n-Main Menu-");
    Console.WriteLine("1) List inventory");
    Console.WriteLine("2) Add new item");
    Console.WriteLine("3) Insert new item");
    Console.WriteLine("4) Find item");
    Console.WriteLine("5) Sort inventory");
    Console.WriteLine("6) Remove an item");
    Console.WriteLine("7) Delete inventory");
    Console.WriteLine("8) Exit");
    Console.Write("-> ");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("\n-Inventory-");

        if (inventory.Count == 0)
        {
            Console.WriteLine("No inventory.");
        }
        foreach (string item in inventory)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine();
    }
    else if (input == "2")
    {
        Console.Write("\nNew item: ");
        input = Console.ReadLine();
        inventory.Add(input);
        Console.WriteLine(input + " added to list.");
        Console.WriteLine();
    }
    else if (input == "3")
    {
        Console.Write("\nNew item: ");
        input = Console.ReadLine();

        Console.Write($"Which index? (0-{inventory.Count - 1}): ");
        int index = Convert.ToInt32(Console.ReadLine());

        inventory.Insert(index, input);
        Console.WriteLine(input + " inserted into list\n");

    }
    else if (input == "4")
    {
        Console.Write("\nWhich item? ");
        input = Console.ReadLine();
        int index = inventory.IndexOf(input);

        if (index >= 0)
        {
            Console.WriteLine($"{input} located at index {index}\n");
        }
        else
        {
            Console.WriteLine("Item not found...\n");
        }
    }
    else if (input == "5")
    {
        Console.WriteLine("\nSorting inventory.");
        inventory.Sort();
    }
    else if (input == "6")
    {
        Console.Write("\nWhich item? ");
        input = Console.ReadLine();
        bool itemRemoved = inventory.Remove(input);

        if (itemRemoved)
        {
            Console.WriteLine(input + " removed\n");
        }
        else
        {
            Console.WriteLine(input + " not found, or an error occured.\n");
        }
    }
    else if (input == "7")
    {
        Console.Write("Are you sure? (y/n) -> ");
        input = Console.ReadLine();

        if (input == "y")
        {
            inventory.Clear();
            Console.WriteLine("✓ Cleared!");
        }
        else
        {
            Console.WriteLine("Canceled.\n");
        }
    }
    else if (input == "8")
    {
        Console.WriteLine("Exiting.");
        managingInventory = false;
    }
    else
    {
        Console.WriteLine("Invalided answer, please try again.\n");
    }
}
