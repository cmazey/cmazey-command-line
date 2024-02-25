using System;

class Program
{
    public static void Main(string[] args)
    {
        int playerHealth = 10;
        int enemyHealth = 10;
        bool escaped = false;
        Random random = new();

        Console.WriteLine("-- Menu --");
        Console.WriteLine("1) attack");
        Console.WriteLine("2) run");

        Console.Write("-> ");
        string choice = Console.ReadLine();

        if (choice == "1" || choice == "attack")
        {
            int playerAttack = random.Next(1, 11);
            int enemyAttack = random.Next(1, 11);

            enemyHealth = enemyHealth - playerAttack;
            playerHealth = playerHealth - enemyAttack;

            Console.WriteLine($"You did {playerAttack} damage!");
            Console.WriteLine($"Enemy has {enemyHealth} health left.\n");
            Console.WriteLine($"Enemy did {enemyAttack} health left.");
            Console.WriteLine($"Enemy has {playerHealth} health left.\n");
        }
        else if (choice == "2" || choice == "run")
        {
            Console.WriteLine("You ran away like a baby.");
            escaped = true;
        }
        else
        {
            Console.WriteLine("Invalid option selected. Exiting battle.");
        }

        if (escaped)
        {
            Console.WriteLine("Bye bye! Back home to Mommy!");
            Console.ReadLine();
        }
        else if (playerHealth > enemyHealth)
        {
            Console.WriteLine("You are beating the enemy!");
            Console.ReadLine();
        }
        else if (enemyHealth > playerHealth)
        {
            Console.WriteLine("Be careful, the enemy is beating you!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine();
            Console.Clear();
        }


        int winningNumber = random.Next(0, 100);

        int winningDigitOne = winningNumber / 10;
        int winningDigitTwo = winningNumber % 10;

        Console.Write("Enter your lottery number (0 - 99): ");
        string inputLot = Console.ReadLine();
        int entryNumber = Convert.ToInt32(inputLot);
        int entryDigitOne = entryNumber / 10;
        int entryDigitTwo = entryNumber % 10;

        Console.WriteLine($"\nAnd the winning number is.... {winningNumber}");

        if (entryNumber == winningNumber)
        {
            Console.WriteLine("Exact match! You win the grand prize of $100,000!");
        }
        else if (winningDigitOne == entryDigitTwo && winningDigitTwo == entryDigitOne)
        {
            Console.WriteLine("You digits match, but out of order! You win $3,000!");
        }
        else
        {
            Console.WriteLine("No match. Better luck next time!");
        }

        Console.ReadLine();


    }
}