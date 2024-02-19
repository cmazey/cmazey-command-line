using System.Reflection;
using NAudio.Wave;
using Spectre.Console;
string version = "v1.1.5 (PRE v1.49)"; // VERSION

// -------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------
// ---------------------------Cmazey Calculator is all written by Colton Mazey '25------------------------------------
// -------------------------All Sound Effects are from Pixabay (https://pixabay.com/)---------------------------------
// -------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------

bool basic = false; // True if user give consent to use basic rather than normal.
bool crew = false; // Only certain crew/cast members can have access to there.
bool nameChange = false;
bool audioAccess = true; // Only false if the start audio cannot be played.
bool basicAns = true; // Used for while loops while checking if the answer is a number, and it will handle the exception if it's not.
bool logAccess = false; // Only True if User give consents for logs and/or log file founded if the file was founded in Documents Folder
bool autoNameCheck = false;
string name = "[gray]Guest[/]"; // Full name
string fname = ""; // First name only
string name1 = "Guest"; // Full name for basic
string autoNameInput = "";
int lotWin = 0;
int lotLoss = 0;
int i = 0;
double inputNum = 0;
double inputNum2 = 0;
double x1 = 0;
double y1 = 0;
double x2 = 0;
double y2 = 0;
string ewqq = "a";
string oeda = "b";
string cdow = "c";
string asdc = "d";
string smcd = "e";
string dokd = "h";
string ckew = "i";
string ckwqo = "O";
string ckoww = "j";
string okdq = "k";
string ciako = "l";
string c9oqa = "D";
string cakoe = "n";
string ckiw = "G";
string cidqq = "A";
string kewd = "o";
string ciwq = "X";
string iciqa = "H";
string jiweq = "S";
string dkoq = "r";
string caokw = "s";
string fokcao = "t";
string rifkoa = "m";
string eiiwq = "u";
string coqko = "B";
string ckooe = "v";
string skmkw = "w";
string okcokd = "x";
string lijwq = "y";
string kwdjiq = "K";
string ansPrint = ""; // string used to append into a file
string titleAppend = "";
string quarterAppend = "";
string dimesAppend = "";
string nickelAppend = "";
string pennieAppend = "";
string changeAppend = "";
int year = DateTime.Now.Year; // Fetch the current year
int month = DateTime.Now.Month; // Fetch the current month
int day = DateTime.Now.Day; // Fetch the current day
int minute = DateTime.Now.Minute; // Fetch the current minute
int hour = DateTime.Now.Hour; // Fetch the current hour
int second = DateTime.Now.Second; // Fetch the current second
int millisecond = DateTime.Now.Millisecond; // Fetch the current millisecond

string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Fetch the Document directory
string curntDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
// string shellPath = Environment.GetEnvironmentVariable("HOME");

Console.WriteLine("Loading Appli: CMAZEY CALCULATOR");
Thread.Sleep(3000);

// Looks for 'CCLResult.txt' in your Documents Folder
if (File.Exists($"{path}\\CCLResult.txt"))
{
    Console.WriteLine($"RESULT LOCATED: '{path}\\CCLResult.txt'");
    logAccess = true;
    Thread.Sleep(2000);
}

// if (File.Exists($"{shellPath}/CCLResult.txt"))
// {
//     Console.WriteLine($"SHELL RESULT LOCATED: '{path}/CCLResult.txt'");
//     logAccess = true;
//     Thread.Sleep(2000);
// }

Console.Clear();

// Startup Menu (Choose beteeen basic or normal and set a name(use 'name -a' for autocorrect name if in database))
while (true)
{
    Console.WriteLine("Choose an option below:");
    Console.WriteLine("- basic");
    Console.WriteLine("- normal");
    Console.WriteLine("- name");
    Console.Write("-\\> ");
    string optionInput = Console.ReadLine();

    if (optionInput == "basic")
    {
        Console.Clear();
        basic = true;
        break;
    }
    else if (optionInput == "normal")
    {
        Console.Clear();
        basic = false;
        break;
    }
    else if (optionInput == "name")
    {
        Console.Write("Enter a name: ");
        string nameInput = Console.ReadLine();
        name = $"[white]{nameInput}[/]";
        name1 = nameInput;
        fname = nameInput;
        Console.WriteLine("Name Changed Confirmed!");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (optionInput == "name -auto" || optionInput == "name -a")
    {
        Console.Write("Enter a name: ");
        string nameInput = Console.ReadLine().ToLower();
        autoNameInput = nameInput;
        Console.WriteLine("Name Changed Confirmed! USR CONFIRMED: autocorrect");
        autoNameCheck = true;
        Thread.Sleep(1000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Input invalid, defaulting to normal...");
        Thread.Sleep(2000);
        Console.Clear();
        basic = false;
        break;
    }
}

// If user type in 'name -auto'. It will check, and auto correct the name if founded in database
if (autoNameCheck)
{
    if (autoNameInput == "colton" || autoNameInput == "colton m" || autoNameInput == "colton mazey")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Colton Mazey");
        name = "[darkgoldenrod]Colton Mazey[/]";
        name1 = "Colton M";
        fname = "Colton";
    }
    else if (autoNameInput == $"{ewqq}{cakoe}{asdc}{lijwq}" || autoNameInput == "andy s" || autoNameInput == "andy scott")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Andy Scott");
        name = "[darkgoldenrod]Andy Scott[/]";
        name1 = "Andy S";
        fname = "Andy";
    }
    else if (autoNameInput == $"{cakoe}{kewd}{ciako}{ewqq}{cakoe}" || autoNameInput == "nolan m" || autoNameInput == "nolan meyer")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Nolan Meyer");
        name = "[darkred]Nolan Meyer[/]";
        name1 = "Nolan M";
        fname = "Nolan";
    }
    else if (autoNameInput == $"{oeda}randon" || autoNameInput == $"{oeda}randon r" || autoNameInput == $"{oeda}randon reed")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Brandon Reed");
        name = "[purple]Brandon Reed[/]";
        name1 = "Brandon R";
        fname = "Brandon";
        crew = true;
    }
    else if (autoNameInput == $"{oeda}raeden" || autoNameInput == $"{oeda}raeden b" || autoNameInput == $"{oeda}raeden barker")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Braeden Barker");
        name = "[blue]Braeden Barker[/]";
        name1 = "Braeden B";
        fname = "Braeden";
        crew = true;

    }
    else if (autoNameInput == $"{kewd}{skmkw}{smcd}{cakoe}" || autoNameInput == "owen k" || autoNameInput == $"owen k{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: {ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}");
        name = $"[darkgoldenrod]{ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}[/]";
        name1 = $"{ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}";
        fname = $"{ckwqo}{skmkw}{smcd}{cakoe}";
    }
    else if (autoNameInput == $"{dokd}{smcd}{ciako}{smcd}{cakoe}" || autoNameInput == $"h{smcd}le{cakoe} g" || autoNameInput == $"h{smcd}le{cakoe} ge{dkoq}{dkoq}i{fokcao}y")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: {dokd}{smcd}{ciako}{smcd}{cakoe} {ckiw}{smcd}{dkoq}{dkoq}{ckew}{fokcao}{lijwq}");
        name = $"[lightpink1]{iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}{smcd}{dkoq}{dkoq}{ckew}{fokcao}{lijwq}[/]";
        name1 = $"{iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}";
        fname = $"{iciqa}{smcd}{ciako}{smcd}{cakoe}";
        crew = true;
    }
    else if (autoNameInput == $"{asdc}{ewqq}{ckooe}{ckew}{asdc}" || autoNameInput == "david b" || autoNameInput == $"david b{eiiwq}{dkoq}{okdq}{smcd}")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: {c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}{eiiwq}{dkoq}{okdq}{smcd}");
        name = $"[darkorange]{c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}{eiiwq}{dkoq}{okdq}{smcd}[/]";
        name1 = $"{c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}";
        fname = $"{c9oqa}{ewqq}{ckooe}{ckew}{asdc}";
    }
    else if (autoNameInput == $"{caokw}{smcd}{ewqq}{cakoe}" || autoNameInput == $"s{smcd}{ewqq}{cakoe} {c9oqa}")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: {caokw}{smcd}{ewqq}{cakoe} {c9oqa}");
        name = $"[darkgoldenrod]{jiweq}{smcd}{ewqq}{cakoe} {c9oqa}[/]";
        name1 = $"{jiweq}{smcd}{ewqq}{cakoe} {c9oqa}";
        fname = $"{jiweq}{smcd}{ewqq}{cakoe}";
    }
    else if (autoNameInput == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd}" || autoNameInput == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd} g" || autoNameInput == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd} gray")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: {okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}{dkoq}{ewqq}{lijwq}");
        name = $"[darkgoldenrod]{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}{dkoq}{ewqq}{lijwq}[/]";
        name1 = $"{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}";
        fname = $"{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd}";
    }
    else if (autoNameInput == $"{rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}")
    {
        Console.WriteLine($"NAME AUTOCORRECTED: Anthony {rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}");
        name = $"[darkgoldenrod]Anthony {rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}[/]";
        name1 = $"Anthony {rifkoa}";
        fname = $"Anthony";
    }
    else if (autoNameInput == "rusto")
    {
        Console.WriteLine("NAME AUTOCORRECTED: Rusto");
        name = "[yellow]Rusto[/]";
        name1 = "Rusto";
        fname = "Rusto";
    }
    else
    {
        name = $"[white]{autoNameInput}[/]";
        name1 = autoNameInput;
        fname = autoNameInput;
        Console.WriteLine($"NAME NOT FOUND IN DATA: DEFAULT: {name1}");
    }
    Thread.Sleep(2000);
    autoNameCheck = false;
    Console.Clear();
}

// Play the intro sound effect (With Exceptions)
try
{
    var reader = new Mp3FileReader("Resources\\startUp.mp3");
    var waveOut = new WaveOutEvent();
    waveOut.Init(reader);
    waveOut.Play();
    Thread.Sleep(1000);
}
catch
{
    try
    {
        Console.WriteLine("Linux Shell Detected. Sound Effect DISABLED");
        Thread.Sleep(3000);
        var reader = new Mp3FileReader("Resources//startUp.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(reader);
        waveOut.Play();
        Console.Clear();
    }
    catch
    {
        Console.WriteLine("There seems to be an issue playing the audio. Audio disabled");
        Thread.Sleep(3000);
        Console.Clear();
    }
    audioAccess = false;
}
// Title/Version
if (basic)
{
    // Basic Title 
    Console.WriteLine("--- CMAZEY CALCULATOR ---");
    Console.WriteLine($"Version: {version}");
}
else if (name1 == "Colton M" || name1 == "test")
{
    AnsiConsole.Write(
    new FigletText("CMAZEY CALCULATOR")
    .LeftJustified()
    .Color(Color.Blue));
    AnsiConsole.Markup($"[yellow]{version}[/]");
}
else
{
    // Used to display my title in a cool way (which was FigletText)
    AnsiConsole.Write(
    new FigletText("CMAZEY CALCULATOR")
    .LeftJustified()
    .Color(Color.Red));
    AnsiConsole.Markup($"[yellow]{version}[/]");
}
// Help Recommendation
if (basic)
{
    if (name1 == "Guest")
    {
        Console.WriteLine("Type /help to show all the available commands!");
    }
    else
    {
        if (hour >= 0 && hour < 12)
        {
            Console.Write($"\nGood Morning, {name1}! ");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.Write($"\nGood Afternoon, {name1}! ");
        }
        else
        {
            Console.Write($"\nGood Evening, {name1}! ");
        }
        Console.WriteLine("Type /help to show all the available commands!");
    }
}
else if (name1 == "Colton M" || name1 == "test")
{
    AnsiConsole.MarkupLine("\n[white]Type [blue1]/help[/] to show all the available commands![/]");
}
else
{
    if (name == "[gray]Guest[/]")
    {
        AnsiConsole.MarkupLine("\n[white]Type [green1]/help[/] to show all the available commands![/]");
    }
    else
    {
        if (hour >= 0 && hour < 12)
        {
            AnsiConsole.Markup($"\n[white]Good Morning, {name}![/] ");
        }
        else if (hour >= 12 && hour < 18)
        {
            AnsiConsole.Markup($"\n[white]Good Afternoon, {name}![/] ");
        }
        else
        {
            AnsiConsole.Markup($"\n[white]Good Evening, {name}![/] ");
        }
        AnsiConsole.MarkupLine("[white]Type [green1]/help[/] to show all the available commands![/]");
    }
}
// Main Content
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
        titleAppend = "CMAZEY CALCULATOR: ADDITION [+]";
        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: ADDITION [+] || {name1}");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double addTotal = inputNum + inputNum2;
                    Console.WriteLine($"{inputNum} + {inputNum2} = {addTotal}");
                    ansPrint = $"{inputNum} + {inputNum2} = {addTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    Console.Write($"\n{inputNum} + [?] = ? -> ");
                    string user_input = Console.ReadLine();
                    while (basicAns)
                    {
                        try
                        {
                            double checking = Convert.ToDouble(user_input);
                            if (checking > 1)
                            {
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid answer, please enter a number below:");
                            invalidAnsSoundEffect(audioAccess);
                            Console.Write("-> ");
                            user_input = Console.ReadLine();
                        }
                    }
                    double add2 = Convert.ToDouble(user_input);
                    double addTotal = inputNum + add2;
                    Console.WriteLine($"{inputNum} + {add2} = {addTotal}");
                    ansPrint = $"{inputNum} + {add2} = {addTotal}";
                    inputNum = 0;
                }
            }
            else
            {
                Console.Write("\n[?] + ? = -> ");
                string user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double add1 = Convert.ToDouble(user_input);
                Console.Write($"{add1} + [?] = ? -> ");
                user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double add2 = Convert.ToDouble(user_input);
                double addTotal = add1 + add2; // Adds the numbers
                Console.WriteLine($"\n{add1} + {add2} = {addTotal}");
                ansPrint = $"{add1} + {add2} = {addTotal}";
            }
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: ADDITION [[+]] ||[/] {name}");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double addTotal = inputNum + inputNum2;
                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{inputNum} + {inputNum2} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
                    ansPrint = $"{inputNum} + {inputNum2} = {addTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    var add2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{inputNum} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage($"[red] That's not a valid number[/]")
                    );
                    double addTotal = inputNum + add2;
                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{inputNum} + {add2} =[/] [yellow]{addTotal}[/]");
                    AnsiConsole.Write(addTable);
                    ansPrint = $"{inputNum} + {add2} = {addTotal}";
                    inputNum = 0;
                }
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
                ansPrint = $"{add1} + {add2} = {addTotal}";
            }
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
        
    }
    // SUBTRACTION
    else if (input == "subtraction" || input == "-")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: SUBTRACTION [-]";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: SUBTRACTION [-] || {name1}");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double subTotal = inputNum - inputNum2;
                    Console.WriteLine($"{inputNum} - {inputNum2} = {subTotal}");
                    ansPrint = $"{inputNum} - {inputNum2} = {subTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    Console.Write($"\n{inputNum} - [?] = ? -> ");
                    string user_input = Console.ReadLine();
                    while (basicAns)
                    {
                        try
                        {
                            double checking = Convert.ToDouble(user_input);
                            if (checking > 1)
                            {
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid answer, please enter a number below:");
                            invalidAnsSoundEffect(audioAccess);
                            Console.Write("-> ");
                            user_input = Console.ReadLine();
                        }
                    }
                    double sub2 = Convert.ToDouble(user_input);
                    double subTotal = inputNum - sub2;
                    Console.WriteLine($"{inputNum} - {sub2} = {subTotal}");
                    ansPrint = $"{inputNum} - {sub2} = {subTotal}";
                    inputNum = 0;
                }
            }
            else
            {
                Console.Write("\n[?] - ? = ? -> ");
                string user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double sub1 = Convert.ToDouble(user_input);
                Console.Write($"{sub1} - [?] = ? -> ");
                user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double sub2 = Convert.ToDouble(user_input);
                double subTotal = sub1 - sub2; // Subtracts the numbers
                Console.WriteLine($"\n{sub1} - {sub2} = {subTotal}");
                ansPrint = $"{sub1} - {sub2} = {subTotal}";
            }
        }
        else
        {
            AnsiConsole.MarkupLine($"CMAZEY CALCULATOR: SUBTRACTION [[-]] || {name}");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double subTotal = inputNum - inputNum2;
                    var addTable = new Table();
                    addTable.AddColumn($"[lightskyblue1]{inputNum} - {inputNum2} =[/] [yellow]{subTotal}[/]");
                    AnsiConsole.Write(addTable);
                    ansPrint = $"{inputNum} - {inputNum} = {subTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    var sub2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{inputNum} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]")
                    );
                    double subTotal = inputNum - sub2;
                    var subTable = new Table();
                    subTable.AddColumn($"[lightskyblue1]{inputNum} - {sub2} =[/] [yellow]{subTotal}[/]");
                    AnsiConsole.Write(subTable);
                    ansPrint = $"{inputNum} - {sub2} = {subTotal}";
                    inputNum = 0;
                }
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
                ansPrint = $"{sub1} - {sub2} = {subTotal}";
            }
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // HELP COMMAND
    else if (input == "/help" || input == "help")
    {
        Console.WriteLine("\n- Addition (+)");
        Console.WriteLine("- Subtraction (-)");
        Console.WriteLine("- Multiplication (x)");
        Console.WriteLine("- Division (/)");
        Console.WriteLine("- LineSlope (ls)");
        Console.WriteLine("- InchesToHeight (HToI\\IToH)");
        Console.WriteLine("- EightBall (8ball)");
        Console.WriteLine("- Lottery (lot)");
        Console.WriteLine("- LotteryResult (lotResult)");
        Console.WriteLine("- Change");
        Console.WriteLine("- Clear (cls)");
        Console.WriteLine("- ClearInt (clsint)");
        Console.WriteLine("- Version");
        Console.WriteLine("- Basic");
        Console.WriteLine("- Calendar");
        Console.WriteLine("- Bigmul-Big");
        Console.WriteLine("- Square Root (Square)");
        Console.WriteLine("- Truncate");
        Console.WriteLine("- PI");
        Console.WriteLine("- E4");
        Console.WriteLine("- Math.Um");
        Console.WriteLine("- Custom");
        Console.WriteLine("- BinaryToHexadecimal (BToH)");
        Console.WriteLine("- DecimalToBinary (DToB)");
        Console.WriteLine("- Name");
        if (crew)
        {
            Console.WriteLine("- Little Shop of Horrors (play)");
        }
        Console.WriteLine("- numcheck (int)");
        Console.WriteLine("- CurrentPath (CrntPath\\Dir)");
        Console.WriteLine("- Exit\n");
        Console.Beep();
    }
    // MULTIPLICATION
    else if (input == "multiplication" || input == "x" || input == "*")
    {
        titleAppend = "CMAZEY CALCULATOR: MULTIPLICATION [x]";
        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: MULTIPLICATION [x] || {name1}\n");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double multTotal = inputNum * inputNum2;
                    Console.WriteLine($"\n{inputNum} x {inputNum2} = {multTotal}");
                    ansPrint = $"{inputNum} x {inputNum2} = {multTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    Console.Write($"{inputNum} x [?] = ? -> ");
                    string user_input = Console.ReadLine();
                    while (basicAns)
                    {
                        try
                        {
                            double checking = Convert.ToDouble(user_input);
                            if (checking > 1)
                            {
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid answer, please enter a number below:");
                            invalidAnsSoundEffect(audioAccess);
                            Console.Write("-> ");
                            user_input = Console.ReadLine();
                        }
                    }
                    double mult2 = Convert.ToDouble(user_input);
                    double multTotal = inputNum * mult2;
                    Console.WriteLine($"\n{inputNum} x {mult2} = {multTotal}");
                    ansPrint = $"{inputNum} x {mult2} = {multTotal}";
                    inputNum = 0;
                }
            }
            else
            {
                Console.Write("[?] x ? = ? -> ");
                string user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double mult1 = Convert.ToDouble(user_input);
                Console.Write($"{mult1} x [?] = ? -> ");
                user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double mult2 = Convert.ToDouble(user_input);
                double multTotal = mult1 * mult2; // Multiply the number
                Console.WriteLine($"\n{mult1} x {mult2} = {multTotal}");
                ansPrint = $"{mult1} x {mult2} = {multTotal}";
            }
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: MULTIPLICATION [[x]] ||[/] {name}\n");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double multTotal = inputNum * inputNum2;
                    var multTable = new Table();
                    multTable.AddColumn($"[lightskyblue1]{inputNum} x {inputNum2} =[/] [green]{multTotal}[/]");
                    AnsiConsole.Write(multTable);
                    ansPrint = $"{inputNum} x {inputNum2} = {multTotal}";
                }
                else
                {
                    var mult2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{inputNum} x[/] [yellow]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]")
                    );
                    double multTotal = inputNum * mult2;
                    var multTable = new Table();
                    multTable.AddColumn($"[lightskyblue1]{inputNum} x {mult2} =[/] [green]{multTotal}[/]");
                    AnsiConsole.Write(multTable);
                    ansPrint = $"{inputNum} x {inputNum2} = {multTotal}";
                }
                inputNum = 0;
                inputNum2 = 0;
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
                ansPrint = $"{mult1} x {mult2} = {multTotal}";
            }
        }
        Console.WriteLine("\n----------------------------------------------\n");
        answSoundEffect(audioAccess);
    }
    // DIVISION / DIVIDE
    else if (input == "division" || input == "/")
    {
        titleAppend = "CMAZEY CALCULATOR: DIVISION [/]";
        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: DIVISION [/] || {name1}\n");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double divTotal = inputNum / inputNum2;
                    Console.WriteLine($"\n{inputNum} / {inputNum2} = {divTotal}");
                    ansPrint = $"{inputNum} / {inputNum2} = {divTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    Console.Write($"{inputNum} / [?] = ? -> ");
                    string user_input = Console.ReadLine();
                    while (basicAns)
                    {
                        try
                        {
                            double checking = Convert.ToDouble(user_input);
                            if (checking > 1)
                            {
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid answer, please enter a number below:");
                            invalidAnsSoundEffect(audioAccess);
                            Console.Write("-> ");
                            user_input = Console.ReadLine();
                        }
                    }
                    double div2 = Convert.ToDouble(user_input);
                    double divTotal = inputNum / div2;
                    Console.WriteLine($"\n{inputNum} / {div2} = {divTotal}");
                    ansPrint = $"{inputNum} / {div2} = {divTotal}";
                    inputNum = 0;
                }
            }
            else
            {
                Console.Write("[?] / ? = ? -> ");
                string user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double div1 = Convert.ToDouble(user_input);
                Console.Write($"{div1} / [?] = ? -> ");
                user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double div2 = Convert.ToDouble(user_input);
                double divTotal = div1 / div2; // Divides the numbers
                Console.WriteLine($"\n{div1} / {div2} = {divTotal}");
                ansPrint = $"{div1} / {div2} = {divTotal}";
            }
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: DIVISION [[/]] ||[/] {name}\n");
            if (inputNum > 0)
            {
                if (inputNum2 > 0)
                {
                    double divTotal = inputNum / inputNum2;
                    var divTable = new Table();
                    divTable.AddColumn($"[lightskyblue1]{inputNum} + {inputNum2} =[/] [yellow]{divTotal}[/]");
                    AnsiConsole.Write(divTable);
                    ansPrint = $"{inputNum} / {inputNum2} = {divTotal}";
                    inputNum = 0;
                    inputNum2 = 0;
                }
                else
                {
                    var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{inputNum} /[/] [yellow]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]")
                    );
                    double divTotal = inputNum / div2;
                    var divTable = new Table();
                    divTable.AddColumn($"[lightskyblue1]{inputNum} / {div2} =[/] [green]{divTotal}[/]");
                    AnsiConsole.Write(divTable);
                    ansPrint = $"{inputNum} / {div2} = {divTotal}";
                    inputNum = 0;
                }
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
                ansPrint = $"{div1} / {div2} = {divTotal}";
            }
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //CHANGECALCULATOR // CHANGE
    else if (input == "change")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: CHANGE CALCULATOR [c]";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: CHANGE CALCULATOR [₵] || {name1}");
            Console.Write("\nEnter change to give back (1c - 99c): ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    if (checking > 99)
                    {
                        Console.WriteLine("You can't exceed over 99 in BASIC MODE..");
                        Console.Write("Please enter an amount to give back (1c - 99c) -> ");
                        user_input = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            int change = Convert.ToInt32(user_input);
            Console.WriteLine($"Change Amount: {change}c");
            changeAppend = $"Change Amount: {change}c";
            int Quarters = change / 25; // Divides the change amount by 25.
            quarterAppend = $"Quarter: {Quarters}";
            int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
            dimesAppend = $"Dimes: {Dimes}";
            int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
            nickelAppend = $"Nickel: {Nickels}";
            int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;
            pennieAppend = $"Pennie: {Pennies}";
            Console.WriteLine($"\nQuarters: {Quarters}");
            Console.WriteLine($"Dimes: {Dimes}");
            Console.WriteLine($"Nickels: {Nickels}");
            Console.WriteLine($"Pennies: {Pennies}");
        }
        else
        {
            AnsiConsole.MarkupLine($"[yellow]CMAZEY CALCULATOR:[/] [white]CHANGE CALCULATOR [[₵]] ||[/] {name}");
            var change = AnsiConsole.Prompt(
              new TextPrompt<int>("Enter [yellow]Change Amount[/]: ")
              .ValidationErrorMessage("[red]Not a valid number/Cannot be a decibel number[/]")
              .PromptStyle("yellow")
            );
            AnsiConsole.MarkupLine($"\n[bold yellow]CHANGE AMOUNT[/]: {change}");
            changeAppend = $"Change Amount: {change}c";
            int Quarters = change / 25; // Divides the change amount by 25.
            quarterAppend = $"Quarter: {Quarters}";
            int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
            dimesAppend = $"Dimes: {Dimes}";
            int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
            nickelAppend = $"Nickel: {Nickels}";
            int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;
            pennieAppend = $"Pennie: {Pennies}";
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
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //Clear
    else if (input == "clear" || input == "cls")
    {
        Console.Clear();
        Console.Beep();
        if (basic)
        {
            Console.WriteLine("\nType /help to show all the available commands!");
        }
        else
        {
            AnsiConsole.MarkupLine("\n[white]Type [green1]/help[/] to show all the available commands![/]");
        }
        inputNum = 0;
        inputNum2 = 0;
    }
    //LINE SLOPE CALCULATOR
    else if (input == "lineslope" || input == "ls")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: Line Slope Calculator";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: Line Slope Calculator || {name1}\n");
            Console.Write("x1: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            x1 = Convert.ToDouble(user_input);
            Console.Write("y1: ");
            user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            y1 = Convert.ToDouble(user_input);
            Console.Write("x2: ");
            user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            x2 = Convert.ToDouble(user_input);
            Console.Write("y2: ");
            user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            y2 = Convert.ToDouble(user_input);
            double slope = (y2 - y1) / (x2 - x1);
            if (x1 == 22 && x2 == 2 && y1 == 2 && y2 == 2)
            {
                Console.WriteLine("\n(Apparently, the answer is '-0' but I'm not going to show it, and i'm going to error this out.)");
                slope = (2 - x2) / (y1 - y2);
            }
            Console.WriteLine($"\nThe slope of the through points ({x1}, {y1}) and ({x2}, {y2}) is {slope}!");
            ansPrint = $"({x1}, {y1}) and  ({x2}, {y2}) is {slope}";
        }
        else
        {
            AnsiConsole.MarkupLine($"[yellow]CMAZEY CALCULATOR: Line Slope Calculator ||[/] {name}\n");
            x1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[yellow]x1[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            y1 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]y1[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            x2 = AnsiConsole.Prompt(
              new TextPrompt<double>("[yellow]x2[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            y2 = AnsiConsole.Prompt(
              new TextPrompt<double>("[green]y2[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );

            double slope = (y2 - y1) / (x2 - x1);
            ansPrint = $"({x1}, {y1}) and  ({x2}, {y2}) is {slope}";

            var linSlpeTable = new Table();
            linSlpeTable.AddColumn($"The slope of the through points ([yellow]{x1}, {y1}[/]) and ([yellow]{x2}, {y2}[/]) is [blue]{slope}[/].");
            AnsiConsole.Write(linSlpeTable);
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //VERSION
    else if (input == "version")
    {
        Console.WriteLine($"\nVersion: {version}");
        Console.WriteLine($"Name: {name1}\n");
        if (name1 == "Colton M" || name1 == "colton m")
        {
            titleAppend = "-- Version --";
            ansPrint = $"v: {version}\nName: {name1}\nDate: {month}/{day}/{year}\nTime: {hour}:{minute}:{second}:{millisecond}";
        }
        Console.Beep();
    }
    //VERSION logged
    else if (input == "version --log")
    {
        titleAppend = "-- Version --";
        ansPrint = $"[USR REQUEST]\nv: {version}\nName: {name1}\nDate: {month}/{day}/{year}\nTime: {hour}:{minute}:{second}:{millisecond}";
        Console.Beep();
        Console.WriteLine();
    }  
    //HeightToInches
    else if (input == "inchestoheight" || input == "htoi" || input == "itoh")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: INCHES TO HEIGHT";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: INCHES TO HEIGHT || {name1}\n");
            Console.Write("Enter your height in inches: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            int height = Convert.ToInt32(user_input);
            int num = 12;
            int foot = height / num; // Dividing the height in inches by 12
            int inches = height % num;

            Console.WriteLine($"\nYou are {foot}ft, {inches}in.");
            answSoundEffect(audioAccess);
            ansPrint = $"{foot}ft, {inches}in";
            Console.WriteLine("----------------------------------------------\n");
        }
        else
        {
            AnsiConsole.MarkupLine($"CMAZEY CALCULATOR: INCHES TO HEIGHT || {name}\n");
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
            answSoundEffect(audioAccess);
            AnsiConsole.Write(heightTable);
            ansPrint = $"{foot}ft, {inches}in";
            Console.WriteLine("\n----------------------------------------------\n");
        }
    }
    // 8BALL
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
            if (name == "Guest")
            {
                var eightBallInput = AnsiConsole.Ask<string>("What is your [green]question[/]? -> ");
            }
            else
            {
                var eightBallInput = AnsiConsole.Ask<string>($"What is your [green]question[/] {fname}? -> ");
            }
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
    else if (input == "lottery" || input == "lot")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        Random random = new();
        int winningNumber = random.Next(0, 100);
        int winningDigitOne = winningNumber / 10;
        int winningDigitTwo = winningNumber % 10;
        quarterAppend = $"Winning Number: {winningNumber}";
        if (basic)
        {
            Console.Write("Enter your lottery number (0 - 99): ");
            string inputLot = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(inputLot);

                    if (checking > 99)
                    {
                        Console.WriteLine("Lot number can't exceed over 100, please enter your lottery number again (0 - 99):");
                        answSoundEffect(audioAccess);
                        Console.Write("-> ");
                        inputLot = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    answSoundEffect(audioAccess);
                    Console.Write("-> ");
                    inputLot = Console.ReadLine();
                }
            }
            int entryNumber = Convert.ToInt32(inputLot);
            dimesAppend = $"Your Number: {entryNumber}";
            selectSoundEffect(audioAccess);
            int entryDigitOne = entryNumber / 10;
            int entryDigitTwo = entryNumber % 10;
            Console.WriteLine($"\nAnd the winning number is.... {winningNumber}");
            if (entryNumber == winningNumber)
            {
                Console.WriteLine("Exact match! You win the grand prize of $100,000!");
                cheerSoundEffect(audioAccess);
                pennieAppend = "EXACT MATCH! YOU WON $100,000!!!";
                lotWin++;
            }
            else if (winningDigitOne == entryDigitTwo && winningDigitTwo == entryDigitOne)
            {
                Console.WriteLine("You digits match, but out of order! You win $3,000!");
                pennieAppend = "Digits match, but are out of order. You won $3,000. Congrats!";
                lotWin++;
            }
            else
            {
                Console.WriteLine("No match. Better luck next time!");
                wompwompSoundEffect(audioAccess);
                pennieAppend = "No match, sorry bud...";
                lotLoss++;
            }
            Thread.Sleep(2000);
        }
        else
        {
            var lotInput = AnsiConsole.Prompt(
              new SelectionPrompt<string>()
              .Title($"Select your [green]lottery number[/]:")
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
            dimesAppend = $"Your Number: {entryNumber}";
            selectSoundEffect(audioAccess);
            int entryDigitOne = entryNumber / 10;
            int entryDigitTwo = entryNumber % 10;

            AnsiConsole.Markup($"[green]{fname} Lottery Number Selected:[/] {lotInput}\n");
            Thread.Sleep(1000);
            Console.WriteLine($"And the winning number is....... {winningNumber}\n");

            if (entryNumber == winningNumber)
            {
                AnsiConsole.Markup("[green1]Exact match[/]! You win the grand prize of [green1]$100,000![/]\n");
                cheerSoundEffect(audioAccess);
                pennieAppend = "EXACT MATCH! YOU WON $100,000!!!";
                lotWin++;
            }
            else if (winningDigitOne == entryDigitTwo && winningDigitTwo == entryDigitOne)
            {
                AnsiConsole.Markup("You digits match, but out of order! You win [green1]$3,000![/]\n");
                pennieAppend = "Digits match, but are out of order. You won $3,000. Congrats!";
                lotWin++;
            }
            else
            {
                AnsiConsole.Markup("[red]No match[/]. Better luck next time!\n");
                wompwompSoundEffect(audioAccess);
                pennieAppend = "No match, sorry bud...";
                lotLoss++;
            }
            Thread.Sleep(2000);
        }
        Console.WriteLine("\n----------------------------------------------\n");
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
        titleAppend = "CMAZEY CALCULATOR: Truncate [.]";
        Console.WriteLine("----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: Truncate [.] || {name1}\n");
            Console.Write("Enter a value: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            double trunNum = Convert.ToDouble(user_input);
            double trunTotal = Math.Truncate(trunNum);
            double roundTotal = Math.Round(trunNum);

            Console.WriteLine($"\nTruncated value is {trunTotal}");
            Console.WriteLine($"Rounded-Off value is {roundTotal}");
            ansPrint = $"Truncated value is {trunTotal}\nRounded-Off value is {roundTotal}";
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: Truncate [[.]] ||[/] {name}\n");
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
            ansPrint = $"Truncated value is {trunTotal}\nRounded-Off value is {roundTotal}";
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // Square Root
    else if (input == "square" || input == "square root")
    {
        titleAppend = "CMAZEY CALCULATOR: SQUARE ROOT [√]";
        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: SQUARE ROOT [√] || {name1}\n");
            if (inputNum > 0)
            {
                double squareNum = Convert.ToDouble(inputNum);
                double squareTotal = Math.Sqrt(inputNum);
                Console.WriteLine($"\nSquare root: {squareTotal}");
                ansPrint = $"Number: {squareNum}\nSquare Root: {squareTotal}";
                inputNum = 0;
            }
            else
            {
                Console.Write("Enter a number: ");
                string user_input = Console.ReadLine();
                while (basicAns)
                {
                    try
                    {
                        double checking = Convert.ToDouble(user_input);
                        if (checking > 1)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid answer, please enter a number below:");
                        invalidAnsSoundEffect(audioAccess);
                        Console.Write("-> ");
                        user_input = Console.ReadLine();
                    }
                }
                double squareNum = Convert.ToDouble(user_input);
                double squareTotal = Math.Sqrt(squareNum);
                Console.WriteLine($"\nSquare root: {squareTotal}");
                ansPrint =$"Number: {squareNum}\nSquare Root: {squareTotal}";
            }
        }
        else
        {
            AnsiConsole.MarkupLine($"CMAZEY CALCULATOR: SQUARE ROOT [[√]] || {name}\n");
            if (inputNum > 0)
            {
                double squareNum = Convert.ToDouble(inputNum);
                double squareTotal = Math.Sqrt(inputNum);
                var squareTable = new Table();
                squareTable.AddColumn($"[yellow]Square Root[/]: [lightskyblue1]{squareTotal}[/]");
                AnsiConsole.Write(squareTable);
                ansPrint = $"Number: {squareNum}\nSquare Root: {squareTotal}";
                inputNum = 0;

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
                ansPrint = $"Number: {squareNum}\nSquare Root: {squareTotal}";
            }
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // BigMul Multiplication
    else if (input == "bigmul multiplication" || input == "bigmul-big")
    {
        titleAppend = "CMAZEY CALCULATOR: BigMul-Big Multiplication";
        Console.WriteLine("\n----------------------------------------------\n");
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: BigMul-Big Multiplication [x] || {name1}\n");
            Console.Write("Enter a number: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    double checking = Convert.ToDouble(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            int bigMult1 = Convert.ToInt32(user_input);
            double bigMultTotal = Math.BigMul(bigMult1, bigMult1);
            Console.WriteLine($"{bigMult1} x {bigMult1} == {bigMultTotal}");
            ansPrint = $"{bigMult1} x {bigMult1} == {bigMultTotal}";
        }
        else
        {
            AnsiConsole.MarkupLine($"[yellow]CMAZEY CALCULATOR:[/] [white]BigMul-Big Multiplication [[x]] ||[/] {name}\n");
            var bigMult1 = AnsiConsole.Prompt(
              new TextPrompt<int>("Enter a [yellow]number[/]: ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/] // [red]Number too high for[/] [yellow]int[/] [red]value[/]")
            );
            double bigMultTotal = Math.BigMul(bigMult1, bigMult1);

            var bigMultTable = new Table();
            bigMultTable.AddColumn($"[yellow dim]{bigMult1}[/] [red]x[/] [yellow dim]{bigMult1}[/] = [chartreuse1]{bigMultTotal}[/]");
            AnsiConsole.Write(bigMultTable);
            ansPrint = $"{bigMult1} x {bigMult1} == {bigMultTotal}";
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // pi
    else if (input == "pi")
    {
        answSoundEffect(audioAccess);
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
        answSoundEffect(audioAccess);
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

            answSoundEffect(audioAccess);
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
                .Title("[white]What equation would you like to do?[/] [green](10 MAX)[/]")
                .PageSize(50)
                .AddChoices(new[] {
                    "++ <3>", "+++ <4>", "++++ <5>", "+++++ <6>", "++++++ <7>", "+++++++ <8>", "++++++++ <9>", "+++++++++ <10>",
                    "-- <3>", "--- <4>", "---- <5>", "----- <6>", "------ <7>", "------- <8>", "-------- <9>", "--------- <10>",
                    "** <3>", "*** <4>", "**** <5>", "***** <6>", "****** <7>", "******* <8>", "******** <9>", "********* <10>",
                    "// <3>", "/// <4>", "//// <5>", "///// <6>", "////// <7>", "/////// <8>", "//////// <9>", "///////// <10>",
                    "+- <3>", "-+ <3>", "+-*/ <5>", "????????? <9>",
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
            else if (customSelct == "// <3>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "/// <4>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "//// <5>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5}=[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "///// <6>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5 / div6;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "////// <7>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5 / div6 / div7;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "/////// <8>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? / ? / ? / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5 / div6 / div7 / div8;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "//////// <9>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? / ? / ? / ? / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5 / div6 / div7 / div8 / div9;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} / {div9} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "///////// <10>")
            {
                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] / ? / ? / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div2 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div3 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div4 = AnsiConsole.Prompt(
                   new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} /[/] [green]?[/] / ? / ? / ? / ? / ? / ? = ? -> ")
                   .PromptStyle("blue")
                   .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div5 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} /[/] [green]?[/] / ? / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div6 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} /[/] [green]?[/] / ? / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div7 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} /[/] [green]?[/] / ? / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div8 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} /[/] [green]?[/] / ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div9 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} /[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div10 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} / {div9} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double divTotal = div1 / div2 / div3 / div4 / div5 / div6 / div7 / div8 / div9 / div10;

                var divTable = new Table();
                divTable.AddColumn($"[lightskyblue1]{div1} / {div2} / {div3} / {div4} / {div5} / {div6} / {div7} / {div8} / {div9} / {div10} =[/] [yellow]{divTotal}[/]");
                AnsiConsole.Write(divTable);
            }
            else if (customSelct == "+- <3>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] + ? - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var addSub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] - ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {addSub1} -[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double addsubTotal = add1 + addSub1 - sub1;

                var addsubTable = new Table();
                addsubTable.AddColumn($"[lightskyblue1]{add1} + {addSub1} - {sub1} =[/] [yellow]{addsubTotal}[/]");
                AnsiConsole.Write(addsubTable);
            }
            else if (customSelct == "-+ <3>")
            {
                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>("[green]?[/] - ? + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var addSub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} -[/] [green]?[/] + ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{sub1} - {addSub1} +[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double addsubTotal = sub1 - addSub1 + add1;

                var addsubTable = new Table();
                addsubTable.AddColumn($"[lightskyblue1]{sub1} - {addSub1} + {add1} =[/] [yellow]{addsubTotal}[/]");
                AnsiConsole.Write(addsubTable);
            }
            else if (customSelct == "+-*/ <5>")
            {
                var add1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[green]?[/] + ? - ? * ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var sub1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} +[/] [green]?[/] - ? * ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var mult1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {sub1} -[/] [green]?[/] * ? / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var div1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {sub1} - {mult1} *[/] [green]?[/] / ? = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                var addsubmultdiv1 = AnsiConsole.Prompt(
                    new TextPrompt<double>($"[lightskyblue1]{add1} + {sub1} - {mult1} * {div1} /[/] [green]?[/] = ? -> ")
                    .PromptStyle("blue")
                    .ValidationErrorMessage("[red] That's not a valid number[/]"));

                double addsubmultdivTotal = add1 + sub1 - mult1 * div1 / addsubmultdiv1;

                var addsubmultdivTable = new Table();
                addsubmultdivTable.AddColumn($"[lightskyblue1]{add1} + {sub1} - {mult1} * {div1} / {addsubmultdiv1} =[/] [yellow]{addsubmultdivTotal}[/]");
                AnsiConsole.Write(addsubmultdivTable);
            }
            else if (customSelct == "Cancel")
            {
                Console.WriteLine("Prompt Canceled");
            }
            answSoundEffect(audioAccess);
        }
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //name
    else if (input == "name")
    {
        if (basic)
        {
            Console.Write("\nWhat's your name?: ");
            string namePrompt = Console.ReadLine();
            name1 = namePrompt;
            Console.WriteLine($"NAME CHANGED: {name1}");
        }
        else
        {
            if (name1 == "Guest")
            {
                nameChange = true;
            }
            else
            {
                AnsiConsole.MarkupLine($"NAME CHOSEN: {name}");
                var choice = AnsiConsole.Ask<string>("Change it? <[blue]y/n[/]>");

                if (choice == "y")
                {
                    crew = false;
                    nameChange = true;
                }
                else
                {
                    AnsiConsole.MarkupLine("[red]Prompt canceled...[/]\n");
                }

            }

            if (nameChange)
            {
                var namePrompt = AnsiConsole.Ask<string>("\nWhat's your [green]name[/]?").ToLower();

                if (namePrompt == "colton" || namePrompt == "colton m" || namePrompt == "colton mazey")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Colton Mazey?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine("\nNAME AUTOCORRECTED: Colton Mazey");
                        Console.WriteLine("\\owner");
                        name = "[darkgoldenrod]Colton Mazey[/]";
                        name1 = "Colton M";
                        fname = "Colton";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{ewqq}{cakoe}{asdc}{lijwq}" || namePrompt == "andy s" || namePrompt == "andy scott")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {cidqq}{cakoe}{asdc}{smcd}{dkoq}{caokw}{kewd}{cakoe} {jiweq}{cdow}{kewd}{fokcao}{fokcao}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {cidqq}{cakoe}{asdc}{smcd}{dkoq}{caokw}{kewd}{cakoe} {jiweq}{cdow}{kewd}{fokcao}{fokcao}");
                        Console.WriteLine("\\friend");
                        name = $"[darkgoldenrod]{cidqq}{cakoe}{asdc}{smcd}{dkoq}{caokw}{kewd}{cakoe} {jiweq}{cdow}{kewd}{fokcao}{fokcao}[/]";
                        name1 = $"{cidqq}{cakoe}{asdc}{smcd}{dkoq}{caokw}{kewd}{cakoe} {jiweq}";
                        fname = $"{cidqq}{cakoe}{asdc}{lijwq}";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{cakoe}{kewd}{ciako}{ewqq}{cakoe}" || namePrompt == "nolan m" || namePrompt == "nolan meyer")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Nolan Meyer?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine("\nNAME AUTOCORRECTED: Nolan Meyer");
                        Console.WriteLine("\\friend");
                        name = "[darkred]Nolan Meyer[/]";
                        name1 = "Nolan M";
                        fname = "Nolan";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{oeda}randon" || namePrompt == $"{oeda}randon r" || namePrompt == $"{oeda}randon reed")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Brandon Reed?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine("\nNAME AUTOCORRECTED: Brandon Reed");
                        Console.WriteLine("\\friend");
                        name = "[purple]Brandon Reed[/]";
                        name1 = "Brandon R";
                        fname = "Brandon";
                        crew = true;
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{oeda}raeden" || namePrompt == $"{oeda}raeden b" || namePrompt == $"{oeda}raeden barker")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Braeden Barker?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine("\nNAME AUTOCORRECTED: Braeden Barker");
                        Console.WriteLine("\\friend");
                        name = "[blue]Braeden Barker[/]";
                        name1 = "Braeden B";
                        fname = "Braeden";
                        crew = true;
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{kewd}{skmkw}{smcd}{cakoe}" || namePrompt == "owen k" || namePrompt == $"owen k{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}");
                        Console.WriteLine("\\friend");
                        name = $"[darkgoldenrod]{ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}{kewd}{cakoe}{ckoww}{eiiwq}{dkoq}{ewqq}[/]";
                        name1 = $"{ckwqo}{skmkw}{smcd}{cakoe} {kwdjiq}";
                        fname = $"{ckwqo}{skmkw}{smcd}{cakoe}";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{dokd}{smcd}{ciako}{smcd}{cakoe}" || namePrompt == $"h{smcd}le{cakoe} g" || namePrompt == $"h{smcd}le{cakoe} ge{dkoq}{dkoq}i{fokcao}y")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}{smcd}{dkoq}{dkoq}{ckew}{fokcao}{lijwq}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}{smcd}{dkoq}{dkoq}{ckew}{fokcao}{lijwq}");
                        Console.WriteLine("\\friend");
                        name = $"[lightpink1]{iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}{smcd}{dkoq}{dkoq}{ckew}{fokcao}{lijwq}[/]";
                        name1 = $"{iciqa}{smcd}{ciako}{smcd}{cakoe} {ckiw}";
                        fname = $"{iciqa}{smcd}{ciako}{smcd}{cakoe}";
                        crew = true;
                        if (audioAccess)
                        {
                            var random1SoundEffect = new Mp3FileReader("Resources\\umm.mp3");
                            var waveOut = new WaveOutEvent();
                            waveOut.Init(random1SoundEffect);
                            waveOut.Play();
                            Thread.Sleep(15000);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{asdc}{ewqq}{ckooe}{ckew}{asdc}" || namePrompt == "david b" || namePrompt == $"david b{eiiwq}{dkoq}{okdq}{smcd}")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}{eiiwq}{dkoq}{okdq}{smcd}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}{eiiwq}{dkoq}{okdq}{smcd}");
                        Console.WriteLine("\\friend");
                        name = $"[darkorange]{c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}{eiiwq}{dkoq}{okdq}{smcd}[/]";
                        name1 = $"{c9oqa}{ewqq}{ckooe}{ckew}{asdc} {coqko}";
                        fname = $"{c9oqa}{ewqq}{ckooe}{ckew}{asdc}";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{caokw}{smcd}{ewqq}{cakoe}" || namePrompt == $"s{smcd}{ewqq}{cakoe} {c9oqa}")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {jiweq}{smcd}{ewqq}{cakoe} {c9oqa}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {jiweq}{smcd}{ewqq}{cakoe} {c9oqa}");
                        Console.WriteLine("\\friend");
                        name = $"[darkgoldenrod]{jiweq}{smcd}{ewqq}{cakoe} {c9oqa}[/]";
                        name1 = $"{jiweq}{smcd}{ewqq}{cakoe} {c9oqa}";
                        fname = $"{jiweq}{smcd}{ewqq}{cakoe}";
                        crew = true;
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd}" || namePrompt == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd} g" || namePrompt == $"{okcokd}{ewqq}{cakoe}{cakoe}{ckew}{smcd} gray")
                {
                    var nameCheck = AnsiConsole.Ask<string>($"[white]Are you {ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}{dkoq}{ewqq}{lijwq}?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}{dkoq}{ewqq}{lijwq}");
                        Console.WriteLine("\\Crew Manager (LSOH)");
                        name = $"[darkgoldenrod]{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}{dkoq}{ewqq}{lijwq}[/]";
                        name1 = $"{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd} {ckiw}";
                        fname = $"{ciwq}{ewqq}{cakoe}{cakoe}{ckew}{smcd}";
                        crew = true;
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == $"{rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Anthony Mortimer?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: {rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}");
                        Console.WriteLine("\\CS Teacher");
                        name = $"[darkgoldenrod]Anthony {rifkoa}{kewd}{dkoq}{fokcao}{ckew}{rifkoa}{smcd}{dkoq}[/]";
                        name1 = $"Anthony {rifkoa}";
                        fname = $"Anthony";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else if (namePrompt == "rusto")
                {
                    var nameCheck = AnsiConsole.Ask<string>("[white]Are you Rusto?[/] [green1]<y/n>[/] -> ").ToLower();
                    if (nameCheck == "y")
                    {
                        Console.WriteLine($"\nNAME AUTOCORRECTED: Rusto");
                        Console.WriteLine("\\Friend");
                        name = "[yellow]Rusto[/]";
                        name1 = "Rusto";
                        fname = "Rusto";
                    }
                    else
                    {
                        Console.WriteLine($"NAME CHANGED: {namePrompt}");
                        name = namePrompt;
                        name1 = namePrompt;
                        fname = namePrompt;
                    }
                }
                else
                {
                    name = $"[white]{namePrompt}[/]";
                    name1 = namePrompt;
                    Console.WriteLine($"NAME CHANGED: {name1}");
                    fname = namePrompt;
                }
                nameChange = false;
                Console.WriteLine();
            }
        }
    }
    //LSOH PLAY
    else if (input == "play" || input == "little shop of horrors")
    {
        if (crew)
        {
            Console.Write("Do you want to check out the credits? (y/n) -> ");
            input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("\n\n----------------------------------------------\n");

                Thread.Sleep(1000);
                AnsiConsole.MarkupLine("The Edwardian Player presents");
                Thread.Sleep(500);
                AnsiConsole.MarkupLine("[bold][underline]Little Shop Of Horrors[/][/]\n");
                Thread.Sleep(500);
                AnsiConsole.MarkupLine("Book and Lyrics by HOWARD ASHMAN\n");
                Thread.Sleep(500);
                AnsiConsole.MarkupLine("Music by ALAN MENKEN\n\n");
                Thread.Sleep(500);
                AnsiConsole.MarkupLine("[white bold]--- CAST MEMBERS ---[/]\n");
                Thread.Sleep(1500);
                AnsiConsole.MarkupLine("[yellow]Seymour[/] - [white]JOEY POKRYWKA[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[green]Audrey[/] - [white]LAURIEN PALMER[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[red]The Voice of Audrey II[/] - [white]ADAM DEMPSEY[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[yellow]Mr. Mushnik[/] - [white]THOMAS LOPEZ[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[green]Orin[/] - [white]MICHAEL DRVENKAR[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[red]Crystal[/] - [white]JULIA O'BRIAN[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[gold1]Ronnette[/] - [white]HELEN GERRITY[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[green]Chiffon[/] - [white]HAILY BETTERS[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[red]Audrey II Puppeteer[/] - [white]DANNY CERTO[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[yellow]Berstein[/] - [white]JACOB YANKOW[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[green]Mrs. Luce[/] - [white]KEONA CARABELLO[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[red]Snip[/] - [white]AIDEN NEWKIRK-SCHULZE[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[yellow]Ensemble[/] - [white]HANNA BETTERS[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[green]Ensemble[/] - [white]MICHAEL GREGORY[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[red]Ensemble[/] - [white]CONALL MCMAHON[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[yellow]Ensemble[/] - [white]LUKAS PARSONS[/]\n");
                Thread.Sleep(1500);
                AnsiConsole.MarkupLine("[white bold]--- CREW ---[/]\n");
                Thread.Sleep(1000);
                AnsiConsole.MarkupLine("[gold3_1]Stage Manager[/] - [white]Xannie Gray[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[chartreuse4]Lighting Crew[/]/[paleturquoise1]Sound Crew Chief[/]/[lightgoldenrod1]Set Construction[/] - [white]Braeden Barker[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Crew Manager (Student Staff) - [white]Sean Dabydeen[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[darkorange]Costume Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Erin Houghtling[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[darkorange]Costume Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Julia Houghtling[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[paleturquoise1]Sound Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Colton Mazey[/] (DEV)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[lightgoldenrod1]Set Construction[/] - [white]Alysia McGill[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Elijah Molseed[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[darkorange]Costume Crew Chief[/]/[lightgoldenrod1]Set Construction[/] - [white]Sarah Molseed[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[aquamarine3]Prop Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Clare Monahan[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[lightgoldenrod1]Set Construction[/] - [white]Daniel Monahan[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[aquamarine3]Prop Crew Co-Chief[/]/[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Scott O'Neill[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[aquamarine3]Prop Crew Co-Chief[/]/[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Brandon Reed[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[lightgoldenrod1]Set Construction[/] - [white]Benjamin Ross[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Dante Scott[/] (BF)");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Bradley Sellers[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[lightgoldenrod1]Set Construction[/] - [white]Rueben Shaffer[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[darkorange]Costume Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Rebecca Sinclair[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[lightgoldenrod1]Set Construction[/] - [white]Andrew Smith[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[royalblue1]Paint Crew Chief[/]/[lightgoldenrod1]Set Construction[/] - [white]Mia Strauss[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[aquamarine3]Prop Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Gabriel Valore[/]");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[chartreuse4]Lighting Crew[/]/[lightgoldenrod1]Set Construction[/] - [white]Lucy Ye[/]\n");
                Thread.Sleep(1500);
                AnsiConsole.MarkupLine("[white bold]--- ORCHESTRA/PIT ---[/]\n");
                Thread.Sleep(1000);
                AnsiConsole.MarkupLine("[white]David Michaels[/] - Keyboard 1");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[white]Harry Richardson[/] - Keyboard 2");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[white]Calvin Polenz[/] - Percussion");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[white]Tyler Valentino[/] - Electric Guitar");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("[white]Matt Pukansky[/] - Bass Guitar\n");
                Thread.Sleep(1500);
                AnsiConsole.MarkupLine("[white bold]--- STAFF ---[/]\n");
                Thread.Sleep(1000);
                AnsiConsole.MarkupLine("Director - Tony Heffner '13");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Technical Director and Set Design - John F. Goers '78");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Master Carpenter - Matt O'Konowitz '01");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Choreographer - Sarah Heffner");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Music Director - David Michaels '03");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Props Director - Cari Foster");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Scenic Artist - Tracy Deal");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Lighting Designer and Director - Sean Monahan '93");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Lighting Technician - Corey Farr '12");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Costume Design - Joseph Basalla '15");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Technical & Scenic Design Assistant - Emily Hetman");
                Thread.Sleep(100);
                AnsiConsole.MarkupLine("Business Manager/Program/Box Office - Dawna Rae Warren");
                Thread.Sleep(2000);
                Console.WriteLine("\n----------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("Prompt Canceled...");
            }
        }
        else if (basic)
        {
            Console.WriteLine("This command isn't supported in BASIC mode, sorry bud..\n");
        }
        else
        {
            Console.WriteLine("Invalid command, please try again.\n");
        }
    }
    //Lottery Results
    else if (input == "lotteryresult" || input == "lotresult")
    {
        if (basic)
        {
            Console.WriteLine("\n--- Lottery Result ---\n");
            Console.WriteLine($"Wins: {lotWin}");
            Console.WriteLine($"Loss: {lotLoss}\n");
            Thread.Sleep(1000);
            Console.Beep();
        }
        else
        {
            var lotTable = new Table();

            Console.WriteLine($"\n--- {fname} Lottery Result ---\n");
            lotTable.AddColumn("");
            lotTable.AddColumn("#");
            lotTable.AddRow("[green3_1]Wins[/]", $"[white]{lotWin}[/]");
            lotTable.AddRow(new Markup("[red3]Loss[/]"), new Markup($"[white]{lotLoss}[/]"));

            AnsiConsole.Write(lotTable);
            Console.WriteLine();
        }
    }
    //bored
    else if (input == "bored")
    {
        while (true)
        {
            Random random = new();
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("This");
            Thread.Sleep(3000);
            Console.WriteLine("Is");
            Thread.Sleep(3000);
            Console.WriteLine("Cmazey");
            Thread.Sleep(3000);
            Console.WriteLine("Calculator");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("A");
            Thread.Sleep(3000);
            Console.WriteLine("Terminal");
            Thread.Sleep(3000);
            Console.WriteLine("Calculator");
            Thread.Sleep(3000);
            i = 0;
            while (i < 5)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }
            Console.WriteLine("+");
            Thread.Sleep(3000);
            Console.WriteLine("-");
            Thread.Sleep(3000);
            Console.WriteLine("x");
            Thread.Sleep(3000);
            Console.WriteLine("/");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            i = 0;
            while (i < 5)
            {
                Console.WriteLine(".");
                i++;
                Thread.Sleep(3000);
            }
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("[?] + ? = ? -> -");
            Thread.Sleep(3000);
            int a = Convert.ToInt32(random.Next(1, 999));
            Console.WriteLine($"{a} + [?] = -> -");
            Thread.Sleep(3000);
            int b = Convert.ToInt32(random.Next(1, 999));
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            i = 0;
            while (i < 6)
            {
                Thread.Sleep(3000);
                Console.WriteLine(".");
                i++;
            }
            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("[?] - ? = ? -> -");
            Thread.Sleep(3000);
            a = Convert.ToInt32(random.Next(1, 999));
            Console.WriteLine($"{a} - [?] = -> -");
            Thread.Sleep(3000);
            b = Convert.ToInt32(random.Next(1, 999));
            c = a - b;
            Console.WriteLine($"{a} + {b} = {c}");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            i = 0;
            while (i < 6)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }
            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("[?] x ? = ? -> -");
            Thread.Sleep(3000);
            a = Convert.ToInt32(random.Next(1, 999));
            Console.WriteLine($"{a} x [?] = -> -");
            Thread.Sleep(3000);
            b = Convert.ToInt32(random.Next(1, 999));
            c = a * b;
            Console.WriteLine($"{a} x {b} = {c}");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            i = 0;
            while (i < 6)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }
            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("[?] / ? = ? -> -");
            Thread.Sleep(3000);
            a = Convert.ToInt32(random.Next(1, 999));
            Console.WriteLine($"{a} / [?] = -> -");
            Thread.Sleep(3000);
            b = Convert.ToInt32(random.Next(1, 999));
            c = a / b;
            Console.WriteLine($"{a} / {b} = {c}");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            i = 0;
            while (i < 8)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }
            Console.WriteLine("Created");
            Thread.Sleep(3000);
            Console.WriteLine("by");
            Thread.Sleep(3000);
            Console.WriteLine("Colton");
            Thread.Sleep(3000);
            Console.WriteLine("Mazey");
            Thread.Sleep(3000);
            i = 0;
            while (i < 10)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }
            Console.WriteLine("----------------------------------------------");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            int lotwin = random.Next(0, 100);
            int d = lotwin / 10;
            int e = lotwin % 10;
            Console.WriteLine("Enter a lottery Number (0 - 99) -> ");
            int fk = Convert.ToInt32(random.Next(0, 100));
            Thread.Sleep(3000);
            Console.WriteLine($"And the winner is {lotwin}");
            Thread.Sleep(3000);
            if (fk == lotwin)
            {
                Console.WriteLine("Exact match! You win the grand prize of $100,000!");
            }
            else
            {
                Console.WriteLine("No match. Better luck next time!");
            }
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------");
            i = 0;
            while (i < 15)
            {
                Console.WriteLine(".");
                Thread.Sleep(3000);
                i++;
            }

        }
    }
    //binary to hexadecimal
    else if (input == "binarytohexadecimal" || input == "btoh")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: Binary To Hexadecimal [0101]";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: Binary To Hexadecimal [0101] | {name1}\n");
            Console.Write("Enter binary number: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    int checking = Convert.ToInt32(user_input,2);
                    string checkingBin = checking.ToString("X");
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            int binaryInput = Convert.ToInt32(user_input, 2);
            string hexadecimalAns = binaryInput.ToString("X");
            Console.WriteLine($"\nHexadecimal: {hexadecimalAns}");
            ansPrint = $"Binary: {user_input} // {binaryInput}\nHexadecimal: {hexadecimalAns}";
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: Binary To Hexadecimal [[0110]] |[/] {name}\n");
            var binInput = AnsiConsole.Prompt(
              new TextPrompt<string>("[white]Enter a [gold1]binary number[/]:[/] ")
              .PromptStyle("blue")
            );
            while (true)
            {
                try
                {
                    int checking = Convert.ToInt32(binInput,2);
                    string checkingBin = checking.ToString("X");
                    break;
                }
                catch
                {
                    AnsiConsole.MarkupLine("[red]Invalid answer, please try again:[/]");
                    invalidAnsSoundEffect(audioAccess);
                    binInput = AnsiConsole.Ask<string>("[white]->[/]");
                }
            }
            int binaryInput = Convert.ToInt32(binInput,2);
            string hexadecimalAns = binaryInput.ToString("X");
            var hexBinTable = new Table();
            hexBinTable.AddColumn($"[yellow]Binary:[/] [green1]{binaryInput}[/] \\ [yellow]Hexadecimal[/]: [green1]{hexadecimalAns}[/]");
            AnsiConsole.Write(hexBinTable);
            ansPrint = $"Binary: {binInput} // {binaryInput}\nHexadecimal: {hexadecimalAns}";

        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    //decimal to binary
    else if (input == "decimaltobinary" || input == "dtob")
    {
        Console.WriteLine("\n----------------------------------------------\n");
        titleAppend = "CMAZEY CALCULATOR: Decimal To Binary [0111]";
        if (basic)
        {
            Console.WriteLine($"CMAZEY CALCULATOR: Decimal To Binary [0111] | {name1}\n");
            Console.Write("Enter a number: ");
            string user_input = Console.ReadLine();
            while (basicAns)
            {
                try
                {
                    int checking = Convert.ToInt32(user_input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a valid answer, please enter a number below:");
                    invalidAnsSoundEffect(audioAccess);
                    Console.Write("-> ");
                    user_input = Console.ReadLine();
                }
            }
            int decNum = Convert.ToInt32(user_input);
            string binaryNum = Convert.ToString(decNum, 2);
            Console.WriteLine($"Binary: {binaryNum}");
            ansPrint = $"Decimal: {user_input}\nBinary: {binaryNum}";
        }
        else
        {
            AnsiConsole.MarkupLine($"[white]CMAZEY CALCULATOR: Decimal To Binary [[0111]] |[/] {name}\n");
            var decNum = AnsiConsole.Prompt(
              new TextPrompt<int>("[white]Enter a number:[/] ")
              .PromptStyle("blue")
              .ValidationErrorMessage("[red] That's not a valid number[/]")
            );
            string binaryNum = Convert.ToString(decNum, 2);
            var decbinNum = new Table();
            decbinNum.AddColumn($"[yellow]Decimal:[/] [green1]{decNum}[/] \\ [yellow]Binary[/]: [green1]{binaryNum}[/]");
            AnsiConsole.Write(decbinNum);
            ansPrint = $"Decimal: {decNum}\nBinary: {binaryNum}";
        }
        answSoundEffect(audioAccess);
        Console.WriteLine("\n----------------------------------------------\n");
    }
    // Exit
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
                Console.Beep();
                basic = true;
            }
            else
            {
                Console.WriteLine("Prompt Canceled...\n");
            }
        }
    }
    //numCheck
    else if (input == "numcheck" || input == "int")
    {
        if (basic)
        {
            if (inputNum > 0)
            {
                Console.WriteLine($"\nNum1: {inputNum}");
            }
            else
            {
                Console.WriteLine("\nNum1: N/A");
            }
            if (inputNum2 > 0)
            {
                Console.WriteLine($"Num2: {inputNum2}\n");
            }
            else
            {
                Console.WriteLine("Num2: N/A\n");
            }
        }
        else
        {
            if (inputNum > 0)
            {
                AnsiConsole.MarkupLine($"\n[white]Num1:[/] [green1]{inputNum}[/]");
            }
            else
            {
                AnsiConsole.MarkupLine("\n[white]Num1:[/] [red]N/A[/]");
            }
            if (inputNum2 > 0)
            {
                AnsiConsole.MarkupLine($"[white]Num2:[/] [green1]{inputNum2}[/]\n");
            }
            else
            {
                AnsiConsole.MarkupLine("[white]Num2:[/] [red]N/A[/]\n");
            }
        }
        Console.Beep();
    }
    //Log Access
    else if (input == "log")
    {
        if (basic)
        {
            if (logAccess)
            {
                Console.WriteLine($"\nLogs are already enabled. It's stored in {path}.\n");
            }
            else
            {
                Console.Write("\nDo you want to enable log access? (y/n) -> ");
                string logInput = Console.ReadLine();

                if (logInput == "y")
                {
                    Console.WriteLine($"LOG ARE ENABLED, Logs/Results will be saved in '{path}'");
                    logAccess = true;
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "CCLResult.txt"), true))
                    {
                        outputFile.WriteLine("----- CMAZEY CALCULATOR RESULTS -----");
                        outputFile.WriteLine($"---------- Name: {name1} --------------");
                        outputFile.WriteLine("-------------------------------------\n");
                        logSoundEffect(audioAccess);
                    }
                }
            }
        }
        else
        {
            if (logAccess)
            {
                AnsiConsole.MarkupLine($"\n[white]Logs are enabled. It's store in '[green1]{path}[/]'.[/]\n");
            }
            else
            {
                var logInput = AnsiConsole.Ask<string>("\n[white]Do you want to enable [green]logs[/]? [blue]<y/n>[/]:[/]");
                if (logInput == "y")
                {
                    AnsiConsole.MarkupLine("[green1]LOGS ARE ENABLED[/]");
                    AnsiConsole.MarkupLine($"[white]Logs will be saved in '[green1]{path}[/]'[/]\n");
                    logAccess = true;
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "CCLResult.txt"), true))
                    {
                        outputFile.WriteLine("----- CMAZEY CALCULATOR RESULTS -----");
                        outputFile.WriteLine($"---------- Name: {name1} --------------");
                        outputFile.WriteLine("-------------------------------------\n");
                        logSoundEffect(audioAccess);
                    }
                }
                else
                {
                    AnsiConsole.MarkupLine("[red]Prompt canceled.[/]\n");
                }
            }
        }
    }
    // Clear num
    else if (input == "clearint" || input == "clsint")
    {
        if (basic)
        {
            inputNum = 0;
            Console.WriteLine("\nNum1: CLEARED");
            inputNum2 = 0;
            Console.WriteLine("Num2: CLEARED\n");
            answSoundEffect(audioAccess);
        }
        else
        {
            inputNum = 0;
            AnsiConsole.MarkupLine("\n[white]Num1:[/] [green1]CLEARED[/]");
            inputNum2 = 0;
            AnsiConsole.MarkupLine("[white]Num2:[/] [green1]CLEARED[/]\n");
            answSoundEffect(audioAccess);
        }
    }
    // Current Path/Directory
    else if (input == "currentpath" || input == "crntpath" || input == "dir")
    {
        if (basic)
        {
            Console.WriteLine($"\nDocument Path: {path}");
            // Console.WriteLine($"Shell Path: {shellPath}");
            Console.WriteLine($"Current Path: {curntDir}\n");
        }
        else
        {
            AnsiConsole.MarkupLine($"\n[white]Document Path:[/] [green1]{path}[/]");
            // AnsiConsole.MarkupLine($"[white]Shell Path:[/] [green1]{shellPath}[/]");
            AnsiConsole.MarkupLine($"[white]Current Path:[/] [green1]{curntDir}[/]\n");
        }
    }
    // INVALID RESPONSE
    else
    {
        while (basicAns)
        {
            try
            {
                double checking = Convert.ToDouble(input);
                if (checking > 1)
                {
                    if (basic)
                    {
                        if (inputNum > 0)
                        {
                            Console.WriteLine($":{checking}");
                            inputNum2 = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                        else
                        {
                            Console.WriteLine(checking);
                            inputNum = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                    }
                    else
                    {
                        if (inputNum > 0)
                        {
                            AnsiConsole.MarkupLine($"[blue]{checking}[/]");
                            inputNum2 = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                        else
                        {
                            AnsiConsole.MarkupLine($"[white]{checking}[/]");
                            inputNum = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                    }
                    break;
                }
                else
                {
                    if (basic)
                    {
                        if (inputNum > 0)
                        {
                            Console.WriteLine($":{checking}");
                            inputNum2 = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                        else
                        {
                            Console.WriteLine(checking);
                            inputNum = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                    }
                    else
                    {
                        if (inputNum > 0)
                        {
                            AnsiConsole.MarkupLine($"[blue]{checking}[/]");
                            inputNum2 = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                        else
                        {
                            AnsiConsole.MarkupLine($"[white]{checking}[/]");
                            inputNum = checking;
                            numCheckSoundEffect(audioAccess);
                        }
                    }
                    break;
                }
            }
            catch
            {
                incorrectAnsSoundEffect(audioAccess);
                Console.WriteLine("Invalid Command, please try again.\n");
                Random random = new();
                int elseChoice = random.Next(1, 5);
                if (elseChoice == 1)
                {
                    Console.WriteLine("Fun Fact: A command start with a capital letter!\n");
                }
                else if (elseChoice == 2)
                {
                    Console.WriteLine("Fun Fact: You can use symbols too instead of typing commands. E.G. +, -, x, /\n");
                }
                else if (elseChoice == 3)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Um hey, there is a secret in this command line. Keep an eye out for suspicious things.\n");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                break;
            }
        }
    }   
    // Append strings into a .txt file
    if (logAccess)
    {
        if (ansPrint == "")
        {
            ansPrint = "";
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "CCLResult.txt"), true))
                {
                    outputFile.WriteLine("\n----------\n");
                    outputFile.WriteLine(titleAppend);
                    outputFile.WriteLine(ansPrint);
                    outputFile.WriteLine("\n----------\n");
                }
            ansPrint = "";
            titleAppend = "";
        }
        if (changeAppend == "")
        {
            changeAppend = "";
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "CCLRESULT.txt"), true))
            {
                outputFile.WriteLine("\n----------\n");
                outputFile.WriteLine($"{titleAppend}\n");
                outputFile.WriteLine($"{changeAppend}\n");
                outputFile.WriteLine(quarterAppend);
                outputFile.WriteLine(dimesAppend);
                outputFile.WriteLine(nickelAppend);
                outputFile.WriteLine(pennieAppend);
                outputFile.WriteLine("\n----------\n");
            }
            changeAppend = "";
            titleAppend = "";
            changeAppend = "";
            quarterAppend = "";
            dimesAppend = "";
            nickelAppend = "";
            pennieAppend = "";
        }
        if (pennieAppend == "")
        {
            pennieAppend = "";
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "CCLRESULT.txt"), true))
            {
                outputFile.WriteLine("\n----------\n");
                outputFile.WriteLine("--- Cmazey Calculator Lottery ---\n");
                outputFile.WriteLine(dimesAppend);
                outputFile.WriteLine(quarterAppend);
                outputFile.WriteLine(pennieAppend);
                outputFile.WriteLine("\n----------\n");
            }
            dimesAppend = "";
            quarterAppend = "";
            pennieAppend = "";
        }
    }
}
Console.Write("Press enter to exit program...");
Console.ReadKey();
Console.WriteLine();

// Sound Effects (via Pixabay)
static void answSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var notifyAns = new Mp3FileReader("Resources\\notifySound.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(notifyAns);
        waveOut.Play();
    }
}

static void incorrectAnsSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var invalidAns = new Mp3FileReader("Resources\\InvalidAns.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(invalidAns);
        waveOut.Play();
    }
}

static void numCheckSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var numCheckAns = new Mp3FileReader("Resources\\numCheckNotify.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(numCheckAns);
        waveOut.Play();
    }
}

static void logSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var logCreatedAns = new Mp3FileReader("Resources\\logsCreated.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(logCreatedAns);
        waveOut.Play();
    }
}

static void invalidAnsSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var invalidAns = new Mp3FileReader("Resources\\PLstryAgain.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(invalidAns);
        waveOut.Play();
    }
}

static void cheerSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var cheerAns = new Mp3FileReader("Resources\\cheering.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(cheerAns);
        waveOut.Play();
    }
}

static void wompwompSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var lostAns = new Mp3FileReader("Resources\\lost.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(lostAns);
        waveOut.Play();
    }
}

static void selectSoundEffect(bool audioAccess)
{
    if (audioAccess)
    {
        var selectAns = new Mp3FileReader("Resources\\select.mp3");
        var waveOut = new WaveOutEvent();
        waveOut.Init(selectAns);
        waveOut.Play();
    }
}

