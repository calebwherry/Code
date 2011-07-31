using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class Game : Video
    {
        private string id;
        private int nbrCopies;
        public static double rental;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public int NbrCopies
        {
            get { return nbrCopies; }
            set { nbrCopies = value; }
        }

        public static double Rental
        {
            get { return rental; }
            set { rental = value; }
        }

        public Game()
        {
            id = "";
            nbrCopies = 0;
            rental = 0;
        }
    }
}
