<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.RegisterPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.RegisterUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Disclaimer = New System.Windows.Forms.Label()
        Me.LoginLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.Plum
        Me.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterButton.FlatAppearance.BorderSize = 0
        Me.RegisterButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(152, 274)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(79, 32)
        Me.RegisterButton.TabIndex = 13
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(151, 213)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(87, 18)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "Password"
        '
        'RegisterPasswordTextBox
        '
        Me.RegisterPasswordTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterPasswordTextBox.Location = New System.Drawing.Point(115, 236)
        Me.RegisterPasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RegisterPasswordTextBox.MaxLength = 140
        Me.RegisterPasswordTextBox.Multiline = True
        Me.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox"
        Me.RegisterPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPasswordTextBox.Size = New System.Drawing.Size(152, 22)
        Me.RegisterPasswordTextBox.TabIndex = 9
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(148, 144)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(90, 18)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "Username"
        '
        'RegisterUsernameTextBox
        '
        Me.RegisterUsernameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterUsernameTextBox.Location = New System.Drawing.Point(115, 169)
        Me.RegisterUsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RegisterUsernameTextBox.MaxLength = 90
        Me.RegisterUsernameTextBox.Multiline = True
        Me.RegisterUsernameTextBox.Name = "RegisterUsernameTextBox"
        Me.RegisterUsernameTextBox.Size = New System.Drawing.Size(152, 22)
        Me.RegisterUsernameTextBox.TabIndex = 7
        '
        'Disclaimer
        '
        Me.Disclaimer.AutoSize = True
        Me.Disclaimer.BackColor = System.Drawing.Color.Transparent
        Me.Disclaimer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disclaimer.Location = New System.Drawing.Point(91, 328)
        Me.Disclaimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Disclaimer.Name = "Disclaimer"
        Me.Disclaimer.Size = New System.Drawing.Size(128, 14)
        Me.Disclaimer.TabIndex = 14
        Me.Disclaimer.Text = "Already Registered?"
        '
        'LoginLinkLabel
        '
        Me.LoginLinkLabel.AutoSize = True
        Me.LoginLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginLinkLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLinkLabel.Location = New System.Drawing.Point(211, 328)
        Me.LoginLinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LoginLinkLabel.Name = "LoginLinkLabel"
        Me.LoginLinkLabel.Size = New System.Drawing.Size(85, 14)
        Me.LoginLinkLabel.TabIndex = 15
        Me.LoginLinkLabel.TabStop = True
        Me.LoginLinkLabel.Text = "Click to Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 64)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Train Station Management " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RegisterForm
        '
        Me.AcceptButton = Me.RegisterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_Register
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginLinkLabel)
        Me.Controls.Add(Me.Disclaimer)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.RegisterPasswordTextBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.RegisterUsernameTextBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.Text = "System Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents RegisterPasswordTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents RegisterUsernameTextBox As TextBox
    Friend WithEvents Disclaimer As Label
    Friend WithEvents LoginLinkLabel As LinkLabel
    Friend WithEvents Label1 As Label
End Class
