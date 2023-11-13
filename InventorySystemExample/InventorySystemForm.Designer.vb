<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventorySystemForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RecordInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PartNumberLabel = New System.Windows.Forms.Label()
        Me.PartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.VenderLabel = New System.Windows.Forms.Label()
        Me.VendorTextBox = New System.Windows.Forms.TextBox()
        Me.ManufactureLabel = New System.Windows.Forms.Label()
        Me.ManufactureTextBox = New System.Windows.Forms.TextBox()
        Me.DataSheetLabel = New System.Windows.Forms.Label()
        Me.DataSheetTextBox = New System.Windows.Forms.TextBox()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordInfoGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecordInfoGroupBox
        '
        Me.RecordInfoGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RecordInfoGroupBox.Controls.Add(Me.DescriptionLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.PartNumberLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.PartNumberTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.LocationLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.LocationTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.VenderLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.VendorTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.ManufactureLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.ManufactureTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.DataSheetLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.DataSheetTextBox)
        Me.RecordInfoGroupBox.Location = New System.Drawing.Point(88, 46)
        Me.RecordInfoGroupBox.Name = "RecordInfoGroupBox"
        Me.RecordInfoGroupBox.Size = New System.Drawing.Size(319, 254)
        Me.RecordInfoGroupBox.TabIndex = 0
        Me.RecordInfoGroupBox.TabStop = False
        Me.RecordInfoGroupBox.Text = "Record Info"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateContextMenuItem, Me.ClearContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(128, 52)
        '
        'UpdateContextMenuItem
        '
        Me.UpdateContextMenuItem.Name = "UpdateContextMenuItem"
        Me.UpdateContextMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.UpdateContextMenuItem.Text = "&Update"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.ClearContextMenuItem.Text = "&Clear"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(9, 25)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(79, 17)
        Me.DescriptionLabel.TabIndex = 4
        Me.DescriptionLabel.Text = "Description"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(95, 25)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(213, 22)
        Me.DescriptionTextBox.TabIndex = 0
        '
        'PartNumberLabel
        '
        Me.PartNumberLabel.AutoSize = True
        Me.PartNumberLabel.Location = New System.Drawing.Point(27, 56)
        Me.PartNumberLabel.Name = "PartNumberLabel"
        Me.PartNumberLabel.Size = New System.Drawing.Size(46, 17)
        Me.PartNumberLabel.TabIndex = 5
        Me.PartNumberLabel.Text = "Part #"
        '
        'PartNumberTextBox
        '
        Me.PartNumberTextBox.Location = New System.Drawing.Point(95, 53)
        Me.PartNumberTextBox.Name = "PartNumberTextBox"
        Me.PartNumberTextBox.Size = New System.Drawing.Size(213, 22)
        Me.PartNumberTextBox.TabIndex = 1
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(19, 86)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(62, 17)
        Me.LocationLabel.TabIndex = 6
        Me.LocationLabel.Text = "Location"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Location = New System.Drawing.Point(95, 81)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(213, 22)
        Me.LocationTextBox.TabIndex = 2
        '
        'VenderLabel
        '
        Me.VenderLabel.AutoSize = True
        Me.VenderLabel.Location = New System.Drawing.Point(19, 114)
        Me.VenderLabel.Name = "VenderLabel"
        Me.VenderLabel.Size = New System.Drawing.Size(54, 17)
        Me.VenderLabel.TabIndex = 7
        Me.VenderLabel.Text = "Vendor"
        '
        'VendorTextBox
        '
        Me.VendorTextBox.Location = New System.Drawing.Point(95, 109)
        Me.VendorTextBox.Name = "VendorTextBox"
        Me.VendorTextBox.Size = New System.Drawing.Size(213, 22)
        Me.VendorTextBox.TabIndex = 3
        '
        'ManufactureLabel
        '
        Me.ManufactureLabel.AutoSize = True
        Me.ManufactureLabel.Location = New System.Drawing.Point(6, 142)
        Me.ManufactureLabel.Name = "ManufactureLabel"
        Me.ManufactureLabel.Size = New System.Drawing.Size(87, 17)
        Me.ManufactureLabel.TabIndex = 10
        Me.ManufactureLabel.Text = "Manufacture"
        '
        'ManufactureTextBox
        '
        Me.ManufactureTextBox.Location = New System.Drawing.Point(95, 139)
        Me.ManufactureTextBox.Name = "ManufactureTextBox"
        Me.ManufactureTextBox.Size = New System.Drawing.Size(213, 22)
        Me.ManufactureTextBox.TabIndex = 4
        '
        'DataSheetLabel
        '
        Me.DataSheetLabel.AutoSize = True
        Me.DataSheetLabel.Location = New System.Drawing.Point(9, 172)
        Me.DataSheetLabel.Name = "DataSheetLabel"
        Me.DataSheetLabel.Size = New System.Drawing.Size(75, 17)
        Me.DataSheetLabel.TabIndex = 11
        Me.DataSheetLabel.Text = "DataSheet"
        '
        'DataSheetTextBox
        '
        Me.DataSheetTextBox.Location = New System.Drawing.Point(95, 167)
        Me.DataSheetTextBox.Name = "DataSheetTextBox"
        Me.DataSheetTextBox.Size = New System.Drawing.Size(213, 22)
        Me.DataSheetTextBox.TabIndex = 5
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton6)
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton5)
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox3)
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox2)
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox1)
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton4)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(413, 46)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Size = New System.Drawing.Size(243, 224)
        Me.OptionsGroupBox.TabIndex = 1
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "Options"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(62, 184)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(62, 157)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(77, 77)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(77, 50)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(77, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(62, 130)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.UpdateButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(148, 305)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(463, 89)
        Me.ButtonGroupBox.TabIndex = 2
        Me.ButtonGroupBox.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(6, 21)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(144, 57)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(156, 21)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(144, 57)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Press This Button to Clear Entered Data")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(307, 21)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 57)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Press This Button to Quit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.TopMenuStrip.TabIndex = 3
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateTopMenuItem, Me.ClearTopMenuItem, Me.ExitTopMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'UpdateTopMenuItem
        '
        Me.UpdateTopMenuItem.Name = "UpdateTopMenuItem"
        Me.UpdateTopMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.UpdateTopMenuItem.Text = "&Update"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.ClearTopMenuItem.Text = "&Clear"
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.ExitTopMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutTopMenuItem.Text = "&About"
        '
        'InventorySystemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RecordInfoGroupBox)
        Me.Controls.Add(Me.OptionsGroupBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "InventorySystemForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Manager"
        Me.RecordInfoGroupBox.ResumeLayout(False)
        Me.RecordInfoGroupBox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.OptionsGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecordInfoGroupBox As GroupBox
    Friend WithEvents DataSheetLabel As Label
    Friend WithEvents ManufactureLabel As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PartNumberTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents VendorTextBox As TextBox
    Friend WithEvents ManufactureTextBox As TextBox
    Friend WithEvents DataSheetTextBox As TextBox
    Friend WithEvents VenderLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents PartNumberLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents OptionsGroupBox As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateTopMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents UpdateContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
End Class
