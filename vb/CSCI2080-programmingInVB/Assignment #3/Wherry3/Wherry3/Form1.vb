Public Class salesEntryForm

    Const BASE_PAY_Integer As Integer = 900I
    Const COMMISSION_Decimal As Decimal = 0.06D
    Const DEDUCTIONS_Decimal As Decimal = 0.18D

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Close the application

        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ' Clear the form for new data input

        With Me
            .employeeNameTextBox.Clear()
            .employeeSalesTextBox.Clear()
            .grossPayTextBox.Clear()
            .deductionsTextBox.Clear()
            .netPayTextBox.Clear()
            .housingTextBox.Clear()
            .foodClothingTextBox.Clear()
            .entertainmentTextBox.Clear()
            .miscellaneousTextBox.Clear()

            .employeeNameTextBox.Focus()
        End With
    End Sub

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        ' Calculate all the nesessary costs with the given input.

        Dim salesDecimal, grossPayDecimal, deductionsDecimal, netPayDecimal As Decimal
        Dim housingDecimal, foodClothingDecimal, entertainmentDecimal, miscellaneousDecimal As Decimal

        Try
            ' Read in the intial input of sales and convert to decimal.
            salesDecimal = Decimal.Parse(Me.employeeSalesTextBox.Text)

            ' Calculate the first group using the intial input of sales.
            grossPayDecimal = BASE_PAY_Integer + (salesDecimal * COMMISSION_Decimal)
            deductionsDecimal = grossPayDecimal * DEDUCTIONS_Decimal
            netPayDecimal = grossPayDecimal - deductionsDecimal

            ' Calculate the second group using the new found Net Pay
            housingDecimal = netPayDecimal * 0.3
            foodClothingDecimal = netPayDecimal * 0.15
            entertainmentDecimal = netPayDecimal * 0.5
            miscellaneousDecimal = netPayDecimal * 0.05

            ' Format and display the calculations found.
            With Me
                ' First group. 
                .grossPayTextBox.Text = grossPayDecimal.ToString("C")
                .deductionsTextBox.Text = deductionsDecimal.ToString("C")
                .netPayTextBox.Text = netPayDecimal.ToString("C")

                ' Second group.
                .housingTextBox.Text = housingDecimal.ToString("C")
                .foodClothingTextBox.Text = foodClothingDecimal.ToString("C")
                .entertainmentTextBox.Text = entertainmentDecimal.ToString("C")
                .miscellaneousTextBox.Text = miscellaneousDecimal.ToString("C")
            End With


        Catch err As FormatException
            ' Display an error window if the inputted sales amount is not a number.

            MessageBox.Show("Sales data has to be numeric!", "Invalid Data", MessageBoxButtons.OK)
            Me.employeeSalesTextBox.Focus()
        End Try

    End Sub

    Private Sub employeeNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles employeeNameTextBox.TextChanged
        Me.employeeNameTextBox.Focus()
    End Sub
End Class
