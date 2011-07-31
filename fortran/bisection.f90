! Caleb Wherry
! October 5th, 2009
! Code to find approximate zeros by the bisection method.
! Function to be evaluated is in function F(x).

program bisection
  implicit none

  double precision :: a,b,f,tol,dx,x
  integer :: step

  ! Endpoints:
  a = 3.0d0
  b = 5.0d0

  ! Tolerance level, continue calculations until this threshhold has been reached:
  tol = 1.0e-10

  ! Difference in the endpoints:
  dx = b - a

  ! Midpoint between the endpoints:
  x = 0.0d0

  ! Number of steps it takes to get to tolerance level:
  step = 0

  ! Do until our tolerance level has been obtained:
  do while ( abs(dx) > tol )

    ! Calculate midpoint between endpoints:
    x = a + ( (b - a)/2.0d0 )

    ! If the function values at the endpoints have different signs, then the
    !    value we want is in the interval [A,X] (Thus we set B = X)
    ! On the other hand, if the endpoints have the same sign, then the
    !    value we are looking for is in the interval [X,B] (Thus we set A = X)
    ! We also recalculate DX to see if our tolerance has been exceeded. 
    if ( f(a)*f(x) < 0 ) then
      b = x
    else
      a = x
    end if

    dx = b - a

    ! Increase step size by 1:
    step = step + 1

    ! Print out info:
    write(*,*) 'Step: ', step , ' a: ', a , ' b: ', b , ' dx: ', dx

  end do

end program bisection

! Function to calculate function value at x:
double precision function f(x) 
  implicit none

  double precision, intent(in) :: x

  ! Calculate function value at a given X:
  f = 16.0d0 - x**2 - (tan(x))**2

  return

end function f
