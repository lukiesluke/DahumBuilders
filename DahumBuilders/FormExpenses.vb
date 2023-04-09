
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class FormExpenses
    Dim format As String = "yyyy-MM-dd"
    Dim messageInfo As String = "Please select name..."
    Dim mDisableLoadUserType As Boolean = False
    Private mIdNumber As String = ""
    Private Sub FormExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1020, 630)
        lblProjectID.Text = 0
        lblClientID.Text = 0
        lblIssueTo.Text = messageInfo
        btnSave.Enabled = False
        txtCheckNo.Text = ""
        loadPaymentType()
        loadCombo()
        loadComboExpensesSearch()
        loadComboBoxUserType()
        enableExportToExcel()

        TaxConfiguration()
        lblTaxbase.Text = "Tax " & taxAmount.ToString("N2") & "%"
        txtTaxBase.Text = 0.ToString("N2")
        txtInput.Text = 0.ToString("N2")
        txtGross.Text = 0.ToString("N2")
        cbxType.SelectedIndex = 0
    End Sub

    Private Sub loadEmployeeList(type As String)
        Connection()
        If "search".Equals(type) Then
            sql = "SELECT `id`, CONCAT(`first_name`, ' ', `middle_name`,' ', `last_name`) NAME, 
            `mobile_number`, TRIM(`address`) AS address, `tin`, (SELECT `type` FROM `db_user_type` WHERE `id`=`user_type`) `user_type`
            FROM `db_user_profile` WHERE `user_type`>0 AND (`first_name` LIKE @Name OR `last_name` LIKE @Name) ORDER BY user_type, NAME"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = txtSearch.Text.Trim + "%"
        Else
            Dim key As Integer = DirectCast(cbbUserType.SelectedItem, KeyValuePair(Of Integer, String)).Key
            sql = "SELECT `id`, CONCAT(`first_name`, ' ', `middle_name`,' ', `last_name`) NAME, 
            `mobile_number`, TRIM(`address`) AS address, `tin`, (SELECT `type` FROM `db_user_type` WHERE `id`=`user_type`) `user_type` FROM `db_user_profile` 
            WHERE {0} ORDER BY user_type, NAME"

            If 0 = key Then
                sql = String.Format(sql, "`user_type`>@UserType")
            Else
                sql = String.Format(sql, "`user_type`=@UserType")
            End If

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@UserType", MySqlDbType.Int32).Value = key
        End If

        sqlDataReader = sqlCommand.ExecuteReader()
        Try
            Dim item As ListViewItem
            ListView1.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("NAME"))
                item.SubItems.Add(sqlDataReader("mobile_number"))
                item.SubItems.Add(sqlDataReader("address"))
                item.SubItems.Add(sqlDataReader("tin"))
                item.SubItems.Add(sqlDataReader("user_type"))
                ListView1.Items.Add(item)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblProjectID.Text = 0
        lblClientID.Text = 0
        lblIssueTo.Text = messageInfo
        cbbUserType.SelectedIndex = 0
        mDisableLoadUserType = True
        loadEmployeeList("search")
        mDisableLoadUserType = False
    End Sub

    Private Sub loadPaymentType()
        Dim comboSourceEwtTaxType As New Dictionary(Of Double, String)()
        comboSourceEwtTaxType.Add("0.01", "1%")
        comboSourceEwtTaxType.Add("0.02", "2%")
        comboSourceEwtTaxType.Add("0.05", "5%")
        comboSourceEwtTaxType.Add("0.10", "10%")
        comboSourceEwtTaxType.Add("0.15", "15%")

        cbxEwt.DataSource = New BindingSource(comboSourceEwtTaxType, Nothing)
        cbxEwt.DisplayMember = "Value"
        cbxEwt.ValueMember = "Key"

        Dim comboSourcePaymentType As New Dictionary(Of String, String)()
        comboSourcePaymentType.Add("0", "Cash")
        comboSourcePaymentType.Add("1", "Check")

        cbbPaymentType.DataSource = Nothing
        cbbPaymentType.Items.Clear()

        cbbPaymentType.DataSource = New BindingSource(comboSourcePaymentType, Nothing)
        cbbPaymentType.DisplayMember = "Value"
        cbbPaymentType.ValueMember = "Key"
    End Sub

    Private Sub loadCombo()
        sql = "SELECT `id`,`name` FROM `db_particular_type` WHERE id>6"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbExpensesType.DataSource = Nothing
            cbbExpensesType.Items.Clear()

            Dim comboSourceExpeneseType As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourceExpeneseType.Add(sqlDataReader("id"), sqlDataReader("name"))
            Loop

            cbbExpensesType.DataSource = New BindingSource(comboSourceExpeneseType, Nothing)
            cbbExpensesType.DisplayMember = "Value"
            cbbExpensesType.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub loadComboExpensesSearch()
        sql = "SELECT `id`,`name` FROM `db_particular_type` WHERE id>6"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbExpensesTypeSearch.DataSource = Nothing
            cbbExpensesTypeSearch.Items.Clear()

            Dim comboSourceExpeneseType As New Dictionary(Of String, String)()
            comboSourceExpeneseType.Add("0", "All")
            Do While sqlDataReader.Read = True
                comboSourceExpeneseType.Add(sqlDataReader("id"), sqlDataReader("name"))
            Loop

            cbbExpensesTypeSearch.DataSource = New BindingSource(comboSourceExpeneseType, Nothing)
            cbbExpensesTypeSearch.DisplayMember = "Value"
            cbbExpensesTypeSearch.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub loadDeduction(keyId As String, dtStart As DateTimePicker, dtEnd As DateTimePicker)

        Dim particulID As String = keyId

        sql = "SELECT `id`, `date_paid`, IFNULL(`official_receipt_no`,'') AS `official_receipt_no`, `commission`, `voucher_no`, `description`,
        IFNULL((SELECT CONCAT(`first_name`, ' ', `last_name`) FROM `db_user_profile` WHERE `db_transaction`.`userid`= `db_user_profile`.`id`), `payee_name`) AS NAME,
        (SELECT `name` FROM `db_payment_type` WHERE `id`= `db_transaction`.`payment_type`) AS paymentType,
        (SELECT `name` FROM `db_particular_type` WHERE `id`= `particular`) AS particular, `check_number`,
        IFNULL((SELECT `tin` FROM `db_user_profile` WHERE `id`=`db_transaction`.`userid`),'') tin,
        IFNULL((SELECT `address` FROM `db_user_profile` WHERE `id`=`db_transaction`.`userid`),'') address,
        `gross_val`, `tax_base`, `input_val`, `ewt_val` FROM `db_transaction`
        WHERE {0} AND `date_paid` BETWEEN @dtStart AND @dtEnd ORDER BY date_paid"

        If 0 = cbbExpensesTypeSearch.SelectedIndex Then
            particulID = "5"
            sql = String.Format(sql, "`particular`>@Particular")
        Else
            sql = String.Format(sql, "`particular`=@Particular")
        End If

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@dtStart", MySqlDbType.VarChar).Value = dtStart.Value.ToString(format)
            sqlCommand.Parameters.Add("@dtEnd", MySqlDbType.VarChar).Value = dtEnd.Value.ToString(format)
            sqlCommand.Parameters.Add("@Particular", MySqlDbType.VarChar).Value = particulID
            sqlDataReader = sqlCommand.ExecuteReader()

            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListViewExpenses.Items.Clear()

            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("date_paid"))
                item.SubItems.Add(sqlDataReader("voucher_no"))
                item.SubItems.Add(sqlDataReader("NAME"))
                item.SubItems.Add(sqlDataReader("tin"))
                item.SubItems.Add(sqlDataReader("address"))
                item.SubItems.Add(Double.Parse(sqlDataReader("gross_val")).ToString("N2"))
                item.SubItems.Add(Double.Parse(sqlDataReader("tax_base")).ToString("N2"))
                item.SubItems.Add(Double.Parse(sqlDataReader("input_val")).ToString("N2"))
                item.SubItems.Add(Double.Parse(sqlDataReader("ewt_val")).ToString("N2"))
                item.SubItems.Add(sqlDataReader("official_receipt_no"))
                item.SubItems.Add(sqlDataReader("particular"))
                item.SubItems.Add(sqlDataReader("description"))
                item.SubItems.Add(sqlDataReader("paymentType"))
                item.SubItems.Add(sqlDataReader("check_number"))
                item.SubItems.Add(Double.Parse(sqlDataReader("commission")).ToString("N2"))
                ListViewExpenses.Items.Add(item)
            Loop

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try

        enableExportToExcel()
    End Sub
    Private Sub txtCashoutAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashoutAmount.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtCashoutAmount.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bankName As String = ""
        Dim payeeName As String = ""
        Dim particularIdValue As String = DirectCast(cbbExpensesType.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim PaymentType As String = DirectCast(cbbPaymentType.SelectedItem, KeyValuePair(Of String, String)).Key

        If "1".Equals(PaymentType) And txtCheckNo.Text.Equals("") Then
            MessageBox.Show("Please enter check number.")
            txtCheckNo.Focus()
            Exit Sub
        End If

        If lblIssueTo.Text.Trim.Equals(messageInfo) Then
            MessageBox.Show("Please select Name to issue as Cash/Check.")
            txtSearch.Focus()
            Exit Sub
        End If

        If txtDescription.Text.Trim.Length < 1 Then
            MessageBox.Show("Please a short description.")
            txtDescription.Focus()
            Exit Sub
        End If

        If txtGross.Text.Length = 0 Then
            txtGross.Text = "0"
        End If

        If txtTaxBase.Text.Length = 0 Then
            txtTaxBase.Text = "0"
        End If

        If txtInput.Text.Length = 0 Then
            txtInput.Text = "0"
        End If

        sql = "INSERT INTO `db_transaction` 
        (`date_paid`,`official_receipt_no`,`commission`,`particular`, `description`, `proj_id`, `check_bank_name`, `check_date`, `voucher_no`, `gross_val`, `tax_base`, `input_val`, `ewt_val`, `payee_name`, `userid`, `payment_type`, `check_number`, `created_by`) VALUES
        (@DatePaid, @ORNo, @Commission, @Particular, @Description, @ProjID, @BankName, @DateCheck, @VoucherNo, @GrossVal, @TaxBase, @InputVal, @EwtVal, @PayeeName, @Userid, @PaymentType, @CheckNumber, @CreatedBy)"

        Dim dateCheck As Date = Nothing
        If "commission".Equals(cbbExpensesType.Text.Trim.ToLower) Then
            dateCheck = dt.Value
        End If

        If cbbBankName.SelectedIndex > 0 Then
            bankName = cbbBankName.Text.Trim
        End If

        If lblClientID.Text.Equals("0") Then
            payeeName = lblIssueTo.Text.Trim
        End If

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.VarChar).Value = dt.Value.ToString(format)
            sqlCommand.Parameters.Add("@ORNo", MySqlDbType.VarChar).Value = txtORNumber.Text.Trim
            sqlCommand.Parameters.Add("@Commission", MySqlDbType.Double).Value = Double.Parse(txtCashoutAmount.Text.Trim)
            sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int64).Value = particularIdValue
            sqlCommand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = txtDescription.Text.Trim
            sqlCommand.Parameters.Add("@ProjID", MySqlDbType.Int64).Value = lblProjectID.Text.Trim
            sqlCommand.Parameters.Add("@BankName", MySqlDbType.VarChar).Value = bankName
            sqlCommand.Parameters.Add("@DateCheck", MySqlDbType.VarChar).Value = dateCheck.ToString(format)
            sqlCommand.Parameters.Add("@VoucherNo", MySqlDbType.VarChar).Value = txtVoucherNo.Text.Trim
            sqlCommand.Parameters.Add("@GrossVal", MySqlDbType.Double).Value = Double.Parse(txtGross.Text.Trim)
            sqlCommand.Parameters.Add("@TaxBase", MySqlDbType.Double).Value = Double.Parse(txtTaxBase.Text.Trim)
            sqlCommand.Parameters.Add("@InputVal", MySqlDbType.Double).Value = Double.Parse(txtInput.Text.Trim)
            sqlCommand.Parameters.Add("@EwtVal", MySqlDbType.Double).Value = Double.Parse(txtEwt.Text.Trim)
            sqlCommand.Parameters.Add("@PayeeName", MySqlDbType.VarChar).Value = payeeName
            sqlCommand.Parameters.Add("@Userid", MySqlDbType.Int64).Value = lblClientID.Text.Trim
            sqlCommand.Parameters.Add("@PaymentType", MySqlDbType.Int64).Value = PaymentType
            sqlCommand.Parameters.Add("@CheckNumber", MySqlDbType.VarChar).Value = txtCheckNo.Text.Trim.ToUpper
            sqlCommand.Parameters.Add("@CreatedBy", MySqlDbType.Int64).Value = userLogon._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                sqlCommand.Dispose()
                txtORNumber.Text = ""
                txtCashoutAmount.Text = 0.ToString("N2")
                txtGross.Text = 0.ToString("N2")
                txtTaxBase.Text = 0.ToString("N2")
                txtInput.Text = 0.ToString("N2")
                txtDescription.Text = ""
                btnSave.Enabled = False
                txtCheckNo.Text = ""
                txtVoucherNo.Text = ""
                cbbBankName.SelectedIndex = 0
                MessageBox.Show("Expenses successfully save.")
                lblIssueTo.Text = messageInfo
            End If
        Catch ex As Exception
            MessageBox.Show("Expenses: " & ex.Message)
            lblIssueTo.Text = messageInfo
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            txtCheckNo.Text = ""
        End Try
    End Sub

    Private Sub txtCashoutAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCashoutAmount.KeyUp
        Dim type As String = DirectCast(cbbPaymentType.SelectedItem, KeyValuePair(Of String, String)).Key
        btnSave.Enabled = False

        If txtCashoutAmount.Text.Length > 0 And txtCashoutAmount.Text <> "." Then
            Dim cashout As Double = Double.Parse(txtCashoutAmount.Text)

            If cashout > 0 Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
        End If

        If txtCashoutAmount.Text.Equals(" ") Or txtCashoutAmount.Text.Equals("") Then
            btnSave.Enabled = False
            txtCashoutAmount.Text = 0.ToString("N2")
        End If

    End Sub

    Private Sub cbbPaymentType_TextChanged(sender As Object, e As EventArgs) Handles cbbPaymentType.TextChanged
        txtCashoutAmount.Text = 0.ToString("N2")
        txtCheckNo.Text = ""
        btnSave.Enabled = False
        Try
            Dim type As String = DirectCast(cbbPaymentType.SelectedItem, KeyValuePair(Of String, String)).Key
            If "1".Equals(type) Then
                txtCheckNo.Enabled = True
                cbbBankName.Enabled = True
                cbbBankName.DroppedDown = True
            Else
                txtCheckNo.Enabled = False
                cbbBankName.Enabled = False
                cbbBankName.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Try
            If ListView1.Items.Count > 0 Then
                lblClientID.Text = ListView1.SelectedItems(0).Text
                lblIssueTo.Text = ListView1.SelectedItems(0).SubItems(1).Text
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        ListView1_Click(sender, e)
    End Sub

    Private Sub lblIssueTo_Click(sender As Object, e As EventArgs) Handles lblIssueTo.Click
        If cbbExpensesType.Text.Contains("Commission") Then
            MessageBox.Show("Please select Payee name from Employee list.")
            txtSearch.Focus()
        Else
            PanelPayeeName.Visible = True
        End If
    End Sub

    Private Sub btnPayeeCancel_Click(sender As Object, e As EventArgs) Handles btnPayeeCancel.Click
        PanelPayeeName.Visible = False
    End Sub

    Private Sub btnSetPayeeName_Click(sender As Object, e As EventArgs) Handles btnSetPayeeName.Click
        txtPayeeName.Text = txtPayeeName.Text.Trim()

        If txtPayeeName.Text.Length < 1 Then
            MessageBox.Show("Please enter Payee Name.")
            txtPayeeName.Focus()
            Exit Sub
        End If

        lblIssueTo.Text = txtPayeeName.Text.Trim
        lblClientID.Text = "0"
        PanelPayeeName.Visible = False
        txtPayeeName.Text = ""
    End Sub

    Private Sub loadComboBoxUserType()
        sql = "SELECT `id`, `type` FROM `db_user_type` WHERE `id` > 0"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbUserType.DataSource = Nothing
            cbbUserType.Items.Clear()

            Dim comboSourceUserType As New Dictionary(Of Integer, String)()
            comboSourceUserType.Add(0, "All")
            Do While sqlDataReader.Read = True
                comboSourceUserType.Add(sqlDataReader("id"), sqlDataReader("type"))
            Loop

            cbbUserType.DataSource = New BindingSource(comboSourceUserType, Nothing)
            cbbUserType.DisplayMember = "Value"
            cbbUserType.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cbbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbUserType.SelectedIndexChanged
        If mDisableLoadUserType = True Then
            Exit Sub
        End If

        loadEmployeeList("userType")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim objExcel As New Excel.Application
            Dim bkWorkBook As Workbook
            Dim shWorkSheet As Worksheet
            Dim chartRange As Excel.Range
            Dim i As Integer
            Dim j As Integer

            objExcel = New Excel.Application
            bkWorkBook = objExcel.Workbooks.Add
            shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)

            chartRange = shWorkSheet.Range("A1", "P1")
            chartRange.Merge()
            chartRange.HorizontalAlignment = Excel.Constants.xlCenter

            If dtpStart.Value.Date = dtpEnd.Value.Date Then
                shWorkSheet.Cells(1, 1) = "Expenses Report " & dtpStart.Value.Date.ToString("MM/dd/yyyy")
            Else
                shWorkSheet.Cells(1, 1) = "Expenses Report " & dtpStart.Value.Date.ToString("MM/dd/yyyy") & " - " & dtpEnd.Value.Date.ToString("MM/dd/yyyy")
            End If

            For i = 0 To Me.ListViewExpenses.Columns.Count - 1
                shWorkSheet.Cells(2, i + 1) = Me.ListViewExpenses.Columns(i).Text
            Next
            For i = 0 To Me.ListViewExpenses.Items.Count - 1
                For j = 0 To Me.ListViewExpenses.Items(i).SubItems.Count - 1
                    shWorkSheet.Cells(i + 3, j + 1) = Me.ListViewExpenses.Items(i).SubItems(j).Text
                Next
            Next

            shWorkSheet.Range("A1:O1").EntireColumn.AutoFit()
            objExcel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub enableExportToExcel()
        If ListViewExpenses.Items.Count > 0 Then
            ExcelToolStripMenuItem.Enabled = True
        Else
            ExcelToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        Dim expensesID As String = DirectCast(cbbExpensesTypeSearch.SelectedItem, KeyValuePair(Of String, String)).Key
        loadDeduction(expensesID, dtpStart, dtpEnd)
    End Sub

    Private Sub ToolStripMenuItemEdit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEdit.Click
        mFormExpensesEntries = New FormExpensesEntries
        mFormExpensesEntries.mIdNumber = mIdNumber
        mFormExpensesEntries.ShowDialog()
    End Sub

    Private Sub ListViewExpenses_Click(sender As Object, e As EventArgs) Handles ListViewExpenses.Click
        If ListView1.Items.Count > 0 Then
            mIdNumber = ListViewExpenses.SelectedItems(0).Text
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        mFormVerification = New FormVerification
        mFormVerification.deleteExpensesEntry = delExpensesID
        mFormVerification.mId = mIdNumber
        mFormVerification.ShowDialog()
    End Sub

    Private Sub txtGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtGross.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTaxBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxBase.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtTaxBase.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtInput.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblTaxbase_Click(sender As Object, e As EventArgs) Handles lblTaxbase.Click
        Dim cashAmount As Double = Convert.ToDouble(txtCashoutAmount.Text.Trim)
        txtTaxBase.Text = (cashAmount * taxAmount).ToString("N2")
    End Sub

    Private Sub txtCashoutAmount_Leave(sender As Object, e As EventArgs) Handles txtCashoutAmount.Leave
        If txtCashoutAmount.Text.Trim.Length < 1 Then
            txtCashoutAmount.Text = 0.ToString("N2")
        End If

        If txtCashoutAmount.Text.Trim.Equals(".") Then
            txtCashoutAmount.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtTaxBase_Leave(sender As Object, e As EventArgs) Handles txtTaxBase.Leave
        If txtTaxBase.Text.Trim.Length < 1 Then
            txtTaxBase.Text = 0.ToString("N2")
        End If

        If txtTaxBase.Text.Trim.Equals(".") Then
            txtTaxBase.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtGross_Leave(sender As Object, e As EventArgs) Handles txtGross.Leave
        If txtGross.Text.Trim.Length < 1 Then
            txtGross.Text = 0.ToString("N2")
        End If

        If txtGross.Text.Trim.Equals(".") Then
            txtGross.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtInput_Leave(sender As Object, e As EventArgs) Handles txtInput.Leave
        If txtInput.Text.Trim.Length < 1 Then
            txtInput.Text = 0.ToString("N2")
        End If

        If txtInput.Text.Trim.Equals(".") Then
            txtInput.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtGross_TextChanged(sender As Object, e As EventArgs) Handles txtGross.TextChanged
        If cbxType.SelectedIndex = 0 Then
            computInputTax()
        Else
            computEwtTax()
        End If
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        If cbxType.SelectedIndex = 0 Then
            computInputTax()
        Else
            computEwtTax()
        End If
    End Sub
    Private Sub computInputTax()
        Dim TotalAmount As Double
        Dim GrossAmount As Double
        GrossAmount = Convert.ToDouble(txtGross.Text)
        TotalAmount = ((GrossAmount / 1.12) * 0.12)

        txtInput.Enabled = True
        txtInput.Text = TotalAmount.ToString("N2")
        txtCashoutAmount.Text = (GrossAmount - TotalAmount).ToString("N2")

        cbxEwt.Enabled = False
        txtEwt.Text = 0.ToString("N2")
        txtEwt.Enabled = False
    End Sub

    Private Sub computEwtTax()
        Dim ewtPercent As Double = DirectCast(cbxEwt.SelectedItem, KeyValuePair(Of Double, String)).Key
        Dim TotalAmount As Double
        Dim GrossAmount As Double
        Try
            GrossAmount = Convert.ToDouble(txtGross.Text)
            TotalAmount = ((GrossAmount / 1.12) * ewtPercent)

            txtInput.Text = 0.ToString("N2")
            txtInput.Enabled = False

            txtEwt.Text = TotalAmount.ToString("N2")
            txtCashoutAmount.Text = (GrossAmount - TotalAmount).ToString("N2")

            cbxEwt.Enabled = True
            txtEwt.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxEwt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEwt.SelectedIndexChanged
        computEwtTax()
    End Sub

    Private Sub txtEwt_Leave(sender As Object, e As EventArgs) Handles txtEwt.Leave
        If txtEwt.Text.Trim.Length < 1 Then
            txtEwt.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub txtCashoutAmount_TextChanged(sender As Object, e As EventArgs) Handles txtCashoutAmount.TextChanged
        btnSave.Enabled = False

        If txtCashoutAmount.Text.Length > 0 And txtCashoutAmount.Text <> "." Then
            Dim cashout As Double = Double.Parse(txtCashoutAmount.Text)

            If cashout > 0 Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
        End If
    End Sub
End Class