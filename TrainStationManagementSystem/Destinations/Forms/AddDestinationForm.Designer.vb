<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDestinationForm
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DestinationFeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DestinationNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DestinationIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Plum
        Me.AddButton.Location = New System.Drawing.Point(142, 231)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 48)
        Me.AddButton.TabIndex = 33
        Me.AddButton.Text = "Add Destination"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(125, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Fee"
        '
        'DestinationFeeTextBox
        '
        Me.DestinationFeeTextBox.Location = New System.Drawing.Point(125, 172)
        Me.DestinationFeeTextBox.Name = "DestinationFeeTextBox"
        Me.DestinationFeeTextBox.Size = New System.Drawing.Size(158, 23)
        Me.DestinationFeeTextBox.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Destination Name"
        '
        'DestinationNameTextBox
        '
        Me.DestinationNameTextBox.Location = New System.Drawing.Point(125, 111)
        Me.DestinationNameTextBox.Name = "DestinationNameTextBox"
        Me.DestinationNameTextBox.Size = New System.Drawing.Size(158, 23)
        Me.DestinationNameTextBox.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ID"
        '
        'DestinationIdTextBox
        '
        Me.DestinationIdTextBox.Location = New System.Drawing.Point(125, 48)
        Me.DestinationIdTextBox.Name = "DestinationIdTextBox"
        Me.DestinationIdTextBox.Size = New System.Drawing.Size(158, 23)
        Me.DestinationIdTextBox.TabIndex = 25
        '
        'AddDestinationForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(425, 324)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DestinationFeeTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DestinationNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestinationIdTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddDestinationForm"
        Me.Text = "AddDestinationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DestinationFeeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DestinationNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DestinationIdTextBox As TextBox
End Class
