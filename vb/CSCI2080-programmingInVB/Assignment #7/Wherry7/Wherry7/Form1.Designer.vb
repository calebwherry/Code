<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bagelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bagelForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DisplayBagelTypeCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bagelComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bagelPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.bagelPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(270, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBagelListToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintBagelListToolStripMenuItem
        '
        Me.PrintBagelListToolStripMenuItem.Name = "PrintBagelListToolStripMenuItem"
        Me.PrintBagelListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintBagelListToolStripMenuItem.Text = "&Print Bagel List"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBagelTypeToolStripMenuItem, Me.RemoveBagelTypeToolStripMenuItem, Me.ClearBagelListToolStripMenuItem, Me.ToolStripMenuItem2, Me.DisplayBagelTypeCountToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddBagelTypeToolStripMenuItem
        '
        Me.AddBagelTypeToolStripMenuItem.Name = "AddBagelTypeToolStripMenuItem"
        Me.AddBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddBagelTypeToolStripMenuItem.Text = "&Add Bagel Type"
        '
        'RemoveBagelTypeToolStripMenuItem
        '
        Me.RemoveBagelTypeToolStripMenuItem.Name = "RemoveBagelTypeToolStripMenuItem"
        Me.RemoveBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RemoveBagelTypeToolStripMenuItem.Text = "&Remove Bagel Type"
        '
        'ClearBagelListToolStripMenuItem
        '
        Me.ClearBagelListToolStripMenuItem.Name = "ClearBagelListToolStripMenuItem"
        Me.ClearBagelListToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ClearBagelListToolStripMenuItem.Text = "&Clear Bagel List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 6)
        '
        'DisplayBagelTypeCountToolStripMenuItem
        '
        Me.DisplayBagelTypeCountToolStripMenuItem.Name = "DisplayBagelTypeCountToolStripMenuItem"
        Me.DisplayBagelTypeCountToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DisplayBagelTypeCountToolStripMenuItem.Text = "&Display Bagel Type Count"
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
        'bagelComboBox
        '
        Me.bagelComboBox.FormattingEnabled = True
        Me.bagelComboBox.Items.AddRange(New Object() {"Banana Nut", "Blueberry", "Egg", "Plain", "Poppy Seed", "Rye", "Salt", "Sesame Seed"})
        Me.bagelComboBox.Location = New System.Drawing.Point(125, 59)
        Me.bagelComboBox.Name = "bagelComboBox"
        Me.bagelComboBox.Size = New System.Drawing.Size(121, 21)
        Me.bagelComboBox.Sorted = True
        Me.bagelComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bagels"
        '
        'bagelPrintPreviewDialog
        '
        Me.bagelPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.bagelPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.bagelPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.bagelPrintPreviewDialog.Enabled = True
        Me.bagelPrintPreviewDialog.Icon = CType(resources.GetObject("bagelPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.bagelPrintPreviewDialog.Name = "bagelPrintPreviewDialog"
        Me.bagelPrintPreviewDialog.Visible = False
        '
        'bagelPrintDocument
        '
        '
        'bagelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 134)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bagelComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "bagelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caleb's Awesome Bagels"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayBagelTypeCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bagelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bagelPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents bagelPrintDocument As System.Drawing.Printing.PrintDocument

End Class
