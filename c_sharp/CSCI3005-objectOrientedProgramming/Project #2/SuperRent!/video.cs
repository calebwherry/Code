using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentView
{
    public abstract class Video
    {
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

    }
}
