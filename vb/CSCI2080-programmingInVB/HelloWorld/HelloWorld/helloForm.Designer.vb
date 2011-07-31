<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helloForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.messageLabel = New System.Windows.Forms.Label
        Me.englishButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.spanishButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.Location = New System.Drawing.Point(152, 56)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(0, 20)
        Me.messageLabel.TabIndex = 1
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'englishButton
        '
        Me.englishButton.Location = New System.Drawing.Point(80, 178)
        Me.englishButton.Name = "englishButton"
        Me.englishButton.Size = New System.Drawing.Size(75, 42)
        Me.englishButton.TabIndex = 2
        Me.englishButton.Text = "English"
        Me.englishButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(156, 241)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 41)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Created By: Caleb Wherry"
        '
        'spanishButton
        '
        Me.spanishButton.Location = New System.Drawing.Point(235, 178)
        Me.spanishButton.Name = "spanishButton"
        Me.spanishButton.Size = New System.Drawing.Size(75, 42)
        Me.spanishButton.TabIndex = 5
        Me.spanishButton.Text = "Spanish"
        Me.spanishButton.UseVisualStyleBackColor = True
        '
        'helloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 347)
        Me.Controls.Add(Me.spanishButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.englishButton)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "helloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World by Caleb Wherry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents englishButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents spanishButton As System.Windows.Forms.Button

End Class
