Public Class TrainOperatorMenu
    Private Sub AddTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles AddTrainOperatorButton.Click
        UpdateTrainOperatorForm.Close()
        DeleteTrainOperatorForm.Close()

        AddTrainOperatorForm.Show()
        AddTrainOperatorForm.Activate()
    End Sub

    Private Sub UpdateTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles UpdateTrainOperatorButton.Click
        AddTrainOperatorForm.Close()
        DeleteTrainOperatorForm.Close()

        UpdateTrainOperatorForm.Show()
        UpdateTrainOperatorForm.Activate()
    End Sub

    Private Sub DeleteTrainOperatorButton_Click(sender As Object, e As EventArgs) Handles DeleteTrainOperatorButton.Click
        UpdateTrainOperatorForm.Close()
        AddTrainOperatorForm.Close()

        DeleteTrainOperatorForm.Show()
        DeleteTrainOperatorForm.Activate()
    End Sub

    Private Sub TrainOperatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("train_operator", TrainOperatorDataGridView, "")
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("train_operator", TrainOperatorDataGridView)
    End Sub

    Private Sub RefreshTrainOperatorsButton_Click(sender As Object, e As EventArgs) Handles RefreshTrainOperatorsButton.Click
        Call load_data_to_datagrid("train_operator", TrainOperatorDataGridView, "")
    End Sub
End Class