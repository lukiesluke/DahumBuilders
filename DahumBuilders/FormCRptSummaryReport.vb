Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptSummaryReport
    Dim format As String = "yyyy-MM-dd"
    Dim MMddyyyy As String = "MMMM dd, yyyy"

    Private Sub FormCRptSummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT l.`id`, l.`proj_name`,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=0 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS cash,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=1 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'check',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=2 AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'bankTransfer',
        (SELECT IFNULL(SUM(it.`discount_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND it.`date_paid` BETWEEN @DateFrom AND @DateTo) AS 'discount',
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
            Dim dateReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtSalesReport")

            If dtpFrom.Value.Date.Equals(dtpTo.Value.Date) Then
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy)
            Else
                dateReport.Text = dtpFrom.Value.ToString(MMddyyyy) & " - " & dtpTo.Value.ToString(MMddyyyy)
            End If

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
        generate_report()
    End Sub
End Class