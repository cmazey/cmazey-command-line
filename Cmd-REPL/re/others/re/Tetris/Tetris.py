import os
import time
import itertools
import threading
import sys

print("TETRIS\n")

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rLoading necessary files ' + c)
        sys.stdout.flush()
        time.sleep(0.1)
    sys.stdout.write('\rLoading Repl completed!')
t = threading.Thread(target=animate)
t.start()

time.sleep(2)
done = True

time.sleep(0.1)
print()

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rLoading GUI ' + c)
        sys.stdout.flush()
        time.sleep(0.1)
    sys.stdout.write('\rGUI HAS BEEN LOADED!')
t = threading.Thread(target=animate)
t.start()

time.sleep(4.3)
done = True

time.sleep(1)
print("\n\nNote: if you are having some issues, please refer to the '" + os.getcwd() + "\Source.txt' for more info.\n")

os.system('python tet.py')

print("\nProgram has been terminated, please press enter to continue, or close the terminal.")
input()