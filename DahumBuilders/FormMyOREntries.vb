Imports MySql.Data.MySqlClient
Public Class FormMyOREntries
    Private transaction As Transaction = New Transaction()
    Public Property mORNumber As String = ""
    Public Property mID As String = ""
    Dim tries As Integer = 0

    Private Sub FormMyOREntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProjectName.Text = ""
        lblClientName.Text = ""
        PanelPassword.Visible = False
        txtORFilter.Text = mORNumber

        load_my_entries()
        loadParticularCombobox()
        loadPaymentTypeCombobox()

        If mID.Trim.Length > 0 Then

            txtORFilter.Visible = False
            chbORFilter.Visible = False

            load_OR_search()
            ListView1.Items(0).Selected = True
            ListView1.Items(0).Focused = True
            ListView1.Select()
            ListView1_Click(Me, Nothing)

        End If
    End Sub

    Private Sub load_my_entries()
        transaction = New Transaction()
        transaction._id = 0

        buttonVoidDelete()
        sql = "SELECT `id`,`date_paid`,`official_receipt_no`,`paid_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`) AS clientName,
        (SELECT `proj_name` FROM `db_project_list` WHERE `db_project_list`.`id`=t.`proj_id`) AS projectNam,
        (SELECT CONCAT('B',`block`, ' L', `lot`, ' ' ,`sqm`,' sqm') FROM `db_project_item` WHERE `db_project_item`.`proj_id`=t.`proj_id` AND `db_project_item`.`item_id`=t.`proj_itemId`) AS lotDes,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, `penalty`, `discount_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`created_by`) AS created_by,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`updated_by`),'') AS updated_by
        FROM `db_transaction` t WHERE t.`particular`<=5 AND t.`date_paid` > DATE_SUB((DATE_SUB(CURDATE(), INTERVAL 2 MONTH)), INTERVAL 1 DAY) ORDER BY t.`date_paid` DESC"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlDataReader = sqlCommand.ExecuteReader()
        Try
            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListView1.Items.Clear()
            Do While sqlDataReader.Read = True
                transaction._id = sqlDataReader("id")
                transaction._datePaid = sqlDataReader("date_paid")
                transaction._or = sqlDataReader("official_receipt_no")
                transaction._clientName = sqlDataReader("clientName")
                transaction._paidAmount = sqlDataReader("paid_amount")
                transaction._description = sqlDataReader("projectNam") & " " & sqlDataReader("lotDes")
                transaction._particular_str = sqlDataReader("particular")
                transaction._paymentType = sqlDataReader("payment_type")
                transaction._penalty = sqlDataReader("penalty")
                transaction._discountAmount = sqlDataReader("discount_amount")
                transaction._createdBy = sqlDataReader("created_by")
                transaction._updatedBy = sqlDataReader("updated_by")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._paidAmount.ToString("N2"))
                item.SubItems.Add(transaction._paymentType)
                item.SubItems.Add(transaction._particular_str)
                item.SubItems.Add(transaction._description)
                item.SubItems.Add(transaction._penalty)
                item.SubItems.Add(transaction._discountAmount)
                item.SubItems.Add(transaction._createdBy)
                item.SubItems.Add(transaction._updatedBy)
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
        Dim paymentKey As String = DirectCast(cbbPayment.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim particularKey As String = DirectCast(cbbParticular.SelectedItem, KeyValuePair(Of String, String)).Key

        sql = "UPDATE `db_transaction` t SET t.`date_paid`=@DatePaid, t.`official_receipt_no`=@ORNumber, t.`paid_amount`=@PaidAmount,
        `particular`=@Particular, `payment_type`=@PaymentType, t.`penalty`=@Penalty, t.`discount_amount`=@DiscountAmount, t.`updated_by`=@UpdatedBy WHERE t.`id`=@ID"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            sqlCommand.Parameters.Add("@ORNumber", MySqlDbType.VarChar).Value = txtORNumber.Text.Trim
            sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = txtAmount.Text.Trim
            sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int64).Value = particularKey
            sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int64).Value = paymentKey
            sqlCommand.Parameters.Add("@Penalty", MySqlDbType.Double).Value = txtPenalty.Text.Trim
            sqlCommand.Parameters.Add("@DiscountAmount", MySqlDbType.Double).Value = txtDiscount.Text.Trim
            sqlCommand.Parameters.Add("@UpdatedBy", MySqlDbType.Int64).Value = userLogon._id
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = transaction._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Official Reciept Entry Successfully Updated")
                sqlCommand.Dispose()
                sqlConnection.Close()
                Exit Sub
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

        If ListView1.Items.Count > 0 Then
            transaction = New Transaction()
            transaction._id = ListView1.SelectedItems.Item(0).Text
            transaction._datePaid = ListView1.SelectedItems.Item(0).SubItems(1).Text
            transaction._or = ListView1.SelectedItems.Item(0).SubItems(2).Text
            transaction._clientName = ListView1.SelectedItems.Item(0).SubItems(3).Text
            transaction._paidAmount = ListView1.SelectedItems.Item(0).SubItems(4).Text
            transaction._paymentType = ListView1.SelectedItems.Item(0).SubItems(5).Text
            transaction._particular_str = ListView1.SelectedItems.Item(0).SubItems(6).Text
            transaction._description = ListView1.SelectedItems.Item(0).SubItems(7).Text
            transaction._penalty = ListView1.SelectedItems.Item(0).SubItems(8).Text
            transaction._discountAmount = ListView1.SelectedItems.Item(0).SubItems(9).Text

            dtpDatePaid.Value = transaction._datePaid
            txtORNumber.Text = transaction._or
            txtAmount.Text = transaction._paidAmount.ToString("N2")
            lblClientName.Text = transaction._clientName
            lblProjectName.Text = transaction._description
            cbbPayment.Text = transaction._paymentType
            cbbParticular.Text = transaction._particular_str
            txtPenalty.Text = transaction._penalty
            txtDiscount.Text = transaction._discountAmount
        End If

        buttonVoidDelete()
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

    Private Sub loadParticularCombobox()
        sql = "SELECT id, `short_name` FROM `db_particular_type` WHERE `id` <=5"
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

    Private Sub cbbPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbPayment.SelectedIndexChanged
        Dim paymentKey As String = DirectCast(cbbPayment.SelectedItem, KeyValuePair(Of String, String)).Key
    End Sub
    Private Sub load_OR_search()
        Connection()

        sql = "SELECT `id`,`date_paid`, IFNULL(`official_receipt_no`,'') AS `official_receipt_no`,`paid_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`) AS clientName,
        (SELECT `proj_name` FROM `db_project_list` WHERE `db_project_list`.`id`=t.`proj_id`) AS projectNam,
        (SELECT CONCAT('B',`block`, ' L', `lot`, ' ' ,`sqm`,' sqm') FROM `db_project_item` WHERE `db_project_item`.`proj_id`=t.`proj_id` AND `db_project_item`.`item_id`=t.`proj_itemId`) AS lotDes,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, `penalty`, `discount_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`created_by`) AS created_by,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`updated_by`),'') AS updated_by
        FROM `db_transaction` t WHERE t.`id` = @OREntry"

        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OREntry", MySqlDbType.Int32).Value = mID
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
                transaction._particular_str = sqlDataReader("particular")
                transaction._paymentType = sqlDataReader("payment_type")
                transaction._penalty = sqlDataReader("penalty")
                transaction._discountAmount = sqlDataReader("discount_amount")
                transaction._createdBy = sqlDataReader("created_by")
                transaction._updatedBy = sqlDataReader("updated_by")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._paidAmount.ToString("N2"))
                item.SubItems.Add(transaction._paymentType)
                item.SubItems.Add(transaction._particular_str)
                item.SubItems.Add(transaction._description)
                item.SubItems.Add(transaction._penalty)
                item.SubItems.Add(transaction._discountAmount)
                item.SubItems.Add(transaction._createdBy)
                item.SubItems.Add(transaction._updatedBy)
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
    Private Sub chbORFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chbORFilter.CheckedChanged
        clearFields()
        buttonVoidDelete()
        If chbORFilter.Checked = False Then
            load_my_entries()
            Exit Sub
        End If

        If txtORFilter.Text.Trim.Length < 1 Then
            load_my_entries()
            Exit Sub
        End If

        sql = "SELECT `id`,`date_paid`, IFNULL(`official_receipt_no`,'') AS `official_receipt_no`,`paid_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE t.`userid`= `db_user_profile`.`id`) AS clientName,
        (SELECT `proj_name` FROM `db_project_list` WHERE `db_project_list`.`id`=t.`proj_id`) AS projectNam,
        (SELECT CONCAT('B',`block`, ' L', `lot`, ' ' ,`sqm`,' sqm') FROM `db_project_item` WHERE `db_project_item`.`proj_id`=t.`proj_id` AND `db_project_item`.`item_id`=t.`proj_itemId`) AS lotDes,
        (SELECT `short_name` FROM `db_particular_type` WHERE `id`= t.`particular`) AS particular, 
        (SELECT `short_name` FROM `db_payment_type` WHERE `id`=t.`payment_type`) AS payment_type, `penalty`, `discount_amount`,
        (SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`created_by`) AS created_by,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_user_profile`.`id`= t.`updated_by`),'') AS updated_by
        FROM `db_transaction` t WHERE t.`official_receipt_no` LIKE @OREntry"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OREntry", MySqlDbType.VarChar).Value = "%" & txtORFilter.Text.Trim & "%"
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
                transaction._particular_str = sqlDataReader("particular")
                transaction._paymentType = sqlDataReader("payment_type")
                transaction._penalty = sqlDataReader("penalty")
                transaction._discountAmount = sqlDataReader("discount_amount")
                transaction._createdBy = sqlDataReader("created_by")
                transaction._updatedBy = sqlDataReader("updated_by")

                item = New ListViewItem(transaction._id)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(transaction._datePaid)
                item.SubItems.Add(transaction._or)
                item.SubItems.Add(transaction._clientName)
                item.SubItems.Add(transaction._paidAmount.ToString("N2"))
                item.SubItems.Add(transaction._paymentType)
                item.SubItems.Add(transaction._particular_str)
                item.SubItems.Add(transaction._description)
                item.SubItems.Add(transaction._penalty)
                item.SubItems.Add(transaction._discountAmount)
                item.SubItems.Add(transaction._createdBy)
                item.SubItems.Add(transaction._updatedBy)
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

    Private Sub buttonVoidDelete()
        If ListView1.Items.Count > 0 And transaction._id > 0 Then
            btDeleteOR.Enabled = True
            btnVoidOR.Enabled = True
        Else
            btDeleteOR.Enabled = False
            btnVoidOR.Enabled = False
        End If
    End Sub

    Private Sub clearFields()
        dtpDatePaid.Value = Date.Now
        txtORNumber.Text = ""
        txtAmount.Text = ""
        lblClientName.Text = ""
        lblProjectName.Text = ""
        cbbPayment.SelectedIndex = 0
        cbbParticular.SelectedIndex = 0
        transaction._id = 0
    End Sub

    Private Sub btDeleteOR_Click(sender As Object, e As EventArgs) Handles btDeleteOR.Click
        Dim message As String = "Are you sure you want to delete this OR?" & vbNewLine & vbNewLine & "OR number: " & transaction._or & vbNewLine & "OR Name: " & transaction._clientName
        Dim result As DialogResult = MessageBox.Show(Me, message, "Delete Official Reciept", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            'deleteORMethod()
            PanelPassword.Visible = True
            txtUsername.Text = userLogon._username
            tries = 0
            passwordVerification()
        End If
    End Sub

    Private Sub deleteORMethod()

        Connection()
        sql = "INSERT INTO `db_history_delete` (`OR`,`amount`,`userID`,`name`) 
        SELECT CONCAT('OR_NUMBER:',`official_receipt_no`), `paid_amount`, @UserID, @Name FROM `db_transaction` WHERE id=@ID;
        DELETE FROM `db_transaction` WHERE `id`=@ID"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = userLogon._id
            sqlCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userLogon._name
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = transaction._id

            If sqlCommand.ExecuteNonQuery() > 0 Then
                txtPassword.Text = ""
                PanelPassword.Visible = False
                MessageBox.Show("Official Reciept Entry Successfully deleted")
                load_my_entries()
            End If
        Catch ex As Exception
            MessageBox.Show("DELETE Official Reciept ERROR: " & ex.Message)
            PanelPassword.Visible = True
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub btnOkayPassword_Click(sender As Object, e As EventArgs) Handles btnOkayPassword.Click
        passwordVerification()
    End Sub

    Private Sub passwordVerification()
        lblMessage.Visible = False
        Try
            If userLogon._password.Equals(txtPassword.Text.Trim) Then
                deleteORMethod()
            Else
                lblMessage.Visible = True
                If txtPassword.Text.Trim.Length < 1 Then
                    lblMessage.Text = "Please enter password."
                Else
                    Dim result As String = String.Empty
                    result = String.Format("Invaild password please try again. Attemp ({0})", tries + 1)
                    tries += 1
                    lblMessage.Text = result
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btPassCancel_Click(sender As Object, e As EventArgs) Handles btPassCancel.Click
        PanelPassword.Visible = False
    End Sub

    Private Sub txtPenalty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPenalty.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

End Class