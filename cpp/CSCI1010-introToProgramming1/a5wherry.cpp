//Caleb Wherry
//Program: a5wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 5
//Due: 10-18-06
//Purpose: To equate mathematical equations from the input of the user.

#include <iostream>
#include <iomanip>
using namespace std;

char operators;

double add (double num1, double num2);
double subtract (double num1, double num2);
double multiply (double num1, double num2);
double divide (double num1, double num2);
void end (double num1, double num2, double total_value, char operators);

int main()
{
	int num_problems;
	double num1, num2, total_value;
	char letter;

	cout <<endl;
	cout <<"How many problems do you need to solve? ";
	cin >> num_problems;
			
		for (int n=1; n<=num_problems; n++)
		{
			cout <<"Enter an A, S, M or D: ";
			cin >> letter;
		
			switch (letter)
			{			
				case 'A' : case 'a':
					cout <<"Enter two real numbers to add: ";
					cin >> num1 >> num2;
					total_value = add (num1, num2);
					end (num1, num2, total_value, operators);
					cout <<endl;
					break;
				
				case 'S' : case 's':
					cout <<"Enter two real numbers to subtract: ";
					cin >> num1 >> num2;
					total_value = subtract (num1, num2);
					end (num1, num2, total_value, operators);
					cout <<endl;
					break;
				
				case 'M' : case 'm':
					cout <<"Enter two real numbers to multiply: ";
					cin >> num1 >> num2;
					total_value = multiply (num1, num2);
					end (num1, num2, total_value, operators);
					cout <<endl;
					break;
				
				case 'D' : case 'd':
					cout <<"Enter two real numbers to divide: ";
					cin >> num1 >> num2;
					if (num2 == 0)
						cout <<"Division by zero is not allowed!" <<endl <<endl;
					else
					{
						total_value = divide (num1, num2);
						end (num1, num2, total_value, operators);
						cout <<endl;
					}
					break;
				
				default:
					cout <<"Please enter an A, S, M or D." <<endl <<endl;
			}	
		}
	return 0;
}

double add (double num1, double num2)
{
	operators = '+';
	return num1 + num2;
}

double subtract (double num1, double num2)
{
	operators = '-';
	return num1 - num2;	 
}

double multiply (double num1, double num2)
{
	operators = '*';
	return num1 * num2;
}

double divide (double num1, double num2)
{
	operators = '/';
	return num1 / num2;
}

void end (double num1, double num2, double total_value, char operators)
{
	cout << setiosflags(ios::fixed | ios::showpoint)
	     << setprecision (1);
	cout <<num1<< " " <<operators<< " " << num2<< " = " <<total_value<< endl;
}
