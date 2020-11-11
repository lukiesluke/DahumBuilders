Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormCRptSalesReport
    Public Property mUser As User = New User()

    Private Sub FormSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate_report("Tagaytay")
    End Sub
    Private Sub generate_report(ByRef projectName As String)

        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`, (SELECT `first_name` FROM `db_user_profile` WHERE id= t.`userid`) AS 'name', `paid_amount`, t.`discount_amount`, t.`penalty`, pt.`short_name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        ORDER BY date_paid DESC, proj_name ASC, lot ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpSalesReport
            report.Load()
            Dim projName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtProjectName")
            projName.Text = "PROJECT NAME: " & projectName

            report.SetDataSource(table)

            CrystalReportViewerSales.ReportSource = report
            CrystalReportViewerSales.Refresh()
            CrystalReportViewerSales.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

End Class