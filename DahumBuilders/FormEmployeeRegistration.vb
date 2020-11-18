Imports MySql.Data.MySqlClient
Public Class FormEmployeeRegistration
    Public Property mUser As User = New User()
    Public Property mUpdate As Boolean = False

    Private Sub FormEmployeeRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        comboBoxSetting()
        If mUpdate = True Then
            btnSearch.PerformClick()
            btnSave.Visible = False
            btnUpdate.Visible = True
        Else
            btnUpdate.Visible = False
            btnSave.Visible = True
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sql = "SELECT `first_name`, `middle_name`, `last_name`,
        `address`, `gender`, `civil_status`, `date_birth`, `telephone_number`, `mobile_number`,
        `email_address`, `username`, `password` FROM `db_user_profile` WHERE `id`=@ID"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int64).Value = userID
            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                mUser = New User
                With mUser
                    ._name = sqlDataReader("first_name")
                    ._middleName = sqlDataReader("middle_name")
                    ._surname = sqlDataReader("last_name")
                    ._address = sqlDataReader("address")
                    ._gender = sqlDataReader("gender")
                    ._civilStatus = sqlDataReader("civil_status")
                    ._dateOfBirth = sqlDataReader("date_birth")
                    ._mobile = sqlDataReader("mobile_number")
                    ._telephone = sqlDataReader("telephone_number")
                    ._email = sqlDataReader("email_address")
                    ._username = sqlDataReader("username")
                    ._password = sqlDataReader("password")
                End With
            Loop

            txtName.Text = mUser._name
            txtSurname.Text = mUser._surname
            txtMiddleName.Text = mUser._middleName
            ComboBoxCivilStatus.Text = mUser._civilStatus
            ComboBoxGender.Text = mUser._gender
            txtAddress.Text = mUser._address
            txtMobile.Text = mUser._mobile
            DateTimePicker1.Value = mUser._dateOfBirth
            txtTelephone.Text = mUser._telephone
            txtEmail.Text = mUser._email
            txtUsername.Text = mUser._username
            txtPass1.Text = mUser._password
            txtPass2.Text = mUser._password
            sqlDataReader.Dispose()

        Catch ex As Exception
            MessageBox.Show("Saving error: " & ex.Message)
        Finally
        sqlCommand.Dispose()
        sqlConnection.Close()
        End Try

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If validation() = False Then
            Exit Sub
        End If

        If txtPass1.Text.Trim.Equals(txtPass2.Text.Trim) Then
            sql = "UPDATE `db_user_profile` SET `first_name`=@first_name, `middle_name`= @middle_name, `last_name`=@last_name,
            `address`=@address, `gender`=@gender, `civil_status`=@civilStatus, `date_birth`=@dateBirth, `telephone_number`= @telephone,
            `mobile_number`=@mobile, `email_address`=@email, `username`=@username, `password`=@Password, `modified_by`=@ModifiedBy,
            `modified_date`=@ModifiedDate WHERE `id`=@ID"

            Connection()
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtName.Text.Trim
            sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
            sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtSurname.Text.Trim
            sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
            sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = ComboBoxGender.Text.Trim

            sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = ComboBoxCivilStatus.Text.Trim
            sqlCommand.Parameters.Add("@dateBirth", MySqlDbType.Date).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
            sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
            sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
            sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim

            sqlCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text.Trim.ToLower
            sqlCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtPass1.Text.Trim
            sqlCommand.Parameters.Add("@ModifiedBy", MySqlDbType.VarChar).Value = username
            sqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = userID
            sqlCommand.Parameters.Add("@ModifiedDate", MySqlDbType.DateTime).Value = DateTime.Now

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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validation() = False Then
            Exit Sub
        End If

        If txtPass1.Text.Trim.Equals(txtPass2.Text.Trim) Then

            sql = "INSERT INTO `db_user_profile` 
            (`first_name`, `middle_name`, `last_name`, `address`, `gender`, `civil_status`, `date_birth`, `telephone_number`,
            `mobile_number`, `email_address`, `username`, `password`, `created_by`, `user_type`) VALUES 
            (@first_name, @middle_name, @last_name, @address, @gender, @civilStatus, @dateBirth, @telephone, 
            @mobile, @email, @username, @Password, @CreatedBy, '1')"

            Connection()
            sqlCommand = New MySqlCommand(sql, sqlConnection)

            sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtName.Text.Trim
            sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
            sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtSurname.Text.Trim
            sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
            sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = ComboBoxGender.Text.Trim

            sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = ComboBoxCivilStatus.Text.Trim
            sqlCommand.Parameters.Add("@dateBirth", MySqlDbType.Date).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
            sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
            sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
            sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim

            sqlCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text.Trim.ToLower
            sqlCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtPass1.Text.Trim
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
        ComboBoxGender.SelectedIndex = 0
        ComboBoxCivilStatus.SelectedIndex = 0
    End Sub
    Function validation() As Boolean
        Dim pass As Boolean = True
        If txtName.Text.Trim.Length < 1 Then
            ShowMessageBox(txtName, "Please Enter Employee Name", MessageBoxIcon.Question)
            pass = False
            Exit Function
        ElseIf txtSurname.Text.Trim.Length < 1 Then
            ShowMessageBox(txtSurname, "Please Enter Employee Surname", MessageBoxIcon.Question)
            pass = False
            Exit Function
        ElseIf txtUsername.Text.Trim.Length < 1 Then
            ShowMessageBox(txtUsername, "Please Enter Employee username", MessageBoxIcon.Question)
            pass = False
            Exit Function
        ElseIf txtPass1.Text.Trim.Length < 1 Then
            ShowMessageBox(txtPass1, "Please enter Password.", MessageBoxIcon.Question)
            pass = False
            Exit Function
        ElseIf txtPass2.Text.Trim.Length < 1 Then
            ShowMessageBox(txtPass2, "Please enter Password.", MessageBoxIcon.Question)
            pass = False
            Exit Function
        ElseIf txtPass1.Text.Trim <> txtPass2.Text.Trim Then
            ShowMessageBox(txtName, "Password does not match. Please enter again.", MessageBoxIcon.Question)
            pass = False
            Exit Function
        End If
        Return pass
    End Function
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