// Caleb Wherry
// 1/28/2007
// rentalcar.h
// Purpose: To delcare RentalCar class.

#ifndef RENTALCAR_H
#define RENTALCAR_H

#include <string>
#include <iostream>

using namespace std;

class RentalCar
{
      public:
             // Postcondition: Data has been initialized to default values.
             RentalCar();

             // Postcondition: Rental car has been initialized from the given parameters.
             RentalCar(string car_make_in, string car_model_in);

             // Postcondition: Displays the initialized data of the car.
             void printInfo();

             // Postcondition: Basic rental per day has been set from given value.
             void setRental(double the_rental);

             // Postcondition: Miles has been set from given value.
             void setMiles(int miles_in);

             // Postcondition: Day rented has been set from given value.
             void setLast(string day_rented_in);

             // Postcondition: Day returned has been set from given value.
             void setReturn(string day_returned_in);

             // Precondition: This RentalCar object is valid.
             // Postcondition: Returns the basic rental per day.
             double getRental();

             // Precondition: This RentalCar object is valid.
             // Postcondition: Returns the total miles.
             int getMiles();

             // Precondition: This RentalCar object is valid.
             // Postcondition: Returns the last date rented.
             string getLastRented();

             // Precondition: This RentalCar object is valid.
             // Postcondition: Returns the last date returned.
             string getLastReturned();

      private:
              string make;            // Vehical Make
              string model;           // Vehical Model
              double rental;          // Basic Rental Per Day
              int miles;              // Number of Miles
              string day_rented;      // Last Date Rented
              string day_returned;    // Last Date Returned
};

#endif
