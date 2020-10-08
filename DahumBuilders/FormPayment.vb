Imports MySql.Data.MySqlClient

Public Class FormPayment
    Dim userId As String = ""
    Dim userName As String = ""
    Dim userAddress As String = ""
    Dim sumOfTotalContractPrice As Double = 0

    Public Sub ShowForm(id As String, name As String, address As String)
        userId = id
        userName = name
        userAddress = address
        Me.ShowDialog()
    End Sub

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        lblName.Text = userName
        lblAddress.Text = userAddress

        cbParticular.SelectedIndex = -1
        cbDownpayment.SelectedIndex = 0
        cbDiscount.SelectedIndex = 0

        btnConfirm.Enabled = False
        PanelDownpayment.Visible = False

        load_userId_info_data_reader()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub load_userId_info_data_reader()

        sql = "SELECT * FROM `db_project_list` INNER JOIN `db_project_item` ON 
        db_project_list.`id`=db_project_item.`pro_id` WHERE `db_project_item`.`assigned_userid` = @userId"

        Connection()
        Try
            Dim table As New DataTable()

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = userId
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim item As ListViewItem
            For i = 0 To table.Rows.Count - 1
                item = New ListViewItem(table.Rows(i)("id").ToString)
                item.SubItems.Add(table.Rows(i)("proj_name"))
                item.SubItems.Add(table.Rows(i)("block"))
                item.SubItems.Add(table.Rows(i)("lot"))
                item.SubItems.Add(table.Rows(i)("sqm"))
                item.SubItems.Add(String.Format("{0:n}", table.Rows(i)("price")))
                item.SubItems.Add(String.Format("{0:n}", table.Rows(i)("price")))
                ListViewUserItem.Items.Add(item)
            Next

            sumOfTotalContractPrice = Convert.ToDouble(table.Compute("SUM(price)", "id > 0"))
            lblDownpaymentAmount.Text = sumOfTotalContractPrice.ToString("N2")
            Dim a As Integer
            For a = 0 To 1
                item = New ListViewItem
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(String.Empty)
                item.SubItems.Add(String.Empty)
                item.SubItems.Add(String.Empty)
                If a > 0 Then
                    With item.SubItems.Add("Total")
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    With item.SubItems.Add(String.Format("{0:n}", sumOfTotalContractPrice))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                End If
                ListViewUserItem.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("User Information: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub btnSearchProject_Click(sender As Object, e As EventArgs) Handles btnSearchProject.Click
        If Application.OpenForms().OfType(Of FormProjectList).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormProjectList = New FormProjectList
            mFormProjectList.ShowDialog(Me)
        End If
    End Sub

    Private Sub cbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentType.SelectedIndexChanged
        If cbPaymentType.SelectedIndex > -1 Then
            btnConfirm.Enabled = True
        Else
            btnConfirm.Enabled = False
        End If
    End Sub

    Private Sub txtAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaidAmount.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub btnConfirm_Click_1(sender As Object, e As EventArgs) Handles btnConfirm.Click
        sql = "INSERT INTO `db_transaction` (`official_receipt_no`, `date_paid`, `paid_amount`, `tcp`, `particular`, 
        `part_no`, `payment_type`, `userid`) VALUES (@OR, @DatePaid, @PaidAmount, @TCP, @Particular, @PartNo, @PaymentType, @userid)"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OR", MySqlDbType.VarChar).Value = txtOfficialReceipt.Text.Trim
        sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = txtPaidAmount.Text.Trim
        sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = sumOfTotalContractPrice
        sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int24).Value = Integer.Parse(cbParticular.SelectedIndex)
        sqlCommand.Parameters.Add("@PartNo", MySqlDbType.Int24).Value = Integer.Parse(txtPart.Text)
        sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int24).Value = cbPaymentType.SelectedIndex
        sqlCommand.Parameters.Add("@userid", MySqlDbType.Int24).Value = userId
        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Successfully Saved")
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)

        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub txtMonthOf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPart.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbDownpayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDownpayment.SelectedIndexChanged
        If cbDownpayment.SelectedIndex < 0 Then
            lblDownpaymentAmount.Text = 0.ToString("N2")
            Exit Sub
        End If
        Dim percent As Double = Double.Parse(cbDownpayment.Text) / 100
        lblDownpaymentAmount.Text = ((sumOfTotalContractPrice) * percent).ToString("N2")
    End Sub

    Private Sub computePaymentDiscount()
        Dim percentDiscount As Double = Double.Parse(cbDiscount.Text) / 100
        lblDiscountAmount.Text = (Double.Parse(lblDownpaymentAmount.Text) * percentDiscount).ToString("N2")
        lblDPAmountToPay.Text = ((Double.Parse(lblDownpaymentAmount.Text) - Double.Parse(lblDiscountAmount.Text))).ToString("N2")
    End Sub
    Private Sub cbDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiscount.SelectedIndexChanged
        computePaymentDiscount()
    End Sub

    Private Sub cbParticular_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbParticular.SelectedIndexChanged
        Select Case cbParticular.SelectedIndex
            Case 0
                If PanelDownpayment.Visible = False Then
                    PanelDownpayment.Visible = True
                End If
            Case Else
                PanelDownpayment.Visible = False
        End Select
    End Sub
End Class