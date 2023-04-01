

Public Class MainMenu
    Private Sub ManageTicketButton_Click(sender As Object, e As EventArgs) Handles ManageTicketButton.Click
        TicketMenu.Show()
        TicketMenu.Activate()
    End Sub

    Private Sub ManagePassengersButton_Click(sender As Object, e As EventArgs) Handles ManagePassengersButton.Click
        PassengerMenu.Show()
        PassengerMenu.Activate()
    End Sub

    Private Sub ManageTrainOperatorsButton_Click(sender As Object, e As EventArgs) Handles ManageTrainOperatorsButton.Click
        TrainOperatorMenu.Show()
        TrainOperatorMenu.Activate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TrainMenu.Show()
        TrainMenu.Activate()
    End Sub

    Private Sub ManageDestinationsButton_Click(sender As Object, e As EventArgs) Handles ManageDestinationsButton.Click
        DestinationMenu.Show()
        DestinationMenu.Activate()
    End Sub

    Private Sub ShowReportsButton_Click(sender As Object, e As EventArgs) Handles ShowReportsButton.Click
        ReportsMenu.Show()
        ReportsMenu.Activate()
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Close()
    End Sub

    Private Sub ShowImportExportButton_Click(sender As Object, e As EventArgs) Handles ShowImportExportButton.Click
        DatabaseManagement.Show()
        DatabaseManagement.Activate()
    End Sub
End Class
