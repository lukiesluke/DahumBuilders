Imports MySql.Data.MySqlClient

Module ModuleForm
    Public mFormUserProfile As New FormUserProfile
    Public mFormUserList As New FormUserList
    Public mFormImageCapture As FormImageCapture
    Public mFormPayment As FormPayment
    Public mFormProjectList As FormProjectList
    Public mFormRptTransaction As FormRptTransaction
    Public mFormCRptTransaction As FormCRptTransaction
    Public mFormAddProjectSetting As FormAddProjectSetting
    Public mFormSalesReport As FormCRptSalesReport

    Public Function computePercentage(totalPrice As Double, value As ComboBox) As Double
        Dim percentageDownpayment As Double = Double.Parse(value.Text) / 100
        Return totalPrice * percentageDownpayment
    End Function

    Public Function toDouble(control As Label) As Double
        Return Double.Parse(control.Text.Trim())
    End Function

    Public Function toDouble(control As TextBox) As Double
        Return Double.Parse(control.Text.Trim())
    End Function

    Public Function toDouble(control As ComboBox) As Double
        Return Double.Parse(control.Text)
    End Function

    Public Function downpaymentAmount(particular As ComboBox, dp As Label, equityAmount As TextBox) As Double
        Dim value As Double = 0
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = toDouble(dp)
            Case 1 'Equity
                value = toDouble(equityAmount)
        End Select
        Return value
    End Function

    Public Function BalanceMonthToPay(particular As ComboBox, dp As ComboBox, equityAmount As ComboBox) As String
        Dim value As String = ""
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = dp.Text.Trim()
            Case 1 'Equity
                value = equityAmount.Text.Trim()
        End Select
        Return value
    End Function

    Public Function monthlyAmortization(particular As ComboBox, dp As Label, equityAmount As Label) As Double
        Dim value As Double = 0
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = toDouble(dp)
            Case 1 'Equity
                value = toDouble(equityAmount)
        End Select
        Return value
    End Function

    Public Function getClientBalance(ByVal clientId As String, ByRef proj As Project) As Double
        Connection()
        Dim totalBalance As Double = 0
        Try
            sql = "SELECT `tcp`, (`tcp`-SUM(`paid_amount`)-SUM(`discount_amount`)) AS 'Balance' 
                   FROM `db_transaction` WHERE `userid`=@userId AND `proj_id`=@ProjId AND `proj_itemId`=@ProjItemId"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            With sqlCommand
                .CommandText = sql
                .Parameters.Add("@userId", MySqlDbType.Int64).Value = clientId
                .Parameters.Add("@ProjId", MySqlDbType.VarChar).Value = proj._projID
                .Parameters.Add("@ProjItemId", MySqlDbType.VarChar).Value = proj._itemID
            End With
            Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
            While sqlReader.Read()
                If Not IsDBNull(sqlReader("Balance")) Then
                    totalBalance = sqlReader("Balance")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Client Balance: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        Return totalBalance
    End Function
    Public Function getPaymentMethod(ByVal itemId As String, ByVal userid As String) As Dictionary(Of String, PaymentMethod)
        Dim values As Dictionary(Of String, PaymentMethod) = New Dictionary(Of String, PaymentMethod)
        Connection()
        Try
            sql = "SELECT m.`type`, m.`monthly`, m.`terms`, m.`start_date`, m.`end_date` FROM `db_payment_method` m WHERE m.`item_id`=@ItemId AND m.`userid`=@Userid"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            With sqlCommand
                .CommandText = sql
                .Parameters.Add("@ItemId", MySqlDbType.Int64).Value = itemId
                .Parameters.Add("@Userid", MySqlDbType.Int64).Value = userid
            End With
            Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
            While sqlReader.Read()
                Dim pm As PaymentMethod = New PaymentMethod
                pm._type = sqlReader("type")
                pm._monthly = sqlReader("monthly")
                pm._term = sqlReader("terms")
                If Not IsDBNull(sqlReader("start_date")) Then
                    pm._startDate = sqlReader("start_date")
                Else
                    pm._term = 0
                End If
                If Not IsDBNull(sqlReader("end_date")) Then
                    pm._endDate = sqlReader("end_date")
                Else
                    pm._term = 0
                End If
                values.Add(pm._type, pm)
            End While
        Catch ex As Exception
            MessageBox.Show("Client Balance: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        Return values
    End Function
    Public Sub EnableDataGridViewCell(ByVal dataGridView As DataGridView, e As DataGridViewCellEventArgs)
        With dataGridView.Rows(e.RowIndex).Cells(9) 'Penalty
            .ReadOnly = False
            .Style.ForeColor = Color.Red
            .Style.BackColor = Color.White
        End With
        With dataGridView.Rows(e.RowIndex).Cells(10) 'Part
            .ReadOnly = False
            .Style.BackColor = Color.White
        End With
    End Sub
    Public Sub DisableDataGridViewCell(ByVal dataGridView As DataGridView, e As DataGridViewCellEventArgs)
        With dataGridView.Rows(e.RowIndex).Cells(9) 'Penalty
            .ReadOnly = False
            .Style.ForeColor = Color.Black
            .Style.BackColor = Color.LightGray
            .Value = 0.ToString("N2")
        End With
        With dataGridView.Rows(e.RowIndex).Cells(10) 'Part
            .ReadOnly = True
            .Style.BackColor = Color.LightGray
            .Value = 0
        End With
        With dataGridView.Rows(e.RowIndex).Cells(4) 'Downpayment amount
            .ReadOnly = True
        End With
    End Sub

    Public Function UpdatePaymetMethod(ByVal proj As Project, type As String, monthly As Double, term As Integer, startDate As Date, endDate As Date) As Integer
        Dim result As Integer = 0
        Connection()
        Try
            sql = "UPDATE `db_payment_method` SET `monthly`=@monthly, `terms`=@term, `start_date`=@StartDate, `end_date`=@EndDate
            WHERE `item_id`=@ItemID AND `userid`=@UserID AND `type` LIKE @Type"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            With sqlCommand
                .CommandText = sql
                .Parameters.Add("@ItemID", MySqlDbType.Int64).Value = proj._itemID
                .Parameters.Add("@UserID", MySqlDbType.Int64).Value = proj._userID
                .Parameters.Add("@Type", MySqlDbType.VarChar).Value = type
                .Parameters.Add("@monthly", MySqlDbType.Double).Value = monthly
                .Parameters.Add("@term", MySqlDbType.Int24).Value = term
                .Parameters.Add("@StartDate", MySqlDbType.Date).Value = startDate
                .Parameters.Add("@EndDate", MySqlDbType.Date).Value = endDate
            End With
            If sqlCommand.ExecuteNonQuery() > 0 Then
                result = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        Return result
    End Function
End Module
