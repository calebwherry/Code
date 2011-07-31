<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.booksDataGridView = New System.Windows.Forms.DataGridView
        Me.RnrBooksDataSet = New Wherry9.RnrBooksDataSet
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter = New Wherry9.RnrBooksDataSetTableAdapters.SubjectsTableAdapter
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.booksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'booksDataGridView
        '
        Me.booksDataGridView.AutoGenerateColumns = False
        Me.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.booksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectCodeDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn})
        Me.booksDataGridView.DataSource = Me.SubjectsBindingSource
        Me.booksDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.booksDataGridView.Name = "booksDataGridView"
        Me.booksDataGridView.Size = New System.Drawing.Size(545, 282)
        Me.booksDataGridView.TabIndex = 0
        '
        'RnrBooksDataSet
        '
        Me.RnrBooksDataSet.DataSetName = "RnrBooksDataSet"
        Me.RnrBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "Subjects"
        Me.SubjectsBindingSource.DataSource = Me.RnrBooksDataSet
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        Me.SubjectCodeDataGridViewTextBoxColumn.Width = 250
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.Width = 250
        '
        'booksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 306)
        Me.Controls.Add(Me.booksDataGridView)
        Me.Name = "booksForm"
        Me.Text = "R 'n R Books"
        CType(Me.booksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents booksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RnrBooksDataSet As Wherry9.RnrBooksDataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As Wherry9.RnrBooksDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
