Imports MySql.Data.MySqlClient
Public Class TicketMenu
    Private Sub AddTicketButton_Click(sender As Object, e As EventArgs) Handles AddTicketButton.Click
        UpdateTicketForm.Close()
        DeleteTicketForm.Close()

        AddTicketForm.Show()
        AddTicketForm.Activate()
    End Sub

    Private Sub UpdateTicketButton_Click(sender As Object, e As EventArgs) Handles UpdateTicketButton.Click
        DeleteTicketForm.Close()
        AddTicketForm.Close()

        UpdateTicketForm.Show()
        UpdateTicketForm.Activate()
    End Sub

    Private Sub DeleteTicketButton_Click(sender As Object, e As EventArgs) Handles DeleteTicketButton.Click
        UpdateTicketForm.Close()
        AddTicketForm.Close()

        DeleteTicketForm.Show()
        DeleteTicketForm.Activate()
    End Sub

    Private Sub TicketMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("ticket", TicketDataGridView)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("ticket", TicketDataGridView)
    End Sub

    Private Sub RefreshTicketButton_Click(sender As Object, e As EventArgs) Handles RefreshTicketButton.Click
        Call load_data_to_datagrid("ticket", TicketDataGridView)
    End Sub
End Class