﻿Imports MySql.Data.MySqlClient

Public Class FormAddProjectSetting
    Dim itemIDDelete As Integer
    Private lot As New LotClass()
    Dim dataPriceList As New Dictionary(Of String, Double)()
    Dim dataPriceListLotType As New Dictionary(Of String, String)()

    Private Sub FormProjectSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1150, 560)
        load_Project_lot_phase_combobox()
        load_ProjectName_combobox()

        PanelLotUpdate.Visible = False
        PanelProjectNameUpdate.Visible = False
    End Sub

    Private Sub load_ProjectName_combobox()
        Dim item As ListViewItem
        sql = "SELECT `id`, `proj_name`, `proj_address`, (SELECT COUNT(proj_id)  FROM `db_project_item` 
        WHERE `db_project_list`.`id`= `db_project_item`.`proj_id`) AS 'lot' FROM `db_project_list`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()
            ListViewProject.Items.Clear()

            Dim comboSourceProjectName As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourceProjectName.Add(sqlDataReader("id"), sqlDataReader("proj_name"))

                'Add to list view
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("proj_address"))
                item.SubItems.Add(sqlDataReader("lot"))
                ListViewProject.Items.Add(item)
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

    Private Sub btnAddLot_Click(sender As Object, e As EventArgs) Handles btnAddLot.Click
        txtBlockFilter.Text = ""
        If cbbProjectName.SelectedIndex = -1 Then
            MessageBox.Show("Please select Project name to add lot")
            Exit Sub
        End If

        Dim s As String = cbSQM.Text.Trim
        Dim words As String() = s.Split(New Char() {";"c})
        Dim cbbPhaseInfoID As String = DirectCast(cbbPhaseInfo.SelectedItem, KeyValuePair(Of String, String)).Key

        sql = "INSERT INTO `db_project_item` ( `block`, `lot`,`sqm`, `lot_type`, `price`, `proj_id`,`autoID`, `phase_id`) VALUES 
        (@Block, @Lot, @Sqm, @LotType, @TCP, (SELECT `id` FROM `db_project_list` WHERE `proj_name` LIKE @ProjectName),
        CONCAT(`proj_id`,'.',`block`,'.',TRIM(`lot`)), @PhaseId)"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Block", MySqlDbType.Int24).Value = Double.Parse(txtBlock.Text.Trim)
            sqlCommand.Parameters.Add("@Lot", MySqlDbType.VarChar).Value = txtLot.Text.Trim
            sqlCommand.Parameters.Add("@Sqm", MySqlDbType.VarChar).Value = words(0)
            sqlCommand.Parameters.Add("@LotType", MySqlDbType.VarChar).Value = words(1).Trim
            sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = Double.Parse(txtTCP.Text.Trim)
            sqlCommand.Parameters.Add("@ProjectName", MySqlDbType.VarChar).Value = cbbProjectName.Text.Trim
            sqlCommand.Parameters.Add("@PhaseId", MySqlDbType.Int32).Value = cbbPhaseInfoID

            If sqlCommand.ExecuteNonQuery() = 1 Then
                loadProjectLots("")
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
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
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
    Private Sub loadComboPriceList(listID As Integer)

        sql = "SELECT `id`, `sqm`, `tcp`, `lot_type` FROM `db_project_list_price` WHERE `lid`=@listID ORDER BY sqm"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@listID", MySqlDbType.Int32).Value = listID
            sqlDataReader = sqlCommand.ExecuteReader()

            cbSQM.DataSource = Nothing
            cbSQMUpdate.DataSource = Nothing

            cbSQM.Items.Clear()
            cbSQMUpdate.Items.Clear()
            dataPriceList.Clear()
            dataPriceListLotType.Clear()

            Dim comboSource As New Dictionary(Of String, String)()
            If sqlDataReader.HasRows Then
                Do While sqlDataReader.Read = True

                    Dim sqmType As String = sqlDataReader("sqm").ToString + "; " + sqlDataReader("lot_type")

                    comboSource.Add(sqlDataReader("id"), sqmType)
                    dataPriceList.Add(sqlDataReader("id"), sqlDataReader("tcp"))
                    dataPriceListLotType.Add(sqlDataReader("id"), sqlDataReader("lot_type"))
                Loop
            Else
                comboSource.Add("1", "0;INNER")
                dataPriceList.Add("1", "0")
                dataPriceListLotType.Add("1", "INNER")
            End If

            cbSQM.DataSource = New BindingSource(comboSource, Nothing)
            cbSQM.DisplayMember = "Value"
            cbSQM.ValueMember = "Key"

            cbSQMUpdate.DataSource = New BindingSource(comboSource, Nothing)
            cbSQMUpdate.DisplayMember = "Value"
            cbSQMUpdate.ValueMember = "Key"

        Catch ex As Exception
            MessageBox.Show("Load Combo PriceList: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub cbSQM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSQM.SelectedIndexChanged
        If cbSQM.SelectedIndex > -1 Then
            Try
                Dim key As String = DirectCast(cbSQM.SelectedItem, KeyValuePair(Of String, String)).Key
                Dim value As String = DirectCast(cbSQM.SelectedItem, KeyValuePair(Of String, String)).Value
                'txtTCP.Text = CDbl(key).ToString("N2")

                If dataPriceList.ContainsKey(key) Then
                    Dim price As Double = dataPriceList.Item(key)
                    txtTCP.Text = price.ToString("N2")
                    cbbPhaseInfo.SelectedIndex = 0
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cbSQMUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSQMUpdate.SelectedIndexChanged
        If cbSQMUpdate.SelectedIndex > -1 Then
            Dim key As String = DirectCast(cbSQMUpdate.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim value As String = DirectCast(cbSQMUpdate.SelectedItem, KeyValuePair(Of String, String)).Value
            'txtTcpUp.Text = CDbl(key).ToString("N2")

            If dataPriceList.ContainsKey(key) Then
                Dim price As Double = dataPriceList.Item(key)
                txtTcpUp.Text = price.ToString("N2")
                cbbPhaseInfoUpdate.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged
        If cbbProjectName.SelectedIndex >= 0 And cbbProjectName.Text.Length > 3 Then
            loadProjectLots("")
            txtBlockFilter.Text = ""

            Dim key As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
            lblProjID.Text = key
            loadComboPriceList(key)
        End If
    End Sub

    Private Sub loadProjectLots(blockNumber As String)
        Dim projectID As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim item As ListViewItem
        If blockNumber.Length > 0 Then
            sql = "SELECT i.`item_id`, l.`id`, l.`proj_name`, i.`block`, i.`lot`, i.`sqm`, i.`lot_type`, i.`price`, 
            IF(STRCMP(i.`status`,'SOLD') = 0, 'SOLD', IF(i.`assigned_userid`<1,'Available', 'Occupied')) AS 'status', `remark`,
            IFNULL((SELECT `last_name` FROM `db_user_profile` WHERE db_user_profile.`id`=i.`assigned_userid`),'') AS 'clientName', i.`autoID`,
            IFNULL((SELECT `phase` FROM `db_project_lot_phase` WHERE `id`=i.`phase_id`),'') phase, i.`proj_id`
            FROM `db_project_item` i INNER JOIN `db_project_list` l ON i.`proj_id`=l.`id` WHERE l.`id`=@ProjID {0} ORDER BY i.`block` ASC, i.`lot` ASC"
            sql = String.Format(sql, " AND i.`block` LIKE '" + blockNumber + "'")
        Else
            sql = "SELECT i.`item_id`, l.`id`, l.`proj_name`, i.`block`, i.`lot`, i.`sqm`, i.`lot_type`, i.`price`, 
            IF(STRCMP(i.`status`,'SOLD') = 0, 'SOLD', IF(i.`assigned_userid`<1,'Available', 'Occupied')) AS 'status', `remark`,
            IFNULL((SELECT `last_name` FROM `db_user_profile` WHERE db_user_profile.`id`=i.`assigned_userid`),'') AS 'clientName', i.`autoID`,
            IFNULL((SELECT `phase` FROM `db_project_lot_phase` WHERE `id`=i.`phase_id`),'') phase, i.`proj_id`
            FROM `db_project_item` i INNER JOIN `db_project_list` l ON i.`proj_id`=l.`id` WHERE l.`id`=@ProjID ORDER BY i.`block` ASC, i.`lot` ASC"
        End If
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ProjID", MySqlDbType.VarChar).Value = projectID
            If blockNumber.Length > 0 Then
                sqlCommand.Parameters.Add("@Block", MySqlDbType.VarChar).Value = blockNumber
            End If
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
                item.SubItems.Add(sqlDataReader("lot_type"))
                item.SubItems.Add(Double.Parse(sqlDataReader("price")).ToString("N2"))

                With item.SubItems.Add(sqlDataReader("status"))
                    .Font = New Font(ListViewProjectLot.Font, FontStyle.Bold)
                    If sqlDataReader("status").Equals("Available") Then
                        .ForeColor = Color.Green
                    ElseIf sqlDataReader("status").Equals("SOLD") Then
                        .ForeColor = Color.Red
                    Else
                        .ForeColor = Color.Orange
                    End If
                End With

                item.SubItems.Add(sqlDataReader("autoID"))
                item.SubItems.Add(sqlDataReader("proj_id"))
                item.SubItems.Add(sqlDataReader("clientName"))
                item.SubItems.Add(sqlDataReader("phase"))
                item.SubItems.Add(sqlDataReader("remark"))
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
            Dim projectName As String = ListViewProject.SelectedItems(0).SubItems(1).Text
            cbbProjectName.Text = projectName

            If projectName.Length > 0 Then

                lblID.Text = ListViewProject.SelectedItems(0).Text
                txtProjectNameUpdate.Text = ListViewProject.SelectedItems(0).SubItems(1).Text
                txtAddressUpdate.Text = ListViewProject.SelectedItems(0).SubItems(2).Text
            End If
        End If
    End Sub

    Private Sub ListViewProject_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewProject.KeyUp
        If ListViewProject.Items.Count > 0 Then
            ListViewProject_Click(sender, e)
            If e.KeyCode = Keys.Enter Then
                PanelProjectNameUpdate.Visible = True
                txtProjectNameUpdate.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                PanelProjectNameUpdate.Visible = False
                PanelLotUpdate.Visible = False
            End If
        End If
    End Sub

    Private Sub ListViewProjectLot_Click(sender As Object, e As EventArgs) Handles ListViewProjectLot.Click
        Try
            If ListViewProjectLot.Items.Count > 0 And ListViewProjectLot.SelectedItems.Item(0).Text IsNot String.Empty Then
                lot = New LotClass()
                With lot
                    ._id = ListViewProjectLot.SelectedItems.Item(0).Text
                    ._block = ListViewProjectLot.SelectedItems.Item(0).SubItems(2).Text
                    ._lot = ListViewProjectLot.SelectedItems.Item(0).SubItems(3).Text
                    ._sqm = ListViewProjectLot.SelectedItems.Item(0).SubItems(4).Text
                    ._lotType = ListViewProjectLot.SelectedItems.Item(0).SubItems(5).Text
                    ._tcp = ListViewProjectLot.SelectedItems.Item(0).SubItems(6).Text
                    ._projID = ListViewProjectLot.SelectedItems.Item(0).SubItems(9).Text
                    ._phase = ListViewProjectLot.SelectedItems.Item(0).SubItems(11).Text
                End With

                txtBlockUp.Text = lot._block
                txtLotUp.Text = lot._lot
                cbSQMUpdate.Text = lot._sqm + "; " + lot._lotType
                txtTcpUp.Text = lot._tcp.ToString("N2")
                cbbPhaseInfoUpdate.Text = lot._phase
            End If
            PanelProjectNameUpdate.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListViewProjectLot_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewProjectLot.KeyUp
        If ListViewProjectLot.Items.Count > 0 Then
            ListViewProjectLot_Click(sender, e)

            If e.KeyCode = Keys.Enter Then
                PanelLotUpdate.Visible = True
            ElseIf e.KeyCode = Keys.Escape Then
                PanelLotUpdate.Visible = False
                PanelProjectNameUpdate.Visible = False
            End If
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        PanelLotUpdate.Visible = False
    End Sub

    Private Sub btnUpdateLot_Click(sender As Object, e As EventArgs) Handles btnUpdateLot.Click

        Dim s As String = cbSQMUpdate.Text.Trim
        Dim words As String() = s.Split(New Char() {";"c})
        Dim cbbPhaseInfoID As String = DirectCast(cbbPhaseInfoUpdate.SelectedItem, KeyValuePair(Of String, String)).Key

        sql = "UPDATE `db_project_item` SET `block`=@block, `lot`=@lot,`sqm`=@Sqm, `lot_type`=@lotType,
        `price`=@price, `autoID`=@autoID, `phase_id`=@PhaseId WHERE `item_id`=@ItemID"
        Connection()

        sqlCommand = New MySqlCommand(sql, sqlConnection)
        Try
            sqlCommand.Parameters.Add("@block", MySqlDbType.Int24).Value = txtBlockUp.Text.Trim
            sqlCommand.Parameters.Add("@lot", MySqlDbType.VarChar).Value = txtLotUp.Text.Trim
            sqlCommand.Parameters.Add("@Sqm", MySqlDbType.VarChar).Value = words(0)
            sqlCommand.Parameters.Add("@lotType", MySqlDbType.VarChar).Value = words(1).Trim
            sqlCommand.Parameters.Add("@price", MySqlDbType.Double).Value = txtTcpUp.Text.Trim
            sqlCommand.Parameters.Add("@autoID", MySqlDbType.VarChar).Value = lot._projID & "." & txtBlockUp.Text.Trim & "." & txtLotUp.Text.Trim
            sqlCommand.Parameters.Add("@ItemID", MySqlDbType.Int64).Value = lot._id
            sqlCommand.Parameters.Add("@PhaseId", MySqlDbType.Int32).Value = cbbPhaseInfoID


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

    Private Sub txtLot_GotFocus(sender As Object, e As EventArgs) Handles txtLot.GotFocus, txtLot.Click
        txtLot.SelectAll()
    End Sub

    Private Sub txtBlock_GotFocus(sender As Object, e As EventArgs) Handles txtBlock.GotFocus, txtBlock.Click
        txtBlock.SelectAll()
    End Sub

    Private Sub txtLot_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBlock.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddLot.PerformClick()
        End If
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        loadProjectLots(txtBlockFilter.Text.Trim)
    End Sub


    Private Sub btnUpdateProjectName_Click(sender As Object, e As EventArgs) Handles btnUpdateProjectName.Click

        sql = "UPDATE `db_project_list` SET `proj_name`=@ProjName,  `proj_address`=@ProjAddress  WHERE `id`=@ID"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        Try
            sqlCommand.Parameters.Add("@ProjName", MySqlDbType.VarChar).Value = txtProjectNameUpdate.Text.Trim
            sqlCommand.Parameters.Add("@ProjAddress", MySqlDbType.VarChar).Value = txtAddressUpdate.Text.Trim
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = lblID.Text.Trim

            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtProjectName.Text = String.Empty
                txtProjectAddress.Text = String.Empty
                PanelLotUpdate.Visible = False
                PanelProjectNameUpdate.Visible = False
                MessageBox.Show("Successfully Project updated.")
                mFormMainDahum.ProjectListToolStripMenuItem.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show("Project Add Lot: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        load_ProjectName_combobox()
    End Sub

    Private Sub lblProjectName_Click(sender As Object, e As EventArgs) Handles lblProjectName.Click
        PanelProjectNameUpdate.Visible = False
    End Sub

    Private Sub ListViewProjectLot_MouseUp(sender As Object, e As MouseEventArgs) Handles ListViewProjectLot.MouseUp
        If ListViewProjectLot.Items.Count > 0 Then
            If e.Button = MouseButtons.Right Then
                PanelLotUpdate.Visible = True
            End If
        Else
            PanelLotUpdate.Visible = False
        End If
    End Sub

    Private Sub ListViewProject_MouseUp(sender As Object, e As MouseEventArgs) Handles ListViewProject.MouseUp
        If ListViewProject.Items.Count > 0 Then
            If e.Button = MouseButtons.Right Then
                PanelProjectNameUpdate.Visible = True
            End If
        Else
            PanelProjectNameUpdate.Visible = False
        End If
    End Sub
    Private Sub load_Project_lot_phase_combobox()
        sql = "SELECT * FROM `db_project_lot_phase` ORDER BY phase"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbPhaseInfo.DataSource = Nothing
            cbbPhaseInfo.Items.Clear()

            cbbPhaseInfoUpdate.DataSource = Nothing
            cbbPhaseInfoUpdate.Items.Clear()

            Dim comboSourceProjectLotType As New Dictionary(Of String, String)()
            If sqlDataReader.HasRows Then
                comboSourceProjectLotType.Add("0", "")
                Do While sqlDataReader.Read = True
                    comboSourceProjectLotType.Add(sqlDataReader("id"), sqlDataReader("phase"))
                Loop
            Else
                comboSourceProjectLotType.Add("0", "")
            End If

            cbbPhaseInfo.DataSource = New BindingSource(comboSourceProjectLotType, Nothing)
            cbbPhaseInfo.DisplayMember = "Value"
            cbbPhaseInfo.ValueMember = "Key"

            cbbPhaseInfoUpdate.DataSource = New BindingSource(comboSourceProjectLotType, Nothing)
            cbbPhaseInfoUpdate.DisplayMember = "Value"
            cbbPhaseInfoUpdate.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        mVerification = False
        Dim countLotPrjCheck As Integer = 0
        For Each item In ListViewProjectLot.CheckedItems
            countLotPrjCheck += 1
        Next

        If countLotPrjCheck < 1 Then
            MessageBox.Show("Please select Project Lot to delete.")
            Exit Sub
        End If

        If Application.OpenForms().OfType(Of FormVerification).Any Then
            mFormVerification.Focus()
        Else
            mFormVerification = New FormVerification
            mFormVerification.ShowDialog()
        End If

        If mVerification = False Then
            Exit Sub
        End If

        itemIDDelete = 0
        For Each item In ListViewProjectLot.CheckedItems
            deleteProjectLotMethod(item.Text)
        Next

        If itemIDDelete > 0 Then
            MessageBox.Show("OR Successfully deleted.")
        End If
        mVerification = False
    End Sub

    Private Sub deleteProjectLotMethod(id As String)
        Dim record As Integer = 0
        Connection()
        Try
            sql = "SELECT COUNT(`assigned_userid`) AS result FROM `db_project_item` WHERE `item_id`=@ID AND `assigned_userid`=0"

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
            sqlDataReader = sqlCommand.ExecuteReader()

            If sqlDataReader.Read = True Then
                record = sqlDataReader("result")
            End If
            'Delete record found assigned_userid ZERO value
            If record = 1 Then
                sqlDataReader.Dispose()
                Dim deleteRecord As Integer = 0

                sql = "SELECT COUNT(`id`) AS result FROM `db_transaction` WHERE `proj_itemId`=@ID"
                sqlCommand = New MySqlCommand(sql, sqlConnection)
                sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
                sqlDataReader = sqlCommand.ExecuteReader()

                If sqlDataReader.Read = True Then
                    deleteRecord = sqlDataReader("result")
                End If

                'Found value on transaction table and unble to delete this record
                If deleteRecord = 1 Then
                    MessageBox.Show("Unable to delete Record. Lot has a transaction entries" & vbNewLine & "ID No.: " & id)
                Else
                    sqlDataReader.Dispose()
                    sql = "INSERT INTO `db_history_delete` (`OR`,`amount`,`userID`,`name`) 
                    SELECT CONCAT('ITEM_LOT: BLK(',`block`,') L(',`lot`,') SQM ',`sqm`), `price`, @UserID, @Name FROM `db_project_item` WHERE `item_id`=@ID;
                    DELETE FROM `db_project_item` WHERE `item_id`=@ID"

                    sqlCommand = New MySqlCommand(sql, sqlConnection)
                    sqlCommand.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = userLogon._id
                    sqlCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userLogon._name
                    sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = id

                    If sqlCommand.ExecuteNonQuery() > 0 Then
                        cbbProjectName_SelectedIndexChanged(Me, Nothing)
                    End If
                End If
            Else
                MessageBox.Show("Unable to delete Record. Lot is currently assiged to client/buyer" & vbNewLine & "ID No.: " & id)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to delete record!")
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub txtBlock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBlock.KeyPress, txtBlockFilter.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLot.KeyPress, txtLotUp.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890-ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

End Class