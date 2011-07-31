' Project:       Hello World
' Programmer:    Caleb Wherry
' Date:          August 24th, 2007
' Description:   This project will display a "Hello World"
'                message in two different languages.

Public Class helloForm

    Private Sub pushButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles englishButton.Click
        ' Display the Hello World Message.

        Me.messageLabel.Text = "Hello World!"
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Exit the project.

        Me.Close()
    End Sub

    Private Sub spanishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spanishButton.Click
        ' Display the Hello World message in Spanish

        Me.messageLabel.Text = "Hola Mundo!"
    End Sub
End Class
