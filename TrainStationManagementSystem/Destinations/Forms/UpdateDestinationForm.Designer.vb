<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDestinationForm
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DestinationFeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DestinationNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DestinationIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(150, 263)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(126, 51)
        Me.UpdateButton.TabIndex = 40
        Me.UpdateButton.Text = "Update Destination"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Fee"
        '
        'DestinationFeeTextBox
        '
        Me.DestinationFeeTextBox.Location = New System.Drawing.Point(133, 187)
        Me.DestinationFeeTextBox.Name = "DestinationFeeTextBox"
        Me.DestinationFeeTextBox.Size = New System.Drawing.Size(158, 22)
        Me.DestinationFeeTextBox.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Destination Name"
        '
        'DestinationNameTextBox
        '
        Me.DestinationNameTextBox.Location = New System.Drawing.Point(133, 122)
        Me.DestinationNameTextBox.Name = "DestinationNameTextBox"
        Me.DestinationNameTextBox.Size = New System.Drawing.Size(158, 22)
        Me.DestinationNameTextBox.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID"
        '
        'DestinationIdTextBox
        '
        Me.DestinationIdTextBox.Location = New System.Drawing.Point(133, 55)
        Me.DestinationIdTextBox.Name = "DestinationIdTextBox"
        Me.DestinationIdTextBox.Size = New System.Drawing.Size(158, 22)
        Me.DestinationIdTextBox.TabIndex = 34
        '
        'UpdateDestinationForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 346)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DestinationFeeTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DestinationNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestinationIdTextBox)
        Me.Name = "UpdateDestinationForm"
        Me.Text = "UpdateDestinationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DestinationFeeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DestinationNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DestinationIdTextBox As TextBox
End Class
