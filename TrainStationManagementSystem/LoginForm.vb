Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLinkLabel.LinkClicked
        Dim obj As New RegisterForm
        obj.Show()

        Hide()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (Me.UsernameTextBox.Text.Length = 0 Or Me.PasswordTextBox.Text.Length = 0) Then
            MessageBox.Show("Username or Password cannot be empty!")
            Return
        End If

        Call Connect_to_DB()


        Dim strSQL As String = "Select * from system_user where username = " _
            & "@user" & " AND password = md5(@pass)"

        Dim mycmd As New MySqlCommand(strSQL, myconn)
        Try
            mycmd.Parameters.AddWithValue("@user", Me.UsernameTextBox.Text)
            mycmd.Parameters.AddWithValue("@pass", Me.PasswordTextBox.Text)

            If mycmd.ExecuteReader.HasRows Then
                Me.Hide()
                MessageBox.Show("Login Successful!")
                MainMenu.Show()
            Else
                MessageBox.Show("Invalid Credentials! Please try again")
            End If
        Catch ex As MySqlException
            MessageBox.Show("An Error has occured: " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub
End Class