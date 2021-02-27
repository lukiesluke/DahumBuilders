Imports MySql.Data.MySqlClient

Public Class FormExpenses
    Dim format As String = "yyyy-MM-dd"
    Private Sub FormExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCashin.Text = 0.ToString("N2")
        txtCashoutAmount.Enabled = False
        lblProjectID.Text = 0
        btnSave.Enabled = False

        loadCombo()
    End Sub

    Private Sub loadSales(dt As DateTimePicker)
        Connection()
        sql = "SELECT `proj_id`, (SELECT `proj_name` FROM `db_project_list` WHERE `id`= t.`proj_id`) proj_name,
        `date_paid`, SUM(`paid_amount`)-SUM(`commission`) AS totalCash, SUM(`commission`) AS totalDeduction 
        FROM `db_transaction` t WHERE `payment_type`=0 AND `date_paid`=@dt AND `proj_id`>0 GROUP BY `proj_id`"

        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@dt", MySqlDbType.VarChar).Value = dt.Value.ToString(format)
        sqlDataReader = sqlCommand.ExecuteReader()
        Try
            Dim item As ListViewItem
            Dim totalPaid As Double = 0

            ListView1.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("proj_id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("date_paid"))
                Dim totalCash As Double = sqlDataReader("totalCash")
                totalPaid += totalCash
                Dim totalDeduction As Double = sqlDataReader("totalDeduction")
                With item.SubItems.Add(totalCash.ToString("N2"))
                    .Font = New Font(ListView1.Font, FontStyle.Regular)
                    .ForeColor = Color.Green
                End With
                With item.SubItems.Add(totalDeduction.ToString("N2"))
                    .Font = New Font(ListView1.Font, FontStyle.Regular)
                    .ForeColor = Color.Red
                End With
                ListView1.Items.Add(item)
            Loop

            lblTotalCashin.Text = totalPaid.ToString("N2")

            If totalPaid > 0 Then
                txtCashoutAmount.Enabled = True
            Else
                txtCashoutAmount.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        loadDeduction(dt)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblTotalCashin.Text = 0.ToString("N2")
        txtCashoutAmount.Enabled = False
        lblProjectID.Text = 0
        loadSales(dt)
    End Sub

    Private Sub loadCombo()
        sql = "SELECT `id`,`name` FROM `db_particular_type` WHERE id>5"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbType.DataSource = Nothing
            cbbType.Items.Clear()

            Dim comboSourceProjectName As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourceProjectName.Add(sqlDataReader("id"), sqlDataReader("name"))
            Loop

            cbbType.DataSource = New BindingSource(comboSourceProjectName, Nothing)
            cbbType.DisplayMember = "Value"
            cbbType.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub loadDeduction(dt As DateTimePicker)
        sql = "SELECT `id`, `date_paid`, `commission`, `description`, 
        (SELECT `name` FROM `db_particular_type` WHERE `id`= `particular`) AS particular
        FROM `db_transaction` WHERE `particular`>5 AND `date_paid`=@dt"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@dt", MySqlDbType.VarChar).Value = dt.Value.ToString(format)
        sqlDataReader = sqlCommand.ExecuteReader()

        Try
            Cursor = Cursors.WaitCursor
            Dim item As ListViewItem
            ListViewExpenses.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("description"))
                item.SubItems.Add(sqlDataReader("commission"))
                item.SubItems.Add(sqlDataReader("particular"))
                item.SubItems.Add(sqlDataReader("date_paid"))
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
        Dim particularID As String = DirectCast(cbbType.SelectedItem, KeyValuePair(Of String, String)).Key

        sql = "INSERT INTO `db_transaction` (`date_paid`,`commission`,`particular`, `description`, `proj_id`, `penalty`, `discount_amount`, `created_by`) VALUES
        (@DatePaid, @Commission, @Particular, @Description, @ProjID, NULL, NULL, @CreatedBy)"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@DatePaid", MySqlDbType.VarChar).Value = dt.Value.ToString(format)
            sqlCommand.Parameters.Add("@Commission", MySqlDbType.Double).Value = Double.Parse(txtCashoutAmount.Text.Trim)
            sqlCommand.Parameters.Add("@Particular", MySqlDbType.Int64).Value = particularID
            sqlCommand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = txtDescription.Text.Trim
            sqlCommand.Parameters.Add("@ProjID", MySqlDbType.Int64).Value = lblProjectID.Text.Trim
            sqlCommand.Parameters.Add("@CreatedBy", MySqlDbType.Int64).Value = userLogon._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                sqlCommand.Dispose()
                loadSales(dt)
                loadDeduction(dt)
                lblTotalCashin.Text = 0.ToString("N2")
                txtCashoutAmount.Text = 0.ToString("N2")
                txtDescription.Text = ""
                btnSave.Enabled = False

                MessageBox.Show("Expenses successfully save.")
            End If
        Catch ex As Exception
            MessageBox.Show("Expenses: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub txtCashoutAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCashoutAmount.KeyUp
        If txtCashoutAmount.Text.Length > 0 And txtCashoutAmount.Text <> "." Then
            Dim cashin As Double = Double.Parse(lblTotalCashin.Text)
            Dim cashout As Double = Double.Parse(txtCashoutAmount.Text)
            If cashout > 0 And cashout <= cashin Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
        End If
    End Sub

End Class