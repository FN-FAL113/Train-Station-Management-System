Imports MySql.Data.MySqlClient
Module DBUtils
    ' loads all data from a given table name parameter to a given grid object parameter 
    Public Sub load_data_to_datagrid(table As String, grid As DataGridView)
        Call Connect_to_DB()

        Dim strSQL As String = "Select * from " & table

        Dim mycmd As New MySqlCommand(strSQL, myconn)
        Try
            Dim result = mycmd.ExecuteReader

            If result.HasRows Then
                Dim row = 0
                Dim i As Integer
                While result.Read()
                    grid.Rows.Insert(row)

                    For i = 0 To result.FieldCount - 1
                        grid.Rows(row).Cells(i).Value = result.GetValue(i)
                    Next

                    row += 1
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show("An Error has occured: " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub
End Module
