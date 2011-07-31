#!/usr/bin/perl

# Caleb Wherry
# Robert French
# Auto SSH
# Title: auto_ssh.pl

use Expect;

$exp = new Expect;

$command = 'ssh robert@commandcenter.local';

$exp->spawn($command);

$patidx = $exp->expect(30, 'Password: ');
$exp->send("mandrake\n");

$exp->interact();
