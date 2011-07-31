//Caleb Wherry
//Program: a7wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 7
//Due: 11-6-06
//Purpose: To read in 3 student test scores, find the average of the scores, and display the final average.

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

void students_name (string & sname);
double avg (int & score1, int & score2, int & score3);
void display_output (string name, int test1, int test2, int test3, double average);

int main()
{
	string name;
	int test1, test2, test3;
	double average;

	students_name (name);

	while (name != "DONE")
	{
		average = avg (test1, test2, test3);
		
		display_output (name, test1, test2, test3, average);
		
		cout << endl;
		cout << "Please enter the student's name or DONE to quit: ";
		cin.ignore (80, '\n');
		getline (cin, name);
	}
	return 0;
}


void students_name (string & sname)
{
	cout << "Please enter the student's name or DONE to quit: ";
	getline (cin, sname);
}


double avg (int & score1, int & score2, int & score3)
{
	cout << "Please enter his/her 3 test scores: ";
	cin >> score1 >> score2 >> score3 ;
	return (score1 + score2 + score3) / 3.0;
}


void display_output (string name, int test1, int test2, int test3, double average)
{
	cout << setiosflags (ios::fixed | ios::showpoint)
	     << setprecision (2);	

	cout << "Student's Name: " << name <<endl;
	cout << "His/Her 3 test scores: " << test1 << " " << test2 << " " << test3 << endl;
	cout << "Average Grade: " << average << endl;
}
