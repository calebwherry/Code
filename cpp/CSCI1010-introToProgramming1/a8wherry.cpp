//Caleb Wherry
//Program: a8wherry.cpp
//CSCI 1010 Section 3
//Programming Assignment 8
//Due: 11-21-06
//Purpose: To seperate car serial numbers into two files by how many miles they have on them.

#include <fstream> //Library for ifstream and ofstream classes.
#include <string>
#include <iostream> 
using namespace std;

void outputfile (ofstream & fout, string serial_number); //Void function declaration.

int main() //Open main.
{
	string serial_number;     //Declares the string variable serial_number.
	int miles_driven;         //Declares the int variable miles_driven.
	
	ifstream infile;          //Declares file stream variable for in flie.
	ofstream outfile_under50; //*50 Thousand Miles* Declares file stream variable for out file.
	ofstream outfile_plus50;  //*50 Thousand Miles* Declares file stream variable for out file.

	infile.open("cars.dat");  //Opens in file to read data from.
	if ( infile.fail())       //Aborts the program and displays an error message if file does not exist.
	{
		cout << "File does not exist.";
		abort();
	}

	outfile_under50.open("under50.dat"); //Opens file to read data into for cars under 50,000 miles.

	outfile_plus50.open("50plus.dat");   //Opens file to read data into for cars over 50,000 miles.

	while ( !infile.eof() ) //Do loop until the "end of file".
	{	
		infile >> serial_number >> miles_driven; //Reads in information from data file.

		if (miles_driven < 50000) 
			outputfile (outfile_under50, serial_number); //Void fundtion call with correct ofstream passed.
		else 		  
			outputfile (outfile_plus50, serial_number);  //Void function call with correct ofstream passed.
		
		infile >> ws; //Skips over whitespace to next value in data file.
	}
	
	infile.close();          //Closes infile.
	outfile_under50.close(); //Closes outfile with cars under 50,000 miles. 
	outfile_plus50.close();  //Closes outfile with cars over 50,000 miles.

return 0;
} //Close main.

void outputfile (ofstream & fout, string serial_number) //Void function definition. Sends info to correct file.
{
	fout << serial_number <<endl; //Sends the serial number to the file that has been passed from main to the void function.
}
