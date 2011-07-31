using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentView
{
    public class Member
    {
        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
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

        public Member()
        {
            id = 0;
            firstName = "";
            lastName = "";
            streetAddress = "";
            city = "";
            state = "";
            zipCode = "";
            telephone = "";
            creditCard = "";
            expirationDate = "";
            cardType = "";
        }

        public Member(Int32 ID, string FIRSTNAME,string LASTNAME,string STREETADDRESS,string CITY,string STATE,string ZIPCODE,string TELEPHONE,string CREDITCARD,string EXPIRATIONDATE,string CARDTYPE)
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
    }
}
