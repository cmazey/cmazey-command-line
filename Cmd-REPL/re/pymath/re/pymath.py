import math
import os
import time

usrTest = True
num1 = 0
num2 = 0
numTotal = 0
cmazeyPylicator = True

# This command line is used for fun rather than Cmazey Calculator which is used for my AP Project.
# I hope you enjoy this, but don't forget, this is the most basic version for a 'terminal calculator'.
# Anyways, here's my useless code, and have a great day/night/evening etc!

os.system('cls')
print("------- CMAZEY PYLICATOR -------")
print("Type '/help' to see all available commands!\n")

while cmazeyPylicator:
    CPinput = input("|-> ".lower())
    # Addition
    if CPinput == "addition" or CPinput == "+":
        print("\n---\n")
        usrInput = input("[?] + ? = ? -> ")
        while usrTest:
            try:
                num1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input(f"{num1} + [?] = ? -> ")
        while usrTest:
            try:
                num2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        numTotal = num1+num2
        print(f"{num1} + {num2} = {numTotal}")
        print("\n---\n")
    # Help
    elif CPinput == "/help" or CPinput == "help":
        print("\n- Addition (+)")
        print("- Subtraction (-)")
        print("- Multiplication (x*)")
        print("- Division (/)")
        print("- InchesToHeight (IToH)")
        print("- LineSlope (ls)")
        print("- Exit\n")
    # Subtraction
    elif CPinput == "subtraction" or CPinput == "-":
        print("\n---\n")
        usrInput = input("[?] - ? = ? -> ")
        while usrTest:
            try:
                num1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input(f"{num1} - [?] = ? -> ")
        while usrTest:
            try:
                num2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        numTotal = num1 - num2
        print(f"{num1} - {num2} = {numTotal}")
        print("\n---\n")
    # Multiplication
    elif CPinput == "multiplication" or CPinput == "x" or CPinput == "*":
        print("\n---\n")
        usrInput = input("[?] x ? = ? -> ")
        while usrTest:
            try:
                num1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input(f"{num1} x [?] = ? -> ")
        while usrTest:
            try:
                num2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        numTotal = num1 * num2
        print(f"{num1} x {num2} = {numTotal}")
        print("\n---\n")
    # Division
    elif CPinput == "division" or CPinput == "/":
        print("\n---\n")
        usrInput = input("[?] / ? = ? -> ")
        while usrTest:
            try:
                num1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input(f"{num1} / [?] = ? -> ")
        while usrTest:
            try:
                num2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        numTotal = num1/num2
        print(f"{num1} / {num2} = {numTotal}")
        print("\n---\n")
    # HeightToInches
    elif CPinput == "inchestoheight" or CPinput == "itoh":
        print("\n---\n")
        usrInput = input("Enter a number: ")
        while usrTest:
            try:
                num1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        foot = int(num1 / 12)
        inches = num1 % 12
        print(f"{foot}ft, {inches}in")
        print("\n---\n")
    # LineSlope
    elif CPinput == "lineslope" or CPinput == "ls":
        print("\n---\n")
        usrInput = input("x1: ")
        while usrTest:
            try:
                x1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input("y1: ")
        while usrTest:
            try:
                y1 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input("x2: ")
        while usrTest:
            try:
                x2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        usrInput = input("y2: ")
        while usrTest:
            try:
                y2 = int(usrInput)
                break
            except:
                print("Invalid input, please try again...")
                usrInput = input("-> ")
        slope = (y2-y1)/(x2-x1)
        print(f"({x1}, {y1}) ({x2}, {y2}) == {slope}")
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


