// manager.cpp		// implements Manager class
// Jiang Li
// 02/05/2007

#include <iostream>
#include <string>

#include "manager.h"   // include declaration of Manager class

using namespace std;

Manager::Manager(int theId, string theName)
{
   id = theId;     // id is a field of parent class Employee
   name = theName;	// name is a field of parent class Employee
   salary = 0.0;	// salary is a field of parent class Employee
   hrsWorked = 0;
   rate = 0.0;
   bonus = 0.0;
	
   for(int i=0; i<5; i++)
      hours[i] = 0;
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
{ return hrsWorked; }

void Manager::setRate(double theRate)
{ rate = theRate; }

double Manager::getRate()
{ return rate; }

void Manager::setBonus(double dBonus)
{ bonus = dBonus; }

double Manager::getBonus()
{ return bonus; }

void Manager::calcSalary()
{ salary = hrsWorked * rate + bonus; }

void Manager::print()
{
    cout << "The complete information about this employee: " << endl;
    cout << "--------------------------------------------- " << endl;
    cout << "ID: " << id << endl;
    cout << "Name: " << name << endl;
    cout << "Total hours worked per week: " << hrsWorked << endl;
    cout << "Hourly rate of pay: " << rate << endl;
    cout << "Bonus pay: " << bonus << endl;
    cout << "Salary: " << salary << endl;
    cout << "--------------------------------------------- \n" << endl;
}

void Manager::operator= (const Manager& otherManager)
{
   // id = otherManager.id	     // do not copy id
   // name = otherManager.name;      // do not copy name
   hrsWorked = otherManager.hrsWorked;
   rate = otherManager.rate;
   bonus = otherManager.bonus;
   salary = otherManager.salary;
    
   for(int i=0; i<5; i++)
      hours[i] = otherManager.hours[i];
	  
} // overloading =

/* If you would allow the assignment like a = b = c; use the following solution
const Manager& Manager::operator= (const Manager& otherManager)
{
   // id = otherManager.id	     // do not copy id
   // name = otherManager.name;      // do not copy name
   hrsWorked = otherManager.hrsWorked;
   rate = otherManager.rate;
   bonus = otherManager.bonus;
   salary = otherManager.salary;
    
   for(int i=0; i<5; i++)
      hours[i] = otherManager.hours[i];
      
   return *this; // enables a = b = c;
}  // overloading =	
*/
