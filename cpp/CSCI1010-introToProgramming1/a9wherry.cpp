//Caleb Wherry
//Program: a9wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 9
//Due: 12-4-06
//Purpose: To sort the social security numbers, names, GPAs and find the average GPA of students using vectors and arrays.

#include <iostream>
#include <iomanip>
#include <fstream>
#include <vector>
#include <string>
using namespace std;

int main ()
{
	vector<int> student_number(35);
	vector<string> student_name(35);
	double student_gpa[35];
	ifstream infile;

	infile.open("students.dat");
	if (infile.fail())
        {
                cerr << "Unable to open file." <<endl;
                abort();
        }

	cout << setiosflags (ios::fixed | ios::showpoint)
             << setprecision(2);

	int i=0;
	while (infile >> ws && !infile.eof())
	{
		infile >> student_number[i];
		infile.ignore();
		getline (infile, student_name[i]);
		infile >> student_gpa[i];
		i++;
	}

	double total=0;
	for (int k=0; k<i; k++)
		total += student_gpa[k];

	double average;
	average=total/i;

	cout << endl;
	cout << "SS Number" << setw(9) << "Name" << setw(15) << "GPA" <<endl;

	for (int j=i-1; j>=0; j--)
		cout << student_number[j] << setw(5 + student_name[j].length()) << student_name[j] << setw(20 - student_name[j].length()) << student_gpa[j] <<endl;

	cout << endl;
	cout << "Total Number of Students: " << i <<endl;
        cout << "Average GPA: " << average <<endl <<endl;

	infile.close();
	
	return 0;
}
