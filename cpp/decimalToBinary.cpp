// J. Caleb Wherry
// 24th April 2010
// Decimal To Binary Conversion

#include <iostream>
#include <string>
#include <math.h>

using namespace std;

int main(int argc, char* argv[]) {

  string binary = "";
  int len = 0, decimal = 0, count = 0;

  cout << "Welcome to My Binary To Decimal Convertor" << endl;
  cout << "-----------------------------------------" << endl;
  cout << endl;
  cout << "Enter a binary number: ";
  cin >> binary;

  while ( binary != "-999") {

    len = binary.length();
    decimal = 0;
    count = 0;

    for (int i=len-1; i >= 0; i--)
      if ( binary[count++] == '1' ) decimal += pow(2,i);

    cout << "  Decimal Form: " << decimal << endl << endl;

    cout << "Enter a binary number: ";
    cin >> binary;
  }

  return 0;
}
