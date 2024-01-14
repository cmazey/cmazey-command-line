using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Zodiac Calendar ---\n");
        Console.Write("Enter your birth year: ");
        string input = Console.ReadLine();
        int year = Convert.ToInt32(input);
        int zodiacNumber = year % 12;

        Console.Write($"\nYour birth year was {year}, so you were born the year of the ");

        if (zodiacNumber == 0)
        {
            Console.WriteLine("monkey");
        }
        else if (zodiacNumber == 1)
        {
            Console.WriteLine("rooster");
        }
        else if (zodiacNumber == 3)
        {
            Console.WriteLine("pig");
        }
        else if (zodiacNumber == 4)
        {
            Console.WriteLine("rat");
        }
        else if (zodiacNumber == 5)
        {
            Console.WriteLine("ox");
        }
        else if (zodiacNumber == 6)
        {
            Console.WriteLine("tiger");
        }
        else if (zodiacNumber == 7)
        {
            Console.WriteLine("rabbit");
        }
        else if (zodiacNumber == 9)
        {
            Console.WriteLine("snake");
        }
        else if (zodiacNumber == 10)
        {
            Console.WriteLine("horse");
        }
        else
        {
            Console.WriteLine("sheep");
        }

        Console.WriteLine();
        Console.ReadLine();



        Console.Clear();
        Console.WriteLine("--- ATM Demo ---\n");
        Console.Write("Set your initial balance: $");
        input = Console.ReadLine();
        double balance = Convert.ToDouble(input);

        Console.WriteLine("Simple ATM");
        Console.WriteLine("--------------------");
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1) View Balance");
        Console.WriteLine("2) Deposit");
        Console.WriteLine("3) Withdraw");

        Console.Write("Enter your option (1,2,3): ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            Console.WriteLine($"Your balance is ${balance}.");
        }
        else if (option == "2")
        {
            Console.Write("How much would you like to deposit? $");
            input = Console.ReadLine();
            double deposit = Convert.ToDouble(input);
            balance = balance + deposit;
            Console.WriteLine($"Thank you for your deposit of ${deposit}");
            Console.WriteLine($"Your balance is now ${balance}.");
        }
        else if (option == "3")
        {
            Console.Write("How much would you like to withdraw? $");
            input = Console.ReadLine();
            double withdraw = Convert.ToDouble(input);
            balance = balance - withdraw;
            Console.WriteLine($"Thank you for your deposit of ${withdraw}");
            Console.WriteLine($"Your balance is now ${balance}.");
        }
        else
        {
            Console.WriteLine("Invalid option, Exiting...");
        }

        //12/09/2023, 11:42 AM EST
    }
}