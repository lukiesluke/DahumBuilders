Imports MySql.Data.MySqlClient

Public Class FormUserProfile
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dahum_builders")


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `db_user_profile`
            (`first_name`,`middle_name`,`last_name`,`gender`,`address`) 
            VALUES (@first_name,@middle_name,@last_name,@gender,@address)", connection)

        insert_command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtFirstName.Text
        insert_command.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text
        insert_command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtLastName.Text
        insert_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = txtGender.Text
        insert_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text

        If execCommand(insert_command) Then
            txtFirstName.Text = ""
            txtMiddleName.Text = ""
            txtLastName.Text = ""
            txtGender.Text = ""
            txtAddress.Text = ""
            MessageBox.Show("Successfully Saved")

        Else

            MessageBox.Show("Data NOT Inserted")

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sql_command As New MySqlCommand("SELECT * FROM `db_user_profile` WHERE `Id` = @id", connection)
        sql_command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtGender.Text
        Dim adapter As New MySqlDataAdapter(sql_command)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)

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
        End Try
    End Sub

    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

End Class
