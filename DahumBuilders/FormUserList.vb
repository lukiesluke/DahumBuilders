Imports MySql.Data.MySqlClient

Public Class FormUserList
    Dim mUser As User

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
        If Application.OpenForms().OfType(Of FormRptTransaction).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormRptTransaction = New FormRptTransaction
            mFormRptTransaction.mUser = mUser
            mFormRptTransaction.ShowDialog()
        End If
    End Sub

    Private Sub ListViewUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewUser.SelectedIndexChanged

    End Sub
End Class