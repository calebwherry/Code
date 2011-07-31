using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRental
{
    public abstract class Video
    {
        private DateTime releaseDate;
        private string title;

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
