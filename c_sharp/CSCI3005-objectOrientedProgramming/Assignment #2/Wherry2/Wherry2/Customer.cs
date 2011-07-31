using System;
using System.Collections.Generic;
using System.Text;

namespace Wherry2
{
    class Customer
    {
        private string address;
        private int chkAcc;
        private string name;
        private int pin;
        private string ssn;
        private bool status;
        private string tel;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public int ChkAcc
        {
            get { return chkAcc; }
            set { chkAcc = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
       
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Customer()
        {
            address = "";
            chkAcc = 0;
            name = "";
            pin = 0;
            ssn = "";
            status = false;
            tel = "";
        }
    }
}
