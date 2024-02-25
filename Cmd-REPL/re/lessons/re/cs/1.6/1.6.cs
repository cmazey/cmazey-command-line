using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey! What's your name? My name's Someone! ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}, that's fun to say! {name}, {name}...\n");

        Console.Write("Does someone need a hug? ");
        string answer = Console.ReadLine();
        Console.WriteLine($"{answer}!? I just want a hug!\n");

        Console.Write("Buddy the Elf, what's your favorite color? ");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine($"That's a nice {favoriteColor} outfit, very {favoriteColor}-y.\n\n\n");

        Console.WriteLine("--- SECRET AGENT CONSOLE ---");
        Console.WriteLine("CREATING NEW IDENTITY, PLEASE HOLD...");

        Console.WriteLine();
        Console.WriteLine($"NAME AUTOCORRECTED");
        Console.WriteLine($"{name}");
        Console.WriteLine($"Enter your code name Agent {name}. ");
        string codeName = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Choose your gadget:");
        Console.WriteLine("- ASMR Radio");
        Console.WriteLine("- Flashbang Energy Drink");
        Console.WriteLine("- Metamucil");
        Console.Write("-> ");
        string gadget = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("-- Constructing your agent identity --");
        Console.WriteLine($"AGENT NAME: {name} - CODE NAME {codeName}");
        Console.WriteLine($"GADGET: {gadget}");
        Console.WriteLine("-- INDENTITY CONFIRMED EXITING PROGRAM... --\n\n");
    }
}