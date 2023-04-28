Public Class DeletePassengerForm
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Call delete_data_from_db("passenger", PassengerIdTextBox.Text)
    End Sub
End Class