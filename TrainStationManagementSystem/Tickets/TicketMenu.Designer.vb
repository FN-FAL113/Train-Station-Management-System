<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketMenu
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
        Me.TicketDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passenger_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.train_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee_with_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddTicketButton = New System.Windows.Forms.Button()
        Me.DeleteTicketButton = New System.Windows.Forms.Button()
        Me.UpdateTicketButton = New System.Windows.Forms.Button()
        Me.RefreshTicketButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets"
        '
        'TicketDataGridView
        '
        Me.TicketDataGridView.AllowUserToAddRows = False
        Me.TicketDataGridView.AllowUserToDeleteRows = False
        Me.TicketDataGridView.AllowUserToOrderColumns = True
        Me.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.passenger_id, Me.train_id, Me.fee_with_tax, Me.date_added})
        Me.TicketDataGridView.Location = New System.Drawing.Point(29, 98)
        Me.TicketDataGridView.Name = "TicketDataGridView"
        Me.TicketDataGridView.ReadOnly = True
        Me.TicketDataGridView.RowHeadersWidth = 51
        Me.TicketDataGridView.RowTemplate.Height = 24
        Me.TicketDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.TicketDataGridView.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'passenger_id
        '
        Me.passenger_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.passenger_id.FillWeight = 283.871!
        Me.passenger_id.HeaderText = "passenger id"
        Me.passenger_id.MinimumWidth = 125
        Me.passenger_id.Name = "passenger_id"
        Me.passenger_id.ReadOnly = True
        '
        'train_id
        '
        Me.train_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.train_id.FillWeight = 7.992467!
        Me.train_id.HeaderText = "train id"
        Me.train_id.MinimumWidth = 125
        Me.train_id.Name = "train_id"
        Me.train_id.ReadOnly = True
        '
        'fee_with_tax
        '
        Me.fee_with_tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fee_with_tax.FillWeight = 25.64791!
        Me.fee_with_tax.HeaderText = "fee with tax"
        Me.fee_with_tax.MinimumWidth = 125
        Me.fee_with_tax.Name = "fee_with_tax"
        Me.fee_with_tax.ReadOnly = True
        '
        'date_added
        '
        Me.date_added.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_added.FillWeight = 7.48865!
        Me.date_added.HeaderText = "date"
        Me.date_added.MinimumWidth = 120
        Me.date_added.Name = "date_added"
        Me.date_added.ReadOnly = True
        '
        'AddTicketButton
        '
        Me.AddTicketButton.BackColor = System.Drawing.Color.Thistle
        Me.AddTicketButton.Location = New System.Drawing.Point(193, 471)
        Me.AddTicketButton.Name = "AddTicketButton"
        Me.AddTicketButton.Size = New System.Drawing.Size(113, 45)
        Me.AddTicketButton.TabIndex = 2
        Me.AddTicketButton.Text = "Add a Ticket"
        Me.AddTicketButton.UseVisualStyleBackColor = False
        '
        'DeleteTicketButton
        '
        Me.DeleteTicketButton.BackColor = System.Drawing.Color.Thistle
        Me.DeleteTicketButton.Location = New System.Drawing.Point(559, 471)
        Me.DeleteTicketButton.Name = "DeleteTicketButton"
        Me.DeleteTicketButton.Size = New System.Drawing.Size(113, 45)
        Me.DeleteTicketButton.TabIndex = 3
        Me.DeleteTicketButton.Text = "Delete a Ticket"
        Me.DeleteTicketButton.UseVisualStyleBackColor = False
        '
        'UpdateTicketButton
        '
        Me.UpdateTicketButton.BackColor = System.Drawing.Color.Thistle
        Me.UpdateTicketButton.Location = New System.Drawing.Point(374, 471)
        Me.UpdateTicketButton.Name = "UpdateTicketButton"
        Me.UpdateTicketButton.Size = New System.Drawing.Size(113, 45)
        Me.UpdateTicketButton.TabIndex = 4
        Me.UpdateTicketButton.Text = "Update a Ticket"
        Me.UpdateTicketButton.UseVisualStyleBackColor = False
        '
        'RefreshTicketButton
        '
        Me.RefreshTicketButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshTicketButton.Location = New System.Drawing.Point(29, 47)
        Me.RefreshTicketButton.Name = "RefreshTicketButton"
        Me.RefreshTicketButton.Size = New System.Drawing.Size(101, 42)
        Me.RefreshTicketButton.TabIndex = 5
        Me.RefreshTicketButton.Text = "Refresh Data"
        Me.RefreshTicketButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrainStationManagementSystem.My.Resources.Resources.black_and_white_blank_ticket_17
        Me.PictureBox1.Location = New System.Drawing.Point(312, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Plum
        Me.PrintButton.Location = New System.Drawing.Point(136, 47)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(101, 42)
        Me.PrintButton.TabIndex = 15
        Me.PrintButton.Text = "Print to Excel"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'TicketMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshTicketButton)
        Me.Controls.Add(Me.UpdateTicketButton)
        Me.Controls.Add(Me.DeleteTicketButton)
        Me.Controls.Add(Me.AddTicketButton)
        Me.Controls.Add(Me.TicketDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TicketMenu"
        Me.Text = "Ticket Menu"
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TicketDataGridView As DataGridView
    Friend WithEvents AddTicketButton As Button
    Friend WithEvents DeleteTicketButton As Button
    Friend WithEvents UpdateTicketButton As Button
    Friend WithEvents RefreshTicketButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents passenger_id As DataGridViewTextBoxColumn
    Friend WithEvents train_id As DataGridViewTextBoxColumn
    Friend WithEvents fee_with_tax As DataGridViewTextBoxColumn
    Friend WithEvents date_added As DataGridViewTextBoxColumn
    Friend WithEvents PrintButton As Button
End Class
