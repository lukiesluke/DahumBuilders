Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private onCancelClick As Boolean = False
    Private tries As Integer = 0
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCompanyName.Text = ModuleConnection.CompanyName
        mFormMainDahum.Text = ModuleConnection.CompanyName
        tries = 0
        lblMessage.Visible = False
        lblIP.Text = String.Format("server: {0}", serverSetting._ip)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DahumConfiguration()
        If validateLogin() = False Then
            lblMessage.Text = "Please enter username/password."
            lblMessage.Visible = True
            Exit Sub
        End If

        sql = "SELECT `id`, CONCAT(`first_name`, ' ', `middle_name`, ' ', `last_name`) AS 'name', `username`, `password`,`user_type` FROM `db_user_profile` WHERE `username` LIKE @Username AND `password` LIKE @Password"
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
                    ._name = sqlDataReader("name")
                    ._username = sqlDataReader("username")
                    ._password = sqlDataReader("password")
                End With
                Exit Do
            Loop
            If userLogon._username.Equals(txtUsername.Text.Trim.ToLower) And userLogon._password.Equals(txtPassword.Text.Trim) Then
                showMainForm()
                Me.Close()
            Else
                Dim result As String = String.Empty
                result = String.Format("Invaild username or password please try again. Attemp ({0})", tries + 1)
                tries += 1
                lblMessage.Text = result
                lblMessage.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
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
        onCancelClick = True
        End
    End Sub
    Private Sub txtUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyUp
        txtPassword_KeyUp(sender, e)
    End Sub
    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            Me.Focus()
        End If
    End Sub

    Private Function validateLogin() As Boolean
        Dim pass As Boolean = True
        If txtUsername.Text.Trim.Length < 5 Then
            pass = False
        ElseIf txtPassword.Text.Trim.Length < 5 Then
            pass = False
        End If
        Return pass
    End Function
End Class