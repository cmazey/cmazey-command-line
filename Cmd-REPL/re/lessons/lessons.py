import os
import time
lessons = True
print("LESSONS")
time.sleep(2)

while lessons:
    print("javascript (.JS)")
    time.sleep(0.1)
    print("csharp (C#)")
    time.sleep(0.1)
    ans = input("-> ")

    if ans == "javascript":
        print("Input selected: JavaScript (.JS)")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            print()
        else:
            print("Input canceled.\n")

    elif ans == "csharp":
        print("Input selected: C Sharp (C#)")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            print()
        else:
            print("Input canceled.\n")

    else:
        print("Invalid input, please try again.\n")