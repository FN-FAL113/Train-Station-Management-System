Imports MySql.Data.MySqlClient
Public Class RegisterForm

    Private Sub LoginLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LoginLinkLabel.LinkClicked
        Me.Close()
        LoginForm.Show()
        LoginForm.Activate()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If (Me.RegisterUsernameTextBox.Text.Length = 0 Or Me.RegisterPasswordTextBox.Text.Length = 0) Then
            MessageBox.Show("Username or Password cannot be empty!")
            Return
        End If

        Call Connect_to_DB()

        Dim mycmd As New MySqlCommand
        Dim strSQL As String = "INSERT INTO system_user (`username`, `password`, `createdAt`) VALUES " _
                & "('" & Me.RegisterUsernameTextBox.Text & "', " _
                & "md5('" & Me.RegisterPasswordTextBox.Text & "'), " _
                & "str_to_date('" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "', '%d/%m/%Y %H:%i:%s'))"

        Try
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully registered! Redirecting to Login")
            Me.Close()
            LoginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Exception encountered while registering: " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Private Sub Disclaimer_Click(sender As Object, e As EventArgs) Handles Disclaimer.Click

    End Sub

    Private Sub RegisterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
        LoginForm.Activate()
    End Sub
End Class