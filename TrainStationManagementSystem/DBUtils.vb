Imports MySql.Data.MySqlClient
Module DBUtils
    ' loads all data from a given table name parameter to a given grid object parameter 
    Public Sub load_data_to_datagrid(table As String, grid As DataGridView, query As String)
        Call Connect_to_DB()

        Dim strSQL As String = IIf(query.Length > 0, query, "Select * from " + table)

        Dim mycmd As New MySqlCommand(strSQL, myconn)
        Try
            ' clear data grid rows before adding data
            grid.Rows.Clear()
            Dim result = mycmd.ExecuteReader()

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
            MessageBox.Show("An Error has occured while loading data to grid: " + ex.Message +
                            Environment.NewLine + "Table name: " + table)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Public Function wrap_value_sq(value As String) As String
        Return "'" + value + "'"
    End Function

    Public Sub add_data_to_db(table As String, values As String, IDValue As String)
        Call Connect_to_DB()

        Dim strSql As String = "INSERT INTO " + table + " VALUES " + values
        Dim mycmd As New MySqlCommand(strSql, myconn)

        Try
            If check_data_from_id(table, IDValue) Then
                MessageBox.Show("Data ID already exist in " + table)
                Return
            End If

            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully added data to " + table)
        Catch ex As MySqlException
            MessageBox.Show("An error has occured while adding data to " + table + ": " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Public Sub update_data_from_db(table As String, values As String, IDValue As String)
        Call Connect_to_DB()

        Dim strSql As String = "UPDATE " + table + " SET " + values + " WHERE id = " + IDValue + ";"
        Dim mycmd As New MySqlCommand(strSql, myconn)

        Try
            If Not check_data_from_id(table, IDValue) Then
                MessageBox.Show("Data ID does not exist in " + table)
                Return
            End If

            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully updated data!")
        Catch ex As MySqlException
            MessageBox.Show("An error has occured while updating data from " + table + ": " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Public Sub delete_data_from_db(table As String, IDValue As String)
        Call Connect_to_DB()

        Dim strSql As String = "DELETE FROM " + table + " WHERE ID = " + IDValue
        Dim mycmd As New MySqlCommand(strSql, myconn)

        Try
            If Not check_data_from_id(table, IDValue) Then
                MessageBox.Show("Data does not exist in " + table)
                Return
            End If

            mycmd.ExecuteNonQuery()

            MessageBox.Show("Successfully deleted data from " + table)
        Catch ex As MySqlException
            MessageBox.Show("An error has occured while delete data from " + table + ": " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Sub

    Public Function check_data_from_id(table As String, IDValue As String)
        Call Connect_to_DB()

        Dim strSql As String = "SELECT * FROM " + table + " WHERE id = " + IDValue
        Dim mycmd As New MySqlCommand(strSql, myconn)

        Try
            Dim myreader As MySqlDataReader = mycmd.ExecuteReader()

            If Not myreader.HasRows Then
                myreader.Close()
                Return False
            End If

            myreader.Close()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("An error has occured while checking data from id on " + table + ": " + ex.Message)
        End Try

        Call Disconnect_to_DB()
    End Function
End Module
