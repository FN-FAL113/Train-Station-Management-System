Public Class AddTrainForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ID As String = TrainIdTextBox.Text
        Dim trainDestinationId As String = TrainDestinationIdTextBox.Text
        Dim trainName As String = TrainNameTextBox.Text
        Dim isOngoing As String = TrainIsOngoingTextBox.Text
        Dim trainOperatorID As String = TrainOperatorIdTextBox.Text

        ' create a partial query based from form data
        Dim values As String = "(" + ID + ", " + trainDestinationId + ", " + wrap_value_sq(trainName) +
            ", " + isOngoing + ", " + trainOperatorID + ");"

        Call add_data_to_db("train", values, ID)
    End Sub
End Class