import os
import sys
import time
import subprocess
original_directory = os.getcwd()

print()
time.sleep(2)
print()
time.sleep(2)
print()
time.sleep(2)
print()
time.sleep(2)
print()
time.sleep(0.1)
print("LOADING COMPLETED")
time.sleep(1)
print("Loading Repl...")
animation = ["[■□□□□□□□□□]","[■■□□□□□□□□]", "[■■■□□□□□□□]", "[■■■■□□□□□□]", "[■■■■■□□□□□]", "[■■■■■■□□□□]", "[■■■■■■■□□□]", "[■■■■■■■■□□]", "[■■■■■■■■■□]", "[■■■■■■■■■■]"]

for i in range(len(animation)):
    time.sleep(0.4)
    sys.stdout.write("\r" + animation[i % len(animation)])
    sys.stdout.flush()

print("\n")
print("REPL LOADED! Please hold...")
time.sleep(3)
print("ENJOY MATH Y'ALL NERDS!")

time.sleep(0.5)

subprocess.call('cls', shell=True)
time.sleep(2)

try:
    os.chdir('rere/bin/Release/net6.0')

except OSError as e:
    print(f"An error has been occured:: {e}")
    print("\n\nChecking debug bin...")
    time.sleep(2)

    try:
        os.chdir("rere/bin/Debug/net6.0")
    except OSError as e:
        print("mathcmd cannot be located in the bin files.")
        
        print("Do you want to run the file? [.NET 6.0 IS REQUIRED] (y/n)")
        Confirming = input("-> ")

        if Confirming == "y":
            os.chdir(original_directory)
            os.chdir('rere')
            try:
                subprocess.call('dotnet run', shell=False)
            except:
                subprocess.call('dotnet run', shell=True)
        else:
            print("Application has been interupted, heading back to the main menu...")
            time.sleep(3)
               
try:
    subprocess.call('mathcmd', shell=False)
except subprocess.CalledProcessError:
        os.chdir(original_directory)
        os.chdir('rere')
        try:
            subprocess.call('dotnet run', shell=True)
        except:         
            print("This is just here cuz why not. Also if u see this, I kinda want to ask [BLANK] if she wanna hang out, idk")

