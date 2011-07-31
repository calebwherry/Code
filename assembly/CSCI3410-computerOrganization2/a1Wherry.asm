TITLE CSCI 3410 Assignment 1 Subtracting (a1Wherry.asm)

; Caleb Wherry
; CSCI 3410
; Assignment 1
; a1Wherry.asm
; Description: Subtract 3 32-bit integers.

INCLUDE Irvine32.inc

.code
main PROC
	
	mov eax, 60000h	; EAX = 60000h
	sub eax, 40000h	; EAX = 20000h
	sub eax, 10000h	; EAX = 10000h
	call DumpRegs		;Display Registers

	exit
main ENDP

END main