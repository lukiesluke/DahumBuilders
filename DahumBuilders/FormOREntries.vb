Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormOREntries
    Public Property mUser As User = New User()

    Private Sub FormOREntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("", "Official Receipt")
        DataGridView1.Columns.Add("", "TCP")
        DataGridView1.Columns.Add("", "Date")

        generate_report()
    End Sub

    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`,`paid_amount`, t.`discount_amount`, t.`penalty`, pt.`short_name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`short_name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=@userId ORDER BY date_paid DESC, proj_name ASC, lot ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = 14
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

End Class