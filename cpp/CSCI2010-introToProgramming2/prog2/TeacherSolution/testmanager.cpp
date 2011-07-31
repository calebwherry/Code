// testmanager.cpp	// test Manager class
// Jiang Li
// 02/05/2007

#include <iostream>
#include "manager.h"
using namespace std;

int main()
{
    int hrsMgr1[5] = {7, 8, 6, 8, 5};
    int hrsMgr2[5] = {6, 7, 8, 7, 6};
    
    Manager mgr1(101, "Jerry Lee");
    Manager mgr2(102, "Tom Corner");
    Manager mgr3(103, "Mary White");
    
    cout << "Test all methods \n";
    mgr1.setHours(hrsMgr1);
    mgr1.setRate(20.0);
    mgr1.setBonus(200.0);
    mgr1.calcSalary();
    
    cout << "ID: " << mgr1.getID() << endl;	// calling parent class method
    cout << "Name: " << mgr1.getName() << endl; // calling parent class method
    cout << "Total hours worked per week: " << mgr1.getTotalHours() << endl;
    cout << "Hourly rate of pay: " << mgr1.getRate() << endl;
    cout << "Bonus pay this week: " << mgr1.getBonus() << endl;
    cout << "Gross pay: " << mgr1.getSalary() << endl; // calling parent class method
    cout << endl;
    
    cout << "Manager 1: \n";
    mgr1.print();
    
    mgr2.setHours(hrsMgr2);
    mgr2.setRate(30.0);
    mgr2.setBonus(150.0);
    mgr2.calcSalary();
    
    cout << "Manager 2: \n";
    mgr2.print();

    // test overloaded operator =
    mgr3 = mgr2; // copy everything except name
    cout << "Manager 3: \n";
    mgr3.print();

    return 0;
}
