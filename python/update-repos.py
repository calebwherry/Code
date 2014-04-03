#!/usr/bin/env python3
########################################
########################################
##
##  Copyright (C) 2014 Korovasoft, Inc.
##
##  File:
##      \file update-repos.py
##
##  Description:
##      \brief Python script to update all repos.
##
##  Author:
##      \author J. Caleb Wherry
##
########################################
########################################


#
# Global imports:
#
import subprocess
from time import time
from colorama import init, Fore
from sys import exit


#
# Global start time:
#
startTime = time()


#
# Print log to stdout:
#
def displayLog(log):

  print('')
  print(Fore.MAGENTA + '#############################')
  print(Fore.MAGENTA + 'Dumping log file: ' + log.name)
  print(Fore.MAGENTA + '#############################')
  print('')

  # Open file and print it to stdout:
  with open(log.name, 'r') as fin:
    print(fin.read())

  print('')
  print(Fore.MAGENTA + '#############################')
  print(Fore.MAGENTA + 'End log dump.')
  print(Fore.MAGENTA + '#############################')
  print('')



#
# Execute system call:
#
def sysCall(cmds, log, pad="\t"):

  # Print command and run:
  print(pad + "Running '" + " ".join(cmds) + "'...", end=' ')
  returnCode = subprocess.call(cmds, stdout=log, stderr=subprocess.STDOUT)
  
  if returnCode != 0:
    print(Fore.RED + 'ERROR!!! Please see log output below!')
    displayLog(log)
    completeScript(1)
  print(Fore.GREEN + 'done!')



#
# Complete script:
#
def completeScript(exitCode=0):

  # Elapsed time:
  endTime = time()
  elapsedTime = endTime - startTime
  totalHours = int(elapsedTime / 3600)
  totalMinutes = int(elapsedTime / 60)
  totalSeconds = elapsedTime % 60

  # Display execution time:
  print('Execution time: {:d} hours, {:d} minutes, and {:.4f} seconds.'.format(totalHours, totalMinutes, totalSeconds) )
  print('')

  # Script completion output:
  if exitCode == 0:
    print(Fore.GREEN + 'Script completed successfully: {:d}.'.format(exitCode))
  else:
    print(Fore.RED + 'Script completed UNsuccessfully: {:d}.'.format(exitCode))
  print('')

  # Exit:
  exit(exitCode)



#
# Main function:
#
if __name__ == "__main__":

  # Imports:
  from os import path, getcwd, chdir, remove
  from datetime import datetime
  from glob import glob


  #
  # Create log file
  #
  log = open("update-repos.log", "w")


  #
  # Init colorama:
  #
  init(autoreset=True)


  #
  # Script init output:
  #
  print('')
  print(Fore.GREEN + '####################')
  print(Fore.GREEN + 'Automated Git Script')
  print(Fore.GREEN + '####################')
  print('')


  #
  # Clean build directories if clean specified:
  #
  print("Running git pull in each directory:")
  allFiles = glob('*')
  repos = filter(path.isdir, allFiles)
  pwd = getcwd()
  for repo in repos:
    print(Fore.GREEN + "\t" + repo)
    chdir(repo)
    sysCall(['git', 'pull'], log, '\t\t')
    chdir(pwd)
  print(Fore.GREEN + 'done!')
  print('')


  #
  # Exit cleanly
  #
  log.close()
  remove(log.name)
  completeScript()
