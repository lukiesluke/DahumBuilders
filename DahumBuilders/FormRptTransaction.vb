Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class FormRptTransaction
    Public Property mUser As User = New User()

    Private Sub FormRptTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        generate_report()
    End Sub

    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`,`paid_amount`, t.`discount_amount`, pt.`name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`name` AS `particular`, `date_paid` 
        FROM `db_transaction` t INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id`
        WHERE t.`userid`=@userId ORDER BY date_paid, t.`particular`, t.`part_no`, t.`official_receipt_no` ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim rpt As New ReportDataSource("Customer", table)
            Dim rParam As New ReportParameterCollection

            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt)
            rParam.Add(New ReportParameter("ReportParameterClientName", mUser._name & " " & mUser._middleName & " " & mUser._surname))
            rParam.Add(New ReportParameter("ReportParameterAddress", mUser._address))
            rParam.Add(New ReportParameter("ReportParameterMobile", mUser._mobile))
            Me.ReportViewer1.LocalReport.SetParameters(rParam)
            Me.ReportViewer1.RefreshReport()
            ''ReportViewer1.RefreshReport()
            ''ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'Me.ReportViewer1.SetDisplayMode(DisplayMode.Normal)

            Dim pageSettings As Printing.PageSettings = New Printing.PageSettings
            Console.WriteLine(" Default height: " & pageSettings.PaperSize.Height)
            Console.WriteLine(" Default width: " & pageSettings.PaperSize.Width)

        Catch ex As Exception
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
End Class