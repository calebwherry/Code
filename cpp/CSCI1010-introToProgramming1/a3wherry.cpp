//Caleb Wherry
//Program: a3wherry.cpp
//CSCI 1010 Section 03
//Programming Assignment 3
//Due: 9-22-06
/*Purpose: To find the number of different bills in an amount of money, in dollars, input from the user.*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int usd, usd_20, usd_10, usd_5, usd_1;  //usd = United States Dollars
	
	cout <<"Enter the amount of dollars: ";
	cin >> usd;
	cout <<endl;

	cout <<"In $" <<usd<< " there are:" <<endl;
	
	cout <<"$50 bills: " <<usd / 50<<endl;
	
	usd_20 = usd % 50;
	cout <<"$20 bills: " <<usd_20 / 20<<endl;
	
	usd_10 = usd_20 % 20;
	cout <<"$10 bills: " <<usd_10 / 10<<endl;
	
	usd_5 = usd_10 % 10;
	cout <<"$ 5 bills: " <<usd_5 / 5<<endl;
	
	usd_1 = usd_5 % 5;
	cout <<"$ 1 bills: " <<usd_1 / 1<<endl;
	return 0;
}
