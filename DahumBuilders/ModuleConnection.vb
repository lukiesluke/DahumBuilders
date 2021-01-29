Imports MySql.Data.MySqlClient
Imports FireSharp.Config

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

    'Firebase variable
    Public pathSummary As String = "summary/"
    Public pathSummaryTest As String = "summaryTest/"

    Public pathProject As String = "project/"
    Public pathProjectTest As String = "projectTest/"

    Public fireCon As New FirebaseConfig() With {
        .AuthSecret = "g8tKN67dcGPFLnYw7bLXIivT3j3cd7SEpYbBoOFZ",
        .BasePath = "https://dahum-builders-corporation-default-rtdb.firebaseio.com/"
        }

    Public Sub Connection()
        Try
            Dim connStr As String = String.Format("Server={0}; Uid={1}; Pwd=; Port=3306; Database=dahum_builders;", serverSetting._ip, serverSetting._username)
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
