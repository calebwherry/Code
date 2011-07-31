//Caleb Wherry
//Program: area_rec.cpp
//Finds the volume of a rectangular shape.
//September 6, 2006

#include <iostream>
using namespace std;

int main ()
{
	int length, width, height, area;	
 	
	cout << "What is the length? ";
	cin >> length;
	cout << "What is the width? ";
	cin >> width;
	cout << "What is the height? ";
	cin >>height;
	area = length * width * height;
	cout << "The area is " <<area<< "." <<endl;
	return 0;
}

	  
