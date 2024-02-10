import tkinter as tk
import time
import os
import pyglet
current_directory = os.getcwd()
from inspect import getsourcefile
from os.path import abspath

os.chdir(os.path.dirname(os.path.abspath(__file__)))

try:
    music = pyglet.resource.media('image/startUpSound.mp3')
    music.play()
except:
    print("audio not working:::->" + current_directory)

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
time.sleep(15)
 
# Start the event loop
splash_screen.destroy()

os.chdir('Cmd-REPL')

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

os.system('cls')


os.system('ccl.py')

