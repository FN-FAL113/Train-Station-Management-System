<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTrainOperatorForm
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
        Me.TrainOperatorGenderTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrainOperatorNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrainOperatorAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainOperatorIdTextBox = New System.Windows.Forms.TextBox()
        Me.TrainOperatorPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Plum
        Me.AddButton.Location = New System.Drawing.Point(196, 163)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 48)
        Me.AddButton.TabIndex = 35
        Me.AddButton.Text = "Add Train Operator"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Gender"
        '
        'TrainOperatorGenderTextBox
        '
        Me.TrainOperatorGenderTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainOperatorGenderTextBox.Location = New System.Drawing.Point(371, 46)
        Me.TrainOperatorGenderTextBox.Name = "TrainOperatorGenderTextBox"
        Me.TrainOperatorGenderTextBox.Size = New System.Drawing.Size(122, 25)
        Me.TrainOperatorGenderTextBox.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Name"
        '
        'TrainOperatorNameTextBox
        '
        Me.TrainOperatorNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainOperatorNameTextBox.Location = New System.Drawing.Point(196, 46)
        Me.TrainOperatorNameTextBox.Name = "TrainOperatorNameTextBox"
        Me.TrainOperatorNameTextBox.Size = New System.Drawing.Size(149, 25)
        Me.TrainOperatorNameTextBox.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Age"
        '
        'TrainOperatorAgeTextBox
        '
        Me.TrainOperatorAgeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainOperatorAgeTextBox.Location = New System.Drawing.Point(31, 108)
        Me.TrainOperatorAgeTextBox.Name = "TrainOperatorAgeTextBox"
        Me.TrainOperatorAgeTextBox.Size = New System.Drawing.Size(129, 25)
        Me.TrainOperatorAgeTextBox.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Phone Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ID"
        '
        'TrainOperatorIdTextBox
        '
        Me.TrainOperatorIdTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainOperatorIdTextBox.Location = New System.Drawing.Point(31, 46)
        Me.TrainOperatorIdTextBox.Name = "TrainOperatorIdTextBox"
        Me.TrainOperatorIdTextBox.Size = New System.Drawing.Size(129, 25)
        Me.TrainOperatorIdTextBox.TabIndex = 25
        '
        'TrainOperatorPhoneNumberTextBox
        '
        Me.TrainOperatorPhoneNumberTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainOperatorPhoneNumberTextBox.Location = New System.Drawing.Point(196, 108)
        Me.TrainOperatorPhoneNumberTextBox.Name = "TrainOperatorPhoneNumberTextBox"
        Me.TrainOperatorPhoneNumberTextBox.Size = New System.Drawing.Size(149, 25)
        Me.TrainOperatorPhoneNumberTextBox.TabIndex = 36
        '
        'AddTrainOperatorForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 234)
        Me.Controls.Add(Me.TrainOperatorPhoneNumberTextBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrainOperatorGenderTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrainOperatorNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrainOperatorAgeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrainOperatorIdTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddTrainOperatorForm"
        Me.Text = "AddTrainOperator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TrainOperatorGenderTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TrainOperatorNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TrainOperatorAgeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrainOperatorIdTextBox As TextBox
    Friend WithEvents TrainOperatorPhoneNumberTextBox As TextBox
End Class
