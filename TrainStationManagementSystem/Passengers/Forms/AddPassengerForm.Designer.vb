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
        Me.AddButton.BackColor = System.Drawing.Color.Plum
        Me.AddButton.Location = New System.Drawing.Point(196, 163)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 48)
        Me.AddButton.TabIndex = 24
        Me.AddButton.Text = "Add Passenger"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Gender"
        '
        'PassengerGenderTextBox
        '
        Me.PassengerGenderTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerGenderTextBox.Location = New System.Drawing.Point(91, 111)
        Me.PassengerGenderTextBox.Name = "PassengerGenderTextBox"
        Me.PassengerGenderTextBox.Size = New System.Drawing.Size(158, 25)
        Me.PassengerGenderTextBox.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Name"
        '
        'PassengerNameTextBox
        '
        Me.PassengerNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerNameTextBox.Location = New System.Drawing.Point(296, 47)
        Me.PassengerNameTextBox.Name = "PassengerNameTextBox"
        Me.PassengerNameTextBox.Size = New System.Drawing.Size(167, 25)
        Me.PassengerNameTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Age"
        '
        'PassengerAgeTextBox
        '
        Me.PassengerAgeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerAgeTextBox.Location = New System.Drawing.Point(296, 111)
        Me.PassengerAgeTextBox.Name = "PassengerAgeTextBox"
        Me.PassengerAgeTextBox.Size = New System.Drawing.Size(167, 25)
        Me.PassengerAgeTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'PassengerIdTextBox
        '
        Me.PassengerIdTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerIdTextBox.Location = New System.Drawing.Point(91, 47)
        Me.PassengerIdTextBox.Name = "PassengerIdTextBox"
        Me.PassengerIdTextBox.Size = New System.Drawing.Size(158, 25)
        Me.PassengerIdTextBox.TabIndex = 14
        '
        'AddPassengerForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 234)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PassengerGenderTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PassengerNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassengerAgeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassengerIdTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
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
