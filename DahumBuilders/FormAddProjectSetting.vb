Imports MySql.Data.MySqlClient

Public Class FormAddProjectSetting
    Private lot As New LotClass()
    Private Sub FormProjectSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(980, 500)
        load_ProjectName_combobox()
        cbbProjectName.SelectedIndex = 0
        PanelLotUpdate.Visible = False
    End Sub

    Private Sub load_ProjectName_combobox()
        Dim item As ListViewItem

        sql = "SELECT `id`, `proj_name`, `proj_address`, (SELECT COUNT(proj_id)  FROM `db_project_item` 
        WHERE `db_project_list`.`id`= `db_project_item`.`proj_id`) AS 'lot' FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.Items.Clear()
            ListViewProject.Items.Clear()
            Do While sqlDataReader.Read = True
                cbbProjectName.Items.Add(sqlDataReader("proj_name"))

                'Add to list view
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("proj_address"))
                item.SubItems.Add(sqlDataReader("lot"))
                ListViewProject.Items.Add(item)
            Loop

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnAddLot_Click(sender As Object, e As EventArgs) Handles btnAddLot.Click
        If cbbProjectName.SelectedIndex = -1 Then
            MessageBox.Show("Please select Project name to add lot")
            Exit Sub
        End If

        sql = "INSERT INTO `db_project_item` ( `block`, `lot`,`sqm`, `price`, `proj_id`,`autoID`) VALUES 
        (@Block, @Lot, @Sqm, @TCP, (SELECT `id` FROM `db_project_list` WHERE `proj_name` LIKE @ProjectName),
        CONCAT(`proj_id`,'.',`block`,'.',`lot`))"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)

        Try
            sqlCommand.Parameters.Add("@Block", MySqlDbType.Int24).Value = Double.Parse(txtBlock.Text.Trim)
            sqlCommand.Parameters.Add("@Lot", MySqlDbType.Int24).Value = Double.Parse(txtLot.Text.Trim)
            sqlCommand.Parameters.Add("@Sqm", MySqlDbType.VarChar).Value = txtSqm.Text.Trim
            sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = Double.Parse(txtTCP.Text.Trim)
            sqlCommand.Parameters.Add("@ProjectName", MySqlDbType.VarChar).Value = cbbProjectName.Text.Trim
            If sqlCommand.ExecuteNonQuery() = 1 Then
                cbbProjectName_SelectedIndexChanged(Me, e)
                MessageBox.Show("Successfully added new lot.")
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            If ex.Message.Contains("Duplicate") Then
                Dim msg As String = "Block (" & txtBlock.Text.Trim & ") and lot (" & txtLot.Text.Trim & ") alreaady exist in " & cbbProjectName.Text.Trim
                MessageBox.Show(Me, msg, "Project Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Project Add Lot: " & ex.Message)
            End If
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        Try
            Dim FindMe As String = lblProjID.Text & "." & txtBlock.Text.Trim & "." & txtLot.Text.Trim
            For i As Integer = 0 To ListViewProjectLot.Items.Count - 1
                For n As Integer = 0 To 7
                    If ListViewProjectLot.Items(i).SubItems(n).Text.Equals(FindMe) Then
                        ListViewProjectLot.Items(i).Selected = True
                        ListViewProjectLot.Items(i).EnsureVisible()
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

        'Try
        '    Dim selectitemIndex As Integer = 7
        '    Dim itmX As ListViewItem = ListViewProjectLot.FindItemWithText(FindMe, True, selectitemIndex)
        '    If Not itmX Is Nothing Then
        '        ListViewProjectLot.Focus()
        '        itmX.Selected = True
        '        ListViewProjectLot.Items(itmX.Index).Selected = True
        '        selectitemIndex = itmX.Index + 1
        '        itmX.EnsureVisible()
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click
        If txtProjectName.Text.Trim.Length < 2 Then
            MessageBox.Show("Please enter Project Name.")
            txtProjectName.Focus()
            Exit Sub
        End If
        If txtProjectAddress.Text.Trim.Length < 2 Then
            MessageBox.Show("Please enter Project Address.")
            txtProjectAddress.Focus()
            Exit Sub
        End If

        sql = "INSERT INTO `db_project_list` (`proj_name`, `proj_address`) VALUES (@ProjName, @Address)"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)

        Try
            sqlCommand.Parameters.Add("@ProjName", MySqlDbType.VarChar).Value = txtProjectName.Text.Trim
            sqlCommand.Parameters.Add("@Address", MySqlDbType.VarChar).Value = txtProjectAddress.Text.Trim
            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtProjectName.Text = String.Empty
                txtProjectAddress.Text = String.Empty
                load_ProjectName_combobox()
                MessageBox.Show("Successfully added new project name.")
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Project Add: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged
        Dim item As ListViewItem

        sql = "SELECT i.`item_id`, l.`id`, l.`proj_name`, i.`block`, i.`lot`, i.`sqm`, i.`price`, IF(i.`assigned_userid`=0,'Available', 'Occupied') AS 'status',
IFNULL((SELECT `last_name` FROM `db_user_profile` WHERE db_user_profile.`id`=i.`assigned_userid`),'') AS 'clientName', i.`autoID`, i.`proj_id`
FROM `db_project_item` i INNER JOIN `db_project_list` l ON i.`proj_id`=l.`id` WHERE l.`proj_name` LIKE @ProjName ORDER BY i.`block` ASC, i.`lot` ASC"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ProjName", MySqlDbType.VarChar).Value = cbbProjectName.Text
            sqlDataReader = sqlCommand.ExecuteReader()
            ListViewProjectLot.Items.Clear()
            Do While sqlDataReader.Read = True
                'Add to list view
                item = New ListViewItem(sqlDataReader("item_id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("block"))
                item.SubItems.Add(sqlDataReader("lot"))
                item.SubItems.Add(sqlDataReader("sqm"))
                item.SubItems.Add(Double.Parse(sqlDataReader("price")).ToString("N2"))
                With item.SubItems.Add(sqlDataReader("status"))
                    .Font = New Font(ListViewProjectLot.Font, FontStyle.Bold)
                    If sqlDataReader("status").Equals("Available") Then
                        .ForeColor = Color.Green
                    Else
                        .ForeColor = Color.Orange
                    End If
                End With
                lblProjID.Text = sqlDataReader("id")
                item.SubItems.Add(sqlDataReader("autoID"))
                item.SubItems.Add(sqlDataReader("proj_id"))
                item.SubItems.Add(sqlDataReader("clientName"))
                ListViewProjectLot.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub ListViewProject_Click(sender As Object, e As EventArgs) Handles ListViewProject.Click
        If ListViewProject.Items.Count > 0 Then
            Dim projectName As String = cbbProjectName.Text = ListViewProject.SelectedItems(0).SubItems(1).Text
            If projectName.Length > 0 Then
                cbbProjectName.Text = ListViewProject.SelectedItems(0).SubItems(1).Text
            End If
        End If
    End Sub

    Private Sub ListViewProject_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewProject.KeyUp
        If ListViewProject.Items.Count > 0 Then
            ListViewProject_Click(sender, e)
        End If
    End Sub

    Private Sub ListViewProjectLot_Click(sender As Object, e As EventArgs) Handles ListViewProjectLot.Click
        If ListViewProjectLot.Items.Count > 0 And ListViewProjectLot.SelectedItems.Item(0).Text IsNot String.Empty Then
            lot = New LotClass()
            With lot
                ._id = ListViewProjectLot.SelectedItems.Item(0).Text
                ._block = ListViewProjectLot.SelectedItems.Item(0).SubItems(2).Text
                ._lot = ListViewProjectLot.SelectedItems.Item(0).SubItems(3).Text
                ._sqm = ListViewProjectLot.SelectedItems.Item(0).SubItems(4).Text
                ._tcp = ListViewProjectLot.SelectedItems.Item(0).SubItems(5).Text
                ._projID = ListViewProjectLot.SelectedItems.Item(0).SubItems(8).Text
            End With

            txtBlockUp.Text = lot._block
            txtLotUp.Text = lot._lot
            txtSqmUp.Text = lot._sqm
            txtTcpUp.Text = lot._tcp.ToString("N2")
        End If
    End Sub

    Private Sub ListViewProjectLot_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewProjectLot.KeyUp
        If ListViewProjectLot.Items.Count > 0 Then
            ListViewProjectLot_Click(sender, e)

            If e.KeyCode = Keys.Enter Then
                PanelLotUpdate.Visible = True
            ElseIf e.KeyCode = Keys.Escape Then
                PanelLotUpdate.Visible = False
            End If
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        PanelLotUpdate.Visible = False
    End Sub

    Private Sub btnUpdateLot_Click(sender As Object, e As EventArgs) Handles btnUpdateLot.Click
        sql = "UPDATE `db_project_item` SET `block`=@block, `lot`=@lot,`sqm`=@Sqm,
        `price`=@price, `autoID`=@autoID WHERE `item_id`=@ItemID"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        Try
            sqlCommand.Parameters.Add("@block", MySqlDbType.Int24).Value = txtBlockUp.Text.Trim
            sqlCommand.Parameters.Add("@lot", MySqlDbType.Int24).Value = txtLotUp.Text.Trim
            sqlCommand.Parameters.Add("@Sqm", MySqlDbType.VarChar).Value = txtSqmUp.Text.Trim
            sqlCommand.Parameters.Add("@price", MySqlDbType.Double).Value = txtTcpUp.Text.Trim
            sqlCommand.Parameters.Add("@autoID", MySqlDbType.VarChar).Value = lot._projID & "." & txtBlockUp.Text.Trim & "." & txtLotUp.Text.Trim
            sqlCommand.Parameters.Add("@ItemID", MySqlDbType.Int64).Value = lot._id

            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtProjectName.Text = String.Empty
                txtProjectAddress.Text = String.Empty
                PanelLotUpdate.Visible = False
                cbbProjectName_SelectedIndexChanged(Me, Nothing)
                MessageBox.Show("Successfully lot updated.")
            End If
        Catch ex As Exception
            If ex.Message.Contains("Duplicate") Then
                Dim msg As String = "Block (" & txtBlockUp.Text.Trim & ") and lot (" & txtLotUp.Text.Trim & ") alreaady exist in " & cbbProjectName.Text.Trim
                MessageBox.Show(Me, msg, "Project Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Project Add Lot: " & ex.Message)
            End If
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub ListViewProject_GotFocus(sender As Object, e As EventArgs) Handles ListViewProject.GotFocus
        PanelLotUpdate.Visible = False
    End Sub
End Class