Imports MySql.Data.MySqlClient
Public Class DatabaseManagement
    Private Sub DumpDatabaseButton_Click(sender As Object, e As EventArgs) Handles DumpDatabaseButton.Click
        DatabaseBackupMenu.Show()
        DatabaseBackupMenu.Activate()
    End Sub

    Private Sub ImportCSVButton_Click(sender As Object, e As EventArgs) Handles ImportCSVButton.Click
        Dim fileBrowserResult As DialogResult = ImportCSVOpenFileDialog.ShowDialog()

        ' return if browser dialog is cancelled or closed
        If Not fileBrowserResult = 1 Then
            Return
        End If

        Dim fileExtension As String = IO.Path.GetExtension(ImportCSVOpenFileDialog.FileName)

        ' return if file extension is not csv or txt
        If Not fileExtension.ToLower() = ".csv" And Not fileExtension.ToLower() = ".txt" Then
            MessageBox.Show("Only CSV and TXT files are supported!")
            Return
        End If

        Dim msgBoxResult As DialogResult = MessageBox.Show("Click yes if headers exist else no", "Ignore headers?", MessageBoxButtons.YesNo)
        Dim shouldIgnoreHeader As String = IIf(msgBoxResult = 6, " ignore 1 lines", "")

        Call Connect_to_DB()

        Dim strSQL As String = "LOAD DATA INFILE '" + ImportCSVOpenFileDialog.FileName.Replace("\", "/") + "'" _
                               + " INTO TABLE " + IO.Path.GetFileName(ImportCSVOpenFileDialog.FileName).Replace(fileExtension, "").Split("-")(0) _
                               + " FIELDS TERMINATED BY ',' LINES TERMINATED BY '\r\n'" _
                               + shouldIgnoreHeader _
                               + " SET ID = NULL;"
        Dim mycmd As New MySqlCommand(strSQL, myconn)

        Try
            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully imported raw data to database!")
        Catch ex As Exception
            MessageBox.Show("An error has occured while importing csv data: " + ex.Message +
                            Environment.NewLine + Environment.NewLine +
                            "Please verify filename, must be same of database table name."
                           )
        End Try

        Call Disconnect_to_DB()
    End Sub

    Private Sub ExportCSVButton_Click(sender As Object, e As EventArgs) Handles ExportAsButton.Click
        ExportMenu.Show()
        ExportMenu.Activate()
    End Sub

    Private Sub DbManagementInfoPictureBox_Click(sender As Object, e As EventArgs) Handles DbManageInfoPictureBox.Click
        DbManageInfoToolTip.SetToolTip(DbManageInfoPictureBox,
                                       "CSV files to import must be inside C:\ProgramData\MySQL\MySQL Server <version>\Uploads")
    End Sub

    Private Sub ImportCSVButton_MouseHover(sender As Object, e As EventArgs) Handles ImportCSVButton.MouseHover
        ImportCSVToolTip.SetToolTip(ImportCSVButton, "CSV filename must be same of database table name")
    End Sub
End Class