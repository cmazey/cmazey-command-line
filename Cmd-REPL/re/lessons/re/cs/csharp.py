import os
import time
lessons = True

os.system('cls')
print("C SHARP LESSONS (C#)")
time.sleep(2)

print("- 1.1 (Hello World)")
time.sleep(0.1)
print("MORE COMING SOON")
time.sleep(1)
print("\nType in 'help' to see all the lessons/commands showned above.")

while lessons:
    lessonAns = input("-> ")

    if lessonAns == "help":
         time.sleep(1)
         print("C SHARP LESSONS")
         print("- 1.1 (Hello World)")
         time.sleep(1)
         print("\nHELPFUL COMMANDS")
         print("- help")
         print("- crntdir")
         print("- exit\n")
         time.sleep(1)


    elif lessonAns == "1.1":
         os.chdir('1.1')
         os.system('dotnet run main.cs')
         os.system('cls')
    

    # Helpful Cmds
    elif lessonAns == "crntdir":
         print("CURRENT DIRECTORY: ", os.getcwd())
         print()
    elif lessonAns == "exit":
         print("Exiting, thanks for checking out my lessons project!")
         lessons = False
    else:
         print(f"{lessonAns} not founded. Please check your spelling, or type in 'help' to see all available commands!\n")
