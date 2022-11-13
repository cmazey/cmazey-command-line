//All of the code above is all written by COLTON MAZEY, all credit are giving to me- I mean, him.

var readline = require("readline-sync");
var colors = require('colors');
var loggingOff = false;
var playing = false;
var commandPrompt = false;
var money = 0;
var nodeJs = false;
var win = 0;
var losses = 0;
var round = 1;
var Playing = false;
var adminnnn = false;
var name = "David";
var age = 15;
var bankAccount = 15000;
var isATeacher = false;
var isAMillionaire = false;
var playerHealth = 10;
var enemyHealth = 10;
var escaped = false;
var commandline = false;

var ans1 = readline.question("Are you sure you want to continue? (yes) -> ".yellow);

if (ans1 == "yes") {
    console.clear();

    console.log("WINDOWS COMMAND LINE");
    console.log("REPL RECREATED BY COLTON MAZEY AKA 'CMAZEY'\n");
    var name = readline.question("Please enter your username: ");

    console.clear();

    console.log("Microsoft Windows [Version 10.0.22000.493]");
    console.log("(c) Microsoft Corporation. All rights reserved.\n");

    commandline = true;
}

else {
    console.log("\nRequest terminated...\n\n\n\n");
}

while (commandline) {
  var cmdanswer = readline.question(`C:/Users/${name}> `);

  if (cmdanswer == "help") {
    console.log("\nadmin");
    console.log("help");
    console.log("crazy");
    console.log("about");
    console.log("clear");
    console.log("sleepy");
    console.log("More coming soon\n");
  }

  else if (cmdanswer == "admin") {
    console.log("WARNING: YOU ARE ATTEMPTED TO ACCESS THE ADMINISTRATOR CONSOLE...".red);
    var ans2 = readline.question("Are you sure you want to proceed? (yes, no) > ".yellow);

    if (ans2 == "yes") {
        console.clear();
        //START
          //Admin Login
  console.log("---ADMIN LOGIN---\n");
  console.log(`USERNAME AUTOFILLED: ${name}`.rainbow);
  var age = readline.question("How old are you?: ");
  var verify = parseInt(readline.question("What's your identification number?: \n"));
  
  //Confirm login
  console.log("---CONFIRMATION---\n");
  console.log(`Your name is ${name} and you are ${age} years old and your identification number is ${verify}.`);
  verify = readline.question("Was the information shown here correct? (Yes, no) -> ");
  
  if (verify == "yes" || verify == "Yes") {
    console.clear();
    console.log("---ADMIN CONSOLE---\n");
    console.log(`Welcome ${name} to the admin console!`);
    var time = parseInt(Math.random() * 500 + 10);
    console.log(`You have been last online about ${time} minutes ago.\n`);
    
    adminnnn = true;
  }
  else if (verify == "no" || verify == "n") {
    console.log("Program termanated.\n\n");

    console.log("Microsoft Windows [Version 10.0.22000.493]");
    console.log("(c) Microsoft Corporation. All rights reserved.\n");

    commandPrompt = true;
  }
  else {
    console.log("Program terminated.");
    var bblank = readline.question("Press space to continue...");
    console.clear();
    console.log("Microsoft Windows [Version 10.0.22000.493]");
    console.log("(c) Microsoft Corporation. All rights reserved.\n");
    commandPrompt = true;
  }
  //Main "Admin" Menu

    while (adminnnn) {

    console.log("- Hack");
    console.log("- Dataserver");
    console.log("- R.P.S (Rocks, Papers, Scissors)");
    console.log("- H.T (Heads or Tails)")
    console.log("- Dark Story")
    console.log("- Branching");
    console.log("- ATM");
    console.log("- Logic");
    console.log("- Drinks");
    console.log("- Order Food");
    console.log("- Math");
    console.log("- M.To.K (Miles to Kilometers)");
    console.log("- RPG");
    console.log("- input");
    console.log("- sus");
    console.log("- Logoff\n");
    var choice = readline.question("What would you like to do? (choose any option above) -> ").toLowerCase();

    //Hack
    if (choice == "hack") {
    var victim = readline.question("Who do you want to hack so far sir? (Write any name) -> ");
      console.log("\n");
      console.log(`Hacking process started... Victim: ${victim}.`);
      console.log("Hacking into his home network");
      console.log(`Found and sell ${victim} information, made about 100000$!`);
      money = 100000;
      console.log(`hacking into ${victim} IP address..`);
      console.log(`Hacking into ${victim} email address: ${victim}@me.com`);
      console.log(`Sell email address and password and made about 156.000$!`)
      money = 156000;
      console.log("Hacking process complete, now logging off.");
      var blank = readline.question("Press space to continue...");
      console.clear();
      adminnnn = false;
      loggingOff = true;
    }

    //Dataserver
    else if (choice == "dataserver" || choice == "dataserver") {
      console.log("---DATA SERVER---");
      console.log(`Error: 'C:/users/${name}/node/admin/console/dataserver' does not exist.`);
      var blank = readline.question("Press space to continue...");
      console.clear();
      adminnnn = false;
      loggingOff = true;
    }

    //Logoff
    else if (choice == "logoff" || choice == "logoff") {
      console.log(`Now logging off from directory: ${name}`);
      blank = readline.question("Press space to continue...");
      console.clear();
      adminnnn = false;
      loggingOff = true;
    }

    //R.P.S
    else if (choice == "r.p.s") {

playing = true;

console.log("\n\n\n---ROCK, PAPER, SCISSORS---");
console.log(" --2020 Terminal Edition--");

//Rock, Paper, Scissors session
while (playing) {
    console.clear();
    console.log(`ROUND ${round}!`);
    console.log(`W: ${win} - L: ${losses}`);

    console.log("Rock, Paper Scissors?");
    
    var playerHand = readline.question("-> ").toLowerCase();
    console.log("\n");

    var randomNumber = parseInt(Math.random() * 3);

    if (randomNumber == 0) {
        var computerHand = "rock";
    }
    else if (randomNumber == 1) {
        var computerHand = "paper";
    }
    else if (randomNumber == 2) {
        var computerHand = "scissors";
    }

    console.log(`Computer chooses ${computerHand}!\n`);

    if (playerHand == computerHand) {
        console.log("Tie!");
    }
    else if (playerHand == "rock") {
        if (computerHand == "paper"){
            console.log("You lose! Paper covers rock!\n");
            losses++
        }
    else {
        console.log("You win! Rock crushes scissors!\n");
        win++
    }
    }
else if (playerHand == "paper") {
    if (computerHand == "scissors") {
        console.log("You lose! Scissors cuts paper!\n");
        losses++
    }
    else {
        console.log("You win! Paper covers rock!\n");
        win++;
    }
}
else if (playerHand == "scissors") {
    if (computerHand == "rock") {
        console.log("You lose! Rock crushes scissors!\n");
        losses++
    }
    else {
        console.log("You win! Scissors cuts paper!\n");
        win++;
    }
}
else {
    console.log("You typed something wrong, dummy...\n");
}


console.log("\nPlay again?");
var choice = readline.question("-> ");
console.log("\n");

if (choice == "no" || choice == "No") {
  console.log(`W: ${win} - L: ${losses}`);
    playing = false;
    loggingOff = true;
}
else {
    round++;
}

console.log();
}
    //Heads or Tails
    }
    else if (choice == "h.t") {

      var randomNumber = Math.floor(Math.random() * 2 + 1)

Playing = true;

while (Playing) {
    var answer = (readline.question("heads or tails: "));

    if (answer == "heads") {
        if (randomNumber == 1) {
            console.log("Correct! It is heads!\n")
            var choice = readline.question("Do you want to play again?: ");

            if (choice == "yes" || choice == "Yes") {
                console.log("Reloading game...\n\n");
            }
            else if (choice == "no" || choice == "No") {
                console.log("\nEnding game...");
                Playing = false;
            }
        }
        else {
            console.log("INCORRECT! It is NOT heads, It was tails.");

            choice = readline.question("Do you want to play again?: ");

            if (choice == "yes" || choice == "Yes") {
                console.log("Reloading game...\n\n");
            }
            else if (choice == "no" || choice == "No") {
                console.log("\nEnding game...");
                Playing = false;
            }
        }
        
    }
    else if (answer == "tails") {
        if (randomNumber == 2) {
            console.log("Correct! It is tails!\n");
            
             choice = readline.question("Do you want to play again?: ");

            if (choice == "yes" || choice == "Yes") {
                console.log("Reloading game...\n\n");
            }
            else if (choice == "no" || choice == "No") {
                console.log("\nEnding game...")
                Playing = false;
            }
        }
        else {
            console.log("INCORRECT! It is NOT tails, It was heads.");

            choice = readline.question("Do you want to play again?: ");

            if (choice == "yes" || choice == "Yes") {
                console.log("Reloading game...\n\n");
            }
            else if (choice == "no" || choice == "No") {
                console.log("\nEnding game...")
                Playing = false;
            }
        }
    }
    else {
        console.log(`${answer} is not defined, please try again...`);
    }

}
    }
    else if (choice == "dark story") {
      //Answers
var friend = readline.question("\nEnter a name: ");
var robber = readline.question("Enter another name: ");
var money = readline.question("Enter a number: ");
var weapon = readline.question("Enter a weapon: ");
console.clear();

//The story
console.log("--- MONEY PROBLEM ---")
console.log();

console.log(`I got $${money} on me right now.`)
console.log(`I was with my friend ${friend} and we went to the bank at the 21st street.`);
console.log(`When suddenly, another dude named ${robber} ran up to me with a gun.`);
console.log(`And he told me to give him all of your $${money} to him or I will die.`);
console.log(`You gave him the money that you have but...`);
console.log(`You grab your ${weapon} and attempted to attack ${robber} and he died.`);
console.log("And you grab your cash and walks away with no mercy.")
console.log();
var blank = readline.question("Press space to continue...");
adminnnn = false;
loggingOff = true;
console.clear();

console.log("The end...");
var blank = readline.question("Press space to continue...");
adminnnn = false;
    }
    //Branching
  else if (choice == "branching") {
    console.clear()
    var age = parseInt(readline.question("Enter your age: "));

if (age >= 16) {
  console.log("You are old enough to drive!\n");
  var blank = readline.question("Press space to continue...");
  adminnnn = false;
  loggingOff = true;
}
else if (age == 15) {
  console.log("You can't drive on your own yet so don't think about stealing someone car yet.\n");
  var blank = readline.question("Press space to continue...");
  adminnnn = false;
  loggingOff = true;
}
else {
  console.log("I'm sorry, but you are not old enough to drive yet.\n");
  var blank = readline.question("Press space to continue...");
  adminnnn = false;
  loggingOff = true;
}
  }
  //atm
  else if (choice == "atm") {
console.log("\n--- ATM Demo ---\n");
var balance = parseFloat(readline.question("Set your initial balance: $"));
console.clear();
atmmmm = true;

while (atmmmm) {
console.log("The Mazeo ATM");
console.log("------------------------");
console.log("Select an option: ");
console.log("1) View Balance");
console.log("2) Deposit");
console.log("3) Withdraw");
console.log("4) Exit");

var option = readline.question("Enter your option (1,2,3,4): ");
console.log("\n");

if (option == "1") {
  console.log(`Your balance is $${balance}.`);
}
else if (option == "2") {
  var deposit = parseInt(readline.question("How much would you like to deposit? $"));
  balance = balance + deposit;
  console.log(`Thank you for your deposit of $${deposit}.`);
  console.log(`Your balance is now $${balance}.`);
}
else if (option == "3") {
  var withdraw = parseInt(readline.question("How much would you like to withdraw? $"));
  balance = balance - withdraw
  console.log(`Thank you for your withdraw of $${withraw}.`);
  console.log(`Your balance is now $${balance}.`);
}
else if (option == "4") {
  console.log("Exiting...\n\n\n");
  atmmmm = false;
  adminnnn = false;
  loggingOff = true;
}
else {
  console.log("Invalid option. Exiting...\n\n\n");
  atmmmm = false;
  adminnnn = false;
  loggingOff = true;
}
}
  }
  else if (choice == "logic") {
    console.log(`Is my name David? ${name == "David"}`);
    console.log(`Is my name Davie? ${name == "Davie"}`);
    console.log(`My name is not Davy: ${name != "Davy"} `);
    
    console.log(`Am I old enough to drive? ${age >= 16}`);
    console.log(
      `Do I have enough to buy a Dodge Challenger? ${bankAccount > 31000}`
    );
    
    console.log(`${name} is a teacher: ${isATeacher == true}`);
    console.log(`${name} is a millionaire: ${isAMillionaire}`);
    console.log(`So, ${name} isn't a millionaire? ${!isAMillionaire}`);
    var ekekedeid = readline.question("Press Space To Continue...");
    console.log("\n\n");
    adminnnn = false;
    loggingOff = true;
  }
  else if (choice == "drinks") {
    console.log("\nTime to sing a song...\n");

var soda = readline.question("Enter your favorite soda?: ");
console.clear();
var numBottles = 99;

while (numBottles > 0) {
    console.log(`${numBottles} bottles of ${soda} on the wall,`);
    console.log(`${numBottles} bottles of ${soda}`);
    console.log("You take one down, pass it around.");
    numBottles--
    console.log(`${numBottles} bottles of ${soda} on the wall!\n`);
  
}
var eieieieieuqwuu = readline.question("Press Space To Continue...");
console.log("\n\n\n");
adminnnn = false;
loggingOff = true;
  }
  else if (choice == "order food") {
    var orderingFood = true;

console.log("\n\n\n-- Crangis McBasketball Order To Go --\n");

while (orderingFood) {
    console.log("-Entrees-");
    console.log("1) Crangis McNuggets");
    console.log("2) JaCrispy Chicken Sandwich");
    console.log("3) Burger With McBasketball Sauce");
    console.log("4) Exit/Complete Order\n");

    var choice = readline.question("Enter an option: ");

    if (choice == "1") {
        console.log("Placing order for one Crangis McNugget\n");
    } 
    else if (choice == "2") {
        console.log("Placing order for one JaCrispy Chicken Sandwich.\n");
    }
    else if (choice == "3") {
        console.log("Placing order for one Burger with McBasketball sauce.\n");
    }
    else if (choice == "4") {
        var time = parseInt(Math.random() * 50 + 10);
        console.log(`Your order has been placed! It will be ready in ${time} minutes.\n`);
        orderingFood = false;
      var eooeeooeoeoe = readline.question("Press Space To Continue...");
      adminnnn = false;
      loggingOff = true;
    }
    else {
        console.log("Invalid option. Please try again...\n")
    }
}
  }
  //Boring Math
  else if (choice == "math") {
    console.log("\nI have 10$, I somehow found a lost wallet that has 7038$ so I decide to keep it for myself, How much do I have in total?")
console.log(7038 + 10);
console.log();

console.log("I have 200$ and I just made 35.76$ out of my paycheck today, How much do I have in total?");
console.log(200 + 35.76);
console.log();

console.log("I'm 15 year old. In months, that's:");
console.log(15 * 12);
console.log();

console.log("I'm starving right now so I went to subway and spend 9.48$ on a subway plus a extra dollar for a medium drink, How much did I spent in total?");
console.log(1.00 + 9.48);
console.log();

console.log("I bought pizza for myself.");
console.log("I ate ___ slices, How much slices did I ate?");
console.log(12 / 2);
console.log();

console.log("I have to split this dollar between the six of us. We each get: ");
console.log(10 / 6);
console.log();

console.log("After splitting up the dollar, how many cents are left over?");
console.log(100 % 6);
console.log();

console.log("6 * 15 + 5 equals:");
console.log(6 * 15 + 5);
console.log("4 * (10 + 12) equals:");
console.log(4 * (10 + 12));
console.log("\n");

var eiucuawdi = readline.question("Press Space To Continue...");
console.log("\n\n\n");
adminnnn = false;
loggingOff = true;
  }
  //Miles to Kilometers
  else if (choice == "m-to-k" || choice == "m.to.k") {
    console.log("--- Miles to kilometers Calculator ---\n");
var miles = parseFloat(readline.question("Enter miles value: "));

console.log(`${miles} miles = ${miles * 1.609344} kilometers`);
console.log("\n");
var eoeoeoeoeoeosjauuw = readline.question("Press Space To Exit Back To Admin Console...");
console.log("\n\n\n");
  }
  //rpg
  else if (choice == "rpg") {
      console.clear();

      console.log("--Menu--");
console.log("1) attack");
console.log("2) run");

var choice = readline.question("-> ");

if (choice == "1" || choice == "attack") {
  var playerAttack = parseInt(Math.random() * 10);
  var enemyAttack = parseInt(Math.random() * 10);

  enemyHealth = enemyHealth - playerAttack
  playerHealth = playerHealth - enemyAttack

  console.log(`You did ${playerAttack} damage!`);
  console.log(`Enemy has ${enemyHealth} health left.\n`);
  console.log(`Enemy did ${enemyAttack} damage!`);
  console.log(`You have ${playerHealth} health left.\n`);
  }
else if (choice == "2" || choice == "run") {
  console.log(`You escape like a big baby...`);
  escaped = true
}
else {
  console.log("Invalid option. Exiting battle...")
  var hehehehe = readline.question("Press Space To Exit Game...");
  console.clear();
}

if (escaped) {
  console.log("Bye bye! Back home to Mommy.");
  var hehehehe = readline.question("Press Space To Exit Game...");
  console.clear();
}
else if (playerHealth > enemyHealth) {
  console.log("You are beating the enemy!");
  var hehehehe = readline.question("Press Space To Exit Game...");
  console.clear();
}
else if (enemyHealth > playerHealth) {
  console.log("Be careful, the enemy is beating you!");
  var hehehehe = readline.question("Press Space To Exit Game...");
  console.clear();
}
else {
  console.log("Battle is tied!");
  var hehehehe = readline.question("Press Space To Exit Game...");
  console.clear();
}

    
  }
  else if (choice == "input") {
    console.clear();
    var namm = readline.question("! What's your name? My name's Colton!: ");
    console.log(`${namm}, that's fun to say! ${namm}, ${namm}...`);
    console.log();
    
    var answer =  readline.question("Does someone need a hug? ");
    console.log(`${answer}!? I just wanted a hug!`);
    console.log();
    
    var favoriteColor = readline.question(`Yo ${namm}, what's your favorite color? `);
    console.log(`Nice choice! ${favoriteColor} is a really nice color choice to choose from!`);
    var nolaniscrazy = readline.question("Press Space To Exit To Admin Console...");
    console.log("\n\n"); 
  }
  else if (choice == "sus") {
    var samchoice = readline.question("Hmmmm, Who's sus? (Type in any name) -> ");
    var howsus = parseInt(Math.random() * 10 + 2);
    console.log();
    console.log(`${samchoice} is ${howsus}% sus.\n`);
    var eieiieieuequiqiqwi = readline.question("Press space to exit to admin console...");
    console.log("\n\n\n\n");
    }
  else {
    console.log(`${choice} is not in our admin directory, Please try again.\n`.yellow);
    }
    
    
  }
  
  if (loggingOff) {
    console.log("Now logging off...")
    console.log("Exiting Program...");
    console.log("\nMicrosoft Windows [Version 10.0.22000.493]");
    console.log("(c) Microsoft Corporation. All rights reserved.\n")
    commandPrompt = true;
  }
  while (commandPrompt) {
  //Normal command line.

    var answer = readline.question(`C:/Users/${name}/%Appdata%/roaming/admin/> `);
    console.log("\n")
  
    if (answer == "node") {
      //node command
      console.log("Welcome to Node.js v16.14.0");
      console.log("Type '.help' for more information.")
    nodeJs = true;
    commandPrompt = false;
    }
    else if (answer == "exit") {
      console.log("REPL Terminated...\n");
      console.log("This Project is made by COLTON MAZEY from class of 2025!!!\n\n");  
      commandPrompt = false;
    }
    else if (answer == "help") {
      console.log("node");
      console.log("help");
      console.log("exit\n");
    }
    else {
      console.log(`'${answer}' is not recognized as an internal or exernal command,`);
      console.log("operable program or batch file.\n");
    }
      //Node Command Prompt
    while (nodeJs) {
      var nodeanswer = readline.question("> ");
      
      if (nodeanswer == ".help") {
        console.log("\n.help  Print this help message");
        console.log(".exit  Exit the REPL");
        console.log(".admin Opens the Admin Console");
      }
      else if (nodeanswer == ".exit") {
        nodeJs = false;
      }
      else if (nodeanswer == ".admin") {
        console.log("Starting up program: 'admin.js!'")
        console.log(".");
        console.log(".");
        console.log(".");
        console.log("------------------------------------------------------------------------------------\n");
        console.log(`Error while loading 'ADMIN LOGIN' Directory: 'C:/users/${name}/node/admin/login'.\n`);
      }
      else if (nodeanswer == ".about") {
        console.log("This 'fake' command line aka repl was coded by Colton Mazey '25.");
        console.log("Admin command line was developed by Colton Mazey '25'.");
      }
      else {
        console.log(`Uncaught ReferenceError: ${nodeanswer} is not defined`);
      }
      //end
    }
  
    
  }
    }
    else {
        console.log("Request terminated\n");
    }
  }
  else if (cmdanswer == "crazy") {
    var crazyanswer = parseInt(readline.question("How crazy are you? -> "));

    console.log(`\n${name} is ${crazyanswer * 1.0}% crazy!\n`);

    if (crazyanswer < 0) {
      console.log("Oh, you are crazy... um, ok..")
    }
    else if (crazyanswer >= 10) {
      console.log("Welcome to the crazy club!\n");
    }
    
    else {
      console.log();
    }
  }
  else if (cmdanswer == "about") {
    console.log("\nThis reimagine REPL is compiled by 'COLTON MAZEY' from the class of 2025!\n");
  }
  else if (cmdanswer == "sleepy") {
    console.log("\nColton is a sleepy head.");
  }
  else if (cmdanswer == "clear") {
    console.clear();
  }
  else if (cmdanswer == "play") {
    console.clear();

    var playanswer = readline.question("Do you want to check out the play? (yes, no) -> ");

    if (playanswer == "yes") {
      console.log("\nThe play is called 'The 25th Annual Putnam County Spelling Bee'!")
      console.log("The play starts thorugh November 17 to November 22 from 7:00 PM to 10:00 PM!\n");
      var playcredits = readline.question("Do you want to check out the play credits? (yes, no) -> ");

      if (playcredits == "yes") {
        console.log("\nComing soon...\n");
      }
      else {
        console.log();
      }
      
    }
    else {
      console.log("Request Terminated..\n\n".red);
    }
  }
  else {
    console.log(`\n${cmdanswer} : The term '${cmdanswer} is not recognized as the name of a cmd, function, script file, or operable program. Please check the spelling or use the help command to see all the available commands.`.red);
    console.log(`+ ${cmdanswer}`.red);
    console.log("+ ~~~\n".red);
    console.log(`  + CategoryInfo     : ObjectNotFound: (${cmdanswer}:string) , CommandNotFoundException`.red);
    console.log("  + FullyQualifiedErrorId : CommandNotFoundException\n".red);

  }






}



//LAST UPDATED 11/13/2022, 11:44 AM