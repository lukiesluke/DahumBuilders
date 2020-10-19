Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormCRptTransaction
    Public Property mUser As User = New User()

    Private Sub FormCRptTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        generate_report()
    End Sub

    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`,`paid_amount`, t.`discount_amount`, pt.`short_name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`short_name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=@userId ORDER BY date_paid, t.`particular`, t.`part_no`, t.`official_receipt_no` ASC"
        Connection()
        Try

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crptTransaction
            report.Load()
            Dim name As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtName")
            Dim mobile As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtMobile")
            Dim address As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtAddress")
            name.Text = mUser._name
            mobile.Text = mUser._mobile
            address.Text = mUser._address
            report.SetDataSource(table)

            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

End Class