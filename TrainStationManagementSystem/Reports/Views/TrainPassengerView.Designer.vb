<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainPassengerView
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
        Me.TrainPassengerDataGridView = New System.Windows.Forms.DataGridView()
        Me.train_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passengers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        CType(Me.TrainPassengerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrainPassengerDataGridView
        '
        Me.TrainPassengerDataGridView.AllowUserToAddRows = False
        Me.TrainPassengerDataGridView.AllowUserToDeleteRows = False
        Me.TrainPassengerDataGridView.AllowUserToOrderColumns = True
        Me.TrainPassengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainPassengerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.train_name, Me.passengers})
        Me.TrainPassengerDataGridView.Location = New System.Drawing.Point(41, 101)
        Me.TrainPassengerDataGridView.Name = "TrainPassengerDataGridView"
        Me.TrainPassengerDataGridView.ReadOnly = True
        Me.TrainPassengerDataGridView.RowHeadersWidth = 51
        Me.TrainPassengerDataGridView.RowTemplate.Height = 24
        Me.TrainPassengerDataGridView.Size = New System.Drawing.Size(481, 291)
        Me.TrainPassengerDataGridView.TabIndex = 5
        '
        'train_name
        '
        Me.train_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_name.HeaderText = "train name"
        Me.train_name.MinimumWidth = 6
        Me.train_name.Name = "train_name"
        Me.train_name.ReadOnly = True
        '
        'passengers
        '
        Me.passengers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.passengers.HeaderText = "passengers"
        Me.passengers.MinimumWidth = 6
        Me.passengers.Name = "passengers"
        Me.passengers.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Train Passengers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Passengers:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.BackColor = System.Drawing.Color.Transparent
        Me.TotalLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(338, 413)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(19, 20)
        Me.TotalLabel.TabIndex = 7
        Me.TotalLabel.Text = "0"
        '
        'TrainPassengerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(546, 454)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrainPassengerDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TrainPassengerView"
        Me.Text = "TrainPassenger"
        CType(Me.TrainPassengerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrainPassengerDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents train_name As DataGridViewTextBoxColumn
    Friend WithEvents passengers As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalLabel As Label
End Class
