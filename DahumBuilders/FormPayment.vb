Imports MySql.Data.MySqlClient

Public Class FormPayment
    Public Property userId As String = ""
    Public Property userName As String = ""
    Public Property userAddress As String = ""
    Dim sumOfTotalContractPrice As Double = 0
    Dim cbb As New DataGridViewComboBoxColumn() With {.HeaderText = "Particular", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDownpayment As New DataGridViewComboBoxColumn() With {.HeaderText = "Downpayment", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDiscount As New DataGridViewComboBoxColumn() With {.HeaderText = "Discount", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}

    Public Sub ShowForm(id As String, name As String, address As String)
        userId = id
        userName = name
        userAddress = address
        Me.ShowDialog()
    End Sub

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2) - 80
        'Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2) - 120
        Me.Size = New Size(1024, 670)
        lblName.Text = userName
        lblAddress.Text = userAddress

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
            For a As Integer = 1 To 1
                item = New ListViewItem(String.Empty)
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

    Private Sub txtAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txtMonthOf_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove
        Dim ht As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)

        ' Can use this to auto-activate the control
        If Not ht Is DataGridView.HitTestInfo.Nowhere Then
            If ht.ColumnIndex >= 0 AndAlso ht.ColumnIndex < DataGridView1.Columns.Count Then
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

        'With DataGridView1
        '    .Columns(0).Width = 150
        '    .Columns(1).Width = 90 'TCP
        '    .Columns(2).Width = 100
        '    .Columns(3).Width = 100
        '    .Columns(4).Width = 90 'Downpayment Amount
        '    .Columns(5).Width = 80
        '    .Columns(6).Width = 115 'Discount Amount
        '    .Columns(7).Width = 50 'ItemID
        '    .Columns(8).Width = 50 'ProjectID
        '    .Columns(9).Width = 90 'Monthly
        '    .Columns(10).Width = 50 'Part
        '    .Columns(11).Width = 110 'Amount to Pay
        'End With

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
                        DataGridView1.Columns(3).Visible = True 'cbb Downpayment
                        DataGridView1.Columns(4).Visible = True 'Downpayment Amount
                        DataGridView1.Columns(9).Visible = True 'Monthly
                        DataGridView1.Columns(10).Visible = True 'Part
                        Console.WriteLine("Downpayment")
                    Case "Equity"
                        Console.WriteLine("Equity")
                    Case "Monthly"
                        Console.WriteLine("Monthly")
                    Case "Reservation"
                        Console.WriteLine("Reservation")
                    Case "Cash"
                        Console.WriteLine("Cash")
                        DataGridView1.Columns(3).Visible = False 'cbb Downpayment
                        DataGridView1.Columns(4).Visible = False 'Downpayment Amount
                        DataGridView1.Columns(9).Visible = False 'Monthly
                        DataGridView1.Columns(10).Visible = False 'Part
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
        If DataGridView1.CurrentCell.ColumnIndex = 9 Or DataGridView1.CurrentCell.ColumnIndex = 10 Then 'Part
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtMonthOf_KeyPress
        End If
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        'CurrentCellDirtyStateChanged event and force a commit edit on the grid
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub ListViewUserItem_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewUserItem.KeyUp
        Dim project As Project = New Project()
        If e.KeyCode = Keys.KeyCode.Enter Then
            If ListViewUserItem.Items.Count > 0 And ListViewUserItem.SelectedItems.Item(0).Text IsNot String.Empty Then
                project.itemID = ListViewUserItem.SelectedItems.Item(0).Text
                project.name = ListViewUserItem.SelectedItems.Item(0).SubItems(1).Text
                project.block = ListViewUserItem.SelectedItems.Item(0).SubItems(2).Text
                project.lot = ListViewUserItem.SelectedItems.Item(0).SubItems(3).Text
                project.sqm = ListViewUserItem.SelectedItems.Item(0).SubItems(4).Text
                project.tcp = ListViewUserItem.SelectedItems.Item(0).SubItems(5).Text
                project.projID = ListViewUserItem.SelectedItems.Item(0).SubItems(6).Text
                project.description = project.name & " " & project.block & " " & project.lot & " " & project.sqm
                addPurchaseItem(project)
                Console.WriteLine("ID " & project.itemID & " - " & project.name & " " & project.block & " " & project.lot & " " & project.sqm & " " & project.tcp & " " & project.projID)
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

    Private Sub addPurchaseItem(ByVal project As Project)

        If DataGridView1.Rows.Count > 0 Then
            For Each dRow As DataGridViewRow In DataGridView1.Rows
                If dRow.Cells(7).Value.Equals(project.itemID) And dRow.Cells(8).Value.Equals(project.projID) Then
                    Console.WriteLine(String.Format("Already exist Project ID {0} and ItemID {1}", project.projID, project.itemID))
                    Exit Sub
                End If
            Next
        End If

        Dim id = DataGridView1.Rows.Add
        Dim row As DataGridViewRow = DataGridView1.Rows(id)

        row.Cells(0).Value = project.description
        row.Cells(1).Value = Double.Parse(project.tcp).ToString("N2")

        Dim comboBoxCell As DataGridViewComboBoxCell = DirectCast(row.Cells(2), DataGridViewComboBoxCell)
        comboBoxCell.Value = "Downpayment"

        Dim cbcDownpayment As DataGridViewComboBoxCell = DirectCast(row.Cells(3), DataGridViewComboBoxCell)
        cbcDownpayment.Value = "50"

        row.Cells(4).Value = (Double.Parse(row.Cells(1).Value) * (Double.Parse(cbcDownpayment.Value) / 100)).ToString("N2")

        Dim cbcDiscount As DataGridViewComboBoxCell = DirectCast(row.Cells(5), DataGridViewComboBoxCell)
        cbcDiscount.Value = "0"

        row.Cells(6).Value = (Double.Parse(row.Cells(4).Value) * Double.Parse(cbcDiscount.Value) / 100).ToString("N2")
        row.Cells(7).Value = project.itemID
        row.Cells(8).Value = project.projID
        row.Cells(9).Value = 0.ToString("N2")

    End Sub
    Private Sub setDataGridView()

        With cbb
            .Items.Add("Downpayment")
            .Items.Add("Equity")
            .Items.Add("Monthly")
            .Items.Add("Cash")
            .Items.Add("Reservation")
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
        DataGridView1.Columns.Add("", "Monthly")
        DataGridView1.Columns.Add("", "Part")
        DataGridView1.Columns.Add("", "Amount to Pay")

        With DataGridView1
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        With DataGridView1
            .Columns(0).Width = 150
            .Columns(1).Width = 90 'TCP
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 90 'Downpayment Amount
            .Columns(5).Width = 70
            .Columns(6).Width = 115 'Discount Amount
            .Columns(7).Width = 50 'ItemID
            .Columns(8).Width = 50 'ProjectID
            .Columns(9).Width = 90 'Monthly
            .Columns(10).Width = 50 'Part
            .Columns(11).Width = 110 'Amount to Pay
        End With

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        DataGridView1.Columns(9).ReadOnly = True
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        CType(DataGridView1.Columns(10), DataGridViewTextBoxColumn).MaxInputLength = 3
        CType(DataGridView1.Columns(11), DataGridViewTextBoxColumn).MaxInputLength = 20
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If txtOfficialReceipt.Text.Trim.Length < 1 Or txtOfficialReceipt.Text.Trim.Equals(String.Empty) Then
            Dim ret As DialogResult = MessageBox.Show(Me, "Please enter Official Receipt number.", "Official Receipt", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Select Case ret
                Case DialogResult.OK
                    txtOfficialReceipt.Text = String.Empty
                    txtOfficialReceipt.Focus()
                    Exit Sub
            End Select
        End If

        If cbPaymentType.SelectedIndex < 0 Then
            Dim ret As DialogResult = MessageBox.Show(Me, "Please select Payment type.", "Payment type", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Select Case ret
                Case DialogResult.OK
                    cbPaymentType.DroppedDown = True
                    cbPaymentType.Focus()
                    Exit Sub
            End Select
        End If

        If DataGridView1.Rows.Count() < 1 Then
            Dim ret As DialogResult = MessageBox.Show(Me, "Please enter project name.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Select Case ret
                Case DialogResult.OK
                    If ListViewUserItem.Items.Count > 0 Then
                        ListViewUserItem.Focus()
                        ListViewUserItem.Items(0).Selected = True
                        ListViewUserItem.Items(0).Focused = True
                    End If
                    Exit Sub
            End Select
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(11).Value Is Nothing Then
                row.DefaultCellStyle.BackColor = Color.MistyRose
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(11).Value Is Nothing Then
                Dim ret As DialogResult = MessageBox.Show(Me, "Please enter amount to pay.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Select Case ret
                    Case DialogResult.OK
                        If DataGridView1.RowCount > 0 Then
                            DataGridView1.Focus()
                            row.Cells(11).Selected = True
                        End If
                End Select
                Exit Sub
            End If
            Dim trans As Transaction = New Transaction()
            Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(2, row.Index), DataGridViewComboBoxCell)
            trans._or = txtOfficialReceipt.Text.Trim
            trans._datePaid = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            trans._paidAmount = row.Cells(11).Value
            trans._tcp = row.Cells(1).Value
            trans._particular = c.Items.IndexOf(c.Value)
            trans._partNo = row.Cells(10).Value
            trans._paymentType = cbPaymentType.SelectedIndex
            trans._clientId = userId
            trans._projectItemId = row.Cells(7).Value
            trans._projectId = row.Cells(8).Value
            insertPurchase(trans)
        Next

        cbPaymentType.SelectedIndex = -1
        txtOfficialReceipt.Text = String.Empty
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(2, row.Index), DataGridViewComboBoxCell)
                Console.WriteLine(row.Index & ". " & row.Cells(2).Value.ToString & " Tag: " & c.Items.IndexOf(c.Value) & " ," & row.Cells(1).Value)
            End If
        Next
    End Sub

    Private Sub insertPurchase(ByVal trans As Transaction)
        sql = "INSERT INTO `db_transaction` (`official_receipt_no`, `date_paid`, `paid_amount`, `tcp`, `particular`, 
        `part_no`, `payment_type`, `userid`, `proj_id`, `proj_itemId`) VALUES (@OR, @DatePaid, @PaidAmount, @TCP, 
        @Particular, @PartNo, @PaymentType, @userid, @ProjId, @ProjItemId)"

        If trans._particular.Equals("0") Or trans._particular.Equals("3") Or trans._particular.Equals("4") Then
            trans._partNo = "0"
        End If

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OR", MySqlDbType.VarChar).Value = trans._or 'txtOfficialReceipt.Text.Trim
        sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(trans._datePaid, "yyyy-MM-dd").ToString 'Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = trans._paidAmount 'txtPaidAmount.Text.Trim
        sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = trans._tcp
        sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int24).Value = trans._particular 'Integer.Parse(cbParticular.SelectedIndex)
        sqlCommand.Parameters.Add("@PartNo", MySqlDbType.Int24).Value = trans._partNo 'Integer.Parse(txtPart.Text)
        sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int24).Value = trans._paymentType 'cbPaymentType.SelectedIndex
        sqlCommand.Parameters.Add("@userid", MySqlDbType.Int24).Value = trans._clientId 'userId
        sqlCommand.Parameters.Add("@ProjId", MySqlDbType.Int24).Value = trans._projectId
        sqlCommand.Parameters.Add("@ProjItemId", MySqlDbType.Int24).Value = trans._projectItemId

        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
            Else
                MessageBox.Show(Me, "Data NOT Inserted. Please try again.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "ERROR: ", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionHistoryToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormRptTransaction).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormRptTransaction = New FormRptTransaction
            mFormRptTransaction.ShowForm(userId, userName, userAddress)
        End If
    End Sub
End Class