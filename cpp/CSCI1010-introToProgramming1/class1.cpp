// class1.cpp
// elementary class demonstration

#include <iostream>

using namespace std;

class person {

        private:
           int idno;
           int age;
           float salary;

        public:
           person() { idno = 0;
                      age = 0;
                      salary = 0;
                    }
           person( int a, int b, float c)
                {
                   idno = a;
                   age = b;
                   salary = c;
                }
           void print()
           {
              cout << "ID No " << idno << endl;
              cout << "Age:  " << age << endl;
              cout << "Salary: " << salary << endl;
           }


           void readit()
           {
              cout << "Enter ID Number ";
              cin >> idno;
              cout << endl << "Enter Age ";
              cin >> age;
              cout << endl << "Enter Salary ";
              cin >> salary;

           }

           int getidno() { return idno; }
           int getage() { return age; }
           float getsalary() { return salary; }
};

int main()
{
   person one;
   person two( 1111, 25, 45000);


   one.print();
   cout << endl << endl;
   two.print();

   int a,b;
   float c;
   cout << "Enter ID Number ";
   cin >> a;
   cout << endl << "Enter Age ";
   cin >> b;
   cout << endl << "Enter Salary ";
   cin >> c;

   person three(a,b,c);
   three.print();

   cout << endl << endl;
   person four;
   four.readit();
   four.print();

   cout << endl << four.getidno();
   
   return 0;
}
