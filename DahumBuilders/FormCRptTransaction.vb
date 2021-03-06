Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormCRptTransaction
    Public Property mUser As User = New User()

    Private Sub FormCRptTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        generate_report()
    End Sub

    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT `official_receipt_no`,`paid_amount`, t.`discount_amount`, t.`penalty`, pt.`short_name` AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`short_name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=@userId ORDER BY date_paid DESC, proj_name ASC, lot ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            sql = "SELECT SUM(i.`price`) AS tcp, SUM(IFNULL((SELECT (`tcp`-SUM(`paid_amount`))-SUM(`discount_amount`) 
            FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`), i.`price` )) AS 'totalBalance'
            FROM `db_project_list` l INNER JOIN `db_project_item` i ON l.`id`=i.`proj_id` WHERE i.`assigned_userid`=@userId"

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlDataReader = sqlCommand.ExecuteReader()

            Dim totalTcp As Double = 0
            Dim totalBalance As Double = 0

            Do While sqlDataReader.Read = True
                If IsDBNull(sqlDataReader("totalBalance")) Then
                Else
                    totalTcp = sqlDataReader("tcp")
                    totalBalance = sqlDataReader("totalBalance")
                End If
            Loop

            Dim report As New crptTransaction
            report.Load()

            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtHeaderCompanyName")

            Dim name As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtName")
            Dim mobile As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtMobile")
            Dim address As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtAddress")
            Dim txtTotalTCP As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalTCP")
            Dim txtTotalBalance As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalBalance")

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName
            name.Text = mUser._name & " " & mUser._middleName & " " & mUser._surname
            mobile.Text = mUser._mobile
            address.Text = mUser._address
            txtTotalTCP.Text = totalTcp.ToString("N2")
            txtTotalBalance.Text = totalBalance.ToString("N2")

            report.SetDataSource(table)

            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        End Try
    End Sub

End Class