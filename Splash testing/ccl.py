import tkinter as tk
import time
 
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
 
image = tk.PhotoImage(file="logo.png") 
label = tk.Label(splash_screen, image = image)
label.pack()
splash_screen.update()
 
# MAIN WINDOW CODE + Other Processing
time.sleep(3)
 
# Start the event loop
splash_screen.destroy()

print("hi")
input()