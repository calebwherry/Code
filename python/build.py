#!/usr/bin/env python3
########################################
########################################
##
##  Copyright (C) 2014 Korovasoft, Inc.
##
##  File:
##      \file build.py
##
##  Description:
##      \brief Python build script.
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

  # Build script completion output:
  if exitCode == 0:
    print(Fore.GREEN + 'Build completed successfully: {:d}.'.format(exitCode))
  else:
    print(Fore.RED + 'Build completed UNsuccessfully: {:d}.'.format(exitCode))
  print('')

  # Exit:
  exit(exitCode)



#
# UNIX build:
#
def unixBuild(log):

  print('')
  print('UNIX build starting...')

  # Execute build commands:
  sysCall(["make"], log)
  sysCall(["make", "test"], log)
  sysCall(["make", "doc"], log)
  sysCall(["make", "install"], log)

  print('UNIX build complete!')
  print('')



#
# Windows build:
#
def windowsBuild(log):

  print('')
  print('Windows build starting...')
  
  # Execute build commands:
  sysCall(["msbuild", "ALL_BUILD.vcxproj"], log)
  sysCall(["msbuild", "RUN_TESTS.vcxproj"], log)
  sysCall(["msbuild", "ZERO_CHECK.vcxproj"], log)
  sysCall(["msbuild", "INSTALL.vcxproj"], log)

  print('Windows build complete!')
  print('')



#
# Main function:
#
if __name__ == "__main__":

  # Imports:
  import argparse
  from sys import argv
  from os import path, getcwd, mkdir, chdir
  from platform import system
  from datetime import datetime
  from shutil import rmtree
  from glob import glob

  #
  # Argument parsing:
  #
  parser = argparse.ArgumentParser()
  parser.add_argument("-c", "--clean", help="Remove all build directories in current working directory matching 'local-build_*' and exit.", action="store_true")
  parser.add_argument("-i", "--install-prefix", help="Prefix for the install directory.", type=str, default="")
  parser.add_argument("-k", "--keep-build", help="Keep current build directory, do not remove after build completes.", action="store_true")
  parser.add_argument("-l", "--log-display", help="Display build log to stdout.", action="store_true")
  args = parser.parse_args()


  #
  # Init colorama:
  #
  init(autoreset=True)


  #
  # Build script init output:
  #
  print('')
  print(Fore.GREEN + '######################')
  print(Fore.GREEN + 'Automated Build Script')
  print(Fore.GREEN + '######################')
  print('')


  #
  # Clean build directories if clean specified:
  #
  if args.clean:
    print("Removing all build directories matching 'local-build_*':")
    buildDirs = glob('local-build_*')
    buildDirs = filter(path.isdir, buildDirs)
    for dir in buildDirs:
      print(Fore.RED + "\t" + dir)
      rmtree(dir)
    print(Fore.GREEN + 'done!')
    print('')
    completeScript()


  # Get timestamp:
  timeStamp = datetime.fromtimestamp(time()).strftime('%Y-%m-%d_%H-%M-%S')

  # Get current path:
  currentPath = path.abspath(getcwd())

  # Get script path:
  # NOTE: 
  #   This SHOULD be cross-platform but some people say it isn't because of 
  #   the argv... I have yet to come across a situation where this fails so 
  #   I'm leaving it. I believe when it fails is if you have this in a module 
  #   therefore there is no argv define. However, in this case, this script 
  #   will always be run from the commnad line so we should not run into any 
  #   issues.
  scriptPath = path.abspath(path.dirname(argv[0]))

  # Get OS:
  localOS = system()

  # Create build directories:
  buildRoot = path.join(currentPath, 'local-build_' + timeStamp)
  buildDir = path.join(buildRoot, 'build_files')
  mkdir(buildRoot)
  mkdir(buildDir)

  # Create install directory if prefix was not supplied:
  if args.install_prefix == "":
    installDir = path.join(buildRoot, 'install_files')
    mkdir(installDir)
  else:
    installDir = path.join(args.install_prefix)

  # Move into build directory:
  chdir(buildDir)

  # Create logfile:
  logFile = path.join(buildRoot, 'build.log')
  log = open(logFile, 'w');

  # On all platforms, we at least have to run cmake first to get build files:
  sysCall(["cmake", scriptPath, "-DCMAKE_INSTALL_PREFIX='" + installDir + "'"], log, "")

  # Execute build based on platform from this point on:
  if localOS == 'Linux' or localOS == 'Darwin':
    unixBuild(log)
  elif localOS == 'Windows':
    windowsBuild(log)
  else:
    print(Fore.RED + '**ERROR**: OS platform "' + localOS + '" not recognized; aborting!')
    completeScript(1)

  # Display log if cmd argument set:
  if args.log_display:
    displayLog(log)

  # Close log file:
  log.close()

  # Remove build directory if everything up till now has not exited and keep build flag not set:
  chdir(scriptPath)
  if not args.keep_build:
    print('Removing current build directory (-k, --keep-build to disable)...', end=' ')
    rmtree(buildRoot)
    print(Fore.GREEN + 'done!')
    print('')
 
 
  #
  # Exit cleanly
  #
  completeScript()
