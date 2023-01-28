Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormCRptCollectibleReport
    Private Sub FormCollectibleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `id`, `proj_name`, `proj_address`, (SELECT COUNT(proj_id)  FROM `db_project_item` 
        WHERE `db_project_list`.`id`= `db_project_item`.`proj_id`) AS 'lot' FROM `db_project_list`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()


            Dim comboSourceProjectName As New Dictionary(Of String, String)()
            comboSourceProjectName.Add(-1, "Please Select Project")
            Do While sqlDataReader.Read = True
                comboSourceProjectName.Add(sqlDataReader("id"), sqlDataReader("proj_name"))
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

    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged
        If cbbProjectName.SelectedIndex >= 0 And cbbProjectName.Text.Length > 3 Then

            Dim keyID As Integer = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
            If keyID > 0 Then
                generate_report(keyID)
            End If
        End If
    End Sub

    Private Sub generate_report(keyID As String)

        Dim table As New DataTable()
        sql = "SELECT i.`item_id`, i.`block`, i.`lot`, i.`sqm`, i.`lot_type`, i.`price`, 
            IF(STRCMP(i.`status`,'SOLD') = 0, 'SOLD', IF(i.`assigned_userid`<1,'Available', 'Occupied')) AS 'status',
            IFNULL((SELECT `last_name` FROM `db_user_profile` WHERE db_user_profile.`id`=i.`assigned_userid`),'') AS 'clientName',
            IFNULL((SELECT `phase` FROM `db_project_lot_phase` WHERE `id`=i.`phase_id`),'') PHASE,

            IFNULL((SELECT SUM(`penalty`) FROM `db_transaction` t WHERE t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_penalty,
            IFNULL((SELECT (SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`) FROM `db_transaction` t WHERE t.`payment_type`=0 AND t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_cash,
            IFNULL((SELECT (SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`) FROM `db_transaction` t WHERE t.`payment_type`=1 AND t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_cheque,
            IFNULL((SELECT (SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`) FROM `db_transaction` t WHERE t.`payment_type`=2 AND t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_bankTransfer,
            IFNULL((SELECT i.`price`-((SUM(`paid_amount`)-SUM(`penalty`))+SUM(`discount_amount`)) FROM `db_transaction` t WHERE t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_balance,
            IFNULL((SELECT SUM(`paid_amount`) FROM `db_transaction` t WHERE t.`userid`=i.`assigned_userid` AND t.`proj_itemId`=i.`item_id`), 0) AS total_paid

            FROM `db_project_item` i INNER JOIN `db_project_list` l ON i.`proj_id`=l.`id` WHERE l.`id`=@ProjID ORDER BY i.`block` ASC, i.`lot` ASC"

        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ProjID", MySqlDbType.VarChar).Value = keyID
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim report As New crpCollectible

            report.Load()
            Dim txtHeaderCompanyName As TextObject = report.ReportDefinition.Sections("Section2").ReportObjects("txtProjectName")
            txtHeaderCompanyName.Text = cbbProjectName.Text

            report.SetDataSource(table)
            CrystalReportViewerCollectible.ReportSource = report
            CrystalReportViewerCollectible.Refresh()
            CrystalReportViewerCollectible.Zoom(90)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub
End Class