using System;

class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("--- MULTIPLICATION TABLE ---");
        Console.Write("What number do you want to multiply up to? -> ");
        int max = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= max; i++)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (i == 0)
            {
                Console.Write("  ");
            }
            else
            {
                Console.Write(i + " ");
            }

        }

        Console.WriteLine();

        for (int i = 1; i <= max; i++)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(i + "  ");
            Console.ForegroundColor = ConsoleColor.White;

            for (int j = 1; j <= max; j++)
            {
                Console.Write(i * j + " ");
            }

            Console.WriteLine();
        }




    }
}