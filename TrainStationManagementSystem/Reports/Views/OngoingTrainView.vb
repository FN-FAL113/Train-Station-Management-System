Public Class OngoingTrainView
    Private Sub OngoingTrainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("ongoing_train", OngoingTrainDataGridView)
    End Sub
End Class