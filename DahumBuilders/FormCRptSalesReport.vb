Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Office.Interop

Public Class FormCRptSalesReport
    Public Property mUser As User = New User()
    Dim format As String = "yyyy-MM-dd"
    Dim MMddyyyy As String = "MMMM dd, yyyy"

    Private Sub FormSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combobox()
        cbbProjectName.SelectedIndex = 0
    End Sub
    Private Sub load_combobox()
        sql = "SELECT `id`, `proj_name` FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()

            Dim comboSourceList As New Dictionary(Of String, String)()
            comboSourceList.Add(0, "All")

            Do While sqlDataReader.Read = True
                comboSourceList.Add(sqlDataReader("id"), sqlDataReader("proj_name"))
            Loop
            cbbProjectName.DataSource = New BindingSource(comboSourceList, Nothing)
            cbbProjectName.DisplayMember = "Value"
            cbbProjectName.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub generate_report()
        Dim projectID As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim zero As String = 0.ToString("N2")
        Dim HeaderSaleReport As String = "Daily Sales Report"
        Dim table As New DataTable()

        sql = "SELECT `official_receipt_no`, (SELECT CONCAT(`first_name`,' ',`last_name`) FROM `db_user_profile` WHERE id= t.`userid`) AS 'name', t.`ar_number`, 
        t.`penalty`,  t.`discount_amount`, `paid_amount`, CONCAT (pa.`short_name`,' - ' ,pt.`short_name`) AS short_name, pa.`short_name` AS `particular`, l.`proj_name`, pt.`id` AS `payment_type`, 
        IF(IFNULL(t.`part_no`, 0)=0,'',t.`part_no`) AS part_no, t.`id`, t.`proj_id`, it.`block`, it.`lot`, it.`sqm`, t.`date_paid`, t.`tax_base` FROM `db_transaction` t 
        LEFT JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        LEFT JOIN `db_particular_type` pa ON t.`particular` = pa.`id` 
        LEFT JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        LEFT JOIN `db_project_list` l ON l.`id` = t.`proj_id`
        WHERE t.`proj_id`{0} @projectID AND t.`particular`<=6 AND t.`date_paid` BETWEEN @DateFrom AND @DateTo
        ORDER BY date_paid DESC, lot ASC, official_receipt_no ASC"

        If projectID.Equals("0") Then
            sql = String.Format(sql, ">=")
            HeaderSaleReport = "Sales Report"
        Else
            sql = String.Format(sql, "=")
            HeaderSaleReport = "Daily Sales Report"
        End If

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@projectID", MySqlDbType.VarChar).Value = projectID
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpSalesReport
            report.Load()
            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtHeaderCompanyName")

            Dim projName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtProjectName")
            Dim txtHeaderSaleReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("HeaderSaleReport")
            Dim dateReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtSalesReport")
            Dim txtTotalCash As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCash")
            Dim txtCheck As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCheck")
            Dim txtBankTransfer As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtBankTransfer")
            Dim txtLoginName As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtLoginName")

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName
            projName.Text = "PROJECT NAME: " & cbbProjectName.Text
            txtHeaderSaleReport.Text = HeaderSaleReport

            If dtpFrom.Value.Date.Equals(dtpTo.Value.Date) Then
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy)
            Else
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy) & " - " & dtpTo.Value.ToString(MMddyyyy)
            End If

            If table.Rows.Count > 0 Then
                If IsDBNull(table.Compute("SUM(paid_amount)", "payment_type = 0")) Then
                    txtTotalCash.Text = 0.ToString("N2")
                Else
                    txtTotalCash.Text = Convert.ToDouble(table.Compute("SUM(paid_amount)", "payment_type = 0")).ToString("N2")
                End If

                If IsDBNull(table.Compute("SUM(paid_amount)", "payment_type = 1")) Then
                    txtCheck.Text = 0.ToString("N2")
                Else
                    txtCheck.Text = Convert.ToDouble(table.Compute("SUM(paid_amount)", "payment_type = 1")).ToString("N2")
                End If

                If IsDBNull(table.Compute("SUM(paid_amount)", "payment_type = 2")) Then
                    txtBankTransfer.Text = 0.ToString("N2")
                Else
                    txtBankTransfer.Text = Convert.ToDouble(table.Compute("SUM(paid_amount)", "payment_type = 2")).ToString("N2")
                End If

            Else
                txtTotalCash.Text = zero
                txtCheck.Text = zero
                txtBankTransfer.Text = zero
            End If

            txtLoginName.Text = userLogon._name

            report.SetDataSource(table)
            CrystalReportViewerSales.ReportSource = report
            CrystalReportViewerSales.Refresh()
            CrystalReportViewerSales.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Cursor = Cursors.WaitCursor
        generate_report()
        Cursor = Cursors.Default
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.Value = dtpFrom.Value
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        If cbbProjectName.SelectedIndex < 1 Then

            MessageBox.Show("Please select one Project Name")
            cbbProjectName.DroppedDown = True
            Exit Sub
        End If

        Dim projectID As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim HeaderSaleReport As String = "Daily Sales Report"

        sql = "SELECT it.`block`, it.`lot`, it.`sqm`, (SELECT CONCAT(`first_name`,' ',`last_name`) FROM `db_user_profile` WHERE id= t.`userid`) AS 'name',
        it.`price`, pa.`short_name` AS `particular`, l.`proj_name`, `official_receipt_no`, t.`date_paid`, t.`tax_base`, `paid_amount`, pt.`short_name`, `ar_number` FROM `db_transaction` t 
        LEFT JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        LEFT JOIN `db_particular_type` pa ON t.`particular` = pa.`id` 
        LEFT JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        LEFT JOIN `db_project_list` l ON l.`id` = t.`proj_id`
        WHERE t.`proj_id`=@projectID AND t.`particular`<=6 AND t.`date_paid` BETWEEN @DateFrom AND @DateTo
        ORDER BY CAST(official_receipt_no AS UNSIGNED) ASC"


        If projectID.Equals("0") Then
            sql = String.Format(sql, ">=")
            HeaderSaleReport = "Sales Report"
        Else
            sql = String.Format(sql, "=")
            HeaderSaleReport = "Daily Sales Report"
        End If

        Cursor = Cursors.WaitCursor
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@projectID", MySqlDbType.VarChar).Value = projectID
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            sqlAdapter = New MySqlDataAdapter
            Dim ds As New DataSet

            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(ds)
            End With

            Dim objExcel As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim shWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim chartRange As Excel.Range

            objExcel = New Excel.Application
            xlWorkBook = objExcel.Workbooks.Add(misValue)
            shWorkSheet = xlWorkBook.Sheets("sheet1")

            chartRange = shWorkSheet.Range("A1", "M1")
            chartRange.Merge()
            chartRange.HorizontalAlignment = Excel.Constants.xlCenter
            shWorkSheet.Cells(1, 1) = HeaderSaleReport

            shWorkSheet.Cells(2, 1) = "BLK"
            shWorkSheet.Cells(2, 2) = "LOT"
            shWorkSheet.Cells(2, 3) = "SQM"
            shWorkSheet.Cells(2, 4) = "Customer Name"
            shWorkSheet.Cells(2, 5) = "TCP"
            shWorkSheet.Cells(2, 6) = "Particular"
            shWorkSheet.Cells(2, 7) = "Property"
            shWorkSheet.Cells(2, 8) = "OR #"
            shWorkSheet.Cells(2, 9) = "Date Payment"
            shWorkSheet.Cells(2, 10) = "VAT"
            shWorkSheet.Cells(2, 11) = "Paid Amount"
            shWorkSheet.Cells(2, 12) = "Payment Type"
            shWorkSheet.Cells(2, 13) = "AR"

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    shWorkSheet.Cells(i + 3, j + 1) = ds.Tables(0).Rows(i).Item(j)
                Next
            Next

            shWorkSheet.Columns(1).HorizontalAlignment = Excel.Constants.xlLeft
            shWorkSheet.Columns(7).HorizontalAlignment = Excel.Constants.xlCenter
            shWorkSheet.Columns(8).HorizontalAlignment = Excel.Constants.xlCenter
            shWorkSheet.Columns(10).HorizontalAlignment = Excel.Constants.xlRight
            shWorkSheet.Columns(11).HorizontalAlignment = Excel.Constants.xlRight
            shWorkSheet.Columns(12).HorizontalAlignment = Excel.Constants.xlCenter
            shWorkSheet.Columns(13).HorizontalAlignment = Excel.Constants.xlLeft

            shWorkSheet.Range("A1:P1").EntireColumn.AutoFit()
            objExcel.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
End Class