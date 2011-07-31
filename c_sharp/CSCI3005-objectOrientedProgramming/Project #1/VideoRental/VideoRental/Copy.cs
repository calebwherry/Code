using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class Copy
    {
        private bool isCheckedOut = false;
        private DateTime purchaseDate;

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public bool IsCheckedOut
        {
            get { return isCheckedOut; }
            set { isCheckedOut = value; }
        }
        
        public Copy()
        {
            isCheckedOut = false;
            purchaseDate = DateTime.ParseExact("01/01/2001", "MM/dd/yyyy", null);
        }
    }
}
