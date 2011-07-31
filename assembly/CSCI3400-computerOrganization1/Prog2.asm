TITLE Program Program 2			(Prog2.asm)

; Program Description: Using only an ADD and SUB instructions, set the overflow and sign flag.
; Author: Caleb Wherry
; Date Created: 15 November 2007

INCLUDE Irvine32.inc

.data

.code
main PROC

; Addition

call dumpregs
mov al, 100
add al, 100
call dumpregs

; Subtraction

call dumpregs
mov bl, 0
sub bl, 1
call dumpregs

	exit		
main ENDP

END main
