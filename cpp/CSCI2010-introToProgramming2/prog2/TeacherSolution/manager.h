// manager.h		// declares Manager class
// Jiang Li
// 02/05/2007

#ifndef MANAGER_H
#define MANAGER_H

#include <string>
#include "employee.h"   // include declaration of Employee class

using namespace std;

class Manager : public Employee
{
   protected:
      int hours[5];     // number of hours worked per day
      int hrsWorked;    // total hours worked
      double rate;      // pay rate per hour
      double bonus;     // bonus

   public:

      // Postcondition: this name has been initialized from the given parameters
      Manager(int theId, string theName);
      
      // Postcondition: the number of hours worked per day has been set from the given array. 
      //                the total hours worked has been computed.
      void setHours(int theHours[]);
      
      //Precondition: the hoursWorked has been computed.
      //Postcondition: returns the total number of hours worked.
      int getTotalHours(); 
      
      // Postcondition: the pay rate per hour has been set from the given value. 
      void setRate(double theRate);

      //Postcondition: returns the payRate.
      double getRate();
            
      // Postcondition: the bonus pay has been set.
      void setBonus(double dBonus);
      
      //Postcondition: returns the name.
      double getBonus();
        
      // Postcondition: the salary has been computed.
      void calcSalary();

      // Postcondition: All information about this employee has been displayed.
      void print();

      // Postcondition: The current manager (calling object) contains a copy of otherManager.
      void operator= (const Manager& otherManager);
      	
      /* if you would allow the assignment like a = b = c; use the following solution
         const Manager& operator= (const Manager& otherManager);
      */

}; // Manager

#endif
