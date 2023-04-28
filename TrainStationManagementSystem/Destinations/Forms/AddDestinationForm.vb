Public Class AddDestinationForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ID As String = DestinationIdTextBox.Text
        Dim name As String = wrap_value_sq(DestinationNameTextBox.Text)
        Dim fee As String = wrap_value_sq(DestinationFeeTextBox.Text)

        Dim values As String = "(" + ID + ", " + name + ", " + fee + ");"

        Call add_data_to_db("destination", values, ID)
    End Sub
End Class