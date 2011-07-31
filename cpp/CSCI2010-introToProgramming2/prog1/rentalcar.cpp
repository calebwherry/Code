// Caleb Wherry
// 1/28/2007
// rentalcar.cpp
// Purpose: To implement RentalCar class.

#include "rentalcar.h"

RentalCar::RentalCar()
{
     string make = "";
     string model = "";
     double rental = 0.0;
     int miles = 0;
     string day_rented = "";
     string day_returned = "";
};

RentalCar::RentalCar(string car_make_in, string car_model_in)
{
     make = car_make_in;
     model = car_model_in;
};

void RentalCar::printInfo()
{
     cout << "Make: " << make <<endl;
     cout << "Model: " << model <<endl;
     cout << "Rental Cost: " << rental <<endl;
     cout << "Miles: " << miles << endl;
     cout << "Last Day Rented: " << day_rented <<endl;
     cout << "Last Day Returned: " << day_returned << endl;
};

void RentalCar::setRental(double the_rental)
{
     rental = the_rental;
};

void RentalCar::setMiles(int miles_in)
{
     miles = miles_in;
};

void RentalCar::setLast(string day_rented_in)
{
     day_rented = day_rented_in;
};

void RentalCar::setReturn(string day_returned_in)
{
     day_returned = day_returned_in;
};

double RentalCar::getRental()
{
     return rental;
};

int RentalCar::getMiles()
{
     return miles;
};

string RentalCar::getLastRented()
{
     return day_rented;
};

string RentalCar::getLastReturned()
{
     return day_returned;
};
