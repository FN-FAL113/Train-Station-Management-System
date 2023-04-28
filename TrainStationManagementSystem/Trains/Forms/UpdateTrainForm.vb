Public Class UpdateTrainForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim ID As String = TrainIdTextBox.Text
        Dim trainDestinationId As String = TrainDestinationIdTextBox.Text
        Dim trainName As String = TrainNameTextBox.Text
        Dim isOngoing As String = TrainIsOngoingTextBox.Text
        Dim trainOperatorID As String = TrainOperatorIdTextBox.Text

        ' create a partial query based from form data
        Dim values As String = "destination_id = " + trainDestinationId + ", train_name = " + wrap_value_sq(trainName) +
            ", is_ongoing = " + isOngoing + ", train_operator_id = " + trainOperatorID

        Call update_data_from_db("train", values, ID)
    End Sub
End Class