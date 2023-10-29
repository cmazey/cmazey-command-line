using System;

int wins = 0;
int losses = 0;
int half = 0;
int rounds = 1;

bool GuessN = true;

Random random = new();

System.Console.WriteLine(" - - - GUESS THE NUMBER - - - ");
System.Console.WriteLine(" - - Terminal Edition - - \n");
System.Threading.Thread.Sleep(1000);
while (GuessN)
{
    System.Console.WriteLine($" - Round: {rounds} - ");
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
    int entryDigitTwo = entryNum % 10;
    
    System.Console.WriteLine($"Input selected: {inputNum}\n");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("And the winning number is...");

    System.Threading.Thread.Sleep(5000);

    Console.SetCursorPosition(0, Console.CursorTop -1);
    System.Console.WriteLine($"And the winning number is {winningNum}");
    
    

}