// Caleb Wherry
// MP6.cpp
// 07-02-07

#include <iostream>

using namespace std;

void display_menu();
void process_request(char);

int main()
{
  int request;
  do
  {
    display_menu();
    cout << "Enter Your Request: ";
    cin >> request;
    cout << endl;
    process_request(request);
  }
  while (request != 0);

  return 0;
}

void display_menu()
{
  cout << endl << "Request Codes" << endl;
  cout << "------------------------------------------" << endl;
  cout << "1: List All Files In The Current Directory" << endl;
  cout << "2: Change To A Subdirectory" << endl;
  cout << "3: Change Subdirectory To Parent Directory" << endl;
  cout << "4: Copy File To Another File" << endl;
  cout << "5: Delete File" << endl;
  cout << "0: Exit Program " << endl << endl;
}

void process_request(char request)
{
  string file1, file2, command;

  switch (request)
  {
    case 1:
	   system("ls -c1 | sort");
	   break;
    case 2:
	   cout << "Enter A Subdirectory: ";
           cin >> file1;
	   command = "cd " + file1;
	   system(command.c_str());
	   cout << "Current Directory: ";
	   system("pwd");
	   cout << endl;
	   break;
    case 3:
	   system("cd ..");
	   cout << "Current Directory: "; 
	   system("pwd");
	   cout << endl;
	   break;
    case 4:
	   cout << "Enter The File To Copy And The File To Be Copied To: ";
	   cin >> file1, file2;

	   char choice1;
	   command = "grep " + file2;
	   if (command == file2)
	   {
	     cout << "File to copy to already exists. Do you want to overwrite the file? (Y/N) ";
	     cin >> choice1;
	     choice1 = toupper(choice1);
             if (choice1 == 'Y')
	     {
	       command = "cp " + file1 + " " + file2;
	       system(command.c_str());
	     }
	     else
	       break; 
	   }
	   else
	   {
	     command = "cp " + file1 + " " + file2;
	     system(command.c_str());
	   }
	   break;
    case 5:
	   cout << "Enter A File To Be Deleted: ";
	   cin >> file1;

	   char choice;
	   cout << "Are You Sure You Want To Delete This File? (Y/N) ";
	   cin >> choice;
	   choice = toupper(choice);
	   if (choice == 'Y')
	   {
	      command = "rm " + file1;
	      system(command.c_str());
	      cout << file1 << " Has Been Deleted." << endl;
	   }
	   else if (choice == 'N')
	     cout << file1 << " Was Not Deleted." << endl;
	   else
	      cout << "You Did Not Enter A Correct Y/N Value!" << endl;
	   break;
    case 0:
	   cout << "Program Terminated." << endl << endl;
	   break;
    default:
	    cout << "Please Enter A Correct Request Code!" << endl;
  }
}
