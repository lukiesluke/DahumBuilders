Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptSummaryReport
    Dim format As String = "yyyy-MM-dd"
    Dim MMddyyyy As String = "MMMM dd, yyyy"

    Function generate_expenses() As String
        Dim table As New DataTable()
        Dim totalExpenses As String = 0.ToString("N2")

        sql = "SELECT SUM(`commission`) AS expenses FROM `db_transaction` 
        WHERE `particular`>5 AND `date_paid` BETWEEN @DateFrom AND @DateTo"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(Table)
            End With

            If table.Rows.Count > 0 Then
                If IsDBNull(table.Compute("SUM(expenses)", "")) Then
                    totalExpenses = 0.ToString("N2")
                Else
                    totalExpenses = Convert.ToDouble(table.Compute("SUM(expenses)", "")).ToString("N2")
                End If
            Else
                totalExpenses = 0.ToString("N2")
            End If
        Catch ex As Exception
            totalExpenses = 0.ToString("N2")
        End Try

        Return totalExpenses
    End Function
    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT l.`id`, l.`proj_name`,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=0 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS cash,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=1 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'check',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=2 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'bankTransfer',
        (SELECT IFNULL(SUM(it.`commission`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'commission',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'total'
        FROM `db_project_list` l LEFT JOIN `db_transaction` t ON l.id = t.`proj_id` GROUP BY l.`id` ORDER BY l.`proj_name` ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(Format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(Format)

            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpSummaryReport
            report.Load()
            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtHeaderCompanyName")

            Dim dateReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtSalesReport")
            Dim txtTotalCash As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtTotalCash")
            Dim txtCheck As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCheck")
            Dim txtBankTransfer As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtBankTransfer")
            Dim txtLoginName As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtLoginName")
            Dim txtTotalExpenses As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtTotalExpenses")
            Dim txtNetProfit As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtNetProfit")

            Dim totalExpenses As Double = generate_expenses()

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName

            If dtpFrom.Value.Date.Equals(dtpTo.Value.Date) Then
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy)
            Else
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy) & " - " & dtpTo.Value.ToString(MMddyyyy)
            End If

            If table.Rows.Count > 0 Then

                If IsDBNull(table.Compute("SUM(cash)", "")) Then
                    txtTotalCash.Text = 0.ToString("N2")
                Else
                    txtTotalCash.Text = Convert.ToDouble(table.Compute("SUM(cash)", "")).ToString("N2")
                End If

                If IsDBNull(table.Compute("SUM(check)", "")) Then
                    txtCheck.Text = 0.ToString("N2")
                Else
                    txtCheck.Text = Convert.ToDouble(table.Compute("SUM(check)", "")).ToString("N2")
                End If

                If IsDBNull(table.Compute("SUM(bankTransfer)", "")) Then
                    txtBankTransfer.Text = 0.ToString("N2")
                Else
                    txtBankTransfer.Text = Convert.ToDouble(table.Compute("SUM(bankTransfer)", "")).ToString("N2")
                End If

                If IsDBNull(table.Compute("SUM(total)", "")) Then
                    txtNetProfit.Text = 0.ToString("N2")
                Else
                    Dim total As Double = table.Compute("SUM(total)", "")
                    txtNetProfit.Text = Convert.ToDouble(total - totalExpenses).ToString("N2")
                End If

                txtTotalCash.Text = (Convert.ToDouble(txtTotalCash.Text)).ToString("N2")
            Else
                txtTotalCash.Text = 0.ToString("N2")
                txtCheck.Text = 0.ToString("N2")
                txtBankTransfer.Text = 0.ToString("N2")
                txtNetProfit.Text = 0.ToString("N2")
            End If

            txtLoginName.Text = userLogon._name
            txtTotalExpenses.Text = totalExpenses.ToString("N2")

            report.SetDataSource(table)
            CrystalReportViewerSummary.ReportSource = report
            CrystalReportViewerSummary.Refresh()
            CrystalReportViewerSummary.Zoom(90)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
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
End Class