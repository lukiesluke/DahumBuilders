Imports MySql.Data.MySqlClient

Public Class FormUserList
    Dim currentUserId As String = ""
    Dim currentUserName As String = ""
    Dim currentUserAddress As String = ""

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
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ListViewUser.Items.Clear()

        Dim item As ListViewItem
        If ComboBoxSearch.SelectedIndex = 0 Then
            sql = "SELECT * FROM `db_user_profile` WHERE last_name LIKE @valueSearch"
        ElseIf ComboBoxSearch.SelectedIndex = 1 Then
            sql = "SELECT * FROM `db_user_profile` WHERE first_name LIKE @valueSearch"
        End If

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@valueSearch", MySqlDbType.VarChar).Value = "%" & txtSearch.Text.Trim & "%"
            sqlDataReader = sqlCommand.ExecuteReader()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                item.SubItems.Add(sqlDataReader("last_name"))
                item.SubItems.Add(sqlDataReader("first_name"))
                item.SubItems.Add(sqlDataReader("middle_name"))
                item.SubItems.Add(sqlDataReader("gender"))
                item.SubItems.Add(sqlDataReader("civil_status"))
                item.SubItems.Add(Format(sqlDataReader("date_birth"), "MMM dd, yyyy").ToString())
                item.SubItems.Add(sqlDataReader("address"))
                If IsDBNull(sqlDataReader("file_location_image")) Then
                    item.SubItems.Add("")
                Else
                    item.SubItems.Add(sqlDataReader("file_location_image"))
                End If
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

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            Dim user As User = New User()
            user._id = ListViewUser.SelectedItems(0).Text
            user._surname = ListViewUser.SelectedItems(0).SubItems(1).Text
            user._name = ListViewUser.SelectedItems(0).SubItems(2).Text
            user._middleName = ListViewUser.SelectedItems(0).SubItems(3).Text
            user._gender = ListViewUser.SelectedItems(0).SubItems(4).Text
            user._civilStatus = ListViewUser.SelectedItems(0).SubItems(5).Text
            user._dateOfBirth = ListViewUser.SelectedItems(0).SubItems(6).Text
            user._address = ListViewUser.SelectedItems(0).SubItems(7).Text
            user._image_location = ListViewUser.SelectedItems(0).SubItems(8).Text

            currentUserId = user._id
            currentUserAddress = user._address
            currentUserName = user._name & " " & user._middleName & " " & user._surname

            txtName.Text = user._name
            txtSurname.Text = user._surname
            txtMiddleName.Text = user._middleName
            txtGender.Text = user._gender
            txtCivilStatus.Text = user._civilStatus
            txtDateOfBirth.Text = user._dateOfBirth
            txtAddress.Text = currentUserAddress

            If currentUserId.Length > 0 Then
                enableDisableClientButton(True)
            Else
                enableDisableClientButton(False)
            End If

            If user._image_location.Length < 3 Then
                If ListViewUser.SelectedItems(0).SubItems(4).Text = "Male" Then
                    PictureBox1.Image = My.Resources.client_male
                Else
                    PictureBox1.Image = My.Resources.client_female
                End If
            Else
                PictureBox1.ImageLocation = user._image_location
            End If
        End If

        If e.KeyCode = Keys.F1 Then
            If Application.OpenForms().OfType(Of FormUserProfile).Any Then
                If mFormUserProfile.WindowState = 1 Then
                    mFormUserProfile.WindowState = 0
                End If
            Else
                mFormUserProfile = New FormUserProfile()
                mFormUserProfile.ShowForm("VIEW", ListViewUser.SelectedItems(0).Text)
            End If
        End If
    End Sub

    Private Sub ListViewUser_Click(sender As Object, e As EventArgs) Handles ListViewUser.Click
        Dim user As User = New User()
        user._id = ListViewUser.SelectedItems(0).Text
        user._surname = ListViewUser.SelectedItems(0).SubItems(1).Text
        user._name = ListViewUser.SelectedItems(0).SubItems(2).Text
        user._middleName = ListViewUser.SelectedItems(0).SubItems(3).Text
        user._gender = ListViewUser.SelectedItems(0).SubItems(4).Text
        user._civilStatus = ListViewUser.SelectedItems(0).SubItems(5).Text
        user._dateOfBirth = ListViewUser.SelectedItems(0).SubItems(6).Text
        user._address = ListViewUser.SelectedItems(0).SubItems(7).Text
        user._image_location = ListViewUser.SelectedItems(0).SubItems(8).Text

        currentUserId = user._id
        currentUserAddress = user._address
        currentUserName = user._name & " " & user._middleName & " " & user._surname

        txtName.Text = user._name
        txtSurname.Text = user._surname
        txtMiddleName.Text = user._middleName
        txtGender.Text = user._gender
        txtCivilStatus.Text = user._civilStatus
        txtDateOfBirth.Text = user._dateOfBirth
        txtAddress.Text = currentUserAddress

        If currentUserId.Length > 0 Then
            enableDisableClientButton(True)
        Else
            enableDisableClientButton(False)
        End If

        If user._image_location.Length < 3 Then
            If ListViewUser.SelectedItems(0).SubItems(4).Text = "Male" Then
                PictureBox1.Image = My.Resources.client_male
            Else
                PictureBox1.Image = My.Resources.client_female
            End If
        Else
            PictureBox1.ImageLocation = user._image_location
        End If
    End Sub

    Private Sub btnProfileInfo_Click(sender As Object, e As EventArgs) Handles btnProfileInfo.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormUserProfile = New FormUserProfile()
            mFormUserProfile.ShowForm("VIEW", currentUserId)
        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormUserProfile = New FormUserProfile
            mFormUserProfile.ShowForm("UPDATE", currentUserId)
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
            mFormPayment.userId = currentUserId
            mFormPayment.userName = currentUserName
            mFormPayment.userAddress = currentUserAddress
            mFormPayment.Show()
            'mFormPayment.ShowForm(currentUserId, currentUserName, currentUserAddress)
        End If
    End Sub

    Private Sub btnStatementAccount_Click(sender As Object, e As EventArgs) Handles btnStatementAccount.Click
        If Application.OpenForms().OfType(Of FormRptTransaction).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormRptTransaction = New FormRptTransaction
            mFormRptTransaction.ShowForm(currentUserId, currentUserName, currentUserAddress)
        End If
    End Sub
End Class