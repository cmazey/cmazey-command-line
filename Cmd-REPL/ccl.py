import os
from time import sleep
import itertools
import threading
import sys
import pyfiglet
import subprocess
import platform
from datetime import datetime
Agreed = False
deBug = False
termsNotice = False
Prompt = False
deBugNoLogs = False
dBugPrompt = False
version = "v1.2.1 (PRE v1.5.1)" # Make sure to change version number before publishing changes!!!


# This detects if you are on a window computer that's trying to run this directly (you can't, use the exe file provided LOOOL)
# v Delete this if you want to run the Python File in Windows (overwise, run the exe file that's included) v
if platform.system() == "Linux":
    print("LINUX DETECTED")
    try:
        os.chdir('Cmd-REPL')
    except:
        pass
else:
    try:
        os.chdir('Cmd-REPL')
    except:
        print("Woah dude, you can't run this exe file here, run the other one lmao")
        input()
        sys.exit()

original_directory = os.getcwd()

# ------- Delete **session files** if detected ------

# mathcmd debug
try:
    os.chdir('re/math/rere/bin/Debug/net6.0/Resources')
    os.remove('CCLIGNORESTARTUP.txt')
    print("[../Debug/net6.0/Resources] : 'CCLIGNORESTARTUP.txt DELETED")
except:
    print("[../Debug/net6.0/Resources] : Skipped")
os.chdir(original_directory)
# mathcmd release
try:
    os.chdir('re/math/rere/Release/net6.0/Resources')
    os.remove('CCLIGNORESTARTUP.txt')
    print("[../Release/net6.0/Resources] : 'CCLIGNORESTARTUP.txt DELETED")
except:
    print("[../Release/net6.0/Resources] : Skipped")
os.chdir(original_directory)
# others session
try:
    os.chdir('re/others')
    os.remove('CCLIGNORESTARTUP.txt')
    print("[../re/others] : 'CCLIGNORESTARTUP.txt DELETED")
except:
    print("[./re/others] : Skipped")
os.chdir(original_directory)

sleep(0.5)
subprocess.run('cls', shell=True)
        
# Startup Proceeder
print("Welcome!")
sleep(0.1)
print("Current directory:", os.getcwd())
sleep(0.1)

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rloading ' + c)
        sys.stdout.flush()
        sleep(0.1)
t = threading.Thread(target=animate)
t.start()

sleep(5)
done = True

subprocess.run('clear', shell=True)
subprocess.run('cls', shell=True)

# EULA AGREEMENT
print('\033[1m' + "EULA AGREEMENT\n" + '\033[0m')
print("Type in `terms` to see the EULA terms. To agree to the terms, and continue, type in `yes` with NO CAPS.")
termsNotice = True
terms = input("-> ")
while termsNotice:
    if terms == "yes":
        termsNotice = False
        Agreed = True
    elif terms == "terms":
        print("End-User License Agreement (EULA)\n")
        print("This End-User License Agreement ('EULA') is a legal agreement between you and Colton Dog")
        print("Portraits.\n")
        sleep(0.1)
        print("This EULA agreement governs your acquisition and use of our Cmazey Command Line software")
        print("('Software') directly from Colton Dog Portraits or indirectly through a Colton Dog Portraits authorized")
        print("reseller or distributor (a 'Reseller'). Anything it says below, you don't have to follow.\n")
        sleep(0.1)
        print("Please read this EULA agreement carefully before completing the installation process and using the")
        print("Cmazey Command Line software. It provides a license to use the Cmazey Command Line software")
        print("and contains warranty information and liability disclaimers.\n")
        sleep(0.1)
        print("If you are entering into this EULA agreement on behalf of a company or other legal entity, you")
        print("represent that you have the authority to bind such entity and its affiliates to these terms and")
        print("conditions. If you do not have such authority or if you do not agree with the terms and conditions of")
        print("this EULA agreement, do not install or use the Software, and you must not accept this EULA")
        print("agreement.\n")
        sleep(0.1)
        print("This EULA agreement will not apply only to the Software supplied by Colton Dog Portraits herewith")
        print("regardless of whether other software is referred to or described herein. The terms doesn't also apply")
        print("to any Colton Dog Portraits updates, supplements, Internet-based services, and support services for the")
        print("Software, unless other terms accompany those items on delivery. If so, those terms apply.\n")
        sleep(0.1)
        print('\033[1m' + "License Grant\n" + "\033[0m")
        sleep(0.1)
        print("Software, unless other terms accompany those items on delivery. If so, those terms apply.")
        print("the Cmazey Command Line software on your devices in accordance with the terms of this EULA")
        print("agreement.\n")
        sleep(0.1)
        print("You are permitted to load the Cmazey Command Line software (for example a PC, laptop, mobile or")
        print("tablet) under your control. You are responsible for ensuring your device meets the minimum")
        print("requirements of the Cmazey Command Line software.\n")
        sleep(0.1)
        print('\033[1m' + "You are totally not permitted to:\n" + '\033[0m')
        sleep(0.1)
        print("- use the Software for any purpose that Colton Dog Portraits considers is a breach of this EULA agreement")
        print("- Use the Software in any way which breaches any applicable local, national or international law\n")
        sleep(0.1)
        print('\033[1m' + "Intellectual Property and Ownership\n" + '\033[0m')
        sleep(0.1)
        print("Colton Dog Portraits doesn't retain ownership of the Software as originally downloaded by")
        print("you and all subsequent downloads of the Software by you. The Software (and the copyright, and")
        print("other intellectual property rights of whatever nature in the Software, including any modifications")
        print("made thereto) are and shall remain the property by no one.\n")
        sleep(0.1)
        print('\033[1m' + "Termination\n" + '\033[0m')
        sleep(0.1)
        print("This EULA agreement is never effective/enforced from the date you first use the Software and shall continue until")
        print("terminated. You may terminate it at any time upon written notice to Colton Dog somethings.\n")
        sleep(0.1)
        print("It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon")
        print("such termination, the licenses granted by this EULA agreement won't immediately terminate and you")
        print("don't have to agree to stop all access and use of the Software. The provisions that by their nature")
        print("continue and survive will survive any termination of this EULA agreement.\n")
        sleep(0.1)
        print('\033[1m' + "Governing Law\n" + '\033[0m')
        sleep(0.1)
        print("This EULA agreement, and any dispute arising out of or in connection with this EULA agreement,")
        print("shall be governed by and construed in accordance with the laws of no one.\n")
        sleep(1)
        print("To agree to the terms, type in 'yes' with NO CAPS.")
        terms = input("-> ")
    elif terms == "dbug":
        termsNotice = False
        deBug = True
    elif terms == "dbugnoloogs" or terms == "dbugn/l":
        termsNotice = False
        deBugNoLogs = True
    else:
        termsNotice = False
        os.chdir('re/others/re/um')
        try:
            subprocess.run('noeula.vbs', shell=True)
            print("EULA NOT ACCEPTED, terminating program...")
        except:
            print("EULA NOT ACCEPTED, terminating program...")
            sleep(5)

if Agreed:
    print('\033[92m' + "PERMISSION GRANTED" + '\033[0m' + ", please hold...")
    sleep(3)
    print('\033[93m')
    subprocess.run('cls', shell=True)
    
    CCLresult = pyfiglet.figlet_format("Cmazey Command Line", font = "slant") 

    print('\033[1m' + CCLresult + '\033[0m')
    print("Type 'help' to show all available commands!\n")
    Prompt = True
    
# CCL (CMAZEY COMMAND LINE INTERFACE)
while Prompt:
    cclInput = input("---> ")

    # help cmd
    if cclInput == "/help" or cclInput == "help":
        print("\n-- MODULES --")
        print("- Math: Cmazey Calculator")
        print("- Node: Command Line in Javascript")
        print("- Others: Additional Projects that I had worked on. (for fun)")
        print("- Py: command line using python")
        print("- Lessons: Temp Disabled\n")
        print("-- Additional Cmds --")
        print("- figlet")
        print("- Directory (dir): Show the current directory")
        print("- Clear: Clear the terminal output")
        print("- Version: Fetch the current version")
        print("- Exit\n")

    # ------ Cmazey Calculator ------
    # math
    elif cclInput == "math" or cclInput == "ccmath":
        print("NOTE: YOU ARE SWITCHING FROM 'CCL' to 'CMAZEY CALCULATOR'")
        promptInput = input("Do you want to continue? (y/n) -> ")

        if promptInput == "y":
            try:
                os.chdir("re/math")
                try:
                    subprocess.run('python startup.py', shell=False)
                except:
                    subprocess.run('python startup.py', shell=True)
                print("\n")
            except FileNotFoundError:
                print("Err: This error occured because it couldn't find the directory. Please ensure that you are in the 'Cmd-REPL' directory.")
                print("DIRECTORY: ", os.getcwd())
                sleep(3)
            except:
                print("\nAn unknown error has been occured, please report it to my discord server. Thanks!\n", sys.exc_info())
                sleep(3)
            os.chdir(original_directory)
        else:
            print("Prompt canceled...\n")
    # math (skipped prompt)
    elif cclInput == "math -y" or cclInput == "ccmath -y":
        try:
            os.chdir("re/math")
            try:
                subprocess.run('startup.exe', check=True, shell=False)
            except subprocess.runedProcessError:
                    try:
                        subprocess.run('python startup.py', shell=False)
                    except:
                        subprocess.run('python3 startup.py', shell=True)
        except FileNotFoundError:
                print("Err: This error occured because it couldn't find the directory. Please ensure that you are in the 'Cmd-REPL' directory.")
                print("DIRECTORY: ", os.getcwd())
                os.chdir(original_directory)
                sleep(3)
        except:
            print("\nAn unknown error has been occured, please report it to my discord server. Thanks!\n", sys.exc_info())
            sleep(3)
        os.chdir(original_directory)
        os.chdir("\n")
    # math (without startup)
    elif cclInput == "math -w -r -o" or cclInput == "math --s" or cclInput == "ccmath -w -r -o" or cclInput == "ccmath --s":
        print()
        # Head to Release/Debug Directory
        try:
            os.chdir('re/math/rere/bin/Releas/net6.0/')
        except FileNotFoundError:
            os.chdir(original_directory)
            try:
                os.chdir('re/math/rere/bin/Debug/net6.0/')
            except FileNotFoundError:
                print("ERROR: Release/Debug builded not founded.\n", sys.exc_info())
        except:
            print("An unknown error has been occured, please report it to my discord sever.\n", sys.exc_info())
            os.chdir(original_directory)
            sleep(2)
        
        # This will only work if you are using a Linux machine (distro/cloud shell/etc)
        if platform.system() == "Linux":
            try:
                os.chdir(original_directory)
                os.chdir('re/math/rere')
                subprocess.run('dotnet build', check=True, shell=True)
                os.chdir('bin/Debug/net6.0/Resources')
                f = open("CCLIGNORESTARTUP.txt", "w")
                f.write("This file is used to bypass the startup proceeder in Cmazey Calculator (aka mathcmd.cs). This file will be deleted when session has ended...")
                f.close()
                os.chdir('../../../..')
                subprocess.run('dotnet run', shell=True)
                os.chdir('bin/Debug/net6.0/Resources')
                os.remove('CCLIGNORESTARTUP.txt')
                os.chdir(original_directory)
            except subprocess.runedProcessError as e:
                # This would catch an exception if it couldn't compiled a new build
                print(f"An error has been occured, you will need Microsoft DotNet 6.0, and 7.0 for it to work properly.\n")
                sleep(3)
                os.chdir(original_directory)
            except:
                print("An unknown error has been occured, please report it to my Discord Server.\n", sys.exc_info())
                sleep(2)
                pass
        # (Windows) Create a '.txt' file, and writing it
        else:
            try:
                os.chdir('Resources')
                f = open("CCLIGNORESTARTUP.txt", "w")
                f.write("This file is used to bypass the startup proceeder in Cmazey Calculator (aka mathcmd.cs). This file will be deleted when session has ended...")
                f.close()
                os.chdir('..')
                # Running the executable file
                subprocess.run('mathcd', check=True, shell=True)
                os.chdir('Resources')
                os.remove('CCLIGNORESTARTUP.txt')
                os.chdir(original_directory)
                print("\n")
            except subprocess.runedProcessError:
                print("\nErr: Subprocess can't find/run 'mathcmd.exe'. Run 'math --dbug' to compile a new build.\n")
                os.chdir(original_directory)
                sleep(3)
                pass
            except:
                continue
    # math debug
    elif cclInput == "math --dbug" or cclInput == "ccmath --dbug":
        print("\n")
        os.chdir('re/math/rere')
        try:
            subprocess.run('dotnet run', check=True, shell=True)
        except subprocess.runedProcessError as e:
            print("\nAn error has been occured, this occured because you don't have Microsoft DotNet 6.0, and 7.0 installed in your operating system.")
            sleep(2)
            pass
        except:
            print("An unknown error has been occured... Please report it in my discord server, or open a GitHub Request.\n" + sys.exc_info())
            sleep(2)
            pass
        os.chdir(original_directory)
        print("\n")
   
    # ----------- node --------------
    # node
    elif cclInput == "node":
        print("NOTE: YOU ARE SWITCHING FROM 'CCL' to 'CCL: node'")
        promptInput = input("Do you want to continue? (y/n) -> ")

        if promptInput == "y":
            try:
                os.chdir("re/node")
                try:
                    subprocess.run('python startup.py', check=True, shell=False)
                except subprocess.runedProcessError:
                    subprocess.run('python3 startup.py', shell=True)
                os.chdir(original_directory)
                print("\n")
            except FileNotFoundError:
                print("Err: This error occured because it couldn't find the directory. Please ensure that you are in the 'Cmd-REPL' directory.")
                print("DIRECTORY: ", os.getcwd())
                os.chdir(original_directory)
                sleep(3)
            except:
                print("\nAn unknown error has been occured, please report it to my discord server. Thanks!\n", sys.exc_info())
                sleep(3)
        else:
            print("Prompt canceled...\n")
    # node -y
    elif cclInput == "node -y":
        try:
            os.chdir("re/node")
            try:
                subprocess.run('python startup.py', shell=False)
            except:
                subprocess.run('python startup.py', shell=True)
            os.chdir(original_directory)
            print("\n")
        except FileNotFoundError:
                print("Err: This error occured because it couldn't find the directory. Please ensure that you are in the 'Cmd-REPL' directory.")
                print("DIRECTORY: ", os.getcwd())
                os.chdir(original_directory)
                sleep(3)
        except:
            print("\nAn unknown error has been occured, please report it to my discord server. Thanks!\n", sys.exc_info())
            sleep(3)

    # ----------- py ----------------
    # py
    elif cclInput == "py":
        print("NOTE: YOU ARE SWITCHING FROM 'CCL' to 'CCL: py'")
        promptInput = input("Do you want to continue? (y/n) -> ")

        if promptInput == "y":
            os.chdir("re/py")
            try:
                subprocess.run('startup.exe', shell=False)
            except:
                try:
                    subprocess.run('python startup.py', shell=False)
                except:
                    subprocess.run('python3 startup.py', shell=True)
            os.chdir(original_directory)
            print("\n")
        else:
            print("Prompt canceled...\n")
    # py -y
    elif cclInput == "py -y":
        os.chdir("re/py")
        try:
            subprocess.run('python startup.py', check=True, shell=False)
        except subprocess.CalledProcessError:
            subprocess.run('python3 startup.py', shell=True)
        except:
            print("An error has been occured, please ensure that you are within the 'Cmd-REPL' directory. If it's past 'Cmd-REPL', then please let me know ASAP via Discord/GitHub")
            print("DIRECTORY: " + os.getcwd())
            sleep(3)
        os.chdir(original_directory)
        print("\n")
    # py directly
    elif cclInput == "py -w -r -o" or cclInput == "py --s":
        print()
    
    # --------- others --------------
    # other
    elif cclInput == "other" or cclInput == "others":
        print("NOTE: YOU ARE SWITCHING FROM 'CCL' to 'CCL: node'")
        promptInput = input("Do you want to continue? (y/n) -> ")

        if promptInput == "y":
            os.chdir("re/others")
            try:
                subprocess.run('python others.exe', check=True, shell=False)
            except subprocess.CalledProcessError:
                try:
                    subprocess.run('python others.py', check=True, shell=False)
                except subprocess.CalledProcessError:
                    try:
                        subprocess.run('python3 others.py', check=True, shell=True)
                    except subprocess.CalledProcessError:
                        print("An error has been occured, please ensure that you are in the 'Cmd-REPL' directory. If it's past 'Cmd-REPL', then please report to me ASAP via Discord/GitHub.\nDirectory: " + os.getcwd() + "\n")
            os.chdir(original_directory)
            print("\n")
        else:
            print("Prompt canceled...\n")
    # others -y
    elif cclInput == "other -y" or cclInput == "others":
        os.chdir("re/others")
        try:
            subprocess.run('others.exe', shell=False)
        except:
            try:
                subprocess.run('python others.py', shell=False)
            except:
                subprocess.run('python3 others.py', shell=True)
        os.chdir(original_directory)
        print("\n")
    # others directly
    elif cclInput == "other -w -r -o" or cclInput == "other --s" or cclInput == "others -w -r -o" or cclInput == "others --s":
        os.chdir('re/others')
        f = open("CCLIGNORESTARTUP.txt", "w")
        f.write("This file is used to bypass the startup proceeder in CCL: other. This file will be deleted when session has ended...")
        f.close()
        print("\n[REDIRECTED] : CCL ----> OTHERS")
        try:
            subprocess.run('python others.py', shell=False)
        except:
            subprocess.run('python3 others.py', shell=True)
        os.remove('CCLIGNORESTARTUP.txt')
        os.chdir(original_directory)
    # others flappybird
    elif cclInput == "other --flappybird" or cclInput == "others --flappybird" or cclInput == "other --bird":
        print("\n[REDIRECTED] : 'CCL' ---> 'Others : FlappyBird\n")
        os.chdir("re/others/re/FlappyBird")
        try:
            subprocess.run('python fb.py', shell=False)
        except:
            subprocess.run('python fb.py', shell=True)
        os.chdir(original_directory)
        print("\n")
    # others: Tetris
    elif cclInput == "other --tetris" or cclInput == "others --tetris":
        print("\n[REDIRECT] : 'CCL' ---> 'Others : Tetris'\n")
        os.chdir("re/others/re/Tetris")
        try:
            subprocess.run('python Tetris.py', shell=False)
        except:
            subprocess.run('python3 Tetris.py', shell=True)
        os.chdir(original_directory)
        print("\n")
    # others: PswdGenrtr
    elif cclInput == "other --pswdgenrtr" or cclInput == "others --pswdgenrtr" or cclInput == "other --passwd":
        print("\n[REDIRECTED] 'CCL' ---> 'Others : PswdGenrtr'\n")
        os.chdir('re/others/re/PswdGenrtr')
        try:
            subprocess.run("pass.exe", Pass=True, shell=False)
        except subprocess.CalledProcessError:
            try:
                subprocess.run('pass.py', Pass=True, shell=False)
            except subprocess.CalledProcessError:
                try:
                    subprocess.run('python3 pass.py', shell=True)
                except subprocess.CalledProcessError:
                    print("An error has occured, while opening the file. Please check, and see if you are in 'Cmd-REPL', if you are past Cmd-REPL, please report the issue to me via GitHub or Discord.\nCUrrent Directory: " + os.getcwd() + "\n")
        except:
            print("An unknown error has occured. Please report the issue to me via Github or Discord.\n" + sys.exc_info())
        os.chdir(original_directory)
        print("\n")
    # others: PetRockAdventure
    elif cclInput == "other --petrockadventure" or cclInput == "others --petrockadventure":
        print("\n[REDIRECTED] 'CCL' ---> 'Others : PetRockAdventure'\n")
        os.chdir('re/others/re/PetRockAdventure')
        try:
            subprocess.run("petRockA.exe", shell=False)
        except:
            try:
                subprocess.run('petRockA.py', shell=False)
            except:
                subprocess.run('python3 petRockA.py', shell=True)
        os.chdir(original_directory)
        print("\n")
    # others: GuessNum
    elif cclInput == "other --guessnum" or cclInput == "others --guessnum":
        print("\n[REDIRECTED] 'CCL' ---> 'Others : GuessNum'\n")
        os.chdir('re/others/re/GuessNum')
        if platform.system == "Linux":
            try:
                subprocess.run('dotnet run', shell=True)
            except:
                print("An issue has been occured. You may need 'DotNet6.0'. Run 'sudo apt install dotnet-sdk-6.0', and 'sudo apt install dotnet-sdk-7.0' to install the necessary packages.\n")
                sleep(3)
                pass
        else:
            try:
                os.chdir('bin/Release/net6.0')
                subprocess.run('guessnum.exe', shell=False)
            except:
                print("Error")
        os.chdir(original_directory)
        print("\n")
                
    # others --h
    elif cclInput == "other --h" or cclInput == "others --h":
        print("\nYou can go directly to one of the small project using this subcommand.")
        print("\n'other --[MODULE]'\n")
        print("-- Available Modules --")
        print("- pymath")
        print("- PswdGenrtr")
        print("- PetRockAdventure")
        print("- GuessNum")
        print("- FlappyBird\n")

    # -------- lessons --------------
    # lessons
    elif cclInput == "lessons":
        print("lessons module disabled....") 
    # lessons -y
    elif cclInput == "lessons -y":
        print("lessons module disabled...")
    # lessons directly
    elif cclInput == "lessons -w -r -o" or cclInput == "lessons --s":
        print("lessons module disabled...")

    # ---- Additional Commands ------
    # Figlet
    elif cclInput == "figlet":
        usrOuput = input("Enter something -> ")
        result = pyfiglet.figlet_format(usrOuput)
        print("\n" + result + "\n")
    # clear
    elif cclInput == "clear":
        subprocess.run('clear', shell=True)
        subprocess.run('cls', shell=True)
    # version
    elif cclInput == "version":
        print(f"\nCCL Version: {version}\n")
    # current directory
    elif cclInput == "dir" or cclInput == "directory":
        print("\nCurrent Path: '" + os.getcwd() + "'\n")
    # Invalid command but has '-h' in it
    elif "-h" in cclInput:
        print("\nThis subcommand is used for additional information about said command/module that you input in.\n")
        print("FORMAT: [Command/Module] -h\n")
    # exit
    elif cclInput == "exit":
        print("Thanks for trying out Cmazey Command Line, see ya later!")
        sleep(3)
        Prompt = False


# debug option
if deBug:
    subprocess.run('cls', shell=True)

    if not os.path.exists('./debugs'):
        os.mkdir('./debugs')
        os.chdir('debugs')
    else:
        os.chdir('debugs')
    
    sleep(1)

    if os.path.exists('debugLogs.txt'):
        f = open("debugLogs.txt", "a")
        sleep(1)
        f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Debug panel has been opened.")
        sleep(0.5)
        f.close()
    else:
        f = open("debugLogs.txt", "w")
        sleep(0.5)
        f.write("---- CCL DEBUG LOGS ----\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Debug panel has been created and opened")
        sleep(0.5)
        f.close()


    print("CMAZEY COMMAND LINE DEBUG")
    sleep(0.5)
    print("\nnode")
    print("py")
    print("math")
    print("other")
    print("lessons\n")
    print("crntdir")
    print("del")
    print("exit")

    print()
    dBugPrompt = True

    while dBugPrompt:
        dBugg = input("---> ")

        if dBugg == "node":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: node")
            sleep(0.5)
            f.close()
            os.chdir(original_directory)
            
            os.chdir('re/node/rere')
            try:
                subprocess.run('node ./nodecmd.js', shell=False)
            except:
                subprocess.run('node ./nodecmd.js', shell=True)

            os.chdir(original_directory)
            os.chdir('debugs')
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Terminating following prompt: node")
            sleep(0.5)
            f.close()

        elif dBugg == "help":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following command: help")
            sleep(0.5)
            f.close()

            print("\nnode")
            print("py")
            print("math")
            print("other")
            print("lessons")
            print("crntdir")
            print("del")
            print("exit")

        elif dBugg == "py":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: pycmd")
            sleep(0.5)
            f.close()
            os.chdir(original_directory)

            os.chdir('re/py/rere')

            if not os.path.exists('./debugs'):
                os.mkdir('./debugs')
            else:
                sleep(0.5)

            try:
                subprocess.run('python pycmd.py', shell=False)
            except:
                subprocess.run('python pycmd.py', shell=True)
            f.close()

            os.chdir(original_directory)
            os.chdir('debugs')
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Terminating following prompt: pycmd")
            sleep(0.5)
            f.close()

        elif dBugg == "math":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: math")
            sleep(0.5)
            f.close()
            os.chdir(original_directory)

            os.chdir('re/math/rere')
            try:
                subprocess.run('dotnet run mathcmd.cs', shell=False)
            except:
                subprocess.run('dotnet run mathcmd.cs', shell=True)

            os.chdir(original_directory)
            os.chdir('debugs')
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Closing following prompt: math")
            sleep(0.5)
            f.close()

        elif dBugg == "other":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: others")
            sleep(0.5)
            f.close()
            os.chdir(original_directory)

            os.chdir('re/others')
            try:
                subprocess.run('python others.py', shell=False)
            except:
                subprocess.run('python others.py', shell=True)

            os.chdir(original_directory)
            os.chdir('debugs')
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Terminating following prompt: others")
            sleep(0.5)
            f.close()

        elif dBugg == "lessons":
            print("- csharp (C#)")
            print("- javascript (.JS)")
            lessonsPrompt = input("-> ")

            if lessonsPrompt == "csharp":
                f = open("debugLogs.txt", "a")
                sleep(1)
                f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: lessons:cs")
                sleep(0.5)
                f.close()      
                os.chdir(original_directory)


                os.chdir('re/lessons/re/cs')
                subprocess.run('python csharp.py', shell=False)

                os.chdir(original_directory)
                os.chdir('debugs')
                f = open("debugLogs.txt", "a")
                sleep(1)
                f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Terminating following prompt: lessons:cs")
                sleep(0.5)
                f.close()      
                

            elif lessonsPrompt == "javascript":
                f = open("debugLogs.txt", "a")
                sleep(1)
                f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following prompt: lessons:js")
                sleep(0.5)
                f.close()      
                os.chdir(original_directory)

                os.chdir('re/lessons/re/js')
                subprocess.run('python javascript.py', shell=False)

                os.chdir(original_directory)
                os.chdir('debugs')

                f = open("debugLogs.txt", "a")
                sleep(1)
                f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Terminating following prompt: lessons:js")
                sleep(0.5)
                f.close()      

            else:
                print("Invalid prompt, canceled...\n")

        elif dBugg == "crntdir":
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> Running following command: crntdir")
            sleep(0.5)
            f.close()      
            print("Current directory: '" + os.getcwd() + "'\n")
        
        elif dBugg == "exit":
            print("Exiting debug mode...")
            sleep(5)
            f = open("debugLogs.txt", "a")
            sleep(1)
            f.write("\n<CLL:DEBUG::" + datetime.now().strftime('%d-%m-%Y %H:%M:%S') + "::> debug panel terminated")
            sleep(0.5)
            f.close()      
            os.chdir(original_directory)
            dBugPrompt = False

        elif dBugg == "clear" or dBugg == "cls":
            subprocess.run("cls", shell=True)

        elif dBugg == "del":
            print("Are you sure that you want to delete Pswd Results, and any Debug Directorys?")
            doubleCheck = input("(y/n) -> ")

            if doubleCheck == "y":
                os.chdir(original_directory)
                os.chdir('re/others/re/PswdGenrtr/Result')
                if os.path.exists("PassGenResult.txt"):
                    os.remove("PassGenResult.txt")
                    print("PassGenResult.txt Deleted")
                else:
                    print()
                sleep(2)
                os.chdir(original_directory)
                os.chdir("debugs")
                if os.path.exists("debugLogs.txt"):
                    os.remove("debugLogs.txt")
                    print("debugLogs.txt Deleted")
                else:
                    print()
                sleep(2)
                os.chdir(original_directory)
                os.rmdir("debugs")
                print("debug directory Deleted")
                sleep(4)

                print("\nPress enter to exit terminal, thank you for checking out Cmazey Command Line!")
                input()
                dBugPrompt = False

            else:
                print("Prompt canceled...\n")

        else:
            print("Invalid prompt, please try again.\n")

# debug option but with no logs
if deBugNoLogs:
    subprocess.run('cls', shell=True)
    sleep(1)
    print("CMAZEY COMMAND LINE: DEBUG PANEL (NO LOGS)\n")

    print("\nnode")
    print("py")
    print("math")
    print("other")
    print("lessons")
    print("pymath")
    print("crntdir")
    print("exit\n")

    deBugNoLogsPrompt = True

    while deBugNoLogsPrompt:
            dBugg = input("--> ")

            if dBugg == "node":
                os.chdir('re/node/rere')
                try:
                    subprocess.run('node ./nodecmd.js', shell=False)
                except:
                    subprocess.run('node ./nodecmd.js', shell=True)
                os.chdir(original_directory)

            elif dBugg == "help":
                print("\nnode")
                print("py")
                print("math")
                print("other")
                print("lessons")
                print("crntdir")
                print("exit\n")

            elif dBugg == "py":
                os.chdir('re/py/rere')
                try:
                    subprocess.run('python pycmd.py', shell=False)
                except:
                    subprocess.run('python pycmd.py', shell=True)
                os.chdir(original_directory)

            elif dBugg == "math":
                try:
                    os.chdir('re/math/rere')
                    try:
                        subprocess.run('dotnet run', shell=False)
                    except:
                        subprocess.run('dotnet run', shell=True)
                    os.chdir(original_directory)
                except:
                    print("An error has occured while attempting to run the file.")

            elif dBugg == "other":
                i = 0
                
                for i in range(50):
                    print(".")
                    sleep(0.1)
                    i = i + 1

                os.chdir('re/others')
                try:
                    subprocess.run('python others.py', shell=False)
                except:
                    subprocess.run('python others.py', shell=True)
                os.chdir(original_directory)

            elif dBugg == "lessons":
                print("- csharp (C#)")
                print("- javascript (.JS)")
                lessonsPrompt = input("-> ")

                if lessonsPrompt == "csharp":
                    os.chdir('re/lessons/re/cs')
                    subprocess.run('python csharp.py', shell=False)
                    os.chdir(original_directory)
    
                elif lessonsPrompt == "javascript":   
                    os.chdir('re/lessons/re/js')
                    subprocess.run('python javascript.py', shell=False)
                    os.chdir(original_directory)   

                else:
                    print("Invalid prompt, canceled...\n")

            elif dBugg == "crntdir":
                print("Current directory: '" + os.getcwd() + "'\n")
            
            elif dBugg == "pymath":
                os.chdir('re/pymath/re')
                try:
                    subprocess.run('python pymath.py', shell=False)
                except:
                    subprocess.run('python pymath.py', shell=True)
                os.chdir(original_directory)
            
            elif dBugg == "exit":
                Confirming = input("Are you sure that you want exit the debug panel? (y/n) -> ")

                if Confirming == "y":
                    print("Exiting debug mode...")
                    sleep(5)
                    deBugNoLogsPrompt = False
                else:
                    print("Prompt canceled\n")

            elif dBugg == "clear" or dBugg == "cls":
                subprocess.run("cls", shell=True)

            else:
                print("Invalid prompt, please try again.\n")
            
