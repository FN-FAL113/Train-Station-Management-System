Public Class OngoingTrainView
    Private Sub OngoingTrainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("ongoing_train", OngoingTrainDataGridView)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("ongoing_train", OngoingTrainDataGridView)
    End Sub
End Class