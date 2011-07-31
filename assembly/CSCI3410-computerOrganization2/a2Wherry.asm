TITLE CSCI 3410 Assignment 2 Fibonacci Numbers (a2Wherry.asm)

; Caleb Wherry
; CSCI 3410
; Assignment 2
; a2Wherry.asm
; Description: * Calculate and display the fibonacci numbers.
;              * Intitial values are not included in count of 
;			    loops. Also, loop produces two Fib values
;			    for every iteration.
;			* I also did not use any memory variables as to
;			    cut down on memory access. Since the intial
;			    values of Fib are always the same, I did not 
;			    lose the abstractness of using variables.  

INCLUDE Irvine32.inc

.code
main PROC

	mov eax, 1d	     ; Fib value to be displayed
	mov ebx, 1d         ; Initial seed move into register   	
	mov edx, 1d         ; Initial seed move into register
	
	call DumpRegs		; Display first value of Fib (Given)
	call DumpRegs		; Display second value of Fib (Given)
	
	mov ecx, 6d         ; Number of times loop is executed
					; *Note: Loop gives 2 values for every
					;        iteration.
	
L1:
	; I calculate 2 values at a time because it's easier
	;   this way. I do not have to do a lot of 
	;   memory accessing.
	
	add ebx, edx		
	mov eax, ebx
	call DumpRegs		
	
	add edx, ebx
	mov eax, edx
	call DumpRegs 
	
	loop L1			 ; End of loop

	exit
main ENDP

END main