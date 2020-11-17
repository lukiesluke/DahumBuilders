Imports MySql.Data.MySqlClient
Public Class FormEmployeeRegistration
    Private Sub FormEmployeeRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        comboBoxSetting()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtName.Text.Trim.Length < 1 Then
            ShowMessageBox(txtName, "Please Enter Employee Name", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtSurname.Text.Trim.Length < 1 Then
            ShowMessageBox(txtSurname, "Please Enter Employee Surname", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtUsername.Text.Trim.Length < 1 Then
            ShowMessageBox(txtUsername, "Please Enter Employee username", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtPass1.Text.Trim.Length < 1 Then
            ShowMessageBox(txtPass1, "Please enter Password.", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtPass2.Text.Trim.Length < 1 Then
            ShowMessageBox(txtPass2, "Please enter Password.", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtPass1.Text.Trim <> txtPass2.Text.Trim Then
            ShowMessageBox(txtName, "Password does not match. Please enter again.", MessageBoxIcon.Question)
            Exit Sub
        ElseIf txtPass1.Text.Trim.Equals(txtPass2.Text.Trim) Then

            sql = "INSERT INTO `db_user_profile` 
            (`first_name`, `middle_name`, `last_name`, `address`, `gender`, `civil_status`, `telephone_number`,
            `mobile_number`, `email_address`, `username`, `password`, `created_by`, `user_type`) VALUES 
            (@first_name, @middle_name, @last_name, @address, @gender, @civilStatus, @telephone, 
            @mobile, @email, @username, @Password, @CreatedBy, '1')"

            Connection()
            sqlCommand = New MySqlCommand(sql, sqlConnection)

            sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtName.Text.Trim
            sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
            sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtSurname.Text.Trim
            sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
            sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = ComboBoxGender.Text.Trim

            sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = ComboBoxCivilStatus.Text.Trim
            sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
            sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
            sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim

            sqlCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text.Trim.ToLower
            sqlCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtUsername.Text.Trim
            sqlCommand.Parameters.Add("@CreatedBy", MySqlDbType.VarChar).Value = username

            Try
                If sqlCommand.ExecuteNonQuery() = 1 Then
                    ShowMessageBox(Nothing, "Employee Profile Successfully Saved.", MessageBoxIcon.Information)
                    sqlCommand.Dispose()
                    sqlConnection.Close()
                    Me.Close()
                Else
                    ShowMessageBox(Nothing, "Data NOT Inserted. Please try again.", MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("Saving error: " & ex.Message)
            Finally
                sqlCommand.Dispose()
                sqlConnection.Close()
            End Try
        End If
    End Sub

    Private Sub comboBoxSetting()
        With Me.ComboBoxGender.Items
            .Add("Male")
            .Add("Female")
        End With

        With Me.ComboBoxCivilStatus.Items
            .Add("Single")
            .Add("Married")
            .Add("Separated")
            .Add("Widow")
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub ShowMessageBox(txtbox As TextBox, message As String, icon As MessageBoxIcon)
        Dim ret As DialogResult = MessageBox.Show(Me, message, "Employee Profile", MessageBoxButtons.OK, icon)
        Select Case ret
            Case DialogResult.OK
                If txtbox IsNot Nothing Then
                    txtbox.Focus()
                End If
                Exit Sub
        End Select
    End Sub
End Class