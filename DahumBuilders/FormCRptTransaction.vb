Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormCRptTransaction
    Public Property mUser As User = New User()
    Private mouseDownClicked As Boolean

    Private Sub FormCRptTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        generate_listProjectCombo()
        mouseDownClicked = False
    End Sub
    Private Sub generate_listProjectCombo()
        sql = "SELECT it.`item_id`, CONCAT( pl.`proj_name` , ' ' ,(SELECT `phase` FROM `db_project_lot_phase` WHERE `id`=it.`phase_id`),  ' Block ', it.`block`,' - lot ', it.`lot`, ' ', it.`sqm`,'sqm')
        projectName FROM `db_transaction` t
        INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=172 AND t.`proj_itemId` GROUP BY item_id"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlDataReader = sqlCommand.ExecuteReader()


            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()

            Dim comboSourceProjectName As New Dictionary(Of String, String)()
            comboSourceProjectName.Add("0", "All Project")
            Do While sqlDataReader.Read = True
                comboSourceProjectName.Add(sqlDataReader("item_id"), sqlDataReader("projectName"))
            Loop

            cbbProjectName.DataSource = New BindingSource(comboSourceProjectName, Nothing)
            cbbProjectName.DisplayMember = "Value"
            cbbProjectName.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub generate_report()
        Dim table As New DataTable()
        sql = "SELECT (CASE 
        WHEN LENGTH(TRIM(`official_receipt_no`)) < 1 && LENGTH(TRIM(`ar_number`)) > 0  THEN `ar_number`
        WHEN LENGTH(TRIM(`official_receipt_no`)) > 0 && LENGTH(TRIM(`ar_number`)) < 1  THEN `official_receipt_no`
        ELSE CONCAT(TRIM(`ar_number`), '/', TRIM(`official_receipt_no`))
        END) AS `official_receipt_no`,`paid_amount`, t.`discount_amount`, t.`penalty`, t.`tax_base`, CONCAT(pa.`short_name`,' - ', pt.`short_name`) AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`short_name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=@userId ORDER BY date_paid DESC, official_receipt_no DESC, proj_name ASC, lot ASC"
        Cursor = Cursors.WaitCursor
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            sql = "SELECT SUM(i.`price`) AS tcp, SUM(IFNULL((SELECT i.`price`-((SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`))
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

            Dim report As New crptTransactionSingle
            report.Load()

            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtHeaderCompanyName")
            Dim txtHeaderCompanyAddress As TextObject = report.ReportDefinition.Sections("Section1").ReportObjects("txtCompanyAddress")

            Dim name As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtName")
            Dim mobile As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtMobile")
            Dim address As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtAddress")
            Dim txtTotalTCP As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalTCP")
            Dim txtTotalBalance As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalBalance")
            Dim lotInfo As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("lotInfo")

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName
            txtHeaderCompanyAddress.Text = ModuleConnection.CompanyAddress

            name.Text = mUser._name & " " & mUser._middleName & " " & mUser._surname
            mobile.Text = mUser._mobile
            address.Text = mUser._address
            txtTotalTCP.Text = totalTcp.ToString("N2")
            txtTotalBalance.Text = totalBalance.ToString("N2")
            lotInfo.Text = cbbProjectName.Text

            report.SetDataSource(table)

            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub generate_report(itemID As String)

        Dim table As New DataTable()
        sql = "SELECT (CASE 
        WHEN LENGTH(TRIM(`official_receipt_no`)) < 1 && LENGTH(TRIM(`ar_number`)) > 0  THEN `ar_number`
        WHEN LENGTH(TRIM(`official_receipt_no`)) > 0 && LENGTH(TRIM(`ar_number`)) < 1  THEN `official_receipt_no`
        ELSE CONCAT(TRIM(`ar_number`), '/', TRIM(`official_receipt_no`))
        END) AS `official_receipt_no`,`paid_amount`, t.`discount_amount`, t.`penalty`, t.`tax_base`, CONCAT(pa.`short_name`,' - ', pt.`short_name`) AS `payment_type`, 
        IF(t.`part_no`=0,'',t.`part_no`) AS part_no, pa.`short_name` AS `particular`, `date_paid`, 
        pl.`proj_name` , it.`block` , it.`lot` , it.`sqm` FROM `db_transaction` t 
        INNER JOIN `db_payment_type` pt ON t.`payment_type` = pt.`id`
        INNER JOIN `db_particular_type` pa ON t.`particular` = pa.`id` INNER JOIN `db_project_list` pl ON pl.`id`= t.`proj_id`
        INNER JOIN `db_project_item` it ON it.`item_id` = t.`proj_itemId`
        WHERE t.`userid`=@userId AND t.`proj_itemId`=@ItemID ORDER BY date_paid DESC, official_receipt_no DESC, proj_name ASC, lot ASC"
        Cursor = Cursors.WaitCursor
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlCommand.Parameters.Add("@ItemID", MySqlDbType.Int32).Value = Convert.ToInt32(itemID)
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            sql = "SELECT SUM(i.`price`) AS tcp, SUM(IFNULL((SELECT i.`price`-((SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`))
            FROM `db_transaction` WHERE db_transaction.`proj_id`=i.`proj_id` AND db_transaction.`proj_itemId`=i.`item_id` AND i.`assigned_userid`=db_transaction.`userid`), i.`price` )) AS 'totalBalance'
            FROM `db_project_list` l INNER JOIN `db_project_item` i ON l.`id`=i.`proj_id` WHERE i.`assigned_userid`=@userId  AND i.`item_id`=@ItemID"

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = mUser._id
            sqlCommand.Parameters.Add("@ItemID", MySqlDbType.Int32).Value = Convert.ToInt32(itemID)
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

            Dim report As New crptTransactionSingle
            report.Load()

            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtHeaderCompanyName")
            Dim txtHeaderCompanyAddress As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtCompanyAddress")

            Dim name As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtName")
            Dim mobile As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtMobile")
            Dim address As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtAddress")
            Dim txtTotalTCP As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalTCP")
            Dim txtTotalBalance As TextObject = report.ReportDefinition.Sections("Section5").ReportObjects("txtTotalBalance")
            Dim lotInfo As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("lotInfo")

            txtHeaderCompanyName.Text = ModuleConnection.CompanyName
            txtHeaderCompanyAddress.Text = ModuleConnection.CompanyAddress

            name.Text = mUser._name & " " & mUser._middleName & " " & mUser._surname
            mobile.Text = mUser._mobile
            address.Text = mUser._address
            txtTotalTCP.Text = totalTcp.ToString("N2")
            txtTotalBalance.Text = totalBalance.ToString("N2")
            lotInfo.Text = cbbProjectName.Text

            report.SetDataSource(table)

            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Zoom(90)
        Catch ex As Exception
            MessageBox.Show("Generate Report: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim key As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Value

        If key.Equals("0") Then
            generate_report()
        Else
            generate_report(key)
        End If

    End Sub

    Private Sub FormCRptTransaction_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        btnShow.PerformClick()
    End Sub

    Private Sub cbbProjectName_MouseUp(sender As Object, e As MouseEventArgs) Handles cbbProjectName.MouseUp
        mouseDownClicked = True
    End Sub

    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged
        If mouseDownClicked = True Then
            Dim key As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim value As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Value

            If key.Equals("0") Then
                generate_report()
            Else
                generate_report(key)
            End If
        End If
    End Sub
End Class