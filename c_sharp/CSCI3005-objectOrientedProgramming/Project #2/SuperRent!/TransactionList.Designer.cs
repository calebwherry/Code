namespace DocumentView
{
    partial class TransactionList
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
            this.transactionListView = new System.Windows.Forms.ListView();
            this.transactionHeader = new System.Windows.Forms.ColumnHeader();
            this.memberNameHeader = new System.Windows.Forms.ColumnHeader();
            this.memberIdHeader = new System.Windows.Forms.ColumnHeader();
            this.rentDateHeader = new System.Windows.Forms.ColumnHeader();
            this.dueDateHeader = new System.Windows.Forms.ColumnHeader();
            this.returnDateHeader = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.rentButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionListView
            // 
            this.transactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionHeader,
            this.memberIdHeader,
            this.memberNameHeader,
            this.rentDateHeader,
            this.dueDateHeader,
            this.returnDateHeader,
            this.columnHeader1});
            this.transactionListView.FullRowSelect = true;
            this.transactionListView.Location = new System.Drawing.Point(3, 3);
            this.transactionListView.Name = "transactionListView";
            this.transactionListView.Size = new System.Drawing.Size(653, 260);
            this.transactionListView.TabIndex = 0;
            this.transactionListView.UseCompatibleStateImageBehavior = false;
            this.transactionListView.View = System.Windows.Forms.View.Details;
            // 
            // transactionHeader
            // 
            this.transactionHeader.Tag = "Transaction ID";
            this.transactionHeader.Text = "Transaction ID";
            this.transactionHeader.Width = 86;
            // 
            // memberNameHeader
            // 
            this.memberNameHeader.Text = "Member Name";
            this.memberNameHeader.Width = 166;
            // 
            // memberIdHeader
            // 
            this.memberIdHeader.Text = "Member ID";
            this.memberIdHeader.Width = 69;
            // 
            // rentDateHeader
            // 
            this.rentDateHeader.Text = "Rent Date";
            this.rentDateHeader.Width = 104;
            // 
            // dueDateHeader
            // 
            this.dueDateHeader.Text = "Due Date";
            this.dueDateHeader.Width = 106;
            // 
            // returnDateHeader
            // 
            this.returnDateHeader.Text = "Return Date";
            this.returnDateHeader.Width = 118;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(672, 16);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(122, 34);
            this.rentButton.TabIndex = 1;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(672, 56);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(122, 34);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.transactionListView);
            this.Name = "TransactionList";
            this.Size = new System.Drawing.Size(810, 275);
            this.Load += new System.EventHandler(this.TransactionList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView transactionListView;
        private System.Windows.Forms.ColumnHeader transactionHeader;
        private System.Windows.Forms.ColumnHeader memberIdHeader;
        private System.Windows.Forms.ColumnHeader rentDateHeader;
        private System.Windows.Forms.ColumnHeader dueDateHeader;
        private System.Windows.Forms.ColumnHeader returnDateHeader;
        private System.Windows.Forms.ColumnHeader memberNameHeader;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
