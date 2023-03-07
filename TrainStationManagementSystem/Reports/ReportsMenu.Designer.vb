<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DestinationFeeButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OngoingTrainsButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrainPassengersButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Train Station Reports"
        '
        'DestinationFeeButton
        '
        Me.DestinationFeeButton.BackColor = System.Drawing.Color.Plum
        Me.DestinationFeeButton.Location = New System.Drawing.Point(619, 137)
        Me.DestinationFeeButton.Name = "DestinationFeeButton"
        Me.DestinationFeeButton.Size = New System.Drawing.Size(94, 44)
        Me.DestinationFeeButton.TabIndex = 3
        Me.DestinationFeeButton.Text = "View"
        Me.DestinationFeeButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(561, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Check Destination Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with or without tax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Check Ongoing Trains"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OngoingTrainsButton
        '
        Me.OngoingTrainsButton.BackColor = System.Drawing.Color.Plum
        Me.OngoingTrainsButton.Location = New System.Drawing.Point(619, 284)
        Me.OngoingTrainsButton.Name = "OngoingTrainsButton"
        Me.OngoingTrainsButton.Size = New System.Drawing.Size(94, 44)
        Me.OngoingTrainsButton.TabIndex = 5
        Me.OngoingTrainsButton.Text = "View"
        Me.OngoingTrainsButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(561, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 40)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Check Total Passengers " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Per Train"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TrainPassengersButton
        '
        Me.TrainPassengersButton.BackColor = System.Drawing.Color.Plum
        Me.TrainPassengersButton.Location = New System.Drawing.Point(619, 439)
        Me.TrainPassengersButton.Name = "TrainPassengersButton"
        Me.TrainPassengersButton.Size = New System.Drawing.Size(94, 44)
        Me.TrainPassengersButton.TabIndex = 7
        Me.TrainPassengersButton.Text = "View"
        Me.TrainPassengersButton.UseVisualStyleBackColor = False
        '
        'ReportsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrainStationManagementSystem.My.Resources.Resources.Train_Station_Management_System_reportsmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 540)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrainPassengersButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OngoingTrainsButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DestinationFeeButton)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ReportsMenu"
        Me.Text = "ReportsMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DestinationFeeButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OngoingTrainsButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TrainPassengersButton As Button
End Class
