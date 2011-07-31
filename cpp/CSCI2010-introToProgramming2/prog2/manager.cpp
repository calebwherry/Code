// Caleb Wherry
// 02-05-2007
// manager.cpp
// Purpose: To implement Manager class.

#include <iostream>
#include <string>
#include "manager.h"

using namespace std;

Manager::Manager(int theId, string theName)
{
	id = theId;              //*****
	name = theName;	         // Inherited fields from parent class Employee initialized.
	salary = 0.0;            //*****

	hrsWorked = 0;           //*****
	pay_rate = 0.0;          //*****
	bonus = 0.0;             // Fields from Manager class initialized.
				 //*****
	for(int i=0; i<5; i++)   //*****
		hours[i] = 0;    //*****
}

void Manager::setHours(int theHours[])
{
	for(int i=0; i<5; i++)
	{
		hours[i] = theHours[i];
		hrsWorked += hours[i];
	}
}

int Manager::getTotalHours()
{
	return hrsWorked;
}

void Manager::setRate(double theRate)
{
	pay_rate = theRate;
}

double Manager::getRate()
{
	return pay_rate;
}

void Manager::setBonus(double theBonus)
{
	bonus = theBonus;
}

double Manager::getBonus()
{
	return bonus;
}

void Manager::calcSalary()
{
	salary = hrsWorked * pay_rate + bonus;
}

void Manager::print()
{
	cout << "ID: " << id <<endl;
	cout << "Name: " << name <<endl;
	cout << "Total Hours Worked This Week: " << hrsWorked <<endl;
	cout << "Hourly Rate of Pay: $" << pay_rate <<endl;
	cout << "Bonus Pay This Week: $" << bonus <<endl;
	cout << "Gross Pay: $" << salary <<endl;
}

void Manager::operator= (const Manager& otherManager)
{
	hrsWorked = otherManager.hrsWorked;
	pay_rate = otherManager.pay_rate;
	bonus = otherManager.bonus;
	salary = otherManager.salary;
}
