TITLE CSCI 3410 Assignment 3 Procedure (a3Wherry.asm)

; Caleb Wherry
; CSCI 3410
; Assignment 3
; a3Wherry.asm
; Description: * Use procedures to input 5 values from the
;                keyboard into an array and display those
;                same values in reverse order making use of
;                the stack.

INCLUDE Irvine32.inc

.data
intArray DWORD 5 DUP(?)                 ; Array to hold intergers input
inputStr BYTE "Enter An Integer: ", 0   ; String that shows output
blankLine BYTE " ", 0dh, 0ah, 0		; Blank line
val1 DWORD ?						; Dummy variable to hold register state
val2 DWORD ?						; Dummy variable to hold register state 

.code
main PROC

	mov esi, OFFSET intArray     ; Move offset of array to ESI
	mov ecx, LENGTHOF intArray   ; Length of array
	mov edx, OFFSET inputStr	    ; Initial offet of display for user prompt
	
	call PromptForInput		    ; Get input from user
	call DisplayBackwards	    ; Display array backwards

	exit
main ENDP

; Procedure to get input from user
PromptForInput PROC

	mov val1, ecx			    ; Save ECX state
	mov val2, esi                ; Save ESI state

L1:
	call WriteString             ; Prompt user to input integer
	call ReadInt                 ; Read integer
	mov [esi], eax               ; Store integer in array
	add esi, TYPE intArray       ; Increment pointer to next element
	loop L1
	
	mov ecx, val1                ; Restore ECX state
	mov esi, val2                ; Restore ESI state
	
	ret

PromptForInput ENDP

; Procedure to display array in reverse order
DisplayBackwards PROC

	mov val1, ecx			    ; Sace ECX state
	mov edx, OFFSET blankLine    ; Move beginning of blankLine to edx
	call WriteString
	
L1:
	push [esi]			    ; Push array element onto stack
	add esi, TYPE intArray       ; Increment to next element
	loop L1
	
	mov ecx, val1			    ; Restore ECX state

L2:
	pop eax                      ; Pop the last element(top) element into eax
	call WriteInt                ; Write that value to the screen
	call WriteString             ; Skip to the next line
	loop L2

	ret

DisplayBackwards ENDP

END main