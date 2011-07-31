// stuvec.cpp
// Jiang Li
// 10/19/2006

#include <iostream>
#include <vector> 
#include <string>
#include <iomanip>

using namespace std;

//==========================================================
// class to hold information

class Student
{
  private:
    int m_id;		// student ID 
    string m_name;	// student name
    string m_tel; 	// phone number
    char m_type;        // 'R' represents resident and 'N' represents nonresident
    int m_crds;      	// number of credits enrolled
    
  public:
    // default constructor
    Student()
    { 
      m_id = 0; m_name = ""; m_tel = ""; 
      m_type = ' '; m_crds = 0;
    }
    
    // constructor
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
//===================================================================

int main()
{
  vector<Student> vec1;
  vector<Student>::iterator p;

  bool found;
  int id;		       // temporary input variables
  string name, tel;
  char type;
  int crds;
  
  cout << endl << "ID: ";
  cin >> id;
  while (id) // exit if id == 0
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
    p = vec1.begin();                             // Move iterator to front
    found = false;
    while( p != vec1.end() && !found )            // Find the proper place for it
      if( stu.getID() < (*p).getID() )
        found = true;
      else
        p++;
  
    vec1.insert(p,stu);                        // Place it on the list
    cout << endl << "ID: ";
    cin >> id;                                 // Read next ID
  }
    p = vec1.begin();                          // move iterator to front
    
   // print list in order that it is stored
   // always know how to do this

   cout << endl << " Studnets In Ascending Order By ID" << endl;
   cout << setw(10) << "ID" << setw(15) << "Name" 
        << setw(15) << "Phone #" << setw(7) << "Type" 
        << setw(10) << "Credits" << endl;
   cout << " ---------------------------------------------------------------------" 
        << endl;
       
   while( p != vec1.end() )
   {
     (*p).print();
     p++;
   }

   // Place info in a new vector that includes only 
   // non-resident students in descending order by name
   //-----------------------------------------------------------------------
   vector<Student> vec2;
   vector<Student>::iterator q;
   Student temp2;
   p = vec1.begin();
   while( p != vec1.end() )
   {
     temp2 = *p;
     if ( temp2.getType() == 'N')
     {
       q = vec2.begin();
       found = false;
       while( q != vec2.end() && !found )
         if( temp2.getName() > (*q).getName() )
           found = true;
         else
           q++;

       vec2.insert(q,temp2);
     }
     p++;
  }

  // Print new list
  //-----------------------------------------------------------------------
  cout << endl << " Non-resident Students In Descending Order By Name " << endl;
  cout << setw(10) << "ID" << setw(15) << "Name" 
       << setw(15) << "Phone #" << setw(7) << "Type" 
       << setw(10) << "Credits" << endl;
  cout << " ---------------------------------------------------------------------" 
       << endl;
       
  q = vec2.begin();
  while( q != vec2.end() )
  {
    (*q).print();
    q++;
  }
  
   // Place info in a new vector that includes students
   // in ascending order by the total number of credits
   //-----------------------------------------------------------------------
   vector<Student> vec3;
   vector<Student>::iterator r;
   
   Student temp3;
   p = vec1.begin();
   while( p != vec1.end() )
   {
     temp3 = *p;
     r = vec3.begin();
     found = false;
     while( r != vec3.end() && !found )
       if( temp3.getCrds() < (*r).getCrds() )
         found = true;
       else
         r++;

     vec3.insert(r,temp3);
     p++;
  }

  // Print new list
  //-----------------------------------------------------------------------
  cout << endl << " Students In Ascending Order By Total Number Of Credits " << endl;
  cout << setw(10) << "ID" << setw(15) << "Name" 
       << setw(15) << "Phone #" << setw(7) << "Type" 
       << setw(10) << "Credits" << endl;
  cout << " ---------------------------------------------------------------------" 
       << endl;
       
  r = vec3.begin();
  while( r != vec3.end() )
  {
    (*r).print();
    r++;
  }
  
}
