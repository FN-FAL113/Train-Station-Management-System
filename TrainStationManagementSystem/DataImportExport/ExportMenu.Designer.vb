<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExportMenu
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
        Me.TablesDataExportCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.CSVRadioButton = New System.Windows.Forms.RadioButton()
        Me.TEXTRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TablesDataExportCheckedListBox
        '
        Me.TablesDataExportCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablesDataExportCheckedListBox.CheckOnClick = True
        Me.TablesDataExportCheckedListBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablesDataExportCheckedListBox.FormattingEnabled = True
        Me.TablesDataExportCheckedListBox.Location = New System.Drawing.Point(140, 61)
        Me.TablesDataExportCheckedListBox.Name = "TablesDataExportCheckedListBox"
        Me.TablesDataExportCheckedListBox.Size = New System.Drawing.Size(373, 220)
        Me.TablesDataExportCheckedListBox.TabIndex = 2
        '
        'ExportButton
        '
        Me.ExportButton.BackColor = System.Drawing.Color.Thistle
        Me.ExportButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(236, 368)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(159, 42)
        Me.ExportButton.TabIndex = 6
        Me.ExportButton.Text = "Start Export"
        Me.ExportButton.UseVisualStyleBackColor = False
        '
        'CSVRadioButton
        '
        Me.CSVRadioButton.AutoSize = True
        Me.CSVRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.CSVRadioButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSVRadioButton.Location = New System.Drawing.Point(260, 331)
        Me.CSVRadioButton.Name = "CSVRadioButton"
        Me.CSVRadioButton.Size = New System.Drawing.Size(66, 24)
        Me.CSVRadioButton.TabIndex = 7
        Me.CSVRadioButton.TabStop = True
        Me.CSVRadioButton.Text = "CSV"
        Me.CSVRadioButton.UseVisualStyleBackColor = False
        '
        'TEXTRadioButton
        '
        Me.TEXTRadioButton.AutoSize = True
        Me.TEXTRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.TEXTRadioButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEXTRadioButton.Location = New System.Drawing.Point(321, 331)
        Me.TEXTRadioButton.Name = "TEXTRadioButton"
        Me.TEXTRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.TEXTRadioButton.TabIndex = 8
        Me.TEXTRadioButton.TabStop = True
        Me.TEXTRadioButton.Text = "TEXT"
        Me.TEXTRadioButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Export as:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Database Table"
        '
        'ExportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 458)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TEXTRadioButton)
        Me.Controls.Add(Me.CSVRadioButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.TablesDataExportCheckedListBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ExportMenu"
        Me.Text = "Export Table Data Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablesDataExportCheckedListBox As CheckedListBox
    Friend WithEvents ExportButton As Button
    Friend WithEvents CSVRadioButton As RadioButton
    Friend WithEvents TEXTRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
