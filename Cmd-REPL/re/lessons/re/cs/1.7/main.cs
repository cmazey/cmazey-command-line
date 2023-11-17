using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("--- Age to Months Calculator ---");

    Console.Write("Enter your age: ");
    string ageString = Console.ReadLine();
    int age = Convert.ToInt32(ageString);

    Console.WriteLine($"You are {age} years old. That's {age * 12} months old, you old fart!\n");

    Console.WriteLine("--- Square Area Calculator ---");

    Console.Write("Enter the length of the square: ");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the unit of measurement (in, ft, m): ");
    string unit = Console.ReadLine();
    double area = length * length;

    Console.WriteLine($"The area of the sqaure is {area}{unit} squared");
  }
}