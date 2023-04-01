<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBackupMenu
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
        Me.DataDumpFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SelectLocationButton = New System.Windows.Forms.Button()
        Me.TablesCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.DumpButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CurrentFileLocationLabel = New System.Windows.Forms.Label()
        Me.BackupDataCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackupStructureCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackupFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.DbBackupInfoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DbBackupInfoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableStructureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DbBackupInfoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectLocationButton
        '
        Me.SelectLocationButton.BackColor = System.Drawing.Color.Thistle
        Me.SelectLocationButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectLocationButton.Location = New System.Drawing.Point(172, 401)
        Me.SelectLocationButton.Name = "SelectLocationButton"
        Me.SelectLocationButton.Size = New System.Drawing.Size(163, 42)
        Me.SelectLocationButton.TabIndex = 0
        Me.SelectLocationButton.Text = "Select Location"
        Me.SelectLocationButton.UseVisualStyleBackColor = False
        '
        'TablesCheckedListBox
        '
        Me.TablesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablesCheckedListBox.CheckOnClick = True
        Me.TablesCheckedListBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablesCheckedListBox.FormattingEnabled = True
        Me.TablesCheckedListBox.Location = New System.Drawing.Point(139, 36)
        Me.TablesCheckedListBox.Name = "TablesCheckedListBox"
        Me.TablesCheckedListBox.Size = New System.Drawing.Size(373, 216)
        Me.TablesCheckedListBox.TabIndex = 1
        '
        'DumpButton
        '
        Me.DumpButton.BackColor = System.Drawing.Color.Thistle
        Me.DumpButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DumpButton.Location = New System.Drawing.Point(341, 401)
        Me.DumpButton.Name = "DumpButton"
        Me.DumpButton.Size = New System.Drawing.Size(159, 42)
        Me.DumpButton.TabIndex = 4
        Me.DumpButton.Text = "Start Backup"
        Me.DumpButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Backup File Location: "
        '
        'CurrentFileLocationLabel
        '
        Me.CurrentFileLocationLabel.AutoSize = True
        Me.CurrentFileLocationLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentFileLocationLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentFileLocationLabel.Location = New System.Drawing.Point(241, 373)
        Me.CurrentFileLocationLabel.Name = "CurrentFileLocationLabel"
        Me.CurrentFileLocationLabel.Size = New System.Drawing.Size(0, 16)
        Me.CurrentFileLocationLabel.TabIndex = 6
        '
        'BackupDataCheckBox
        '
        Me.BackupDataCheckBox.AutoSize = True
        Me.BackupDataCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.BackupDataCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupDataCheckBox.Location = New System.Drawing.Point(185, 274)
        Me.BackupDataCheckBox.Name = "BackupDataCheckBox"
        Me.BackupDataCheckBox.Size = New System.Drawing.Size(113, 20)
        Me.BackupDataCheckBox.TabIndex = 7
        Me.BackupDataCheckBox.Text = "Backup Data"
        Me.BackupDataCheckBox.UseVisualStyleBackColor = False
        '
        'BackupStructureCheckBox
        '
        Me.BackupStructureCheckBox.AutoSize = True
        Me.BackupStructureCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.BackupStructureCheckBox.Checked = True
        Me.BackupStructureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BackupStructureCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupStructureCheckBox.Location = New System.Drawing.Point(313, 274)
        Me.BackupStructureCheckBox.Name = "BackupStructureCheckBox"
        Me.BackupStructureCheckBox.Size = New System.Drawing.Size(187, 20)
        Me.BackupStructureCheckBox.TabIndex = 8
        Me.BackupStructureCheckBox.Text = "Backup Table Structure"
        Me.BackupStructureCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Backup File Name: "
        '
        'BackupFileNameTextBox
        '
        Me.BackupFileNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupFileNameTextBox.Location = New System.Drawing.Point(316, 308)
        Me.BackupFileNameTextBox.Name = "BackupFileNameTextBox"
        Me.BackupFileNameTextBox.Size = New System.Drawing.Size(134, 23)
        Me.BackupFileNameTextBox.TabIndex = 10
        '
        'DbBackupInfoToolTip
        '
        Me.DbBackupInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.DbBackupInfoToolTip.ToolTipTitle = "Additional Info"
        '
        'DbBackupInfoPictureBox
        '
        Me.DbBackupInfoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.DbBackupInfoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DbBackupInfoPictureBox.Image = Global.TrainStationManagementSystem.My.Resources.Resources.Minimalist_info_Icon
        Me.DbBackupInfoPictureBox.Location = New System.Drawing.Point(618, 5)
        Me.DbBackupInfoPictureBox.Name = "DbBackupInfoPictureBox"
        Me.DbBackupInfoPictureBox.Size = New System.Drawing.Size(23, 22)
        Me.DbBackupInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DbBackupInfoPictureBox.TabIndex = 11
        Me.DbBackupInfoPictureBox.TabStop = False
        '
        'DataBackupDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 458)
        Me.Controls.Add(Me.DbBackupInfoPictureBox)
        Me.Controls.Add(Me.BackupFileNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackupStructureCheckBox)
        Me.Controls.Add(Me.BackupDataCheckBox)
        Me.Controls.Add(Me.CurrentFileLocationLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DumpButton)
        Me.Controls.Add(Me.TablesCheckedListBox)
        Me.Controls.Add(Me.SelectLocationButton)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DataBackupDialog"
        Me.Text = "Database Backup"
        CType(Me.DbBackupInfoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataDumpFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents SelectLocationButton As Button
    Friend WithEvents TablesCheckedListBox As CheckedListBox
    Friend WithEvents DumpButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentFileLocationLabel As Label
    Friend WithEvents BackupDataCheckBox As CheckBox
    Friend WithEvents BackupStructureCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackupFileNameTextBox As TextBox
    Friend WithEvents DbBackupInfoToolTip As ToolTip
    Friend WithEvents DbBackupInfoPictureBox As PictureBox
    Friend WithEvents TableStructureToolTip As ToolTip
End Class
