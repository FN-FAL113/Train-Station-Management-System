<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OngoingTrainView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OngoingTrainView))
        Me.OngoingTrainDataGridView = New System.Windows.Forms.DataGridView()
        Me.train_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_operator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.OngoingTrainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OngoingTrainDataGridView
        '
        Me.OngoingTrainDataGridView.AllowUserToAddRows = False
        Me.OngoingTrainDataGridView.AllowUserToDeleteRows = False
        Me.OngoingTrainDataGridView.AllowUserToOrderColumns = True
        Me.OngoingTrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OngoingTrainDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.train_id, Me.train_name, Me.destination_name, Me.train_operator})
        Me.OngoingTrainDataGridView.Location = New System.Drawing.Point(42, 87)
        Me.OngoingTrainDataGridView.Name = "OngoingTrainDataGridView"
        Me.OngoingTrainDataGridView.ReadOnly = True
        Me.OngoingTrainDataGridView.RowHeadersWidth = 51
        Me.OngoingTrainDataGridView.RowTemplate.Height = 24
        Me.OngoingTrainDataGridView.Size = New System.Drawing.Size(800, 365)
        Me.OngoingTrainDataGridView.TabIndex = 3
        '
        'train_id
        '
        Me.train_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_id.HeaderText = "train id"
        Me.train_id.MinimumWidth = 6
        Me.train_id.Name = "train_id"
        Me.train_id.ReadOnly = True
        '
        'train_name
        '
        Me.train_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_name.HeaderText = "train name"
        Me.train_name.MinimumWidth = 6
        Me.train_name.Name = "train_name"
        Me.train_name.ReadOnly = True
        '
        'destination_name
        '
        Me.destination_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.destination_name.HeaderText = "destination name"
        Me.destination_name.MinimumWidth = 6
        Me.destination_name.Name = "destination_name"
        Me.destination_name.ReadOnly = True
        '
        'train_operator
        '
        Me.train_operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_operator.HeaderText = "train operator"
        Me.train_operator.MinimumWidth = 6
        Me.train_operator.Name = "train_operator"
        Me.train_operator.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ongoing Trains"
        '
        'OngoingTrainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 509)
        Me.Controls.Add(Me.OngoingTrainDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "OngoingTrainView"
        Me.Text = "OngoingTrain"
        CType(Me.OngoingTrainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OngoingTrainDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents train_id As DataGridViewTextBoxColumn
    Friend WithEvents train_name As DataGridViewTextBoxColumn
    Friend WithEvents destination_name As DataGridViewTextBoxColumn
    Friend WithEvents train_operator As DataGridViewTextBoxColumn
End Class
