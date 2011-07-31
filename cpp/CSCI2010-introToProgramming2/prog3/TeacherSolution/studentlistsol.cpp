// studentlistsol.cpp
// Jiang Li
// 02/23/2007

#include <iostream>
#include <string>
#include <iomanip>
#include "linked.h"

using namespace std;

//========================================================================

class Student
{
  private:
    int m_id;		// student ID 
    string m_name;	// student name
    string m_tel; 	// phone number
    char m_type;        // 'R' represents resident and 'N' represent non-resident
    int m_crds;      	// number of credits enrolled
    
  public:
    // default constructor
    Student()
    { 
      m_id = 0; m_name = ""; m_tel = ""; 
      m_type = ' '; m_crds = 0;
    }
    
    // custom constructor
    Student(int id, string name, string tel, char type, int crds)
    { 
      m_id = id; m_name = name; m_tel = tel;
      m_type = type; m_crds = crds;
    }

    // get functions
    int getID() {return m_id;} 
    string getName() {return m_name;}
    string getTel() {return m_tel;}
    char getType() {return m_type;}
    int getCrds() {return m_crds;}
    
    // prints out the student's record
    void print()
    {
       cout << setw(10) << m_id << setw(15) << m_name 
            << setw(15) << m_tel << setw(7) << m_type 
            << setw(10) << m_crds << endl;   
    }  
};

//======================================================================== 

int main()
{
  Linked<Student> stuList;     // linked list of employees
  Linked<Student>::Iterator p; // iterator used to move through a linked list
  
  int id;		       // temporary input variables
  string name, tel;
  char type;
  int crds;
  
  cout << endl << "ID: ";
  cin >> id;
  while (id != 0) // exit if id == 0
  {
    cout << "Name: ";
    cin.ignore(80, '\n');
    getline(cin, name);
    
    cout << "Phone number: ";
    getline(cin, tel);
    
    cout << "Type (R / N): ";
    cin >> type;
    type = toupper(type);  // convert it to uppercase letter
    
    cout << "Credits: ";
    cin >> crds;
    
    Student stu(id, name, tel, type, crds); // create a new Student object
    stuList.push_front(stu);	// put it on the list (in the front)
    
    cout << endl << "ID: ";
    cin >> id;
  }     
  
  //-----------------------------------------------------------------------
 
  Linked<Student> newStuList;   // create a new linked list

  p = stuList.begin();          // move to beginning of the old list
  while( p != stuList.end() )   // while( !p.atEnd() )
  {
    Student stu(*p);            // create a new Student object from item 
                                // in old list using default copy constructor
    newStuList.push_front(stu); // put object on new list
    p++;                        // move to next node on the old list
  }
  
  cout << endl << " Students In Order They Were Entered" << endl;
  cout << setw(10) << "ID" << setw(15) << "Name" 
       << setw(15) << "Phone #" << setw(7) << "Type" 
       << setw(10) << "Credits" << endl
       << " ---------------------------------------------------------------------" 
       << endl;
       
  p = newStuList.begin();        // move to the beginning of the new list
  while( p != newStuList.end() ) // while( !p.atEnd() )
  {
    (*p).print();                // print information from new list
    p++;                         // move to next node on the new list
  }
  
  //-----------------------------------------------------------------------
  cout << endl << " Resident Students" << endl;
  cout << setw(10) << "ID" << setw(15) << "Name" 
       << setw(15) << "Phone #" << setw(7) << "Type" 
       << setw(10) << "Credits" << endl
       << " ---------------------------------------------------------------------" 
       << endl;
  
  p = stuList.begin();           // move back to the beginning of the (old) list
  while( !p.atEnd() )
  {
    if( (*p).getType() == 'R' )
    {
      (*p).print();
    }
    p++;                         // move to the next node on the list
  }

  //-----------------------------------------------------------------------
  cout << endl << " Students With 12+ Credits" << endl;
  cout << setw(10) << "ID" << setw(15) << "Name" 
       << setw(15) << "Phone #" << setw(7) << "Type" 
       << setw(10) << "Credits" << endl
       << " ---------------------------------------------------------------------" 
       << endl;
  
  p = stuList.begin();           // move back to the beginning of the (old) list
  while( !p.atEnd() )
  {
    if( (*p).getCrds() > 12 )
    {
      (*p).print();
    }
    p++;                         // move to the next node on the list
  }
  
  cout << endl;

  return 0;

}
