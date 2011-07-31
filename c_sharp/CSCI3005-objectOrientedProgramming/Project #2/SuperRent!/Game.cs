using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentView
{
    public class Game : Video
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public Game()
        {
            Title = "";
            Description = "";
            Publisher = "";
            ReleaseDate = "";
            Rating = "";
            Price = 0;
            Copies = 0;
        }

        public Game(int ID, string TITLE, string DESCRIPTION, string PUBLISHER, string RELEASEDATE, string RATING, double PRICE, int COPIES)
        {
            Id = ID;
            Title = TITLE;
            Description = DESCRIPTION;
            Publisher = PUBLISHER;
            ReleaseDate = RELEASEDATE;
            Rating = RATING;
            Price = PRICE;
            Copies = COPIES;
        }
    }
}
