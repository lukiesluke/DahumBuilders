Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptExpenses
    Dim format As String = "yyyy-MM-dd"
    Dim MMddyyyy As String = "MMMM dd, yyyy"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Cursor = Cursors.WaitCursor
        generate_report()
        Cursor = Cursors.Default
    End Sub

    Private Sub generate_report()

        Dim table As New DataTable()
        sql = "SELECT `id`, `date_paid`, `commission`, `description`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_transaction`.`userid`= `db_user_profile`.`id`), `payee_name`) AS payeeName,
        (SELECT `name` FROM `db_payment_type` WHERE `id`= `db_transaction`.`payment_type`) AS paymentType,
        (SELECT `name` FROM `db_particular_type` WHERE `id`= `particular`) AS particular, `check_bank_name`, `check_number`
        FROM `db_transaction` WHERE `particular`>5 AND `date_paid` BETWEEN @DateFrom AND @DateTo"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpExpensesReport
            report.Load()
            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtHeaderCompanyName")
            Dim txtDateReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtDateReport")

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName
            If dtpFrom.Value.Date.Equals(dtpTo.Value.Date) Then
                txtDateReport.Text = dtpFrom.Value.ToString(MMddyyyy)
            Else
                txtDateReport.Text = dtpFrom.Value.ToString(MMddyyyy) & " - " & dtpTo.Value.ToString(MMddyyyy)
            End If

            report.SetDataSource(table)
            CrystalReportViewerExpenses.ReportSource = report
            CrystalReportViewerExpenses.Refresh()
            CrystalReportViewerExpenses.Zoom(90)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.Value = dtpFrom.Value
    End Sub
End Class