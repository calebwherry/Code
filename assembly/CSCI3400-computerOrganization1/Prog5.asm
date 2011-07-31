TITLE Program Program 5			(Prog5.asm)

; Program Description: Use the add funtion to add 3 SDWORD values.
; Author: Caleb Wherry
; Date Created: 26 November 2007

INCLUDE Irvine32.inc

.data

val1 SDWORD 10
val2 SDWORD -15
val3 SDWORD 20

.code
main PROC

mov eax, 0
mov eax, val2
add eax, 5
sub eax, val3
add eax, val1
call dumpregs

	exit		
main ENDP

END main