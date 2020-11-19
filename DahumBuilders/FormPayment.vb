Imports MySql.Data.MySqlClient

Public Class FormPayment
    Public Property mUser As User = New User()
    Dim mProject As Project = New Project()
    Dim cbb As New DataGridViewComboBoxColumn() With {.HeaderText = "Particular", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDownpayment As New DataGridViewComboBoxColumn() With {.HeaderText = "Downpayment", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDiscount As New DataGridViewComboBoxColumn() With {.HeaderText = "Discount", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1114, 670)
        lblName.Text = mUser._name & " " & mUser._middleName & " " & mUser._surname
        lblAddress.Text = mUser._address
        lblContact.Text = mUser._mobile
        PanelCheck.Visible = False
        lblTotalAmount.Text = 0.ToString("N2")
        lblChange.Text = 0.ToString("N2")
        txtTenderedAmount.Text = 0.ToString("N2")
        DataGridView1.DefaultCellStyle.Font = New Font("Consolas", 9)
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.SplitterDistance = 190
        load_userId_info_data_reader()
        setDataGridView()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub load_userId_info_data_reader()
        sql = "SELECT i.`item_id`, i.`proj_id`, l.`proj_name`, l.`proj_address`, i.`block`, i.`lot`, i.`sqm`, i.`price`,
        IFNULL((SELECT (`tcp`-SUM(`paid_amount`))-SUM(`discount_amount`) FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`), i.`price`) AS 'totalBalance',
        IFNULL((SELECT SUM(`discount_amount`) FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`),0) AS 'totalDiscount',
        IFNULL((SELECT SUM(`penalty`) FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`),0) AS 'totalPenalty',
        IFNULL((SELECT SUM(`paid_amount`) FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`),0) AS 'totalPaidAmount',
        IFNULL((SELECT `monthly` FROM `db_payment_method` WHERE i.`item_id`=db_payment_method.`item_id` AND db_payment_method.`type`='EQ' AND i.`assigned_userid`=db_payment_method.`userid`),0) AS 'EQ',
        IFNULL((SELECT `monthly` FROM `db_payment_method` WHERE i.`item_id`=db_payment_method.`item_id` AND db_payment_method.`type`='MA' AND i.`assigned_userid`=db_payment_method.`userid`),0) AS 'MA'
        FROM `db_project_list` l INNER JOIN `db_project_item` i ON l.`id`=i.`proj_id` WHERE i.`assigned_userid`=@userId"
        ListViewUserItem.Items.Clear()
        Connection()
        Try
            Dim table As New DataTable()
            Dim project As Project

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With
            If table.Rows.Count < 1 Then
                GoTo FinallyLine
            End If

            Dim item As ListViewItem
            For i As Integer = 0 To table.Rows.Count - 1
                project = New Project()
                With project
                    ._itemID = table.Rows(i)("item_id")
                    ._projID = table.Rows(i)("proj_id")
                    ._name = table.Rows(i)("proj_name")
                    ._block = table.Rows(i)("block")
                    ._lot = table.Rows(i)("lot")
                    ._sqm = table.Rows(i)("sqm")
                    ._tcp = table.Rows(i)("price")
                    ._total_balance = table.Rows(i)("totalBalance")
                    ._total_discount = table.Rows(i)("totalDiscount")
                    ._total_penalty = table.Rows(i)("totalPenalty")
                    ._total_paidAmount = table.Rows(i)("totalPaidAmount")
                    ._equity = table.Rows(i)("EQ")
                    ._amortization = table.Rows(i)("MA")
                End With

                item = New ListViewItem(project._itemID)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(project._name)
                item.SubItems.Add(project._block)
                item.SubItems.Add(project._lot)
                item.SubItems.Add(project._sqm)
                item.SubItems.Add(project._tcp.ToString("N2"))
                item.SubItems.Add(project._projID)
                item.SubItems.Add(project._total_balance.ToString("N2"))
                item.SubItems.Add(project._total_discount.ToString("N2"))
                item.SubItems.Add(project._total_penalty.ToString("N2"))
                item.SubItems.Add(project._total_paidAmount.ToString("N2"))
                With item.SubItems.Add(project._equity.ToString("N2"))
                    .BackColor = Color.OldLace
                End With
                With item.SubItems.Add(project._amortization.ToString("N2"))
                    .BackColor = Color.LightSkyBlue
                End With
                ListViewUserItem.Items.Add(item)
            Next

            If ListViewUserItem.Items.Count > 1 Then
                For a As Integer = 1 To 1
                    item = New ListViewItem(String.Empty)
                    item.UseItemStyleForSubItems = False
                    item.SubItems.Add(String.Empty)
                    item.SubItems.Add(String.Empty)
                    item.SubItems.Add(String.Empty)
                    With item.SubItems.Add("Total")
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    With item.SubItems.Add(Convert.ToDouble(table.Compute("SUM(price)", "item_id > 0")).ToString("N2"))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    item.SubItems.Add((String.Empty))
                    With item.SubItems.Add(Convert.ToDouble(table.Compute("SUM(totalBalance)", "item_id > 0")).ToString("N2"))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    With item.SubItems.Add(Convert.ToDouble(table.Compute("SUM(totalDiscount)", "item_id > 0")).ToString("N2"))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    With item.SubItems.Add(Convert.ToDouble(table.Compute("SUM(totalPenalty)", "item_id > 0")).ToString("N2"))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    With item.SubItems.Add(Convert.ToDouble(table.Compute("SUM(totalPaidAmount)", "item_id > 0")).ToString("N2"))
                        .Font = New Font(ListViewUserItem.Font, FontStyle.Bold)
                        .ForeColor = Color.Red
                    End With
                    ListViewUserItem.Items.Add(item)
                Next
            End If
FinallyLine:
        Catch ex As Exception
            MessageBox.Show("User Information load: " & ex.Message)
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
            mFormProjectList.mUser = mUser
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
        Dim discount As Double = 0
        Dim downpamentAmount As Double = 0

        If DataGridView1.Rows.Count > 0 Then
            Dim p As Project = DirectCast(DataGridView1.Rows(e.RowIndex).Cells(12).Value, Project) 'Project class obkect
            Select Case e.ColumnIndex
                Case 2 'ComoboBox Particular
                    Dim cellDP As DataGridViewComboBoxCell = DataGridView1.Rows(e.RowIndex).Cells(3)
                    Dim cellDiscount As DataGridViewComboBoxCell = DataGridView1.Rows(e.RowIndex).Cells(5)
                    cellDP.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    cellDP.Style.BackColor = Color.LightGray
                    cellDP.ReadOnly = True

                    cellDiscount.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    cellDiscount.Style.BackColor = Color.LightGray
                    cellDiscount.ReadOnly = True

                    DisableDataGridViewCell(DataGridView1, e) 'Penalty and Part functionality
                    Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                        Case "Select"
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0" 'cbbDiscount
                        Case "Downpayment"
                            cellDP.Style.BackColor = Color.White
                            cellDP.ReadOnly = False
                            cellDiscount.Style.BackColor = Color.White
                            cellDiscount.ReadOnly = False
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "50" 'cbbDownpayment
                            If p._total_balance = 0 Then
                                downpamentAmount = (p._tcp * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                                DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                            ElseIf p._total_balance < 0 Then
                                DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0.ToString("N2") 'Downpayment Amount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2") 'Amount to pay
                            Else
                                downpamentAmount = (p._total_balance * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                                DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                            End If
                        Case "Equity"
                            Dim pm As New PaymentMethod
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            EnableDataGridViewCell(DataGridView1, e) 'Part
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._equity.ToString("N2") 'Amount to pay
                        Case "Monthly"
                            Dim pm As New PaymentMethod
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            EnableDataGridViewCell(DataGridView1, e) 'Part
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._amortization.ToString("N2") 'Amount to pay
                        Case "Reservation"
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2") 'Amount to pay
                        Case "Cash"
                            Dim ttSum As Double = p._total_discount + p._total_paidAmount
                            cellDiscount.Style.BackColor = Color.White
                            cellDiscount.ReadOnly = False

                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"

                            If p._total_balance <= 0 And ttSum <= 0 Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._tcp.ToString("N2") 'Amount to pay
                            End If

                            If p._total_balance <= 0 And ttSum >= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2")  'Amount to pay
                            End If

                            If p._total_balance >= 1 And ttSum <= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._total_balance.ToString("N2")
                            End If
                    End Select
                Case 3 'ComoboBox Downpayment
                    DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0" 'cbbDiscount
                    If DataGridView1.Rows(e.RowIndex).Cells(2).Value.Equals("Downpayment") And DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" Then
                        SetDataGridViewCell(DataGridView1, e, 4, False)
                    Else
                        SetDataGridViewCell(DataGridView1, e, 4, True)
                    End If
                    If p IsNot Nothing Then
                        If p._total_balance = 0 Then
                            downpamentAmount = (p._tcp * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount

                            DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._tcp * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        ElseIf p._total_balance < 0 Then
                        Else
                            downpamentAmount = (p._total_balance * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                            DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        End If
                    End If
                Case 4 'Discount Amount
                    Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                        Case "Downpayment"
                            If DataGridView1.Rows(e.RowIndex).Cells(4).Value IsNot Nothing Then
                                downpamentAmount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value).ToString("N2")
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                            End If
                    End Select
                Case 5 'ComboBox Discount
                    Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                        Case "Downpayment"
                            downpamentAmount = DataGridView1.Rows(e.RowIndex).Cells(4).Value 'Downpayment Amount
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        Case "Cash"
                            If p._total_balance < 1 And p._total_paidAmount < 1 Then
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._tcp * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (p._tcp - (p._tcp * discount)).ToString("N2") 'Amount to pay
                            ElseIf p._total_balance < 1 And p._total_paidAmount >= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2")
                            Else
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._total_balance * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (p._total_balance - (p._total_balance * discount)).ToString("N2") 'Amount to pay
                            End If
                    End Select
                Case 9 ' Penalty
                    If DataGridView1.Rows(e.RowIndex).Cells(9).Value IsNot Nothing Then
                        Dim penalty As Double = DataGridView1.Rows(e.RowIndex).Cells(9).Value
                        Dim amountToPay As Double = 0
                        Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                            Case "Equity"
                                amountToPay = (penalty + p._equity)
                            Case "Monthly"
                                amountToPay = (penalty + p._amortization)
                        End Select
                        DataGridView1.Rows(e.RowIndex).Cells(11).Value = amountToPay.ToString("N2") 'Amount to pay
                    End If
            End Select
            Dim totalAmountToPay As Double = 0
            For index As Integer = 0 To DataGridView1.RowCount - 1
                totalAmountToPay += Convert.ToDouble(DataGridView1.Rows(index).Cells(11).Value)
            Next
            lblTotalAmount.Text = totalAmountToPay.ToString("N2")
        End If
    End Sub

    Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        If e.ColumnIndex = 4 Then 'Downpayment Amount
            If DataGridView1.Rows(e.RowIndex).Cells(4).Value IsNot Nothing Then
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value).ToString("N2") 'Penalty Amount
            Else
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0.ToString("N2") 'Penalty Amount
            End If
        End If
        If e.ColumnIndex = 9 Then 'Penalty Amount
            If DataGridView1.Rows(e.RowIndex).Cells(9).Value IsNot Nothing Then
                DataGridView1.Rows(e.RowIndex).Cells(9).Value = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(9).Value).ToString("N2") 'Penalty Amount
            Else
                DataGridView1.Rows(e.RowIndex).Cells(9).Value = 0.ToString("N2") 'Penalty Amount
            End If
        End If
        If e.ColumnIndex = 10 Then 'Part
            If DataGridView1.Rows(e.RowIndex).Cells(10).Value Is Nothing Then
                DataGridView1.Rows(e.RowIndex).Cells(10).Value = 0 'Part
            End If
        End If
        If e.ColumnIndex = 13 Then 'Part
            If DataGridView1.Rows(e.RowIndex).Cells(13).Value IsNot Nothing Then
                DataGridView1.Rows(e.RowIndex).Cells(13).Value = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(13).Value).ToString("N2") 'Commission
            Else
                DataGridView1.Rows(e.RowIndex).Cells(13).Value = 0.ToString("N2") 'Commission
            End If
        End If
    End Sub
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = 4 Then 'Downpaymnet Amount
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtAmountPaid_KeyPress
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 9 Or DataGridView1.CurrentCell.ColumnIndex = 10 Then 'Part
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtMonthOf_KeyPress
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 13 Then 'Commission
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtAmountPaid_KeyPress
        End If
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        'CurrentCellDirtyStateChanged event and force a commit edit on the grid
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub addPurchaseItem(ByVal project As Project)

        If DataGridView1.Rows.Count > 0 Then
            For Each dRow As DataGridViewRow In DataGridView1.Rows
                If dRow.Cells(7).Value.Equals(project._itemID) And dRow.Cells(8).Value.Equals(project._projID) Then
                    Console.WriteLine(String.Format("Already exist Project ID {0} and ItemID {1}", project._projID, project._itemID))
                    Console.WriteLine(String.Format("EQ: {0} and Amortization: {1}", project._equity, project._amortization))
                    Exit Sub
                End If
            Next
        End If

        Dim id = DataGridView1.Rows.Add
        Dim row As DataGridViewRow = DataGridView1.Rows(id)

        row.Cells(0).Value = project._description
        row.Cells(1).Value = Double.Parse(project._tcp).ToString("N2")

        Dim comboBoxCell As DataGridViewComboBoxCell = DirectCast(row.Cells(2), DataGridViewComboBoxCell)
        comboBoxCell.Value = "Select"

        Dim cbcDownpayment As DataGridViewComboBoxCell = DirectCast(row.Cells(3), DataGridViewComboBoxCell)
        cbcDownpayment.Value = "0"

        row.Cells(4).Value = (Double.Parse(row.Cells(1).Value) * (Double.Parse(cbcDownpayment.Value) / 100)).ToString("N2")

        Dim cbcDiscount As DataGridViewComboBoxCell = DirectCast(row.Cells(5), DataGridViewComboBoxCell)
        cbcDiscount.Value = "0"

        row.Cells(6).Value = (Double.Parse(row.Cells(4).Value) * Double.Parse(cbcDiscount.Value) / 100).ToString("N2")
        row.Cells(7).Value = project._itemID
        row.Cells(8).Value = project._projID
        row.Cells(9).Value = 0.ToString("N2") 'Penalty Amount
        row.Cells(10).Value = 0 'Part
        row.Cells(12).Value = project 'ProjectClass
        row.Cells(13).Value = 0.ToString("N2") 'Commission
    End Sub
    Private Sub setDataGridView()

        With cbb
            .Items.Add("Select")
            .Items.Add("Downpayment")
            .Items.Add("Equity")
            .Items.Add("Monthly")
            .Items.Add("Cash")
            .Items.Add("Reservation")
        End With

        With cbbDownpayment
            .Items.Add("0")
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
        DataGridView1.Columns.Add("", "Penalty")
        DataGridView1.Columns.Add("", "Part")
        DataGridView1.Columns.Add("", "Amount to Pay")
        DataGridView1.Columns.Add("", "ProjectClass")
        DataGridView1.Columns.Add("", "Commission")

        With DataGridView1
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 100 'TCP
            .Columns(2).Width = 105 'cbb particular
            .Columns(3).Width = 100 'cbb Downpayment
            .Columns(4).Width = 140 'Downpayment Amount
            .Columns(5).Width = 70 'cbb discount
            .Columns(6).Width = 115 'Discount Amount
            .Columns(7).Width = 50 'ItemID
            .Columns(8).Width = 50 'ProjectID
            .Columns(9).Width = 75 'Penalty Amount
            .Columns(10).Width = 50 'Part
            .Columns(11).Width = 105 'Amount to Pay
            .Columns(13).Width = 105 'Commission
        End With

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        DataGridView1.Columns(11).ReadOnly = True
        DataGridView1.Columns(12).ReadOnly = True 'ProjectClass object

        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(12).Visible = False 'ProjectClass object

        CType(DataGridView1.Columns(10), DataGridViewTextBoxColumn).MaxInputLength = 3
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
                    End If
                    Exit Sub
            End Select
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cbbParticular As DataGridViewComboBoxCell = DirectCast(row.Cells(2), DataGridViewComboBoxCell)
            If cbbParticular.Items.IndexOf(cbbParticular.Value) = 0 Then
                MessageBox.Show(Me, "Please select particular from drop down list.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Question)
                DataGridView1.Focus()
                row.Cells(2).Selected = True
                Dim cell As DataGridViewComboBoxCell = DataGridView1.Rows(row.Index).Cells(2)
                If Not DataGridView1.IsCurrentCellInEditMode Then
                    DataGridView1.BeginEdit(True)
                    CType(DataGridView1.EditingControl, ComboBox).DroppedDown = True
                End If
                Exit Sub
            End If

            Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(2, row.Index), DataGridViewComboBoxCell)
            If c.Items.IndexOf(c.Value) = 2 Or c.Items.IndexOf(c.Value) = 3 Then
                If row.Cells(10).Value Is Nothing Then
                    MessageBox.Show(Me, "Please enter Part No. of Equity/Monthly Amortization.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    DataGridView1.Focus()
                    row.Cells(10).Selected = True
                    Exit Sub
                ElseIf row.Cells(10).Value = 0 Then
                    MessageBox.Show(Me, "Please enter Part No. of Equity/Monthly Amortization. Greater than Zero (0)", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    DataGridView1.Focus()
                    row.Cells(10).Selected = True
                    Exit Sub
                End If
            End If
        Next

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim trans As Transaction = New Transaction()
            Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(2, row.Index), DataGridViewComboBoxCell)
            trans._particular = c.Items.IndexOf(c.Value)
            trans._paymentType = cbPaymentType.SelectedIndex
            trans._clientId = mUser._id
            trans._or = txtOfficialReceipt.Text.Trim
            trans._datePaid = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            trans._tcp = row.Cells(1).Value
            trans._discountAmount = row.Cells(6).Value
            trans._projectItemId = row.Cells(7).Value
            trans._projectId = row.Cells(8).Value
            trans._penalty = row.Cells(9).Value 'Penalty
            trans._partNo = row.Cells(10).Value
            trans._paidAmount = row.Cells(11).Value 'Amount to Pay
            trans._check_bank_name = txtBankName.Text.Trim
            If cbPaymentType.SelectedIndex > 0 Then
                trans._check_bank_name = txtBankName.Text.Trim
                trans._check_number = txtCheckNo.Text.Trim
                trans._check_date = dtpCheckDate.Value
            End If
            trans._commission = row.Cells(13).Value
            insertPurchase(trans)
        Next

        cbPaymentType.SelectedIndex = -1
        txtOfficialReceipt.Text = String.Empty
        DataGridView1.Rows.Clear()
        load_userId_info_data_reader()
        MessageBox.Show(Me, "OR transaction successfully saved.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
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
        sql = "INSERT INTO `db_transaction` (`official_receipt_no`, `date_paid`, `paid_amount`, `discount_amount`, `penalty`, `commission`, `tcp`, `particular`, 
        `part_no`, `payment_type`, `check_bank_name`, `check_number`, `check_date`, `userid`, `proj_id`, `proj_itemId`) VALUES (@OR, @DatePaid, @PaidAmount, 
        @DiscountAmount, @Penalty, @Commission, @TCP, @Particular, @PartNo, @PaymentType, @CheckBankName, @CheckNumber, @CheckDate, @userid, @ProjId, @ProjItemId)"

        If trans._particular = 0 Or trans._particular = 1 Or trans._particular = 4 Or trans._particular = 5 Then
            trans._partNo = 0
        End If

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OR", MySqlDbType.VarChar).Value = trans._or
        sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(trans._datePaid, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = trans._paidAmount
        sqlCommand.Parameters.Add("@DiscountAmount", MySqlDbType.Double).Value = trans._discountAmount
        sqlCommand.Parameters.Add("@Penalty", MySqlDbType.Double).Value = trans._penalty
        sqlCommand.Parameters.Add("@Commission", MySqlDbType.Double).Value = trans._commission
        sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = trans._tcp
        sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int24).Value = trans._particular
        sqlCommand.Parameters.Add("@PartNo", MySqlDbType.Int24).Value = trans._partNo
        sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int24).Value = trans._paymentType
        sqlCommand.Parameters.Add("@userid", MySqlDbType.Int24).Value = trans._clientId 'userId
        sqlCommand.Parameters.Add("@ProjId", MySqlDbType.Int24).Value = trans._projectId
        sqlCommand.Parameters.Add("@ProjItemId", MySqlDbType.Int24).Value = trans._projectItemId

        sqlCommand.Parameters.Add("@CheckBankName", MySqlDbType.VarChar).Value = trans._check_bank_name
        sqlCommand.Parameters.Add("@CheckNumber", MySqlDbType.VarChar).Value = trans._check_number
        sqlCommand.Parameters.Add("@CheckDate", MySqlDbType.Date).Value = trans._check_date

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
        If Application.OpenForms().OfType(Of FormCRptTransaction).Any Then
            If mFormCRptTransaction.WindowState = 1 Then
                mFormCRptTransaction.WindowState = 0
            End If
        Else
            mFormCRptTransaction = New FormCRptTransaction
            mFormCRptTransaction.mUser = mUser
            mFormCRptTransaction.Show()
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If ListViewUserItem.Items.Count < 1 Or ListViewUserItem.SelectedItems.Item(0).Text Is String.Empty Then
            Exit Sub
        End If

        Dim projItemId As Int64 = ListViewUserItem.SelectedItems.Item(0).Text
        Dim rowsAffected As Integer = 0
        sql = "UPDATE `db_project_item` SET `assigned_userid`=0 WHERE `item_id`=@ItemId"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ItemId", MySqlDbType.Int32).Value = projItemId
            rowsAffected = sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Assigning" & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        If rowsAffected > 0 Then
            load_userId_info_data_reader()
        End If
    End Sub

    Private Sub ListViewUserItem_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewUserItem.MouseClick
        If ListViewUserItem.Items.Count > 0 And ListViewUserItem.SelectedItems.Item(0).Text IsNot String.Empty Then
            Dim totalPaid As Double = ListViewUserItem.SelectedItems.Item(0).SubItems(10).Text 'Paid Amount
            If totalPaid > 0 Then
                ContextMenuProjectList.Items(0).Enabled = False
            Else
                ContextMenuProjectList.Items(0).Enabled = True
            End If
            ContextMenuProjectList.Items(1).Enabled = True
        ElseIf ListViewUserItem.SelectedItems.Item(0).Text Is String.Empty Then
            ContextMenuProjectList.Items(0).Enabled = False
            ContextMenuProjectList.Items(1).Enabled = False
        End If
    End Sub

    Private Sub cbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentType.SelectedIndexChanged
        lblInformation.Text = String.Empty
        lblDateOrTransfer.Text = String.Empty
        txtCheckNo.Text = String.Empty
        txtBankName.Text = String.Empty
        Select Case cbPaymentType.SelectedIndex
            Case 1
                PanelCheck.Visible = True
                lblInformation.Text = "Check Information"
                lblDateOrTransfer.Text = "Date Check"
                lblCheckNo.Text = "Check Number"
            Case 2
                PanelCheck.Visible = True
                lblInformation.Text = "Bank Transfer Information"
                lblDateOrTransfer.Text = "Date Transfer"
                lblCheckNo.Text = "Ref. Number"
            Case Else
                PanelCheck.Visible = False
        End Select
    End Sub

    Private Sub btnShowHistoryTransaction_Click(sender As Object, e As EventArgs) Handles btnShowHistoryTransaction.Click
        TransactionHistoryToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PaymentMethodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentMethodToolStripMenuItem.Click
        Dim frmPaymentMethod As New FormPaymentMethod
        If Application.OpenForms().OfType(Of FormPaymentMethod).Any Then
            frmPaymentMethod.Focus()
        Else
            frmPaymentMethod = New FormPaymentMethod
            frmPaymentMethod.mProject = mProject
            txtOfficialReceipt.Focus()
            frmPaymentMethod.ShowDialog(Me)
        End If
    End Sub

    Private Sub ListViewUserItem_Click(sender As Object, e As EventArgs) Handles ListViewUserItem.Click
        If ListViewUserItem.Items.Count > 0 And ListViewUserItem.SelectedItems.Item(0).Text IsNot String.Empty Then
            mProject = New Project()
            With mProject
                ._itemID = ListViewUserItem.SelectedItems.Item(0).Text
                ._name = ListViewUserItem.SelectedItems.Item(0).SubItems(1).Text
                ._block = ListViewUserItem.SelectedItems.Item(0).SubItems(2).Text
                ._lot = ListViewUserItem.SelectedItems.Item(0).SubItems(3).Text
                ._sqm = ListViewUserItem.SelectedItems.Item(0).SubItems(4).Text
                ._tcp = ListViewUserItem.SelectedItems.Item(0).SubItems(5).Text
                ._projID = ListViewUserItem.SelectedItems.Item(0).SubItems(6).Text
                ._total_balance = ListViewUserItem.SelectedItems.Item(0).SubItems(7).Text
                ._total_discount = ListViewUserItem.SelectedItems.Item(0).SubItems(8).Text
                ._total_penalty = ListViewUserItem.SelectedItems.Item(0).SubItems(9).Text
                ._total_paidAmount = ListViewUserItem.SelectedItems.Item(0).SubItems(10).Text
                ._equity = ListViewUserItem.SelectedItems.Item(0).SubItems(11).Text
                ._amortization = ListViewUserItem.SelectedItems.Item(0).SubItems(12).Text
                ._description = mProject._name & " B" & mProject._block & " L" & mProject._lot & " - " & mProject._sqm & " sqm"
                ._userID = mUser._id
            End With
        End If
    End Sub
    Private Sub ListViewUserItem_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewUserItem.KeyUp
        If e.KeyCode = Keys.Enter Then
            If ListViewUserItem.Items.Count > 0 And ListViewUserItem.SelectedItems.Item(0).Text IsNot String.Empty Then
                ListViewUserItem_Click(sender, e)
                addPurchaseItem(mProject)
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            For Each i As ListViewItem In Me.ListViewUserItem.Items
                If ListViewUserItem.FocusedItem.Index <> i.Index Then
                    If i.SubItems(1).BackColor = Color.MistyRose Then
                        With i
                            .UseItemStyleForSubItems = False
                            .BackColor = Color.Beige
                            .SubItems(1).BackColor = Color.White
                            .SubItems(2).BackColor = Color.White
                            .SubItems(3).BackColor = Color.White
                            .SubItems(4).BackColor = Color.White
                            .SubItems(5).BackColor = Color.White
                            .SubItems(6).BackColor = Color.White
                            .SubItems(7).BackColor = Color.White
                            .SubItems(8).BackColor = Color.White
                            .SubItems(9).BackColor = Color.White
                        End With
                    End If
                End If
            Next

            Dim item As ListViewItem = New ListViewItem(String.Empty)
            item = ListViewUserItem.SelectedItems.Item(0)
            If item.SubItems(1).BackColor = Color.MistyRose Then
                With item
                    .UseItemStyleForSubItems = False
                    .BackColor = Color.Beige
                    .SubItems(1).BackColor = Color.White
                    .SubItems(2).BackColor = Color.White
                    .SubItems(3).BackColor = Color.White
                    .SubItems(4).BackColor = Color.White
                    .SubItems(5).BackColor = Color.White
                    .SubItems(6).BackColor = Color.White
                    .SubItems(7).BackColor = Color.White
                    .SubItems(8).BackColor = Color.White
                    .SubItems(9).BackColor = Color.White
                End With
            Else
                With item
                    .UseItemStyleForSubItems = False
                    .BackColor = Color.Beige
                    .SubItems(1).BackColor = Color.MistyRose
                    .SubItems(2).BackColor = Color.MistyRose
                    .SubItems(3).BackColor = Color.MistyRose
                    .SubItems(4).BackColor = Color.MistyRose
                    .SubItems(5).BackColor = Color.MistyRose
                    .SubItems(6).BackColor = Color.MistyRose
                    .SubItems(7).BackColor = Color.MistyRose
                    .SubItems(8).BackColor = Color.MistyRose
                    .SubItems(9).BackColor = Color.MistyRose
                End With
            End If
        End If
    End Sub

    Private Sub btnClearEntry_Click(sender As Object, e As EventArgs) Handles btnClearEntry.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub

    Private Sub txtTenderedAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenderedAmount.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtTenderedAmount.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblTotalAmount_TextChanged(sender As Object, e As EventArgs) Handles lblTotalAmount.TextChanged
        enablePaymentBotton()
    End Sub

    Private Sub txtTenderedAmount_LostFocus(sender As Object, e As EventArgs) Handles txtTenderedAmount.LostFocus
        If txtTenderedAmount.Text.Length > 0 And txtTenderedAmount.Text <> "." Then
            txtTenderedAmount.Text = Convert.ToDouble(txtTenderedAmount.Text).ToString("N2")
        ElseIf txtTenderedAmount.Text.Equals(".") Then
            txtTenderedAmount.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtTenderedAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTenderedAmount.TextChanged, txtTenderedAmount.KeyUp
        enablePaymentBotton()
    End Sub

    Private Sub enablePaymentBotton()
        If lblTotalAmount.Text.Length > 0 And txtTenderedAmount.Text.Length > 0 And txtTenderedAmount.Text <> "." Then
            If Convert.ToDouble(txtTenderedAmount.Text) >= Convert.ToDouble(lblTotalAmount.Text) And txtTenderedAmount.Text <> "0.00" Then
                btnPayment.Enabled = True
                btnPayment.BackColor = Color.Lime
                lblChange.Text = (Convert.ToDouble(txtTenderedAmount.Text) - Convert.ToDouble(lblTotalAmount.Text)).ToString("N2")
            Else
                btnPayment.Enabled = False
                btnPayment.BackColor = Color.LightGray
                lblChange.Text = 0.ToString("N2")
            End If
        End If
    End Sub

    Private Sub txtTenderedAmount_GotFocus(sender As Object, e As EventArgs) Handles txtTenderedAmount.GotFocus, txtTenderedAmount.MouseClick
        txtTenderedAmount.SelectAll()
    End Sub

End Class