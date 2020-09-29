Imports MySql.Data.MySqlClient

Public Class FormUserProfile

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        sql = "INSERT INTO `db_user_profile` 
        (`first_name`, `middle_name`, `last_name`, `address`, `gender`, `civil_status`, `date_birth`, 
        `place_birth`, `citizenship`, `telephone_number`, `mobile_number`, `email_address`, 
        `occupation`, `company_name`, `spouse_name`, `spouse_occupation`, `spouse_contact`, 
        `father_name`, `father_provincial_address`, `mother_name`, `mother_provincial_address`, `username`) 
         VALUES (@first_name, @middle_name, @last_name, @address, @gender, @civilStatus, @dateBirth,
        @placeBirth, @citizenship, @telephone, @mobile, @email, @occupation, @companyName, @spouseName, 
        @spouseOccupation, @spouseContact, @fatherName, @fatherAddress, @MotherName, @MotherAddress, @username)"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)

        sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtFirstName.Text.Trim
        sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
        sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtLastName.Text.Trim
        sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
        sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = txtGender.Text.Trim

        sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = txtCivilStatus.Text.Trim
        sqlCommand.Parameters.Add("@dateBirth", MySqlDbType.Date).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@placeBirth", MySqlDbType.VarChar).Value = txtPlaceBirth.Text.Trim
        sqlCommand.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = txtCitizen.Text.Trim
        sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
        sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
        sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim
        sqlCommand.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = txtOccupation.Text.Trim
        sqlCommand.Parameters.Add("@companyName", MySqlDbType.VarChar).Value = txtCompanyName.Text.Trim

        sqlCommand.Parameters.Add("@spouseName", MySqlDbType.VarChar).Value = txtSpouseName.Text.Trim
        sqlCommand.Parameters.Add("@spouseOccupation", MySqlDbType.VarChar).Value = txtSpouseOccupation.Text.Trim
        sqlCommand.Parameters.Add("@spouseContact", MySqlDbType.VarChar).Value = txtSpouseContactNumber.Text.Trim

        sqlCommand.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = txtFatherName.Text.Trim
        sqlCommand.Parameters.Add("@fatherAddress", MySqlDbType.VarChar).Value = txtFatherAddress.Text.Trim
        sqlCommand.Parameters.Add("@MotherName", MySqlDbType.VarChar).Value = txtMotherName.Text.Trim
        sqlCommand.Parameters.Add("@MotherAddress", MySqlDbType.VarChar).Value = txtMotherAddress.Text.Trim
        sqlCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = username

        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtFirstName.Text = ""
                txtMiddleName.Text = ""
                txtLastName.Text = ""
                txtGender.Text = ""
                txtAddress.Text = ""
                insertDataToChildAndBeneficiary(sqlCommand, sqlConnection, username)
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

    Function insertDataToChildAndBeneficiary(cmd As MySqlCommand, conn As MySqlConnection, user As String)
        Dim table As New DataTable()

        sql = "SELECT MAX(id) AS id FROM db_user_profile WHERE username=@username"
        cmd = New MySqlCommand(sql, conn)
        sqlAdapter = New MySqlDataAdapter(cmd)
        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user
        sqlAdapter.Fill(table)

        If ListViewChild.Items.Count > 0 Then

            sql = "INSERT INTO `db_user_child` 
            (`first_name`, `middle_name`, `last_name`, `userid`) 
            VALUES (@firstName, @middleName, @lastName, @userid)"

            For Each item As ListViewItem In Me.ListViewChild.Items
                cmd = New MySqlCommand(sql, conn)
                sqlAdapter = New MySqlDataAdapter(cmd)
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                cmd.Parameters.Add("@middleName", MySqlDbType.VarChar).Value = item.SubItems.Item(2).Text.Trim
                cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = item.SubItems.Item(3).Text.Trim
                cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = table.Rows(0)("id").ToString
                cmd.ExecuteNonQuery()
            Next
        End If

        If ListViewBeneficiary.Items.Count > 0 Then

            sql = "INSERT INTO `db_user_beneficiary` 
            (`first_name`, `middle_name`, `last_name`, `userid`) 
            VALUES (@firstName, @middleName, @lastName, @userid)"

            For Each item As ListViewItem In Me.ListViewBeneficiary.Items
                cmd = New MySqlCommand(sql, conn)
                sqlAdapter = New MySqlDataAdapter(cmd)
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                cmd.Parameters.Add("@middleName", MySqlDbType.VarChar).Value = item.SubItems.Item(2).Text.Trim
                cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = item.SubItems.Item(3).Text.Trim
                cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = table.Rows(0)("id").ToString
                cmd.ExecuteNonQuery()
            Next
        End If

    End Function


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim table As New DataTable()

        sql = "SELECT * FROM `db_user_profile` WHERE `Id` = @id"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = txtGender.Text
        sqlAdapter = New MySqlDataAdapter(sqlCommand)

        Try
            sqlAdapter.Fill(table)

            If table.Rows.Count > 0 Then
                txtFirstName.Text = table.Rows(0)("first_name")
                txtMiddleName.Text = table.Rows(0)("middle_name")
                txtLastName.Text = table.Rows(0)("last_name")
                txtGender.Text = table.Rows(0)("gender")
                txtAddress.Text = table.Rows(0)("address")
                DateTimePicker1.Value = table.Rows(0)("date_birth")
            Else
                txtFirstName.Text = ""
                txtMiddleName.Text = ""
                txtLastName.Text = ""
                txtGender.Text = ""
                txtAddress.Text = ""
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        MessageBox.Show(Format(DateTimePicker1.Value, "MM-dd-yyyy"))
    End Sub

    Private Sub btnAddChild_Click(sender As Object, e As EventArgs) Handles btnAddChild.Click

        If txtChildName.Text.Trim.Length > 0 And txtChildSurname.Text.Trim.Length > 0 Then
            Dim item As New ListViewItem(ListViewChild.Items.Count + 1)
            item.SubItems.Add(txtChildName.Text.Trim)
            item.SubItems.Add(txtChildMiddleName.Text.Trim)
            item.SubItems.Add(txtChildSurname.Text.Trim)
            ListViewChild.Items.Add(item)

            txtChildName.Text = ""
            txtChildMiddleName.Text = txtChildMiddleName.Text.Trim
            txtChildSurname.Text = txtChildSurname.Text.Trim
        Else
            txtChildName.Text = txtChildName.Text.Trim()
            txtChildMiddleName.Text = txtChildMiddleName.Text.Trim()
            txtChildSurname.Text = txtChildSurname.Text.Trim()

            If txtChildName.Text.Length < 1 Then
                MsgBox("Please Enter Child Name.", MsgBoxStyle.Information, "Child Information")
                txtChildName.Focus()
                GoTo end_of_if
            End If

            If txtChildSurname.Text.Length < 1 Then
                MsgBox("Please Enter Child Surname.", MsgBoxStyle.Information, "Child Information")
                txtChildSurname.Focus()
            End If
end_of_if:
        End If

    End Sub

    Private Sub btnAddBeneficiary_Click(sender As Object, e As EventArgs) Handles btnAddBeneficiary.Click
        If txtBeneficiaryName.Text.Trim.Length > 0 And txtBeneficiarySurname.Text.Trim.Length > 0 Then

            Dim item As New ListViewItem(ListViewBeneficiary.Items.Count + 1)
            item.SubItems.Add(txtBeneficiaryName.Text.Trim)
            item.SubItems.Add(txtBeneficiaryMiddleName.Text.Trim)
            item.SubItems.Add(txtBeneficiarySurname.Text.Trim)
            ListViewBeneficiary.Items.Add(item)

            txtBeneficiaryName.Text = ""
            txtBeneficiaryMiddleName.Text = ""
            txtBeneficiarySurname.Text = ""

        Else

            If txtBeneficiaryName.Text.Trim.Length < 1 Then
                MsgBox("Please Enter Beneficiary Name.", MsgBoxStyle.Information, "Beneficiary Information")
                txtBeneficiaryName.Focus()
                GoTo end_of_if
            End If

            If txtBeneficiarySurname.Text.Trim.Length < 1 Then
                MsgBox("Please Enter Beneficiary Surname.", MsgBoxStyle.Information, "Beneficiary Information")
                txtBeneficiarySurname.Focus()
            End If
end_of_if:

        End If
    End Sub

    Private Sub btnClearListBeneficiary_Click(sender As Object, e As EventArgs) Handles btnClearListBeneficiary.Click

        ListViewBeneficiary.Items.Clear()
        txtBeneficiaryName.Focus()

        txtBeneficiaryName.Text = ""
        txtBeneficiaryMiddleName.Text = ""
        txtBeneficiarySurname.Text = ""
    End Sub

    Private Sub btnClearListChild_Click(sender As Object, e As EventArgs) Handles btnClearListChild.Click

        ListViewChild.Items.Clear()
        txtChildName.Focus()

        txtChildName.Text = ""
        txtChildMiddleName.Text = ""
        txtChildSurname.Text = ""
    End Sub

    Private Sub txtChildName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtChildName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddChild.PerformClick()
        End If
    End Sub

    Private Sub txtChildSurname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtChildSurname.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddChild.PerformClick()
        End If
    End Sub

    Private Sub txtBeneficiaryName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBeneficiaryName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddBeneficiary.PerformClick()
        End If
    End Sub

    Private Sub txtBeneficiarySurname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBeneficiarySurname.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddBeneficiary.PerformClick()
        End If
    End Sub
End Class
