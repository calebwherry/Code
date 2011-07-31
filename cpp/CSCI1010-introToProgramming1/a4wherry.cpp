//Caleb Wherry
//Program: a4wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 4
//Due: 9-28-06
/*Purpose: To find the cost of an amount of shirts entered, in dollars, while taking into account discounts given.*/ 

#include <iostream>
using namespace std;

int main ()
{
	int shirts, cost;

	for ( int orders=1; orders<=8; orders++) 
	 {
		cout <<"Enter number of shirts: ";
		cin >> shirts;
		
		if (shirts<0) 
			cout <<"Error: Please enter a positive number."<<endl;
		else if (shirts<3 && shirts>=0)
			cost = shirts * 12;
		else if (shirts>=3 && shirts<10)
			cost = shirts * 10;
		else if (shirts>=10 && shirts<=24)
			cost = shirts * 8;
		else if (shirts>24)
			cout <<"Error: Maximum amount allowed to purchase is 24." <<endl;
		if (shirts>=0 && shirts<=24)
			cout <<"Cost of " <<shirts<< " shirts = $" <<cost<< endl;
		cout <<endl;
	 }
	
	return 0;
}
