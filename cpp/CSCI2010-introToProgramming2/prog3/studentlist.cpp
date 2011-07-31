// Caleb Wherry
// 02-15-07
// studentlist.cpp
// Purpose: To implement the linked header file and test the class Student.

#include <iostream>
#include <string>
#include <iomanip>
#include "linked.h"

using namespace std;

class Student
{
	private:
		int studentID;         // Student ID Number
		string name;           // Student Name
		string phone_number;   // Student Telephone Number
		char type;             // i.e. 'R' represents resident and 'N' represent nonresident
		int credits;           // Total Credits Per Semester

	public:
		Student()
		{
			studentID = 0;
			name = "";
			phone_number = "";
			type = ' ';
			credits = 0;
		}

		Student(int studentID_in, string name_in, string phone_number_in, char type_in, int credits_in)
		{
			studentID = studentID_in;
			name = name_in;
			phone_number = phone_number_in;
			type = type_in;
			credits = credits_in;
		}

		char getType()
		{
			return type;
		}		
		int getCredits()
		{
			return credits;
		}

		void print()
		{
			cout << studentID << setw(18) << name 
			     << setw(16) << phone_number
			     << setw(8) << type  << setw(12) << credits << endl;
		}			
};

int main()
{
	Linked<Student> stuList;
	Linked<Student>::Iterator p;

	int id;
	string name;
	string phone_number;
	char type;
	int credits;
	
	cout << endl;
	cout  << "ID: ";
	cin >> id;

	while (id != 0)
	{
		cout << "Name: ";
		cin.ignore(80, '\n');
		getline(cin, name);

		cout << "Phone Number: ";
		cin >> phone_number;

		cout << "Type (R or N): ";
		cin >> type;

		cout << "Credits: ";
		cin >> credits;

        Student stu(id, name, phone_number, type, credits);  
        stuList.push_front(stu); 

		cout << endl;
		cout << "ID: ";
		cin >> id;		
	}

	Linked<Student> newStuList;

 	p = stuList.begin();          
  	while( p != stuList.end() )  
  	{
    		Student stu(*p);           
                newStuList.push_front(stu);
    		p++;                       
  	}
  
	cout << endl;
  	cout << "Students In Order They Were Entered" << endl;
  	cout << setw(4) << "ID" << setw(18) << "Name" 
         << setw(16) << "Phone #" << setw(8) << "Type" 
         << setw(12) << "Credits" << endl
         << "---------------------------------------------------------------------" 
         << endl;
       
  	p = newStuList.begin(); 
  	while( p != newStuList.end() ) 
  	{
    		(*p).print();                
    		p++;                         
  	}

	cout << endl;
    cout << "Resident Students" << endl;
    cout << setw(4) << "ID" << setw(18) << "Name"
         << setw(16) << "Phone #" << setw(8) << "Type"
         << setw(12) << "Credits" << endl
         << "---------------------------------------------------------------------"
         << endl;

    p = newStuList.begin();
    while ( p != newStuList.end() )
    {
          if ( (*p).getType() == 'R' || (*p).getType() == 'r')
          {
               (*p).print();
          }
		
    p++;
	}

	cout << endl;
    cout << "Students With 12+ Credits" << endl;
    cout << setw(4) << "ID" << setw(18) << "Name"
         << setw(16) << "Phone #" << setw(8) << "Type"
         << setw(12) << "Credits" << endl
         << "---------------------------------------------------------------------"
         << endl;

    p = newStuList.begin();
    while ( p != newStuList.end() )
    {
          if ( (*p).getCredits() >= 12)
          {
               (*p).print();
          }
		
          p++;
     }
	
	cout << endl;

	return 0;
}
