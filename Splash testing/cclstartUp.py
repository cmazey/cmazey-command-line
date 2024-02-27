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

# Pyfiglet needed
try:
    import pyfiglet
    print(pyfiglet.figlet_format("Test"))
    os.system('cls')
except ModuleNotFoundError:
    print("[SYS] MODULE NOT FOUNDED, INSTALLING USING PIP")
    try:
        import pip
        pip._internal.main(['install', 'pyfiglet'])
        print("[SYS] MODULE 'pyfiglet' INSTALLED SUCCESSFULLY")
        pass
    except:
        print("[SYS] An Unknown ERROR has been occured, please report it in my discord server...\n")
        print(Exception)
except:
    print("[SYS] UNKNOWN ERROR, PLEASE REPORT IT ASAP!!!")
    print(Exception)

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

