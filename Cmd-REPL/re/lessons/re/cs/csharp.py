import os
import time
lessons = True

original_directory = os.getcwd()

os.system('cls')
print("C SHARP LESSONS (C#)")
time.sleep(2)

print("- 1.1 (Hello World)")
time.sleep(0.1)
print("- 1.2 (Arithmetic)")
time.sleep(0.1)
print("- 1.3 (String Formatting)")
time.sleep(0.1)
print("- 1.4 (Variables)")
time.sleep(0.1)
print("- 1.5 (Manipulating Variables)")
time.sleep(0.1)
print("- 1.6 (Prompting for Input)")
time.sleep(0.1)
print("- 1.7 (Prompting for Numerical Input)")
time.sleep(0.1)
print("- 1.8 (Math and Random Methods)")
time.sleep(0.1)
print()
time.sleep(0.1)
print("- 2.1 (Logic Crash Course)")  
time.sleep(0.1)
print("- 2.2 (If Statements)")
time.sleep(0.1)
print("- 2.3 (Branching with Else If and Else)")
time.sleep(0.1)
print("- 2.4 (Compound Boolean Expressions)")
time.sleep(0.1)
print("- 2.5 (Nested If Statements)")
time.sleep(0.1)
print("- 2.6 (While Loops)")
time.sleep(0.1)
print("- 2.7 (Number Guessing Game)")
time.sleep(0.1)
print("- 2.8 (Rock, Paper, Scissors Game)")  
time.sleep(0.1)
print("- 2.10 (Nested For Loops - Multiplication Table)")
time.sleep(0.1)
print()
time.sleep(0.1)
print("- 3.1 (Arrays)")
time.sleep(0.1)
print("- 3.2 (Arrays and Loops)")
time.sleep(0.1)
print("- 3.3 (Lists)")
time.sleep(0.1)
print("- 3.4 (Foreach Loops)")
time.sleep(0.1)
print("- 3.5 (List Methods)")
time.sleep(0.1)
print()
time.sleep(0.1)
print("- 4.1 (Method Basics)")
time.sleep(0.1)
print("- 4.2 (Mathod Parameters)")
time.sleep(1)
print("\nType in 'help' to see all the lessons/commands showned above.")

while lessons:
    lessonAns = input("-> ")

    if lessonAns == "help":
         time.sleep(1)
         print("\nC SHARP LESSONS")
         time.sleep(1)

         print("Part 1 - Programming Basics")
         print("- 1.1 (Hello World)")
         print("- 1.2 (Arithmetic)")
         print("- 1.3 (String Formatting)")
         print("- 1.4 (Variables)")
         print("- 1.5 (Manipulating Variables)")
         print("- 1.6 (Prompting for Input)")
         print("- 1.7 (Prompting for Numerical Input)")
         print("- 1.8 (Math and Random Methods)")
         time.sleep(1)

         print("\nPart 2 - Control Flow: Selection and Iteration") 
         print("- 2.1 (Logic Crash Course)")  
         print("- 2.2 (If Statements)")
         print("- 2.3 (Branching with Else If and Else)")
         print("- 2.4 (Compound Boolean Expressions)")
         print("- 2.5 (Nested If Statements)")
         print("- 2.6 (While Loops)")
         print("- 2.7 (Number Guessing Game)")
         print("- 2.8 (Rock, Paper, Scissors Game)")  
         print("- 2.10 (Nested For Loops - Multiplication Table)")
         time.sleep(1)

         print("\nPart 3 - Data Structures") 
         print("- 3.1 (Arrays)")
         print("- 3.2 (Arrays and Loops)")
         print("- 3.3 (Lists)")
         print("- 3.4 (Foreach Loops)")
         print("- 3.5 (List Methods)")
         time.sleep(1) 

         print("\nPart 4 - Methods")
         print("- 4.1 (Method Basics)")
         print("- 4.2 (Method Parameters)\n")     
         time.sleep(1)
         print("\nHELPFUL COMMANDS")
         print("- help")
         print("- crntdir")
         print("- exit\n")
         time.sleep(1)

     # Part 1 - Programming Basics

    elif lessonAns == "1.1":
         os.system('cls')
         os.chdir('1.1')
         os.system('dotnet run main.cs')
         
         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "1.2":
         os.system('cls')
         os.chdir('1.2')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)
     
    elif lessonAns == "1.3":
         os.system('cls')
         os.chdir('1.3')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)
     
    elif lessonAns == "1.4":
         os.system('cls')
         os.chdir('1.4')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)
    
    elif lessonAns == "1.5":
         os.system('cls')
         os.chdir('1.5')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "1.6":
         os.system('cls')
         os.chdir('1.6')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "1.7":
         os.system('cls')
         os.chdir('1.7')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "1.8":
         os.system('cls')
         os.chdir('1.8')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

     # Part 2 - Control Flow: Selection and Iteration

    elif lessonAns == "2.1":
         os.system('cls')
         os.chdir('2.1')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.2":
         os.system('cls')
         os.chdir('2.2')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.3":
         os.system('cls')
         os.chdir('2.3')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.4":
         os.system('cls')
         os.chdir('2.4')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.5":
         print("Coming soon...\n")

    elif lessonAns == "2.6":
         os.system('cls')
         os.chdir('2.6')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.7":
         os.system('cls')
         os.chdir('2.7')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.8":
         os.system('cls')
         os.chdir('2.8')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "2.10":
         os.system('cls')
         os.chdir('2.10')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

     # Part 3 - Data Structures

    elif lessonAns == "3.1":
         os.system('cls')
         os.chdir('3.1')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "3.2":
         os.system('cls')
         os.chdir('3.2')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "3.3":
         os.system('cls')
         os.chdir('3.3')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "3.4":
         os.system('cls')
         os.chdir('3.4')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

    elif lessonAns == "3.5":
         os.system('cls')
         os.chdir('3.5')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)

     # Part 4 - Methods

    elif lessonAns == "4.1":
         os.system('cls')
         os.chdir('4.1')
         os.system('dotnet run main.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)
     
    elif lessonAns == "4.2":
         os.system('cls')
         os.chdir('4.2')
         os.system('dotnet run program.cs')

         print("\n\nPress enter to continue...")
         input()

         os.system('cls')
         os.chdir(original_directory)              


    # Helpful Cmds

    elif lessonAns == "crntdir":
         print("CURRENT DIRECTORY: ", os.getcwd())
         print()
    elif lessonAns == "exit":
         print("Exiting, thanks for checking out my lessons project!")
         lessons = False
    else:
         print(f"{lessonAns} not founded. Please check your spelling, or type in 'help' to see all available commands!\n")
