Imports MySql.Data.MySqlClient

Module ModuleConnection
    Public sqlConnection As New MySqlConnection
    Public sql As String
    Public sqlCommand As MySqlCommand
    Public sqlDataReader As MySqlDataReader
    Public sqlAdapter As MySqlDataAdapter
    Public fileLocationImage As String
    Public userLogon As User
    Public Sub Connection()
        Try
            Dim connStr As String = "Server=192.168.1.9; Uid=admin; Pwd=@dmin@2020; Port=3306; Database=dahum_builders;"
            'sqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=admin;password=@dmin@2020;database=dahum_builders")
            sqlConnection = New MySqlConnection(connStr)
            sqlConnection.Open()
        Catch ex As Exception
            MsgBox("Please configure Database: " & ex.Message, MsgBoxStyle.Information, "Database")
        End Try
    End Sub
End Module
