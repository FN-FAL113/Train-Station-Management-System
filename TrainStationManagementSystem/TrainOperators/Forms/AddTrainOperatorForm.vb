Public Class AddTrainOperatorForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ID As String = TrainOperatorIdTextBox.Text
        Dim name As String = wrap_value_sq(TrainOperatorNameTextBox.Text)
        Dim gender As String = wrap_value_sq(TrainOperatorGenderTextBox.Text)
        Dim age As String = TrainOperatorAgeTextBox.Text
        Dim mobile As String = TrainOperatorPhoneNumberTextBox.Text

        Dim values As String = "(" + ID + ", " + name + ", " + gender +
           ", " + age + ", " + mobile + ");"

        Call add_data_to_db("train_operator", values, ID)
    End Sub
End Class