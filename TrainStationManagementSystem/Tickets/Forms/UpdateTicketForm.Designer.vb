<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTicketForm
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
        Me.TicketIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TicketPassengerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TicketTrainIdTextBox = New System.Windows.Forms.TextBox()
        Me.TicketDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TicketIdTextBox
        '
        Me.TicketIdTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketIdTextBox.Location = New System.Drawing.Point(27, 47)
        Me.TicketIdTextBox.Name = "TicketIdTextBox"
        Me.TicketIdTextBox.Size = New System.Drawing.Size(129, 25)
        Me.TicketIdTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Passenger ID"
        '
        'TicketPassengerIdTextBox
        '
        Me.TicketPassengerIdTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketPassengerIdTextBox.Location = New System.Drawing.Point(192, 47)
        Me.TicketPassengerIdTextBox.Name = "TicketPassengerIdTextBox"
        Me.TicketPassengerIdTextBox.Size = New System.Drawing.Size(129, 25)
        Me.TicketPassengerIdTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(366, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Train ID"
        '
        'TicketTrainIdTextBox
        '
        Me.TicketTrainIdTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketTrainIdTextBox.Location = New System.Drawing.Point(367, 47)
        Me.TicketTrainIdTextBox.Name = "TicketTrainIdTextBox"
        Me.TicketTrainIdTextBox.Size = New System.Drawing.Size(129, 25)
        Me.TicketTrainIdTextBox.TabIndex = 10
        '
        'TicketDateTimePicker
        '
        Me.TicketDateTimePicker.Location = New System.Drawing.Point(27, 108)
        Me.TicketDateTimePicker.Name = "TicketDateTimePicker"
        Me.TicketDateTimePicker.Size = New System.Drawing.Size(304, 23)
        Me.TicketDateTimePicker.TabIndex = 12
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Plum
        Me.UpdateButton.Location = New System.Drawing.Point(192, 164)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(126, 48)
        Me.UpdateButton.TabIndex = 13
        Me.UpdateButton.Text = "Update Ticket"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'UpdateTicketForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_genericmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 234)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.TicketDateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TicketTrainIdTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TicketPassengerIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TicketIdTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UpdateTicketForm"
        Me.Text = "UpdateTicketForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TicketIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TicketPassengerIdTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TicketTrainIdTextBox As TextBox
    Friend WithEvents TicketDateTimePicker As DateTimePicker
    Friend WithEvents UpdateButton As Button
End Class
