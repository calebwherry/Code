namespace DocumentView
{
    partial class MemberList
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
            this.expirationDateHeader = new System.Windows.Forms.ColumnHeader();
            this.creditCardHeader = new System.Windows.Forms.ColumnHeader();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.telephoneHeader = new System.Windows.Forms.ColumnHeader();
            this.idHeader = new System.Windows.Forms.ColumnHeader();
            this.memberListView = new System.Windows.Forms.ListView();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.addressHeader = new System.Windows.Forms.ColumnHeader();
            this.companyHeader = new System.Windows.Forms.ColumnHeader();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // expirationDateHeader
            // 
            this.expirationDateHeader.Text = "Expiration Date";
            this.expirationDateHeader.Width = 118;
            // 
            // creditCardHeader
            // 
            this.creditCardHeader.Text = "Credit Card";
            this.creditCardHeader.Width = 106;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(737, 55);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 34);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Account";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(737, 15);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(122, 34);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open Account";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // telephoneHeader
            // 
            this.telephoneHeader.Text = "Telephone";
            this.telephoneHeader.Width = 104;
            // 
            // idHeader
            // 
            this.idHeader.Tag = "Transaction ID";
            this.idHeader.Text = "ID";
            this.idHeader.Width = 86;
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.nameHeader,
            this.addressHeader,
            this.telephoneHeader,
            this.creditCardHeader,
            this.expirationDateHeader,
            this.companyHeader});
            this.memberListView.FullRowSelect = true;
            this.memberListView.Location = new System.Drawing.Point(3, 3);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(717, 263);
            this.memberListView.TabIndex = 3;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 166;
            // 
            // addressHeader
            // 
            this.addressHeader.Text = "Address";
            this.addressHeader.Width = 69;
            // 
            // companyHeader
            // 
            this.companyHeader.Text = "Company";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(737, 95);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update Account";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(756, 164);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(86, 45);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.memberListView);
            this.Name = "MemberList";
            this.Size = new System.Drawing.Size(875, 275);
            this.Load += new System.EventHandler(this.MemberList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader expirationDateHeader;
        private System.Windows.Forms.ColumnHeader creditCardHeader;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ColumnHeader telephoneHeader;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader addressHeader;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ColumnHeader companyHeader;
        private System.Windows.Forms.Button refreshButton;
    }
}
