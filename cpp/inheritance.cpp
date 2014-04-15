////////////////////////////////////////
////////////////////////////////////////
//
//  Copyright (C) 2014 Korovasoft, Inc.
//
//  File:
//      \file inheritance.cpp
//
//  Description:
//      \brief Inheritance application
//
//  Author:
//      \author J. Caleb Wherry
//
////////////////////////////////////////
////////////////////////////////////////


// Compiler Includes:
#include <iostream>
#include <memory>

using namespace std;

// Base Class
class Base
{

  public:

    Base()
    {
      cout << "Calling from the Base class constructor!" << endl;
    }

    ~Base()
    {
      cout << "Calling from the Base class destructor!" << endl;
    }

    virtual void show()
    {
      cout << "Printing Base class!" << endl;
    }
};


// Derived class:
class Derived1 : public Base
{

  public:

    Derived1()
    {
      cout << "Calling from the Derived1 class constructor!" << endl;
    }

    ~Derived1()
    { 
      cout << "Calling from the Derived1 class destructor!" << endl;
    }

    virtual void show()
    {   
      cout << "Printing Derived1 class!" << endl;
    } 

};


// Derived2 class:
class Derived2: public Derived1
{

  public:

    Derived2()
    {
      cout << "Calling from the Derived2 class constructor!" << endl;
    }
    
    ~Derived2()
    { 
      cout << "Calling from the Derived2 class destructor!" << endl;
    }

    virtual void show()
    {
      cout << "Printing Derived2 class!" << endl;
    }

};


// Main:
int main(int argc, char* argv[])
{

  unique_ptr<Base> base1(new Base);

  {
    unique_ptr<Base> base2(new Base);
  }

  base1->show();

  shared_ptr<Derived1> derived1(new Derived1);
  derived1->show();

  shared_ptr<Base> baseDerived(new Derived2);
  baseDerived->show();

  return 0;

}
