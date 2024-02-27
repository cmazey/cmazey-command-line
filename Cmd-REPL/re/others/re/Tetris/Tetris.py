from time import sleep
import itertools
import threading
import sys
import subprocess

print("----- TETRIS -----\n")

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rLoading necessary files ' + c)
        sys.stdout.flush()
        sleep(0.1)
    sys.stdout.write('\rLoading Repl completed!')
t = threading.Thread(target=animate)
t.start()

sleep(2)
done = True

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rLoading GUI ' + c)
        sys.stdout.flush()
        sleep(0.1)
    sys.stdout.write('\rGUI HAS BEEN LOADED!')
t = threading.Thread(target=animate)
t.start()

sleep(4.3)
done = True

print("\n\nCONTROLS: \n [ARROW UP] - Rotates \n [ARROW DOWN] - Move blocks down faster \n [ARROW LEFT] - Move Block Left \n [ARROW RIGHT] - Move Block Right\n")
sleep(0.4)

try:
    subprocess.call('python tet.py', shell=False)
except:
    subprocess.call('python3 tet.py', shell=True)

print("\nProgram has been terminated, please press enter to continue, or close the terminal.")
input()