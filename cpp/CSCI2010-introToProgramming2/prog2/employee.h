// employee.h	  // declares Employee class
// Jiang Li
// 01/29/2007

#ifndef EMPLOYEE_H
#define EMPLOYEE_H

#include <string>
using namespace std;

class Employee
{
   public:

      // Postcondition: this employee's name has been set to ""
      //                and salary to 0.0.
      Employee();
      
      // The employee has been created with id.
      Employee(int iId);
      
      int getID(); // return id
      
      void setName(string sName); // set name of the employee
    
      string getName(); // return name of the employee

      // The salary of this Employee have been set.
      void setSalary(double dSalary);
      
      // The salary has been returned;
      double getSalary();

      // this Employee's name and salary have been print out.
      void print();

      // Postcondition: this Employee contains a copy of otherEmployee.
      void getCopyOf (const Employee& otherEmployee);

   protected:
       int id;
       string name;
       double salary;
      
}; // Employee

#endif
