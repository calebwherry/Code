// Caleb Wherry
// 6-18-07
// Purpose: To allow management of the memory on a 512K system.

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
  char command;
  int mem_arr [512];
  int mem_locat;
  int mem_val;

  for (int i=0; i<512; i++)
  {
    mem_arr[i] = -99;
  }

  cout << endl;
  cout << "Program Key" << endl;
  cout << "---------------------------------------------------------------------------------" << endl;
  cout << "D: Accept a memory location and a value and deposit this value into the location" << endl;
  cout << "E: Accept a memory location and display the value sored at that location." << endl;
  cout << "C: Accept a memory location and replace the value stored in the location by -99" << endl;
  cout << "V: Display the contents of the entire memory unit." << endl;
  cout << "Q: Terminate Program" << endl;
  cout << "---------------------------------------------------------------------------------" << endl << endl;

  cout << "Enter A Command: ";
  cin >> command;
  command = toupper(command);

  while (command != 'Q')
  {
    switch(command)
    {
      case 'D': cout << "   Enter A Memory Location: ";
		cin >> mem_locat;
		cout << "   Enter A Memory Value: ";
		cin >> mem_val;

		if (mem_locat > 512)
		  cout << "Memory Location Out Of Memory Range!" << endl;
		else
		  mem_arr[mem_locat] = mem_val;
		break;

      case 'E': cout << "   Enter A Memory Location: ";
		cin >> mem_locat;

		if (mem_locat > 512)
		  cout << "Memory Location Out Of Memory Range!" << endl;
		else
		  cout << "   "  << mem_arr[mem_locat] << endl;
		break;

      case 'C': cout << "   Enter A Memory Location: ";
		cin >> mem_locat;

		if (mem_locat > 512)
		  cout << "Memory Location Out Of Memory Range!" << endl;
		else
		  mem_arr[mem_locat] = -99;
		break;

      case 'V': cout << endl;
		for (int i=0; i<512; i++)
		{
		  if ( (i)%16 == 0)
		    cout <<endl;
		  cout << mem_arr[i] << " ";
		}
		cout << endl;
		break;

      default: cout << command << " is not an acceptable command!" << endl;
		
    }

    cout << endl << "Enter A Command: ";
    cin >> command;
    command = toupper(command);
  }

  cout << endl << "Program Terminated." << endl << endl;

  return 0;   
}
