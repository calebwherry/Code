using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class Child : Form
	{
		public Child()
		{
			InitializeComponent();
		}
		public enum ViewType
		{
			Inventory,
			Members,
            Transactions,
            AddMov,
            AddGam,
            UpdateMov,
            UpdateGam,
            Rent,
            Return,
            AddMem,
            UpdateMem
		}

		public LView Document;

		public Child(LView doc, ViewType viewType,Form parent)
			: this()
		{
			// Configure the title.
			this.Text = doc.LastFileName;
			this.Document = doc;
            this.MdiParent = parent;

			// Create a reference for the view.
			// This reference can accomodate any type of control.
			Control view = null;

			// Instantiate the appropriate view.
			switch (viewType)
			{
				case ViewType.Inventory:
					view = new InventoryList(doc,parent);

                    this.Size = new System.Drawing.Size(900, 580);
					break;
                case ViewType.Members:
                    view = new MemberList(doc,parent);
                    this.Size = new System.Drawing.Size(875, 300);
                    break;
                case ViewType.Transactions:
                    view = new TransactionList(doc,parent);
                    this.Size = new System.Drawing.Size(810, 300);
                    break;
                case ViewType.AddMov:
                    view = new AddMovieDocument(doc);
                    this.Size = new System.Drawing.Size(425, 355);
                    break;
                case ViewType.AddGam:
                    view = new AddGameDocument(doc);
                    this.Size = new System.Drawing.Size(425, 355);
                    break;
                case ViewType.UpdateMov:
                    view = new UpdateMovieDocument(doc);
                    this.Size = new System.Drawing.Size(425, 355);
                    break;
                case ViewType.UpdateGam:
                    view = new UpdateGameDocument(doc);
                    this.Size = new System.Drawing.Size(425, 355);
                    break;
                case ViewType.Rent:
                    view = new RentDocument(doc);
                    this.Size = new System.Drawing.Size(550, 475);
                    break;
                case ViewType.Return:
                    view = new ReturnDocument(doc);
                    this.Size = new System.Drawing.Size(550, 400);
                    break;
                case ViewType.AddMem:
                    view = new AddMemberDocument(doc);
                    this.Size = new System.Drawing.Size(430, 430);
                    break;
                case ViewType.UpdateMem:
                    view = new UpdateMemberDocument(doc);
                    this.Size = new System.Drawing.Size(430, 430);
                    break;

			}

			// Add the view to the form.
			view.Dock = DockStyle.Fill;
			this.Controls.Add(view);
		}
	}
}