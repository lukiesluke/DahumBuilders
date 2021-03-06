Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptExpenses
    Private Sub FormCRptExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_report()
    End Sub
    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT `id`, `date_paid`, `commission`, `description`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_transaction`.`userid`= `db_user_profile`.`id`), 'UNSIGNED') AS payeeName,
        (SELECT `name` FROM `db_payment_type` WHERE `id`= `db_transaction`.`payment_type`) AS paymentType,
        (SELECT `name` FROM `db_particular_type` WHERE `id`= `particular`) AS particular, `check_number`
        FROM `db_transaction` WHERE `particular`>5"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            'sqlCommand.Parameters.Add("@projectID", MySqlDbType.VarChar).Value = projectID
            'sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(Format)
            'sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(Format)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpExpensesReport
            report.Load()

            report.SetDataSource(table)
            CrystalReportViewerExpenses.ReportSource = report
            CrystalReportViewerExpenses.Refresh()
            CrystalReportViewerExpenses.Zoom(90)
        Catch ex As Exception

        End Try
    End Sub

End Class