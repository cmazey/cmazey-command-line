import time
import os
clear = False
Commandline = False


checkup = input("Are you sure you want to proceed? (yes) -> ")

if checkup == "yes":
    print("\nPlease hold...")
    time.sleep(10)
    os.system('cls')
    clear = True
else:
    print("\nRequest Terminated...\n\n")

while(clear):
    time.sleep(1)
    print("-- WINDOWS COMMAND LINE *Python Version* --")
    time.sleep(0.1)
    print("REPL RECREATED BY COLTON MAZEY AKA 'CMAZEY'\n")
    time.sleep(2)
    print("WARNING: This recreated command line is NOT finished, This command line will be constantly updated, please check the Github site to check for recent updates, thanks!")
    time.sleep(1)
    print("Version: PRE ALPHA: V1.0.0")
    time.sleep(3)
    print()
    time.sleep(1)
    name = input("Please enter your username: ")
    time.sleep(1)
    print(f"Username entered: {name}\n")
    print("Creating REPL, please hold...")
    time.sleep(8)
    print()
    time.sleep(0.1)
    print()
    time.sleep(0.1)
    print()
    time.sleep(0.1)

    os.system('cls')
    time.sleep(5)

    print("Microsoft Windows [Version 10.0.22000.493]")
    print("(c) Microsoft Corporation. All rights reserved.")
    time.sleep(2)
    print()
    time.sleep(1)

    Commandline = True

    while(Commandline):
        cmdanswer = input(f"C:/Users/{name}> ")

        if cmdanswer == "help":
            time.sleep(1)
            print("\nhelp")
            print("sad")
            print("test")
            print("clear")
            print("More coming soon..")
            time.sleep(2)
            print()
            time.sleep(1)
        elif cmdanswer == "test":
            print("\nThis is a test...\n")
        elif cmdanswer == "sad":
            print()
            time.sleep(1)
            print("Someone named Braedon had made me sad because he was given the role to use the sound effect and yeah. : ( ")
            time.sleep(3)
            print()
            time.sleep(1)
        elif cmdanswer == "clear":
            os.system('cls')
            time.sleep(1)
            print("Microsoft Windows [Version 10.0.22000.493]")
            print("(c) Microsoft Corporation. All rights reserved.")
            time.sleep(1)
            print()
            time.sleep(0.1)
        elif cmdanswer == "play":
                print("coming soon...")
        else:
            print()











