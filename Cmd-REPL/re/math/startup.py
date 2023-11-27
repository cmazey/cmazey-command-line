import os
import sys
import time
import subprocess


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
    time.sleep(1.1)
    sys.stdout.write("\r" + animation[i % len(animation)])
    sys.stdout.flush()

print("\n")
print("REPL LOADED! Please hold...")
time.sleep(3)
print("ENJOY MATH Y'ALL NERDS!")



time.sleep(0.5)

os.system('cls')
time.sleep(2)

os.chdir('rere')
subprocess.call('dotnet run mathcmd.cs', shell=False)