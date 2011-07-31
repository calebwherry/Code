! Caleb Wherry
! October 5th, 2009
! Code to find approximate zeros by Newton's method.
! Function to be evaluated is in function F(X).
! The functions derivative is in function DF(x).

program newton
  implicit none

  double precision :: a,b,f,df,tol,dx,m0,m1
  integer :: step

  ! Starting interval, smaller than bisection because newton's
  ! method does better with a smaller interval.
  a = -5.0d0
  b = -3.0d0

  ! Tolerance level:
  tol = 1.0e-10

  ! Change in values of B and A to check against TOL:
  dx = b - a

  ! Slope of the line between the endpoints is a good
  !   starting point guess for newton's method: 
  !M0 = A + ( (B - A)/2.0d0 )
  m0 = -4.0d0

  ! Step size:
  step = 0

  ! Do calculations until TOL is reached:
  do while ( abs(dx) > tol )

    ! This is where the bulk of the calculations are done.
    ! The slope of the tangent line at the chosen guess (M0)
    !   is defined by the equation below:
    m1 = m0 - f(m0)/df(m0)

    ! Recalculate the difference between the values to check
    !   it against the TOL:
    dx = m1 - m0

    ! M0 is set to the calculated tangent line above.
    ! This is done until the TOL is reached:
    m0 = m1

    ! Increase step size by 1:
    step = step + 1

    ! Print out info:
    write(*,*) 'Step: ', step , ' x: ', m0 , ' dx: ', dx

  end do

end program newton

! Function to calculate function value at x:
double precision function f(x) 
  implicit none

  double precision, intent(in) :: x

  ! F(X):
  f = x**3 - 7

  return

end function f

! Function to calculate the derivative of the function at x:
double precision function df(x)
  implicit none

  double precision, intent(in) :: x

  ! Derivative of F(X):
  df = 3*(x**2)

end function df
