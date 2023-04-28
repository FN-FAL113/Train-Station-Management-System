Public Class DeleteTrainForm
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim trainID As String = TrainIdTextBox.Text

        Call delete_data_from_db("train", trainID)
    End Sub
End Class