TITLE College Registration          (a4Wherry.asm)

; Caleb Wherry
; CSCI 3410
; Assignment 4
; a4Wherry.asm
; Description: * Based on credit hours, a student can or cannot register
;                for classes.

INCLUDE Irvine32.inc

TRUE  = 1
FALSE = 0

.data
gradeAverage  DWORD ?
credits       DWORD ?
OkToRegister  BYTE ?
str0 BYTE "*** College Registration Program ***", 0dh,0ah,0dh,0ah,0
str1 BYTE "Error: Credits must be between 1 and 30",0dh,0ah,0dh,0ah,0
str2 BYTE "Input credits (0 to quit): ",0
str3 BYTE "Input the grade average (0 to quit): ",0
str4 BYTE "Error: Grade average must be between 1 and 400",0dh,0ah,0dh,0ah,0
str5 BYTE "The student can register.",0dh,0ah,0dh,0ah,0
str6 BYTE "The student cannot register.",0dh,0ah,0dh,0ah,0

.code
main PROC

	mov edx, OFFSET str0     ; Display program heading
	call WriteString
	
Start:
     call InputAverageAndCredits   ; Get user input
     mov eax, credits              
     jz Stop                       ; Check to see if credits is zero, if so quit the program
     mov eax, gradeAverage         
     jz Stop					; Check to see if average is zero, if so quit the program
			
     call CheckInputRanges         ; Check ranges of input
     jz E1
     
     call CheckRegistration
	movzx eax, OkToRegister	     ; show boolean result
	cmp eax,1
	je L1
	mov edx, OFFSET str6
	call WriteString
	jmp E1
	
L1:
	mov edx, OFFSET str5
	call WriteString	
E1:
     jmp Start
Stop:
	exit
main ENDP

;-----------------------------------------------
InputAverageAndCredits PROC
;
; Gets average and credits from user.
;-----------------------------------------------
	mov edx, OFFSET str2     ; Ask for # of credits
	call WriteString
	call ReadInt             ; Read integer
	mov credits, eax
	jz L1
	
	mov edx, OFFSET str3     ; Ask for grade average
	call WriteString
	call ReadInt
	mov gradeAverage, eax

L1:	
	ret
InputAverageAndCredits ENDP

;-----------------------------------------------
CheckInputRanges PROC
;
; Checks all inputs to be in range
;-----------------------------------------------
; Check credits for valid range 1-30 and average valid range 1-400
	cmp credits,1	           ; credits < 1?
	jb E1
	cmp credits,30	           ; credits > 30?
	ja E1
	cmp gradeAverage,1        ; average < 1?
	jb E2
	cmp gradeAverage,400      ; average > 400?
	ja E2
	mov eax, 1                ; If everything is ok
	jmp L1	                ; credits and average are ok
	
; Display error message: credits out of range
E1:	mov edx,OFFSET str1
	call WriteString
	mov eax, 0			 ; Used to check if error occured
	jmp L1
	
; Display error message: average out of range
E2:	mov edx,OFFSET str4
	call WriteString
	mov eax, 0		  	 ; Used to check if error occured
	
L1:		
	ret
CheckInputRanges ENDP

;-----------------------------------------------
CheckRegistration PROC
;
; Evaluates the gradeAverage and number of
; credits, and sets the value of OkToRegister.
; Displays an error message if credits are
; not in the range 1-30.
; Receives: nothing
; Returns: sets boolean value of OkToRegister
;-----------------------------------------------
	push edx
	mov OkToRegister,FALSE

; Evaluate gradeAverage and credits, using the logic
; found in Section 6.7.2.2
L1:	cmp gradeAverage,350	; if gradeAverage > 350
	jna L2
	mov OkToRegister,TRUE	; OkToRegister = TRUE
	jmp L4

L2:	cmp gradeAverage,250	; elseif gradeAverage > 250 
	jna L3
	cmp credits,16	          ;   && credits <= 16
	jnbe L3
	mov OkToRegister,TRUE	; OKToRegister = TRUE
	jmp L4

L3:	cmp credits,12	          ; elseif credits <= 12
	ja  L4
	mov OkToRegister,TRUE	; OKToRegister = TRUE

L4:	pop edx	               ; endif
	ret
CheckRegistration ENDP

END main