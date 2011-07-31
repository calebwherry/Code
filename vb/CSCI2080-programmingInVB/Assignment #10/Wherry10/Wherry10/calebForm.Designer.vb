<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phoneNumberForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nameLabel = New System.Windows.Forms.Label
        Me.phoneNumberLabel = New System.Windows.Forms.Label
        Me.openButton = New System.Windows.Forms.Button
        Me.nextButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.name1Label = New System.Windows.Forms.Label
        Me.phoneNumber1Label = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(83, 52)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(88, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Company Name: "
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Location = New System.Drawing.Point(40, 101)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(131, 13)
        Me.phoneNumberLabel.TabIndex = 1
        Me.phoneNumberLabel.Text = "Company Phone Number: "
        '
        'openButton
        '
        Me.openButton.Location = New System.Drawing.Point(86, 166)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(75, 23)
        Me.openButton.TabIndex = 2
        Me.openButton.Text = "Open"
        Me.openButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(213, 166)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 3
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(338, 166)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'name1Label
        '
        Me.name1Label.AutoSize = True
        Me.name1Label.Location = New System.Drawing.Point(177, 52)
        Me.name1Label.Name = "name1Label"
        Me.name1Label.Size = New System.Drawing.Size(0, 13)
        Me.name1Label.TabIndex = 5
        '
        'phoneNumber1Label
        '
        Me.phoneNumber1Label.AutoSize = True
        Me.phoneNumber1Label.Location = New System.Drawing.Point(177, 101)
        Me.phoneNumber1Label.Name = "phoneNumber1Label"
        Me.phoneNumber1Label.Size = New System.Drawing.Size(0, 13)
        Me.phoneNumber1Label.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'phoneNumberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 247)
        Me.Controls.Add(Me.phoneNumber1Label)
        Me.Controls.Add(Me.name1Label)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.openButton)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "phoneNumberForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caleb's Quick Phone Number Access "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents phoneNumberLabel As System.Windows.Forms.Label
    Friend WithEvents openButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents name1Label As System.Windows.Forms.Label
    Friend WithEvents phoneNumber1Label As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
