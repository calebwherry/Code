using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class TransactionList : UserControl
    {
        public TransactionList()
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
            get { return parent; }
        }


        public TransactionList(LView document,Form parent)
            : this()
        {
            Document = document;
        }


        private void RefreshList()
        {
            if (transactionListView != null)
            {
                transactionListView.SuspendLayout();
                transactionListView.Items.Clear();

                ListViewItem itemDisplay;
                foreach (LViewItem item in this.Document)
                {
                    itemDisplay = transactionListView.Items.Add(item.Id.ToString());
                    itemDisplay.SubItems.Add(item.MemberId.ToString());
                    itemDisplay.SubItems.Add(item.LastName.ToString() + ", " + item.FirstName.ToString());
                    itemDisplay.SubItems.Add(item.RentDate);
                    itemDisplay.SubItems.Add(item.DueDate);
                    itemDisplay.SubItems.Add(item.ReturnDate);
                    itemDisplay.SubItems.Add(item.Status);
                }
            }
        }


        private void rentButton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Rent";
            Child frmChild = new Child(doc, Child.ViewType.Rent, Parent);
            frmChild.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Return";
            Child frmChild = new Child(doc, Child.ViewType.Return, Parent);
            frmChild.Show();
        }

        private void TransactionList_Load(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            List<Transaction> allTransactions = new List<Transaction>();
            allTransactions = dataHandler.getTransactions();

            foreach (Transaction item in allTransactions)
            {
                Document.Add(new LViewItem(item.Id, item.MemberId,item.FirstName,item.LastName,item.RentDate,item.DueDate,item.ReturnDate,item.Status));
            }

            RefreshList();
        }

 
    }
}
