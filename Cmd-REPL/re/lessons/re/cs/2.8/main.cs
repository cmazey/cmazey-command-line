using System;

class Program {
  public static void Main (string[] args) {
    
int wins = 0;
int losses = 0;
int round = 1;
bool playing = true;
Random random = new();

Console.WriteLine("---ROCK, PAPER, SCISSORS---");
Console.WriteLine(" --202X TERMINAL EDITION --");

while (playing)
{
  
  Console.WriteLine($"\nROUND {round}!");
  Console.WriteLine($"W: {wins} - L: {losses}");
  Console.WriteLine("Rock, Paper, Scissors?");
  string player = Console.ReadLine().ToLower();

  int randomNumber = random.Next(0, 3);
  string computer;

  if (randomNumber == 0)
  {
    computer = "rock";
  }
  else if (randomNumber == 1)
  {
    computer = "paper";
  }
  else
  {
    computer = "scissors";
  }

  Console.WriteLine($"Computer chooses {computer}!");

  // LINE 56 (https://sehs.io/c-sharp-fundamentals/activities/2-8-rock-paper-scissors/)

if (player == computer)
{
  Console.WriteLine("Tie!");    
}
else if (player == "rock" && computer == "scissors")
{
  Console.WriteLine("You win! Rock crushes scissors.");
  wins++;
}
  else if (player == "rock" && computer == "paper")
{
  Console.WriteLine("You lose! Paper covers rock!");
  losses++;
}
else if (player == "paper" && computer == "rock")
{
    Console.WriteLine("You win! Paper covers rock!");
  wins++;
}
else if (player == "paper" && computer == "scissors")
{
   Console.WriteLine("You lose! Scissors cuts paper!");
  losses++;
}
else if (player == "scissors" && computer == "paper")
{
    Console.WriteLine("You win! Scissors cuts paper!");
  wins++;
}
else if (player == "scissors" && computer == "rock")
{
    Console.WriteLine("You lose! Rock crushes scissors!");
  losses++;
}
else
{
  Console.WriteLine("You typed something wrong. You suck."); 
}

Console.Write("\nPlay again (yes, no)?: ");
string playAgain = Console.ReadLine();

if (playAgain == "no")
{
    Console.WriteLine("\n--- RESULTS ---");
    Console.WriteLine($"  W: {wins} - L: {losses}");
    Console.Write("\nClick enter to terminate program...");
    Console.ReadLine();
    playing = false;
}
else
{
  round++;  
}
  
}
}
}


// 28/09/2023, 02:17 PM EST