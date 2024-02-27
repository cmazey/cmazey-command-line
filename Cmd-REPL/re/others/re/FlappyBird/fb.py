from time import sleep
import subprocess
import sys

print("--- Flappy Bird ---")
sleep(1)

sleep(0.4)
try:
    subprocess.call('python Flappygame.exe', check=True, shell=False)
except subprocess.CalledProcessError:
    try:
        subprocess.call('python Flappygame.py', check=True, shell=False)
    except:
        subprocess.call('python3 Flappygame.py', check=True, shell=True)
except:
    print("An unknown error has been occured, please report it in my discord server, thxssss\n")
    sleep(3)

print("\nProgram has been terminated, please press enter to continue, or close the terminal.")
input()

