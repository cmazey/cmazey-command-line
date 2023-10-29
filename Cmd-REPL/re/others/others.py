import os
import time
others = False

print('\033[1m' + "OTHERS" + '\033[0m')
time.sleep(2)
others = True
NumGuess = False

while others:
    print("- GuessNum")
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
    
if NumGuess:
    time.sleep(3)

    os.chdir('re/GuessNum')
    os.system('dotnet run guessnum.cs')
    
