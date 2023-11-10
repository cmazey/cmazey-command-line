from itertools import cycle
from shutil import get_terminal_size
from threading import Thread
from time import sleep
import os

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

    loader = Loader("Preparing to open file, please hold...", "Completed, install/updating package files", 0.05).start()
    for i in range(15):
        sleep(0.25)
    loader.stop()

sleep(1.5)
print()

os.chdir('rere')

print("Installing/Updating 'readline-sync'")
sleep(1)
os.system('npm install readline-sync')

sleep(1)

print("\n\n Installing/Updating 'colors'")
os.system('npm install colors')

sleep(1)

os.system('cls')

print("\n\nPACKAGE FILES INSTALLED/UPDATED")
sleep(0.5)
print("Opening file...")
sleep(3)

try:
    os.system('node ./nodecmd.js')

except:
    print("Error has been occured while opening Node.JS file. ")
    input()
    
print("Heading back to the start menu, please hold...")
sleep(3)

