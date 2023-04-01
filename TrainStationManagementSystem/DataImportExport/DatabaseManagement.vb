Imports MySql.Data.MySqlClient
Public Class DatabaseManagement
    Private Sub DumpDatabaseButton_Click(sender As Object, e As EventArgs) Handles DumpDatabaseButton.Click
        DataBackupMenu.Show()
        DataBackupMenu.Activate()
    End Sub

    Private Sub ImportCSVButton_Click(sender As Object, e As EventArgs) Handles ImportCSVButton.Click
        Dim result As DialogResult = ImportCSVOpenFileDialog.ShowDialog()

        If Not result = 1 Then
            Return
        End If

        Call Connect_to_DB()

        Dim strSQL As String = "LOAD DATA INFILE '" + ImportCSVOpenFileDialog.FileName.Replace("\", "/") + "'" _
                               + " INTO TABLE " + IO.Path.GetFileName(ImportCSVOpenFileDialog.FileName).Replace(".csv", "") _
                               + " FIELDS TERMINATED BY ',' LINES TERMINATED BY '\r\n'" _
                               + " ignore 1 lines" _
                               + " SET ID = NULL;"
        Dim mycmd As New MySqlCommand(strSQL, myconn)

        Try
            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully imported csv data to database!")
        Catch ex As Exception
            MessageBox.Show("An error has occured while importing csv data: " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Private Sub ExportCSVButton_Click(sender As Object, e As EventArgs) Handles ExportCSVButton.Click

    End Sub

    Private Sub DbManagementInfoPictureBox_Click(sender As Object, e As EventArgs) Handles DbManageInfoPictureBox.Click
        DbManageInfoToolTip.SetToolTip(DbManageInfoPictureBox,
                                       "CSV files to import must be inside C:\ProgramData\MySQL\MySQL Server <version>\Uploads")
    End Sub

    Private Sub ImportCSVButton_MouseHover(sender As Object, e As EventArgs) Handles ImportCSVButton.MouseHover
        ImportCSVToolTip.SetToolTip(ImportCSVButton, "CSV filename must be same of database table name")
    End Sub
End Class