<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTicketForm
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
        Me.TicketDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TicketTrainIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TicketPassengerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TicketFeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TicketIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Plum
        Me.AddButton.Location = New System.Drawing.Point(196, 163)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 48)
        Me.AddButton.TabIndex = 24
        Me.AddButton.Text = "Add Ticket"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'TicketDateTimePicker
        '
        Me.TicketDateTimePicker.Location = New System.Drawing.Point(196, 107)
        Me.TicketDateTimePicker.Name = "TicketDateTimePicker"
        Me.TicketDateTimePicker.Size = New System.Drawing.Size(304, 23)
        Me.TicketDateTimePicker.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(371, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Train ID"
        '
        'TicketTrainIdTextBox
        '
        Me.TicketTrainIdTextBox.Location = New System.Drawing.Point(371, 46)
        Me.TicketTrainIdTextBox.Name = "TicketTrainIdTextBox"
        Me.TicketTrainIdTextBox.Size = New System.Drawing.Size(129, 23)
        Me.TicketTrainIdTextBox.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(196, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Passenger ID"
        '
        'TicketPassengerIdTextBox
        '
        Me.TicketPassengerIdTextBox.Location = New System.Drawing.Point(196, 46)
        Me.TicketPassengerIdTextBox.Name = "TicketPassengerIdTextBox"
        Me.TicketPassengerIdTextBox.Size = New System.Drawing.Size(129, 23)
        Me.TicketPassengerIdTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fee"
        '
        'TicketFeeTextBox
        '
        Me.TicketFeeTextBox.Location = New System.Drawing.Point(31, 108)
        Me.TicketFeeTextBox.Name = "TicketFeeTextBox"
        Me.TicketFeeTextBox.Size = New System.Drawing.Size(129, 23)
        Me.TicketFeeTextBox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'TicketIdTextBox
        '
        Me.TicketIdTextBox.Location = New System.Drawing.Point(31, 46)
        Me.TicketIdTextBox.Name = "TicketIdTextBox"
        Me.TicketIdTextBox.Size = New System.Drawing.Size(129, 23)
        Me.TicketIdTextBox.TabIndex = 14
        '
        'AddTicketForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 234)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TicketDateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TicketTrainIdTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TicketPassengerIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TicketFeeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TicketIdTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddTicketForm"
        Me.Text = "AddTicketForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents TicketDateTimePicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TicketTrainIdTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TicketPassengerIdTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TicketFeeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TicketIdTextBox As TextBox
End Class
