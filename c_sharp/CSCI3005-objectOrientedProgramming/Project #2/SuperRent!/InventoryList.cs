using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class InventoryList : UserControl
    {
        public InventoryList()
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

        private Form parent;
        public Form Parent
        {
            set
            {
                parent = value;
            }
            get{return parent;}
        }

        public InventoryList(LView document,Form parent)
            : this()
        {
            Document = document;
            Parent = parent;
        }

        private void RefreshList()
        {
            if (movieListView != null)
            {
                movieListView.SuspendLayout();
                movieListView.Items.Clear();

                ListViewItem itemDisplay;
                foreach (LViewItem item in this.Document)
                {
                    if (item.IsMovie)
                    {
                        itemDisplay = movieListView.Items.Add(item.Id.ToString());
                        itemDisplay.SubItems.Add(item.Title);
                        itemDisplay.SubItems.Add(item.Description);
                        itemDisplay.SubItems.Add(item.Publisher);
                        itemDisplay.SubItems.Add(item.ReleaseDate);
                        itemDisplay.SubItems.Add(item.Rating);
                        itemDisplay.SubItems.Add(item.Price.ToString());
                        itemDisplay.SubItems.Add(item.Copies.ToString());
                    }
                    else
                    {
                        itemDisplay = gameListView.Items.Add(item.Id.ToString());
                        itemDisplay.SubItems.Add(item.Title);
                        itemDisplay.SubItems.Add(item.Description);
                        itemDisplay.SubItems.Add(item.Publisher);
                        itemDisplay.SubItems.Add(item.ReleaseDate);
                        itemDisplay.SubItems.Add(item.Rating);
                        itemDisplay.SubItems.Add(item.Price.ToString());
                        itemDisplay.SubItems.Add(item.Copies.ToString());
                    }
                }
            }
        }


        private void movieListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Add Movie";
            Child frmChild = new Child(doc, Child.ViewType.AddMov, Parent);
            frmChild.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Update Movie";
            Child frmChild = new Child(doc, Child.ViewType.UpdateMov, Parent);
            frmChild.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Add Game";
            Child frmChild = new Child(doc, Child.ViewType.AddGam, Parent);
            frmChild.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Update Game";
            Child frmChild = new Child(doc, Child.ViewType.UpdateGam, Parent);
            frmChild.Show();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            dbIO dataHandler = new dbIO();
            List<Game> allGames = new List<Game>();
            allGames = dataHandler.getGames();

            foreach (Game item in allGames)
            {
                Document.Add(new LViewItem(item.Id, item.Title, item.Description, item.Publisher, item.ReleaseDate, item.Rating, item.Price, item.Copies, false));
            }


            List<Movie> allMovies = new List<Movie>();
            allMovies = dataHandler.getMovies();

            foreach (Movie item in allMovies)
            {
                Document.Add(new LViewItem(item.Id, item.Title, item.Description, item.Publisher, item.ReleaseDate, item.Rating, item.Price, item.Copies, true));
            }

            RefreshList();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Int32 num;
            if(movieListView.SelectedIndices.Count==1)
            {
                num = Int32.Parse(movieListView.SelectedItems[0].Text);
                dataHandler.deleteMovie(num);
            }
            gameListView.Items.Clear();
            Document.clear();
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Int32 num;
            if (gameListView.SelectedIndices.Count == 1)
            {
                num = Int32.Parse(gameListView.SelectedItems[0].Text);
                dataHandler.deleteGame(num);
            }
            gameListView.Items.Clear();
            Document.clear();
            reload();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            movieListView.Items.Clear();
            gameListView.Items.Clear();
            Document.clear();
            reload();
        }

    }
}
