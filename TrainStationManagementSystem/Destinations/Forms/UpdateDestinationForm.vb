Public Class UpdateDestinationForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim ID As String = DestinationIdTextBox.Text
        Dim name As String = wrap_value_sq(DestinationNameTextBox.Text)
        Dim fee As String = wrap_value_sq(DestinationFeeTextBox.Text)

        Dim values As String = "name = " + name + ", fee = " + fee

        Call update_data_from_db("destination", values, ID)
    End Sub
End Class