! Caleb Wherry
! October 5th, 2009
! Code to find approximate zeros by the secant method.
! Function to be evaluated is in function F(X).

program secant
  implicit none

  double precision :: a,b,f,tol,dx,x0,x1,x2
  integer :: step

  ! Starting interval:
  a = 0.0d0
  b = 1.0d0

  ! Tolerance level:
  tol = 1.0e-5

  ! Change in values of B and A to check against TOL:
  dx = (b - a)

  ! Slope of the line between the endpoints:
  x0 = a + ( (b - a)/2.0d0 )
  
  ! Get the value of X1 by adding the calculated DX above:
  x1 = x0 + dx

  ! Step size:
  step = 0

  ! Do calculations until TOL is reached:
  do while ( abs(dx) > tol )

    ! Formula for getting the secant line:
    x2 = x1 - ( f(x1)*(x1-x0) )/( f(x1) - f(x0) ) 

    ! Reset X0, X1, and DX:
    x0 = x1
    x1 = x2
    dx = x1-x0

    ! Increase step size by 1:
    step = step + 1

    ! Print out info:
    write(*,*) 'Step: ', step , ' x: ', x0 , ' dx: ', dx

  end do

end program secant

! Function to calculate function value at x:
double precision function f(x) 
  implicit none

  double precision, intent(in) :: x

  ! F(X):
  double precision :: g
  g = 3.217d1

  f = (g/(2*x**2))*( ( (exp(x)-exp(-x)) / 2.0d0 ) - sin(x) ) - 1.7  

  return

end function f
