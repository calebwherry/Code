<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesEntryForm
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
        Me.components = New System.ComponentModel.Container
        Me.employeeNameTextBox = New System.Windows.Forms.TextBox
        Me.employeeSalesTextBox = New System.Windows.Forms.TextBox
        Me.employeeNameLabel = New System.Windows.Forms.Label
        Me.employeeSalesLabel = New System.Windows.Forms.Label
        Me.calculateButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.payGroupBox = New System.Windows.Forms.GroupBox
        Me.netPayLabel = New System.Windows.Forms.Label
        Me.deductionsLabel = New System.Windows.Forms.Label
        Me.grossPayLabel = New System.Windows.Forms.Label
        Me.netPayTextBox = New System.Windows.Forms.TextBox
        Me.deductionsTextBox = New System.Windows.Forms.TextBox
        Me.grossPayTextBox = New System.Windows.Forms.TextBox
        Me.budgetGroupBox = New System.Windows.Forms.GroupBox
        Me.miscellaneousLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.housingLabel = New System.Windows.Forms.Label
        Me.miscellaneousTextBox = New System.Windows.Forms.TextBox
        Me.entertainmentTextBox = New System.Windows.Forms.TextBox
        Me.foodClothingTextBox = New System.Windows.Forms.TextBox
        Me.housingTextBox = New System.Windows.Forms.TextBox
        Me.titleLabel = New System.Windows.Forms.Label
        Me.titleToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.calculateToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.clearToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.exitToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.payGroupBox.SuspendLayout()
        Me.budgetGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'employeeNameTextBox
        '
        Me.employeeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameTextBox.Location = New System.Drawing.Point(279, 70)
        Me.employeeNameTextBox.Name = "employeeNameTextBox"
        Me.employeeNameTextBox.Size = New System.Drawing.Size(182, 26)
        Me.employeeNameTextBox.TabIndex = 0
        '
        'employeeSalesTextBox
        '
        Me.employeeSalesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeSalesTextBox.Location = New System.Drawing.Point(279, 120)
        Me.employeeSalesTextBox.Name = "employeeSalesTextBox"
        Me.employeeSalesTextBox.Size = New System.Drawing.Size(182, 26)
        Me.employeeSalesTextBox.TabIndex = 1
        '
        'employeeNameLabel
        '
        Me.employeeNameLabel.AutoSize = True
        Me.employeeNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameLabel.Location = New System.Drawing.Point(92, 73)
        Me.employeeNameLabel.Name = "employeeNameLabel"
        Me.employeeNameLabel.Size = New System.Drawing.Size(183, 20)
        Me.employeeNameLabel.TabIndex = 2
        Me.employeeNameLabel.Text = "Enter Employee's Name:"
        '
        'employeeSalesLabel
        '
        Me.employeeSalesLabel.AutoSize = True
        Me.employeeSalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeSalesLabel.Location = New System.Drawing.Point(92, 123)
        Me.employeeSalesLabel.Name = "employeeSalesLabel"
        Me.employeeSalesLabel.Size = New System.Drawing.Size(181, 20)
        Me.employeeSalesLabel.TabIndex = 3
        Me.employeeSalesLabel.Text = "Enter Employee's Sales:"
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(223, 387)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(105, 32)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate"
        Me.calculateToolTip.SetToolTip(Me.calculateButton, "Calculate Values")
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(235, 435)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(84, 32)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearToolTip.SetToolTip(Me.clearButton, "Clear Values")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(235, 484)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(84, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitToolTip.SetToolTip(Me.exitButton, "Exit Finace Manager")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'payGroupBox
        '
        Me.payGroupBox.Controls.Add(Me.netPayLabel)
        Me.payGroupBox.Controls.Add(Me.deductionsLabel)
        Me.payGroupBox.Controls.Add(Me.grossPayLabel)
        Me.payGroupBox.Controls.Add(Me.netPayTextBox)
        Me.payGroupBox.Controls.Add(Me.deductionsTextBox)
        Me.payGroupBox.Controls.Add(Me.grossPayTextBox)
        Me.payGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payGroupBox.Location = New System.Drawing.Point(59, 173)
        Me.payGroupBox.Name = "payGroupBox"
        Me.payGroupBox.Size = New System.Drawing.Size(214, 196)
        Me.payGroupBox.TabIndex = 7
        Me.payGroupBox.TabStop = False
        Me.payGroupBox.Text = "Pay"
        '
        'netPayLabel
        '
        Me.netPayLabel.AutoSize = True
        Me.netPayLabel.Location = New System.Drawing.Point(28, 154)
        Me.netPayLabel.Name = "netPayLabel"
        Me.netPayLabel.Size = New System.Drawing.Size(62, 17)
        Me.netPayLabel.TabIndex = 14
        Me.netPayLabel.Text = "Net Pay:"
        '
        'deductionsLabel
        '
        Me.deductionsLabel.AutoSize = True
        Me.deductionsLabel.Location = New System.Drawing.Point(7, 95)
        Me.deductionsLabel.Name = "deductionsLabel"
        Me.deductionsLabel.Size = New System.Drawing.Size(83, 17)
        Me.deductionsLabel.TabIndex = 13
        Me.deductionsLabel.Text = "Deductions:"
        '
        'grossPayLabel
        '
        Me.grossPayLabel.AutoSize = True
        Me.grossPayLabel.Location = New System.Drawing.Point(12, 39)
        Me.grossPayLabel.Name = "grossPayLabel"
        Me.grossPayLabel.Size = New System.Drawing.Size(78, 17)
        Me.grossPayLabel.TabIndex = 12
        Me.grossPayLabel.Text = "Gross Pay:"
        '
        'netPayTextBox
        '
        Me.netPayTextBox.Location = New System.Drawing.Point(96, 151)
        Me.netPayTextBox.Name = "netPayTextBox"
        Me.netPayTextBox.ReadOnly = True
        Me.netPayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.netPayTextBox.TabIndex = 11
        Me.netPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'deductionsTextBox
        '
        Me.deductionsTextBox.Location = New System.Drawing.Point(96, 92)
        Me.deductionsTextBox.Name = "deductionsTextBox"
        Me.deductionsTextBox.ReadOnly = True
        Me.deductionsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.deductionsTextBox.TabIndex = 10
        Me.deductionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grossPayTextBox
        '
        Me.grossPayTextBox.Location = New System.Drawing.Point(96, 36)
        Me.grossPayTextBox.Name = "grossPayTextBox"
        Me.grossPayTextBox.ReadOnly = True
        Me.grossPayTextBox.Size = New System.Drawing.Size(100, 23)
        Me.grossPayTextBox.TabIndex = 9
        Me.grossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'budgetGroupBox
        '
        Me.budgetGroupBox.Controls.Add(Me.miscellaneousLabel)
        Me.budgetGroupBox.Controls.Add(Me.Label6)
        Me.budgetGroupBox.Controls.Add(Me.Label5)
        Me.budgetGroupBox.Controls.Add(Me.housingLabel)
        Me.budgetGroupBox.Controls.Add(Me.miscellaneousTextBox)
        Me.budgetGroupBox.Controls.Add(Me.entertainmentTextBox)
        Me.budgetGroupBox.Controls.Add(Me.foodClothingTextBox)
        Me.budgetGroupBox.Controls.Add(Me.housingTextBox)
        Me.budgetGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.budgetGroupBox.Location = New System.Drawing.Point(291, 173)
        Me.budgetGroupBox.Name = "budgetGroupBox"
        Me.budgetGroupBox.Size = New System.Drawing.Size(219, 196)
        Me.budgetGroupBox.TabIndex = 0
        Me.budgetGroupBox.TabStop = False
        Me.budgetGroupBox.Text = "Budget"
        '
        'miscellaneousLabel
        '
        Me.miscellaneousLabel.AutoSize = True
        Me.miscellaneousLabel.Location = New System.Drawing.Point(1, 170)
        Me.miscellaneousLabel.Name = "miscellaneousLabel"
        Me.miscellaneousLabel.Size = New System.Drawing.Size(101, 17)
        Me.miscellaneousLabel.TabIndex = 18
        Me.miscellaneousLabel.Text = "Miscellaneous:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Entertainment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Food/Clothes:"
        '
        'housingLabel
        '
        Me.housingLabel.AutoSize = True
        Me.housingLabel.Location = New System.Drawing.Point(31, 25)
        Me.housingLabel.Name = "housingLabel"
        Me.housingLabel.Size = New System.Drawing.Size(64, 17)
        Me.housingLabel.TabIndex = 15
        Me.housingLabel.Text = "Housing:"
        '
        'miscellaneousTextBox
        '
        Me.miscellaneousTextBox.Location = New System.Drawing.Point(101, 167)
        Me.miscellaneousTextBox.Name = "miscellaneousTextBox"
        Me.miscellaneousTextBox.ReadOnly = True
        Me.miscellaneousTextBox.Size = New System.Drawing.Size(100, 23)
        Me.miscellaneousTextBox.TabIndex = 15
        Me.miscellaneousTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'entertainmentTextBox
        '
        Me.entertainmentTextBox.Location = New System.Drawing.Point(101, 120)
        Me.entertainmentTextBox.Name = "entertainmentTextBox"
        Me.entertainmentTextBox.ReadOnly = True
        Me.entertainmentTextBox.Size = New System.Drawing.Size(100, 23)
        Me.entertainmentTextBox.TabIndex = 14
        Me.entertainmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foodClothingTextBox
        '
        Me.foodClothingTextBox.Location = New System.Drawing.Point(101, 70)
        Me.foodClothingTextBox.Name = "foodClothingTextBox"
        Me.foodClothingTextBox.ReadOnly = True
        Me.foodClothingTextBox.Size = New System.Drawing.Size(100, 23)
        Me.foodClothingTextBox.TabIndex = 12
        Me.foodClothingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'housingTextBox
        '
        Me.housingTextBox.Location = New System.Drawing.Point(101, 22)
        Me.housingTextBox.Name = "housingTextBox"
        Me.housingTextBox.ReadOnly = True
        Me.housingTextBox.Size = New System.Drawing.Size(100, 23)
        Me.housingTextBox.TabIndex = 13
        Me.housingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(189, 20)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(187, 29)
        Me.titleLabel.TabIndex = 8
        Me.titleLabel.Text = "Finace Manager"
        Me.titleToolTip.SetToolTip(Me.titleLabel, "Form Title")
        '
        'salesEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(581, 519)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.budgetGroupBox)
        Me.Controls.Add(Me.payGroupBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.employeeSalesLabel)
        Me.Controls.Add(Me.employeeNameLabel)
        Me.Controls.Add(Me.employeeSalesTextBox)
        Me.Controls.Add(Me.employeeNameTextBox)
        Me.Name = "salesEntryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finace Manager"
        Me.payGroupBox.ResumeLayout(False)
        Me.payGroupBox.PerformLayout()
        Me.budgetGroupBox.ResumeLayout(False)
        Me.budgetGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents employeeSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents employeeNameLabel As System.Windows.Forms.Label
    Friend WithEvents employeeSalesLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents payGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents budgetGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents foodClothingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents netPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents deductionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grossPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents housingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents miscellaneousTextBox As System.Windows.Forms.TextBox
    Friend WithEvents entertainmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grossPayLabel As System.Windows.Forms.Label
    Friend WithEvents netPayLabel As System.Windows.Forms.Label
    Friend WithEvents deductionsLabel As System.Windows.Forms.Label
    Friend WithEvents miscellaneousLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents housingLabel As System.Windows.Forms.Label
    Friend WithEvents titleToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents calculateToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents clearToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents exitToolTip As System.Windows.Forms.ToolTip

End Class
