Public Class AddPassengerForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ID As String = PassengerIdTextBox.Text
        Dim name As String = wrap_value_sq(PassengerNameTextBox.Text)
        Dim gender As String = wrap_value_sq(PassengerGenderTextBox.Text)
        Dim age As String = PassengerAgeTextBox.Text

        Dim values As String = "(" + ID + ", " + name + ", " + gender +
            ", " + age + ");"

        Call add_data_to_db("passenger", values, ID)
    End Sub
End Class