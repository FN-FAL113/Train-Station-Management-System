<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DestinationFeeView
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
        Me.DestinationFeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee_with_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.DestinationFeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destination Fee"
        '
        'DestinationFeeDataGridView
        '
        Me.DestinationFeeDataGridView.AllowUserToAddRows = False
        Me.DestinationFeeDataGridView.AllowUserToDeleteRows = False
        Me.DestinationFeeDataGridView.AllowUserToOrderColumns = True
        Me.DestinationFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DestinationFeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.location, Me.fee, Me.fee_with_tax})
        Me.DestinationFeeDataGridView.Location = New System.Drawing.Point(42, 87)
        Me.DestinationFeeDataGridView.Name = "DestinationFeeDataGridView"
        Me.DestinationFeeDataGridView.ReadOnly = True
        Me.DestinationFeeDataGridView.RowHeadersWidth = 51
        Me.DestinationFeeDataGridView.RowTemplate.Height = 24
        Me.DestinationFeeDataGridView.Size = New System.Drawing.Size(800, 361)
        Me.DestinationFeeDataGridView.TabIndex = 1
        '
        'location
        '
        Me.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.location.HeaderText = "location"
        Me.location.MinimumWidth = 6
        Me.location.Name = "location"
        Me.location.ReadOnly = True
        '
        'fee
        '
        Me.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fee.HeaderText = "fee"
        Me.fee.MinimumWidth = 6
        Me.fee.Name = "fee"
        Me.fee.ReadOnly = True
        '
        'fee_with_tax
        '
        Me.fee_with_tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fee_with_tax.HeaderText = "fee with tax"
        Me.fee_with_tax.MinimumWidth = 6
        Me.fee_with_tax.Name = "fee_with_tax"
        Me.fee_with_tax.ReadOnly = True
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Plum
        Me.PrintButton.Location = New System.Drawing.Point(42, 41)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(101, 42)
        Me.PrintButton.TabIndex = 23
        Me.PrintButton.Text = "Print to Excel"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'DestinationFeeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 509)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DestinationFeeDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DestinationFeeView"
        Me.Text = "DestinationFee"
        CType(Me.DestinationFeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DestinationFeeDataGridView As DataGridView
    Friend WithEvents location As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
    Friend WithEvents fee_with_tax As DataGridViewTextBoxColumn
    Friend WithEvents PrintButton As Button
End Class
