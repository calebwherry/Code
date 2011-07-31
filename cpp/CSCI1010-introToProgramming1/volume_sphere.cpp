//Caleb Wherry
//Program: volume_sphere.cpp
//Find the volume of a sphere. (4/3 pi r^3)
//September 6, 2006

#include <iostream>
using namespace std;

int main ()
{
	double pi, radius, volume;

	pi = 3.14159265;
	cout << "What is the radius of the sphere? ";
	cin >> radius;
	volume = 4/3.0 * pi * (radius * radius * radius);
	cout << "The volume of the sphere is " <<volume<< "." <<endl;
	return 0;
}
