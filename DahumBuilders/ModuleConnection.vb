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
            sqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dahum_builders")
            sqlConnection.Open()
        Catch ex As Exception
            MsgBox("Please configure Database", MsgBoxStyle.Information, "Database")
        End Try
    End Sub
End Module
