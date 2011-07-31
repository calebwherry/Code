' Caleb Wherry
' Wherry2
' 9-12-07
' Purpose: To display information for the Cool Boards
'          company using radio buttons and check boxes.

Public Class coolBoardsForm

    Private Sub companyNameCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles companyNameCheckBox.CheckedChanged
        ' Make the visibility of the label match the settings in the check box.

        Me.companyNameLabel.Visible = Me.companyNameCheckBox.Checked
    End Sub

    Private Sub sloganCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sloganCheckBox.CheckedChanged
        ' Make the visibility of the label match the settings in the check box.

        Me.sloganLabel.Visible = Me.sloganCheckBox.Checked
    End Sub

    Private Sub logoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoCheckBox.CheckedChanged
        ' Make the visibility of the label match the settings in the check box.

        Me.logoPictureBox.Visible = Me.logoCheckBox.Checked
    End Sub

    Private Sub programmerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles programmerCheckBox.CheckedChanged
        ' Make the visibility of the label match the settings in the check box.

        Me.programmerLabel.Visible = Me.programmerCheckBox.Checked
    End Sub

    Private Sub redRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redRadioButton.CheckedChanged
        ' Make the visibility of the label match the settings of the radio button

        Me.sloganLabel.ForeColor = Color.Red
    End Sub

    Private Sub blueRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blueRadioButton.CheckedChanged
        ' Make the visibility of the label match the settings of the radio button

        Me.sloganLabel.ForeColor = Color.Blue
    End Sub

    Private Sub greenRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greenRadioButton.CheckedChanged
        ' Make the visibility of the label match the settings of the radio button

        Me.sloganLabel.ForeColor = Color.Green
    End Sub

    Private Sub blackRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackRadioButton.CheckedChanged
        ' Make the visibility of the label match the settings of the radio button

        Me.sloganLabel.ForeColor = Color.Black
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Exit the project

        Me.Close()
    End Sub
End Class
