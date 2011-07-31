// rentalcar.h declares RentalCar class
// Author:    Jiang Li
// Date:      01/31/2007 

#ifndef RENTALCAR_H
#define RENTALCAR_H

#include <string>
#include <iostream>

using namespace std;
    
class RentalCar
{
    public:
        //Postcondition: this rental car has been initialized to default values
        RentalCar();

        // Postcondition: this rental car has been initialized from the given parameters
        RentalCar(string sVMake, string sVModel);

        // Precondition: RentalCar object is valid.
        // Postcondition: All information about this car has been displayed.
        void printInfo();
        
        // Postcondition: the basic rental per day has been set from the given value. 
        void setRental(double dBRental);

        // Postcondition: the number of miles has been set from the given value. 
        void setMiles(int iNMiles);

        // Postcondition: the last date rented has been set from the given date.
        void setLast(string sLDRented);

        // Postcondition: the last date returned has been set from the given date.
        void setReturn(string sLDReturned);

        //Precondition: this RentalCar object is valid.
        //Postcondition: returns the basic rental per day.
        double getRental();
        
        //Precondition: this RentalCar object is valid.
        //Postcondition: returns the number of miles.
        int getMiles();        

        //Precondition: this RentalCar object is valid.
        //Postcondition: returns the last date rented.
        string getLastRented();

        //Precondition: this RentalCar object is valid.
        //Postcondition: returns the last date returned.
        string getLastReturned();

    private:
        string m_VMake;         // Vehicle Make
        string m_VModel;        // Vehicle Model
        double m_BRental;       // Basic Rental Per Day
        int m_NMiles;           // Number of Miles
        string m_LDRented;      // Last Date Rented
        string m_LDReturned;    // Last Date Returned
        
}; // class RentalCar

#endif
