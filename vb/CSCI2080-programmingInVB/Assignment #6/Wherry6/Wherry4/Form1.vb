' Caleb Wherry
' October 12, 2007
' Wherry6
' Revised assignment 5 to fit assignment 6.


Option Strict On

Public Class veryVeryBoardsForm
    Const SML_DECIMAL As Decimal = 10D
    Const XL_DECIMAL As Decimal = 11D
    Const XXL_DECIMAL As Decimal = 12D
    Const MONO_DECIMAL As Decimal = 2D
    Const POCK_DECIMAL As Decimal = 1D
    Private total_shirtPrice, summaryTotal, total_order As Decimal
    Private orderCountInteger, totalQuantityShirt As Integer

    Private Function shirtPrice(ByVal numberShirts As Decimal) As Decimal
        'Find price of shirts.

        Dim shirtPriceDecimal As Decimal

        With Me
            If .smallRadioButton.Checked Or .mediumRadioButton.Checked Or .largeRadioButton.Checked Then
                shirtPriceDecimal = SML_DECIMAL
            ElseIf .extraLargeRadioButton.Checked Then
                shirtPriceDecimal = XL_DECIMAL
            Else
                shirtPriceDecimal = XXL_DECIMAL
            End If

            If .monoCheckBox.Checked = True Then
                shirtPriceDecimal += MONO_DECIMAL
            End If
            If .pocketCheckBox.Checked = True Then
                shirtPriceDecimal += POCK_DECIMAL
            End If
        End With

        Return shirtPriceDecimal * numberShirts
    End Function


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
                ElseIf .extraLargeRadioButton.Checked Then
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
                .extraLargeRadioButton.Checked = False
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
                .extraLargeRadioButton.Checked = False
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

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays about form

        AboutBox1.ShowDialog()
    End Sub

    Private Sub SloganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SloganToolStripMenuItem.Click
        ' Hide & display slogan

        If SloganToolStripMenuItem.Checked Then
            sloganLabel.Text = ""
            SloganToolStripMenuItem.Checked = False
        Else
            sloganLabel.Text = "The Best In T-Shirts!"
            SloganToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub LogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoToolStripMenuItem.Click
        ' Hide & display logo

        If LogoToolStripMenuItem.Checked Then
            logoPictureBox.Visible = False
            LogoToolStripMenuItem.Checked = False
        Else
            logoPictureBox.Visible = True
            LogoToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Change the font of the slogan

        With Me
            With .FontDialog1
                .ShowDialog()
                sloganLabel.Font = .Font
            End With
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Change the color of the slogan

        With Me
            With .ColorDialog1
                .ShowDialog()
                sloganLabel.ForeColor = .Color
            End With
        End With
    End Sub

    Private Sub ClearThisItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearThisItemToolStripMenuItem.Click
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
                .extraLargeRadioButton.Checked = False
                .xXLRadioButton.Checked = False
                .monoCheckBox.Checked = False
                .pocketCheckBox.Checked = False
                .shirtPriceTextBox.Clear()
                .currOrderTextBox.Clear()
            End If
        End With
    End Sub

    Private Sub AddToOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToOrderToolStripMenuItem.Click
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
                ElseIf .extraLargeRadioButton.Checked Then
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

    Private Sub OrderCompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCompleteToolStripMenuItem.Click
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
                .extraLargeRadioButton.Checked = False
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

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
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

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

