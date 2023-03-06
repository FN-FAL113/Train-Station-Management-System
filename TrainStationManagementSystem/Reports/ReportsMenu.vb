Public Class ReportsMenu
    Private Sub DestinationFeeButton_Click(sender As Object, e As EventArgs) Handles DestinationFeeButton.Click
        DestinationFeeView.Show()
        DestinationFeeView.Activate()
    End Sub

    Private Sub OngoingTrainsButton_Click(sender As Object, e As EventArgs) Handles OngoingTrainsButton.Click
        OngoingTrainView.Show()
        OngoingTrainView.Activate()
    End Sub

    Private Sub TrainPassengersButton_Click(sender As Object, e As EventArgs) Handles TrainPassengersButton.Click
        TrainPassengerView.Show()
        TrainPassengerView.Activate()
    End Sub
End Class