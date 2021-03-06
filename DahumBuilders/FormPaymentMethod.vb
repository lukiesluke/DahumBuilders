﻿Imports MySql.Data.MySqlClient

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
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If UpdatePaymetMethod(mProject, "EQ", txtAmountEQ.Text, txtEquityTerm.Text, dtpEquityStart.Value, dtpEquityEnd.Value) = 1 Then
            If UpdatePaymetMethod(mProject, "MA", txtAmountMA.Text, txtMATerm.Text, dtpMonthlyStart.Value, dtpMonthlyEnd.Value) = 1 Then
                MessageBox.Show("Successfully Updated.")
                mFormPayment.load_userId_info_data_reader()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpEquityStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpEquityStart.ValueChanged
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(txtEquityTerm.Text)
        End If
    End Sub

    Private Sub txtEquityTerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEquityTerm.KeyUp
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(txtEquityTerm.Text)

            dtpMonthlyStart.Value = dtpEquityEnd.Value.AddMonths(1)
        End If
    End Sub

    Private Sub txtMATerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMATerm.KeyUp
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(txtMATerm.Text)
        End If
    End Sub

    Private Sub dtpMonthlyStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthlyStart.ValueChanged
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(txtMATerm.Text)
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

End Class