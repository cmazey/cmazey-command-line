 Console.WriteLine ("\n--- Battle Simulator ---");
    int playerHealth = 100;
    int enemyHealth = 100;
    int enemyAttackDamage = 20;
    int potions = 3;

    Console.WriteLine($"Health: {playerHealth}");
    Console.WriteLine($"Enemy Health: {enemyHealth}");
    Console.WriteLine();

    
  Console.WriteLine("Round 1");
    Console.WriteLine("Player Attack.");
    enemyHealth = enemyHealth - 15; //Subtracts the variable by 15
    Console.WriteLine($"You did 15 damage! Enemy Health: {enemyHealth}");
    playerHealth = playerHealth - enemyAttackDamage;
    Console.WriteLine($"Enemy did {enemyAttackDamage} damage! Player health: {playerHealth}");
    Console.WriteLine();

  Console.WriteLine("Using potion...");
    playerHealth = playerHealth + 10;
    potions--; // Subtracts by 1
    Console.WriteLine($"Player health: {playerHealth}. Potions left: {potions}");

    Console.WriteLine("Buying one potion...");
    potions++; //Adding 1
    Console.WriteLine($"Potions left: {potions}");
    Console.WriteLine("Using the potion!!!");
    potions--;

    Console.WriteLine("\n\n");

  Console.WriteLine("--- Banking Simulator ---");
    string accountName = "checking Account";
    double accountBalance = 100.50;

    Console.WriteLine($"{accountName} balance: {accountBalance}");
    Console.WriteLine($"Depositing $99.01 to {accountName}");
    accountBalance = accountBalance + 99.01;
    Console.WriteLine($"{accountName} balance: {accountBalance}");

    //day 2 of driving, my dad is still following behind me...
    