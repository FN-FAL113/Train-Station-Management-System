Imports Microsoft.Office.Interop
Module ExcelUtils
    Public xlsTemplatePath As String = IO.Directory.GetCurrentDirectory & "\..\..\dataXls\Templates\"
    Public xlsSavePath As String = IO.Directory.GetCurrentDirectory & "\..\..\dataXls\"

    Public Sub import_to_excel(templateFileName As String, grid As DataGridView)
        Dim xlsApp As Excel.Application = New Excel.Application()
        ' load a workbook from existing excel file to excel app
        Dim xlsWB As Excel.Workbook = xlsApp.Workbooks.Open(xlsTemplatePath + templateFileName)
        ' select worksheet 1
        Dim xlsSheet As Excel.Worksheet = xlsApp.Worksheets(1)

        Dim row, column, i As Integer

        ' add formatted column headers with borders in worksheet
        ' skip certain rows which contains headers
        For i = 0 To grid.ColumnCount - 1
            With xlsSheet.Cells(4, i + 1)
                .Borders.Linestyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlMedium
                .Font.Bold = True
            End With

            ' row-column param for #Cells method, data grid column names to excel row cells/column
            xlsSheet.Cells(4, i + 1) = grid.Columns(i).Name
        Next

        ' add values to each formatted row column in worksheet 
        ' skip certain rows which contains headers
        For row = 0 To grid.RowCount - 1
            For column = 0 To grid.ColumnCount - 1
                xlsSheet.Cells(row + 5, column + 1).Borders.Linestyle = Excel.XlLineStyle.xlContinuous
                xlsSheet.Cells(row + 5, column + 1) = grid.Rows(row).Cells(column).Value
            Next
        Next

        ' auto fit values in a cell to prevent text overflows
        xlsSheet.Cells.EntireColumn.AutoFit()

        ' format filename for the new excel file
        Dim myfilename As String = templateFileName & "_" + Date.Now.ToString("yy-MM-dd_HH-mm-ss") + ".xlsx"

        ' for data visualization on sheet 2 (only database views have this sheet)
        If xlsApp.Worksheets.Count > 1 Then
            ' make worksheet 2 as active window
            xlsApp.Worksheets(2).Activate
            ' change active window view style
            xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
            ' remove active window grid lines
            xlsApp.ActiveWindow.DisplayGridlines = False
        End If

        ' save workbook
        xlsWB.SaveAs(xlsSavePath & myfilename)
        ' quit excel app but this is not cleared from the memory
        xlsApp.Quit()

        ' release excel app objects from the memory
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)

        ' open the created file with given filepath and filename in excel.exe
        Process.Start("EXCEL.EXE", """" + xlsSavePath + myfilename + """")
    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

End Module
