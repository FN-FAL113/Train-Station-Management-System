<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseManagement
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
        Me.components = New System.ComponentModel.Container()
        Me.ExportCSVButton = New System.Windows.Forms.Button()
        Me.ImportCSVButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DumpDatabaseButton = New System.Windows.Forms.Button()
        Me.ImportCSVOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DbManageInfoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DbManageInfoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ImportCSVToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DbManageInfoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportCSVButton
        '
        Me.ExportCSVButton.BackColor = System.Drawing.Color.LightPink
        Me.ExportCSVButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportCSVButton.Location = New System.Drawing.Point(277, 97)
        Me.ExportCSVButton.Name = "ExportCSVButton"
        Me.ExportCSVButton.Size = New System.Drawing.Size(121, 48)
        Me.ExportCSVButton.TabIndex = 8
        Me.ExportCSVButton.Text = "Export As CSV"
        Me.ExportCSVButton.UseVisualStyleBackColor = False
        '
        'ImportCSVButton
        '
        Me.ImportCSVButton.BackColor = System.Drawing.Color.LightPink
        Me.ImportCSVButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportCSVButton.Location = New System.Drawing.Point(121, 97)
        Me.ImportCSVButton.Name = "ImportCSVButton"
        Me.ImportCSVButton.Size = New System.Drawing.Size(120, 48)
        Me.ImportCSVButton.TabIndex = 9
        Me.ImportCSVButton.Text = "Import From CSV"
        Me.ImportCSVButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Data Loading and Conversion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Backup Database"
        '
        'DumpDatabaseButton
        '
        Me.DumpDatabaseButton.BackColor = System.Drawing.Color.LightPink
        Me.DumpDatabaseButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DumpDatabaseButton.Location = New System.Drawing.Point(198, 236)
        Me.DumpDatabaseButton.Name = "DumpDatabaseButton"
        Me.DumpDatabaseButton.Size = New System.Drawing.Size(116, 48)
        Me.DumpDatabaseButton.TabIndex = 12
        Me.DumpDatabaseButton.Text = "Configure Backup"
        Me.DumpDatabaseButton.UseVisualStyleBackColor = False
        '
        'ImportCSVOpenFileDialog
        '
        Me.ImportCSVOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'DbManageInfoToolTip
        '
        Me.DbManageInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.DbManageInfoToolTip.ToolTipTitle = "Warning"
        '
        'DbManageInfoPictureBox
        '
        Me.DbManageInfoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.DbManageInfoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DbManageInfoPictureBox.Image = Global.TrainStationManagementSystem.My.Resources.Resources.Minimalist_info_Icon
        Me.DbManageInfoPictureBox.Location = New System.Drawing.Point(483, 2)
        Me.DbManageInfoPictureBox.Name = "DbManageInfoPictureBox"
        Me.DbManageInfoPictureBox.Size = New System.Drawing.Size(23, 22)
        Me.DbManageInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DbManageInfoPictureBox.TabIndex = 13
        Me.DbManageInfoPictureBox.TabStop = False
        '
        'ImportCSVToolTip
        '
        Me.ImportCSVToolTip.AutoPopDelay = 5000
        Me.ImportCSVToolTip.InitialDelay = 100
        Me.ImportCSVToolTip.ReshowDelay = 100
        '
        'ImportExportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 335)
        Me.Controls.Add(Me.DbManageInfoPictureBox)
        Me.Controls.Add(Me.DumpDatabaseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImportCSVButton)
        Me.Controls.Add(Me.ExportCSVButton)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ImportExportMenu"
        Me.Text = "Database Management"
        CType(Me.DbManageInfoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportCSVButton As Button
    Friend WithEvents ImportCSVButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DumpDatabaseButton As Button
    Friend WithEvents ImportCSVOpenFileDialog As OpenFileDialog
    Friend WithEvents DbManageInfoToolTip As ToolTip
    Friend WithEvents DbManageInfoPictureBox As PictureBox
    Friend WithEvents ImportCSVToolTip As ToolTip
End Class
