using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class Member
    {
        private string id;
        private string name;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Member()
        {
            id = "";
            name = "";
        }
    }
}
