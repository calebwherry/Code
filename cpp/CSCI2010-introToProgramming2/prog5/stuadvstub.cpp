// stuadvstub.cpp
// Jiang Li

#include <iostream>
#include <string>
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
  Student stu;        		// struct to hold info for one student
  
  Advisor adv[4];		// structs to store advisor information
  
  // Initialize advisor information
  // e.g. adv[0].advcode = 2918;
  //      adv[0].name = "Higgins";
  //	  adv[0].nstuadv = 0;
  
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
      // 1. input student's name and category, e.g.,
      // Student Name: Brown, Susan
      // Category: O
      
      // 2. put (push_back) student's request into the appropriate deque
      // based on the student's category
      
    } // end if
    
    else if (reqcode == 'A')	// advisor available to see a student
    {
      // 1. input advisor code, e.g., 3408
      
      // 2. Use this code to find the advisor, e.g., adv[2], 
      //    then check req[2] (because req[i] holds requests for adv[i])
      //    If a student is waiting to see the advisor, i.e., adv[2] is not empty
      //    print the student's name and the advisor's name,
      //    and remove (pop_front) that student from the deque. 
      
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
      // print students who are waiting to see an advisor in each deque
    }
    
    // print the total number of students seen by each advisor 

  }
}
