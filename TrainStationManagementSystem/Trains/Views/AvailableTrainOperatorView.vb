Public Class AvailableTrainOperatorView
    Private Sub AvailableTrainOperatorView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid(
                       "train_operator",
                       AvailableTrainOperatorDataGridView,
                       "SELECT * FROM train_operator where id NOT IN (SELECT train_operator_id FROM train);"
                   )
    End Sub

    Private Sub RefreshAvailableTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles RefreshAvailableTrainOperatorButton.Click
        Call load_data_to_datagrid(
                       "train_operator",
                       AvailableTrainOperatorDataGridView,
                       "SELECT * FROM train_operator where id NOT IN (SELECT train_operator_id FROM train);"
                   )
    End Sub
End Class