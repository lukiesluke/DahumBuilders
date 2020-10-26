Imports MySql.Data.MySqlClient

Public Class FormProjectList
    Public Property mUser As User = New User()
    Dim proj As Project = New Project()

    Private Sub FormProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAssign.Enabled = False
        lblProjectAssignedToUser.Text = String.Empty
        load_project_list(String.Empty)
        load_ProjectName_combobox()
    End Sub

    Private Sub load_ProjectName_combobox()
        sql = "SELECT proj_name FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()
            cbbProjectName.Items.Clear()
            Do While sqlDataReader.Read = True
                cbbProjectName.Items.Add(sqlDataReader("proj_name"))
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub load_project_list(ByVal projectName As String)
        Dim checkAvailable As String = ""
        If chkAvailable.Checked = True Then
            checkAvailable = " AND p.`assigned_userid` <= 0"
        End If
        Connection()
        If cbbProjectName.SelectedIndex = -1 Then
            sql = "SELECT  p.`item_id`, l.`proj_name`, block , lot, sqm, price, 
            IFNULL((SELECT CONCAT(last_name , ', ', first_name ) FROM `db_user_profile` WHERE `db_user_profile`.`id`= assigned_userid),'') AS assigned_name  
            FROM `db_project_item` p INNER JOIN `db_project_list` l ON p.`proj_id`=l.`id` 
            WHERE block LIKE @Block " & checkAvailable

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Block", MySqlDbType.VarChar).Value = "%" & txtBlock.Text.Trim & "%"
            sqlDataReader = sqlCommand.ExecuteReader()
        Else
            sql = "SELECT  p.`item_id`, l.`proj_name`, block , lot, sqm, price, 
            IFNULL((SELECT CONCAT(last_name , ', ', first_name ) FROM `db_user_profile` WHERE `db_user_profile`.`id`= assigned_userid),'') AS assigned_name  
            FROM `db_project_item` p INNER JOIN `db_project_list` l ON p.`proj_id`=l.`id`
            WHERE `proj_name` LIKE @projName AND block LIKE @Block " & checkAvailable

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@projName", MySqlDbType.VarChar).Value = "%" & cbbProjectName.SelectedItem & "%"
            sqlCommand.Parameters.Add("@Block", MySqlDbType.VarChar).Value = "%" & txtBlock.Text.Trim & "%"
            sqlDataReader = sqlCommand.ExecuteReader()
        End If

        Try
            Dim item As ListViewItem
            ListViewProject.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("item_id").ToString)
                Dim price As Double = sqlDataReader("price")

                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("block"))
                item.SubItems.Add(sqlDataReader("lot"))
                item.SubItems.Add(sqlDataReader("sqm"))
                item.SubItems.Add(price.ToString("N2"))
                item.SubItems.Add(sqlDataReader("assigned_name"))
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

    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged
        txtBlock.Text = String.Empty
        load_project_list(cbbProjectName.SelectedItem)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        load_project_list(cbbProjectName.SelectedItem)
    End Sub

    Private Sub txtBlock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBlock.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkAvailable_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailable.CheckedChanged
        btnSearch.PerformClick()
    End Sub

    Private Sub ListViewProject_Click(sender As Object, e As EventArgs) Handles ListViewProject.Click
        If ListViewProject.Items.Count < 1 Then
            Exit Sub
        End If
        proj._itemID = ListViewProject.SelectedItems(0).Text
        proj._name = ListViewProject.SelectedItems(0).SubItems(1).Text
        proj._block = ListViewProject.SelectedItems(0).SubItems(2).Text
        proj._lot = ListViewProject.SelectedItems(0).SubItems(3).Text
        proj._sqm = ListViewProject.SelectedItems(0).SubItems(4).Text
        proj._tcp = ListViewProject.SelectedItems(0).SubItems(5).Text
        proj._assignedToUserName = ListViewProject.SelectedItems(0).SubItems(6).Text

        lblProjectName.Text = proj._name
        lblProjectItemID.Text = String.Format("{0:000000}", Integer.Parse(proj._itemID)) 'proj._itemID.ToString("0000")
        lblProjectBlock.Text = proj._block
        lblProjectLot.Text = proj._lot
        lblProjectSQM.Text = proj._sqm
        lblProjectTCP.Text = proj._tcp.ToString("N2")

        If proj._assignedToUserName.Trim.Length < 1 Then
            btnAssign.Enabled = True
            lblProjectAssignedToUser.Text = String.Empty
        Else
            btnAssign.Enabled = False
            lblProjectAssignedToUser.Text = "Assigned to: " & proj._assignedToUserName
        End If
    End Sub
    Private Sub ListViewProject_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewProject.KeyUp
        ListViewProject_Click(sender, e)
    End Sub
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim rowsAffected As Integer = 0
        sql = "UPDATE `db_project_item` SET `assigned_userid`=@UserID WHERE `item_id`=@ItemId AND `assigned_userid`<1"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@UserID", MySqlDbType.Int32).Value = mUser._id
            sqlCommand.Parameters.Add("@ItemId", MySqlDbType.Int32).Value = proj._itemID
            rowsAffected = sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Assigning" & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

        If rowsAffected < 1 Then
            MessageBox.Show("Assigning lot to " & mUser._name & " " & mUser._surname & " was unsuccessful")
        Else
            MessageBox.Show(Me, "Assigning lot to " & mUser._name & " " & mUser._surname & " was Successfully updated", "Project List", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mFormPayment.load_userId_info_data_reader()
            Me.Close()
        End If
    End Sub
End Class