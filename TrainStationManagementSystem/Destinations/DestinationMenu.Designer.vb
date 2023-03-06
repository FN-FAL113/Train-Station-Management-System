<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DestinationMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DestinationMenu))
        Me.DestinationDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RefreshDestinationButton = New System.Windows.Forms.Button()
        Me.UpdateDestinationButton = New System.Windows.Forms.Button()
        Me.DeleteDestinationButton = New System.Windows.Forms.Button()
        Me.AddDestinationButton = New System.Windows.Forms.Button()
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationDataGridView
        '
        Me.DestinationDataGridView.AllowUserToAddRows = False
        Me.DestinationDataGridView.AllowUserToDeleteRows = False
        Me.DestinationDataGridView.AllowUserToOrderColumns = True
        Me.DestinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DestinationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.destination_name, Me.fee})
        Me.DestinationDataGridView.Location = New System.Drawing.Point(33, 96)
        Me.DestinationDataGridView.Name = "DestinationDataGridView"
        Me.DestinationDataGridView.ReadOnly = True
        Me.DestinationDataGridView.RowHeadersWidth = 51
        Me.DestinationDataGridView.RowTemplate.Height = 24
        Me.DestinationDataGridView.Size = New System.Drawing.Size(811, 339)
        Me.DestinationDataGridView.TabIndex = 15
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Destinations"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(330, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'RefreshDestinationButton
        '
        Me.RefreshDestinationButton.BackColor = System.Drawing.Color.Plum
        Me.RefreshDestinationButton.Location = New System.Drawing.Point(33, 67)
        Me.RefreshDestinationButton.Name = "RefreshDestinationButton"
        Me.RefreshDestinationButton.Size = New System.Drawing.Size(101, 23)
        Me.RefreshDestinationButton.TabIndex = 19
        Me.RefreshDestinationButton.Text = "Refresh Data"
        Me.RefreshDestinationButton.UseVisualStyleBackColor = False
        '
        'UpdateDestinationButton
        '
        Me.UpdateDestinationButton.BackColor = System.Drawing.Color.Thistle
        Me.UpdateDestinationButton.Location = New System.Drawing.Point(382, 466)
        Me.UpdateDestinationButton.Name = "UpdateDestinationButton"
        Me.UpdateDestinationButton.Size = New System.Drawing.Size(113, 45)
        Me.UpdateDestinationButton.TabIndex = 18
        Me.UpdateDestinationButton.Text = "Update Destination"
        Me.UpdateDestinationButton.UseVisualStyleBackColor = False
        '
        'DeleteDestinationButton
        '
        Me.DeleteDestinationButton.BackColor = System.Drawing.Color.Thistle
        Me.DeleteDestinationButton.Location = New System.Drawing.Point(567, 466)
        Me.DeleteDestinationButton.Name = "DeleteDestinationButton"
        Me.DeleteDestinationButton.Size = New System.Drawing.Size(113, 45)
        Me.DeleteDestinationButton.TabIndex = 17
        Me.DeleteDestinationButton.Text = "Delete Destination"
        Me.DeleteDestinationButton.UseVisualStyleBackColor = False
        '
        'AddDestinationButton
        '
        Me.AddDestinationButton.BackColor = System.Drawing.Color.Thistle
        Me.AddDestinationButton.Location = New System.Drawing.Point(201, 466)
        Me.AddDestinationButton.Name = "AddDestinationButton"
        Me.AddDestinationButton.Size = New System.Drawing.Size(113, 45)
        Me.AddDestinationButton.TabIndex = 16
        Me.AddDestinationButton.Text = "Add Destination"
        Me.AddDestinationButton.UseVisualStyleBackColor = False
        '
        'DestinationMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.DestinationDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshDestinationButton)
        Me.Controls.Add(Me.UpdateDestinationButton)
        Me.Controls.Add(Me.DeleteDestinationButton)
        Me.Controls.Add(Me.AddDestinationButton)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DestinationMenu"
        Me.Text = "DestinationMenu"
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DestinationDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RefreshDestinationButton As Button
    Friend WithEvents UpdateDestinationButton As Button
    Friend WithEvents DeleteDestinationButton As Button
    Friend WithEvents AddDestinationButton As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents destination_name As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
End Class
