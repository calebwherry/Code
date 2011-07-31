using System;
using System.Collections;
using System.IO;

namespace DocumentView
{
	public class LViewItem
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

        private string rentDate;
        public string RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }

        private string dueDate;
        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        
        private string returnDate;
        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }



        private bool isMovie;
        public bool IsMovie
        {
            get { return isMovie; }
            set { isMovie = value; }
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
        private string streetAddress;

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private string creditCard;

        public string CreditCard
        {
            get { return creditCard; }
            set { creditCard = value; }
        }
        private string expirationDate;

        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        private string cardType;

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private string releaseDate;

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        private string rating;

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int copies;

        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }



        public LViewItem(int ID, string TITLE, string DESCRIPTION, string PUBLISHER, string RELEASEDATE, string RATING, double PRICE, int COPIES,bool ISMOVIE)
		{
			Id = ID;
            Title = TITLE;
            Description = DESCRIPTION;
            Publisher = PUBLISHER;
            ReleaseDate = RELEASEDATE;
            Rating = RATING;
            Price = PRICE;
            Copies = COPIES;
            isMovie = ISMOVIE;
		}

        public LViewItem(Int32 ID, string FIRSTNAME, string LASTNAME, string STREETADDRESS, string CITY, string STATE, string ZIPCODE, string TELEPHONE, string CREDITCARD, string EXPIRATIONDATE, string CARDTYPE)
        {
            id = ID;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            streetAddress = STREETADDRESS;
            city = CITY;
            state = STATE;
            zipCode = ZIPCODE;
            telephone = TELEPHONE;
            creditCard = CREDITCARD;
            expirationDate = EXPIRATIONDATE;
            cardType = CARDTYPE;
        }

        public LViewItem(Int32 ID, Int32 MEMBERID, string FIRSTNAME, string LASTNAME, string RENTDATE, string DUEDATE, string RETURNDATE, string STATUS)
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
	}

    public class LView : CollectionBase
    {
        public event EventHandler DocumentChanged;

        private string lastFilename;
        public string LastFileName
        {
            get
            {
                return lastFilename;
            }
            set
            {
                lastFilename = value;
            }
        }

        public void Add(LViewItem item)
        {
            base.List.Add(item);
            OnDocumentChanged(new EventArgs());
        }
        public void clear()
        {
            base.List.Clear();
        }

        public void Remove(int index)
        {
            // Check to see if there is an item at the supplied index.
            if (index > (this.Count - 1) || index < 0)
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                base.List.RemoveAt(index);
            }
            OnDocumentChanged(new EventArgs());
        }

        // Indexer.
        public LViewItem this[int index]
        {
            get { return (LViewItem)base.List[index]; }
            set { base.List[index] = value; }
        }

        protected void OnDocumentChanged(System.EventArgs e)
        {
            // Note that this currently occurs as items are added or removed,
            // but not when they are edited. To overcome this would require adding
            // an additional LViewItem change event.

            // Raise the DocumentChanged event.
            if (DocumentChanged != null)
            {
                
                DocumentChanged(this, e);
            }
        }



    }
}
