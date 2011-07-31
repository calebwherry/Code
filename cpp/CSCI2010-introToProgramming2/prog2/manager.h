// Caleb Wherry
// 02-05-2007
// manager.h
// Purpose: To declare Manager class.
 
#ifndef MANAGER_H
#define MANAGER_H

#include <string>
#include "employee.h"

using namespace std;

class Manager : public Employee
{
	protected:
		int hours[5];
		int hrsWorked;
		double pay_rate;
		double bonus;

	public:
		  // Postcondition: This name has been intialized from the given parameter.
		Manager(int theId, string theName);

		  // Postcondition: The number of hours worked per day has been set from
		  //                the given array. The total hours worked has been computed.
		void setHours(int theHours[]);

		  // Precondition: The hoursWorked has been computed.
		  // Postcondition: Returns the total number of hours worked.
		int getTotalHours();

		  // Postcondition: The pay rate per hour has been set from the given value.
		void setRate(double theRate);

		  // Postcondition: Returns the payRate.
		double getRate();

		  // Postcondition: The bonus pay has been set.
		void setBonus(double theBonus);

		  // Postcondition: Returns the bonus.
		double getBonus();

		  // Postcondition: The salary has been computed.
		void calcSalary();

		  // Postcondition: All information about this employee has been displayed.
		void print();

		  // Postcondition: The current manager contains a copy of other Manager.
		void operator= (const Manager& otherManager);
};
#endif		
