using System;

class Program {
  public static void Main (string[] args) {
    Random random = new();
    int secretNumber = random.Next(1, 11);
    int tries = 0;
    int guess = 0;

    while (guess != secretNumber)
    {
      Console.Write("Guess the number (1-10): ");
      guess = Convert.ToInt32(Console.ReadLine());
      tries = tries + 1;

      if (guess == secretNumber)
      {
        Console.WriteLine($"Correct! It took you {tries} tries!");
      }
      else if (guess > secretNumber)
      {
        Console.WriteLine("Wrong! Too high.");
      }
      else
      {
        Console.WriteLine("Wrong! Too low.");
      }
    }
  }
}