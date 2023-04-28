Public Class UpdateTrainOperatorForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim ID As String = TrainOperatorIdTextBox.Text
        Dim name As String = wrap_value_sq(TrainOperatorNameTextBox.Text)
        Dim gender As String = wrap_value_sq(TrainOperatorGenderTextBox.Text)
        Dim age As String = TrainOperatorAgeTextBox.Text
        Dim mobile As String = TrainOperatorPhoneNumberTextBox.Text

        Dim values As String = "name = " + name + ", gender = " + gender +
           ", age = " + age + ", phone_number = " + mobile

        Call update_data_from_db("train_operator", values, ID)
    End Sub
End Class