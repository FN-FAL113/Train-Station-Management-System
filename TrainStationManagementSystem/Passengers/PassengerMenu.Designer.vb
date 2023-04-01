<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassengerMenu
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
        Me.PassengerDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passenger_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshPassengerButton = New System.Windows.Forms.Button()
        Me.UpdatePassengerButton = New System.Windows.Forms.Button()
        Me.DeletePassengerButton = New System.Windows.Forms.Button()
        Me.AddPassengerButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PassengerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PassengerDataGridView
        '
        Me.PassengerDataGridView.AllowUserToAddRows = False
        Me.PassengerDataGridView.AllowUserToDeleteRows = False
        Me.PassengerDataGridView.AllowUserToOrderColumns = True
        Me.PassengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PassengerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.passenger_name, Me.gender, Me.age})
        Me.PassengerDataGridView.Location = New System.Drawing.Point(33, 96)
        Me.PassengerDataGridView.Name = "PassengerDataGridView"
        Me.PassengerDataGridView.ReadOnly = True
        Me.PassengerDataGridView.RowHeadersWidth = 51
        Me.PassengerDataGridView.RowTemplate.Height = 24
        Me.PassengerDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.PassengerDataGridView.TabIndex = 8
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'passenger_name
        '
        Me.passenger_name.HeaderText = "name"
        Me.passenger_name.MinimumWidth = 6
        Me.passenger_name.Name = "passenger_name"
        Me.passenger_name.ReadOnly = True
        Me.passenger_name.Width = 245
        '
        'gender
        '
        Me.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gender.HeaderText = "gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'age
        '
        Me.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.age.HeaderText = "age"
        Me.age.MinimumWidth = 6
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Passenger"
        '
        'RefreshPassengerButton
        '
        Me.RefreshPassengerButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshPassengerButton.Location = New System.Drawing.Point(33, 66)
        Me.RefreshPassengerButton.Name = "RefreshPassengerButton"
        Me.RefreshPassengerButton.Size = New System.Drawing.Size(101, 23)
        Me.RefreshPassengerButton.TabIndex = 12
        Me.RefreshPassengerButton.Text = "Refresh Data"
        Me.RefreshPassengerButton.UseVisualStyleBackColor = False
        '
        'UpdatePassengerButton
        '
        Me.UpdatePassengerButton.BackColor = System.Drawing.Color.Thistle
        Me.UpdatePassengerButton.Location = New System.Drawing.Point(389, 466)
        Me.UpdatePassengerButton.Name = "UpdatePassengerButton"
        Me.UpdatePassengerButton.Size = New System.Drawing.Size(113, 45)
        Me.UpdatePassengerButton.TabIndex = 11
        Me.UpdatePassengerButton.Text = "Update Passenger"
        Me.UpdatePassengerButton.UseVisualStyleBackColor = False
        '
        'DeletePassengerButton
        '
        Me.DeletePassengerButton.BackColor = System.Drawing.Color.Thistle
        Me.DeletePassengerButton.Location = New System.Drawing.Point(574, 466)
        Me.DeletePassengerButton.Name = "DeletePassengerButton"
        Me.DeletePassengerButton.Size = New System.Drawing.Size(113, 45)
        Me.DeletePassengerButton.TabIndex = 10
        Me.DeletePassengerButton.Text = "Delete Passenger"
        Me.DeletePassengerButton.UseVisualStyleBackColor = False
        '
        'AddPassengerButton
        '
        Me.AddPassengerButton.BackColor = System.Drawing.Color.Thistle
        Me.AddPassengerButton.Location = New System.Drawing.Point(208, 466)
        Me.AddPassengerButton.Name = "AddPassengerButton"
        Me.AddPassengerButton.Size = New System.Drawing.Size(113, 45)
        Me.AddPassengerButton.TabIndex = 9
        Me.AddPassengerButton.Text = "Add Passenger"
        Me.AddPassengerButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrainStationManagementSystem.My.Resources.Resources.passenger
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(312, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PassengerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.PassengerDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshPassengerButton)
        Me.Controls.Add(Me.UpdatePassengerButton)
        Me.Controls.Add(Me.DeletePassengerButton)
        Me.Controls.Add(Me.AddPassengerButton)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PassengerMenu"
        Me.Text = "Passenger Menu"
        CType(Me.PassengerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PassengerDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RefreshPassengerButton As Button
    Friend WithEvents UpdatePassengerButton As Button
    Friend WithEvents DeletePassengerButton As Button
    Friend WithEvents AddPassengerButton As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents passenger_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
End Class
