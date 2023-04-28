<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableDestinationView
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
        Me.AvailableDestinationDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefreshAvailableDestinationButton = New System.Windows.Forms.Button()
        CType(Me.AvailableDestinationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Available Destination"
        '
        'AvailableDestinationDataGridView
        '
        Me.AvailableDestinationDataGridView.AllowUserToAddRows = False
        Me.AvailableDestinationDataGridView.AllowUserToDeleteRows = False
        Me.AvailableDestinationDataGridView.AllowUserToOrderColumns = True
        Me.AvailableDestinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvailableDestinationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.destination_name, Me.fee})
        Me.AvailableDestinationDataGridView.Location = New System.Drawing.Point(42, 87)
        Me.AvailableDestinationDataGridView.Name = "AvailableDestinationDataGridView"
        Me.AvailableDestinationDataGridView.ReadOnly = True
        Me.AvailableDestinationDataGridView.RowHeadersWidth = 51
        Me.AvailableDestinationDataGridView.RowTemplate.Height = 24
        Me.AvailableDestinationDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.AvailableDestinationDataGridView.TabIndex = 16
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'destination_name
        '
        Me.destination_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.destination_name.HeaderText = "destination name"
        Me.destination_name.MinimumWidth = 6
        Me.destination_name.Name = "destination_name"
        Me.destination_name.ReadOnly = True
        '
        'fee
        '
        Me.fee.HeaderText = "fee"
        Me.fee.MinimumWidth = 6
        Me.fee.Name = "fee"
        Me.fee.ReadOnly = True
        Me.fee.Width = 170
        '
        'RefreshAvailableDestinationButton
        '
        Me.RefreshAvailableDestinationButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshAvailableDestinationButton.Location = New System.Drawing.Point(42, 36)
        Me.RefreshAvailableDestinationButton.Name = "RefreshAvailableDestinationButton"
        Me.RefreshAvailableDestinationButton.Size = New System.Drawing.Size(101, 45)
        Me.RefreshAvailableDestinationButton.TabIndex = 20
        Me.RefreshAvailableDestinationButton.Text = "Refresh Data"
        Me.RefreshAvailableDestinationButton.UseVisualStyleBackColor = False
        '
        'AvailableDestinationView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(895, 513)
        Me.Controls.Add(Me.RefreshAvailableDestinationButton)
        Me.Controls.Add(Me.AvailableDestinationDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AvailableDestinationView"
        Me.Text = "Check Available Destinations"
        CType(Me.AvailableDestinationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AvailableDestinationDataGridView As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents destination_name As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
    Friend WithEvents RefreshAvailableDestinationButton As Button
End Class
