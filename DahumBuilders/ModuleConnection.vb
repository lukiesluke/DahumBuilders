Imports MySql.Data.MySqlClient

Module ModuleConnection
    Public sqlConnection As New MySqlConnection
    Public sql As String
    Public sqlCommand As MySqlCommand
    Public sqlDataReader As MySqlDataReader
    Public sqlAdapter As MySqlDataAdapter
    Public fileLocationImage As String
    Public userLogon As User
    Public serverSetting As configurationSetting
    Public ini As New clsIni

    Public Sub Connection()
        Try
            Dim connStr As String = String.Format("Server={0}; Uid={1}; Pwd=@dmin@2020; Port=3306; Database=dahum_builders;", serverSetting._ip, serverSetting._username)
            sqlConnection = New MySqlConnection(connStr)
            sqlConnection.Open()
        Catch ex As Exception
            MsgBox("Please configure Database: " & ex.Message, MsgBoxStyle.Information, "Database")
        End Try
    End Sub

    Public Sub DahumConfiguration()
        ini = New clsIni
        serverSetting = New configurationSetting
        serverSetting._ip = ini.GetString("server_setting", "ip-address", "")
        serverSetting._username = ini.GetString("server_setting", "username", "")
    End Sub
End Module
