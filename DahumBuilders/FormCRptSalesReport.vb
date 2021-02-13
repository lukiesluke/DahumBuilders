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
        sql = "SELECT `id`, `proj_name` FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()

            Dim comboSourceList As New Dictionary(Of String, String)()
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

        Dim table As New DataTable()
        Dim dataSet As New DataSet()
        dataSet.Clear()

        sql = "SELECT `official_receipt_no`, (SELECT CONCAT(`first_name`,' ',`last_name`) FROM `db_user_profile` WHERE id= t.`userid`) AS 'name', 
        t.`penalty`,  t.`discount_amount`, `paid_amount`,  pt.`short_name`, pa.`name` AS `particular`, pt.`id` AS `payment_type`, 
        IF(IFNULL(t.`part_no`, 0)=0,'',t.`part_no`) AS part_no, t.`id` , t.`proj_id`, it.`block` , it.`lot` , it.`sqm`, t.`date_paid` FROM `db_transaction` t 
        LEFT JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        LEFT JOIN `db_particular_type` pa ON t.`particular` = pa.`id` 
        LEFT JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`proj_id`=@projectID AND t.`particular`<6 AND t.`date_paid` BETWEEN @DateFrom AND @DateTo
        ORDER BY date_paid DESC, lot ASC, official_receipt_no ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@projectID", MySqlDbType.VarChar).Value = projectID
            sqlCommand.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            sqlCommand.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(dataSet, "SalesReport")
            End With

            table = dataSet.Tables(0)


            Dim report As New crpSalesReport
            report.Load()

            Dim projName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtProjectName")
            Dim dateReport As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtSalesReport")
            Dim txtTotalCash As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCash")
            Dim txtCheck As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtCheck")
            Dim txtBankTransfer As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtBankTransfer")
            Dim txtDiscount As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtDiscount")
            'Dim txtTotalCommission As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtTotalCommission")
            'Dim txtTotalCashOnHand As TextObject = report.ReportDefinition.Sections("Section4").ReportObjects("txtTotalCashOnHand")
            Dim txtLoginName As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtLoginName")

            projName.Text = "PROJECT NAME: " & cbbProjectName.Text
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

                '    txtTotalCashOnHand.Text = (Convert.ToDouble(txtTotalCash.Text) - Convert.ToDouble(txtTotalCommission.Text)).ToString("N2")
                txtDiscount.Text = Convert.ToDouble(table.Compute("SUM(discount_amount)", "")).ToString("N2")
            Else
                txtTotalCash.Text = zero
                txtCheck.Text = zero
                txtBankTransfer.Text = zero
                txtDiscount.Text = zero

                '    txtTotalCommission.Text = zero
                '    txtTotalCashOnHand.Text = zero
            End If

            sql = "SELECT t.`description`, t.`commission`, pt.`short_name`, pa.`name` AS `particular`, pt.`id` AS `payment_type`, 
            t.`id` , t.`proj_id`, it.`block` , it.`lot` , it.`sqm`, t.`date_paid` FROM `db_transaction` t 
            LEFT JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
            LEFT JOIN `db_particular_type` pa ON t.`particular` = pa.`id` 
            LEFT JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
            WHERE t.`proj_id`=@projectID AND t.`particular`>=6 AND t.`date_paid` BETWEEN @DateFrom AND @DateTo
            ORDER BY date_paid DESC"

            Dim cmd As New MySqlCommand(sql, sqlConnection)
            cmd.Parameters.Add("@projectID", MySqlDbType.VarChar).Value = projectID
            cmd.Parameters.Add("@DateFrom", MySqlDbType.VarChar).Value = dtpFrom.Value.ToString(format)
            cmd.Parameters.Add("@DateTo", MySqlDbType.VarChar).Value = dtpTo.Value.ToString(format)

            Dim adapter As New MySqlDataAdapter()
            With adapter
                .SelectCommand = cmd
                .Fill(dataSet, "SalesReportExpenses")
            End With
            report.Refresh()

            txtLoginName.Text = userLogon._name

            report.SetDataSource(dataSet)
            CrystalReportViewerSales.ReportSource = report
            CrystalReportViewerSales.Refresh()
            CrystalReportViewerSales.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        generate_report()
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.Value = dtpFrom.Value
    End Sub
End Class