<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTrainForm
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
        Me.TrainIsOngoingTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrainNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrainDestinationIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrainOperatorIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TrainIsOngoingTextBox
        '
        Me.TrainIsOngoingTextBox.Location = New System.Drawing.Point(196, 115)
        Me.TrainIsOngoingTextBox.Name = "TrainIsOngoingTextBox"
        Me.TrainIsOngoingTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainIsOngoingTextBox.TabIndex = 47
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(196, 174)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(126, 51)
        Me.AddButton.TabIndex = 46
        Me.AddButton.Text = "Add Train"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Train Name"
        '
        'TrainNameTextBox
        '
        Me.TrainNameTextBox.Location = New System.Drawing.Point(371, 49)
        Me.TrainNameTextBox.Name = "TrainNameTextBox"
        Me.TrainNameTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainNameTextBox.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Destination ID"
        '
        'TrainDestinationIdTextBox
        '
        Me.TrainDestinationIdTextBox.Location = New System.Drawing.Point(196, 49)
        Me.TrainDestinationIdTextBox.Name = "TrainDestinationIdTextBox"
        Me.TrainDestinationIdTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainDestinationIdTextBox.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Train Operator ID"
        '
        'TrainOperatorIdTextBox
        '
        Me.TrainOperatorIdTextBox.Location = New System.Drawing.Point(31, 115)
        Me.TrainOperatorIdTextBox.Name = "TrainOperatorIdTextBox"
        Me.TrainOperatorIdTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainOperatorIdTextBox.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Is Ongoing (0 or 1)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ID"
        '
        'TrainIdTextBox
        '
        Me.TrainIdTextBox.Location = New System.Drawing.Point(31, 49)
        Me.TrainIdTextBox.Name = "TrainIdTextBox"
        Me.TrainIdTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainIdTextBox.TabIndex = 37
        '
        'AddTrainForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 250)
        Me.Controls.Add(Me.TrainIsOngoingTextBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrainNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrainDestinationIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrainOperatorIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrainIdTextBox)
        Me.Name = "AddTrainForm"
        Me.Text = "AddTrainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrainIsOngoingTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TrainNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TrainDestinationIdTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TrainOperatorIdTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrainIdTextBox As TextBox
End Class
