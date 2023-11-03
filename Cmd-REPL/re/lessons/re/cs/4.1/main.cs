using System;

class Program {
  public static void Main (string[] args) {

    // See https://sehs.io/ for more information

    void Genie()
    {
        Console.Write("What is your first wish? ");
        Console.ReadLine();
        Console.Write("What is your second wish? ");
        Console.ReadLine();
        Console.WriteLine("...");
        Thread.Sleep(3000);
        Console.WriteLine("I'll get right on that.");
    }

    int RandomNumber()
    {
        Random random = new Random();
        Console.Write("Enter your minimum: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your maximum: ");
        int max = Convert.ToInt32(Console.ReadLine());
        return random.Next(min, max + 1);
    }

    Genie();
    int n1 = RandomNumber();
    int n2 = RandomNumber();
    int n3 = RandomNumber();

    Console.WriteLine($"Your random numbers are: {n1}, {n2}, and {n3}");

    
  }
}