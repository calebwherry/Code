using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class UpdateMovieDocument : UserControl
    {
        public UpdateMovieDocument()
        {
            InitializeComponent();
        }

        private LView document;
        public LView Document
        {
            set
            {
                document = value;
            }
            get { return document; }
        }
                
        public UpdateMovieDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Movie newMovie = new Movie(int.Parse(idMaskedTextBox.Text), titleTextBox.Text, descriptionTextBox.Text, publisherTextBox.Text, releaseDateMaskedTextBox.Text, ratingTextBox.Text, double.Parse(priceMaskedTextBox.Text), (int)numberOfCopiesUpDown.Value);
            dataHandler.updateMovie(newMovie);
            idMaskedTextBox.Text = "";
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            publisherTextBox.Text = "";
            releaseDateMaskedTextBox.Text = "";
            ratingTextBox.Text = "";
            priceMaskedTextBox.Text = "";
            numberOfCopiesUpDown.Value = 0;
        }
    }
}
