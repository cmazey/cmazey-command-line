System.Threading.Thread.Sleep(3000);
Console.Clear();

Console.WriteLine ("--- CMAZEY CALCULATOR ---");
Console.WriteLine("ALPHA v6.9");

Console.WriteLine("\nType /help to show all the available commands!");

bool cmazeyCalculator = true;
while (cmazeyCalculator)
{
  Console.Write("-> ");
  string input = Console.ReadLine();
  // ADDITION
  if (input == "Addition" || input == "+")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine("CMAZEY CALCULATOR: ADDITION [+]");
    Console.Write("\n? + ? = -> ");
    int add1 = Convert.ToInt32(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.Write($"\r{add1} + ? = ? -> ");
    int add2 = Convert.ToInt32(Console.ReadLine());

    int addTotal = add1 + add2; // Adds the numbers

    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.WriteLine($"\r{add1} + {add2} = {addTotal}      ");
    Console.ReadLine();
  }

  // SUBTRACTION
    else if (input == "Subtraction" || input == "-") 
  {
    Console.WriteLine("\n----------------------------------------------\n");

    Console.WriteLine("CMAZEY CALCULATOR: SUBTRACTION [-]");

    Console.Write("\n? - ? = ? -> ");
    int sub1 = Convert.ToInt32(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop -1);

    Console.Write($"\r{sub1} - ? = ? -> ");
    int sub2 = Convert.ToInt32(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop -1);
    int subTotal = sub1 - sub2; // Subtracts the numbers


    Console.WriteLine($"\r{sub1} - {sub2} = {subTotal}        ");
    Console.ReadLine();
  }

  // HELP COMMAND
  else if (input == "/help" || input == "help")
  {
    Console.WriteLine("\n- Addition");
    Console.WriteLine("- Subtraction");
    Console.WriteLine("- Multiplication");
    Console.WriteLine("- Division");
    Console.WriteLine("- LineSlope");
    Console.WriteLine("- HToI");
    Console.WriteLine("- 8Ball");
    Console.WriteLine("- Lottery");
    Console.WriteLine("- Change\n");
    Console.WriteLine("- Exit");
  }
  
  // MULTIPLICATION
  else if (input == "Multiplication" || input == "x")
  {
    
    Console.WriteLine("\n----------------------------------------------\n");
  
    Console.WriteLine("CMAZEY CALCULATOR: MULTIPLICATION [x]\n");

    Console.Write("? x ? = ? -> ");
    int mult1 = Convert.ToInt32(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.Write($"{mult1} x ? = ? -> ");
    int mult2 = Convert.ToInt32(Console.ReadLine());

    int multTotal = mult1 * mult2; // Multiply the number
    Console.SetCursorPosition(0, Console.CursorTop -1);

    Console.WriteLine($"\r{mult1} x {mult2} = {multTotal}     ");
    Console.ReadLine();
  }

  // DIVISION / DIVIDE
  else if (input == "Division" || input == "/")
  {
    Console.WriteLine("\n----------------------------------------------\n");

    Console.WriteLine("CMAZEY CALCULATOR: DIVISION [/]");

    Console.Write("\n? / ? = ? -> ");
    double div1 = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.Write($"\r{div1} / ? = ? -> ");
    double div2 = Convert.ToDouble(Console.ReadLine());

    double divTotal = (div1 / div2); // Divides the numbers
    Console.SetCursorPosition(0, Console.CursorTop -1);

    Console.WriteLine($"\r{div1} / {div2} = {divTotal}           ");
    Console.ReadLine();
  }

  //CHANGECALCULATOR // CHANGE
  else if (input == "Change")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine("CMAZEY CALCULATOR: CHANGE CALCULATOR [₵]");

    Console.Write("\nEnter change to give back (1c - 99c): ");

    int change = Convert.ToInt32(Console.ReadLine());

    int Quarters = (change / 25); // Divides the change amount by 25.
    int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
    int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
    int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;

    Console.SetCursorPosition(0, Console.CursorTop -1);
    Console.WriteLine($"Change Amount: {change}₵                                        ");

    Console.WriteLine($"\nQuarters: {Quarters}");
    Console.WriteLine($"Dimes: {Dimes}");
    Console.WriteLine($"Nickels: {Nickels}");
    Console.WriteLine($"Pennies: {Pennies}");
    
    Console.ReadLine();
  }
  //Clear
  else if (input == "Clear")
  {
    Console.Clear();
    Console.WriteLine("\nType /help to show all the available commands!\n");
  }
  //LINE SLOPE CALCULATOR
  else if (input == "LineSlope")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine ("CMAZEY CALCULATOR: Line Slope Calculator\n");
    Console.Write("x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    double slope = (y2 - y1) / (x2 - x1);

    Console.WriteLine($"\nThe slope of the through points ({x1}, {y1}) and ({x2}, {y2}) is {slope}!");
    Console.ReadLine();
  }

  //HeightToInches
  else if (input == "HToI")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine("CMAZEY CALCULATOR: HEIGHT TO INCHES\n");
    Console.Write("Enter your height in inches: ");
    int height = Convert.ToInt32(Console.ReadLine());
    int num = 12;
    int foot = height / num; // Dividing the height in inches by 12
    int inches = height % num;

    Console.WriteLine($"\nYou are {foot}ft, {inches}in.");
    Console.ReadLine();
    Console.WriteLine("----------------------------------------------\n");
  }

  // 8 BALL
  else if (input == "8Ball")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine ("--- Magic 8 Ball ---\n");
    Console.WriteLine("What is your question?");
    Console.Write("-> ");
    string EightBallInput = Console.ReadLine();
    Random random = new();
    
    int eightBall = Convert.ToInt32(random.Next(1,7));
    if (eightBall == 1)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("It is certain!");
      Console.ReadLine();
    }
    else if (eightBall == 2)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("Without a doubt!");
      Console.ReadLine();
    }
    else if (eightBall == 3)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("Ask again later.");
      Console.ReadLine();
   }
    else if (eightBall == 4)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("Cannot predict now.");
      Console.ReadLine();
    }
    else if (eightBall == 5)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("Don't count on it.");
      Console.ReadLine();
    }
    else if (eightBall == 6)
    {
      Console.Write("\nMagic 8-Ball: ");
      Console.WriteLine("Outlook not so good.");
      Console.ReadLine();
    }

    Console.WriteLine("----------------------------------------------\n"); 
  }

  // LOTTERY
  else if (input == "Lottery")
  {
    Console.WriteLine("\n----------------------------------------------\n"); 
      
    Random random = new();
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

    Console.WriteLine("----------------------------------------------\n"); 
  }
  // MORE COMING SOON

  else if (input == "Exit")
  {
    Console.WriteLine("Exiting...\n\n");
    cmazeyCalculator = false;
  }
      
  // INVALID RESPONSE
  else 
  {
    Console.WriteLine("Invalid Command, please try again.\n");
    Random random = new();
    int elseChoice = random.Next(1, 4);
    if (elseChoice == 1)
    {
      Console.WriteLine("Fun Fact: A command start with a capital letter!\n");
    }
    else if (elseChoice == 2)
    {
      Console.WriteLine("Fun Fact: You can use symbols too instead of typing commands. E.G. +, -, x, /\n");
    }
  }
}


Console.Write("Press enter to exit program...");
Console.ReadLine();