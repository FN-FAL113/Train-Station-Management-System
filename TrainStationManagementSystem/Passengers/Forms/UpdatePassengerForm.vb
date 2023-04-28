Public Class UpdatePassengerForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim ID As String = PassengerIdTextBox.Text
        Dim name As String = wrap_value_sq(PassengerNameTextBox.Text)
        Dim gender As String = wrap_value_sq(PassengerGenderTextBox.Text)
        Dim age As String = PassengerAgeTextBox.Text

        Dim values As String = "name = " + name + ", gender = " + gender +
            ", age = " + age

        Call update_data_from_db("passenger", values, ID)
    End Sub
End Class