Public Class UpdateTicketForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim ID As String = TicketIdTextBox.Text
        Dim passengerID As String = TicketPassengerIdTextBox.Text
        Dim trainID As String = TicketTrainIdTextBox.Text
        Dim dateTime As String = TicketDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")

        Dim values As String = "passenger_id = " + passengerID + ", train_id = " + trainID +
          ", date = " + wrap_value_sq(dateTime)

        Call update_data_from_db("ticket", values, ID)
    End Sub
End Class