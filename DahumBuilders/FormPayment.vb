﻿Imports MySql.Data.MySqlClient

Public Class FormPayment
    Dim userId As String = ""
    Dim userName As String = ""
    Dim userAddress As String = ""
    Dim sumOfTotalContractPrice As Double = 0
    Dim cbb As New DataGridViewComboBoxColumn() With {.HeaderText = "Particular"}
    Dim cbbDownpayment As New DataGridViewComboBoxColumn() With {.HeaderText = "Downpayment"}
    Dim cbbDiscount As New DataGridViewComboBoxColumn() With {.HeaderText = "Discount"}


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

        With cbb
            .Items.Add("Downpayment")
            .Items.Add("Equity")
            .Items.Add("Monthly")
            .Items.Add("Reservation")
            .Items.Add("Cash")
        End With

        With cbbDownpayment
            .Items.Add("50")
            .Items.Add("60")
        End With

        With cbbDiscount
            .Items.Add("0")
            .Items.Add("5")
            .Items.Add("6")
            .Items.Add("7")
            .Items.Add("8")
            .Items.Add("9")
            .Items.Add("10")
            .Items.Add("11")
            .Items.Add("12")
            .Items.Add("13")
            .Items.Add("14")
            .Items.Add("15")
        End With

        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Insert(0, cbb)
        DataGridView1.Columns.Add("", "TCP")
        DataGridView1.Columns.Insert(2, cbbDownpayment)
        DataGridView1.Columns.Add("", "Downpayment Amount")
        DataGridView1.Columns.Insert(4, cbbDiscount)
        DataGridView1.Columns.Add("", "Discount Amount")

        With DataGridView1
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub ListViewUserItem_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewUserItem.KeyUp

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

        Dim id = DataGridView1.Rows.Add
        Dim row As DataGridViewRow = DataGridView1.Rows(id)

        Dim comboBoxCell As DataGridViewComboBoxCell = DirectCast(row.Cells(0), DataGridViewComboBoxCell)
        comboBoxCell.Value = "Downpayment"
        row.Cells(1).Value = (220000).ToString("N2")

        Dim cbcDownpayment As DataGridViewComboBoxCell = DirectCast(row.Cells(2), DataGridViewComboBoxCell)
        cbcDownpayment.Value = "50"

        row.Cells(3).Value = (Double.Parse(row.Cells(1).Value) * Double.Parse(cbcDownpayment.Value) / 100).ToString("N2")

        Dim cbcDiscount As DataGridViewComboBoxCell = DirectCast(row.Cells(4), DataGridViewComboBoxCell)
        cbcDiscount.Value = "0"
        row.Cells(4).Value = "0"
        row.Cells(5).Value = (Double.Parse(row.Cells(3).Value) * Double.Parse(cbcDiscount.Value) / 100).ToString("N2")

        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True

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

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim tcp As Double = 0
        Dim discount As Double = 0
        Dim downpamentAmount As Double = 0

        If e.ColumnIndex = 0 Then 'ComoboBox Particular
            If DataGridView1.Rows(e.RowIndex).Cells(0).Value.Equals("Downpayment") Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = (220000).ToString("N2")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = "50"
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = (Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(2).Value) / 100).ToString("N2")
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = "0"
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                tcp = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value) / 100
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = (tcp * discount).ToString("N2")
                'DataGridView1.Columns(1).Visible = True
                'DataGridView1.Columns(2).Visible = False
                DataGridView1.Rows(e.RowIndex).Cells(0).Tag = 0
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(0).Value.Equals("Equity") Then
                'DataGridView1.Rows(e.RowIndex).Cells(2).Value = "Equity"
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(0).Value.Equals("Monthly") Then
                'DataGridView1.Rows(e.RowIndex).Cells(2).Value = "Monthly"
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(0).Value.Equals("Reservation") Then
                'DataGridView1.Rows(e.RowIndex).Cells(2).Value = "Reservation"
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(0).Value.Equals("Cash") Then
                'DataGridView1.Rows(e.RowIndex).Cells(2).Value = DataGridView1.Rows(e.RowIndex).Cells(1).Tag
            End If
        ElseIf e.ColumnIndex = 2 Then 'ComoboBox Downpament
            DataGridView1.Rows(e.RowIndex).Cells(4).Value = "0"
            downpamentAmount = Double.Parse(Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(2).Value) / 100)
            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value) / 100

            DataGridView1.Rows(e.RowIndex).Cells(3).Value = downpamentAmount.ToString("N2")
            DataGridView1.Rows(e.RowIndex).Cells(5).Value = (downpamentAmount * discount).ToString("N2")
        ElseIf e.ColumnIndex = 3 Then 'Textbox downpament Amount
            downpamentAmount = Double.Parse(Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(2).Value) / 100)
            DataGridView1.Rows(e.RowIndex).Cells(3).Value = (downpamentAmount).ToString("N2")
        ElseIf e.ColumnIndex = 4 Then 'ComoboBox Discount
            downpamentAmount = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value) / 100
            DataGridView1.Rows(e.RowIndex).Cells(5).Value = (downpamentAmount * discount).ToString("N2")
        End If
        'DataGridView1.Columns.Insert(0, cbb)
        'DataGridView1.Columns.Add("", "Price")
        'DataGridView1.Columns.Insert(2, cbbDownpayment)
        'DataGridView1.Columns.Add("", "Downpayment Amount")
        'DataGridView1.Columns.Insert(4, cbbDiscount)
        'DataGridView1.Columns.Add("", "Discount Amount")
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(1).Tag = "hello world"
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        'Try
        '    Dim c As ComboBox = CType(e.Control, ComboBox)
        '    If e.Control Is c Then
        '        MessageBox.Show("DataGridView1.CurrentCell.RowIndex: " & DataGridView1.CurrentCell.RowIndex)

        '        MessageBox.Show("ComboBox: " & c.SelectedIndex)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        'CurrentCellDirtyStateChanged event and force a commit edit on the grid
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

End Class