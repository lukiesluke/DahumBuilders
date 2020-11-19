Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "SELECT `id`,`username`, `password`,`user_type` FROM `db_user_profile` WHERE `username` LIKE @Username AND `password` LIKE @Password"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@Username", MySqlDbType.VarChar).Value = txtUsername.Text.Trim
        sqlCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtPassword.Text.Trim
        Try
            sqlDataReader = sqlCommand.ExecuteReader()
            userLogon = New User
            Do While sqlDataReader.Read = True
                With userLogon
                    ._id = sqlDataReader("id")
                    ._username = sqlDataReader("username")
                    ._password = sqlDataReader("password")
                End With
                Exit Do
            Loop
            If userLogon._username.Equals(txtUsername.Text.Trim.ToLower) And userLogon._password.Equals(txtPassword.Text.Trim) Then
                showMainForm()
                Me.Close()
            Else
                MessageBox.Show("Invaild username or password please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Saving error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub showMainForm()
        If Application.OpenForms().OfType(Of FormMainDahum).Any Then
            mFormMainDahum.Focus()
        Else
            mFormMainDahum = New FormMainDahum
            mFormMainDahum.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class