// employee.cpp		// implements Employee class
// Jiang Li
// 01/29/2007

#include <iostream>
#include "employee.h"

using namespace std;

Employee::Employee()
{
   id = 0;
   name = "";
   salary = 0.0;
} // default constructor

Employee::Employee(int iId)
{
   id = iId;
   name = "";
   salary = 0.0;
} // custom constructor
      
int Employee::getID()
{ return id; }
      
void Employee::setName(string sName)
{ name = sName; }

string Employee::getName()
{ return name; }

// Postcondition: The salary of this Employee have been set.
void Employee::setSalary(double dSalary)
{ salary = dSalary; }
      
// The salary has been returned;
double Employee::getSalary()
{ return salary; }

void Employee::print()
{ cout << name << "  $" << salary << endl; }

void Employee::getCopyOf (const Employee &otherEmployee)
{
   id = otherEmployee.id;
   name = otherEmployee.name;
   salary = otherEmployee.salary;
} // getCopyOf
