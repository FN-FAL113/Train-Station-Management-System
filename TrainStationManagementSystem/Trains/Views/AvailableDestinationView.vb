Public Class AvailableDestinationView

    Private Sub AvailableDestinationView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid(
                       "destination",
                       AvailableDestinationDataGridView,
                       "SELECT * FROM destination where id NOT IN (SELECT destination_id FROM train);"
                   )
    End Sub

    Private Sub RefreshAvailableDestinationButton_Click(sender As Object, e As EventArgs) Handles RefreshAvailableDestinationButton.Click
        Call load_data_to_datagrid(
                      "destination",
                      AvailableDestinationDataGridView,
                      "SELECT * FROM destination where id NOT IN (SELECT destination_id FROM train);"
                  )
    End Sub
End Class