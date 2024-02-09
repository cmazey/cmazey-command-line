import math
import os
import time

num1 = 0
num2 = 0
numTotal = 0
cmazeyPylicator = True
document_path = os.path.expanduser('~/Documents')

# This command line is used for fun rather than Cmazey Calculator which is used for my AP Project.
# I hope you enjoy this, but don't forget, this is the most basic version for a 'terminal calculator'.
# Anyways, here's my useless code, but anyways, have a great day/night/evening etc!

os.system('cls')
print("------- CMAZEY PYLICATOR -------")
print("Type '/help' to see all available commands!\n")

while cmazeyPylicator:
    CPinput = input("|-> ".lower())
    # addition
    if CPinput == "addition" or CPinput == "+":
        print("\n---\n")
        num1 = int(input("[?] + ? = ? -> "))
        num2 = int(input(f"{num1} + [?] = ? -> "))
        numTotal = num1 + num2
        print(f"{num1} + {num2} = {numTotal}")
        print("\n---\n")
    # help
    elif CPinput == "/help" or CPinput == "help":
        print("\n- Addition (+)")
        print("- Subtraction (-)")
        print("- Multiplication (x*)")
        print("- Division (/)")
        print("- InchesToHeight (IToH)")
        print("- Exit\n")
    # subtraction
    elif CPinput == "subtraction" or CPinput == "-":
        print("\n---\n")
        num1 = int(input("[?] - ? = ? -> "))
        num2 = int(input(f"{num1} - [?] = ? -> "))
        numTotal = num1 - num2
        print(f"{num1} - {num2} = {numTotal}")
        print("\n---\n")
    # multiplication
    elif CPinput == "multiplication" or CPinput == "x" or CPinput == "*":
        print("\n---\n")
        num1 = int(input("[?] x ? = ? -> "))
        num2 = int(input(f"{num1} x [?] = ? -> "))
        numTotal = num1 * num2
        print(f"{num1} x {num2} = {numTotal}")
        print("\n---\n")
    # Division
    elif CPinput == "division" or CPinput == "/":
        print("\n---\n")
        num1 = int(input("[?] / ? = ? -> "))
        num2 = int(input(f"{num1} / [?] = ? -> "))
        numTotal = num1 / num2
        print(f"{num1} / {num2} = {numTotal}")
        print("\n---\n")
    # HeightToInches
    elif CPinput == "inchestoheight" or CPinput == "itoh":
        print("\n---\n")
        num1 = int(input("Enter a number: "))
        foot = int(num1 / 12)
        inches = num1 % 12
        print(f"{foot}ft, {inches}in")
        print("\n---\n")
    # More Commands Coming soon
    
    # exit
    elif CPinput == "exit":
        print("Exiting program, thanks for checking out Cmazey Pylicator!")
        time.sleep(3)
        cmazeyPylicator = False
    # Invalid
    else:
        print("\nInvalid command, please try again...\n")


