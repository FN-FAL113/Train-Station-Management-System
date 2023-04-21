Imports MySql.Data.MySqlClient
Public Class TrainPassengerView
    Private Sub TrainPassengerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("train_passenger", TrainPassengerDataGridView)

        Call Connect_to_DB()

        Dim strSql = "Select SUM(passengers) from train_passenger"

        Try
            Dim mycmd As New MySqlCommand(strSql, myconn)
            Dim result = mycmd.ExecuteReader
            result.Read()

            TotalLabel.Text = result.GetValue(0).ToString()
        Catch ex As MySqlException
            MessageBox.Show("An error has occured: " & ex.Message)
        End Try


    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("train_passenger", TrainPassengerDataGridView)
    End Sub
End Class