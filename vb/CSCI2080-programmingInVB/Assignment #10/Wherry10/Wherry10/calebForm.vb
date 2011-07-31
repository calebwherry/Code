' Caleb Wherry
' Wherry10
' December 3, 2007
' Purpose: Use VB .NET functions and classes to read items from a file and display them to the screen.

Imports System.IO

Public Class phoneNumberForm

    Private recordStreamReader As StreamReader

    Private Sub openButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openButton.Click
        ' Open a .txt file that contains the needed data.

        Dim responseDialogResult = DialogResult

        OpenFileDialog1.InitialDirectory = Application.StartupPath
        responseDialogResult = OpenFileDialog1.ShowDialog()

        If responseDialogResult <> DialogResult.Cancel Then
            recordStreamReader = New StreamReader(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        ' Goes to the next item in the file.


    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Close all open files and programs.

        Me.Close()
    End Sub
End Class