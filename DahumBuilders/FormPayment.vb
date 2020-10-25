Imports MySql.Data.MySqlClient

Public Class FormPayment
    Public Property mUser As User = New User()
    Dim mProject As Project = New Project()
    Dim sumOfTotalContractPrice As Double = 0
    Dim cbb As New DataGridViewComboBoxColumn() With {.HeaderText = "Particular", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDownpayment As New DataGridViewComboBoxColumn() With {.HeaderText = "Downpayment", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}
    Dim cbbDiscount As New DataGridViewComboBoxColumn() With {.HeaderText = "Discount", .AutoComplete = DataGridViewAutoSizeColumnMode.DisplayedCells, .FlatStyle = FlatStyle.Flat}

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1114, 670)
        lblName.Text = mUser._name & " " & mUser._middleName & " " & mUser._surname
        lblAddress.Text = mUser._address
        lblContact.Text = mUser._mobile
        PanelCheck.Visible = False

        load_userId_info_data_reader()
        setDataGridView()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub load_userId_info_data_reader()

        sql = "SELECT * FROM `db_project_list` INNER JOIN `db_project_item` ON 
        db_project_list.`id`=db_project_item.`proj_id` WHERE `db_project_item`.`assigned_userid` = @userId"
        ListViewUserItem.Items.Clear()
        Connection()
        Try
            Dim table As New DataTable()
            Dim project As Project = New Project()

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
            Dim sumTransaction As SummaryTransaction = New SummaryTransaction
            For i As Integer = 0 To table.Rows.Count - 1
                project._itemID = table.Rows(i)("item_id")
                project._projID = table.Rows(i)("proj_id")
                project._name = table.Rows(i)("proj_name")
                project._block = table.Rows(i)("block")
                project._lot = table.Rows(i)("lot")
                project._sqm = table.Rows(i)("sqm")
                project._tcp = table.Rows(i)("price")

                sumTransaction = New SummaryTransaction
                sumTransaction = getSummaryTransaction(mUser._id, project)
                project._sumTran = sumTransaction

                item = New ListViewItem(project._itemID)
                item.SubItems.Add(project._name)
                item.SubItems.Add(project._block)
                item.SubItems.Add(project._lot)
                item.SubItems.Add(project._sqm)
                item.SubItems.Add(project._tcp.ToString("N2"))
                item.SubItems.Add(project._projID)
                item.SubItems.Add(project._sumTran._balance.ToString("N2"))
                item.SubItems.Add(project._sumTran._discount.ToString("N2"))
                item.SubItems.Add(project._sumTran._totalPaid.ToString("N2"))
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
            Dim p As Project = DirectCast(DataGridView1.Rows(e.RowIndex).Cells(13).Value, Project) 'Project class obkect
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
                            If p._sumTran._balance < 1 Then
                                downpamentAmount = (p._tcp * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                                DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                            Else
                                downpamentAmount = (p._sumTran._balance * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                                DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                            End If
                        Case "Equity"
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2") 'Amount to pay
                        Case "Monthly"
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2") 'Amount to pay
                        Case "Reservation"
                            'cellDiscount.Style.BackColor = Color.White
                            'cellDiscount.ReadOnly = False
                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0.ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2") 'Amount to pay
                        Case "Cash"
                            Dim ttSum As Double = p._sumTran._discount + p._sumTran._totalPaid
                            cellDiscount.Style.BackColor = Color.White
                            cellDiscount.ReadOnly = False

                            DataGridView1.Rows(e.RowIndex).Cells(3).Value = "0" 'cbbDownpayment
                            DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0"

                            If p._sumTran._balance <= 0 And ttSum <= 0 Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._tcp.ToString("N2") 'Amount to pay
                            End If

                            If p._sumTran._balance <= 0 And ttSum >= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2")  'Amount to pay
                            End If

                            If p._sumTran._balance >= 1 And ttSum <= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = p._sumTran._balance.ToString("N2")
                            End If
                    End Select
                Case 3 'ComoboBox Downpayment
                    DataGridView1.Rows(e.RowIndex).Cells(5).Value = "0" 'cbbDiscount
                    If p IsNot Nothing Then
                        If p._sumTran._balance < 1 Then
                            downpamentAmount = (p._tcp * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount

                            DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._tcp * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        Else
                            downpamentAmount = (p._sumTran._balance * Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value) / 100).ToString("N2")
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100

                            DataGridView1.Rows(e.RowIndex).Cells(4).Value = downpamentAmount.ToString("N2") 'Downpayment Amount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        End If
                    End If
                Case 5 'ComboBox Discount
                    Select Case DataGridView1.Rows(e.RowIndex).Cells(2).Value 'ComoboBox Particular
                        Case "Downpayment"
                            downpamentAmount = DataGridView1.Rows(e.RowIndex).Cells(4).Value 'Downpayment Amount
                            discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                            DataGridView1.Rows(e.RowIndex).Cells(6).Value = (downpamentAmount * discount).ToString("N2") 'Discount Amount
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = (downpamentAmount - (downpamentAmount * discount)).ToString("N2") 'Amount to pay
                        Case "Cash"
                            If p._sumTran._balance < 1 And p._sumTran._totalPaid < 1 Then
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._tcp * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (p._tcp - (p._tcp * discount)).ToString("N2") 'Amount to pay
                            ElseIf p._sumTran._balance < 1 And p._sumTran._totalPaid >= p._tcp Then
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = 0.ToString("N2")
                            Else
                                discount = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value) / 100 'cbbDiscount
                                DataGridView1.Rows(e.RowIndex).Cells(6).Value = (p._sumTran._balance * discount).ToString("N2") 'Discount Amount
                                DataGridView1.Rows(e.RowIndex).Cells(11).Value = (p._sumTran._balance - (p._sumTran._balance * discount)).ToString("N2") 'Amount to pay
                            End If
                    End Select
            End Select
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 12 Then
            If DataGridView1.Rows(e.RowIndex).Cells(12).Value IsNot Nothing Then
                DataGridView1.Rows(e.RowIndex).Cells(12).Value = Double.Parse(DataGridView1.Rows(e.RowIndex).Cells(12).Value).ToString("N2")
            End If
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = 9 Or DataGridView1.CurrentCell.ColumnIndex = 10 Then 'Part
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtMonthOf_KeyPress
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 12 Then 'Tender
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtAmountPaid_KeyPress
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
                project._itemID = ListViewUserItem.SelectedItems.Item(0).Text
                project._name = ListViewUserItem.SelectedItems.Item(0).SubItems(1).Text
                Project._block = ListViewUserItem.SelectedItems.Item(0).SubItems(2).Text
                Project._lot = ListViewUserItem.SelectedItems.Item(0).SubItems(3).Text
                Project._sqm = ListViewUserItem.SelectedItems.Item(0).SubItems(4).Text
                Project._tcp = ListViewUserItem.SelectedItems.Item(0).SubItems(5).Text
                Project._projID = ListViewUserItem.SelectedItems.Item(0).SubItems(6).Text
                project._sumTran._balance = ListViewUserItem.SelectedItems.Item(0).SubItems(7).Text
                project._sumTran._discount = ListViewUserItem.SelectedItems.Item(0).SubItems(8).Text
                project._sumTran._totalPaid = ListViewUserItem.SelectedItems.Item(0).SubItems(9).Text
                project._description = project._name & " B" & project._block & " L" & project._lot & " - " & project._sqm & " sqm"
                addPurchaseItem(Project)
            End If
        End If
    End Sub

    Private Sub addPurchaseItem(ByVal project As Project)

        If DataGridView1.Rows.Count > 0 Then
            For Each dRow As DataGridViewRow In DataGridView1.Rows
                If dRow.Cells(7).Value.Equals(project._itemID) And dRow.Cells(8).Value.Equals(project._projID) Then
                    Console.WriteLine(String.Format("Already exist Project ID {0} and ItemID {1}", project._projID, project._itemID))
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
        row.Cells(9).Value = 0.ToString("N2") 'Monthly Amortization
        row.Cells(13).Value = project 'project class
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
        DataGridView1.Columns.Add("", "Monthly")
        DataGridView1.Columns.Add("", "Part")
        DataGridView1.Columns.Add("", "Amount to Pay")
        DataGridView1.Columns.Add("", "Tender Amount")
        DataGridView1.Columns.Add("", "Total Paid")

        With DataGridView1
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With DataGridView1
            .Columns(0).Width = 150
            .Columns(1).Width = 90 'TCP
            .Columns(2).Width = 100 'cbb particular
            .Columns(3).Width = 100 'cbb Downpayment
            .Columns(4).Width = 90 'Downpayment Amount
            .Columns(5).Width = 70 'cbb discount
            .Columns(6).Width = 90 'Discount Amount
            .Columns(7).Width = 50 'ItemID
            .Columns(8).Width = 50 'ProjectID
            .Columns(9).Width = 75 'Monthly
            .Columns(10).Width = 50 'Part
            .Columns(11).Width = 100 'Amount to Pay
            .Columns(12).Width = 110 'Tender Amount
        End With

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        DataGridView1.Columns(9).ReadOnly = True
        DataGridView1.Columns(11).ReadOnly = True
        DataGridView1.Columns(13).ReadOnly = True 'Project class obkect

        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(13).Visible = False 'Project class obkect

        CType(DataGridView1.Columns(10), DataGridViewTextBoxColumn).MaxInputLength = 3
        CType(DataGridView1.Columns(12), DataGridViewTextBoxColumn).MaxInputLength = 20

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
                        'ListViewUserItem.Items(0).Focused = True
                    End If
                    Exit Sub
            End Select
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(12).Value Is Nothing Then
                row.DefaultCellStyle.BackColor = Color.MistyRose
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next

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
            If row.Cells(12).Value Is Nothing Then
                Dim ret As DialogResult = MessageBox.Show(Me, "Please enter Tender Amount.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Select Case ret
                    Case DialogResult.OK
                        If DataGridView1.RowCount > 0 Then
                            DataGridView1.Focus()
                            row.Cells(12).Selected = True
                        End If
                End Select
                Exit Sub
            End If
            Dim trans As Transaction = New Transaction()
            Dim c As DataGridViewComboBoxCell = DirectCast(DataGridView1.Item(2, row.Index), DataGridViewComboBoxCell)
            trans._or = txtOfficialReceipt.Text.Trim
            trans._datePaid = Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
            trans._tcp = row.Cells(1).Value
            trans._DiscountAmount = row.Cells(6).Value
            trans._paidAmount = row.Cells(12).Value 'Tender Amount
            trans._particular = c.Items.IndexOf(c.Value)
            trans._partNo = row.Cells(10).Value
            trans._paymentType = cbPaymentType.SelectedIndex
            trans._clientId = mUser._id
            trans._projectItemId = row.Cells(7).Value
            trans._projectId = row.Cells(8).Value
            trans._check_bank_name = txtBankName.Text.Trim
            If cbPaymentType.SelectedIndex > 0 Then
                trans._check_bank_name = txtBankName.Text.Trim
                trans._check_number = txtCheckNo.Text.Trim
                trans._check_date = dtpCheckDate.Value
            End If
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
        sql = "INSERT INTO `db_transaction` (`official_receipt_no`, `date_paid`, `paid_amount`, `discount_amount`, `tcp`, `particular`, 
        `part_no`, `payment_type`, `check_bank_name`, `check_number`, `check_date`, `userid`, `proj_id`, `proj_itemId`) VALUES (@OR, @DatePaid, @PaidAmount, @DiscountAmount, @TCP, 
        @Particular, @PartNo, @PaymentType, @CheckBankName, @CheckNumber, @CheckDate, @userid, @ProjId, @ProjItemId)"

        If trans._particular = 0 Or trans._particular = 1 Or trans._particular = 4 Or trans._particular = 5 Then
            trans._partNo = 0
        End If

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@OR", MySqlDbType.VarChar).Value = trans._or 'txtOfficialReceipt.Text.Trim
        sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.Date).Value = Format(trans._datePaid, "yyyy-MM-dd").ToString 'Format(dtpDatePaid.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@PaidAmount", MySqlDbType.Double).Value = trans._paidAmount 'txtPaidAmount.Text.Trim
        sqlCommand.Parameters.Add("@DiscountAmount", MySqlDbType.Double).Value = trans._DiscountAmount 'txtPaidAmount.Text.Trim
        sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = trans._tcp
        sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int24).Value = trans._particular 'Integer.Parse(cbParticular.SelectedIndex)
        sqlCommand.Parameters.Add("@PartNo", MySqlDbType.Int24).Value = trans._partNo 'Integer.Parse(txtPart.Text)
        sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int24).Value = trans._paymentType 'cbPaymentType.SelectedIndex
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
            Dim totalPaid As Double = ListViewUserItem.SelectedItems.Item(0).SubItems(8).Text
            If totalPaid > 0 Then
                ContextMenuProjectList.Items(0).Enabled = False
            Else
                ContextMenuProjectList.Items(0).Enabled = True
            End If
        ElseIf ListViewUserItem.SelectedItems.Item(0).Text Is String.Empty Then
            ContextMenuProjectList.Items(0).Enabled = False
        End If
    End Sub

    Private Sub cbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentType.SelectedIndexChanged
        lblCheckNo.Visible = False
        txtCheckNo.Visible = False
        lblInformation.Text = String.Empty
        lblDateOrTransfer.Text = String.Empty
        txtCheckNo.Text = String.Empty
        txtBankName.Text = String.Empty
        Select Case cbPaymentType.SelectedIndex
            Case 1
                PanelCheck.Visible = True
                lblInformation.Text = "Check Information"
                lblDateOrTransfer.Text = "Date Check"
                lblCheckNo.Visible = True
                txtCheckNo.Visible = True
            Case 2
                PanelCheck.Visible = True
                lblInformation.Text = "Bank Transfer Information"
                lblDateOrTransfer.Text = "Date Transfer"
            Case Else
                PanelCheck.Visible = False
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'mProject = DirectCast(DataGridView1.Rows(e.RowIndex).Cells(14).Value, Project)
    End Sub

    Private Sub btnShowHistoryTransaction_Click(sender As Object, e As EventArgs) Handles btnShowHistoryTransaction.Click
        TransactionHistoryToolStripMenuItem.PerformClick()
    End Sub
End Class