Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptSummaryReport
    Private Sub FormCRptSummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_report()
    End Sub
    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT l.`id`, l.`proj_name`,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=0) AS cash,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=1) AS 'check',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=2) AS 'bankTransfer',
        (SELECT IFNULL(SUM(it.`discount_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id`) AS 'discount',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id`) AS 'total'
        FROM `db_project_list` l LEFT JOIN `db_transaction` t ON l.id = t.`proj_id` GROUP BY l.`id` ORDER BY l.`proj_name` ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(Table)
            End With
            Dim report As New crpSummaryReport
            report.Load()
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
End Class