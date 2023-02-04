Imports System.Net
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private onCancelClick As Boolean = False
    Private tries As Integer = 0
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim host_name As String = Dns.GetHostName()
        Dim ip_address As String = Dns.GetHostByName(host_name).AddressList(0).ToString()
        FormMainDahum.ToolStripMyIP.Text = ip_address

        lblCompanyName.Text = ModuleConnection.CompanyName
        mFormMainDahum.Text = ModuleConnection.CompanyName

        tries = 0
        lblMessage.Visible = False
        lblIP.Text = String.Format("server: {0}", serverSetting._ip)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtCustomeIP.Text = txtCustomeIP.Text.Trim.Replace(" ", "")

        If chBoxCustomIP.Checked = True And txtCustomeIP.Text.Trim.Length >= 7 Then
            ini = New clsIni
            ini.WriteString("server_setting", "ip-address-custome", txtCustomeIP.Text.Trim)
        ElseIf chBoxCustomIP.Checked = True And txtCustomeIP.Text.Trim.Length < 7 Then
            MessageBox.Show("Please enter valid IP Address.")
            txtCustomeIP.Focus()
            Exit Sub
        End If

        DahumConfiguration(chBoxCustomIP, txtCustomeIP.Text)

        If validateLogin() = False Then
            lblMessage.Text = "Please enter username/password."
            lblMessage.Visible = True
            Exit Sub
        End If

        sql = "SELECT `id`, CONCAT(`first_name`, ' ', `middle_name`, ' ', `last_name`) AS 'name', 
        `username`, `password`,`user_type`, (SELECT `type` FROM `db_user_type` WHERE `id`=`user_type`) nameType FROM `db_user_profile` WHERE `username` LIKE @Username AND `password` LIKE @Password"
        Cursor = Cursors.WaitCursor
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
                    ._userTypeStr = sqlDataReader("nameType")
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
            Cursor = Cursors.Default
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chBoxCustomIP.CheckedChanged
        If chBoxCustomIP.Checked = True Then

            txtCustomeIP.Visible = True
            lblIP.Visible = False

            ini = New clsIni
            txtCustomeIP.Text = ini.GetString("server_setting", "ip-address-custome", "")
            txtCustomeIP.Focus()

        Else
            txtCustomeIP.Visible = False
            lblIP.Visible = True
        End If
    End Sub

End Class