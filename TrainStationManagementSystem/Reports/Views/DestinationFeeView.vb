Public Class DestinationFeeView
    Private Sub DestinationFeeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data_to_datagrid("destination_fee_plus_tax", DestinationFeeDataGridView, "")
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Call import_to_excel("destination_fee_plus_tax", DestinationFeeDataGridView)
    End Sub
End Class