Public Class AddTicketForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ID As String = TicketIdTextBox.Text
        Dim passengerID As String = TicketPassengerIdTextBox.Text
        Dim trainID As String = TicketTrainIdTextBox.Text
        Dim dateTime As String = TicketDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")

        Dim values As String = "(" + ID + ", " + passengerID + ", " + trainID +
            ", " + "NULL" + ", " + wrap_value_sq(dateTime) + ");"

        Call add_data_to_db("ticket", values, ID)
    End Sub
End Class