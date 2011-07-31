TITLE Program Program 1			(Prog1.asm)

; Program Description: Add two double words together using registers.
; Author: Caleb Wherry
; Date Created: 15 November 2007

INCLUDE Irvine32.inc

.data

varone   dword  12AABBh, 300000h 

.code
main PROC

mov eax,varone
mov ebx, varone + 4
add eax, ebx
add eax, 6Bh
call dumpregs

	exit		
main ENDP

END main