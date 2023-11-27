import os
import time
import itertools
import threading
import sys
import subprocess
lessons = True

original_directory = os.getcwd()

print("LESSONS")
time.sleep(2)

while lessons:
    print("javascript (.JS)")
    time.sleep(0.1)
    print("csharp (C#)")
    time.sleep(0.1)
    ans = input("-> ")

    if ans == "javascript":
        print("Input selected: JavaScript (.JS)")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            os.chdir('re/js')
            os.system('python javascript.py')

            lessons = False
        else:
            print("Input canceled.\n")

    elif ans == "csharp":
        print("Input selected: C Sharp (C#)")
        Confirming = input("Continue? (y/n) -> ")

        if Confirming == "y":
            os.chdir('re/cs')
            os.system('python csharp.py')

            lessons = False
        else:
            print("Input canceled.\n")

    else:
        print("Invalid input, please try again.\n")

os.chdir(original_directory)
print()

done = False

def animate():
    for c in itertools.cycle(['|', '/', '-', '\\']):
        if done:
            break
        sys.stdout.write('\rTransfering back to "ccl.py", please hold... ' + c)
        sys.stdout.flush()
        time.sleep(0.1)
t = threading.Thread(target=animate)
t.start()

time.sleep(5)
done = True



