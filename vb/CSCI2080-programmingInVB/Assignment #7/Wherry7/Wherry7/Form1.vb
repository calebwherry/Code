' Caleb Wherry
' Wherry7

Public Class bagelForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBagelTypeToolStripMenuItem.Click
        ' Add a bagel to the list.

        With Me.bagelComboBox
            If .Text = "" Then
                MessageBox.Show("You did not enter a bagel! Please enter a bagel name!", "Try Again", MessageBoxButtons.OK)
            ElseIf .Items.Contains(.Text) Then
                MessageBox.Show("This bagel is already in the list! Try another name!", "Try Again", MessageBoxButtons.OK)
            Else
                .Items.Add(.Text)
                .Text = ""
            End If
        End With
    End Sub

    Private Sub RemoveBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBagelTypeToolStripMenuItem.Click
        ' Remove the bagel that is selected from the list.

        With Me.bagelComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("You did not select a bagel! Please select one!", "No bagel selected!", MessageBoxButtons.OK)
            End If
        End With
    End Sub

    Private Sub PrintBagelListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBagelListToolStripMenuItem.Click
        ' Displays the print preview for the list of bagels.

        bagelPrintPreviewDialog.Document = bagelPrintDocument
        bagelPrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub ClearBagelListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBagelListToolStripMenuItem.Click
        ' Clear the contents of the bagel combo box.

        Dim clearDialogResult As DialogResult

        clearDialogResult = MessageBox.Show("Do you really want to clear the bagel list?", "Clear Bagel List?", MessageBoxButtons.YesNo)

        If clearDialogResult = DialogResult.Yes Then
            Me.bagelComboBox.Items.Clear()
        End If
    End Sub

    Private Sub DisplayBagelTypeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayBagelTypeCountToolStripMenuItem.Click
        ' Displays the number of bagels in the list.

        MessageBox.Show("There are " & Me.bagelComboBox.Items.Count & " bagels in the list!", "Number of Bagels", MessageBoxButtons.OK)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays the about box screen.

        AboutBox.ShowDialog()
    End Sub

    Private Sub bagelPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles bagelPrintDocument.PrintPage
        ' Create the page to be printed.

        Dim printFont As New Font("Times New Roman", 12)
        Dim lineHeightSingle As Single = printFont.GetHeight + 2
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim listIndexInteger As Integer

        ' Print the heading.

        Using headingFont As New Font("Times New Roman", 12)
            e.Graphics.DrawString("Visual Basic .Net: Awesome Bagels!", headingFont, Brushes.Black, horizontalPrintLocationSingle, _
                verticalPrintLocationSingle)
            verticalPrintLocationSingle += lineHeightSingle
            e.Graphics.DrawString("Built by: Caleb Wherry", headingFont, Brushes.Black, horizontalPrintLocationSingle, _
                verticalPrintLocationSingle)
            verticalPrintLocationSingle += lineHeightSingle
            e.Graphics.DrawString("Types of Bagels:", headingFont, Brushes.Black, horizontalPrintLocationSingle, _
                verticalPrintLocationSingle)
            verticalPrintLocationSingle += lineHeightSingle * 2
        End Using

        ' Print the list of bagels.

        Do Until listIndexInteger = bagelComboBox.Items.Count
            e.Graphics.DrawString(bagelComboBox.Items(listIndexInteger).ToString(), printFont, Brushes.Black, horizontalPrintLocationSingle, _
                verticalPrintLocationSingle)
            listIndexInteger += 1
            verticalPrintLocationSingle += lineHeightSingle
        Loop

    End Sub
End Class
