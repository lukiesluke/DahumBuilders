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
    Public iniTax As New clsIniTax
    Public mVerification As Boolean
    Public taxAmount As Double = 0.12

    'Delete Constant
    Public delExpensesID As String = "delExpensesID"

    'Public CompanyName As String = "Dahum Builders and Development Corporation"
    'Public CompanyAddress As String = "3rd floor, T. De Castro Bldg, Emilio Aguinaldo Hwy, Palico 1, Imus, 4103 Cavite"

    Public CompanyName As String = "BayLeaf Development and Real Estate Corporation"
    Public CompanyAddress As String = "Brgy Halang, Naic, Cavite City"

    'Firebase variable
    Public pathSummary As String = "summary/"
    Public pathSummaryTest As String = "summaryTest/"
    Public pathSummaryLogs As String = "summaryLogs/"

    Public pathProject As String = "project/"
    Public pathProjectTest As String = "projectTest/"
    Public pathProjectLogs As String = "projectLogs/"

    Public fireCon As New FirebaseConfig() With {
        .AuthSecret = "3zPFq1X41jpyd8jGBdk6dM50tXG3vO0x7LQGNFj8",
        .BasePath = "https://xxxtprealtydevelopmentcorp-28101-default-rtdb.firebaseio.com/"
        }

    'Public fireCon As New FirebaseConfig() With {
    '    .AuthSecret = "g8tKN67dcGPFLnYw7bLXIivT3j3cd7SEpYbBoOFZ",
    '    .BasePath = "https://dahum-builders-corporation-default-rtdb.firebaseio.com/"
    '    }

    Public Sub Connection()
        Try
            'Pwd=admin88@2021
            'BayLeafPWD=admin88
            Dim connStr As String = String.Format("Server={0}; Uid={1}; Pwd={2}; Port=3306; Database=dahum_builders; Connect Timeout={3}", serverSetting._ip, serverSetting._username, serverSetting._database, serverSetting._connTimeout)
            sqlConnection = New MySqlConnection(connStr)
            sqlConnection.Open()
        Catch ex As Exception
            MsgBox("Please configure Database: " & ex.Message, MsgBoxStyle.Information, "Database")
        End Try
    End Sub

    Public Sub DahumConfiguration(checkBox As CheckBox, customIP As String)
        ini = New clsIni
        Dim ip As String = ""
        serverSetting = New configurationSetting
        If checkBox.Checked Then
            ip = customIP
        Else
            ip = ini.GetString("server_setting", "ip-address", "")
        End If

        serverSetting._ip = ip
        serverSetting._username = ini.GetString("server_setting", "username", "")
        serverSetting._connTimeout = ini.GetString("server_setting", "connect-timeout", "28800")
        serverSetting._database = ini.GetString("server_setting", "database", "")
    End Sub

    Public Sub DahumConfiguration()
        ini = New clsIni
        serverSetting = New configurationSetting

        serverSetting._ip = ini.GetString("server_setting", "ip-address", "")
        serverSetting._username = ini.GetString("server_setting", "username", "")
        serverSetting._connTimeout = ini.GetString("server_setting", "connect-timeout", "28800")
        serverSetting._database = ini.GetString("server_setting", "database", "")
    End Sub

    Public Sub TaxConfiguration()
        iniTax = New clsIniTax
        taxAmount = Convert.ToDouble(iniTax.GetString("server_setting", "tax_base", "0.00"))
    End Sub
End Module
