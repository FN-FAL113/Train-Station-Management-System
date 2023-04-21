<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseBackupMenu
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
        Me.DatabaseBackupFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SelectDbBackupLocationButton = New System.Windows.Forms.Button()
        Me.TablesDbBackupCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.DumpButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CurrentDbBackupLocationLabel = New System.Windows.Forms.Label()
        Me.BackupDataCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackupStructureCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackupFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.DbBackupInfoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DbBackupInfoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableStructureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DbBackupInfoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectDbBackupLocationButton
        '
        Me.SelectDbBackupLocationButton.BackColor = System.Drawing.Color.Thistle
        Me.SelectDbBackupLocationButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectDbBackupLocationButton.Location = New System.Drawing.Point(172, 407)
        Me.SelectDbBackupLocationButton.Name = "SelectDbBackupLocationButton"
        Me.SelectDbBackupLocationButton.Size = New System.Drawing.Size(163, 42)
        Me.SelectDbBackupLocationButton.TabIndex = 0
        Me.SelectDbBackupLocationButton.Text = "Select Location"
        Me.SelectDbBackupLocationButton.UseVisualStyleBackColor = False
        '
        'TablesDbBackupCheckedListBox
        '
        Me.TablesDbBackupCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablesDbBackupCheckedListBox.CheckOnClick = True
        Me.TablesDbBackupCheckedListBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablesDbBackupCheckedListBox.FormattingEnabled = True
        Me.TablesDbBackupCheckedListBox.Location = New System.Drawing.Point(139, 54)
        Me.TablesDbBackupCheckedListBox.Name = "TablesDbBackupCheckedListBox"
        Me.TablesDbBackupCheckedListBox.Size = New System.Drawing.Size(373, 198)
        Me.TablesDbBackupCheckedListBox.TabIndex = 1
        '
        'DumpButton
        '
        Me.DumpButton.BackColor = System.Drawing.Color.Thistle
        Me.DumpButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DumpButton.Location = New System.Drawing.Point(341, 407)
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
        Me.Label2.Location = New System.Drawing.Point(182, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Backup File Location: "
        '
        'CurrentDbBackupLocationLabel
        '
        Me.CurrentDbBackupLocationLabel.AutoSize = True
        Me.CurrentDbBackupLocationLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentDbBackupLocationLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDbBackupLocationLabel.Location = New System.Drawing.Point(241, 378)
        Me.CurrentDbBackupLocationLabel.Name = "CurrentDbBackupLocationLabel"
        Me.CurrentDbBackupLocationLabel.Size = New System.Drawing.Size(0, 20)
        Me.CurrentDbBackupLocationLabel.TabIndex = 6
        '
        'BackupDataCheckBox
        '
        Me.BackupDataCheckBox.AutoSize = True
        Me.BackupDataCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.BackupDataCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupDataCheckBox.Location = New System.Drawing.Point(185, 281)
        Me.BackupDataCheckBox.Name = "BackupDataCheckBox"
        Me.BackupDataCheckBox.Size = New System.Drawing.Size(137, 24)
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
        Me.BackupStructureCheckBox.Location = New System.Drawing.Point(313, 281)
        Me.BackupStructureCheckBox.Name = "BackupStructureCheckBox"
        Me.BackupStructureCheckBox.Size = New System.Drawing.Size(226, 24)
        Me.BackupStructureCheckBox.TabIndex = 8
        Me.BackupStructureCheckBox.Text = "Backup Table Structure"
        Me.BackupStructureCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Backup File Name: "
        '
        'BackupFileNameTextBox
        '
        Me.BackupFileNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupFileNameTextBox.Location = New System.Drawing.Point(316, 313)
        Me.BackupFileNameTextBox.Name = "BackupFileNameTextBox"
        Me.BackupFileNameTextBox.Size = New System.Drawing.Size(134, 27)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Select Database Table"
        '
        'DatabaseBackupMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 458)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DbBackupInfoPictureBox)
        Me.Controls.Add(Me.BackupFileNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackupStructureCheckBox)
        Me.Controls.Add(Me.BackupDataCheckBox)
        Me.Controls.Add(Me.CurrentDbBackupLocationLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DumpButton)
        Me.Controls.Add(Me.TablesDbBackupCheckedListBox)
        Me.Controls.Add(Me.SelectDbBackupLocationButton)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DatabaseBackupMenu"
        Me.Text = "Database Backup"
        CType(Me.DbBackupInfoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseBackupFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents SelectDbBackupLocationButton As Button
    Friend WithEvents TablesDbBackupCheckedListBox As CheckedListBox
    Friend WithEvents DumpButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentDbBackupLocationLabel As Label
    Friend WithEvents BackupDataCheckBox As CheckBox
    Friend WithEvents BackupStructureCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackupFileNameTextBox As TextBox
    Friend WithEvents DbBackupInfoToolTip As ToolTip
    Friend WithEvents DbBackupInfoPictureBox As PictureBox
    Friend WithEvents TableStructureToolTip As ToolTip
    Friend WithEvents Label3 As Label
End Class
