using System;

int wins = 0;
int losses = 0;
int half = 0;
int rounds = 1;

bool GuessN = true;

Random random = new();

Console.Clear();
System.Console.WriteLine(" - - - GUESS THE NUMBER - - - ");
System.Console.WriteLine(" - - Terminal Edition - - ");
System.Threading.Thread.Sleep(1000);
while (GuessN)
{
    System.Console.WriteLine($"\n - Round: {rounds} - ");
    System.Threading.Thread.Sleep(500);
    System.Console.WriteLine($" - Guessed Correctly: {wins} - ");
    System.Threading.Thread.Sleep(500);
    System.Console.WriteLine($" - Halfly corrected: {half}");
    System.Threading.Thread.Sleep(500);
    System.Console.WriteLine($"- Failed Attempts: {losses} - \n");
    System.Threading.Thread.Sleep(1000);

    int winningNum = random.Next(0, 100);
    int winningDigitOne = winningNum / 10;
    int winningDigitTwo = winningNum % 10;

    System.Console.Write("Enter the guessing number (0 - 99) -> ");
    string inputNum = Console.ReadLine();
    int entryNum = Convert.ToInt32(inputNum);

    int inputDigitOne = entryNum / 10;
    int inputDigitTwo = entryNum % 10;
    
    System.Console.WriteLine($"Input selected: {inputNum}\n");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("And the winning number is...");

    System.Threading.Thread.Sleep(5000);

    Console.SetCursorPosition(0, Console.CursorTop -1);
    System.Console.WriteLine($"And the winning number is {winningNum}");
    
    if (entryNum == winningNum)
    {
        System.Console.WriteLine("YOU GOT THE RIGHT NUMBER, CONGRATS MY DUDE!!!\n");
        wins++;
    }
    else if (winningDigitOne == inputDigitTwo && winningDigitTwo == inputDigitOne)
    {
        System.Console.WriteLine("The digits are matched, but they are out of order though, so you halfly got it corrected, Congrats!\n");
        half++;
    }
    else
    {
        System.Console.WriteLine("The winning number does not matched. Better luck next time!\n");
        losses++;
    }

    System.Console.Write("\nPlay again? (y/n) -> ");
    string input = Console.ReadLine();

    if (input == "y")
    {
        Console.Clear();
        rounds++;
    }
    else 
    {
        Console.Clear();
        GuessN = false;
    }

}

System.Console.WriteLine(" - - - RESULTS - - - ");
System.Console.WriteLine($" | Guessed Correctly: {wins} / ");
System.Console.WriteLine($" | Halfly Corrected: {half}  |");
System.Console.WriteLine($"/ Failed Attempts: {losses}  | ");
Console.ReadLine();