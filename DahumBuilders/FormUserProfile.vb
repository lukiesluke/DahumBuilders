Imports MySql.Data.MySqlClient

Public Class FormUserProfile

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        sql = "INSERT INTO `db_user_profile` 
        (`first_name`, `middle_name`, `last_name`, `address`, `gender`, `civil_status`, `date_birth`, 
        `place_birth`, `citizenship`, `telephone_number`, `mobile_number`, `email_address`, 
        `occupation`, `company_name`, `spouse_name`, `spouse_occupation`, `spouse_contact`, 
        `father_name`, `father_provincial_address`, `mother_name`, `mother_provincial_address`) 
         VALUES (@first_name, @middle_name, @last_name, @address, @gender, @civilStatus, @dateBirth,
        @placeBirth, @citizenship, @telephone, @mobile, @email, @occupation, @companyName, '', '', '', 
        @fatherName, @fatherAddress, @MotherName, @MotherAddress)"

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

        sqlCommand.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = txtFatherName.Text.Trim
        sqlCommand.Parameters.Add("@fatherAddress", MySqlDbType.VarChar).Value = txtFatherAddress.Text.Trim
        sqlCommand.Parameters.Add("@MotherName", MySqlDbType.VarChar).Value = txtMotherName.Text.Trim
        sqlCommand.Parameters.Add("@MotherAddress", MySqlDbType.VarChar).Value = txtMotherAddress.Text.Trim

        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtFirstName.Text = ""
                txtMiddleName.Text = ""
                txtLastName.Text = ""
                txtGender.Text = ""
                txtAddress.Text = ""

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
            Dim item As New ListViewItem(txtChildName.Text.Trim)
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

End Class
