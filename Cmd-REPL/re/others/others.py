import os
import time
others = False
Tetris = False
FlappyBird = False
petRock = False
import itertools
import threading
import sys
import subprocess

original_directory = os.getcwd()

print('\033[1m' + "OTHERS" + '\033[0m')
time.sleep(2)
others = True
NumGuess = False

while others:
    print("- GuessNum")
    time.sleep(0.1)
    print("- Tetris")
    time.sleep(0.1)
    print("- 2.5")
    time.sleep(0.1)
    print("- FlappyBird")
    time.sleep(0.1)
    print("- petRockAdventure")
    time.sleep(0.1)
    print("- Pygame (Installing pygame modules)")
    time.sleep(0.1)
    print("- (More coming soon...)")
    time.sleep(0.1)
    otherAns = input("-> ")

    if otherAns == "GuessNum":
        print("OTHER:: GuessNum")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            others = False
            NumGuess = True
            subprocess.call('cls', shell=True)
        else:
            print("Prompt Canceled\n")
    elif otherAns == "Tetris":
        print("OTHER:: Tetris")
        Confirming = input("Continue? (y/n) -> ")
        if Confirming == "y":
            others = False
            Tetris = True
            subprocess.call('cls', shell=True)
        else:
            print("Prompt Canceled\n")
    elif otherAns == "2.5":
        subprocess.call('cls', shell=True)
        os.chdir('re/2.5')
        os.system('dotnet run program.cs')

        print("\n\nPress enter to continue...")
        input()

        subprocess.call('cls', shell=True)
        os.chdir(original_directory)

        print('\033[1m' + "OTHERS" + '\033[0m')
        time.sleep(2)
        print("- exit")
        time.sleep(0.1)
    elif otherAns == "FlappyBird":
        print("OTHER:: Flappy Bird")
        Confirming = input("Continue? (y/n) -> ")
        if Confirming == "y":
            others = False
            FlappyBird = True
            subprocess.call('cls', shell=True)
        else:
            print("Prompt Canceled\n")
    elif otherAns == "petRockAdventure":
        print("OTHER::petRockAdventure")
        Confirming = input("Continue? (y/n) -> ")
        if Confirming == "y":
            others = False
            petRock = True
        else:
            print("Undefined prompt, please try again.\n")
    elif otherAns == "Pygame":
        print("\nAre you sure that you want to install the Pygame modules.")
        Confirming = input("(y/n) -> ")
        if Confirming == "y":
            subprocess.call('pip install pygame', shell=False)
            time.sleep(1)
            print("PYGAME module has been installed, press the enter key to continue")
            input()
            subprocess.call('cls', shell=True)
        else:
            print("")


    elif otherAns == "exit":
        others = False
        exit = True
    else:
        print("Undefined prompt, please try again.\n")

if NumGuess:
    time.sleep(3)

    os.chdir('re/GuessNum/bin/Debug/net6.0')
    subprocess.call('guessnum', shell=False)
    os.chdir(original_directory)

elif Tetris:
    time.sleep(3)

    os.chdir('re/Tetris')
    subprocess.call('python Tetris.py', shell=False)
    os.chdir(original_directory)

elif FlappyBird:
    time.sleep(3)

    os.chdir('re/FlappyBird')
    subprocess.call('python fb.py', shell=False)
    os.chdir(original_directory)

elif petRock:
    os.chdir('re/petRockAdventure')
    subprocess.call('python petRockA.py', shell=False)
    os.chdir(original_directory)


elif exit:
    print("Prompt executing, please for checking out others program!\n")
    time.sleep(2)

done = False

print()
print()
print()

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rTransfering back to "ccl.py", please hold... ' + c)
        sys.stdout.flush()
        time.sleep(0.1)
t = threading.Thread(target=animate)
t.start()

time.sleep(4)
done = True

    
