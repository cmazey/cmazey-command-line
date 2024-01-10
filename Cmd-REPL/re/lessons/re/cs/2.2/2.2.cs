using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter your age: ");
    string input = Console.ReadLine();
    int age = Convert.ToInt32(input);

    if (age < 0)
    {
      Console.WriteLine("You're just a baby, you're not ready yet!\n");
      
    }
  if (age >= 13)
    {
      Console.WriteLine("You're old enough to join Cobra Kai!");
      Console.WriteLine("Although, the last few seasons were terrible...\n");
    }
  if (age >= 16)
    {
      Console.WriteLine("You're old enough to get your license!\n");
    }
  if (age >= 18)
    {
      Console.WriteLine("You're old enough to live on your own.");
      Console.WriteLine("So... Get out of your parents' basement creep!\n");
    }
  if (age >= 35)
    {
      Console.WriteLine("You're old enough to run for president.");
      Console.Write("Enter your full name: ");
      string name = Console.ReadLine();

      Console.Write("What year will you run? ");
      string year = Console.ReadLine();

      Console.Write("What's your nickname (adjective): ");
      string nickname = Console.ReadLine();

      Console.WriteLine($"/n{nickname} {name} for president! Coming {year}!");
    }
  }
}