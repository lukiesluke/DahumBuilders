Imports MySql.Data.MySqlClient

Public Class FormAddProjectSetting
    Private Sub FormProjectSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ProjectName_combobox()
        cbbProjectName.SelectedIndex = 0
    End Sub

    Private Sub load_ProjectName_combobox()
        Dim item As ListViewItem

        sql = "SELECT * FROM `db_project_list`"
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
                MessageBox.Show("Successfully added new lot.")
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Project Add Lot: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
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
End Class