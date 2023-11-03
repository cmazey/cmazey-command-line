using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Enter your favorite soda: ");
    string soda = Console.ReadLine();
    int bottles = 99;

    while (bottles > 0)
    {
      Console.WriteLine($"{bottles} bottles of {soda} on the wall.");
      Console.WriteLine($"{bottles} bottles pf {soda}!");
      Console.WriteLine("You take on down, pass it around,");
      bottles = bottles - 1;
      Console.WriteLine($"{bottles} bottles of {soda} on the wall!\n");
      System.Threading.Thread.Sleep(100);
    }

    System.Threading.Thread.Sleep(5000);



    // ATM LITE
    bool usingAtm = true;
    double balance = 100.55;
    
    Console.WriteLine("/n/n/n-- ATM Lite --");

    while (usingAtm)
    {
      Console.WriteLine("\n- Menu");
      Console.WriteLine("1) Check Balance");
      Console.WriteLine("2) Depsoit Money");
      Console.WriteLine("3) Withdraw Money");
      Console.WriteLine("4) Exit");

      Console.Write("-> ");
      string input = Console.ReadLine();

      if (input == "1")
      {
        Console.WriteLine($"Your balance is: ${balance}");
      }

      else if (input == "2")
      {
        Console.WriteLine("\nHow much would you like to deposit? $");
        input = Console.ReadLine();
        balance = balance + Convert.ToDouble(input);
        Console.WriteLine($"Your new balance is ${balance}\n");
      }
      else if (input == "3")
      {
        Console.Write("\nHow much would you like to withdraw? $");
        input = Console.ReadLine();
        balance = balance - Convert.ToDouble(input);
        Console.WriteLine($"Your new balance is ${balance}!\n");
      }
      else if (input == "4")
      {
        Console.WriteLine("Thank you for using ATM Lite!");
        Console.WriteLine("Have a nice day!");
        usingAtm = false;
      }
      else
      {
        Console.WriteLine("Incorrect menu option selected. Try again.\n");
      }
    }

    
  }
}