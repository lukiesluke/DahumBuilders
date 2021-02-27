Imports MySql.Data.MySqlClient
Public Class FormMyOREntries
    Private transaction As Transaction = New Transaction()

    Private Sub FormMyOREntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProjectName.Text = ""
        lblClientName.Text = ""

        load_my_entries()
    End Sub

    Private Sub load_my_entries()

        sql = "SELECT `id`,`date_paid`,`official_receipt_no`,`paid_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`) AS clientName,
        (SELECT `proj_name` FROM `db_project_list` WHERE `db_project_list`.`id`=t.`proj_id`) AS projectNam,
        (SELECT CONCAT('B',`block`, ' L', `lot`, ' ' ,`sqm`,' sqm') FROM `db_project_item` WHERE `db_project_item`.`proj_id`=t.`proj_id` AND `db_project_item`.`item_id`=t.`proj_itemId`) AS lotDes
        FROM `db_transaction` t WHERE t.`official_receipt_no` IS NOT NULL AND t.`date_paid` > DATE_SUB((DATE_SUB(CURDATE(), INTERVAL 2 MONTH)), INTERVAL 1 DAY) ORDER BY t.`date_paid` DESC"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        'sqlCommand.Parameters.Add("@dt", MySqlDbType.VarChar).Value = dt.Value.ToString(Format)
        'sqlCommand.Parameters.Add("@ProjID", MySqlDbType.VarChar).Value = lblProjectID.Text.Trim
        sqlDataReader = sqlCommand.ExecuteReader()

        Try
            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListView1.Items.Clear()
            Do While sqlDataReader.Read = True
                transaction = New Transaction()
                transaction._id = sqlDataReader("id")
                transaction._datePaid = sqlDataReader("date_paid")
                transaction._or = sqlDataReader("official_receipt_no")
                transaction._clientName = sqlDataReader("clientName")
                transaction._paidAmount = sqlDataReader("paid_amount")
                transaction._description = sqlDataReader("projectNam") & " " & sqlDataReader("lotDes")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._paidAmount.ToString("N2"))
                item.SubItems.Add(transaction._description)
                ListView1.Items.Add(item)
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Connection()

        sql = "UPDATE `db_transaction` t SET t.`date_paid`=@DatePaid, t.`official_receipt_no`=@ORNumber,
        t.`paid_amount`=@PaidAmount, t.`updated_by`=@UpdatedBy WHERE t.`id`=@ID"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            sqlCommand.Parameters.Add("@ORNumber", MySqlDbType.Double).Value = txtORNumber.Text.Trim
            sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = txtAmount.Text.Trim
            sqlCommand.Parameters.Add("@UpdatedBy", MySqlDbType.Int64).Value = userLogon._id
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = transaction._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Official Reciept Entry Successfully Updated")
                sqlCommand.Dispose()
                sqlConnection.Close()
                Me.Close()
            Else
                MessageBox.Show("Data was not updated. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        'ListView1.SelectedItems.Item(0).Text
        'dtpDatePaid.Value = ListView1.SelectedItems.Item(0).SubItems(1).Text
        transaction = New Transaction()
        transaction._id = ListView1.SelectedItems.Item(0).Text
        transaction._datePaid = ListView1.SelectedItems.Item(0).SubItems(1).Text
        transaction._or = ListView1.SelectedItems.Item(0).SubItems(2).Text
        transaction._clientName = ListView1.SelectedItems.Item(0).SubItems(3).Text
        transaction._paidAmount = ListView1.SelectedItems.Item(0).SubItems(4).Text
        transaction._description = ListView1.SelectedItems.Item(0).SubItems(5).Text

        dtpDatePaid.Value = transaction._datePaid
        txtORNumber.Text = transaction._or
        txtAmount.Text = transaction._paidAmount.ToString("N2")
        lblClientName.Text = transaction._clientName
        lblProjectName.Text = transaction._description

    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        ListView1_Click(sender, e)
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub


    Private Sub txtAmount_GotFocus(sender As Object, e As EventArgs) Handles txtAmount.GotFocus, txtAmount.Click
        txtAmount.SelectAll()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class