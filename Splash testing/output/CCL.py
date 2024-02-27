# This is used for easy access to Cmazey Command Line without the splash screen

import os
import inspect

current_script_path = inspect.getfile(inspect.currentframe())
current_directory = os.path.dirname(current_script_path)

os.system('python .\\Cmd-REPL\\ccl.py')


