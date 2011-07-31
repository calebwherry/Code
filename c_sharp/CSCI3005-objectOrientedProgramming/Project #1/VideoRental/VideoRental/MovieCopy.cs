using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public class MovieCopy : Copy
    {
        private int id;
        private string movieId;
        private string movieTitle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string MovieId
        {
            get { return movieId; }
            set { movieId = value; }
        }

        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }

        public MovieCopy()
        {
            id = 0;
            movieId = "";
            movieTitle = "";
        }
    }
}
