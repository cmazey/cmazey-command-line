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


print("MIT License\n")
time.sleep(0.1)
print("Copyright (c) 2022 Colton Mazey")
time.sleep(0.1)
print("\nPermission is hereby granted, free of charge, to any person obtaining a copy")
print("of this software and associated documentation files (the 'Software'), to deal")
print("in the Software without restriction, including without limitation the rights")
print("to use, copy, modify, merge, publish, distribute, sublicense, and/or sell")
print("copies of the Software, and to permit persons to whom the Software is")
print("furnished to do so, subject to the following conditions:")
time.sleep(1)
print("\nThe above copyright notice and this permission notice shall be included in all")
print("copies or substantial portions of the Software.")
time.sleep(1)
print("\nTHE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR")
print("IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,")
print("FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE")
print("AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER")
print("LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,")
print("OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE")
print("SOFTWARE.")
time.sleep(1)
print("Do you agree to the terms above? (yes, no): ")
terms = input("-> ")

if terms == "yes":
    Agreed = True
else:
    print("Canceling program...")

if Agreed:
    print("Permission granted, please hold...")
    time.sleep(3)

    os.system('cls')

    print("CMAZEY COMMAND LINE")
    time.sleep(2)
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
        print("Coming soon...")
    elif ans == "lessons":
        print("Coming soon...")
    else:
        print("Invalid prompt...")


if pyPrompt:
    os.system('cls')
    print("CMAZEY COMMAND LINE: PYTHON EDITION")
    time.sleep(1)
    print("Please hold...")
    time.sleep(3)

    os.chdir('re/py')
    os.system('python startup.py')

elif nodePrompt:
    os.system('cls')
    print("CMAZEY COMMAND LINE: NODE.JS EDITION")
    time.sleep(1)
    print("Please hold...")
    time.sleep(5)

    os.chdir('re/node')
    os.system('python startup.py')

elif mathPrompt:
    os.system('cls')
    print("CMAZEY MATH COMMAND (C#)")
    time.sleep(1)
    print("Please hold...")
    time.sleep(5)

    os.chdir('re/math')
    os.system('python startup.py')









        
        

