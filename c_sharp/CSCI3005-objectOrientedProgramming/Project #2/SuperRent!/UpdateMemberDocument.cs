using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public partial class UpdateMemberDocument : UserControl
    {
        public UpdateMemberDocument()
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
                
        public UpdateMemberDocument(LView document)
            : this()
        {
            Document = document;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            dbIO dataHandler = new dbIO();
            Member newMember = new Member(Int32.Parse(idTextBox.Text), firstNameTextbox.Text, textBox3.Text, textBox4.Text, textBox5.Text, maskedTextBox5.Text, maskedTextBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text, textBox1.Text);
            dataHandler.updateMember(newMember);
            idTextBox.Text = "";
            firstNameTextbox.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text="";
            maskedTextBox5.Text="";
            maskedTextBox1.Text="";
            maskedTextBox2.Text="";
            maskedTextBox3.Text="";
            maskedTextBox4.Text="";
            textBox1.Text = "";
        }
    }


    
}
