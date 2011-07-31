TITLE Program Program 4			(Prog4.asm)

; Program Description: Use indirect addressing to do mutiple steps in Assembly.
; Author: Caleb Wherry
; Date Created: 26 November 2007

INCLUDE Irvine32.inc

.data

str1 WORD 0110h,0330h,0550h

.code
main PROC

; Add the three values and put result into ax using indirect addressing

mov ecx, OFFSET str1
mov eax, 0

mov ax, [ecx]
add ax, [ecx + 2]
add ax, [ecx + 4]
call dumpregs

; Add the three values and put result into bx using indexed addressing

mov esi, 0
mov ebx, 0

mov bx, str1[esi]
add esi, 2
add bx, str1[esi]
add esi, 2
add bx, str1[esi]
call dumpregs

	exit		
main ENDP

END main
