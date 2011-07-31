namespace DocumentView
{
    partial class ReturnDocument
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.returnListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.checkedOutListBox = new System.Windows.Forms.ListBox();
            this.returnDateTextBox = new System.Windows.Forms.TextBox();
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.rentDateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.memberTextBox = new System.Windows.Forms.TextBox();
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(435, 329);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 31);
            this.cancelButton.TabIndex = 38;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(331, 329);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 31);
            this.okButton.TabIndex = 37;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(124, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 30);
            this.addButton.TabIndex = 36;
            this.addButton.Text = ">>";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // returnListView
            // 
            this.returnListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.returnListView.Location = new System.Drawing.Point(178, 127);
            this.returnListView.Name = "returnListView";
            this.returnListView.Size = new System.Drawing.Size(344, 196);
            this.returnListView.TabIndex = 35;
            this.returnListView.UseCompatibleStateImageBehavior = false;
            this.returnListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 196;
            // 
            // checkedOutListBox
            // 
            this.checkedOutListBox.FormattingEnabled = true;
            this.checkedOutListBox.Location = new System.Drawing.Point(6, 127);
            this.checkedOutListBox.Name = "checkedOutListBox";
            this.checkedOutListBox.Size = new System.Drawing.Size(112, 199);
            this.checkedOutListBox.TabIndex = 33;
            // 
            // returnDateTextBox
            // 
            this.returnDateTextBox.Enabled = false;
            this.returnDateTextBox.Location = new System.Drawing.Point(422, 71);
            this.returnDateTextBox.Name = "returnDateTextBox";
            this.returnDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.returnDateTextBox.TabIndex = 32;
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.Enabled = false;
            this.dueDateTextBox.Location = new System.Drawing.Point(422, 40);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 31;
            // 
            // rentDateTextBox
            // 
            this.rentDateTextBox.Enabled = false;
            this.rentDateTextBox.Location = new System.Drawing.Point(422, 9);
            this.rentDateTextBox.Name = "rentDateTextBox";
            this.rentDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentDateTextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Location = new System.Drawing.Point(338, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rent Date";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(117, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 26;
            // 
            // memberTextBox
            // 
            this.memberTextBox.Enabled = false;
            this.memberTextBox.Location = new System.Drawing.Point(117, 40);
            this.memberTextBox.Name = "memberTextBox";
            this.memberTextBox.Size = new System.Drawing.Size(68, 20);
            this.memberTextBox.TabIndex = 25;
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.Location = new System.Drawing.Point(117, 9);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(68, 20);
            this.transactionTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Member Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Member Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Transaction Id";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(203, 7);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(75, 23);
            this.validateButton.TabIndex = 39;
            this.validateButton.Text = "Validate Id";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // ReturnDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnListView);
            this.Controls.Add(this.checkedOutListBox);
            this.Controls.Add(this.returnDateTextBox);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(this.rentDateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.memberTextBox);
            this.Controls.Add(this.transactionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReturnDocument";
            this.Size = new System.Drawing.Size(530, 375);
            this.Load += new System.EventHandler(this.ReturnDocument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView returnListView;
        private System.Windows.Forms.ListBox checkedOutListBox;
        private System.Windows.Forms.TextBox returnDateTextBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
        private System.Windows.Forms.TextBox rentDateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox memberTextBox;
        private System.Windows.Forms.TextBox transactionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button validateButton;
    }
}
