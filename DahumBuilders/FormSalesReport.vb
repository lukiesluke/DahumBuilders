Imports MySql.Data.MySqlClient

Public Class FormSalesReport
    Private Sub FormSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_report()
    End Sub

    Private Sub load_report()
        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`, (SELECT `first_name` FROM `db_user_profile` WHERE id= t.`userid`) AS 'name', `paid_amount`, t.`discount_amount`, t.`penalty`, pt.`short_name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        ORDER BY date_paid DESC, proj_name ASC, lot ASC"
        Connection()
        ListViewReport.Items.Clear()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With
            If table.Rows.Count < 1 Then
                GoTo FinallyLine
            End If
            Dim item As ListViewItem
            Dim sale As Sales
            For i As Integer = 0 To table.Rows.Count - 1
                sale = New Sales()
                With sale
                    ._officialReceipt = table.Rows(i)("official_receipt_no")
                    ._name = table.Rows(i)("name")
                    ._block = table.Rows(i)("block")
                    ._lot = table.Rows(i)("lot")
                    ._sqm = table.Rows(i)("sqm")
                    ._amount = table.Rows(i)("paid_amount")
                    ._particular = table.Rows(i)("particular")
                    ._payment_type = table.Rows(i)("payment_type")
                End With
                item = New ListViewItem(sale._officialReceipt)
                With item
                    .SubItems.Add(sale._name)
                    .SubItems.Add(sale._block)
                    .SubItems.Add(sale._lot)
                    .SubItems.Add(sale._sqm)
                    .SubItems.Add(sale._amount.ToString("N2"))
                    .SubItems.Add(sale._particular)
                    .SubItems.Add(sale._payment_type)
                End With
                ListViewReport.Items.Add(item)
            Next
FinallyLine:
        Catch ex As Exception
            MessageBox.Show("User Information load: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

    End Sub
End Class