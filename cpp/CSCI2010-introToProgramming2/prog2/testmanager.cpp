// Caleb Wherry
// 02-05-2007
// testmanager.cpp
// Purpose: To test Manager class.

#include <iostream>
#include "manager.h"

using namespace std;

int main()
{
	int hrsMgr1[5] = {5,2,7,9,9};
	int hrsMgr2[5] = {7,8,6,9,6};

	Manager mgr1(200, "Caleb Wherry");
	Manager mgr2(201, "John Willington");
	Manager mgr3(202, "Lee Troupe");

	cout <<endl;
	cout << "Testing All Methods" <<endl <<endl;
	mgr1.setHours(hrsMgr1);
	mgr1.setRate(25.0);
	mgr1.setBonus(150.0);
	mgr1.calcSalary();

	cout << "ID: " << mgr1.getID() <<endl;
	cout << "Name: " << mgr1.getName() <<endl;
	cout << "Total Hours Worked This Week: " << mgr1.getTotalHours() <<endl;
	cout << "Hourly Rate of Pay: $" << mgr1.getRate() <<endl;
    	cout << "Bonus Pay This Week: $" << mgr1.getBonus() <<endl;
    	cout << "Gross Pay: $" << mgr1.getSalary() <<endl <<endl;

	cout << "Manager 1: " <<endl;
	mgr1.print();

	mgr2.setHours(hrsMgr2);
    	mgr2.setRate(35.0);
    	mgr2.setBonus(250.0);
    	mgr2.calcSalary();
	cout <<endl;

	cout << "Manager 2: " <<endl;
	mgr2.print();
	cout <<endl;

	mgr3 = mgr2;

	cout << "Manager 3: " <<endl;
	mgr3.print();
	cout <<endl;

	return 0;
}
