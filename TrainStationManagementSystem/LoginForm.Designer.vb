﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Disclaimer = New System.Windows.Forms.Label()
        Me.SignUpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(121, 168)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTextBox.MaxLength = 90
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(152, 21)
        Me.UsernameTextBox.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(146, 140)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(102, 21)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PasswordTextBox.Location = New System.Drawing.Point(121, 235)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.MaxLength = 140
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(152, 21)
        Me.PasswordTextBox.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(148, 208)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(98, 21)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Plum
        Me.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton.FlatAppearance.BorderSize = 0
        Me.LoginButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(154, 273)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(79, 32)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
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
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Train Station Management " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Disclaimer
        '
        Me.Disclaimer.AutoSize = True
        Me.Disclaimer.BackColor = System.Drawing.Color.Transparent
        Me.Disclaimer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disclaimer.Location = New System.Drawing.Point(97, 327)
        Me.Disclaimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Disclaimer.Name = "Disclaimer"
        Me.Disclaimer.Size = New System.Drawing.Size(124, 14)
        Me.Disclaimer.TabIndex = 7
        Me.Disclaimer.Text = "Not Registered Yet?"
        '
        'SignUpLinkLabel
        '
        Me.SignUpLinkLabel.AutoSize = True
        Me.SignUpLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLinkLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpLinkLabel.Location = New System.Drawing.Point(213, 326)
        Me.SignUpLinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SignUpLinkLabel.Name = "SignUpLinkLabel"
        Me.SignUpLinkLabel.Size = New System.Drawing.Size(99, 14)
        Me.SignUpLinkLabel.TabIndex = 8
        Me.SignUpLinkLabel.TabStop = True
        Me.SignUpLinkLabel.Text = "Click to Sign Up"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 439)
        Me.Controls.Add(Me.SignUpLinkLabel)
        Me.Controls.Add(Me.Disclaimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "System Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Disclaimer As Label
    Friend WithEvents SignUpLinkLabel As LinkLabel
End Class
