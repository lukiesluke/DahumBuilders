Imports MySql.Data.MySqlClient

Public Class FormCategorySetting
    Private Sub FormCategorySetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmpID.Text = ""
        lblExpID.Text = ""
        enableButton(False)
        loadEmployeeType()
    End Sub

    Private Sub loadEmployeeType()
        Cursor = Cursors.WaitCursor
        Connection()
        Dim item As ListViewItem
        Try
            ListViewEmpType.Items.Clear()
            sql = "SELECT `id`,`type` FROM `db_user_type`"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.SubItems.Add(sqlDataReader("type"))
                ListViewEmpType.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub loadExpensesType()
        Cursor = Cursors.WaitCursor
        Connection()
        Dim item As ListViewItem
        Try
            ListViewExpType.Items.Clear()
            sql = "SELECT `id`,`name`,`short_name` FROM `db_particular_type` WHERE `id`>5"
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.SubItems.Add(sqlDataReader("name"))
                item.SubItems.Add(sqlDataReader("short_name"))
                ListViewExpType.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        btnAddEmp.Visible = False
        btnUpdateEmp.Visible = True
        btnCancelEmp.Visible = True
        lblAddEmp.Visible = False
        txtNameEmp.Focus()
        txtNameEmp.SelectionStart = txtNameEmp.Text.Length
    End Sub

    Private Sub enableButton(enable As Boolean)
        'Employee Type
        btnAddEmp.Visible = enable
        btnUpdateEmp.Visible = enable
        btnCancelEmp.Visible = enable
        lblAddEmp.Visible = True

        'Expenses Type
        btnAddExp.Visible = enable
        btnUpdateExp.Visible = enable
        btnCancelExp.Visible = enable
        lblAddExp.Visible = True
    End Sub

    Private Sub btnCancelEmp_Click(sender As Object, e As EventArgs) Handles btnCancelEmp.Click
        enableButton(False)
        lblEmpID.Text = ""
        txtNameEmp.Text = ""
    End Sub

    Private Sub ListViewEmpType_Click(sender As Object, e As EventArgs) Handles ListViewEmpType.Click, ListViewEmpType.KeyUp
        If ListViewEmpType.Items.Count > 0 Then
            lblEmpID.Text = ListViewEmpType.SelectedItems(0).Text
            txtNameEmp.Text = ListViewEmpType.SelectedItems(0).SubItems(1).Text
            enableButton(False)
            lblAddEmp.Visible = True
        End If
    End Sub

    Private Sub lblAddEmp_Click(sender As Object, e As EventArgs) Handles lblAddEmp.Click
        btnAddEmp.Visible = True
        btnUpdateEmp.Visible = False
        btnCancelEmp.Visible = True
        lblAddEmp.Visible = False
        lblEmpID.Text = ""
        txtNameEmp.Text = ""
        txtNameEmp.Focus()
    End Sub

    Private Sub btnUpdateEmp_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp.Click
        If txtNameEmp.Text.Trim.Length > 0 And lblEmpID.Text.Length > 0 Then
            sql = "UPDATE `db_user_type` SET `type` = @NameType WHERE `id`=@ID;"
            updateType(1, sql, txtNameEmp.Text.Trim, "", lblEmpID.Text)
        Else
            MessageBox.Show("Please Enter Employee Type.")
            txtNameEmp.Focus()
        End If
    End Sub
    Private Sub btnUpdateExp_Click(sender As Object, e As EventArgs) Handles btnUpdateExp.Click
        If txtNameExp.Text.Trim.Length > 0 And lblExpID.Text.Length > 0 And txtShortName.Text.Trim.Length > 0 Then
            sql = "UPDATE `db_particular_type` SET `name`=@NameType, `short_name`=@ShortName WHERE `id`=@ID;"
            updateType(2, sql, txtNameExp.Text.Trim, txtShortName.Text.Trim, lblExpID.Text)
        Else
            MessageBox.Show("Please Enter Expenses Type.")
            txtNameEmp.Focus()
        End If
    End Sub
    Private Sub updateType(type As Integer, sqlCmd As String, nameType As String, shortName As String, idType As String)
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@NameType", MySqlDbType.VarChar).Value = nameType
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = idType
            If type = 2 Then
                sqlCommand.Parameters.Add("@ShortName", MySqlDbType.VarChar).Value = shortName
            End If

            If sqlCommand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Successfully Updated")
                If type = 1 Then
                    loadEmployeeType()
                Else
                    loadExpensesType()
                End If

                enableButton(False)
                'Employee type set empty
                lblEmpID.Text = ""
                txtNameEmp.Text = ""

                'Expenses type set empty
                lblExpID.Text = ""
                txtNameExp.Text = ""
                txtShortName.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to update record!")
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        If txtNameEmp.Text.Trim.Length > 0 Then
            sql = "INSERT INTO `db_user_type` (`type`) VALUES (@NameType);"
            addType(1, sql, txtNameEmp.Text.Trim, "")
        Else
            MessageBox.Show("Please Enter Employee Type!")
            txtNameEmp.Focus()
        End If
    End Sub
    Private Sub btnAddExp_Click(sender As Object, e As EventArgs) Handles btnAddExp.Click
        If txtNameExp.Text.Trim.Length > 0 And txtShortName.Text.Length > 0 Then
            sql = "INSERT INTO `db_particular_type` (`name`, `short_name`) VALUES (@NameType, @ShortName);"
            addType(2, sql, txtNameExp.Text.Trim, txtShortName.Text.Trim)
        Else
            MessageBox.Show("Please Enter Expenses type and short name!")
            txtNameExp.Focus()
        End If
    End Sub
    Private Sub addType(type As Integer, sqlCmd As String, nameType As String, shortName As String)
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@NameType", MySqlDbType.VarChar).Value = nameType
            If type = 2 Then
                sqlCommand.Parameters.Add("@ShortName", MySqlDbType.VarChar).Value = shortName
            End If
            If sqlCommand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Successfully Added")
                If type = 1 Then
                    loadEmployeeType()
                Else
                    loadExpensesType()
                End If

                enableButton(False)
                'Employee type set empty
                lblEmpID.Text = ""
                txtNameEmp.Text = ""

                'Expenses type set empty
                lblExpID.Text = ""
                txtNameExp.Text = ""
                txtShortName.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to Add record! " & vbNewLine & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub lblAddExp_Click(sender As Object, e As EventArgs) Handles lblAddExp.Click
        btnAddExp.Visible = True
        btnUpdateExp.Visible = False
        btnCancelExp.Visible = True
        lblAddExp.Visible = False
        lblExpID.Text = ""
        txtNameExp.Text = ""
        txtNameExp.Focus()
        txtShortName.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            'Expenses type set empty
            lblExpID.Text = ""
            txtNameExp.Text = ""
            txtShortName.Text = ""

            enableButton(False)
            loadExpensesType()
        Else
            'Employee type set empty
            lblEmpID.Text = ""
            txtNameEmp.Text = ""
            loadEmployeeType()
        End If
    End Sub

    Private Sub ListViewExpType_Click(sender As Object, e As EventArgs) Handles ListViewExpType.Click, ListViewExpType.KeyUp
        If ListViewExpType.Items.Count > 0 Then
            lblExpID.Text = ListViewExpType.SelectedItems(0).Text
            txtNameExp.Text = ListViewExpType.SelectedItems(0).SubItems(1).Text
            txtShortName.Text = ListViewExpType.SelectedItems(0).SubItems(2).Text
            enableButton(False)
            lblAddEmp.Visible = True
        End If
    End Sub

    Private Sub btnCancelExp_Click(sender As Object, e As EventArgs) Handles btnCancelExp.Click
        enableButton(False)
        lblExpID.Text = ""
        txtNameExp.Text = ""
        txtShortName.Text = ""
    End Sub

    Private Sub EditExpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditExpToolStripMenuItem1.Click
        btnAddExp.Visible = False
        btnUpdateExp.Visible = True
        btnCancelExp.Visible = True
        lblAddExp.Visible = False
        txtNameExp.Focus()
        txtNameExp.SelectionStart = txtNameExp.Text.Length
    End Sub

End Class