import os
import time
lessons = True

original_directory = os.getcwd()

os.system('cls')
print("JAVASCRIPT LESSONS (.JS)")
time.sleep(2)

print("- 1.1 (Output)")
time.sleep(0.1)
print("MORE COMING SOON")
time.sleep(1)
print("\nType in 'help' to see all the lessons/commands showned above.")

while lessons:
    lessonAns = input("-> ")

    if lessonAns == "help":
         time.sleep(1)
         print("JAVASCRIPT LESSONS:")
         print("- 1.1 (Output)")
         time.sleep(1)
         print("\nHELPFUL COMMANDS")
         print("- help")
         print("- crntdir")
         print("- exit\n")
         time.sleep(1)


    elif lessonAns == "1.1":
         os.system('cls')

         time.sleep(2)
         os.chdir('1.1')
         os.system('node ./index')

         print("\nPress enter to continue...")
         input()
         os.system('cls')
         os.chdir(original_directory)

         print("JAVASCRIPT LESSON (.JS)\n")
    

    # Helpful Cmds
    elif lessonAns == "crntdir":
         print("CURRENT DIRECTORY: ", os.getcwd())
         print()
    elif lessonAns == "exit":
         print("Exiting, thanks for checking out my lessons project!")
         lessons = False
    else:
         print(f"{lessonAns} not founded. Please check your spelling, or type in 'help' to see all available commands!\n")