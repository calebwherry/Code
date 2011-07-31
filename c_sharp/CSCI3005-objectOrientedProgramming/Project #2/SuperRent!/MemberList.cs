using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class MemberList : UserControl
    {
        public MemberList()
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

                
        public MemberList(LView document,Form parent)
            : this()
        {
            Document = document;
            Parent = parent;
        }

        private void RefreshList()
        {
            if (memberListView != null)
            {
                memberListView.SuspendLayout();
                memberListView.Items.Clear();

                ListViewItem itemDisplay;
                foreach (LViewItem item in this.Document)
                {
                    itemDisplay = memberListView.Items.Add(item.Id.ToString());
                    itemDisplay.SubItems.Add(item.LastName.ToString() + ", " + item.FirstName.ToString());
                    itemDisplay.SubItems.Add(item.StreetAddress.ToString() + " " + item.City.ToString() + ", " + item.State.ToString());
                    itemDisplay.SubItems.Add(item.Telephone.ToString());
                    itemDisplay.SubItems.Add(item.CreditCard.ToString());
                    itemDisplay.SubItems.Add(item.ExpirationDate.ToString());
                    itemDisplay.SubItems.Add(item.CardType.ToString());
                }
            }
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            dbIO dataHandler = new dbIO();
            List<Member> allMembers = new List<Member>();
            allMembers = dataHandler.getMembers();

            foreach (Member item in allMembers)
            {
                Document.Add(new LViewItem(item.Id, item.FirstName, item.LastName, item.StreetAddress, item.City, item.State, item.ZipCode, item.Telephone, item.CreditCard, item.ExpirationDate, item.CardType));
            }

            RefreshList();
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Add Member";
            Child frmChild = new Child(doc, Child.ViewType.AddMem, Parent);
            frmChild.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Update Member";
            Child frmChild = new Child(doc, Child.ViewType.UpdateMem, Parent);
            frmChild.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Int32 num;
            if (memberListView.SelectedIndices.Count == 1)
            {
                num = Int32.Parse(memberListView.SelectedItems[0].Text);
                dataHandler.deleteMember(num);
            }
            memberListView.Items.Clear();
            Document.clear();
            reload();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            memberListView.Items.Clear();
            Document.clear();
            reload();
        }
    }
}
