import os
import time
import subprocess
lessons = True

original_directory = os.getcwd()

subprocess.call('cls', shell=True)
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
         subprocess.call('cls', shell=True)

         time.sleep(2)
         os.chdir('1.1')
         subprocess.call('node ./index', shell=False)

         print("\nPress enter to continue...")
         input()
         subprocess.call('cls', shell=True)
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