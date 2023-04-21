Public Class TrainMenu
    Private Sub AddTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles AddTrainOperatorButton.Click
        UpdateTrainForm.Close()
        DeleteTrainForm.Close()

        AddTrainForm.Show()
        AddTrainForm.Activate()
    End Sub

    Private Sub UpdateTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles UpdateTrainOperatorButton.Click
        AddTrainForm.Close()
        DeleteTrainForm.Close()

        UpdateTrainForm.Show()
        UpdateTrainForm.Activate()
    End Sub

    Private Sub DeleteTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles DeleteTrainOperatorButton.Click
        UpdateTrainForm.Close()
        AddTrainForm.Close()

        DeleteTrainForm.Show()
        DeleteTrainForm.Activate()
    End Sub

    Private Sub TrainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("train", TrainDataGridView)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("train", TrainDataGridView)
    End Sub

    Private Sub RefreshTrainButton_Click(sender As Object, e As EventArgs) Handles RefreshTrainButton.Click
        Call load_data_to_datagrid("train", TrainDataGridView)
    End Sub
End Class