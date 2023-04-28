Public Class DeleteDestinationForm
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Call delete_data_from_db("destination", DestinationIdTextBox.Text)
    End Sub
End Class