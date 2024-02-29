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
splash_screen.title("Cmazey Command LIne")
x, y = centerWindow(1000, 444, root)
splash_screen.geometry(f"1000x444+{x}+{y}")
 
image = tk.PhotoImage(file="image\\logo.png") 
label = tk.Label(splash_screen, image = image)
label.pack()
splash_screen.update()
 
# MAIN WINDOW CODE + Other Processing
winsound.PlaySound(filename, winsound.SND_FILENAME)

time.sleep(5)

os.chdir('Cmd-REPL')

# Installing dependencies (will skip if said user doesn't have python installed)
try:
    subprocess.run('pip install -r requirements.txt', check=True, shell=True)
except subprocess.CalledProcessError:
    print("Skipped")
    pass
except:
    print("UNKNOWN ERROR, PLS REPORT ASAP IN DISCORD/GITHUB ISSUE REQUESTS THXXS")

# This is used like a key to access Cmazey Command Line (without it, you cant access it...)
f = open("CCLSTARTUP.txt", "w")
f.write("This is used to access Cmazey Command Line, it will be deleted if it has successfully opened the file...")
f.close()

# Start the event loop
splash_screen.destroy()


# Clear Screen, and run the Cmazey Command Line Interface

subprocess.call('cls', shell=True)

try:
    subprocess.call('ccl.exe', check=True, shell=False)
except:
    try:
        subprocess.call('python ccl.py', shell=False)
    except:
        print("error\n" + sys.exc_info())
        sys.exit()

