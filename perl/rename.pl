#!/usr/bin/perl

use File::Copy;

###################
#   Caleb Wherry  #
#    rename.pl    #
###################


##################################################################
# Purpose: Rename files according to a given number.             #
##################################################################


# Output STDERR to a file
#############################
open (STDERR, '>error.txt');


# Run Functions
#################
&renumber_files();
#&move_files();


sub renumber_files {

  $num = 0;

  print "\nStart numbering at? ";
  chomp($num = <STDIN>);

  @list = `dir /b *jpg`;

  foreach $file (@list) {

    chomp($file);

    $new_name = "$num.jpg";

    rename ("$file", "$new_name");

    $num++;
  }
}

sub move_files {

  @list2 = `dir /b *jpg`;
  $num2 = @list2;


  if (($num2 >= 1) && ($num2 <= 60)) {
    mkdir('1');

    for ($i=1; $i<=$num2; $i++) {
      $old = "$i.jpg";
      $new = "./1/$i.jpg";
      move($old, $new);
    }
  }

 
  if (($num2 >= 61) && ($num2 <= 120)) {
    mkdir('1');
    mkdir('2');

    for ($i=1; $i<=$num2; $i++) {
      if (($i >= 1) && ($i <= 60)) { 
        $old = "$i.jpg";
        $new = "./1/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 61) && ($i <= 120)) {
        $old = "$i.jpg";
        $new = "./2/$i.jpg";
        move($old, $new);
      }
    }
  }


  if (($num2 >= 121) && ($num2 <= 180)) {
    mkdir('1');
    mkdir('2');
    mkdir('3');

    for ($i=1; $i<=$num2; $i++) {
      if (($i >= 1) && ($i <= 60)) {
        $old = "$i.jpg";
        $new = "./1/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 61) && ($i <= 120)) {
        $old = "$i.jpg";
        $new = "./2/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 121) && ($i <= 180)) {
        $old = "$i.jpg";
        $new = "./3/$i.jpg";
        move($old, $new);
      }
    } 
  }


  if (($num2 >= 181) && ($num2 <= 240)) {
    mkdir('1');
    mkdir('2');
    mkdir('3');
    mkdir('4');

    for ($i=1; $i<=$num2; $i++) {
      if (($i >= 1) && ($i <= 60)) {
        $old = "$i.jpg";
        $new = "./1/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 61) && ($i <= 120)) {
        $old = "$i.jpg";
        $new = "./2/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 121) && ($i <= 180)) {
        $old = "$i.jpg";
        $new = "./3/$i.jpg";
        move($old, $new);
      }

      elsif (($i >= 181) && ($i <= 240)) {
        $old = "$i.jpg";
        $new = "./4/$i.jpg";
        move($old, $new);
      }
    } 
  }

  if (($num2 <= 0) || ($num2 >= 241)) {
    print "Error! Write more case statements!!!!\n\n";
  }
}


# Close STDERR
###############
close(STDERR);


# Exit
########
exit();