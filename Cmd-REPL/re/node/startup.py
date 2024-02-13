from itertools import cycle
from shutil import get_terminal_size
from threading import Thread
from time import sleep
import os
import subprocess

print("NOTICE: The file that you are currently locating is not an executable file. This is a '.js' file, and you will need NODE.JS (LTS recommended)")
print("to run this file. If you already have NODE.JS installed on your window system, then type in the follow prompt below v\n")
print("i have nodejs installed")
Confirming = input("-> ")

if Confirming == "i have nodejs installed":
    print("\nPROMPT AGREED")
    sleep(2)
    print("LOADING COMPLETED")
    sleep(1)

    class Loader:
        def __init__(self, desc="Loading...", end="Loading Repl Completed", timeout=0.1):
            """
            A loader-like context manager

            Args:
                desc (str, optional): The loader's description. Defaults to "Loading...".
                end (str, optional): Final print. Defaults to "Done!".
                timeout (float, optional): Sleep time between prints. Defaults to 0.1.
            """
            self.desc = desc
            self.end = end
            self.timeout = timeout

            self._thread = Thread(target=self._animate, daemon=True)
            self.steps = ["⢿", "⣻", "⣽", "⣾", "⣷", "⣯", "⣟", "⡿"]
            self.done = False

        def start(self):
            self._thread.start()
            return self

        def _animate(self):
            for c in cycle(self.steps):
                if self.done:
                    break
                print(f"\r{self.desc} {c}", flush=True, end="")
                sleep(self.timeout)

        def __enter__(self):
            self.start()

        def stop(self):
            self.done = True
            cols = get_terminal_size((80, 20)).columns
            print("\r" + " " * cols, end="", flush=True)
            print(f"\r{self.end}", flush=True)

        def __exit__(self, exc_type, exc_value, tb):
            self.stop()

    if __name__ == "__main__":
        with Loader("Loading REPL..."):
            for i in range(10):
                sleep(0.25)

        loader = Loader("Preparing to open file, please hold...", "Completed. Please answer the following prompt below..", 0.05).start()
        for i in range(15):
            sleep(0.25)
        loader.stop()

    sleep(1.5)
    print()

    print("\nDo you want to install/update package files? (y/n)")
    Confirming = input("-> ")

    if Confirming == "y":

        os.chdir('rere')
        print("Installing/Updating 'readline-sync'")
        sleep(1)
        os.system('npm install readline-sync')

        sleep(1)

        print("\n\n Installing/Updating 'colors'")
        os.system('npm install colors')

        sleep(1)

        subprocess.call('cls', shell=True)

        print("\n\nPACKAGE FILES INSTALLED/UPDATED")
        sleep(0.5)
        print("Opening file...")
        sleep(3)

    else:
        os.chdir('rere')
        
        print("Opening file...")
        sleep(3)

    try:
        subprocess.call('node ./nodecmd.js', shell=False)

    except:
        print("Error has been occured while opening Node.JS file. Either package files aren't installed, or NODEJS isn't installed on your operating system.")
        input()

    print("Heading back to the start menu, please hold...")
    sleep(3)
else:
    print("Prompt Distrupted, heading back to main menu...")
    sleep(2)
