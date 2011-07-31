using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class ReturnDocument : UserControl
    {
        public ReturnDocument()
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
                
        public ReturnDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void ReturnDocument_Load(object sender, EventArgs e)
        {  
            returnDateTextBox.Text = System.DateTime.Today.Date.ToShortDateString(); 
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Transaction foundTrans = new Transaction();
            foundTrans = dataHandler.findTrans(Int32.Parse(transactionTextBox.Text));
            dueDateTextBox.Text = foundTrans.DueDate;
            rentDateTextBox.Text = foundTrans.RentDate;
            memberTextBox.Text = foundTrans.MemberId.ToString();
            nameTextBox.Text = foundTrans.FirstName + " " + foundTrans.LastName;

        }

    }
}
