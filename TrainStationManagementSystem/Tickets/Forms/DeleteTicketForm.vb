Public Class DeleteTicketForm
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Call delete_data_from_db("ticket", TicketIdTextBox.Text)
    End Sub
End Class