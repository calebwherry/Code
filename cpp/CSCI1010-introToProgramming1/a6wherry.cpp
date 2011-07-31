//Caleb Wherry
//Program: a6wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 6
//Due: 10-27-06
//Purpose: To find the commission on the base sales of a salesman.

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

double commission (double actual_sales, double base_sales, double rate);

int main ()
{
	int id_number;
	string name;
	double base_salary, comp_sales, printer_sales, total_salary, comp_commission, printer_commission, total_commission;

	cout <<"Please enter salesperson's identification or -999 to terminate: ";
        cin >> id_number;
	cout <<endl;

	while (id_number != -999)
	{
		cout << setiosflags (ios::fixed | ios::showpoint)
		     << setprecision(2);
		
		cout <<"Please enter salesperson's name: ";
		cin.ignore (80, '\n');
		getline (cin, name);
		cout <<endl;

		cout <<"Please enter salesman's base salary: ";
		cin >> base_salary;
		cout <<endl;

		cout <<"Please enter personal computer sales: ";
		cin >> comp_sales;
		cout <<endl;

		cout <<"Please enter printer sales: ";
		cin >> printer_sales;

		cout <<endl<<endl;

		cout << setw(32) <<"APSU Computer Company" <<endl;
		cout << setw(31) <<"Commission Statement" <<endl;
		cout << setw(25) <<"SalesPerson " << id_number <<endl;
		cout << setw(26) << name <<endl;
		cout << setw(37) <<"   ***************************************" <<endl;

		cout <<"Product" << setw(23) <<"Sales Amount" << setw(13) <<"Commission" <<endl;
		
		comp_commission = commission (comp_sales, 5000, .1);
		cout <<"Personal Computers" << setw(12) << comp_sales << setw(13) << comp_commission <<endl;
		
		printer_commission = commission (printer_sales, 2000, .08);
		cout <<"Printers" << setw(22) << printer_sales << setw(13) << printer_commission <<endl<<endl;

		total_commission = comp_commission + printer_commission;
		cout <<"Total Commission" << setw(27) << total_commission <<endl;
		cout <<"Base Pay" << setw(35) << base_salary <<endl;
		
		total_salary = base_salary + total_commission;
		cout <<"Total Due" << setw(34) << total_salary <<endl<<endl;

		cout <<"Please enter salesperson's identification or -999 to terminate: ";
		cin >> id_number;
		cout <<endl;
	}
return 0;
}

double commission (double actual_sales, double base_sales, double rate)
{
	if (actual_sales < base_sales)
		return 0;
	else
		return actual_sales * rate;
}
