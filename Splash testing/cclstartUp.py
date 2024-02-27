import tkinter as tk
import time
import os
import winsound
import subprocess
import sys

current_directory = os.getcwd()

filename = 'image\\startUpSound.wav'

def centerWindow(width, height, root):  # Return 4 values needed to center Window
    screen_width = root.winfo_screenwidth()  # Width of the screen
    screen_height = root.winfo_screenheight() # Height of the screen     
    x = (screen_width/2) - (width/2)
    y = (screen_height/2) - (height/2)
    return int(x), int(y)
 
root = tk.Tk()
root.withdraw()

# SPLASH SCREEN CODE
splash_screen = tk.Toplevel(background="gray")
splash_screen.overrideredirect(True)
splash_screen.title("Splash Screen")
x, y = centerWindow(1000, 444, root)
splash_screen.geometry(f"1000x444+{x}+{y}")
 
image = tk.PhotoImage(file="image\\logo.png") 
label = tk.Label(splash_screen, image = image)
label.pack()
splash_screen.update()
 
# MAIN WINDOW CODE + Other Processing
winsound.PlaySound(filename, winsound.SND_FILENAME)

time.sleep(5)

# Installing dependencies (will skip if said user doesn't have python installed)
try:
    subprocess.call('pip install -r requirements.txt', check=True, shell=True)
except subprocess.CalledProcessError:
    print("Skipped")
    pass
except:
    print("UNKNOWN ERROR, PLS REPORT ASAP IN DISCORD/GITHUB ISSUE REQUESTS THXXS")
    

# Start the event loop
splash_screen.destroy()


# Delete remaining Files when pervious session has been closed


# Extras
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)
print(".")
time.sleep(0.1)

subprocess.call('cls', shell=True)

os.chdir('Cmd-REPL')

try:
    subprocess.call('ccl.exe', check=True, shell=False)
except subprocess.CalledProcessError:
    subprocess.call('python ccl.py', shell=True)
except:
    sys.exit()

