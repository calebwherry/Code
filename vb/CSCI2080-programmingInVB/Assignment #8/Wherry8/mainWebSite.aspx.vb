' Caleb Wherry
' Wherry8


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub submitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submitButton.Click
        ' Sees if the two password boxes match.

        With Me
            If .passwordTextBox.Text = .confirmPasswordTextBox.Text Then
                With Me.messageLabel
                    .Font.Size = 28
                    .Text = "Welcome " & Me.nameTextBox.Text & "!"
                End With
            Else
                .passwordTextBox.Text = ""
                .confirmPasswordTextBox.Text = ""
                With Me.messageLabel
                    .Font.Size = 24
                    .Text = "Your passwords do not match! Please re-enter!"
                End With
            End If
        End With
    End Sub
End Class
