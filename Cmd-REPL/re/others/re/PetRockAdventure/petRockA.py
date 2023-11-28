import os
import time
import subprocess

time.sleep(3)
print()

subprocess.call('cls', shell=True)
time.sleep(1)
os.system('petRockAdventure.exe')

print("\n\nPress enter to continue...")
input()