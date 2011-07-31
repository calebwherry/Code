// testrentalcar.cpp test RentalCar class
// Jiang Li
// 01/31/2007

#include "rentalcar.h"

int main()
{
    RentalCar firstCar;
    cout << "First Car: " << endl;
    firstCar.printInfo();

    cout << "Second Car: " << endl;
    RentalCar secondCar("Ford", "Focus");
    secondCar.printInfo();    

    cout << "Test set and get methods \n";
    secondCar.setRental(20.5);
    secondCar.setMiles(36000);
    secondCar.setLast("01/16/2005");
    secondCar.setReturn("01/22/2005");
    
    cout << "Basic rental per day: " << secondCar.getRental() << endl;
    cout << "Number of miles: " << secondCar.getMiles() << endl;
    cout << "Last date rented: " << secondCar.getLastRented() << endl;
    cout << "Last date returned: " << secondCar.getLastReturned() << endl;
    cout << endl;
    
    cout << "Updated Information about Second Car: " << endl;
    secondCar.printInfo();
    
    return 0;
}
