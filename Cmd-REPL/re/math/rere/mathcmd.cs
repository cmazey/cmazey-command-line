using System.Security.Cryptography.X509Certificates;
using Spectre.Console;
bool basic = false;
string version = "ALPHA v6.11.1";

System.Threading.Thread.Sleep(3000);
Console.Clear();

AnsiConsole.Write(
  new FigletText("CMAZEY CALCULATOR")
  .LeftJustified()
  .Color(Color.Red));
AnsiConsole.Markup($"[yellow]{version}[/]");

Console.WriteLine("\nType /help to show all the available commands!");

bool cmazeyCalculator = true;
while (cmazeyCalculator)
{
  Console.Write("-> ");
  string input = Console.ReadLine().ToLower();

  // ADDITION
  if (input == "addition" || input == "+")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine("CMAZEY CALCULATOR: ADDITION [+]");
    
    if (basic)
    {
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

    else
    {
      var add1 = AnsiConsole.Prompt(
        new TextPrompt<int>("[green]?[/] + ? = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      var add2 = AnsiConsole.Prompt(
        new TextPrompt<int>($"[lightskyblue1]{add1} +[/] [green]?[/] = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      int addTotal = add1 + add2;

      var addTable = new Table();
      addTable.AddColumn($"[lightskyblue1]{add1} + {add2} =[/] [green]{addTotal}[/]");
      AnsiConsole.Write(addTable);
      Console.ReadLine();
    }
    Console.WriteLine("----------------------------------------------\n");
  }

  // SUBTRACTION
    else if (input == "subtraction" || input == "-") 
  {
    Console.WriteLine("\n----------------------------------------------\n");

    Console.WriteLine("CMAZEY CALCULATOR: SUBTRACTION [-]");
    if (basic)
    {
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

    else
    {
      var sub1 = AnsiConsole.Prompt(
        new TextPrompt<int>("[green]?[/] - ? = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      var sub2 = AnsiConsole.Prompt(
        new TextPrompt<int>($"[lightskyblue1]{sub1} -[/] [green]?[/] = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      int subTotal = sub1 - sub2;

      var subTable = new Table();
      subTable.AddColumn($"[lightskyblue1]{sub1} + {sub2} =[/] [green]{subTotal}[/]");
      AnsiConsole.Write(subTable);
      Console.ReadLine();
    }
    Console.WriteLine("\n----------------------------------------------\n");
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
    Console.WriteLine("- Change");
    Console.WriteLine("- Clear");
    Console.WriteLine("- Version");
    Console.WriteLine("- Basic");
    Console.WriteLine("- Calendar");
    Console.WriteLine("- Exit\n");
  }
  
  // MULTIPLICATION
  else if (input == "multiplication" || input == "x")
  {
    
    Console.WriteLine("\n----------------------------------------------\n");
  
    Console.WriteLine("CMAZEY CALCULATOR: MULTIPLICATION [x]\n");
    if (basic)
    {
      Console.Write("? x ? = ? -> ");
      int mult1 = Convert.ToInt32(Console.ReadLine());
      Console.Write($"{mult1} x ? = ? -> ");
      int mult2 = Convert.ToInt32(Console.ReadLine());

      int multTotal = mult1 * mult2; // Multiply the number

      Console.WriteLine($"\n{mult1} x {mult2} = {multTotal}");
      Console.ReadLine();
    }
    else
    {
      var mult1 = AnsiConsole.Prompt(
        new TextPrompt<int>("[green]?[/] x ? = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      var mult2 = AnsiConsole.Prompt(
        new TextPrompt<int>($"[lightskyblue1]{mult1} x[/] [green]?[/] = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      int multTotal = mult1 * mult2;

      var multTable = new Table();
      multTable.AddColumn($"[lightskyblue1]{mult1} + {mult2} =[/] [green]{multTotal}[/]");
      AnsiConsole.Write(multTable);
      Console.ReadLine();
    }
    Console.WriteLine("----------------------------------------------\n");
  }

  // DIVISION / DIVIDE
  else if (input == "division" || input == "/")
  {
    Console.WriteLine("\n----------------------------------------------\n");

    Console.WriteLine("CMAZEY CALCULATOR: DIVISION [/]");
    if (basic)
    {
      Console.Write("\n? / ? = ? -> ");
      double div1 = Convert.ToDouble(Console.ReadLine());
      Console.Write($"{div1} / ? = ? -> ");
      double div2 = Convert.ToDouble(Console.ReadLine());

      double divTotal = div1 / div2; // Divides the numbers

      Console.WriteLine($"{div1} / {div2} = {divTotal}");
      Console.ReadLine();
    }
    else
    {
      var div1 = AnsiConsole.Prompt(
        new TextPrompt<int>("[green]?[/] / ? = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      var div2 = AnsiConsole.Prompt(
        new TextPrompt<int>($"[lightskyblue1]{div1} /[/] [green]?[/] = ? -> ")
        .PromptStyle("blue")
        .ValidationErrorMessage("[red] That's not a valid number[/]")
      );

      int divTotal = div1 / div2;

      var divTable = new Table();
      divTable.AddColumn($"[lightskyblue1]{div1} + {div2} =[/] [green]{divTotal}[/]");
      AnsiConsole.Write(divTable);
      Console.ReadLine();
    }
    Console.WriteLine("----------------------------------------------\n");
  }

  //CHANGECALCULATOR // CHANGE
  else if (input == "change")
  {
    Console.WriteLine("\n----------------------------------------------\n");
    Console.WriteLine("CMAZEY CALCULATOR: CHANGE CALCULATOR [₵]");

    if (basic)
    {
      Console.Write("\nEnter change to give back (1c - 99c): ");
      int change = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Change Amount: {change}₵");

      int Quarters = change / 25; // Divides the change amount by 25.
      int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
      int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
      int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;

      Console.WriteLine($"\nQuarters: {Quarters}");
      Console.WriteLine($"Dimes: {Dimes}");
      Console.WriteLine($"Nickels: {Nickels}");
      Console.WriteLine($"Pennies: {Pennies}");
    }
    else
    {
      var change = AnsiConsole.Prompt(
        new TextPrompt<int>("Enter [yellow]Change Amount[/]: ")
        .ValidationErrorMessage("[red]Not a valid number/Cannot be a decibel number[/]")
        .PromptStyle("yellow")
      );

      AnsiConsole.MarkupLine($"\n[bold yellow]CHANGE AMOUNT[/]: {change}");

      int Quarters = change / 25; // Divides the change amount by 25.
      int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
      int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
      int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;

      var changeAmountResult = new Table();
      AnsiConsole.Live(changeAmountResult)
      .Start(ctx =>
      {
        changeAmountResult.AddColumn("[yellow]Change[/]");
        ctx.Refresh();
        Thread.Sleep(100);

        changeAmountResult.AddColumn(new TableColumn ("[yellow]Amount[/]"));
        ctx.Refresh();
        Thread.Sleep(100);

        changeAmountResult.AddRow("Quarters", $"{Quarters}");
        ctx.Refresh();
        Thread.Sleep(100);

        changeAmountResult.AddRow("Dimes", $"{Dimes}");
        ctx.Refresh();
        Thread.Sleep(100);

        changeAmountResult.AddRow("Nickels", $"{Nickels}");
        ctx.Refresh();
        Thread.Sleep(100);

        changeAmountResult.AddRow("Pennies", $"{Pennies}");
        ctx.Refresh();
        Thread.Sleep(100);
      });
    }
    Console.ReadLine();
  }
  //Clear
  else if (input == "clear" || input == "cls")
  {
    Console.Clear();
    Console.WriteLine("\nType /help to show all the available commands!\n");
  }
  //LINE SLOPE CALCULATOR
  else if (input == "lineslope")
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
  
  //Version
  else if (input == "version")
  {
    Console.WriteLine($"Version: {version}");
  }

  //HeightToInches
  else if (input == "htoi")
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
  else if (input == "8ball" || input == "eightball")
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
  else if (input == "lottery")
  {
    Console.WriteLine("\n----------------------------------------------\n"); 
      
    Random random = new();
    int winningNumber = random.Next(0, 100);
    int winningDigitOne = winningNumber / 10;
    int winningDigitTwo = winningNumber % 10;

    if (basic)
    {
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
    
    else
    {
      var lotInput = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Select your [green]lottery number[/]:")
        .PageSize(100)
        .AddChoices(new[] {
          "0", "1", "2", "3", "4", "5",
          "6", "7", "8", "9", "10", "11",
          "12", "13", "14", "15", "16", "17",
          "18", "19", "20", "21", "22", "23",
          "24", "25", "26", "27", "28", "29",
          "30", "31", "32", "33", "34", "35",
          "36", "37", "38", "39", "40", "41",
          "42", "43", "44", "45", "46", "47", "48",
          "49", "50", "51", "52", "53", "54", "55", "56",
          "57", "58", "59", "60", "61", "62", "63", "64",
          "65", "66", "67", "68", "69", "70", "71",
          "72", "73", "74", "75", "76", "77", "78",
          "70", "80", "81", "82", "83", "84", "85",
          "86", "87", "88", "89", "90", "91", "92", "93",
          "94", "95", "96", "97", "98", "99", "100"
        }));

      int entryNumber = Convert.ToInt32(lotInput);
      int entryDigitOne = entryNumber / 10;
      int entryDigitTwo = entryNumber % 10;

      AnsiConsole.Markup($"[green]Lottery Number Selected:[/] {lotInput}\n");
      Thread.Sleep(1000);
      Console.WriteLine($"And the winning number is....... {winningNumber}\n");

      if (entryNumber == winningNumber)
      {
        AnsiConsole.Markup("[bright green]Exact match[/]! You win the grand prize of $[green]100,000![/]\n");
      }
      else if (winningDigitOne == entryDigitTwo && winningDigitTwo == entryDigitOne)
      {
        AnsiConsole.Markup("You digits match, but out of order! You win $[green]3,000![/]\n");
      }
      else
      {
        AnsiConsole.Markup("[red]No match[/]. Better luck next time!\n");
      }

      Console.ReadLine();

    }

    Console.WriteLine("----------------------------------------------\n"); 
  }

  else if (input == "calendar")
  {
    if (basic)
    {
      Console.WriteLine("This command doesn't work in BASIC mode, sorry bud.\n");
    }

    else
    {
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        int day = DateTime.Now.Day;

        var calendar = new Calendar(year,month);
        calendar.HeaderStyle(Style.Parse("yellow"));
        calendar.AddCalendarEvent(year,month,day);
        Console.WriteLine();
        AnsiConsole.Write(calendar);
        Console.WriteLine();
    }
  }

  // MORE COMING SOON

  else if (input == "exit")
  {
    Console.WriteLine("Exiting...\n\n");
    cmazeyCalculator = false;
  }

  // Basic Mode
  else if (input == "basic")
  {
    if (basic)
    {
      Console.WriteLine("Basic is enabled\n");
    }
    
    else
    {
      Console.Write("Are you sure you want to enable Basic Mode, you cannot reverse the change? (y/n) -> ");
      string inputBasic = Console.ReadLine();

      if (inputBasic == "y")
      {
        basic = true;
      }
      else
      {
        Console.WriteLine("Prompt Canceled...\n");
      }
    }
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

