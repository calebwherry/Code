<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class veryVeryBoardsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(veryVeryBoardsForm))
        Me.titleLabel = New System.Windows.Forms.Label
        Me.custNameLabel = New System.Windows.Forms.Label
        Me.custNameTextBox = New System.Windows.Forms.TextBox
        Me.orderNumbTextBox = New System.Windows.Forms.TextBox
        Me.orderNumbLabel = New System.Windows.Forms.Label
        Me.orderGroupBox = New System.Windows.Forms.GroupBox
        Me.clearButton = New System.Windows.Forms.Button
        Me.addButton = New System.Windows.Forms.Button
        Me.quantityTextBox = New System.Windows.Forms.TextBox
        Me.quantityLabel = New System.Windows.Forms.Label
        Me.sizesGroupBox = New System.Windows.Forms.GroupBox
        Me.largeRadioButton = New System.Windows.Forms.RadioButton
        Me.extraLargeRadioButton = New System.Windows.Forms.RadioButton
        Me.mediumRadioButton = New System.Windows.Forms.RadioButton
        Me.xXLRadioButton = New System.Windows.Forms.RadioButton
        Me.smallRadioButton = New System.Windows.Forms.RadioButton
        Me.monoPockGroupBox = New System.Windows.Forms.GroupBox
        Me.pocketCheckBox = New System.Windows.Forms.CheckBox
        Me.monoCheckBox = New System.Windows.Forms.CheckBox
        Me.pricingGroupBox = New System.Windows.Forms.GroupBox
        Me.currOrderTextBox = New System.Windows.Forms.TextBox
        Me.shirtPriceTextBox = New System.Windows.Forms.TextBox
        Me.currOrderLabel = New System.Windows.Forms.Label
        Me.shirtPriceLabel = New System.Windows.Forms.Label
        Me.submitButton = New System.Windows.Forms.Button
        Me.summaryButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SloganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sloganLabel = New System.Windows.Forms.Label
        Me.logoPictureBox = New System.Windows.Forms.PictureBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.logoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sloganToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.orderGroupBox.SuspendLayout()
        Me.sizesGroupBox.SuspendLayout()
        Me.monoPockGroupBox.SuspendLayout()
        Me.pricingGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(116, 40)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(186, 31)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "T-Shirt Orders"
        '
        'custNameLabel
        '
        Me.custNameLabel.AutoSize = True
        Me.custNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.custNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.custNameLabel.Location = New System.Drawing.Point(33, 94)
        Me.custNameLabel.Name = "custNameLabel"
        Me.custNameLabel.Size = New System.Drawing.Size(109, 17)
        Me.custNameLabel.TabIndex = 1
        Me.custNameLabel.Text = "Customer Name"
        '
        'custNameTextBox
        '
        Me.custNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custNameTextBox.Location = New System.Drawing.Point(152, 91)
        Me.custNameTextBox.Name = "custNameTextBox"
        Me.custNameTextBox.Size = New System.Drawing.Size(225, 23)
        Me.custNameTextBox.TabIndex = 2
        '
        'orderNumbTextBox
        '
        Me.orderNumbTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderNumbTextBox.Location = New System.Drawing.Point(152, 134)
        Me.orderNumbTextBox.Name = "orderNumbTextBox"
        Me.orderNumbTextBox.Size = New System.Drawing.Size(225, 23)
        Me.orderNumbTextBox.TabIndex = 3
        '
        'orderNumbLabel
        '
        Me.orderNumbLabel.AutoSize = True
        Me.orderNumbLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderNumbLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.orderNumbLabel.Location = New System.Drawing.Point(33, 137)
        Me.orderNumbLabel.Name = "orderNumbLabel"
        Me.orderNumbLabel.Size = New System.Drawing.Size(99, 17)
        Me.orderNumbLabel.TabIndex = 4
        Me.orderNumbLabel.Text = "Order Number"
        '
        'orderGroupBox
        '
        Me.orderGroupBox.Controls.Add(Me.clearButton)
        Me.orderGroupBox.Controls.Add(Me.addButton)
        Me.orderGroupBox.Controls.Add(Me.quantityTextBox)
        Me.orderGroupBox.Controls.Add(Me.quantityLabel)
        Me.orderGroupBox.Controls.Add(Me.sizesGroupBox)
        Me.orderGroupBox.Controls.Add(Me.monoPockGroupBox)
        Me.orderGroupBox.Controls.Add(Me.pricingGroupBox)
        Me.orderGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderGroupBox.Location = New System.Drawing.Point(11, 181)
        Me.orderGroupBox.Name = "orderGroupBox"
        Me.orderGroupBox.Size = New System.Drawing.Size(411, 309)
        Me.orderGroupBox.TabIndex = 5
        Me.orderGroupBox.TabStop = False
        Me.orderGroupBox.Text = "Order Information"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(277, 253)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(98, 34)
        Me.clearButton.TabIndex = 11
        Me.clearButton.Text = "&Clear Screen"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(277, 206)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(98, 34)
        Me.addButton.TabIndex = 10
        Me.addButton.Text = "&Add to Order"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(149, 44)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(53, 23)
        Me.quantityTextBox.TabIndex = 9
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.quantityLabel.Location = New System.Drawing.Point(73, 47)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(61, 17)
        Me.quantityLabel.TabIndex = 0
        Me.quantityLabel.Text = "Quantity"
        '
        'sizesGroupBox
        '
        Me.sizesGroupBox.Controls.Add(Me.largeRadioButton)
        Me.sizesGroupBox.Controls.Add(Me.extraLargeRadioButton)
        Me.sizesGroupBox.Controls.Add(Me.mediumRadioButton)
        Me.sizesGroupBox.Controls.Add(Me.xXLRadioButton)
        Me.sizesGroupBox.Controls.Add(Me.smallRadioButton)
        Me.sizesGroupBox.Location = New System.Drawing.Point(260, 13)
        Me.sizesGroupBox.Name = "sizesGroupBox"
        Me.sizesGroupBox.Size = New System.Drawing.Size(94, 171)
        Me.sizesGroupBox.TabIndex = 8
        Me.sizesGroupBox.TabStop = False
        Me.sizesGroupBox.Text = "Sizes"
        '
        'largeRadioButton
        '
        Me.largeRadioButton.AutoSize = True
        Me.largeRadioButton.Location = New System.Drawing.Point(17, 76)
        Me.largeRadioButton.Name = "largeRadioButton"
        Me.largeRadioButton.Size = New System.Drawing.Size(63, 21)
        Me.largeRadioButton.TabIndex = 13
        Me.largeRadioButton.TabStop = True
        Me.largeRadioButton.Text = "Larg&e"
        Me.largeRadioButton.UseVisualStyleBackColor = True
        '
        'extraLargeRadioButton
        '
        Me.extraLargeRadioButton.AutoSize = True
        Me.extraLargeRadioButton.Location = New System.Drawing.Point(17, 103)
        Me.extraLargeRadioButton.Name = "extraLargeRadioButton"
        Me.extraLargeRadioButton.Size = New System.Drawing.Size(43, 21)
        Me.extraLargeRadioButton.TabIndex = 14
        Me.extraLargeRadioButton.TabStop = True
        Me.extraLargeRadioButton.Text = "&XL"
        Me.extraLargeRadioButton.UseVisualStyleBackColor = True
        '
        'mediumRadioButton
        '
        Me.mediumRadioButton.AutoSize = True
        Me.mediumRadioButton.Location = New System.Drawing.Point(17, 49)
        Me.mediumRadioButton.Name = "mediumRadioButton"
        Me.mediumRadioButton.Size = New System.Drawing.Size(75, 21)
        Me.mediumRadioButton.TabIndex = 12
        Me.mediumRadioButton.TabStop = True
        Me.mediumRadioButton.Text = "&Medium"
        Me.mediumRadioButton.UseVisualStyleBackColor = True
        '
        'xXLRadioButton
        '
        Me.xXLRadioButton.AutoSize = True
        Me.xXLRadioButton.Location = New System.Drawing.Point(17, 136)
        Me.xXLRadioButton.Name = "xXLRadioButton"
        Me.xXLRadioButton.Size = New System.Drawing.Size(52, 21)
        Me.xXLRadioButton.TabIndex = 15
        Me.xXLRadioButton.TabStop = True
        Me.xXLRadioButton.Text = "XX&L"
        Me.xXLRadioButton.UseVisualStyleBackColor = True
        '
        'smallRadioButton
        '
        Me.smallRadioButton.AutoSize = True
        Me.smallRadioButton.Location = New System.Drawing.Point(17, 22)
        Me.smallRadioButton.Name = "smallRadioButton"
        Me.smallRadioButton.Size = New System.Drawing.Size(60, 21)
        Me.smallRadioButton.TabIndex = 12
        Me.smallRadioButton.TabStop = True
        Me.smallRadioButton.Text = "&Small"
        Me.smallRadioButton.UseVisualStyleBackColor = True
        '
        'monoPockGroupBox
        '
        Me.monoPockGroupBox.Controls.Add(Me.pocketCheckBox)
        Me.monoPockGroupBox.Controls.Add(Me.monoCheckBox)
        Me.monoPockGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monoPockGroupBox.Location = New System.Drawing.Point(62, 86)
        Me.monoPockGroupBox.Name = "monoPockGroupBox"
        Me.monoPockGroupBox.Size = New System.Drawing.Size(140, 84)
        Me.monoPockGroupBox.TabIndex = 7
        Me.monoPockGroupBox.TabStop = False
        Me.monoPockGroupBox.Text = "Monogram/Pocket"
        '
        'pocketCheckBox
        '
        Me.pocketCheckBox.AutoSize = True
        Me.pocketCheckBox.Location = New System.Drawing.Point(14, 58)
        Me.pocketCheckBox.Name = "pocketCheckBox"
        Me.pocketCheckBox.Size = New System.Drawing.Size(69, 20)
        Me.pocketCheckBox.TabIndex = 9
        Me.pocketCheckBox.Text = "&Pocket"
        Me.pocketCheckBox.UseVisualStyleBackColor = True
        '
        'monoCheckBox
        '
        Me.monoCheckBox.AutoSize = True
        Me.monoCheckBox.Location = New System.Drawing.Point(14, 21)
        Me.monoCheckBox.Name = "monoCheckBox"
        Me.monoCheckBox.Size = New System.Drawing.Size(92, 20)
        Me.monoCheckBox.TabIndex = 8
        Me.monoCheckBox.Text = "M&onogram"
        Me.monoCheckBox.UseVisualStyleBackColor = True
        '
        'pricingGroupBox
        '
        Me.pricingGroupBox.Controls.Add(Me.currOrderTextBox)
        Me.pricingGroupBox.Controls.Add(Me.shirtPriceTextBox)
        Me.pricingGroupBox.Controls.Add(Me.currOrderLabel)
        Me.pricingGroupBox.Controls.Add(Me.shirtPriceLabel)
        Me.pricingGroupBox.Location = New System.Drawing.Point(6, 187)
        Me.pricingGroupBox.Name = "pricingGroupBox"
        Me.pricingGroupBox.Size = New System.Drawing.Size(232, 100)
        Me.pricingGroupBox.TabIndex = 6
        Me.pricingGroupBox.TabStop = False
        Me.pricingGroupBox.Text = "Pricing"
        '
        'currOrderTextBox
        '
        Me.currOrderTextBox.Enabled = False
        Me.currOrderTextBox.Location = New System.Drawing.Point(121, 63)
        Me.currOrderTextBox.Name = "currOrderTextBox"
        Me.currOrderTextBox.Size = New System.Drawing.Size(90, 23)
        Me.currOrderTextBox.TabIndex = 3
        '
        'shirtPriceTextBox
        '
        Me.shirtPriceTextBox.Enabled = False
        Me.shirtPriceTextBox.Location = New System.Drawing.Point(121, 30)
        Me.shirtPriceTextBox.Name = "shirtPriceTextBox"
        Me.shirtPriceTextBox.Size = New System.Drawing.Size(90, 23)
        Me.shirtPriceTextBox.TabIndex = 2
        '
        'currOrderLabel
        '
        Me.currOrderLabel.AutoSize = True
        Me.currOrderLabel.Location = New System.Drawing.Point(19, 66)
        Me.currOrderLabel.Name = "currOrderLabel"
        Me.currOrderLabel.Size = New System.Drawing.Size(81, 17)
        Me.currOrderLabel.TabIndex = 1
        Me.currOrderLabel.Text = "Total Order"
        '
        'shirtPriceLabel
        '
        Me.shirtPriceLabel.AutoSize = True
        Me.shirtPriceLabel.Location = New System.Drawing.Point(19, 35)
        Me.shirtPriceLabel.Name = "shirtPriceLabel"
        Me.shirtPriceLabel.Size = New System.Drawing.Size(96, 17)
        Me.shirtPriceLabel.TabIndex = 0
        Me.shirtPriceLabel.Text = "Current Order"
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(102, 505)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(112, 36)
        Me.submitButton.TabIndex = 6
        Me.submitButton.Text = "Su&bmit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton.Location = New System.Drawing.Point(246, 505)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(106, 36)
        Me.summaryButton.TabIndex = 7
        Me.summaryButton.Text = "S&ummary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SAToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "mainMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SAToolStripMenuItem
        '
        Me.SAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToOrderToolStripMenuItem, Me.ClearThisItemToolStripMenuItem, Me.OrderCompleteToolStripMenuItem})
        Me.SAToolStripMenuItem.Name = "SAToolStripMenuItem"
        Me.SAToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SAToolStripMenuItem.Text = "&Sale"
        '
        'AddToOrderToolStripMenuItem
        '
        Me.AddToOrderToolStripMenuItem.Name = "AddToOrderToolStripMenuItem"
        Me.AddToOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AddToOrderToolStripMenuItem.Text = "&Add To Order"
        '
        'ClearThisItemToolStripMenuItem
        '
        Me.ClearThisItemToolStripMenuItem.Name = "ClearThisItemToolStripMenuItem"
        Me.ClearThisItemToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ClearThisItemToolStripMenuItem.Text = "C&lear This Item"
        '
        'OrderCompleteToolStripMenuItem
        '
        Me.OrderCompleteToolStripMenuItem.Name = "OrderCompleteToolStripMenuItem"
        Me.OrderCompleteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OrderCompleteToolStripMenuItem.Text = "O&rder Complete"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripSeparator2, Me.SloganToolStripMenuItem, Me.LogoToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(109, 6)
        '
        'SloganToolStripMenuItem
        '
        Me.SloganToolStripMenuItem.Checked = True
        Me.SloganToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SloganToolStripMenuItem.Name = "SloganToolStripMenuItem"
        Me.SloganToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SloganToolStripMenuItem.Text = "&Slogan"
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Checked = True
        Me.LogoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoToolStripMenuItem.Text = "&Logo"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'sloganLabel
        '
        Me.sloganLabel.AutoSize = True
        Me.sloganLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sloganLabel.Location = New System.Drawing.Point(451, 346)
        Me.sloganLabel.Name = "sloganLabel"
        Me.sloganLabel.Size = New System.Drawing.Size(232, 29)
        Me.sloganLabel.TabIndex = 10
        Me.sloganLabel.Text = "The Best In T-Shirts!"
        Me.sloganToolTip.SetToolTip(Me.sloganLabel, "Our Slogan")
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(509, 203)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(108, 105)
        Me.logoPictureBox.TabIndex = 11
        Me.logoPictureBox.TabStop = False
        Me.logoToolTip.SetToolTip(Me.logoPictureBox, "Our Logo")
        '
        'veryVeryBoardsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 563)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.sloganLabel)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.orderGroupBox)
        Me.Controls.Add(Me.orderNumbLabel)
        Me.Controls.Add(Me.orderNumbTextBox)
        Me.Controls.Add(Me.custNameTextBox)
        Me.Controls.Add(Me.custNameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "veryVeryBoardsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Very Very Boards"
        Me.orderGroupBox.ResumeLayout(False)
        Me.orderGroupBox.PerformLayout()
        Me.sizesGroupBox.ResumeLayout(False)
        Me.sizesGroupBox.PerformLayout()
        Me.monoPockGroupBox.ResumeLayout(False)
        Me.monoPockGroupBox.PerformLayout()
        Me.pricingGroupBox.ResumeLayout(False)
        Me.pricingGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents custNameLabel As System.Windows.Forms.Label
    Friend WithEvents custNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents orderNumbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents orderNumbLabel As System.Windows.Forms.Label
    Friend WithEvents orderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents monoPockGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents pricingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityLabel As System.Windows.Forms.Label
    Friend WithEvents sizesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents pocketCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents monoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents currOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents shirtPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents currOrderLabel As System.Windows.Forms.Label
    Friend WithEvents shirtPriceLabel As System.Windows.Forms.Label
    Friend WithEvents largeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents mediumRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents extraLargeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents xXLRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents smallRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderCompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SloganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sloganLabel As System.Windows.Forms.Label
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents logoToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents sloganToolTip As System.Windows.Forms.ToolTip

End Class
