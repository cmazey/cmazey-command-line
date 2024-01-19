using System.Runtime.InteropServices;
using Spectre.Console;
bool basic = false;
string version = "ALPHA v6.12.5";

Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("Choose an option below:");
Console.WriteLine("- basic");
Console.WriteLine("- normal");
Console.Write("-> ");
string optionInput = Console.ReadLine();

if (optionInput == "basic")
{
    Console.Clear();
    basic = true;
}
else if (optionInput == "normal")
{
    Console.Clear();
    basic = false;
}
else
{
    Console.WriteLine("Input invalid, defaulting to normal...");
    Thread.Sleep(2000);
    Console.Clear();
    basic = false;
}

if (basic)
{
    Console.WriteLine("--- CMAZEY CALCULATOR ---");
    Console.WriteLine($"Version: {version}");
}
else
{
    AnsiConsole.Write(
    new FigletText("CMAZEY CALCULATOR")
    .LeftJustified()
    .Color(Color.Red));
    AnsiConsole.Markup($"[yellow]{version}[/]");
}

if (basic)
{
    Console.WriteLine("\nType /help to show all the available commands!");
}
else
{
    AnsiConsole.MarkupLine("\n[white]Type [green1]/help[/] to show all the available commands![/]");
}
bool cmazeyCalculator = true;
while (cmazeyCalculator)
{
    if (basic)
    {
        Console.Write("-> ");
    }
    else
    {
        AnsiConsole.Write(new Markup("[gold1]->[/] "));
    }
    string input = Console.ReadLine().ToLower();

    // ADDITION
    if (input == "addition" || input == "+")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: ADDITION [+]");

        if (basic)
        {
            Console.Write("\n[?] + ? = -> ");
            double add1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(0, Console.CursorTop -1);
            Console.Write($"\r{add1} + [?] = ? -> ");
            double add2 = Convert.ToDouble(Console.ReadLine());

            double addTotal = add1 + add2; // Adds the numbers

            Console.SetCursorPosition(0, Console.CursorTop -1);
            Console.WriteLine($"\r{add1} + {add2} = {addTotal}            ");
            Console.ReadKey();
        }
        else
        {
            var add1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]?[/] + ? = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var add2 = AnsiConsole.Prompt(
              new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double addTotal = add1 + add2;

            var addTable = new Table();
            addTable.AddColumn($"[lightskyblue1]{add1} + {add2} =[/] [yellow]{addTotal}[/]");
            AnsiConsole.Write(addTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // SUBTRACTION
    else if (input == "subtraction" || input == "-")
    {
        Console.WriteLine("\n----------------------------------------------\n");

        Console.WriteLine("CMAZEY CALCULATOR: SUBTRACTION [-]");
        if (basic)
        {
            Console.Write("\n[?] - ? = ? -> ");
            double sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{sub1} - [?] = ? -> ");
            double sub2 = Convert.ToDouble(Console.ReadLine());
            double subTotal = sub1 - sub2; // Subtracts the numbers

            Console.WriteLine($"\n{sub1} - {sub2} = {subTotal}");
            Console.ReadKey();
        }

        else
        {
            var sub1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]?[/] - ? = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var sub2 = AnsiConsole.Prompt(
              new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double subTotal = sub1 - sub2;

            var subTable = new Table();
            subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} =[/] [yellow]{subTotal}[/]");
            AnsiConsole.Write(subTable);
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
        Console.WriteLine("- Bigmul-Big");
        Console.WriteLine("- Square Root");
        Console.WriteLine("- Truncate");
        Console.WriteLine("- PI");
        Console.WriteLine("- E4");
        Console.WriteLine("- Math.Um");
        Console.WriteLine("- Custom");
        Console.WriteLine("- Exit\n");
    }
    // MULTIPLICATION
    else if (input == "multiplication" || input == "x")
    {

        Console.WriteLine("\n----------------------------------------------\n");

        Console.WriteLine("CMAZEY CALCULATOR: MULTIPLICATION [x]\n");
        if (basic)
        {
            Console.Write("[?] x ? = ? -> ");
            double mult1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{mult1} x [?] = ? -> ");
            double mult2 = Convert.ToDouble(Console.ReadLine());

            double multTotal = mult1 * mult2; // Multiply the number

            Console.WriteLine($"\n{mult1} x {mult2} = {multTotal}");
            Console.ReadKey();
        }
        else
        {
            var mult1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]?[/] x ? = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var mult2 = AnsiConsole.Prompt(
              new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [yellow]?[/] = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double multTotal = mult1 * mult2;
            var multTable = new Table();
            multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} =[/] [green]{multTotal}[/]");
            AnsiConsole.Write(multTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // DIVISION / DIVIDE
    else if (input == "division" || input == "/")
    {
        Console.WriteLine("\n----------------------------------------------\n");

        Console.WriteLine("CMAZEY CALCULATOR: DIVISION [/]\n");
        if (basic)
        {
            Console.Write("[?] / ? = ? -> ");
            double div1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{div1} / [?] = ? -> ");
            double div2 = Convert.ToDouble(Console.ReadLine());

            double divTotal = div1 / div2; // Divides the numbers

            Console.WriteLine($"\n{div1} / {div2} = {divTotal}");
        }
        else
        {
            var div1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]?[/] / ? = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var div2 = AnsiConsole.Prompt(
              new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [yellow]?[/] = ? -> ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double divTotal = div1 / div2;

            var divTable = new Table();
            divTable.AddColumn($"[lightskyblue1]{div1} / {div2} =[/] [green]{divTotal}[/]");
            AnsiConsole.Write(divTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
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

                changeAmountResult.AddColumn(new TableColumn("[yellow]Amount[/]"));
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
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //Clear
    else if (input == "clear" || input == "cls")
    {
        Console.Clear();
        if (basic)
        {
            Console.WriteLine("\nType /help to show all the available commands!");
        }
        else
        {
            AnsiConsole.MarkupLine("\n[white]Type [green1]/help[/] to show all the available commands![/]");
        }
    }
    //LINE SLOPE CALCULATOR
    else if (input == "lineslope")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: Line Slope Calculator\n");

        if (basic)
        {
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
            Console.ReadKey();
        }

        else
        {
            var x1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[yellow]x1[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var y1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]y1[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var x2 = AnsiConsole.Prompt(
              new TextPrompt<double>("[yellow]x2[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var y2 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]y2[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double slope = (y2 - y1) / (x2 - x1);

            var linSlpeTable = new Table();
            linSlpeTable.AddColumn($"The slope of the through points ([yellow]{x1}, {y1}[/]) and ([yellow]{x2}, {y2}[/]) is [blue]{slope}[/].");
            AnsiConsole.Write(linSlpeTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //VERSION
    else if (input == "version")
    {
        Console.WriteLine($"Version: {version}");
    }
    //HeightToInches
    else if (input == "htoi" || input == "itoh")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: INCHES TO HEIGHT\n");
        if (basic)
        {
            Console.Write("Enter your height in inches: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int num = 12;
            int foot = height / num; // Dividing the height in inches by 12
            int inches = height % num;

            Console.WriteLine($"\nYou are {foot}ft, {inches}in.");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------\n");
        }
        else
        {
            var height = AnsiConsole.Prompt(
              new TextPrompt<int>("Enter you [lightskyblue1]height[/] in [yellow]inches[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );
            int num = 12;
            int foot = height / num;
            int inches = height % num;

            var heightTable = new Table();
            heightTable.AddColumn($"[yellow]{foot}[/]ft, [yellow]{inches}[/]in.");
            AnsiConsole.Write(heightTable);
            Console.WriteLine("\n----------------------------------------------\n");
        }
    }
    // 8 BALL
    else if (input == "8ball" || input == "eightball")
    {

        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine("--- Magic 8 Ball ---\n");
            Console.WriteLine("What is your question?");
            Console.Write("-> ");
            string EightBallInput = Console.ReadLine();
        }
        else
        {
            AnsiConsole.MarkupLine("[white]--- Magic [blue]8[/] Ball ---[/]");
            var eightBallInput = AnsiConsole.Ask<string>("What is your [green]question[/]? -> ");
        }
        Random random = new();

        int eightBall = Convert.ToInt32(random.Next(1, 7));
        if (basic)
        {
            if (eightBall == 1)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("It is certain!");
            }
            else if (eightBall == 2)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("Without a doubt!");
            }
            else if (eightBall == 3)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("Ask again later.");
            }
            else if (eightBall == 4)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("Cannot predict now.");
            }
            else if (eightBall == 5)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("Don't count on it.");
            }
            else if (eightBall == 6)
            {
                Console.Write("\nMagic 8-Ball: ");
                Console.WriteLine("Outlook not so good.");
            }
        }
        else
        {
            if (eightBall == 1)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[green1]It is certain![/]");
            }
            else if (eightBall == 2)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[green1]Without a doubt![/]");
            }
            else if (eightBall == 3)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[white]Ask again later.[/]");
            }
            else if (eightBall == 4)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[white]Cannot predict now.[/]");
            }
            else if (eightBall == 5)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[red]Don't count on it.[/]");
            }
            else if (eightBall == 6)
            {
                AnsiConsole.Markup("\n[white bold]Magic [blue]8[/]-Ball[/]: ");
                AnsiConsole.MarkupLine("[red]Outlook not so good.[/]");
            }
        }
        Console.ReadKey();
        Console.WriteLine("\n----------------------------------------------\n");
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

            Console.ReadKey();
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
                AnsiConsole.Markup("[green1]Exact match[/]! You win the grand prize of $[green]100,000![/]\n");
            }
            else if (winningDigitOne == entryDigitTwo && winningDigitTwo == entryDigitOne)
            {
                AnsiConsole.Markup("You digits match, but out of order! You win $[green]3,000![/]\n");
            }
            else
            {
                AnsiConsole.Markup("[red]No match[/]. Better luck next time!\n");
            }
            Console.ReadKey();
        }
        Console.WriteLine("----------------------------------------------\n");
    }
    // CALENDAR
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

            var calendar = new Calendar(year, month);
            calendar.HeaderStyle(Style.Parse("yellow"));
            calendar.AddCalendarEvent(year, month, day);
            Console.WriteLine();
            AnsiConsole.Write(calendar);
            Console.WriteLine();
        }
    }
    // Truncate
    else if (input == "truncate")
    {
        Console.WriteLine("----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: Truncate [.]\n");
        if (basic)
        {
            Console.Write("Enter a value: ");
            double trunNum = Convert.ToDouble(Console.ReadLine());

            double trunTotal = Math.Truncate(trunNum);
            double roundTotal = Math.Round(trunNum);

            Console.WriteLine($"\nTruncated value is {trunTotal}");
            Console.WriteLine($"Rounded-Off value is {roundTotal}");
        }
        else
        {
            var trunNum = AnsiConsole.Prompt(
              new TextPrompt<double>("Enter a [yellow]value[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double trunTotal = Math.Truncate(trunNum);
            double roundTotal = Math.Round(trunNum);

            var trunTable = new Table();
            trunTable.AddColumn($"[yellow]Truncated[/] value: [lightskyblue1]{trunTotal}[/] [black]//[/] [yellow]Rounded-Off[/] value: [lightskyblue1]{roundTotal}[/]");
            AnsiConsole.Write(trunTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // Square Root
    else if (input == "square" || input == "square root")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: SQUARE ROOT [√]\n");
        if (basic)
        {
            Console.Write("Enter a number: ");
            double squareNum = Convert.ToDouble(Console.ReadLine());
            double squareTotal = Math.Sqrt(squareNum);
            Console.WriteLine($"\nSquare root: {squareTotal}");
        }
        else
        {
            var squareNum = AnsiConsole.Prompt(
              new TextPrompt<double>("Enter a [yellow]number[/] or [yellow]value[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );
            double squareTotal = Math.Sqrt(squareNum);

            var squareTable = new Table();
            squareTable.AddColumn($"[yellow]Square Root[/]: [lightskyblue1]{squareTotal}[/]");
            AnsiConsole.Write(squareTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // BigMul Multiplication
    else if (input == "bigmul multiplication" || input == "bigmul-big")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Console.WriteLine("CMAZEY CALCULATOR: BigMul-Big Multiplication [x]\n");

        if (basic)
        {
            Console.Write("Enter a number: ");
            int bigMult1 = Convert.ToInt32(Console.ReadLine());
            double bigMultTotal = Math.BigMul(bigMult1, bigMult1);
            Console.WriteLine($"{bigMult1} x {bigMult1} == {bigMultTotal}");
        }
        else
        {
            var bigMult1 = AnsiConsole.Prompt(
              new TextPrompt<int>("Enter a [yellow]number[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/] // [red]Number too high for[/] [yellow]int[/] [red]value[/]")
            );
            double bigMultTotal = Math.BigMul(bigMult1, bigMult1);

            var bigMultTable = new Table();
            bigMultTable.AddColumn($"[yellow dim]{bigMult1}[/] [red]x[/] [yellow dim]{bigMult1}[/] = [chartreuse1]{bigMultTotal}[/]");
            AnsiConsole.Write(bigMultTable);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // pi
    else if (input == "pi")
    {
        if (basic)
        {
            Console.WriteLine("\nThe value of PI is " + Math.PI);
        }
        else
        {
            Console.WriteLine();
            double pi = Math.PI;
            var piTable = new Table();
            piTable.Title("[dim]PI[/]");
            piTable.AddColumn($"[yellow]{pi}[/]");
            AnsiConsole.Write(piTable);
            Console.WriteLine();
        }
    }
    //e4
    else if (input == "e4" || input == "efour")
    {
        if (basic)
        {
            Console.WriteLine("\nThe value of logarithmic base E is " + Math.E);
        }
        else
        {
            Console.WriteLine();
            double eFour = Math.E;
            var e4Table = new Table();
            e4Table.Title("[dim]e4[/]");
            e4Table.AddColumn($"[yellow]{eFour}[/]");
            AnsiConsole.Write(e4Table);
            Console.WriteLine();
        }
    }
    //math.um
    else if (input == "math.um")
    {
        if (basic)
        {
            Console.WriteLine("This command doesn't work in BASIC mode, sorry bro.\n");
        }
        else
        {
            Console.WriteLine("\n----------------------------------------------\n");

            AnsiConsole.MarkupLine("[yellow]CMAZEY CALCULATOR:[/] [white]Math.um [[CC]][/]\n");

            var mathNum = AnsiConsole.Prompt(
                new TextPrompt<double>("Enter a [yellow]number[/] or [yellow]value[/]: ")
                .PromptStyle("blue")
                .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            var mathPrompt = AnsiConsole.Prompt(
              new SelectionPrompt<string>()
              .Title($"What equation do you want to use for [yellow]{mathNum}[/]?")
              .PageSize(7)
              .MoreChoicesText("[grey]Use the arrow keys to move up or down, press <ENTER> to select[/]")
              .AddChoices(new[] {
        "Math.Sqrt", "Math.Abs", "Math.Round", "Math.Ceiling", "Math.Floor"
              }));

            if (mathPrompt == "Math.Sqrt")
            {
                double mathAns = Math.Sqrt(mathNum);
                AnsiConsole.MarkupLine("[green]PROMPT SELECTED:[/] [yellow dim]Math.Sqrt[/]");
                var mathTable = new Table();
                mathTable.AddColumn($"[yellow]{mathAns}[/]");
                AnsiConsole.Write(mathTable);
            }
            else if (mathPrompt == "Math.Abs")
            {
                double mathAns = Math.Abs(mathNum);
                AnsiConsole.MarkupLine("[green]PROMPT SELECTED:[/] [yellow dim]Math.Abs[/]");
                var mathTable = new Table();
                mathTable.AddColumn($"[yellow]{mathAns}[/]");
                AnsiConsole.Write(mathTable);
            }
            else if (mathPrompt == "Math.Round")
            {
                double mathAns = Math.Round(mathNum);
                AnsiConsole.MarkupLine("[green]PROMPT SELECTED:[/] [yellow dim]Math.Round[/]");
                var mathTable = new Table();
                mathTable.AddColumn($"[yellow]{mathAns}[/]");
                AnsiConsole.Write(mathTable);
            }
            else if (mathPrompt == "Math.Ceiling")
            {
                double mathAns = Math.Ceiling(mathNum);
                AnsiConsole.MarkupLine("[green]PROMPT SELECTED:[/] [yellow dim]Math.Ceiling[/]");
                var mathTable = new Table();
                mathTable.AddColumn($"[yellow]{mathAns}[/]");
                AnsiConsole.Write(mathTable);
            }
            else if (mathPrompt == "Math.Floor")
            {
                double mathAns = Math.Floor(mathNum);
                AnsiConsole.MarkupLine("[green]PROMPT SELECTED:[/] [yellow dim]Math.Floor[/]");
                var mathTable = new Table();
                mathTable.AddColumn($"[yellow]{mathAns}[/]");
                AnsiConsole.Write(mathTable);
            }
            Console.WriteLine("\n----------------------------------------------\n");
        }
    }

    //custom
    else if (input == "custom")
    {
        if (basic)
        {
            Console.WriteLine("This command currently doesn't work in BASIC mode, but its planned though. Check github repo for latest update...");
        }
        else
        {
            Console.WriteLine("\n----------------------------------------------\n");
            AnsiConsole.MarkupLine("[yellow]CMAZEY CALCULATOR:[/] [white]Custom Equations [[+-x/]][/]");
            AnsiConsole.MarkupLine("[blink]Please hold...[/]\n");
            Thread.Sleep(3000);

            var customSelct = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("[white]What equation would you like to do?[/] [green](9 MAX)[/]")
                .PageSize(50)
                .AddChoices(new[] {
                    "++ <3>", "+++ <4>", "++++ <5>", "+++++ <6>", "++++++ <7>", "+++++++ <8>", "++++++++ <9>", "+++++++++ <10>",
                    "-- <3>", "--- <4>", "---- <5>", "----- <6>", "------ <7>", "------- <8>", "-------- <9>", "--------- <10>",
                    "** <3>", "*** <4>", "**** <5>", "***** <6>", "****** <7>", "******* <8>", "******** <9>", "********* <10>",
                    "// <3>",
                    "Cancel",
                }));
            
            if (customSelct == "++ <3>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "+++ <4>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "++++ <5>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? = ? + ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? = ? + ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "+++++ <6>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5 + add6;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "++++++ <7>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5 + add6 + add7;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "+++++++ <8>")

            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green]?[/] + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "++++++++ <9>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green][bold]?[/] [dim]+ ? + ? + ? + ? + ? + ? + ? = ? + ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green][bold]?[/] [dim]+ ? + ? + ? + ? + ? + ? = ? + ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green][bold]?[/] [dim]+ ? + ? + ? + ? + ? + ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green][bold]?[/] [dim]+ ? + ? + ? + ? + ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green][bold]?[/] [dim]+ ? + ? + ? + ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} +[/] [green][bold]?[/] [dim]+ ? + ? + ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} +[/] [green][bold]?[/] [dim]+ ? + ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} +[/] [green][bold]?[/] [dim]+ ? = ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} +[/] [green][bold]?[/] [dim]= ?[/][/] -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8 + add9;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} + {add9} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "+++++++++ <10>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? + ? + ? + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] + ? + ? + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} +[/] [green]?[/] + ? + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var add4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} +[/] [green]?[/] + ? + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                var add5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} +[/] [green]?[/] + ? + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} +[/] [green]?[/] + ? + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} +[/] [green]?[/] + ? + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} +[/] [green]?[/] + ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} +[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));
                
                var add10 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} + {add9} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red]That's not a valid number[/]"));

                    double addTotal = add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8 + add9 + add10;

                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{add1} + {add2} + {add3} + {add4} + {add5} + {add6} + {add7} + {add8} + {add9} + {add10} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
            }
            else if (customSelct == "-- <3>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                    double subTotal = sub1 - sub2 - sub3;

                    var subTable = new Table();
                    subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} =[/] [yellow]{subTotal}[/]");
                    AnsiConsole.Write(subTable);
            }
            else if (customSelct == "--- <4>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "---- <5>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "----- <6>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5 - sub6;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "------ <7>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5 - sub6 - sub7;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "------- <8>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5 - sub6 - sub7 - sub8;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "-------- <9>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5 - sub6 - sub7 - sub8 - sub9;

                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} - {sub9} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "--------- <10>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? - ? - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} -[/] [green]?[/] - ? - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} -[/] [green]?[/] - ? - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} -[/] [green]?[/] - ? - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} -[/] [green]?[/] - ? - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} -[/] [green]?[/] - ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var sub9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} -[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub10 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} - {sub9} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double subTotal = sub1 - sub2 - sub3 - sub4 - sub5 - sub6 - sub7 - sub8 - sub9 - sub10;
                
                var subTable = new Table();
                        subTable.AddColumn($"[lightskyblue1]{sub1} - {sub2} - {sub3} - {sub4} - {sub5} - {sub6} - {sub7} - {sub8} - {sub9} - {sub10} =[/] [yellow]{subTotal}[/]");
                        AnsiConsole.Write(subTable);
            }
            else if (customSelct == "** <3>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "*** <4>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "**** <5>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "***** <6>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5 * mult6;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "****** <7>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "******* <8>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "******** <9>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8 * mult9;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} x {mult9} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "********* <10>")
            {
                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] x ? x ? x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult4 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x[/] [green]?[/] x ? x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x[/] [green]?[/] x ? x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x[/] [green]?[/] x ? x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x[/] [green]?[/] x ? x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x[/] [green]?[/] x ? x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} x[/] [green]?[/] x ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));
                
                var mult10 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} x {mult9} x[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double multTotal = mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8 * mult9 * mult10;

                var multTable = new Table();
                        multTable.AddColumn($"[lightskyblue1]{mult1} x {mult2} x {mult3} x {mult4} x {mult5} x {mult6} x {mult7} x {mult8} x {mult9} x {mult10} =[/] [yellow]{multTotal}[/]");
                        AnsiConsole.Write(multTable);
            }
            else if (customSelct == "Cancel")
            {
                Console.WriteLine("Prompt Canceled");
            }
        }
        Console.WriteLine("\n----------------------------------------------\n");
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
Console.ReadKey();
Console.WriteLine();

