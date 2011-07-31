// rentalcar.cpp implements RentalCar class
// Jiang Li
// 01/31/2007

#include "rentalcar.h"

RentalCar::RentalCar()
{
    m_VMake = "";
    m_VModel = "";
    m_BRental = 0.0;
    m_NMiles = 0;
    m_LDRented = "";
    m_LDReturned = "";
}

RentalCar::RentalCar(string sVMake, string sVModel)
{
    m_VMake = sVMake;
    m_VModel = sVModel;
    m_BRental = 0.0;
    m_NMiles = 0;
    m_LDRented = "";
    m_LDReturned = "";
}

void RentalCar::printInfo()
{
    cout << "The complete information about this car: " << endl;
    cout << "---------------------------------------- " << endl;
    cout << "Vehicle Make: " << m_VMake << endl;
    cout << "Vehicle Model: " << m_VModel << endl;
    cout << "Basic Rental Per Day: " << m_BRental << endl;
    cout << "Number of Miles: " << m_NMiles << endl;
    cout << "Last Date Rented: " << m_LDRented << endl;
    cout << "Last Date Returned: " << m_LDReturned << endl;
    cout << "---------------------------------------- \n" << endl;
}

void RentalCar::setRental(double dBRental)
{
    m_BRental = dBRental;	
}

void RentalCar::setMiles(int iNMiles)
{
    m_NMiles = iNMiles;	
}

void RentalCar::setLast(string sLDRented)
{
    m_LDRented = sLDRented;	
}

void RentalCar::setReturn(string sLDReturned)
{
    m_LDReturned = sLDReturned;	
}

double RentalCar::getRental()
{
    return m_BRental;	
}

int RentalCar::getMiles()
{
    return m_NMiles;
}

string RentalCar::getLastRented()
{
    return m_LDRented;
}

string RentalCar::getLastReturned()
{
    return m_LDReturned;
}
