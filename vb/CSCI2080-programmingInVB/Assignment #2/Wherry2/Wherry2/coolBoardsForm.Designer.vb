<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coolBoardsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coolBoardsForm))
        Me.companyNameLabel = New System.Windows.Forms.Label
        Me.sloganLabel = New System.Windows.Forms.Label
        Me.exitButton = New System.Windows.Forms.Button
        Me.programmerLabel = New System.Windows.Forms.Label
        Me.companyNameCheckBox = New System.Windows.Forms.CheckBox
        Me.sloganCheckBox = New System.Windows.Forms.CheckBox
        Me.logoCheckBox = New System.Windows.Forms.CheckBox
        Me.programmerCheckBox = New System.Windows.Forms.CheckBox
        Me.redRadioButton = New System.Windows.Forms.RadioButton
        Me.blueRadioButton = New System.Windows.Forms.RadioButton
        Me.greenRadioButton = New System.Windows.Forms.RadioButton
        Me.blackRadioButton = New System.Windows.Forms.RadioButton
        Me.sloganColorGroupBox = New System.Windows.Forms.GroupBox
        Me.displayGroupBox = New System.Windows.Forms.GroupBox
        Me.logoPictureBox = New System.Windows.Forms.PictureBox
        Me.companyNameToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sloganToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.logoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sloganColorGroupBox.SuspendLayout()
        Me.displayGroupBox.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'companyNameLabel
        '
        Me.companyNameLabel.AutoSize = True
        Me.companyNameLabel.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyNameLabel.Location = New System.Drawing.Point(153, 18)
        Me.companyNameLabel.Name = "companyNameLabel"
        Me.companyNameLabel.Size = New System.Drawing.Size(231, 45)
        Me.companyNameLabel.TabIndex = 0
        Me.companyNameLabel.Text = "Cool Boards"
        Me.companyNameToolTip.SetToolTip(Me.companyNameLabel, "Our Company Name")
        '
        'sloganLabel
        '
        Me.sloganLabel.AutoSize = True
        Me.sloganLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sloganLabel.Location = New System.Drawing.Point(168, 73)
        Me.sloganLabel.Name = "sloganLabel"
        Me.sloganLabel.Size = New System.Drawing.Size(184, 17)
        Me.sloganLabel.TabIndex = 1
        Me.sloganLabel.Text = "Freezing Out the Compititon"
        Me.sloganToolTip.SetToolTip(Me.sloganLabel, "Our Slogan")
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(403, 340)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'programmerLabel
        '
        Me.programmerLabel.AutoSize = True
        Me.programmerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programmerLabel.Location = New System.Drawing.Point(23, 340)
        Me.programmerLabel.Name = "programmerLabel"
        Me.programmerLabel.Size = New System.Drawing.Size(151, 13)
        Me.programmerLabel.TabIndex = 4
        Me.programmerLabel.Text = "Programmed By: Caleb Wherry"
        '
        'companyNameCheckBox
        '
        Me.companyNameCheckBox.AutoSize = True
        Me.companyNameCheckBox.Checked = True
        Me.companyNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.companyNameCheckBox.Location = New System.Drawing.Point(12, 28)
        Me.companyNameCheckBox.Name = "companyNameCheckBox"
        Me.companyNameCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.companyNameCheckBox.TabIndex = 0
        Me.companyNameCheckBox.Text = "&Company Name"
        Me.companyNameCheckBox.UseVisualStyleBackColor = True
        '
        'sloganCheckBox
        '
        Me.sloganCheckBox.AutoSize = True
        Me.sloganCheckBox.Checked = True
        Me.sloganCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sloganCheckBox.Location = New System.Drawing.Point(12, 61)
        Me.sloganCheckBox.Name = "sloganCheckBox"
        Me.sloganCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.sloganCheckBox.TabIndex = 1
        Me.sloganCheckBox.Text = "&Slogan"
        Me.sloganCheckBox.UseVisualStyleBackColor = True
        '
        'logoCheckBox
        '
        Me.logoCheckBox.AutoSize = True
        Me.logoCheckBox.Checked = True
        Me.logoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.logoCheckBox.Location = New System.Drawing.Point(12, 98)
        Me.logoCheckBox.Name = "logoCheckBox"
        Me.logoCheckBox.Size = New System.Drawing.Size(50, 17)
        Me.logoCheckBox.TabIndex = 2
        Me.logoCheckBox.Text = "&Logo"
        Me.logoCheckBox.UseVisualStyleBackColor = True
        '
        'programmerCheckBox
        '
        Me.programmerCheckBox.AutoSize = True
        Me.programmerCheckBox.Checked = True
        Me.programmerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.programmerCheckBox.Location = New System.Drawing.Point(12, 132)
        Me.programmerCheckBox.Name = "programmerCheckBox"
        Me.programmerCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.programmerCheckBox.TabIndex = 3
        Me.programmerCheckBox.Text = "Progra&mmer"
        Me.programmerCheckBox.UseVisualStyleBackColor = True
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Checked = True
        Me.redRadioButton.Location = New System.Drawing.Point(6, 28)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.redRadioButton.TabIndex = 0
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "&Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(6, 60)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.blueRadioButton.TabIndex = 1
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "&Blue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(6, 98)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.greenRadioButton.TabIndex = 2
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "&Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'blackRadioButton
        '
        Me.blackRadioButton.AutoSize = True
        Me.blackRadioButton.Location = New System.Drawing.Point(6, 132)
        Me.blackRadioButton.Name = "blackRadioButton"
        Me.blackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.blackRadioButton.TabIndex = 3
        Me.blackRadioButton.TabStop = True
        Me.blackRadioButton.Text = "Blac&k"
        Me.blackRadioButton.UseVisualStyleBackColor = True
        '
        'sloganColorGroupBox
        '
        Me.sloganColorGroupBox.Controls.Add(Me.redRadioButton)
        Me.sloganColorGroupBox.Controls.Add(Me.blueRadioButton)
        Me.sloganColorGroupBox.Controls.Add(Me.greenRadioButton)
        Me.sloganColorGroupBox.Controls.Add(Me.blackRadioButton)
        Me.sloganColorGroupBox.Location = New System.Drawing.Point(26, 109)
        Me.sloganColorGroupBox.Name = "sloganColorGroupBox"
        Me.sloganColorGroupBox.Size = New System.Drawing.Size(159, 163)
        Me.sloganColorGroupBox.TabIndex = 2
        Me.sloganColorGroupBox.TabStop = False
        Me.sloganColorGroupBox.Text = "Slogan Color"
        '
        'displayGroupBox
        '
        Me.displayGroupBox.Controls.Add(Me.companyNameCheckBox)
        Me.displayGroupBox.Controls.Add(Me.sloganCheckBox)
        Me.displayGroupBox.Controls.Add(Me.logoCheckBox)
        Me.displayGroupBox.Controls.Add(Me.programmerCheckBox)
        Me.displayGroupBox.Location = New System.Drawing.Point(191, 109)
        Me.displayGroupBox.Name = "displayGroupBox"
        Me.displayGroupBox.Size = New System.Drawing.Size(170, 163)
        Me.displayGroupBox.TabIndex = 3
        Me.displayGroupBox.TabStop = False
        Me.displayGroupBox.Text = "Display"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.logoPictureBox.Image = Global.Wherry2.My.Resources.Resources.skateboarding
        Me.logoPictureBox.Location = New System.Drawing.Point(393, 115)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(85, 184)
        Me.logoPictureBox.TabIndex = 12
        Me.logoPictureBox.TabStop = False
        Me.sloganToolTip.SetToolTip(Me.logoPictureBox, "Our Logo")
        '
        'companyNameToolTip
        '
        '
        'coolBoardsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(543, 382)
        Me.Controls.Add(Me.displayGroupBox)
        Me.Controls.Add(Me.sloganColorGroupBox)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.programmerLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.sloganLabel)
        Me.Controls.Add(Me.companyNameLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "coolBoardsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cool Boards"
        Me.sloganColorGroupBox.ResumeLayout(False)
        Me.sloganColorGroupBox.PerformLayout()
        Me.displayGroupBox.ResumeLayout(False)
        Me.displayGroupBox.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents companyNameLabel As System.Windows.Forms.Label
    Friend WithEvents sloganLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents programmerLabel As System.Windows.Forms.Label
    Friend WithEvents companyNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents sloganCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents logoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents programmerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents redRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents greenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents sloganColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents displayGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents companyNameToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents sloganToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents logoToolTip As System.Windows.Forms.ToolTip

End Class
