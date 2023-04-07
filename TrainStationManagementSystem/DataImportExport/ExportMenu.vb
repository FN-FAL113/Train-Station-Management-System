Imports MySql.Data.MySqlClient
Public Class ExportMenu
    Private Sub ExportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        Dim strSql As String = "SHOW TABLES;"
        Dim mycmd As New MySqlCommand(strSql, myconn)
        Dim myreader As MySqlDataReader


        Try
            myreader = mycmd.ExecuteReader()

            If Not myreader.HasRows() Then
                MessageBox.Show("No Database tables yet!")
                Return
            End If

            While myreader.Read()
                TablesDataExportCheckedListBox.Items.Add(myreader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("An error has occured while loading checklist box items: " + ex.Message)
        End Try


        Call Disconnect_to_DB()
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        If Not CSVRadioButton.Checked And Not TEXTRadioButton.Checked Then
            MessageBox.Show("Please select from export as file type")
            Return
        End If

        If TablesDataExportCheckedListBox.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select a table from the list to backup")
            Return
        End If

        Call Connect_to_DB()

        Dim mycmd As New MySqlCommand("", myconn)
        Dim fileType As String = IIf(CSVRadioButton.Checked, ".csv", ".txt")

        Try
            Dim secureUploadLoc As String = getSecureFilePrivFolder() ' get mysql secure folder

            For Each table As String In TablesDataExportCheckedListBox.CheckedItems
                mycmd.CommandText = "SELECT * FROM " + table + " INTO OUTFILE " _
                                    + "'" + secureUploadLoc + table + fileType + "' " _
                                    + "FIELDS TERMINATED BY ',' LINES TERMINATED BY '\r\n';"
                mycmd.ExecuteReader().Close() ' close this reader for reusability
            Next

            MessageBox.Show("Successfully exported data!")
            Process.Start(secureUploadLoc) ' open mysql secure folder
        Catch ex As Exception
            MessageBox.Show("An error has occured while exporting data as csv: " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Public Function getSecureFilePrivFolder() As String
        Dim mycmd As New MySqlCommand("", myconn)
        mycmd.CommandText = "SELECT @@GLOBAL.secure_file_priv;"

        Return mycmd.ExecuteScalar.ToString().Replace("\", "/")
    End Function
End Class