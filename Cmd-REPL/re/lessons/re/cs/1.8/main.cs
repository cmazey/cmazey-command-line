using System;

class Program {
  public static void Main (string[] args) {
// See https://sehs.io/ for more information
Console.WriteLine("--- Circumference Calculator! ---");

Console.Write("Enter radius: ");
double radius = Convert.ToDouble(Console.ReadLine());
double circumference = 2 * Math.PI * radius;

Console.WriteLine($"Radius: {radius}, Circumference: {circumference}");
Console.WriteLine($"Rounded circumference {Math.Round(circumference, 2)}\n");

Console.WriteLine("--- More math functions ---");

Console.Write("Enter base number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{number} cubed equals {Math.Pow(number, 3)}");

Console.Write("Enter positive number: ");
number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The sqare root of {number} is {Math.Sqrt(number)}");

Console.Write("Enter a decimal number: ");
number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Round: {Math.Round(number)}, Floor: {Math.Floor(number)}, Ceil: {Math.Ceiling(number)}");

Console.WriteLine("--- Random Number generation ---");
Random random = new();

Console.WriteLine($"\n\nRandom number between 1 and 10: {random.Next(1, 11)}");
Console.WriteLine($"Random number between 1 and 10: {random.Next(1, 11)}"); 
Console.WriteLine($"Random number between 1 and 10: {random.Next(1, 11)}");

  }
}