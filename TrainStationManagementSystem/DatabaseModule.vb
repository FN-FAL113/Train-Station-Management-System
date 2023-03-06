Imports MySql.Data.MySqlClient
Module DatabaseModule

    Public myconn As New MySqlConnection

    Public Sub Connect_to_DB()
        Dim myConnectionString As String = "server=127.0.0.1;" _
                    & "port=4306;" _
                    & "uid=root;" _
                    & "pwd=admin;" _
                    & "database=orbeta_fatdb_activity2"
        Try
            If myconn.State = ConnectionState.Open Then myconn.Close()

            myconn.ConnectionString = myConnectionString
            myconn.Open()
        Catch ex As MySqlException
            Call Disconnect_to_DB()
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server!")
                Case 1045
                    MsgBox("Invalid DB Credentials!")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub
End Module
