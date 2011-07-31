//Caleb Wherry
//Program: a2wherry.cpp
//CSCI 1010 Section 03
//Programming Assignment 2
//Due: Friday 9-15-06
/*Purpose: To find the total value, in cents, from the number of dimes and nickels put into a machine.*/

#include <iostream>
using namespace std;

int main ()
{
    int dimes, nickels, total;	

	cout << "How many dimes were put in? ";
        cin >> dimes;
	cout << "How many nickels were put in? ";
	cin >> nickels;
	cout <<endl;
	cout <<"Number of dimes put in: " <<dimes<< endl;
	cout <<"Number of nickels put in: " <<nickels<< endl;
	total = (dimes * 10) + (nickels * 5);
	cout <<"The total amount deposited was " << total << " cents." 	<<endl;
	return 0;
}
