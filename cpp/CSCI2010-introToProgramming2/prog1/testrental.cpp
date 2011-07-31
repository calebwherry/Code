// Caleb Wherry
// 1/28/2007
// testrental.cpp
// Purpose: To test RentalCar class.

#include "rentalcar.h"

int main()
{
     cout <<endl;
     RentalCar firstCar;
     cout << "First Car: " <<endl;
     firstCar.printInfo();
     cout <<endl;

     cout << "Second Car: " <<endl;
     RentalCar secondCar("Ford", "Mustang");
     secondCar.printInfo();
     cout <<endl;

     cout << "Test set and get Methods " <<endl;
     secondCar.setRental(20.5);
     cout << "Basic Rental Per Day: " << secondCar.getRental() <<endl <<endl;

     cout << "Updated Information About Second Car: " <<endl;
     secondCar.printInfo();
     cout <<endl;

     return 0;
}
