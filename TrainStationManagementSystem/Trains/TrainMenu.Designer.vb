<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RefreshTrainButton = New System.Windows.Forms.Button()
        Me.UpdateTrainOperatorButton = New System.Windows.Forms.Button()
        Me.DeleteTrainOperatorButton = New System.Windows.Forms.Button()
        Me.AddTrainOperatorButton = New System.Windows.Forms.Button()
        Me.TrainDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_operator_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrainStationManagementSystem.My.Resources.Resources.trains
        Me.PictureBox1.Location = New System.Drawing.Point(343, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'RefreshTrainButton
        '
        Me.RefreshTrainButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshTrainButton.Location = New System.Drawing.Point(29, 47)
        Me.RefreshTrainButton.Name = "RefreshTrainButton"
        Me.RefreshTrainButton.Size = New System.Drawing.Size(101, 45)
        Me.RefreshTrainButton.TabIndex = 19
        Me.RefreshTrainButton.Text = "Refresh Data"
        Me.RefreshTrainButton.UseVisualStyleBackColor = False
        '
        'UpdateTrainOperatorButton
        '
        Me.UpdateTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.UpdateTrainOperatorButton.Location = New System.Drawing.Point(371, 451)
        Me.UpdateTrainOperatorButton.Name = "UpdateTrainOperatorButton"
        Me.UpdateTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.UpdateTrainOperatorButton.TabIndex = 18
        Me.UpdateTrainOperatorButton.Text = "Update Train"
        Me.UpdateTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'DeleteTrainOperatorButton
        '
        Me.DeleteTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.DeleteTrainOperatorButton.Location = New System.Drawing.Point(556, 451)
        Me.DeleteTrainOperatorButton.Name = "DeleteTrainOperatorButton"
        Me.DeleteTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.DeleteTrainOperatorButton.TabIndex = 17
        Me.DeleteTrainOperatorButton.Text = "Delete Train"
        Me.DeleteTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'AddTrainOperatorButton
        '
        Me.AddTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.AddTrainOperatorButton.Location = New System.Drawing.Point(190, 451)
        Me.AddTrainOperatorButton.Name = "AddTrainOperatorButton"
        Me.AddTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.AddTrainOperatorButton.TabIndex = 16
        Me.AddTrainOperatorButton.Text = "Add Train"
        Me.AddTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'TrainDataGridView
        '
        Me.TrainDataGridView.AllowUserToAddRows = False
        Me.TrainDataGridView.AllowUserToDeleteRows = False
        Me.TrainDataGridView.AllowUserToOrderColumns = True
        Me.TrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.destination_id, Me.train_name, Me.is_ongoing, Me.train_operator_id})
        Me.TrainDataGridView.Location = New System.Drawing.Point(29, 98)
        Me.TrainDataGridView.Name = "TrainDataGridView"
        Me.TrainDataGridView.ReadOnly = True
        Me.TrainDataGridView.RowHeadersWidth = 51
        Me.TrainDataGridView.RowTemplate.Height = 24
        Me.TrainDataGridView.Size = New System.Drawing.Size(811, 324)
        Me.TrainDataGridView.TabIndex = 15
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'destination_id
        '
        Me.destination_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.destination_id.HeaderText = "destination id"
        Me.destination_id.MinimumWidth = 6
        Me.destination_id.Name = "destination_id"
        Me.destination_id.ReadOnly = True
        '
        'train_name
        '
        Me.train_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_name.HeaderText = "train name"
        Me.train_name.MinimumWidth = 6
        Me.train_name.Name = "train_name"
        Me.train_name.ReadOnly = True
        '
        'is_ongoing
        '
        Me.is_ongoing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.is_ongoing.HeaderText = "is ongoing"
        Me.is_ongoing.MinimumWidth = 6
        Me.is_ongoing.Name = "is_ongoing"
        Me.is_ongoing.ReadOnly = True
        '
        'train_operator_id
        '
        Me.train_operator_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_operator_id.HeaderText = "train operator id"
        Me.train_operator_id.MinimumWidth = 6
        Me.train_operator_id.Name = "train_operator_id"
        Me.train_operator_id.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Trains"
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Plum
        Me.PrintButton.Location = New System.Drawing.Point(136, 47)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(101, 45)
        Me.PrintButton.TabIndex = 21
        Me.PrintButton.Text = "Print to Excel"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.Location = New System.Drawing.Point(600, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Available Destination"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Plum
        Me.Button2.Location = New System.Drawing.Point(723, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 45)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Available Train Operator"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TrainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshTrainButton)
        Me.Controls.Add(Me.UpdateTrainOperatorButton)
        Me.Controls.Add(Me.DeleteTrainOperatorButton)
        Me.Controls.Add(Me.AddTrainOperatorButton)
        Me.Controls.Add(Me.TrainDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TrainMenu"
        Me.Text = "Train Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RefreshTrainButton As Button
    Friend WithEvents UpdateTrainOperatorButton As Button
    Friend WithEvents DeleteTrainOperatorButton As Button
    Friend WithEvents AddTrainOperatorButton As Button
    Friend WithEvents TrainDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintButton As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents destination_id As DataGridViewTextBoxColumn
    Friend WithEvents train_name As DataGridViewTextBoxColumn
    Friend WithEvents is_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents train_operator_id As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
