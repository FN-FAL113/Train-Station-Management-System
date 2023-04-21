Public Class DestinationMenu
    Private Sub AddDestinationButton_Click(sender As Object, e As EventArgs) Handles AddDestinationButton.Click
        UpdateDestinationForm.Close()
        DeleteDestinationForm.Close()

        AddDestinationForm.Show()
        AddDestinationForm.Activate()
    End Sub

    Private Sub UpdateDestinationButton_Click(sender As Object, e As EventArgs) Handles UpdateDestinationButton.Click
        AddDestinationForm.Close()
        DeleteDestinationForm.Close()

        UpdateDestinationForm.Show()
        UpdateDestinationForm.Activate()
    End Sub

    Private Sub DeleteDestinationButton_Click(sender As Object, e As EventArgs) Handles DeleteDestinationButton.Click
        UpdateDestinationForm.Close()
        AddDestinationForm.Close()

        DeleteDestinationForm.Show()
        DeleteDestinationForm.Activate()
    End Sub

    Private Sub DestinationMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("destination", DestinationDataGridView)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("destination", DestinationDataGridView)
    End Sub

    Private Sub RefreshDestinationButton_Click(sender As Object, e As EventArgs) Handles RefreshDestinationButton.Click
        Call load_data_to_datagrid("destination", DestinationDataGridView)
    End Sub
End Class