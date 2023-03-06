<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPassengerForm
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
        Me.PassengerGenderTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PassengerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PassengerAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassengerIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(196, 174)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 51)
        Me.AddButton.TabIndex = 24
        Me.AddButton.Text = "Add Passenger"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Gender"
        '
        'PassengerGenderTextBox
        '
        Me.PassengerGenderTextBox.Location = New System.Drawing.Point(91, 109)
        Me.PassengerGenderTextBox.Name = "PassengerGenderTextBox"
        Me.PassengerGenderTextBox.Size = New System.Drawing.Size(158, 22)
        Me.PassengerGenderTextBox.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Name"
        '
        'PassengerNameTextBox
        '
        Me.PassengerNameTextBox.Location = New System.Drawing.Point(296, 40)
        Me.PassengerNameTextBox.Name = "PassengerNameTextBox"
        Me.PassengerNameTextBox.Size = New System.Drawing.Size(167, 22)
        Me.PassengerNameTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Age"
        '
        'PassengerAgeTextBox
        '
        Me.PassengerAgeTextBox.Location = New System.Drawing.Point(296, 109)
        Me.PassengerAgeTextBox.Name = "PassengerAgeTextBox"
        Me.PassengerAgeTextBox.Size = New System.Drawing.Size(167, 22)
        Me.PassengerAgeTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'PassengerIdTextBox
        '
        Me.PassengerIdTextBox.Location = New System.Drawing.Point(91, 40)
        Me.PassengerIdTextBox.Name = "PassengerIdTextBox"
        Me.PassengerIdTextBox.Size = New System.Drawing.Size(158, 22)
        Me.PassengerIdTextBox.TabIndex = 14
        '
        'AddPassengerForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 250)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PassengerGenderTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PassengerNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassengerAgeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassengerIdTextBox)
        Me.Name = "AddPassengerForm"
        Me.Text = "AddPassengerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PassengerGenderTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PassengerNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PassengerAgeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PassengerIdTextBox As TextBox
End Class
