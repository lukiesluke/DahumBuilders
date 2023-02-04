﻿Imports MySql.Data.MySqlClient
Public Class FormExpensesEntries
    Private transaction As Transaction = New Transaction()
    Public Property mIdNumber As String = ""

    Private Sub FormExpensesEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClientName.Text = ""
        generate_report()
        loadParticularCombobox()
        loadPaymentTypeCombobox()

        If mIdNumber.Length > 0 Then
            txtORFilter.Visible = False
            chbORFilter.Visible = False
            searchIdEntry(mIdNumber)
            ListView.Items(0).Selected = True
            ListView.Items(0).Focused = True
            ListView.Select()
            ListView_Click(Me, Nothing)
        End If
    End Sub

    Private Sub generate_report()
        transaction = New Transaction()
        sql = "SELECT `id`,`date_paid`,IFNULL(`official_receipt_no`,'') official_receipt_no, t.`voucher_no` , t.`commission`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`),t.`payee_name`) AS clientName,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, t.`check_bank_name`, t.`check_number`, t.`description`,
        `gross_val`,`tax_base`, `input_val` FROM `db_transaction` t WHERE t.`particular`>6 AND t.`date_paid` > DATE_SUB((DATE_SUB(CURDATE(), INTERVAL 2 MONTH)), INTERVAL 1 DAY) ORDER BY t.`date_paid` DESC"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlDataReader = sqlCommand.ExecuteReader()

        loadReaderToListView(sqlDataReader)

    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click, ListView.KeyUp
        Try
            If ListView.Items.Count > 0 Then
                transaction = New Transaction()
                transaction._id = ListView.SelectedItems.Item(0).Text
                transaction._datePaid = ListView.SelectedItems.Item(0).SubItems(1).Text
                transaction._or = ListView.SelectedItems.Item(0).SubItems(2).Text
                transaction._voucher = ListView.SelectedItems.Item(0).SubItems(3).Text
                transaction._gross = ListView.SelectedItems.Item(0).SubItems(4).Text
                transaction._tax_base = ListView.SelectedItems.Item(0).SubItems(5).Text
                transaction._input_val = ListView.SelectedItems.Item(0).SubItems(6).Text
                transaction._clientName = ListView.SelectedItems.Item(0).SubItems(7).Text
                transaction._commission = ListView.SelectedItems.Item(0).SubItems(8).Text
                transaction._paymentType = ListView.SelectedItems.Item(0).SubItems(9).Text
                transaction._particular_str = ListView.SelectedItems.Item(0).SubItems(10).Text
                transaction._check_bank_name = ListView.SelectedItems.Item(0).SubItems(11).Text
                transaction._check_number = ListView.SelectedItems.Item(0).SubItems(12).Text
                transaction._description = ListView.SelectedItems.Item(0).SubItems(13).Text

                dtpDatePaid.Value = transaction._datePaid
                txtORNumber.Text = transaction._or
                txtVoucher.Text = transaction._voucher
                txtGross.Text = transaction._gross.ToString("N2")
                txtTaxBase.Text = transaction._tax_base.ToString("N2")
                txtInput.Text = transaction._input_val.ToString("N2")
                lblClientName.Text = transaction._clientName
                txtAmount.Text = transaction._commission.ToString("N2")
                cbbPayment.Text = transaction._paymentType
                cbbParticular.Text = transaction._particular_str
                txtReference.Text = transaction._check_number
                cbbBankName.Text = transaction._check_bank_name
                txtDescription.Text = transaction._description
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadParticularCombobox()
        sql = "SELECT id, `short_name` FROM `db_particular_type` WHERE `id` >6"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbParticular.DataSource = Nothing
            cbbParticular.Items.Clear()

            Dim comboSourceParticular As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourceParticular.Add(sqlDataReader("id"), sqlDataReader("short_name"))
            Loop

            cbbParticular.DataSource = New BindingSource(comboSourceParticular, Nothing)
            cbbParticular.DisplayMember = "Value"
            cbbParticular.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub loadPaymentTypeCombobox()
        sql = "SELECT id, `short_name` FROM `db_payment_type`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbPayment.DataSource = Nothing
            cbbPayment.Items.Clear()

            Dim comboSourcePayment As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourcePayment.Add(sqlDataReader("id"), sqlDataReader("short_name"))
            Loop

            cbbPayment.DataSource = New BindingSource(comboSourcePayment, Nothing)
            cbbPayment.DisplayMember = "Value"
            cbbPayment.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If transaction._id Is Nothing Or transaction._id.Equals(0) Or txtAmount.TextLength < 1 Then
            MessageBox.Show("Please select item to update.")
            Exit Sub
        End If

        Connection()
        Dim paymentKey As String = DirectCast(cbbPayment.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim particularKey As String = DirectCast(cbbParticular.SelectedItem, KeyValuePair(Of String, String)).Key

        sql = "UPDATE `db_transaction` t SET t.`date_paid`=@DatePaid, t.`official_receipt_no`=@ORNumber, t.`voucher_no`=@Voucher, 
            t.`commission`=@Commission, `particular`=@Particular, `payment_type`=@PaymentType, t.`check_number`=@CheckNumber, 
            t.`description`=@Description, t.`gross_val`=@GrossVal, t.`tax_base`=@TaxBase, t.`input_val`=@InputVal, t.`updated_by`=@UpdatedBy WHERE t.`id`=@ID"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            sqlCommand.Parameters.Add("@ORNumber", MySqlDbType.VarChar).Value = txtORNumber.Text.Trim
            sqlCommand.Parameters.Add("@Voucher", MySqlDbType.VarChar).Value = txtVoucher.Text.Trim
            sqlCommand.Parameters.Add("@Commission", MySqlDbType.Double).Value = txtAmount.Text.Trim
            sqlCommand.Parameters.Add("@GrossVal", MySqlDbType.Double).Value = txtGross.Text.Trim
            sqlCommand.Parameters.Add("@TaxBase", MySqlDbType.Double).Value = txtTaxBase.Text.Trim
            sqlCommand.Parameters.Add("@InputVal", MySqlDbType.Double).Value = txtInput.Text.Trim
            sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int64).Value = particularKey
            sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int64).Value = paymentKey
            sqlCommand.Parameters.Add("@CheckNumber", MySqlDbType.VarChar).Value = txtReference.Text.Trim
            sqlCommand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = txtDescription.Text.Trim
            sqlCommand.Parameters.Add("@UpdatedBy", MySqlDbType.Int64).Value = userLogon._id
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = transaction._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Official Reciept Entry Successfully Updated")
                sqlCommand.Dispose()
                sqlConnection.Close()
                If mIdNumber.Length > 0 Then
                    txtORFilter.Visible = False
                    chbORFilter.Visible = False
                    searchIdEntry(mIdNumber)
                    ListView_Click(Me, Nothing)
                Else
                    generate_report()
                End If
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
    Private Sub searchIdEntry(id As String)
        clearFields()

        sql = "SELECT `id`,`date_paid`,IFNULL(`official_receipt_no`,'') official_receipt_no, t.`voucher_no` , t.`commission`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`),t.`payee_name`) AS clientName,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, t.`check_bank_name`, t.`check_number`, t.`description`,
        `gross_val`,`tax_base`, `input_val` FROM `db_transaction` t WHERE t.`particular`>6 AND t.`id`=@FindId"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@FindId", MySqlDbType.VarChar).Value = id
        sqlDataReader = sqlCommand.ExecuteReader()

        loadReaderToListView(sqlDataReader)

    End Sub

    Private Sub chbORFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chbORFilter.CheckedChanged
        clearFields()

        If chbORFilter.Checked = False Then
            generate_report()
            Exit Sub
        End If

        sql = "SELECT `id`,`date_paid`,IFNULL(`official_receipt_no`,'') official_receipt_no, t.`voucher_no` , t.`commission`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`),t.`payee_name`) AS clientName,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, t.`check_bank_name`, t.`check_number`, t.`description`,
        `gross_val`,`tax_base`, `input_val` FROM `db_transaction` t WHERE t.`particular`>6 AND t.`voucher_no`=@FindOR OR t.`official_receipt_no`=@FindOR ORDER BY t.`date_paid` DESC LIMIT 500"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@FindOR", MySqlDbType.VarChar).Value = txtORFilter.Text.Trim
        sqlDataReader = sqlCommand.ExecuteReader()

        loadReaderToListView(sqlDataReader)
    End Sub
    Private Sub loadReaderToListView(reader As MySqlDataReader)
        Try
            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListView.Items.Clear()
            Do While reader.Read = True
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
                transaction._description = sqlDataReader("description")
                transaction._gross = sqlDataReader("gross_val")
                transaction._tax_base = sqlDataReader("tax_base")
                transaction._input_val = sqlDataReader("input_val")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._voucher)
                item.SubItems.Add(transaction._gross.ToString("N2"))
                item.SubItems.Add(transaction._tax_base.ToString("N2"))
                item.SubItems.Add(transaction._input_val.ToString("N2"))
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._commission.ToString("N2"))
                item.SubItems.Add(transaction._paymentType)
                item.SubItems.Add(transaction._particular_str)
                item.SubItems.Add(transaction._check_bank_name)
                item.SubItems.Add(transaction._check_number)
                item.SubItems.Add(transaction._description)
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

    Private Sub clearFields()

        dtpDatePaid.Value = Date.Now
        txtORNumber.Text = ""
        txtAmount.Text = ""
        txtGross.Text = ""
        txtTaxBase.Text = ""
        txtInput.Text = ""
        lblClientName.Text = ""
        txtReference.Text = ""
        cbbPayment.SelectedIndex = 0
        cbbParticular.SelectedIndex = 0
        txtVoucher.Text = ""
        transaction._id = 0
        cbbBankName.SelectedIndex = 0
    End Sub

    Private Sub txtGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtGross.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTaxBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxBase.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtTaxBase.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtInput.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtAmount.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub
End Class