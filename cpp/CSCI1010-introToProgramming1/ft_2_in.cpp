// ft_2_in.cpp
// Convert input number of feet to inches.
#include <iostream>
using namespace std;

int main()
{
	int feet, inches;
	cout << "Enter number of feet: ";
	cin >> feet;
	inches = 12 * feet;
	cout << "That's " <<inches<< " inches." << endl;
	return 0;
}

