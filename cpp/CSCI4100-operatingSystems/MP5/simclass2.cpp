// Modified by Caleb Wherry for Machine Problem #5
// simclass2.cpp
// CSCI 4100: Operating System Concepts
// 06-27-07

//  simclass.cxx
//  a simulation of shortest remaining time first processor scheduling
//  C. Bruce Myers

#include <iostream>
#include <iomanip>
#include <deque>

using namespace std;

// Struct to represent process

struct process 
{
  int idno;
  int ready;            // start time
  int run;              // run time
  int remaining;        // time remaining
  int active;           // is process active?
  int finish;           // finish time
};

// Primitive class to represent system clock

class myclock
{
  protected:
    int clock99;        // represent time on clock
                        // clock itself is a predefined function name
  public:
    myclock() { clock99 = 0; }
    void setclock( int w ) { clock99 = w; }
    void tick() { clock99++; }
    int gettime() { return clock99; }
};

//  This class represents the processor and the list of jobs waiting
//  for the processor

class processor
{
  protected:
    int maxjobs;        // maximum number of jobs
    int jobsub;         // location of next job to be added, also # of jobs
    int current_id;     // subscript of job currently running
    int previous_id;
    int quantum;        // maximum length of time a job may run
    int elapsed;        // time current job has been running
    process * list;     // list of processes that want to use processor

  public:

    // constructor

    processor (int q, int n)
    {
      maxjobs = n;
      jobsub = 0;
      elapsed = 0;
      current_id = -1;
      previous_id = -1;
      quantum = q;
      list = new process[n];
    }

    // place a single job into a queue

    int insertjob (int id, int start, int run)
    {
      if (jobsub < maxjobs)
      {
        list[jobsub].idno = id;
        list[jobsub].ready = start;
        list[jobsub].run = run;
        list[jobsub].remaining = run;
        list[jobsub].active = 0;
        list[jobsub].finish = -1;
        jobsub++;
        return 1;
      }
      else
        return 0;
    }

    //  display all jobs in the queue

    void printlist()
    {
      if (jobsub > 0)
        for (int i = 0; i < jobsub; i++)
        {
          cout << list[i].idno << setw(10) << list[i].ready << setw(10)
               << list[i].run << setw(10) << list[i].finish;

          if (list[i].finish != -1)
            cout << setw(10) << list[i].finish - list[i].ready << endl;
          else
            cout << endl;
        }
    }

    //  determine if any jobs are left to run

    int jobsleft()
    {
      int temp = 0;
      for (int i=0; i < jobsub ; i++)
        if (list[i].remaining != 0)
          temp = 1;
      return temp;
    }

    //  make all processes that become ready at the current time active

    void fixready (int t)
    {
      for (int i=0; i < jobsub; i++)
        if (list[i].ready == t)
          list[i].active = 1;
    }

    //  are there any active processes?

    int anyactive()
    {
      int temp = 0;
      for (int i = 0; i < jobsub; i++)
        if (list[i].active)
          temp = 1;
      return temp;
    }


    //  actual work of the simulation, checks quantum, performs context
    //  switch if necessary, and updates statistics


    void check (int t)
    {
      if (current_id != -1)
      {
        if (list[current_id].remaining == 0)
        {
          list[current_id].finish = t;
          list[current_id].active = 0;
          previous_id = -1;
          current_id = -1;
          elapsed = 0;
        }
        
        if (elapsed == quantum)
        {
          previous_id = current_id;
          current_id = -1;
          elapsed = 0;
        }
      }
  
      if (current_id == -1 && anyactive())
      {
        current_id = findmin();
      }
  
      if (current_id != -1)
      {
        list[current_id].remaining -= 1;
        elapsed++;
      }
    }  


    //  returns the id of the current process

    int getcurrent() { return list[current_id].idno; }

    //  determines the position of the next process to get the processor
    //  this is the only function that needs modification if the
    //  scheduling discipline is changed from SRT
    
    int findmin()
    {
      deque<int> d;
      deque<int>::iterator itr;
      itr = d.begin();

      if (!d.empty())
      {
        d.push_back(previous_id);
        d.pop_front();
        d.push_front(current_id);
      }

      itr = d.begin();

      return (*itr);
    }

    //  Sets finishing time of the last job to finish
    //  Not a very pleasing fix to allow the main program to run but it works.

    void endsim (int t)
    {
      list[current_id].finish = t;
    }
};

int main()
{
  myclock timer;                        // clock
  int quantum, t;
  int newid,newstart,newruntime;
  char ch;
  int n;

  cout << "How Many Jobs? ";
  cin >> n;                             // Number of Jobs
  cout << endl << "What Is The Quantum? ";
  cin >> quantum;                       // Quantum

  processor cpu( quantum, n);           // Set up processor

  cout << endl << "Enter ID Number, Start Time, and Run Time For Each Job ";
  cout << endl << "-------------------------------------------------------";
  cout << endl;
  for (int i = 0; i < n; i++)
  {
    cin >> newid >> newstart >> newruntime;
    if (cpu.insertjob( newid, newstart, newruntime))
      cout << "Job Inserted Successfully " << endl;
    else
      cout << "Processor Queue Size Limit Exceeded " << endl;
    
    cout << "-------------------------------------------------------"
         << endl;
  }

  cout << endl << "-------------------------------------------------------"
       << endl;
  cout << "Summary of Data Entered " << endl;
  cout << "-------------------------------------------------------" << endl;

  cpu.printlist();
  cout << "-------------------------------------------------------" << endl;

  cout << endl << endl << "-------------------------------------------------------" << endl;
  cout << "Gantt Chart" << endl;
  cout << "-------------------------------------------------------" << endl;


  while (cpu.jobsleft())                // continue until time remaining = 0
  {                                     // for all jobs

    t = timer.gettime();                // read clock
    cpu.fixready( t );                  // make processes ready at time t active
    cpu.check( t );                     // do the work of the simulation
    if (cpu.anyactive())                // display the number of the active
      cout << "|" << cpu.getcurrent();  // processes for the purpose of a trac
    else
      cout << "|---";
    timer.tick();                       // update the clock
  }

  t = timer.gettime();                  // read clock
  cout << "|";
  cpu.endsim(t);                        // update last finish time, a crude fix
  cout << endl << "-------------------------------------------------------" << endl;
  cout << endl << endl;
  cout << "-------------------------------------------------------" << endl;
  cout << "Simulation Results " << endl;
  cout << "-------------------------------------------------------" << endl;
  cpu.printlist();                      // display final results
  cout << "-------------------------------------------------------" << endl;
}
