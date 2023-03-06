<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteTrainForm
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
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(111, 111)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(126, 51)
        Me.DeleteButton.TabIndex = 33
        Me.DeleteButton.Text = "Delete Train"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Train ID"
        '
        'TrainIdTextBox
        '
        Me.TrainIdTextBox.Location = New System.Drawing.Point(111, 62)
        Me.TrainIdTextBox.Name = "TrainIdTextBox"
        Me.TrainIdTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TrainIdTextBox.TabIndex = 31
        '
        'DeleteTrainForm
        '
        Me.AcceptButton = Me.DeleteButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 204)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrainIdTextBox)
        Me.Name = "DeleteTrainForm"
        Me.Text = "DeleteTrainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TrainIdTextBox As TextBox
End Class
