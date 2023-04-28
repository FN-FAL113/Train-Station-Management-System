<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableTrainOperatorView
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AvailableTrainOperatorDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_operator_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefreshAvailableTrainOperatorButton = New System.Windows.Forms.Button()
        CType(Me.AvailableTrainOperatorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Available Train Operator"
        '
        'AvailableTrainOperatorDataGridView
        '
        Me.AvailableTrainOperatorDataGridView.AllowUserToAddRows = False
        Me.AvailableTrainOperatorDataGridView.AllowUserToDeleteRows = False
        Me.AvailableTrainOperatorDataGridView.AllowUserToOrderColumns = True
        Me.AvailableTrainOperatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvailableTrainOperatorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.train_operator_name, Me.gender, Me.age, Me.phone_number})
        Me.AvailableTrainOperatorDataGridView.Location = New System.Drawing.Point(42, 87)
        Me.AvailableTrainOperatorDataGridView.Name = "AvailableTrainOperatorDataGridView"
        Me.AvailableTrainOperatorDataGridView.ReadOnly = True
        Me.AvailableTrainOperatorDataGridView.RowHeadersWidth = 51
        Me.AvailableTrainOperatorDataGridView.RowTemplate.Height = 24
        Me.AvailableTrainOperatorDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.AvailableTrainOperatorDataGridView.TabIndex = 17
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
        'RefreshAvailableTrainOperatorButton
        '
        Me.RefreshAvailableTrainOperatorButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshAvailableTrainOperatorButton.Location = New System.Drawing.Point(42, 38)
        Me.RefreshAvailableTrainOperatorButton.Name = "RefreshAvailableTrainOperatorButton"
        Me.RefreshAvailableTrainOperatorButton.Size = New System.Drawing.Size(101, 45)
        Me.RefreshAvailableTrainOperatorButton.TabIndex = 21
        Me.RefreshAvailableTrainOperatorButton.Text = "Refresh Data"
        Me.RefreshAvailableTrainOperatorButton.UseVisualStyleBackColor = False
        '
        'AvailableTrainOperatorView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 509)
        Me.Controls.Add(Me.RefreshAvailableTrainOperatorButton)
        Me.Controls.Add(Me.AvailableTrainOperatorDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "AvailableTrainOperatorView"
        Me.Text = "AvailableTrainOperatorView"
        CType(Me.AvailableTrainOperatorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AvailableTrainOperatorDataGridView As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents train_operator_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents phone_number As DataGridViewTextBoxColumn
    Friend WithEvents RefreshAvailableTrainOperatorButton As Button
End Class
