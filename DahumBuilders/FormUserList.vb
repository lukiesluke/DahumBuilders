Imports MySql.Data.MySqlClient

Public Class FormUserList
    Dim mUser As User
    Dim mDisableLoadUserType As Boolean = False
    Dim mDisableLoadProject As Boolean = False

    Private Sub FormUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Computer.Screen.Bounds.Top)
        With Me.ComboBoxSearch.Items
            .Add("Surname")
            .Add("Name")
        End With
        ComboBoxSearch.SelectedIndex = 0
        labelRows.Text = "Row's: " & ListViewUser.Items.Count

        Panel1.Controls.OfType(Of TextBox).All(Function(b)
                                                   b.ReadOnly = True
                                                   Return True
                                               End Function)
        enableDisableClientButton(False)
        loadProjectListCombobox()
        loadComboBoxUserType()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        mDisableLoadUserType = True
        mDisableLoadProject = True

        cbbUserType.SelectedIndex = 0
        cbbProjectList.SelectedIndex = 0
        searchUser("")
        mDisableLoadUserType = False
        mDisableLoadProject = False
    End Sub

    Private Sub searchUser(value As String)
        ListViewUser.Items.Clear()
        Dim item As ListViewItem
        If value.Equals("All") Or value.Length < 1 Then
            If ComboBoxSearch.SelectedIndex = 0 Then
                sql = "SELECT `id`,`last_name`,`first_name`,`middle_name`,`gender`,`civil_status`,`address`,`date_birth`,`mobile_number`,
                (SELECT `type` FROM `db_user_type` WHERE `id`=u.`user_type`) user_type, 
                IF(`agent_id`=0, '',  CONCAT(`first_name`, ' ', `last_name`)) `agent_name`,
                IF(`agent_id`=0, '',  `mobile_number`) `agent_contact`,
                `file_location_image` FROM `db_user_profile` u WHERE u.`last_name` LIKE @valueSearch ORDER BY u.`user_type`, u.`last_name`"
            ElseIf ComboBoxSearch.SelectedIndex = 1 Then
                sql = "SELECT `id`,`last_name`,`first_name`,`middle_name`,`gender`,`civil_status`,`address`,`date_birth`,`mobile_number`,
                (SELECT `type` FROM `db_user_type` WHERE `id`=u.`user_type`) user_type,
                IF(`agent_id`=0, '',  CONCAT(`first_name`, ' ', `last_name`)) `agent_name`,
                IF(`agent_id`=0, '',  `mobile_number`) `agent_contact`,
                `file_location_image` FROM `db_user_profile` u WHERE u.`first_name` LIKE @valueSearch ORDER BY u.`user_type`, u.`last_name`"
            End If
        Else
            txtSearch.Text = ""
            sql = "SELECT `id`, `last_name`,`first_name`,`middle_name`,`gender`,`civil_status`,`address`,
            `date_birth`,`mobile_number`,`file_location_image`, (SELECT `type` FROM `db_user_type` WHERE `id`=p.`user_type`) user_type,
            IF(`agent_id`=0, '',  CONCAT(`first_name`, ' ', `last_name`)) `agent_name`,
            IF(`agent_id`=0, '',  `mobile_number`) `agent_contact`
            FROM `db_user_profile` p
            INNER JOIN `db_project_item` i ON i.`assigned_userid`=p.`id` AND i.`proj_id`=@ProjID GROUP BY p.`id` ORDER BY p.`last_name`"
        End If

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            If value.Equals("All") Or value.Length < 1 Then
                sqlCommand.Parameters.Add("@valueSearch", MySqlDbType.VarChar).Value = "%" & txtSearch.Text.Trim & "%"
            Else
                Dim key As String = DirectCast(cbbProjectList.SelectedItem, KeyValuePair(Of String, String)).Key
                sqlCommand.Parameters.Add("@ProjID", MySqlDbType.Int32).Value = key
                txtSearch.Text = ""
            End If

            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                Dim user As User = New User()
                user._id = sqlDataReader("id")
                user._surname = sqlDataReader("last_name")
                user._middleName = sqlDataReader("middle_name")
                user._name = sqlDataReader("first_name")
                user._gender = sqlDataReader("gender")
                user._civilStatus = sqlDataReader("civil_status")
                user._dateOfBirth = sqlDataReader("date_birth")
                user._address = sqlDataReader("address")
                user._mobile = sqlDataReader("mobile_number")
                user._image_location = IIf(IsDBNull(sqlDataReader("file_location_image")), "", sqlDataReader("file_location_image"))
                user._userTypeStr = sqlDataReader("user_type")
                user._agentName = sqlDataReader("agent_name")
                user._agentMobile = sqlDataReader("agent_contact")

                item = New ListViewItem(user._id)
                item.SubItems.Add(user._surname)
                item.SubItems.Add(user._name)
                item.SubItems.Add(user._middleName)
                item.SubItems.Add(user._gender)
                item.SubItems.Add(user._civilStatus)
                item.SubItems.Add(user._dateOfBirth.ToString("MMM dd, yyyy"))
                item.SubItems.Add(user._address)
                If IsDBNull(user._image_location) Or user._image_location.Length.Equals(String.Empty) Then
                    item.SubItems.Add("")
                Else
                    item.SubItems.Add(user._image_location)
                End If
                item.SubItems.Add(user._mobile)
                item.SubItems.Add(user._userTypeStr)
                item.SubItems.Add(user._agentName)
                item.SubItems.Add(user._agentMobile)

                ListViewUser.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        labelRows.Text = "Row's: " & ListViewUser.Items.Count
    End Sub

    Private Sub ListViewUser_KeyUp(sender As Object, e As KeyEventArgs) Handles ListViewUser.KeyUp
        ListViewUser_Click(sender, e)
    End Sub

    Private Sub ListViewUser_Click(sender As Object, e As EventArgs) Handles ListViewUser.Click
        If ListViewUser.Items.Count < 1 Then
            Exit Sub
        End If
        mUser = New User()
        mUser._id = ListViewUser.SelectedItems(0).Text
        mUser._surname = ListViewUser.SelectedItems(0).SubItems(1).Text
        mUser._name = ListViewUser.SelectedItems(0).SubItems(2).Text
        mUser._middleName = ListViewUser.SelectedItems(0).SubItems(3).Text
        mUser._gender = ListViewUser.SelectedItems(0).SubItems(4).Text
        mUser._civilStatus = ListViewUser.SelectedItems(0).SubItems(5).Text
        mUser._dateOfBirth = ListViewUser.SelectedItems(0).SubItems(6).Text
        mUser._address = ListViewUser.SelectedItems(0).SubItems(7).Text
        mUser._image_location = ListViewUser.SelectedItems(0).SubItems(8).Text
        mUser._mobile = ListViewUser.SelectedItems(0).SubItems(9).Text

        txtName.Text = mUser._name
        txtSurname.Text = mUser._surname
        txtMiddleName.Text = mUser._middleName
        txtGender.Text = mUser._gender
        txtCivilStatus.Text = mUser._civilStatus
        txtDateOfBirth.Text = mUser._dateOfBirth.ToString("MMMM dd, yyyy")
        txtAddress.Text = mUser._address
        txtMobileContact.Text = mUser._mobile

        If mUser._id.Length > 0 Then
            enableDisableClientButton(True)
        Else
            enableDisableClientButton(False)
        End If

        If mUser._image_location.Length < 3 Then
            If ListViewUser.SelectedItems(0).SubItems(4).Text = "Male" Then
                PictureBox1.Image = My.Resources.client_male
            Else
                PictureBox1.Image = My.Resources.client_female
            End If
        Else
            PictureBox1.ImageLocation = mUser._image_location
        End If
    End Sub

    Private Sub btnProfileInfo_Click(sender As Object, e As EventArgs) Handles btnProfileInfo.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormUserProfile = New FormUserProfile()
            mFormUserProfile.ShowForm("VIEW", mUser._id)
        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormUserProfile = New FormUserProfile
            mFormUserProfile.ShowForm("UPDATE", mUser._id)
        End If
    End Sub

    Private Sub enableDisableClientButton(value As Boolean)
        btnPayment.Enabled = value
        btnProfileInfo.Enabled = value
        btnStatementAccount.Enabled = value
        btnUpdateRecord.Enabled = value
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If Application.OpenForms().OfType(Of FormPayment).Any Then
            mFormPayment.WindowState = FormWindowState.Maximized
            mFormPayment.Focus()
        Else
            mFormPayment = New FormPayment
            mFormPayment.MdiParent = FormMainDahum
            mFormPayment.mUser = mUser
            mFormPayment.Show()
        End If
    End Sub

    Private Sub btnStatementAccount_Click(sender As Object, e As EventArgs) Handles btnStatementAccount.Click
        If Application.OpenForms().OfType(Of FormCRptTransaction).Any Then
            If mFormCRptTransaction.WindowState = 1 Then
                mFormCRptTransaction.WindowState = 0
            End If
        Else
            mFormCRptTransaction = New FormCRptTransaction
            mFormCRptTransaction.mUser = mUser
            mFormCRptTransaction.Show()
        End If
    End Sub

    Private Sub loadProjectListCombobox()
        sql = "SELECT id, `proj_name` FROM `db_project_list`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectList.DataSource = Nothing
            cbbProjectList.Items.Clear()

            Dim comboSourceProject As New Dictionary(Of String, String)()
            comboSourceProject.Add("0", "All")
            Do While sqlDataReader.Read = True
                comboSourceProject.Add(sqlDataReader("id"), sqlDataReader("proj_name"))
            Loop

            cbbProjectList.DataSource = New BindingSource(comboSourceProject, Nothing)
            cbbProjectList.DisplayMember = "Value"
            cbbProjectList.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cbbProjectList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectList.SelectedIndexChanged
        If mDisableLoadProject = True Then
            Exit Sub
        End If

        mDisableLoadUserType = True
        Try
            cbbUserType.SelectedIndex = 0
            Dim value As String = DirectCast(cbbProjectList.SelectedItem, KeyValuePair(Of String, String)).Value
            searchUser(value)
        Catch ex As Exception

        End Try
        mDisableLoadUserType = False
    End Sub

    Private Sub loadComboBoxUserType()
        sql = "SELECT `id`, `type` FROM `db_user_type`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbUserType.DataSource = Nothing
            cbbUserType.Items.Clear()

            Dim comboSourceUserType As New Dictionary(Of Integer, String)()
            comboSourceUserType.Add(-1, "All")
            Do While sqlDataReader.Read = True
                comboSourceUserType.Add(sqlDataReader("id"), sqlDataReader("type"))
            Loop

            cbbUserType.DataSource = New BindingSource(comboSourceUserType, Nothing)
            cbbUserType.DisplayMember = "Value"
            cbbUserType.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cbbUserType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbUserType.SelectedValueChanged
        If mDisableLoadUserType = True Then
            Exit Sub
        End If

        Dim key As Integer = DirectCast(cbbUserType.SelectedItem, KeyValuePair(Of Integer, String)).Key
        If -1 = key Then
            selectPerUserType(key)
        Else
            selectPerUserType(key)
        End If
    End Sub

    Private Sub selectPerUserType(key As String)
        Dim item As ListViewItem
        ListViewUser.Items.Clear()
        Connection()
        Try

            sql = "SELECT `id`,`last_name`,`first_name`,`middle_name`,`gender`,`civil_status`,`address`,`date_birth`,`mobile_number`,
                (SELECT `type` FROM `db_user_type` WHERE `id`=u.`user_type`) user_type, 
                IF(`agent_id`=0, '',  CONCAT(`first_name`, ' ', `last_name`)) `agent_name`,
                IF(`agent_id`=0, '',  `mobile_number`) `agent_contact`,
                `file_location_image` FROM `db_user_profile` u {0} ORDER BY u.`user_type`, u.`last_name`"

            If -1 = key Then
                sql = String.Format(sql, "")
                sqlCommand = New MySqlCommand(sql, sqlConnection)
            Else
                sql = String.Format(sql, "WHERE `user_type`=@UserType")
                sqlCommand = New MySqlCommand(sql, sqlConnection)
                sqlCommand.Parameters.Add("@UserType", MySqlDbType.Int32).Value = key
            End If

            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                Dim user As User = New User()
                user._id = sqlDataReader("id")
                user._surname = sqlDataReader("last_name")
                user._middleName = sqlDataReader("middle_name")
                user._name = sqlDataReader("first_name")
                user._gender = sqlDataReader("gender")
                user._civilStatus = sqlDataReader("civil_status")
                user._dateOfBirth = sqlDataReader("date_birth")
                user._address = sqlDataReader("address")
                user._mobile = sqlDataReader("mobile_number")
                user._image_location = IIf(IsDBNull(sqlDataReader("file_location_image")), "", sqlDataReader("file_location_image"))
                user._userTypeStr = sqlDataReader("user_type")
                user._agentName = sqlDataReader("agent_name")
                user._agentMobile = sqlDataReader("agent_contact")

                item = New ListViewItem(user._id)
                item.SubItems.Add(user._surname)
                item.SubItems.Add(user._name)
                item.SubItems.Add(user._middleName)
                item.SubItems.Add(user._gender)
                item.SubItems.Add(user._civilStatus)
                item.SubItems.Add(user._dateOfBirth.ToString("MMM dd, yyyy"))
                item.SubItems.Add(user._address)
                If IsDBNull(user._image_location) Or user._image_location.Length.Equals(String.Empty) Then
                    item.SubItems.Add("")
                Else
                    item.SubItems.Add(user._image_location)
                End If
                item.SubItems.Add(user._mobile)
                item.SubItems.Add(user._userTypeStr)
                item.SubItems.Add(user._agentName)
                item.SubItems.Add(user._agentMobile)

                ListViewUser.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
        labelRows.Text = "Row's: " & ListViewUser.Items.Count
    End Sub

End Class