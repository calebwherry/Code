using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentView
{
    public class Transaction
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int memberId;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string rentDate;

        public string RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        private string returnDate;

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        private string dueDate;

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Transaction(Int32 ID,Int32 MEMBERID,string FIRSTNAME,string LASTNAME,string RENTDATE,string DUEDATE,string RETURNDATE,string STATUS)
        {
            Id = ID;
            MemberId = MEMBERID;
            FirstName = FIRSTNAME;
            LastName = LASTNAME;
            RentDate = RENTDATE;
            DueDate = DUEDATE;
            ReturnDate = RETURNDATE;
            Status = STATUS;
        }

        public Transaction()
        {
            Id = 0;
            MemberId = 0;
            FirstName = "";
            LastName = "";
            RentDate = "";
            DueDate = "";
            ReturnDate = "";
            Status = "";
        }

    }
}
