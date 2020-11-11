Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormCRptSalesReport
    Public Property mUser As User = New User()
    Dim format As String = "yyyy-MM-dd"
    Dim MMddyyyy As String = "MMMM dd, yyyy"


    Private Sub FormSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combobox()
        cbbProjectName.SelectedIndex = 0
    End Sub
    Private Sub load_combobox()
        sql = "SELECT `proj_name`, `proj_address` FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.Items.Clear()
            Do While sqlDataReader.Read = True
                cbbProjectName.Items.Add(sqlDataReader("proj_name"))
            Loop

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub generate_report(ByRef projectName As String)

        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`, (SELECT CONCAT(`first_name`,' ',`last_name`) FROM `db_user_profile` WHERE id= t.`userid`) AS 'name', 
        `paid_amount`, t.`discount_amount`, t.`penalty`, pt.`short_name`, pt.`id` AS `payment_type`, 
        IF(IFNULL(t.`part_no`, 0)=0,'',t.`part_no`) AS part_no, pa.`name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm`, t.`date_paid` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE pl.`proj_name` LIKE @ProjName AND t.`date_paid` BETWEEN @DateFrom AND @DateTo
        ORDER BY date_paid DESC, proj_name ASC, lot ASC, official_receipt_no ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ProjName", MySqlDbType.VarChar).Value = projectName
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpSalesReport
            report.Load()
            Dim projName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtProjectName")
            Dim salesReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtSalesReport")
            Dim txtCash As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCash")
            Dim txtCheck As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCheck")
            Dim txtBankTransfer As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtBankTransfer")
            Dim txtDiscount As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtDiscount")

            projName.Text = "PROJECT NAME: " & projectName
            If dtpFrom.Value = dtpTo.Value Then
                salesReport.Text = dtpFrom.Value.ToString(MMddyyyy)
            Else
                salesReport.Text = dtpFrom.Value.ToString(MMddyyyy) & " - " & dtpTo.Value.ToString(MMddyyyy)
            End If

            If table.Rows.Count > 0 Then
                If IsDBNull(table.Compute("SUM(paid_amount)", "payment_type = 0")) Then
                    txtCash.Text = 0.ToString("N2")
                Else
                    txtCash.Text = Convert.ToDouble(table.Compute("SUM(paid_amount)", "payment_type = 0")).ToString("N2")
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
                txtDiscount.Text = Convert.ToDouble(table.Compute("SUM(discount_amount)", "")).ToString("N2")
            Else
                txtCash.Text = 0.ToString("N2")
                txtCheck.Text = 0.ToString("N2")
                txtBankTransfer.Text = 0.ToString("N2")
                txtDiscount.Text = 0.ToString("N2")
            End If
            report.SetDataSource(table)
            CrystalReportViewerSales.ReportSource = report
            CrystalReportViewerSales.Refresh()
            CrystalReportViewerSales.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        generate_report(cbbProjectName.Text)
    End Sub
End Class