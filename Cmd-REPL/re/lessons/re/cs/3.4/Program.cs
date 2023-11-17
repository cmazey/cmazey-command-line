// See https://sehs.io/ for more information
List<string> shoppingCart = new List<string>();
string input = "";

Console.WriteLine("--- Shopping Cart ---");

while (input != "3")
{
    Console.WriteLine("-Menu-");
    Console.WriteLine("1) Add item to shopping cart");
    Console.WriteLine("2) Display cart contents");
    Console.WriteLine("3) Exit");

    Console.Write("-> ");
    input = Console.ReadLine();

    if (input == "1")
    {
        Console.Write("Enter new item: ");
        input = Console.ReadLine();
        shoppingCart.Add(input);
    }
    else if (input == "2")
    {
        Console.WriteLine("\n-Cart Contents-");
        foreach (string item in shoppingCart)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
    else if (input == "3")
    {
        Console.WriteLine("Exiting...");
    }
    else
    {
        Console.WriteLine("Invalid option. Please select again.");
    }

    Console.WriteLine();

}