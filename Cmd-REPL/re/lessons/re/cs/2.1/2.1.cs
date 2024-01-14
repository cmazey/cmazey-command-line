using System;

class Program
{
    public static void Main(string[] args)
    {
        string name = "Mr. Mortimer";
        int age = 30;
        double bankAccount = 150;
        bool isATeacher = true;
        bool isAMillionaire = false;

        Console.WriteLine($"Is my name Mr. Mortimer? {name == "Mr. Mortimer"}");
        Console.WriteLine($"Is my name Mr. Mertens? {name == "Mr. Mertens"}");
        Console.WriteLine($"My name is not Mr. Merriman? {name != "Mr. Merriman"}\n");

        Console.WriteLine($"Am I old enough to drive? {age >= 16}");
        Console.WriteLine($"Do I have enough to buy a Dodge Challenger? {bankAccount > 31000}\n");

        Console.WriteLine($"{name} os a teacher: {isATeacher == true}");
        Console.WriteLine($"{name} is a millionaire: {isAMillionaire}");
        Console.WriteLine($"So, {name} isn't a millionaire? {!isAMillionaire}");
    }
}