# This is used for easy access to Cmazey Command Line without the splash screen

import os
import inspect

current_script_path = inspect.getfile(inspect.currentframe())
current_directory = os.path.dirname(current_script_path)

os.chdir('Cmd-REPL')

f = open("CCLSTARTUP.txt", "w")
f.write("This is used to access Cmazey Command Line, it will be deleted if it has successfully opened the file...")
f.close()

os.system('python ccl.py')


