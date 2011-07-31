using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class RentDocument : UserControl
    {
        public RentDocument()
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
                
        public RentDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void RefreshList()
        {
                foreach (LViewItem item in this.Document)
                {
                    if (item.IsMovie)
                    {
                        movieListBox.Items.Add(item.Title);
                    }
                    else
                    {
                        gameListBox.Items.Add(item.Title);
                    }
                }
            
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            List<Game> likeGames = new List<Game>();
            List<Movie> likeMovies = new List<Movie>();
            likeGames = dataHandler.searchGame(searchTextBox.Text);
            likeMovies = dataHandler.searchMovie(searchTextBox.Text);

            Document.clear();
            movieListBox.Items.Clear();
            gameListBox.Items.Clear();
            foreach (Game item in likeGames)
            {
                Document.Add(new LViewItem(item.Id, item.Title, item.Description, item.Publisher, item.ReleaseDate, item.Rating, item.Price, item.Copies, false));
            }

            foreach (Movie item in likeMovies)
            {
                Document.Add(new LViewItem(item.Id, item.Title, item.Description, item.Publisher, item.ReleaseDate, item.Rating, item.Price, item.Copies, true));
            }

            RefreshList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem itemDisplay;

            if (movieListBox.SelectedItems.Count == 1)
            {
                foreach (LViewItem item in this.Document)
                {
                    if (item.Title == movieListBox.SelectedItem.ToString())
                    {
                        itemDisplay = rentListView.Items.Add(item.Id.ToString());
                        if (item.IsMovie)
                            itemDisplay.SubItems.Add("Movie");
                        else
                            itemDisplay.SubItems.Add("Game");
                        itemDisplay.SubItems.Add(item.Title);
                    }
                }

                movieListBox.ClearSelected();
            }

            if (gameListBox.SelectedItems.Count == 1)
            {
                foreach (LViewItem item in this.Document)
                {
                    if (item.Title == gameListBox.SelectedItem.ToString())
                    {
                        itemDisplay = rentListView.Items.Add(item.Id.ToString());
                        if (item.IsMovie)
                            itemDisplay.SubItems.Add("Movie");
                        else
                            itemDisplay.SubItems.Add("Game");
                        itemDisplay.SubItems.Add(item.Title);
                    }
                }
                gameListBox.ClearSelected();
            }
        }

        private void RentDocument_Load(object sender, EventArgs e)
        {
            rentDateTextBox.Text= System.DateTime.Today.Date.ToShortDateString();
            dueDateTextBox.Text = System.DateTime.Today.Date.AddDays(5).ToShortDateString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Transaction newTrans = new Transaction();

            newTrans.MemberId = Int32.Parse(memberTextBox.Text);
            foreach (LViewItem item in this.Document)
            {
                if (item.MemberId == Int32.Parse(memberTextBox.Text))
                {
                    newTrans.FirstName = item.FirstName;
                    newTrans.LastName = item.LastName;
                }
            }
            newTrans.RentDate = rentDateTextBox.Text;
            newTrans.DueDate = dueDateTextBox.Text;
            newTrans.Status = "Open";

            dbIO dataHandler = new dbIO();

            dataHandler.rentGame(newTrans, Int32.Parse(memberTextBox.Text));
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Member foundMember = new Member();
            foundMember = dataHandler.findMember(Int32.Parse(memberTextBox.Text));

            nameTextBox.Text = foundMember.FirstName + foundMember.LastName;

            rentDateTextBox.Text = System.DateTime.Today.Date.ToShortDateString();
            dueDateTextBox.Text = System.DateTime.Today.Date.AddDays(5).ToShortDateString();
        }


    }
}
