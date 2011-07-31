' Caleb Wherry
' Wherry9
' 15 November 2007

Public Class booksForm

    Private Sub booksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.RnrBooksDataSet.Subjects)

    End Sub
End Class
