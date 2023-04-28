Public Class PassengerMenu
    Private Sub AddPassengerButton_Click(sender As Object, e As EventArgs) Handles AddPassengerButton.Click
        UpdatePassengerForm.Close()
        DeletePassengerForm.Close()

        AddPassengerForm.Show()
        AddPassengerForm.Activate()
    End Sub

    Private Sub UpdatePassengerButton_Click(sender As Object, e As EventArgs) Handles UpdatePassengerButton.Click
        AddPassengerForm.Close()
        DeletePassengerForm.Close()

        UpdatePassengerForm.Show()
        UpdatePassengerForm.Activate()
    End Sub

    Private Sub DeletePassengerButton_Click(sender As Object, e As EventArgs) Handles DeletePassengerButton.Click
        UpdatePassengerForm.Close()
        AddPassengerForm.Close()

        DeletePassengerForm.Show()
        DeletePassengerForm.Activate()
    End Sub

    Private Sub PassengerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("passenger", PassengerDataGridView, "")
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("passenger", PassengerDataGridView)
    End Sub

    Private Sub RefreshPassengerButton_Click(sender As Object, e As EventArgs) Handles RefreshPassengerButton.Click
        Call load_data_to_datagrid("passenger", PassengerDataGridView, "")
    End Sub
End Class