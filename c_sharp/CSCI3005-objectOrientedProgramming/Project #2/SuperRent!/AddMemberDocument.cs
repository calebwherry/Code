using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class AddMemberDocument : UserControl
    {
        public AddMemberDocument()
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
                
        public AddMemberDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            dbIO dataHandler = new dbIO();
            Member newMember = new Member(0,firstNameTextBox.Text,lastNameTextBox.Text,streetAddressTextbox.Text,cityTextbox.Text,stateMaskedTextBox.Text,zipCodeMaskedTextBox.Text,telephoneMaskedTextBox.Text,creditCardMaskedTextBox.Text,expMaskedTextbox.Text,companyTextbox.Text);
            dataHandler.addMember(newMember);
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetAddressTextbox.Text = "";
            cityTextbox.Text = "";
            stateMaskedTextBox.Text = "";
            zipCodeMaskedTextBox.Text = "";
            telephoneMaskedTextBox.Text = "";
            expMaskedTextbox.Text = "";
            companyTextbox.Text = "";
        }
    }
}
