import os
import time
others = False
Tetris = False
FlappyBird = False
import itertools
import threading
import sys

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
    print("- (More coming soon...)")
    time.sleep(0.1)
    otherAns = input("-> ")

    if otherAns == "GuessNum":
        print("OTHER:: GuessNum")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            others = False
            NumGuess = True
            os.system('cls')
        else:
            print("Prompt Canceled\n")
    elif otherAns == "Tetris":
        print("OTHER:: Tetris")
        Confirming = input("Continue? (y/n) -> ")
        if Confirming == "y":
            others = False
            Tetris = True
            os.system('cls')
        else:
            print("Prompt Canceled\n")
    elif otherAns == "2.5":
        os.system('cls')
        os.chdir('re/2.5')
        os.system('dotnet run program.cs')

        print("\n\nPress enter to continue...")
        input()

        os.system('cls')
        os.chdir(original_directory)

        print('\033[1m' + "OTHERS" + '\033[0m')
        time.sleep(2)
        print("- exit")
        time.sleep(0.1)
    elif otherAns == "FlappyBird":
        print("OTHER:: Flappy Bird")
        Confirming = input("Continue?(y/n) -> ")
        if Confirming == "y":
            others = False
            FlappyBird = True
            os.system('cls')
        else:
            print("Prompt Canceled\n")
    

    elif otherAns == "exit":
        others = False
        exit = True
    else:
        print("Undefined prompt, please try again.\n")

if NumGuess:
    time.sleep(3)

    os.chdir('re/GuessNum')
    os.system('dotnet run guessnum.cs')
    os.chdir(original_directory)

elif Tetris:
    time.sleep(3)

    os.chdir('re/Tetris')
    os.system('python Tetris.py')
    os.chdir(original_directory)

elif FlappyBird:
    time.sleep(3)

    os.chdir('re/FlappyBird')
    os.system('python fb.py')
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

    
