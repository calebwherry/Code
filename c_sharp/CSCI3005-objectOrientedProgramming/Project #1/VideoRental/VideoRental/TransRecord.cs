using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class TransRecord
    {
        private static Copy[] cpArr = new Copy[9];
        private static DateTime returnDate;
        private DateTime dueDate;
        private static string id;
        private static string mbrId;
        private static DateTime rentDate;

        public static DateTime ReturnDate
        {
            get { return TransRecord.returnDate; }
            set { TransRecord.returnDate = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public static DateTime RentDate
        {
            get { return TransRecord.rentDate; }
            set { TransRecord.rentDate = value; }
        }

        public Copy[] CpArr
        {
            get { return cpArr; }
            set { cpArr = value; }
        }

        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string MbrId
        {
            get { return mbrId; }
            set { mbrId = value; }
        }

        public TransRecord()
        {
            for (int i = 0; i < cpArr.Length; i++)
                cpArr[i] = new Copy();

            returnDate = DateTime.ParseExact("01/01/2001", "MM/dd/yyyy", null);
            dueDate = DateTime.ParseExact("01/01/2001", "MM/dd/yyyy", null);
            id = "";
            mbrId = "";
            rentDate = DateTime.ParseExact("01/01/2001", "MM/dd/yyyy", null);
        }

        public void Rent(string n_id, string n_memberID, string n_rentDate, Copy rentObj)
        {
            id = n_id;
            mbrId = n_memberID;

            rentDate = DateTime.Parse(n_rentDate);
            dueDate = rentDate;
            dueDate = dueDate.AddDays(5);

            CpArr[CpArr.Length] = rentObj;
        }

        public void Return(string n_id, string n_returnDate)
        {
            id = n_id;
            returnDate = DateTime.Parse(n_returnDate);
        }
    }
}