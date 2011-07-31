using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class UpdateGameDocument : UserControl
    {
        public UpdateGameDocument()
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
                
        public UpdateGameDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Game newGame = new Game(int.Parse(idMaskedTextBox.Text), titleTextBox.Text, descriptionTextBox.Text, publisherTextBox.Text, releaseDateMaskedTextBox.Text, ratingTextBox.Text, double.Parse(priceMaskedTextBox.Text), (int)numberOfCopiesUpDown.Value);
            dataHandler.updateGame(newGame);
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
