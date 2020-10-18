Imports MySql.Data.MySqlClient

Public Class FormProjectList
    Private Sub FormProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            sql = "SELECT  l.`id`, l.`proj_name`, block , lot, sqm, price, 
            IFNULL((SELECT CONCAT(last_name , ', ', first_name ) FROM `db_user_profile` WHERE `db_user_profile`.`id`= assigned_userid),'') AS assigned_name  
            FROM `db_project_item` p INNER JOIN `db_project_list` l ON p.`proj_id`=l.`id` 
            WHERE block LIKE @Block " & checkAvailable

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Block", MySqlDbType.VarChar).Value = "%" & txtBlock.Text.Trim & "%"
            sqlDataReader = sqlCommand.ExecuteReader()
        Else
            sql = "SELECT  l.`id`, l.`proj_name`, block , lot, sqm, price, 
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
                item = New ListViewItem(sqlDataReader("id").ToString)
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
End Class