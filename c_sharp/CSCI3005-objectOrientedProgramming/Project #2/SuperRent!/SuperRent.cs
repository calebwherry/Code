using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class SuperRent : Form
	{
		public SuperRent()
		{
			InitializeComponent();
		}

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Inventory";
            Form parent;
            parent = this;
            Child frmChild = new Child(doc, Child.ViewType.Inventory,parent);
            //frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Members";
            Form parent;
            parent = this;
            Child frmChild = new Child(doc, Child.ViewType.Members, parent);
            //frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Transactions";
            Form parent;
            parent = this;
            Child frmChild = new Child(doc, Child.ViewType.Transactions, parent);
            //frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Rent";
            Form parent;
            parent = this;
            Child frmChild = new Child(doc, Child.ViewType.Rent, parent);
            frmChild.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new LView.
            LView doc = new LView();
            doc.LastFileName = "Return";
            Form parent;
            parent = this;
            Child frmChild = new Child(doc, Child.ViewType.Return, parent);
            //frmChild.MdiParent = this;
            frmChild.Show();
        }

	}
}