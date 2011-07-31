' Name: Caleb Wherry
' Program: VB Mail Order (Wherry1)
' Due: September 4, 2007
' Purpose: To use VB .NET to create a simple GUI application that uses buttons to show basic information about a mail order business.

Public Class vbMailOrderForm

    Dim pressed As Boolean = True
    Dim pressed2 As Boolean = True
    Dim pressed3 As Boolean = True
    Dim pressed4 As Boolean = True

    Private Sub customerRelationsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerRelationsButton.Click
        ' Display the contact information for Customer Relations

        If pressed = True Then
            Me.relationsContactLabel.Text = "Tricia Mills"
            Me.relationsTelephoneLabel.Text = "500-1111"
            pressed = False
        Else : Me.relationsContactLabel.Text = ""
            Me.relationsTelephoneLabel.Text = ""
            pressed = True
        End If
    End Sub

    Private Sub marketingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marketingButton.Click
        ' Display the contact information for Marketing

        If pressed2 = True Then
            Me.marketingContactLabel.Text = "Michelle Rigner"
            Me.marketingTelephoneLabel.Text = "500-2222"
            pressed2 = False
        Else : Me.marketingContactLabel.Text = ""
            Me.marketingTelephoneLabel.Text = ""
            pressed2 = True
        End If
    End Sub

    Private Sub orderProcessingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderProcessingButton.Click
        ' Display the contact information for Order Processing

        If pressed3 = True Then
            Me.orderContactLabel.Text = "Kenna DeVoss"
            Me.orderTelephoneLabel.Text = "500-3333"
            pressed3 = False
        Else : Me.orderContactLabel.Text = ""
            Me.orderTelephoneLabel.Text = ""
            pressed3 = True
        End If
    End Sub

    Private Sub shippingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shippingButton.Click
        ' Display the contact information for Shipping

        If pressed4 = True Then
            Me.shippingContactLabel.Text = "Eric Andrews"
            Me.shippingTelephoneLabel.Text = "500-4444"
            pressed4 = False
        Else : Me.shippingContactLabel.Text = ""
            Me.shippingTelephoneLabel.Text = ""
            pressed4 = True
        End If
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Exit the project.

        Me.Close()
    End Sub
End Class