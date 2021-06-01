Imports MySql.Data.MySqlClient

Public Class FormPaymentMethod
    Public Property mProject As Project = New Project()
    Private Sub FormPaymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCancel.Select()
        lblProjectDetails.Text = String.Format("{0} Block {1} Lot {2} ({3} sqm)", mProject._name, mProject._block, mProject._lot, mProject._sqm)
        lblTCP.Text = mProject._tcp.ToString("N2")
        Dim count As Integer = 0
        Connection()
        Try
            sql = "SELECT COUNT(*) AS 'count' FROM `db_payment_method` WHERE item_id=@ItemID AND userid=@UserID"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            With sqlCommand
                .CommandText = sql
                .Parameters.Add("@ItemID", MySqlDbType.Int64).Value = mProject._itemID
                .Parameters.Add("@UserID", MySqlDbType.Int64).Value = mProject._userID
            End With
            Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()

            While sqlReader.Read()
                count = sqlReader("count")
            End While
        Catch ex As Exception
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

        Connection()
        Try
            If count < 1 Then
                sql = "INSERT INTO `db_payment_method` (`type`,`monthly`,`terms`,`item_id`,`userid`) VALUES 
            ('EQ', 0, 0, @ItemIDE, @UserIDE), ('MA', 0, 0, @ItemIDM, @UserIDM)"
                sqlCommand = New MySqlCommand(sql, sqlConnection)
                With sqlCommand
                    .CommandText = sql
                    .Parameters.Add("@ItemIDE", MySqlDbType.Int64).Value = mProject._itemID
                    .Parameters.Add("@UserIDE", MySqlDbType.Int64).Value = mProject._userID
                    .Parameters.Add("@ItemIDM", MySqlDbType.Int64).Value = mProject._itemID
                    .Parameters.Add("@UserIDM", MySqlDbType.Int64).Value = mProject._userID
                End With
                If sqlCommand.ExecuteNonQuery() < 1 Then
                    MessageBox.Show(Me, "Data NOT Inserted. Please try again.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                Dim values As Dictionary(Of String, PaymentMethod) = New Dictionary(Of String, PaymentMethod)
                Dim pm As New PaymentMethod
                values = getPaymentMethod(mProject._itemID, mProject._userID)
                If values.TryGetValue("EQ", pm) Then
                    txtAmountEQ.Text = pm._monthly
                    txtEquityTerm.Text = pm._term
                    dtpEquityStart.Value = pm._startDate
                    dtpEquityEnd.Value = pm._endDate
                End If
                If values.TryGetValue("MA", pm) Then
                    txtAmountMA.Text = pm._monthly
                    txtMATerm.Text = pm._term
                    dtpMonthlyStart.Value = pm._startDate
                    dtpMonthlyEnd.Value = pm._endDate
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("On Load: " & ex.Message)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

        txtAmountMA.Text = Double.Parse(txtAmountMA.Text).ToString("N2")
        txtAmountEQ.Text = Double.Parse(txtAmountEQ.Text).ToString("N2")
        loadDueDate()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If UpdatePaymetMethod(mProject, "EQ", txtAmountEQ.Text, txtEquityTerm.Text, dtpEquityStart.Value, dtpEquityEnd.Value) = 1 Then
            If UpdatePaymetMethod(mProject, "MA", txtAmountMA.Text, txtMATerm.Text, dtpMonthlyStart.Value, dtpMonthlyEnd.Value) = 1 Then
                MessageBox.Show("Successfully Updated.")
                mFormPayment.load_userId_info_data_reader()
            End If
        End If

        deleteCurrentDueDate()
        Connection()
        Try
            If Integer.Parse(txtMATerm.Text.Trim) > 0 Then
                For index As Integer = 0 To Integer.Parse(txtMATerm.Text.Trim) - 1
                    sql = "INSERT INTO `db_payment_collection` (`userid`, `type`, `due_date`, `amount`, `item_id`, `proj_id`) 
                    VALUES (@UserId, @TYPE, @DueDate, @Amount, @ItemId, @ProjId)"
                    sqlCommand = New MySqlCommand(sql, sqlConnection)
                    With sqlCommand
                        .CommandText = sql
                        .Parameters.Add("@UserId", MySqlDbType.Int64).Value = mProject._userID
                        .Parameters.Add("@TYPE", MySqlDbType.VarChar).Value = "MA"
                        .Parameters.Add("@DueDate", MySqlDbType.Date).Value = DateAdd("m", index, dtpMonthlyStart.Value)
                        .Parameters.Add("@Amount", MySqlDbType.Double).Value = txtAmountMA.Text.Trim
                        .Parameters.Add("@ItemId", MySqlDbType.Int64).Value = mProject._itemID
                        .Parameters.Add("@ProjId", MySqlDbType.Int64).Value = mProject._projID
                    End With
                    sqlCommand.ExecuteNonQuery()
                Next
            End If

            If Integer.Parse(txtEquityTerm.Text.Trim) > 0 Then
                For index As Integer = 0 To Integer.Parse(txtEquityTerm.Text.Trim) - 1
                    sql = "INSERT INTO `db_payment_collection` (`userid`, `type`, `due_date`, `amount`, `item_id`, `proj_id`) 
                    VALUES (@UserId, @TYPE, @DueDate, @Amount, @ItemId, @ProjId)"
                    sqlCommand = New MySqlCommand(sql, sqlConnection)
                    With sqlCommand
                        .CommandText = sql
                        .Parameters.Add("@UserId", MySqlDbType.Int64).Value = mProject._userID
                        .Parameters.Add("@TYPE", MySqlDbType.VarChar).Value = "EQ"
                        .Parameters.Add("@DueDate", MySqlDbType.Date).Value = DateAdd("m", index, dtpEquityStart.Value)
                        .Parameters.Add("@Amount", MySqlDbType.Double).Value = txtAmountEQ.Text.Trim
                        .Parameters.Add("@ItemId", MySqlDbType.Int64).Value = mProject._itemID
                        .Parameters.Add("@ProjId", MySqlDbType.Int64).Value = mProject._projID
                    End With
                    sqlCommand.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        loadDueDate()
        'Me.Close()
    End Sub

    Private Sub deleteCurrentDueDate()

        Connection()
        sql = "DELETE FROM `db_payment_collection` WHERE `userid`=@Userid AND `item_id`=@ItemId AND `proj_id`=@ProjId"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Userid", MySqlDbType.Int64).Value = mProject._userID
            sqlCommand.Parameters.Add("@ItemId", MySqlDbType.Int64).Value = mProject._itemID
            sqlCommand.Parameters.Add("@ProjId", MySqlDbType.Int64).Value = mProject._projID
            sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("DELETE Official Reciept ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpEquityStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpEquityStart.ValueChanged
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            If Int32.Parse(txtEquityTerm.Text) = 0 Then
            Else
                dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(Int32.Parse(txtEquityTerm.Text) - 1)
            End If
        End If
    End Sub

    Private Sub txtEquityTerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEquityTerm.KeyUp
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            If Int32.Parse(txtEquityTerm.Text) = 0 Then
            Else
                dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(Int32.Parse(txtEquityTerm.Text) - 1)
            End If

            dtpMonthlyStart.Value = dtpEquityEnd.Value.AddMonths(1)
        End If
    End Sub

    Private Sub txtMATerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMATerm.KeyUp
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            If Int32.Parse(txtMATerm.Text) = 0 Then
            Else
                dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(Int32.Parse(txtMATerm.Text) - 1)
            End If
        End If
    End Sub

    Private Sub dtpMonthlyStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthlyStart.ValueChanged
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            If Int32.Parse(txtMATerm.Text) = 0 Then
            Else
                dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(Int32.Parse(txtMATerm.Text) - 1)
            End If
        End If
    End Sub
    Private Sub dtpEquityEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEquityEnd.ValueChanged
        dtpMonthlyStart.Value = dtpEquityEnd.Value.AddMonths(1)
    End Sub
    Private Sub txtEquityTerm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEquityTerm.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMATerm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMATerm.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAmountEQ_LostFocus(sender As Object, e As EventArgs) Handles txtAmountEQ.LostFocus
        txtAmountEQ.Text = Double.Parse(txtAmountEQ.Text).ToString("N2")
    End Sub

    Private Sub txtAmountMA_LostFocus(sender As Object, e As EventArgs) Handles txtAmountMA.LostFocus
        txtAmountMA.Text = Double.Parse(txtAmountMA.Text).ToString("N2")
    End Sub

    Private Sub txtAmountMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountMA.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtAmountEQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountEQ.KeyPress
        txtAmountMA_KeyPress(sender, e)
    End Sub

    Private Sub txtAmountEQ_GotFocus(sender As Object, e As EventArgs) Handles txtAmountEQ.GotFocus
        txtAmountEQ.SelectAll()
    End Sub

    Private Sub txtAmountMA_GotFocus(sender As Object, e As EventArgs) Handles txtAmountMA.GotFocus
        txtAmountMA.SelectAll()
    End Sub

    Private Sub txtAmountMA_Click(sender As Object, e As EventArgs) Handles txtAmountMA.Click
        txtAmountMA.SelectAll()
    End Sub

    Private Sub txtAmountEQ_Click(sender As Object, e As EventArgs) Handles txtAmountEQ.Click
        txtAmountEQ.SelectAll()
    End Sub

    Private Sub loadDueDate()
        Connection()
        sql = "SELECT `userid`, `type`, `due_date`, `amount` FROM `db_payment_collection` WHERE userid=@UserId ORDER BY `due_date`, `type`"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@UserId", MySqlDbType.Int64).Value = mProject._userID
            sqlDataReader = sqlCommand.ExecuteReader()

            Dim item As ListViewItem
            ListView1.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("userid").ToString)
                item.UseItemStyleForSubItems = False
                Dim price As Double = sqlDataReader("amount")
                item.SubItems.Add(sqlDataReader("type"))
                item.SubItems.Add(sqlDataReader("due_date"))
                item.SubItems.Add(price.ToString("N2"))
                ListView1.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
End Class