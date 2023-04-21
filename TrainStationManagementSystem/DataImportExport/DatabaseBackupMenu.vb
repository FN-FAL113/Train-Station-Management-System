Imports MySql.Data.MySqlClient
Public Class DatabaseBackupMenu

    Private Sub DataDumpDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        Dim strSQL As String = "SHOW TABLES;"
        Dim mycmd As New MySqlCommand(strSQL, myconn)
        Dim myreader As MySqlDataReader

        Try
            myreader = mycmd.ExecuteReader()

            ' return if there no database tables
            If Not myreader.HasRows Then
                MessageBox.Show("No database tables yet!")
                Return
            End If

            While myreader.Read()
                ' Add tables and views to check list box
                TablesDbBackupCheckedListBox.Items.Add(myreader.GetString(0))
            End While
        Catch ex As MySqlException
            MessageBox.Show("An error has occured while loading checklist box items: " + ex.Message)
        End Try

        ' Set file location label with default path on form load
        CurrentDbBackupLocationLabel.Text = Environ("USERPROFILE") + "\" + DatabaseBackupFolderBrowserDialog.RootFolder.ToString()

        Call Disconnect_to_DB()
    End Sub

    Private Sub SelectLocationButton_Click(sender As Object, e As EventArgs) Handles SelectDbBackupLocationButton.Click
        Dim folderBrowserResult As DialogResult = DatabaseBackupFolderBrowserDialog.ShowDialog()

        If folderBrowserResult = 1 Then
            ' Update file location label on folder select
            CurrentDbBackupLocationLabel.Text = DatabaseBackupFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub DumpButton_Click(sender As Object, e As EventArgs) Handles DumpButton.Click
        Dim fileLoc As String = IIf(DatabaseBackupFolderBrowserDialog.SelectedPath.Length = 0,
                                Environ("USERPROFILE") + "\" + DatabaseBackupFolderBrowserDialog.RootFolder.ToString(),
                                DatabaseBackupFolderBrowserDialog.SelectedPath)
        Dim fileName As String = IIf(BackupFileNameTextBox.Text.Length = 0,
                                    "TrainStationDbBackup_" + Date.Now.ToString("yy-MM-dd_HH-mm-ss"),
                                    BackupFileNameTextBox.Text)
        Dim backupData As Boolean = BackupDataCheckBox.Checked
        Dim backupStruct As Boolean = BackupStructureCheckBox.Checked

        If Not backupData And Not backupStruct Then
            ' prevent operation if backup options are not ticked
            MessageBox.Show("Please choose whether to backup data/structure")
            Return
        End If

        Dim dataOption As String = IIf(Not backupData, "--no-data", "") ' if data should be backed up
        Dim structOption As String = IIf(Not backupStruct, "--no-create-info", "") ' if table structure should be back up

        Try
            ' Keep events, procedures, functions and events. 
            ' Backup checked items from the checklist box, type casted as string to retrieve table names
            Dim proc As Process = Process.Start("cmd.exe", "/c mysqldump -u root -padmin -P 4306" _
            + " orbeta_fatdb_activity2 " _
            + dataOption + " " + structOption + " --events --routines --triggers " _
            + String.Join(" ", TablesDbBackupCheckedListBox.CheckedItems.Cast(Of String)) _
            + " > " + fileLoc.Replace("\", "/") + "/" + fileName + ".sql")

            ' wait for process to exit for synchronous execution for code below this
            proc.WaitForExit()

            If proc.ExitCode = 0 Then
                MessageBox.Show("Successfully backed up database!")
            Else
                Throw New Exception("An error has occured while backing up database!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles DbBackupInfoPictureBox.Click
        DbBackupInfoToolTip.SetToolTip(
                                DbBackupInfoPictureBox,
                               "1. Proceedures, Functions, Events and Triggers are automatically backed up" _
                                + Environment.NewLine _
                                + "2. If there are no selected tables, clicking start backup will backup all tables"
                              )
    End Sub

    Private Sub BackupStructureCheckBox_MouseEnter(sender As Object, e As EventArgs) Handles BackupStructureCheckBox.MouseEnter
        TableStructureToolTip.SetToolTip(BackupStructureCheckBox, "Always check this box if Database Views are selected")
    End Sub
End Class