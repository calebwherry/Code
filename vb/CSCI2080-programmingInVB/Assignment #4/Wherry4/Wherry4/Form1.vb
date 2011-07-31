' Caleb Wherry
' 26 September 2007
' Wherry4
' Purpose: To take the orders of a t-shirt company using common VB .NET functions.

Option Strict On

Public Class veryVeryBoardsForm
    Const SML_DECIMAL As Decimal = 10D
    Const XL_DECIMAL As Decimal = 11D
    Const XXL_DECIMAL As Decimal = 12D
    Const MONO_DECIMAL As Decimal = 2D
    Const POCK_DECIMAL As Decimal = 1D
    Private total_shirtPrice, summaryTotal, total_order As Decimal
    Private orderCountInteger, totalQuantityShirt As Integer

    Private Sub summaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryButton.Click
        Dim messageString As String

        If total_order > 0 Then
            messageString = _
            "Total Shirts Ordered:  " & totalQuantityShirt _
            & ControlChars.NewLine & _
            "Number of Orders:      " & orderCountInteger _
            & ControlChars.NewLine & _
            "Total of All Orders:   " & summaryTotal.ToString("C")
            MessageBox.Show(messageString, "Summary", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
            Me.custNameTextBox.Focus()
        End If
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Dim quantityInteger As Integer
        Dim priceDecimal, shirtPriceDecimal As Decimal
        With Me
            .custNameTextBox.Enabled = False
            .orderNumbTextBox.Enabled = False
            .submitButton.Enabled = True
            .summaryButton.Enabled = True

            quantityInteger = Integer.Parse(.quantityTextBox.Text)

            If quantityInteger > 0 Then
                If .smallRadioButton.Checked Or .mediumRadioButton.Checked _
                    Or .largeRadioButton.Checked Then
                    priceDecimal = SML_DECIMAL
                ElseIf .xtraLrgeRadioButton.Checked Then
                    priceDecimal = XL_DECIMAL
                ElseIf .xXLRadioButton.Checked Then
                    priceDecimal = XXL_DECIMAL
                Else
                    MessageBox.Show("Please select a shirt size", "Missing Selection" _
                                     , MessageBoxButtons.OK)
                End If

                If .monoCheckBox.Checked Then
                    priceDecimal += MONO_DECIMAL
                End If
                If .pocketCheckBox.Checked Then
                    priceDecimal += POCK_DECIMAL
                End If

                ' Calculate Price
                shirtPriceDecimal = priceDecimal * quantityInteger
                total_shirtPrice += shirtPriceDecimal
                total_order += total_shirtPrice
                totalQuantityShirt += quantityInteger
                summaryTotal += shirtPriceDecimal
                orderCountInteger += 1

                ' Display Values Into Textboxes
                .shirtPriceTextBox.Text = shirtPriceDecimal.ToString("C")
                .currOrderTextBox.Text = total_shirtPrice.ToString("C")

                Try
                    ' Catch Values Less Than Zero
                Catch quantityException As FormatException
                    MessageBox.Show("Quantity must be greater than zero.", _
                        "Data Entry Error", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                    With .quantityTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            End If
        End With
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Dim clearDialogResult As DialogResult
        Dim messageString As String

        With Me
            messageString = "Clear the current order details?"
            clearDialogResult = MessageBox.Show(messageString, "Clear Order", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
              MessageBoxDefaultButton.Button2)

            If clearDialogResult = Windows.Forms.DialogResult.Yes Then
                .quantityTextBox.Clear()
                .smallRadioButton.Checked = False
                .mediumRadioButton.Checked = False
                .largeRadioButton.Checked = False
                .xtraLrgeRadioButton.Checked = False
                .xXLRadioButton.Checked = False
                .monoCheckBox.Checked = False
                .pocketCheckBox.Checked = False
                .shirtPriceTextBox.Clear()
                .currOrderTextBox.Clear()
            End If
        End With
    End Sub

    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click
        Dim clearDialogResult As DialogResult
        Dim messageString As String

        With Me
            messageString = "Do you wish to submit your order?"
            clearDialogResult = MessageBox.Show(messageString, "Submit Order", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
              MessageBoxDefaultButton.Button2)

            If clearDialogResult = Windows.Forms.DialogResult.Yes Then
                .quantityTextBox.Clear()
                .smallRadioButton.Checked = False
                .mediumRadioButton.Checked = False
                .largeRadioButton.Checked = False
                .xtraLrgeRadioButton.Checked = False
                .xXLRadioButton.Checked = False
                .monoCheckBox.Checked = False
                .pocketCheckBox.Checked = False
                .shirtPriceTextBox.Clear()
                .currOrderTextBox.Clear()
                .custNameTextBox.Clear()
                .orderNumbTextBox.Clear()
                total_order = 0
                total_shirtPrice = 0
                summaryTotal = 0
                orderCountInteger = 0
                totalQuantityShirt = 0


                .custNameTextBox.Enabled = True
                .orderNumbTextBox.Enabled = True
                .submitButton.Enabled = False
                .summaryButton.Enabled = True
                .custNameTextBox.Focus()
            End If
        End With
    End Sub
End Class

