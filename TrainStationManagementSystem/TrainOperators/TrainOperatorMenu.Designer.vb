<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainOperatorMenu
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
        Me.RefreshTrainOperatorsButton = New System.Windows.Forms.Button()
        Me.UpdateTrainOperatorButton = New System.Windows.Forms.Button()
        Me.DeleteTrainOperatorButton = New System.Windows.Forms.Button()
        Me.AddTrainOperatorButton = New System.Windows.Forms.Button()
        Me.TrainOperatorDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_operator_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainOperatorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrainStationManagementSystem.My.Resources.Resources.train_operator
        Me.PictureBox1.Location = New System.Drawing.Point(301, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'RefreshTrainOperatorsButton
        '
        Me.RefreshTrainOperatorsButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshTrainOperatorsButton.Location = New System.Drawing.Point(29, 69)
        Me.RefreshTrainOperatorsButton.Name = "RefreshTrainOperatorsButton"
        Me.RefreshTrainOperatorsButton.Size = New System.Drawing.Size(101, 23)
        Me.RefreshTrainOperatorsButton.TabIndex = 12
        Me.RefreshTrainOperatorsButton.Text = "Refresh Data"
        Me.RefreshTrainOperatorsButton.UseVisualStyleBackColor = False
        '
        'UpdateTrainOperatorButton
        '
        Me.UpdateTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.UpdateTrainOperatorButton.Location = New System.Drawing.Point(379, 460)
        Me.UpdateTrainOperatorButton.Name = "UpdateTrainOperatorButton"
        Me.UpdateTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.UpdateTrainOperatorButton.TabIndex = 11
        Me.UpdateTrainOperatorButton.Text = "Update Train Operator"
        Me.UpdateTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'DeleteTrainOperatorButton
        '
        Me.DeleteTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.DeleteTrainOperatorButton.Location = New System.Drawing.Point(564, 460)
        Me.DeleteTrainOperatorButton.Name = "DeleteTrainOperatorButton"
        Me.DeleteTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.DeleteTrainOperatorButton.TabIndex = 10
        Me.DeleteTrainOperatorButton.Text = "Delete Train Operator"
        Me.DeleteTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'AddTrainOperatorButton
        '
        Me.AddTrainOperatorButton.BackColor = System.Drawing.Color.Thistle
        Me.AddTrainOperatorButton.Location = New System.Drawing.Point(198, 460)
        Me.AddTrainOperatorButton.Name = "AddTrainOperatorButton"
        Me.AddTrainOperatorButton.Size = New System.Drawing.Size(113, 45)
        Me.AddTrainOperatorButton.TabIndex = 9
        Me.AddTrainOperatorButton.Text = "Add Train Operator"
        Me.AddTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'TrainOperatorDataGridView
        '
        Me.TrainOperatorDataGridView.AllowUserToAddRows = False
        Me.TrainOperatorDataGridView.AllowUserToDeleteRows = False
        Me.TrainOperatorDataGridView.AllowUserToOrderColumns = True
        Me.TrainOperatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainOperatorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.train_operator_name, Me.gender, Me.age, Me.phone_number})
        Me.TrainOperatorDataGridView.Location = New System.Drawing.Point(29, 98)
        Me.TrainOperatorDataGridView.Name = "TrainOperatorDataGridView"
        Me.TrainOperatorDataGridView.ReadOnly = True
        Me.TrainOperatorDataGridView.RowHeadersWidth = 51
        Me.TrainOperatorDataGridView.RowTemplate.Height = 24
        Me.TrainOperatorDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.TrainOperatorDataGridView.TabIndex = 8
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'train_operator_name
        '
        Me.train_operator_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_operator_name.HeaderText = "train operator name"
        Me.train_operator_name.MinimumWidth = 6
        Me.train_operator_name.Name = "train_operator_name"
        Me.train_operator_name.ReadOnly = True
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
        'phone_number
        '
        Me.phone_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phone_number.HeaderText = "phone number"
        Me.phone_number.MinimumWidth = 6
        Me.phone_number.Name = "phone_number"
        Me.phone_number.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Train Operators"
        '
        'TrainOperatorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshTrainOperatorsButton)
        Me.Controls.Add(Me.UpdateTrainOperatorButton)
        Me.Controls.Add(Me.DeleteTrainOperatorButton)
        Me.Controls.Add(Me.AddTrainOperatorButton)
        Me.Controls.Add(Me.TrainOperatorDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TrainOperatorMenu"
        Me.Text = "TrainOperatorMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainOperatorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RefreshTrainOperatorsButton As Button
    Friend WithEvents UpdateTrainOperatorButton As Button
    Friend WithEvents DeleteTrainOperatorButton As Button
    Friend WithEvents AddTrainOperatorButton As Button
    Friend WithEvents TrainOperatorDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents train_operator_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents phone_number As DataGridViewTextBoxColumn
End Class
