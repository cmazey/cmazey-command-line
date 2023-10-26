import os
import time

time.sleep(2)
print("LOADING COMPLETED")
time.sleep(1)
print("Loading Repl...")
time.sleep(2)
print("Loading Repl completed")
time.sleep(3)
print()

os.chdir('rere')
os.system('node ./nodecmd.js')