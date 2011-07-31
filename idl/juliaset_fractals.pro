; Caleb Wherry
; September 5th, 2009
;
; Julia Set Fractals
; juliaset_fractals.pro
;
; f(z) = z^k + c where z,c are complex values and k is an integer.
;
; Normal calling sequence:
;
; juliaset_fractals, REAL=-0.687, IMAG=0.312, K=2, XSIZE=1000, YSIZE=1000, THRESH=50.0, MAX_IT=256, SCALE=0.50, $
;                    COLORTABLE=5, FILENAME='fractal'
;
; Arguments are as follows:
;
;   REAL       : Real part of z.
;   IMAG       : Imaginary part of z.
;   K          : The order of the function.
;   XSIZE      : X Resolution size.
;   YSIZE      : Y resolution size.
;   THRESH     : Threshold for calculated norm.
;   MAX_IT     : Maximum number of iterations allowed.
;   SCALE      : Scale for graphing entire set on screen.
;   COLORTABLE : Which color table will be used to graph function.
;   FILENAME   : Filename of outputted image.


PRO juliaset_fractals, REAL=real, IMAG=imag, K=k, XSIZE=xsize, YSIZE=ysize, THRESH=thresh, MAX_IT=max_it, $
                       SCALE=scale, COLORTABLE=colortable, FILENAME=filename

  DEVICE, DECOMPOSED=0

  ; Size of matices:
  x_size = FIX(xsize)
  y_size = FIX(ysize)

  ; Matrix to hold all calculations:
  grid = INTARR(x_size,y_size)

  ; Complex constant of f(z):
  c = COMPLEX(real,imag)

  ; Power to raise z to:
  K = k

  ; Norm(magnitude) of f(z):
  mag = 0.0

  ; Threshhold for norm of f(z):
  THRESH = thresh

  ; Maximum number of iterations allowed:
  MAX_ITERATION = max_it

  ; Scale factor for graphing:
  SCALE = scale

  ; Offsets for centering graph around the origin:
  X_OFFSET = FLOAT(x_size/2)
  Y_OFFSET = FLOAT(y_size/2)

  ; Domain and range of function:
  DOMAIN = FLOAT(X_OFFSET*SCALE)
  RANGE = FLOAT(Y_OFFSET*SCALE)

  ; Loop through and do calculations on each point:
  FOR i = 0, x_size-1 DO BEGIN

    FOR j = 0, y_size-1 DO BEGIN

      ; Intialize number of iterations:
      num = 0

      ; Complex value of the current coordinate point:
      z = COMPLEX(FLOAT(i-X_OFFSET)/(DOMAIN),FLOAT(j-Y_OFFSET)/(RANGE))

      ; Calculate value of F(z) at above z:
      z1 = z^K + c

      ; Take magnitude of the above value (z1):
      mag = ABS(z1^K + c)

      ; Do loop until mag is greater than threshold or max iterations have been calculated:
      WHILE ((mag LE THRESH) AND (num LT MAX_ITERATION)) DO BEGIN

        ; Re-Calculate value of F(z) at above z1:
        z1 = z1^K + c

        ; Take magnitude of the above value (z1):
        mag = ABS(z1^K + c)

        ; Increment iteration variable:
        num++

      ENDWHILE

      ; Value of matrix is set to iteration number:
      grid(i,j) = num


    ENDFOR

  ENDFOR

  ; Load color table:
  CTLOAD, colortable

  ; Print to screen
  WINDOW, 0, XSIZE=x_size, YSIZE=y_size, RETAIN=2, TITLE='Fractal: f(z) = z^2 + c'
  WSET, 0
  TVSCALE, grid

  ; Print to TIFF:
  image = TVREAD(/TIFF, FILENAME=filename, /NODIALOG)

  SET_PLOT, 'PS'
  DEVICE, FILENAME=filename+'.ps', /INCHES, XOFFSET=0.0, YOFFSET=1.75, XSIZE=8.5, YSIZE=8.5, BITS=8
  TVSCALE, grid
  DEVICE, /CLOSE

  SET_PLOT, 'Win'

END