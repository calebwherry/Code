using System;
using System.Collections.Generic;
using System.Text;

namespace Wherry2
{
    class Checking
    {
        private double balance;
        private int number;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Checking()
        {
            balance = 0.0;
            number = 0;
            status = false;
        }
    }
}