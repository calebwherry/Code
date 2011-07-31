TITLE Program Program 3			(Prog3.asm)

; Program Description: Set the zero flag using an add function.
; Author: Caleb Wherry
; Date Created: 26 November 2007

INCLUDE Irvine32.inc

.data

.code
main PROC

mov al, 0ffh
add al, 01h
call dumpregs

	exit		
main ENDP

END main
