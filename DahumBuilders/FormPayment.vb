Imports MySql.Data.MySqlClient

Public Class FormPayment
    Dim userId As String = ""
    Dim userName As String = ""
    Dim userAddress As String = ""
    Dim sumOfTotalContractPrice As Double = 0
    Dim comboBoxColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn


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
        setPartVisibility()
        load_userId_info_data_reader()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub load_userId_info_data_reader()


        sql = "SELECT * FROM `db_project_list` INNER JOIN `db_project_item` ON 
        db_project_list.`id`=db_project_item.`proj_id` WHERE `db_project_item`.`assigned_userid` = @userId"

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

            'For i As Integer = 0 To table.Rows.Count - 1
            '    DataGridClientList.Rows.Add()
            '    DataGridClientList.Rows(i).Cells(0).Value = table.Rows(i).ItemArray(0)
            '    DataGridClientList.Rows(i).Cells(1).Value = table.Rows(i).ItemArray(1)
            '    DataGridClientList.Rows(i).Cells(2).Value = table.Rows(i).ItemArray(2)
            '    DataGridClientList.Rows(i).Cells(3).Value = table.Rows(i).ItemArray(3)
            '    DataGridClientList.Rows(i).Cells(4).Value = table.Rows(i).ItemArray(4)

            '    'Set the Default Value as the Selected Value.
            '    comboBoxCell.Value = "Select Country"

            '    Dim comboBoxCell As New DataGridViewComboBoxCell
            '    comboBoxCell.Items.Add("Select Country")
            '    For cb As Integer = 0 To table.Rows.Count - 1
            '        comboBoxCell.Items.Add(table.Rows(i).ItemArray(5))
            '    Next
            '    comboBoxCell.Value = 0
            '    'Dim cell As DataGridViewComboBoxCell = DirectCast(DataGridClientList.Rows(i).Cells(5), DataGridViewComboBoxCell)
            '    'cell.Value = "18"

            'Next

            Dim item As ListViewItem
            For i As Integer = 0 To table.Rows.Count - 1
                item = New ListViewItem(table.Rows(i)("id").ToString)
                item.SubItems.Add(table.Rows(i)("proj_name"))
                item.SubItems.Add(table.Rows(i)("block"))
                item.SubItems.Add(table.Rows(i)("lot"))
                item.SubItems.Add(table.Rows(i)("sqm"))
                item.SubItems.Add(String.Format("{0:n}", table.Rows(i)("price")))
                item.SubItems.Add(table.Rows(i)("proj_id"))
                ListViewUserItem.Items.Add(item)
            Next

            sumOfTotalContractPrice = Convert.ToDouble(table.Compute("SUM(price)", "id > 0"))
            lblDownpaymentAmount.Text = sumOfTotalContractPrice.ToString("N2")

            For a As Integer = 0 To 1
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
        setPartVisibility()
    End Sub

    Private Sub setPartVisibility()
        If cbParticular.SelectedIndex > 0 And cbParticular.SelectedIndex < 3 Then
            lblPart.Visible = True
            txtPart.Visible = True
        Else
            lblPart.Visible = False
            txtPart.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comboBoxColumn.HeaderText = "Country"
        comboBoxColumn.Width = 100
        comboBoxColumn.Name = "ComboIto"
        'DataGridClientList.Columns.Add(comboBoxColumn)

        Dim cbb As New DataGridViewComboBoxColumn() With {.HeaderText = "Particular"}
        cbb.Items.Add("Downpayment")
        cbb.Items.Add("Equity")
        cbb.Items.Add("Monthly")
        cbb.Items.Add("Reservation")
        cbb.Items.Add("Cash")

        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Insert(0, cbb)
        DataGridView1.Columns.Add("Amount.", "Amount")
        DataGridView1.Columns.Add("assa.", "assa")


        'Dim comboBoxCell As DataGridViewComboBoxCell = CType(row.Cells(0), DataGridViewComboBoxCell)
        DataGridView1.Rows.Add()
        Dim comboBoxCell As DataGridViewComboBoxCell = DirectCast(DataGridView1.Rows(0).Cells(0), DataGridViewComboBoxCell)
        comboBoxCell.Value = "Downpayment"
        DataGridView1.Rows(0).Cells(1).Value = "Dooooooo"
        DataGridView1.Rows(0).Cells(2).Value = "asass"
        DataGridView1.Columns(2).ReadOnly = True

    End Sub

    Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove
        Dim ht As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)

        ' Can use this to auto-activate the control
        If Not ht Is DataGridView.HitTestInfo.Nowhere Then
            If ht.ColumnIndex >= 0 AndAlso ht.ColumnIndex < dataGridView1.Columns.Count Then
                Dim col As DataGridViewColumn = DataGridView1.Columns(ht.ColumnIndex)

                If TypeOf (col) Is DataGridViewComboBoxColumn Then
                    If Not ht.RowIndex = DataGridView1.NewRowIndex AndAlso ht.RowIndex >= 0 _
                        AndAlso ht.RowIndex < DataGridView1.RowCount Then
                        DataGridView1.CurrentCell = DataGridView1.Rows(ht.RowIndex).Cells(ht.ColumnIndex)
                        DataGridView1.BeginEdit(True)
                    End If
                End If

                If TypeOf (col) Is DataGridViewTextBoxColumn Then
                    If Not ht.RowIndex = DataGridView1.NewRowIndex AndAlso ht.RowIndex >= 0 _
                        AndAlso ht.RowIndex < DataGridView1.RowCount Then
                        DataGridView1.CurrentCell = DataGridView1.Rows(ht.RowIndex).Cells(ht.ColumnIndex)
                        DataGridView1.BeginEdit(True)
                    End If
                End If
            End If
        End If
    End Sub
End Class