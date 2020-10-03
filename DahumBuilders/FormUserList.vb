Imports MySql.Data.MySqlClient

Public Class FormUserList
    Dim currentUserId As String = ""

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
            currentUserId = ListViewUser.SelectedItems(0).Text
            txtName.Text = ListViewUser.SelectedItems(0).SubItems(2).Text
            txtSurname.Text = ListViewUser.SelectedItems(0).SubItems(1).Text
            txtMiddleName.Text = ListViewUser.SelectedItems(0).SubItems(3).Text
            txtGender.Text = ListViewUser.SelectedItems(0).SubItems(4).Text
            txtCivilStatus.Text = ListViewUser.SelectedItems(0).SubItems(5).Text
            txtDateOfBirth.Text = ListViewUser.SelectedItems(0).SubItems(6).Text
            txtAddress.Text = ListViewUser.SelectedItems(0).SubItems(7).Text

            If currentUserId.Length > 0 Then
                enableDisableClientButton(True)
            Else
                enableDisableClientButton(False)
            End If

            If ListViewUser.SelectedItems(0).SubItems(8).Text.Length < 3 Then
                    If ListViewUser.SelectedItems(0).SubItems(4).Text = "Male" Then
                        PictureBox1.Image = My.Resources.client_male
                    Else
                        PictureBox1.Image = My.Resources.client_female
                    End If
                Else
                    PictureBox1.ImageLocation = ListViewUser.SelectedItems(0).SubItems(8).Text
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
        currentUserId = ListViewUser.SelectedItems(0).Text
        txtName.Text = ListViewUser.SelectedItems(0).SubItems(2).Text
        txtSurname.Text = ListViewUser.SelectedItems(0).SubItems(1).Text
        txtMiddleName.Text = ListViewUser.SelectedItems(0).SubItems(3).Text
        txtGender.Text = ListViewUser.SelectedItems(0).SubItems(4).Text
        txtCivilStatus.Text = ListViewUser.SelectedItems(0).SubItems(5).Text
        txtDateOfBirth.Text = ListViewUser.SelectedItems(0).SubItems(6).Text
        txtAddress.Text = ListViewUser.SelectedItems(0).SubItems(7).Text

        If currentUserId.Length > 0 Then
            enableDisableClientButton(True)
        Else
            enableDisableClientButton(False)
        End If

        If ListViewUser.SelectedItems(0).SubItems(8).Text.Length < 3 Then
            If ListViewUser.SelectedItems(0).SubItems(4).Text = "Male" Then
                PictureBox1.Image = My.Resources.client_male
            Else
                PictureBox1.Image = My.Resources.client_female
            End If
        Else
            PictureBox1.ImageLocation = ListViewUser.SelectedItems(0).SubItems(8).Text
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
End Class