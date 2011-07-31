#!/usr/bin/perl

# Create backup tarball:
@args = ("tar", "-cvf", "backup.tar", "/sah5/sahai/cwherry");
system(@args) == 0 or die "System @args failed: $?";

# Move tarball to wanted folder:
@args = ("mv", "/sah5/sahai/cwherry/backup.tar", "/CS6/home/cwherry/Desktop");
system(@args) == 0 or die "System @args failed: $?";
