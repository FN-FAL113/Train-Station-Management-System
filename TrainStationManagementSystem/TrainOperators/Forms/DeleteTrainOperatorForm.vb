Public Class DeleteTrainOperatorForm
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Call delete_data_from_db("train_operator", TrainOperatorIdTextBox.Text)
    End Sub
End Class