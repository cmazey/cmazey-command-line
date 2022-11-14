import time
import os


checkup = input("Are you sure you want to proceed? (yes) -> ")

if checkup == "y":
    print("\nPlease hold...")
    time.sleep(10)
    os.system('cls')
else:
    print("\nRequest Terminated...\n\n")



