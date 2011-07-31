// Caleb Wherry
// bstchecks.cpp
// 04/20/07
// Purpose: To input and delete checks using the binary search tree.

#include<iostream>
#include<iomanip>
#include<fstream>
#include<string> 
#include "bst.h"

using namespace std;

class Check
{
	private:
		int chkNbr; 
    		string payeeName; 
    		string date; 
    		double amount;

	public:
    		Check()
    		{
     			chkNbr = 0;
			payeeName = "";
			date = "";
			amount = 0.0; 
    		}
 
    		void setdata(int a, string b, string c, double d)
    		{
			chkNbr = a;
			payeeName = b;
			date = c;
			amount = d;    		 
    		}
 		
   		friend bool operator<( const Check& a, const Check& b)
   		{
     			return a.chkNbr < b.chkNbr;
   		}
   
     		friend ostream &operator<<( ostream& os, const Check& w )
   		{
    	 		os << setw(15) << w.chkNbr << setw(20) << w.payeeName << setw(20) 
        		   << w.date << setw(20) << w.amount << endl;
   		} 
};

int main()
{
	Check x;
	BinSearchTree<Check> tree;
  	BinSearchTree<Check>::Iterator p;
  
  	int chkNbr; 
  	string payeeName; 
  	string date; 
  	double amount;
   
  	ifstream fin;

  	fin.open("checks.dat");
  	if( fin.fail() )
  	{
   		cout << "Data File Not Available " << endl;
    		exit(1);
  	}
 
  	while (!fin.eof())
  	{
    		fin >> chkNbr;
    		fin.ignore();
    		getline(fin, payeeName);
    		fin >> date;
    		fin >> amount;
    		fin.ignore();
    		fin.ignore();
     
    		x.setdata(chkNbr, payeeName, date, amount);
    		tree.insert(x); 
  	}
  
  	cout << endl << setw(15) << "Check number" << setw(20) << "Payee Name"
       	     << setw(20) << "Date" << setw(20) << "Amount" << endl;

  	p = tree.begin();
  	while(p != tree.end())
  	{
    		cout << (*p);
    		p++;
  	}
  
  	cout << endl << "Enter a check number to find (0 to quit): ";
  	cin >> chkNbr;
  
  	while (chkNbr != 0)
  	{
    		x.setdata(chkNbr, "", "", 0.0); 
    		p = tree.find(x);
    
    		if (p != tree.end())
      			cout << *p;
    		else 
      			cout << "Can't Find Check #" << chkNbr << "!!" << endl;
      
    		cout << endl << "Enter a check number to find (0 to quit): ";
    		cin >> chkNbr;
  	}

	cout << endl <<  "*********************************************" << endl;
  
  	cout << endl << "Enter a check number to delete (0 to quit): ";
  	cin >> chkNbr;
  	
  	while (chkNbr != 0) 	
  	{
		x.setdata(chkNbr, "", "", 0.0);
	        p = tree.find(x);

		if (p != tree.end())
		{
			tree.erase(p);
			cout << "Check #" << chkNbr << " has been deleted!" << endl;
		}
		else
			cout << "Can't Find Check #" << chkNbr << "!!" << endl;

 		cout << endl << "Enter a check number to delete (0 to quit): ";
	        cin >> chkNbr; 
  	}
  
  	cout << endl << setw(15) << "Check number" << setw(20) << "Payee Name"
             << setw(20) << "Date" << setw(20) << "Amount" << endl;

        p = tree.begin();
        while(p != tree.end())
        {
                cout << (*p);
                p++;
        }  
  
 	cout << endl <<  "Enter two new checks: " << endl;
  
  	for (int i = 0; i < 2; i++)
  	{
		cout << "Number: ";
       		cin >> chkNbr;

		cout << "Name: ";
		cin.ignore();
		getline(cin, payeeName);

		cout << "Date: ";
		getline(cin, date);

		cout << "Amount: ";
		cin >> amount;
		cout << endl;

		x.setdata(chkNbr, payeeName, date, amount);
		tree.insert(x);
  	}
  
  	cout << setw(15) << "Check number" << setw(20) << "Payee Name"
             << setw(20) << "Date" << setw(20) << "Amount" << endl;

        p = tree.begin();
        while(p != tree.end())
        {
                cout << (*p);
                p++;
        }

	cout << endl;
   
  	return 0;
}
