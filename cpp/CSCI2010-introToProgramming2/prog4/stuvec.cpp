// Caleb Wherry
// 03-11-07
// stuvec.cpp
// Purpose: To organize student's information using the STL vector class.

#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

//***************************************************************

class Student
{
	protected:
		int studentID;
		string name;
		string phone_number;
		char type;
		int credits;

	public:
		Student()
		{
			studentID = 0;
			name = "";
			phone_number = "";
			type = ' ';
			credits = 0;
		}

		Student(int s, string n, string p, char t, int c)
		{
			studentID = s;
			name = n;
			phone_number = p;
			type = t;
			credits = c;
		}

		int getstudentID()  { return studentID; }
		
		string getname()  { return name; }

		string getphone_number()  { return phone_number; }

		char gettype()  { return type; }

		int getcredits()  { return credits; }
		
		void print()
		{
			cout << studentID << setw(18) << name << setw(16) 
                 	     << phone_number << setw(8) << type << setw(12) 
                             << credits << endl;
		}
};

//****************************************************************

int main()
{
	vector<Student> vec1;
	vector<Student>::iterator p;

	int studentID_in;
	string name_in;
	string phone_number_in;
	char type_in;
	int credits_in;
	bool found;

    	cout << endl << "ID: ";
	cin >> studentID_in;

	while (studentID_in != 0)
	{
		cout << "Name: ";
		cin.ignore(80, '\n');
		getline(cin, name_in);

		cout << "Phone Number: ";
		cin >> phone_number_in;

		cout << "Residency Type (R or N): ";
		cin >> type_in;
		
		cout << "Credits: ";
		cin >> credits_in;

		Student data(studentID_in, name_in, phone_number_in, type_in, credits_in);

		p = vec1.begin();
		found = false;
		while (p != vec1.end() && !found)
		{
			if (data.getstudentID() < (*p).getstudentID())
				found = true;
			else
				p++;
		}	
		
		vec1.insert(p, data);
			
		cout << endl;
		cin.ignore();
			
		cout << "ID: ";
		cin >> studentID_in;
	}

	cout << endl
	     << "************************************************" << endl
             << "Students In Ascending Order By Their Student ID" << endl
             << "************************************************" << endl << endl;
         
   	cout << setw(4) << "ID" << setw(18) << "Name" 
             << setw(16) << "Phone #" << setw(8) << "Type" 
             << setw(12) << "Credits" << endl
             << "---------------------------------------------------------------------" 
             << endl;

	p = vec1.begin();
	while (p != vec1.end())
	{
		(*p).print();
		p++;
	}

		// Non-Resident Student's In Descending Order By Name

	vector<Student> vec2;
	vector<Student>::iterator q;

	Student temp;

	p = vec1.begin();
	while (p != vec1.end())
	{
		temp = *p;
		
		if ((*p).gettype() == 'N' || (*p).gettype() == 'n')
		{	
			q = vec2.begin();
			found = false;
			while (q != vec2.end() && !found)
			{	
				if ( temp.getname() > (*q).getname())
					found = true;
				else
					q++;	
			}
			
			vec2.insert(q, temp);
		}

		p++;
	}

	cout << endl << endl
	     << "*********************************************************" << endl
             << "Non-Resident Student's In Descending Order By Their Name" << endl
             << "*********************************************************" << endl << endl;
         
   	cout << setw(4) << "ID" << setw(18) << "Name" 
             << setw(16) << "Phone #" << setw(8) << "Type" 
             << setw(12) << "Credits" << endl
             << "---------------------------------------------------------------------" 
             << endl;
         
	p = vec2.begin();
	while (p != vec2.end())
	{
		(*p).print();
		p++;
	}

                // Students In Ascending Order By Their Total Number Of Credits  

    	vector<Student> vec3;
	vector<Student>::iterator r;

	Student temp2;

	p = vec1.begin();
	while (p != vec1.end())
	{
		temp2 = *p;
		r = vec3.begin();
		found = false;
		while (r != vec3.end() && !found)
		{
			if (temp2.getcredits() < (*r).getcredits())
                 		found = true;
			else
                 		r++;	
		}
		
		vec3.insert(r, temp2);
		p++;
	}

	cout << endl << endl
	     << "*************************************************************" << endl
             << "Students In Ascending Order By Their Total Number Of Credits" << endl
             << "*************************************************************" << endl << endl;
         
   	cout << setw(4) << "ID" << setw(18) << "Name" 
             << setw(16) << "Phone #" << setw(8) << "Type" 
             << setw(12) << "Credits" << endl
             << "---------------------------------------------------------------------" 
             << endl;

	p = vec3.begin();
	while (p != vec3.end())
	{
		(*p).print();
		p++;
	}
	
	cout << endl;
    
    return 0;
}
