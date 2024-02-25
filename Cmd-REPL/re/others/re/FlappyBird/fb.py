import os
import time
import subprocess

print("Flappy Bird")

time.sleep(2)

print("Note: if you are having some issues, please refer to the '" + os.getcwd() + "\Source.txt' for more info.\n")
time.sleep(1)

subprocess.call('python Flappygame.py', shell=False)

print("\nProgram has been terminated, please press enter to continue, or close the terminal.")
input()

