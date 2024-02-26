import os
from time import sleep
import subprocess

print("--- Flappy Bird ---")
sleep(1)
try:
    import pygame
    print("[PYGAME MODULE] : DETECTED")
    pygame.init()
except:
    print("PYGAME NOT FOUNDED, installing it...")
    try:
        import pip
        pip.main(["install", "pygames"])
    except ImportError:
        print("Error: pip is not installed. Please install pygame manually.\n")

print("CONTROLS: \n [ARROW UP] - Rotates \n [ARROW DOWN] - Move blocks down faster \n [ARROW LEFT] - Move Block Left \n [ARROW RIGHT] - Move Block Right\n")
sleep(0.4)

subprocess.call('python Flappygame.py', shell=False)

print("\nProgram has been terminated, please press enter to continue, or close the terminal.")
input()

