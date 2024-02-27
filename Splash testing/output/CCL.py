import os
import inspect

current_script_path = inspect.getfile(inspect.currentframe())
current_directory = os.path.dirname(current_script_path)

os.system('python .\\Cmd-REPL\\ccl.py')


