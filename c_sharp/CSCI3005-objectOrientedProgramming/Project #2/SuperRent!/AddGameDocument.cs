using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class AddGameDocument : UserControl
    {
        public AddGameDocument()
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

        
                
        public AddGameDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Game newGame = new Game(0, titleTextBox.Text, descriptionTextBox.Text, publisherTextBox.Text, releaseDateMaskedTextBox.Text, ratingTextBox.Text, double.Parse(priceMaskedTextBox.Text), (int)numberOfCopiesUpDown.Value);
            dataHandler.addGame(newGame,(Int32)numberOfCopiesUpDown.Value);
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
