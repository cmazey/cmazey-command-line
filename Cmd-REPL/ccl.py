import os
import time
import itertools
import threading
import sys
Agreed = False
Prompt = False
mathPrompt = False
nodePrompt = False
pyPrompt = False


print("Welcome!")
time.sleep(0.1)
print("Current directory:", os.getcwd())
time.sleep(0.1)

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rloading ' + c)
        sys.stdout.flush()
        time.sleep(0.1)
t = threading.Thread(target=animate)
t.start()

time.sleep(5)
done = True

os.system('cls')


print('\033[1m' + "End-User License Agreement (EULA)")
print("\033[0m")

print("This End-User License Agreement ('EULA') is a legal agreement between you and Colton Dog")
print("Portraits.\n")
time.sleep(0.1)
print("This EULA agreement governs your acquisition and use of our Cmazey Command Line software")
print("('Software') directly from Colton Dog Portraits or indirectly through a Colton Dog Portraits authorized")
print("reseller or distributor (a 'Reseller').\n")
time.sleep(0.1)
print("Please read this EULA agreement carefully before completing the installation process and using the")
print("Cmazey Command Line software. It provides a license to use the Cmazey Command Line software")
print("and contains warranty information and liability disclaimers.\n")
time.sleep(0.1)
print("If you are entering into this EULA agreement on behalf of a company or other legal entity, you")
print("represent that you have the authority to bind such entity and its affiliates to these terms and")
print("conditions. If you do not have such authority or if you do not agree with the terms and conditions of")
print("this EULA agreement, do not install or use the Software, and you must not accept this EULA")
print("agreement.\n")
time.sleep(0.1)
print("This EULA agreement shall apply only to the Software supplied by Colton Dog Portraits herewith")
print("regardless of whether other software is referred to or described herein. The terms also apply to any")
print("Colton Dog Portraits updates, supplements, Internet-based services, and support services for the")
print("Software, unless other terms accompany those items on delivery. If so, those terms apply.\n")
time.sleep(0.1)
print('\033[1m' + "License Grant\n" + "\033[0m")
time.sleep(0.1)
print("Software, unless other terms accompany those items on delivery. If so, those terms apply.")
print("the Cmazey Command Line software on your devices in accordance with the terms of this EULA")
print("agreement.\n")
time.sleep(0.1)
print("You are permitted to load the Cmazey Command Line software (for example a PC, laptop, mobile or")
print("tablet) under your control. You are responsible for ensuring your device meets the minimum")
print("requirements of the Cmazey Command Line software.\n")
time.sleep(0.1)
print('\033[1m' + "You are not permitted to:\n" + '\033[0m')
time.sleep(0.1)
print("- use the Software for any purpose that Colton Dog Portraits considers is a breach of this EULA agreement")
print("- Use the Software in any way which breaches any applicable local, national or international law\n")
time.sleep(0.1)
print('\033[1m' + "Intellectual Property and Ownership\n" + '\033[0m')
time.sleep(0.1)
print("Colton Dog Portraits shall at all times retain ownership of the Software as originally downloaded by")
print("you and all subsequent downloads of the Software by you. The Software (and the copyright, and")
print("other intellectual property rights of whatever nature in the Software, including any modifications")
print("made thereto) are and shall remain the property of Colton Dog Portraits.\n")
time.sleep(0.1)
print('\033[1m' + "Termination\n" + '\033[0m')
time.sleep(0.1)
print("This EULA agreement is effective from the date you first use the Software and shall continue until")
print("terminated. You may terminate it at any time upon written notice to Colton Dog Portraits.\n")
time.sleep(0.1)
print("It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon")
print("such termination, the licenses granted by this EULA agreement will immediately terminate and you")
print("agree to stop all access and use of the Software. The provisions that by their nature continue and")
print("survive will survive any termination of this EULA agreement.\n")
time.sleep(0.1)
print('\033[1m' + "Governing Law\n" + '\033[0m')
time.sleep(0.1)
print("This EULA agreement, and any dispute arising out of or in connection with this EULA agreement,")
print("shall be governed by and construed in accordance with the laws of us.\n")
time.sleep(1)
print("Do you agree to the EULA above? (yes, no): ")
terms = input("-> ")

if terms == "yes":
    Agreed = True
else:
    print("Canceling program...")

if Agreed:
    print('\033[92m' + "PERMISSION GRANTED" + '\033[0m' + ", please hold...")
    time.sleep(3)

    print('\033[93m')
    os.system('cls')
    
    print('\033[1m' + 'CMAZEY COMMAND LINE')
    print('\033[0m')
    time.sleep(2)
    print("- chngdir")
    time.sleep(0.1)
    Prompt = True

while Prompt:
    print("- node")
    time.sleep(0.1)
    print("- py")
    time.sleep(0.1)
    print("- math")
    time.sleep(0.1)
    print("- lessons")
    time.sleep(0.1)
    print("- other")
    time.sleep(0.1)
    ans = input("-> ")

    if ans == "node":
        print("Command Line Selected: 'node'")
        Confirming = input("Do you want to continue? (y/n)-> ")
        
        if Confirming == "y":
            Prompt = False
            nodePrompt = True
        else:
            print()
    
    elif ans == "py":
        print("Command Line Selected: py")
        Confirming = input("Do you want to continue? (y/n) -> ")

        if Confirming == "y":
            pyPrompt = True
            Prompt = False
        else:
            print()

    elif ans == "math":
        print("Command Line Selected: math (C#)")
        Confirming = input("Do you want to continue? (y/n) -> ")

        if Confirming == "y":
            Prompt = False
            mathPrompt = True
        else:
            print()
    elif ans == "other":
        print("Coming soon...\n")
    elif ans == "lessons":
        print("Coming soon...")
    elif ans == "chngdir":
      print("Are you sure you want to change the directory to Cmd-REPL? (y/n)")
      print('\033[91m' + "NOTE: THIS IS MEANT TO BE USED IN REPLIT", '\033[0m')
      Confirming = input("-> ")

      if Confirming == "y":
        os.chdir('Cmd-REPL')
        print("DIRECTORY CHANGED: ", os.getcwd())
        print()
      else:
        print("Prompt Canceled\n")    
    else:
        print("Invalid prompt...\n")


if pyPrompt:
    os.system('cls')
    print('\033[1m' + '\033[94m' + "CMAZEY COMMAND LINE: PYTHON EDITION", '\033[0m')
    time.sleep(1)
    print("Please hold...")
    time.sleep(3)

    os.chdir('re/py')
    os.system('python startup.py')

elif nodePrompt:
    os.system('cls')
    print('\033[1m' + '\033[93m' + "CMAZEY COMMAND LINE: NODE.JS EDITION", '\033[0m')
    time.sleep(1)
    print("Please hold...")
    time.sleep(5)

    os.chdir('re/node')
    os.system('python startup.py')

elif mathPrompt:
    os.system('cls')
    print('\033[1m' + '\033[96m' + "CMAZEY MATH COMMAND (C#)" + '\033[0m',)
    time.sleep(1)
    print("Please hold...")
    time.sleep(5)

    os.chdir('re/math')
    os.system('python startup.py')









        
        

