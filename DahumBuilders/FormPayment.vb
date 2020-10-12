Imports MySql.Data.MySqlClient

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
        setDataGridView()
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

            Dim item As ListViewItem
            For i As Integer = 0 To table.Rows.Count - 1
                item = New ListViewItem(table.Rows(i)("item_id").ToString)
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

            For a As Integer = 1 To 1
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

        'DataGridView1.Columns.Add("", "Desciption")  0
        'DataGridView1.Columns.Add("", "TCP")   1
        'DataGridView1.Columns.Insert(2, cbb)   2
        'DataGridView1.Columns.Insert(3, cbbDownpayment) 3
        'DataGridView1.Columns.Add("", "Downpayment Amount") 4
        'DataGridView1.Columns.Insert(5, cbbDiscount) 5
        'DataGridView1.Columns.Add("", "Discount Amount") 6
        'DataGridView1.Columns.Add("", "ItemID") 7
        'DataGridView1.Columns.Add("", "ProjectID") 8

        Select Case e.ColumnIndex
            Case 2 'ComoboBox Particular
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = "50" 'cbbDownpayment
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0" 'cbbDiscount

                Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                    Case "Downpayment"
                        DataGridView1.Rows(e.RowIndex).Cells(4).Value = (Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                        tcp = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                        discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100
                        DataGridView1.Rows(e.RowIndex).Cells(6).Value = (tcp * discount).ToString("N2")
                        DataGridView1.Columns(3).Visible = True
                        DataGridView1.Columns(4).Visible = True
                        Console.WriteLine("Downpayment")
                    Case "Equity"
                        Console.WriteLine("Equity")
                    Case "Monthly"
                        Console.WriteLine("Monthly")
                    Case "Reservation"
                        Console.WriteLine("Reservation")
                    Case "Cash"
                        Console.WriteLine("Cash")
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(4).Visible = False
                End Select
            Case 3 'ComoboBox Downpayment
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0" 'cbbDiscount
                downpamentAmount = Double.Parse(Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100)
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
            Case 4 'Textbox downpayment Amount
                downpamentAmount = Double.Parse(Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100)
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = (downpamentAmount).ToString("N2") ''Downpayment Amount
            Case 5
                Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value
                    Case "Downpayment"
                        downpamentAmount = DataGridView1.Rows(e.RowIndex).Cells(4).Value 'Downpayment Amount
                        discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                        DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                    Case "Cash"
                        tcp = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value) 'tcp
                        discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                        DataGridView1.Rows(e.RowIndex).Cells(6).Value = (tcp * discount).ToString("N2") 'Discount Amount
                End Select
        End Select
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

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(0, row.Index), DataGridViewComboBoxCell)
                Console.WriteLine(row.Index & ". " & row.Cells(0).Value.ToString & " Tag: " & c.Items.IndexOf(c.Value) & " ," & row.Cells(1).Value)
            End If
        Next
    End Sub
    Private Sub ListViewUserItem_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewUserItem.KeyUp
        Dim itemID As String = ""
        Dim name As String = ""
        Dim block As String = ""
        Dim lot As String = ""
        Dim sqm As String = ""
        Dim tcp As String = ""
        Dim projID As String = ""
        Dim description As String = ""

        If e.KeyCode = Keys.KeyCode.Enter Then
            If ListViewUserItem.Items.Count > 0 Then
                itemID = ListViewUserItem.SelectedItems.Item(0).Text
                name = ListViewUserItem.SelectedItems.Item(0).SubItems(1).Text
                block = ListViewUserItem.SelectedItems.Item(0).SubItems(2).Text
                lot = ListViewUserItem.SelectedItems.Item(0).SubItems(3).Text
                sqm = ListViewUserItem.SelectedItems.Item(0).SubItems(4).Text
                tcp = ListViewUserItem.SelectedItems.Item(0).SubItems(5).Text
                projID = ListViewUserItem.SelectedItems.Item(0).SubItems(6).Text
                description = name & " " & block & " " & lot & " " & sqm
                addPurchaseItem(itemID, projID, tcp, description)
                Console.WriteLine("ID " & itemID & " - " & name & " " & block & " " & lot & " " & sqm & " " & tcp & " " & projId)
            End If
        End If

        'item = New ListViewItem(table.Rows(i)("id").ToString)
        'item.SubItems.Add(table.Rows(i)("proj_name"))
        'item.SubItems.Add(table.Rows(i)("block"))
        'item.SubItems.Add(table.Rows(i)("lot"))
        'item.SubItems.Add(table.Rows(i)("sqm"))
        'item.SubItems.Add(String.Format("{0:n}", table.Rows(i)("price")))
        'item.SubItems.Add(table.Rows(i)("proj_id"))
    End Sub

    Private Sub addPurchaseItem(itemID As String, projID As String, tcp As String, description As String)

        Dim id = DataGridView1.Rows.Add
        Dim row As DataGridViewRow = DataGridView1.Rows(id)

        row.Cells(0).Value = description
        row.Cells(1).Value = Double.Parse(tcp).ToString("N2")

        Dim comboBoxCell As DataGridViewComboBoxCell = DirectCast(row.Cells(2), DataGridViewComboBoxCell)
        comboBoxCell.Value = "Downpayment"

        Dim cbcDownpayment As DataGridViewComboBoxCell = DirectCast(row.Cells(3), DataGridViewComboBoxCell)
        cbcDownpayment.Value = "50"

        row.Cells(4).Value = (Double.Parse(row.Cells(1).Value) * (Double.Parse(cbcDownpayment.Value) / 100)).ToString("N2")

        Dim cbcDiscount As DataGridViewComboBoxCell = DirectCast(row.Cells(5), DataGridViewComboBoxCell)
        cbcDiscount.Value = "0"

        row.Cells(6).Value = (Double.Parse(row.Cells(4).Value) * Double.Parse(cbcDiscount.Value) / 100).ToString("N2")
        row.Cells(7).Value = itemID
        row.Cells(8).Value = projID

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True

        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False

    End Sub
    Private Sub setDataGridView()
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
        DataGridView1.Columns.Add("", "Lot Desciption")
        DataGridView1.Columns.Add("", "TCP")
        DataGridView1.Columns.Insert(2, cbb)
        DataGridView1.Columns.Insert(3, cbbDownpayment)
        DataGridView1.Columns.Add("", "Downpayment Amount")
        DataGridView1.Columns.Insert(5, cbbDiscount)
        DataGridView1.Columns.Add("", "Discount Amount")
        DataGridView1.Columns.Add("", "ItemID")
        DataGridView1.Columns.Add("", "ProjectID")

        With DataGridView1
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With DataGridView1
            .Columns(0).Width = 150
            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 100
        End With
    End Sub

End Class