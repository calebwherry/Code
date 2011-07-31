// stuadv.cpp
// Jiang Li

#include <iostream>
#include <deque> 

using namespace std;

struct Student 		// data type to store information
{
  string name;
  char category;
};

struct Advisor
{
  int advcode;
  string name;
  int nstuadv;		// number of students seen
};

int main()
{
  deque<Student> req[4];  	// deques to store request information
  Student stu;        		// struct to hold info for one person
  
  Advisor adv[4];		// structs to store advisor information
  
  adv[0].advcode = 2918;
  adv[0].name = "Higgins";
  adv[1].advcode = 4502;
  adv[1].name = "Beard";
  adv[2].advcode = 3408;
  adv[2].name = "Watson";
  adv[3].advcode = 5644;
  adv[3].name = "Sherwood";
  
  for (int i=0; i<4; i++)
    adv[i].nstuadv = 0;
  
  char reqcode;
  int advcode;
  bool isValid;
  
  cout << endl << "Request Code: ";
  cin >> reqcode;
  reqcode = toupper(reqcode);
  
  while (reqcode != 'Q') 	// exit if request code is Q
  {
    if (reqcode == 'R')		// request to see an advisor 
    {
      cout << "Student Name: ";
      cin.ignore(80, '\n');
      getline(cin, stu.name);
      cout <<"Category: ";
      cin >> stu.category;
      stu.category = toupper(stu.category);
      
      switch (stu.category)
      {
      	case 'S':
      	  req[0].push_back(stu);
      	  break;
      	case 'W':
      	  req[1].push_back(stu);
      	  break;
      	case 'O':
      	  req[2].push_back(stu);
      	  break;
      	case 'T':
      	  req[3].push_back(stu);
      	  break;
      	default:
      	  cout << "Invalid Category" << endl;
      } // end switch
    } // end if
    
    else if (reqcode == 'A')	// advisor available to see a student
    {
      cout <<"Advisor Code: ";
      cin >> advcode;
      isValid = false;
      for (int i=0; i<4; i++)
        if(adv[i].advcode == advcode)
        {
          if (req[i].empty())
            cout << "No students are waiting to see this advisor. " << endl;
          else
          {
            stu = req[i].front();
            req[i].pop_front();
            cout << adv[i].name << " is advising student " << stu.name << endl;
            adv[i].nstuadv++;
          }
          isValid = true;
        }
      if (!isValid)
        cout << "Invalid Advisor Code" << endl;
    } // end else if
    
    else
      cout << "Invalid Request Code" << endl;
         
    cout << endl << "Request Code: ";
    cin >> reqcode;
    reqcode = toupper(reqcode);
  } // end while
  
  // Print out information after receiving input 'Q'
  for (int i=0; i<4; i++)
  {
    if (!req[i].empty())
    {
      cout << "The following students are waiting for advisor " 
           << adv[i].name << ": " << endl;
      for (int j=0; j<req[i].size(); j++)                          
      {
        stu = req[i][j];
        cout << stu.name << endl;
      }
      cout << endl;
    }
    cout << adv[i].name << " has seen " << adv[i].nstuadv << " student(s). \n\n";
  }
}
