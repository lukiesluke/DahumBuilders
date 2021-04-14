Imports MySql.Data.MySqlClient
Public Class FormExpensesEntries
    Private transaction As Transaction = New Transaction()

    Private Sub FormExpensesEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClientName.Text = ""
        generate_report()
    End Sub

    Private Sub generate_report()
        transaction = New Transaction()
        sql = "SELECT `id`,`date_paid`,IFNULL(`official_receipt_no`,'') official_receipt_no, t.`voucher_no` , t.`commission`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`),t.`payee_name`) AS clientName,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, t.`check_bank_name`, t.`check_number`
        FROM `db_transaction` t WHERE t.`particular`>5 AND t.`date_paid` > DATE_SUB((DATE_SUB(CURDATE(), INTERVAL 2 MONTH)), INTERVAL 1 DAY) ORDER BY t.`date_paid` DESC"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlDataReader = sqlCommand.ExecuteReader()
        Try
            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListView.Items.Clear()
            Do While sqlDataReader.Read = True
                transaction._id = sqlDataReader("id")
                transaction._datePaid = sqlDataReader("date_paid")
                transaction._or = sqlDataReader("official_receipt_no")
                transaction._voucher = sqlDataReader("voucher_no")
                transaction._clientName = sqlDataReader("clientName")
                transaction._commission = sqlDataReader("commission")
                transaction._particular_str = sqlDataReader("particular")
                transaction._paymentType = sqlDataReader("payment_type")
                transaction._check_bank_name = sqlDataReader("check_bank_name")
                transaction._check_number = sqlDataReader("check_number")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._voucher)
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._commission)
                item.SubItems.Add(transaction._paymentType)
                item.SubItems.Add(transaction._particular_str)
                item.SubItems.Add(transaction._check_bank_name)
                item.SubItems.Add(transaction._check_number)
                ListView.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click, ListView.KeyUp
        If ListView.Items.Count > 0 Then
            transaction = New Transaction()
            transaction._id = ListView.SelectedItems.Item(0).Text
            transaction._datePaid = ListView.SelectedItems.Item(0).SubItems(1).Text
            transaction._or = ListView.SelectedItems.Item(0).SubItems(2).Text
            transaction._voucher = ListView.SelectedItems.Item(0).SubItems(3).Text
            transaction._clientName = ListView.SelectedItems.Item(0).SubItems(4).Text
            transaction._commission = ListView.SelectedItems.Item(0).SubItems(5).Text
            transaction._paymentType = ListView.SelectedItems.Item(0).SubItems(6).Text
            transaction._particular_str = ListView.SelectedItems.Item(0).SubItems(7).Text
            transaction._check_bank_name = ListView.SelectedItems.Item(0).SubItems(8).Text
            transaction._check_number = ListView.SelectedItems.Item(0).SubItems(9).Text

            dtpDatePaid.Value = transaction._datePaid
            txtORNumber.Text = transaction._or
            txtVoucher.Text = transaction._voucher
            lblClientName.Text = transaction._clientName
            txtAmount.Text = transaction._commission.ToString("N2")
            cbbPayment.Text = transaction._paymentType
            cbbParticular.Text = transaction._particular_str
        End If
    End Sub

End Class