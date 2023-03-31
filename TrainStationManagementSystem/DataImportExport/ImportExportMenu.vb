Public Class ImportExportMenu
    Private Sub DumpDatabaseButton_Click(sender As Object, e As EventArgs) Handles DumpDatabaseButton.Click
        DataBackupDialog.Show()
        DataBackupDialog.Activate()
    End Sub
End Class