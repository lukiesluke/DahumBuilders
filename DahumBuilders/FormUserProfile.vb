Imports MySql.Data.MySqlClient
Imports System.Linq

Public Class FormUserProfile

    Private currentUserId As String = ""
    Private formViewType As String = ""

    Public Sub ShowForm(formType As String, id As String)
        currentUserId = id
        formViewType = formType
        Me.Show()
    End Sub

    Private Sub FormUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Location = New Point(My.Computer.Screen.Bounds.Top)
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(550, 580)
        fileLocationImage = String.Empty
        lblAgentID.Text = 0

        With Me.ComboBoxGender.Items
            .Add("Male")
            .Add("Female")
        End With
        With Me.ComboBoxCivilStatus.Items
            .Add("Single")
            .Add("Married")
            .Add("Separated")
            .Add("Widow")
        End With

        ComboBoxGender.SelectedIndex = 0
        ComboBoxCivilStatus.SelectedIndex = 0
        Dim x As String = formViewType
        Select Case x
            Case "NEW"
                Me.Text = "Client Registration Form - [New]"
                btnSave.Visible = True
                btnSearch.Visible = False
                btnUpdate.Visible = False
            Case "UPDATE"
                If currentUserId.Length > 0 Then
                    Me.Text = "Client Information Record - [Update]"
                    disableAllCommandControl(False)
                    btnSave.Visible = False
                    btnSearch.PerformClick()
                End If
            Case "VIEW"
                If currentUserId.Length > 0 Then
                    Me.Text = "Client Information Record"
                    disableAllCommandControl(True)
                    btnSave.Visible = False
                    btnUpdate.Visible = False
                    btnSearch.PerformClick()
                    btnAddChild.Enabled = False
                    btnClearListChild.Enabled = False
                    btnAddBeneficiary.Enabled = False
                    btnClearListBeneficiary.Enabled = False
                End If
            Case Else
                MessageBox.Show("Error: " & currentUserId, "Information")
        End Select
        PictureBox1.Image = My.Resources.client_male
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFirstName.Text.Trim.Length < 1 Then
            txtFirstName.Focus()
            MessageBox.Show("Please Enter Client Name", "User Profile")
            Exit Sub
        ElseIf txtLastName.Text.Trim.Length < 1 Then
            txtLastName.Focus()
            MessageBox.Show("Please Enter Client Surname", "User Profile")
            Exit Sub
        End If

        sql = "INSERT INTO `db_user_profile` 
        (`first_name`, `middle_name`, `last_name`, `address`, `gender`, `civil_status`, `date_birth`, 
        `place_birth`, `citizenship`, `telephone_number`, `mobile_number`, `email_address`, 
        `occupation`, `company_name`, `spouse_name`, `spouse_occupation`, `spouse_contact`, 
        `father_name`, `father_provincial_address`, `mother_name`, `mother_provincial_address`,
        `file_location_image`, `sss`, `tin`, `id_type1`, `id_number1`, `id_type2`, `id_number2`,`agent_id`, `created_by`)  VALUES (@first_name, @middle_name, @last_name, @address, @gender,
        @civilStatus, @dateBirth, @placeBirth, @citizenship, @telephone, @mobile, @email, @occupation, 
        @companyName, @spouseName, @spouseOccupation, @spouseContact, @fatherName, @fatherAddress, @MotherName, 
        @MotherAddress, @fileLocationImage, @SSS, @TIN, @IdType1, @IdNumber1, @IdType2, @IdNumber2, @AgentId, @CreatedBy)"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)

        sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtFirstName.Text.Trim
        sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
        sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtLastName.Text.Trim
        sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
        sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = ComboBoxGender.Text.Trim

        sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = ComboBoxCivilStatus.Text.Trim
        sqlCommand.Parameters.Add("@dateBirth", MySqlDbType.Date).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@placeBirth", MySqlDbType.VarChar).Value = txtPlaceBirth.Text.Trim
        sqlCommand.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = txtCitizen.Text.Trim
        sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
        sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
        sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim
        sqlCommand.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = txtOccupation.Text.Trim
        sqlCommand.Parameters.Add("@companyName", MySqlDbType.VarChar).Value = txtCompanyName.Text.Trim

        sqlCommand.Parameters.Add("@spouseName", MySqlDbType.VarChar).Value = txtSpouseName.Text.Trim
        sqlCommand.Parameters.Add("@spouseOccupation", MySqlDbType.VarChar).Value = txtSpouseOccupation.Text.Trim
        sqlCommand.Parameters.Add("@spouseContact", MySqlDbType.VarChar).Value = txtSpouseContactNumber.Text.Trim

        sqlCommand.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = txtFatherName.Text.Trim
        sqlCommand.Parameters.Add("@fatherAddress", MySqlDbType.VarChar).Value = txtFatherAddress.Text.Trim
        sqlCommand.Parameters.Add("@MotherName", MySqlDbType.VarChar).Value = txtMotherName.Text.Trim
        sqlCommand.Parameters.Add("@MotherAddress", MySqlDbType.VarChar).Value = txtMotherAddress.Text.Trim
        sqlCommand.Parameters.Add("@fileLocationImage", MySqlDbType.VarChar).Value = fileLocationImage

        sqlCommand.Parameters.Add("@SSS", MySqlDbType.VarChar).Value = txtSSS.Text.Trim
        sqlCommand.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = txtTIN.Text.Trim

        sqlCommand.Parameters.Add("@IdType1", MySqlDbType.VarChar).Value = txtIdType1.Text.Trim
        sqlCommand.Parameters.Add("@IdType2", MySqlDbType.VarChar).Value = txtIdType2.Text.Trim
        sqlCommand.Parameters.Add("@IdNumber1", MySqlDbType.VarChar).Value = txtIdNumber1.Text.Trim
        sqlCommand.Parameters.Add("@IdNumber2", MySqlDbType.VarChar).Value = txtIdNumber2.Text.Trim
        sqlCommand.Parameters.Add("@AgentId", MySqlDbType.VarChar).Value = lblAgentID.Text.Trim
        sqlCommand.Parameters.Add("@CreatedBy", MySqlDbType.Int64).Value = userLogon._id

        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
                insertDataToChildAndBeneficiary(sqlCommand, sqlConnection, userLogon._username)
                MessageBox.Show("Successfully Saved")
                clearAllTextBox()
                sqlCommand.Dispose()
                sqlConnection.Close()
                Me.Close()
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Saving error: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
    Private Sub updateDataToChildAndBeneficiary(cmd As MySqlCommand, conn As MySqlConnection, clientID As String)
        If ListViewChild.Items.Count > 0 Then
            sql = "INSERT INTO `db_user_child` 
            (`first_name`, `userid`) VALUES (@firstName, @userid)"

            For Each item As ListViewItem In Me.ListViewChild.Items
                If item.Text.Equals("*") Then
                    cmd = New MySqlCommand(sql, conn)
                    sqlAdapter = New MySqlDataAdapter(cmd)
                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                    cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = clientID
                    cmd.ExecuteNonQuery()
                End If
            Next
        End If

        If ListViewBeneficiary.Items.Count > 0 Then
            sql = "INSERT INTO `db_user_beneficiary` 
            (`first_name`, `userid`) VALUES (@firstName, @userid)"

            For Each item As ListViewItem In Me.ListViewBeneficiary.Items
                If item.Text.Equals("*") Then
                    cmd = New MySqlCommand(sql, conn)
                    sqlAdapter = New MySqlDataAdapter(cmd)
                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                    cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = clientID
                    cmd.ExecuteNonQuery()
                End If
            Next
        End If
    End Sub

    Private Sub insertDataToChildAndBeneficiary(cmd As MySqlCommand, conn As MySqlConnection, user As String)
        Dim table As New DataTable()

        sql = "SELECT MAX(id) AS id FROM db_user_profile WHERE username=@username"

        cmd = New MySqlCommand(sql, conn)
        sqlAdapter = New MySqlDataAdapter(cmd)
        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user
        sqlAdapter.Fill(table)

        If ListViewChild.Items.Count > 0 Then

            sql = "INSERT INTO `db_user_child` 
            (`first_name`, `userid`) VALUES (@firstName, @userid)"

            For Each item As ListViewItem In Me.ListViewChild.Items
                cmd = New MySqlCommand(sql, conn)
                sqlAdapter = New MySqlDataAdapter(cmd)
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = table.Rows(0)("id").ToString
                cmd.ExecuteNonQuery()
            Next
        End If

        If ListViewBeneficiary.Items.Count > 0 Then

            sql = "INSERT INTO `db_user_beneficiary` 
            (`first_name`, `userid`) VALUES (@firstName, @userid)"

            For Each item As ListViewItem In Me.ListViewBeneficiary.Items
                cmd = New MySqlCommand(sql, conn)
                sqlAdapter = New MySqlDataAdapter(cmd)
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = item.SubItems.Item(1).Text.Trim
                cmd.Parameters.Add("@userid", MySqlDbType.VarChar).Value = table.Rows(0)("id").ToString
                cmd.ExecuteNonQuery()
            Next
        End If
    End Sub
    Private Sub getAgentList(cmd As MySqlCommand, conn As MySqlConnection, search As String, agentID As String)
        Dim item As ListViewItem
        cmd.Dispose()

        If search IsNot Nothing Then
            sql = "SELECT `id`, `first_name`,`last_name`, `mobile_number`, `user_type` FROM `db_user_profile` WHERE `user_type`>0 AND (`first_name` LIKE @search OR `last_name` LIKE @search)"
        Else
            sql = "SELECT `id`, `first_name`,`last_name`, `mobile_number`, `user_type` FROM `db_user_profile` WHERE `user_type`>0"
        End If

        cmd = New MySqlCommand(sql, conn)
        If search IsNot Nothing Then
            cmd.Parameters.Add("@search", MySqlDbType.VarChar).Value = search + "%"
        End If
        sqlDataReader = cmd.ExecuteReader()

        ListViewAgent.Items.Clear()
        Do While sqlDataReader.Read = True
            item = New ListViewItem(sqlDataReader("id").ToString)
            item.SubItems.Add(sqlDataReader("first_name"))
            item.SubItems.Add(sqlDataReader("last_name"))
            item.SubItems.Add(sqlDataReader("mobile_number"))
            item.SubItems.Add(sqlDataReader("user_type"))

            If lblAgentID.Text.Equals(sqlDataReader("id").ToString) Then
                txtAgentName.Text = sqlDataReader("last_name") + ", " + sqlDataReader("first_name")
                txtAgentContact.Text = sqlDataReader("mobile_number")
            End If

            ListViewAgent.Items.Add(item)
        Loop
        sqlDataReader.Dispose()
    End Sub

    Private Sub getUserChildAndBeneficiary(cmd As MySqlCommand, conn As MySqlConnection, userId As String)
        Dim item As ListViewItem

        sql = "SELECT * FROM `db_user_child` WHERE `userid` = @userid"
        cmd.Dispose()
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.Add("@userid", MySqlDbType.Int64).Value = userId
        sqlDataReader = cmd.ExecuteReader()

        ListViewChild.Items.Clear()
        Do While sqlDataReader.Read = True
            item = New ListViewItem(sqlDataReader("id").ToString)
            item.SubItems.Add(sqlDataReader("first_name"))
            item.SubItems.Add(sqlDataReader("middle_name"))
            item.SubItems.Add(sqlDataReader("last_name"))
            ListViewChild.Items.Add(item)
        Loop
        sqlDataReader.Dispose()

        sql = "SELECT * FROM `db_user_beneficiary` WHERE `userid` = @userid"
        cmd.Dispose()
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.Add("@userid", MySqlDbType.Int64).Value = userId
        sqlDataReader = cmd.ExecuteReader()

        ListViewBeneficiary.Items.Clear()
        Do While sqlDataReader.Read = True
            item = New ListViewItem(sqlDataReader("id").ToString)
            item.SubItems.Add(sqlDataReader("first_name"))
            item.SubItems.Add(sqlDataReader("middle_name"))
            item.SubItems.Add(sqlDataReader("last_name"))
            ListViewBeneficiary.Items.Add(item)
        Loop
        sqlDataReader.Dispose()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim userGender As String = ""
        Dim table As New DataTable()

        sql = "SELECT * FROM `db_user_profile` WHERE `Id` = @id"
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        sqlCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = currentUserId
        sqlAdapter = New MySqlDataAdapter(sqlCommand)

        Try
            sqlAdapter.Fill(table)

            If table.Rows.Count > 0 Then
                lblClientID.Text = table.Rows(0)("id")
                userGender = table.Rows(0)("gender")
                txtFirstName.Text = table.Rows(0)("first_name")
                txtMiddleName.Text = table.Rows(0)("middle_name")
                txtLastName.Text = table.Rows(0)("last_name")
                ComboBoxGender.Text = userGender
                txtAddress.Text = table.Rows(0)("address")
                DateTimePicker1.Value = table.Rows(0)("date_birth")

                ComboBoxCivilStatus.Text = table.Rows(0)("civil_status")
                txtPlaceBirth.Text = table.Rows(0)("place_birth")
                txtCitizen.Text = table.Rows(0)("citizenship")
                txtTelephone.Text = table.Rows(0)("telephone_number")
                txtMobile.Text = table.Rows(0)("mobile_number")
                txtEmail.Text = table.Rows(0)("email_address")
                txtOccupation.Text = table.Rows(0)("occupation")
                txtCompanyName.Text = table.Rows(0)("company_name")

                txtSpouseName.Text = table.Rows(0)("spouse_name")
                txtSpouseOccupation.Text = table.Rows(0)("spouse_occupation")
                txtSpouseContactNumber.Text = table.Rows(0)("spouse_contact")

                txtFatherName.Text = table.Rows(0)("father_name")
                txtFatherAddress.Text = table.Rows(0)("father_provincial_address")
                txtMotherName.Text = table.Rows(0)("mother_name")
                txtMotherAddress.Text = table.Rows(0)("mother_provincial_address")

                txtSSS.Text = table.Rows(0)("sss")
                txtTIN.Text = table.Rows(0)("tin")

                txtIdType1.Text = table.Rows(0)("id_type1")
                txtIdType2.Text = table.Rows(0)("id_type2")
                txtIdNumber1.Text = table.Rows(0)("id_number1")
                txtIdNumber2.Text = table.Rows(0)("id_number2")

                lblAgentID.Text = table.Rows(0)("agent_id")

                If userGender = "Male" Then
                    PictureBox1.Image = My.Resources.client_male
                Else
                    PictureBox1.Image = My.Resources.client_female
                End If

                If table.Rows(0)("file_location_image").ToString.Length < 3 Then
                    If userGender = "Male" Then
                        PictureBox1.Image = My.Resources.client_male
                    Else
                        PictureBox1.Image = My.Resources.client_female
                    End If
                Else
                    fileLocationImage = table.Rows(0)("file_location_image")
                    PictureBox1.ImageLocation = fileLocationImage
                End If

                getUserChildAndBeneficiary(sqlCommand, sqlConnection, currentUserId)
                getAgentList(sqlCommand, sqlConnection, Nothing, lblAgentID.Text.Trim)

            Else
                MessageBox.Show("No Data Found")
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtFirstName.Text.Trim.Length < 1 Then
            txtFirstName.Focus()
            MessageBox.Show("Please Enter Client Name", "User Profile")
            Exit Sub
        ElseIf txtLastName.Text.Trim.Length < 1 Then
            txtLastName.Focus()
            MessageBox.Show("Please Enter Client Surname", "User Profile")
            Exit Sub
        End If

        sql = "UPDATE `db_user_profile` p SET `first_name`=@first_name, `middle_name`=@middle_name, 
        `last_name`=@last_name, `address`=@address, `gender`=@gender,
        `civil_status`=@civilStatus, `date_birth`=@dateBirth, `place_birth`=@placeBirth, 
        `citizenship`=@citizenship, `telephone_number`=@telephone, `mobile_number`=@mobile,
        `email_address`=@email, `occupation`=@occupation, `company_name`=@companyName, `spouse_name`=@spouseName,
        `spouse_occupation`=@spouseOccupation, `spouse_contact`=@spouseContact, `father_name`=@fatherName,
        `father_provincial_address`=@fatherAddress, `mother_name`=@MotherName, `mother_provincial_address`=@MotherAddress,
        `file_location_image`=@fileLocationImage, `sss`=@SSS, `tin`=@TIN, `id_type1`=@IdType1, `id_number1`=@IdNumber1, `id_type2`=@IdType2, `id_number2`=@IdNumber2,
        `agent_id`=@AgentId, `modified_by`=@ModifiedBy, `modified_date`=@ModifiedDate WHERE p.`id`=@currentUserId"

        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)

        sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = txtFirstName.Text.Trim
        sqlCommand.Parameters.Add("@middle_name", MySqlDbType.VarChar).Value = txtMiddleName.Text.Trim
        sqlCommand.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = txtLastName.Text.Trim
        sqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtAddress.Text.Trim
        sqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = ComboBoxGender.Text.Trim

        sqlCommand.Parameters.Add("@civilStatus", MySqlDbType.VarChar).Value = ComboBoxCivilStatus.Text.Trim
        sqlCommand.Parameters.Add("@dateBirth", MySqlDbType.Date).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
        sqlCommand.Parameters.Add("@placeBirth", MySqlDbType.VarChar).Value = txtPlaceBirth.Text.Trim
        sqlCommand.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = txtCitizen.Text.Trim
        sqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txtTelephone.Text.Trim
        sqlCommand.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtMobile.Text.Trim
        sqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim
        sqlCommand.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = txtOccupation.Text.Trim
        sqlCommand.Parameters.Add("@companyName", MySqlDbType.VarChar).Value = txtCompanyName.Text.Trim

        sqlCommand.Parameters.Add("@spouseName", MySqlDbType.VarChar).Value = txtSpouseName.Text.Trim
        sqlCommand.Parameters.Add("@spouseOccupation", MySqlDbType.VarChar).Value = txtSpouseOccupation.Text.Trim
        sqlCommand.Parameters.Add("@spouseContact", MySqlDbType.VarChar).Value = txtSpouseContactNumber.Text.Trim

        sqlCommand.Parameters.Add("@fatherName", MySqlDbType.VarChar).Value = txtFatherName.Text.Trim
        sqlCommand.Parameters.Add("@fatherAddress", MySqlDbType.VarChar).Value = txtFatherAddress.Text.Trim
        sqlCommand.Parameters.Add("@MotherName", MySqlDbType.VarChar).Value = txtMotherName.Text.Trim
        sqlCommand.Parameters.Add("@MotherAddress", MySqlDbType.VarChar).Value = txtMotherAddress.Text.Trim
        sqlCommand.Parameters.Add("@@fileLocationImage", MySqlDbType.VarChar).Value = fileLocationImage

        sqlCommand.Parameters.Add("@SSS", MySqlDbType.VarChar).Value = txtSSS.Text.Trim
        sqlCommand.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = txtTIN.Text.Trim

        sqlCommand.Parameters.Add("@IdType1", MySqlDbType.VarChar).Value = txtIdType1.Text.Trim
        sqlCommand.Parameters.Add("@IdType2", MySqlDbType.VarChar).Value = txtIdType2.Text.Trim
        sqlCommand.Parameters.Add("@IdNumber1", MySqlDbType.VarChar).Value = txtIdNumber1.Text.Trim
        sqlCommand.Parameters.Add("@IdNumber2", MySqlDbType.VarChar).Value = txtIdNumber2.Text.Trim
        sqlCommand.Parameters.Add("@currentUserId", MySqlDbType.Int32).Value = currentUserId
        sqlCommand.Parameters.Add("@AgentId", MySqlDbType.VarChar).Value = lblAgentID.Text.Trim
        sqlCommand.Parameters.Add("@ModifiedBy", MySqlDbType.Int64).Value = userLogon._id
        sqlCommand.Parameters.Add("@ModifiedDate", MySqlDbType.DateTime).Value = DateTime.Now

        Try
            If sqlCommand.ExecuteNonQuery() = 1 Then
                updateDataToChildAndBeneficiary(sqlCommand, sqlConnection, lblClientID.Text)
                MessageBox.Show("User Profile Successfully Updated")
                clearAllTextBox()
                sqlCommand.Dispose()
                sqlConnection.Close()
                Me.Close()
            Else
                MessageBox.Show("Data was not updated. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnAddChild_Click(sender As Object, e As EventArgs) Handles btnAddChild.Click

        If txtChildName.Text.Trim().Length > 0 Then
            If formViewType.Equals("UPDATE") Then
                Dim item As New ListViewItem("*")
                item.SubItems.Add(txtChildName.Text.Trim)
                ListViewChild.Items.Add(item)
            Else
                Dim item As New ListViewItem(ListViewChild.Items.Count + 1)
                item.SubItems.Add(txtChildName.Text.Trim)
                ListViewChild.Items.Add(item)
            End If
            txtChildName.Text = ""
            Else
            If txtChildName.Text.Trim().Length < 1 Then
                txtChildName.Focus()
                MsgBox("Please Enter Child Name.", MsgBoxStyle.Information, "Child Information")
            End If
        End If
        txtChildName.Focus()
    End Sub

    Private Sub btnAddBeneficiary_Click(sender As Object, e As EventArgs) Handles btnAddBeneficiary.Click
        If txtBeneficiaryName.Text.Trim.Length > 0 Then
            If formViewType.Equals("UPDATE") Then
                Dim item As New ListViewItem("*")
                item.SubItems.Add(txtBeneficiaryName.Text.Trim)
                ListViewBeneficiary.Items.Add(item)
            Else
                Dim item As New ListViewItem(ListViewBeneficiary.Items.Count + 1)
                item.SubItems.Add(txtBeneficiaryName.Text.Trim)
                ListViewBeneficiary.Items.Add(item)
            End If
            txtBeneficiaryName.Text = ""
        Else
            If txtBeneficiaryName.Text.Trim.Length < 1 Then
                txtBeneficiaryName.Focus()
                MsgBox("Please Enter Beneficiary Name.", MsgBoxStyle.Information, "Beneficiary Information")
            End If
        End If
        txtBeneficiaryName.Focus()
    End Sub

    Private Sub btnClearListBeneficiary_Click(sender As Object, e As EventArgs) Handles btnClearListBeneficiary.Click

        ListViewBeneficiary.Items.Clear()
        txtBeneficiaryName.Focus()
        txtBeneficiaryName.Text = ""
    End Sub

    Private Sub btnClearListChild_Click(sender As Object, e As EventArgs) Handles btnClearListChild.Click

        ListViewChild.Items.Clear()
        txtChildName.Focus()

        txtChildName.Text = ""
    End Sub

    Private Sub txtChildName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtChildName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddChild.PerformClick()
        End If
    End Sub

    Private Sub txtChildSurname_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAddChild.PerformClick()
        End If
    End Sub

    Private Sub txtBeneficiaryName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBeneficiaryName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddBeneficiary.PerformClick()
        End If
    End Sub

    Private Sub txtBeneficiarySurname_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAddBeneficiary.PerformClick()
        End If
    End Sub

    Private Sub clearAllTextBox()

        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""

        txtPlaceBirth.Text = ""
        txtCitizen.Text = ""
        txtTelephone.Text = ""
        txtMobile.Text = ""
        txtEmail.Text = ""
        txtOccupation.Text = ""
        txtCompanyName.Text = ""

        txtSpouseName.Text = ""
        txtSpouseOccupation.Text = ""
        txtSpouseContactNumber.Text = ""

        txtFatherName.Text = ""
        txtFatherAddress.Text = ""
        txtMotherName.Text = ""
        txtMotherAddress.Text = ""

        txtChildName.Text = ""
        txtBeneficiaryName.Text = ""

        ListViewChild.Clear()
        ListViewBeneficiary.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Application.OpenForms().OfType(Of FormImageCapture).Any Then
            mFormImageCapture.Focus()
        Else
            mFormImageCapture = New FormImageCapture
            mFormImageCapture.Show(Me)
        End If
    End Sub

    Private Sub disableAllCommandControl(value As Boolean)
        TabPage1.Controls.OfType(Of TextBox).All(Function(b)
                                                     b.ReadOnly = value
                                                     Return True
                                                 End Function)
        TabPage2.Controls.OfType(Of TextBox).All(Function(b)
                                                     b.ReadOnly = value
                                                     Return True
                                                 End Function)

        TabPage3.Controls.OfType(Of TextBox).All(Function(b)
                                                     b.ReadOnly = value
                                                     Return True
                                                 End Function)

        gbContactInformation.Controls.OfType(Of TextBox).All(Function(b)
                                                                 b.ReadOnly = value
                                                                 Return True
                                                             End Function)

        gbEmploymentInfo.Controls.OfType(Of TextBox).All(Function(b)
                                                             b.ReadOnly = value
                                                             Return True
                                                         End Function)

        gbParentInfo.Controls.OfType(Of TextBox).All(Function(b)
                                                         b.ReadOnly = value
                                                         Return True
                                                     End Function)
        gbChilderName.Controls.OfType(Of TextBox).All(Function(b)
                                                          b.ReadOnly = value
                                                          Return True
                                                      End Function)
        gbId.Controls.OfType(Of TextBox).All(Function(b)
                                                 b.ReadOnly = value
                                                 Return True
                                             End Function)
    End Sub

    Private Sub btnSearchAgent_Click(sender As Object, e As EventArgs) Handles btnSearchAgent.Click
        Connection()
        sqlCommand = New MySqlCommand(sql, sqlConnection)
        getAgentList(sqlCommand, sqlConnection, txtSearchAgent.Text.Trim, lblAgentID.Text.Trim)
        sqlCommand.Dispose()
        sqlConnection.Close()
    End Sub

    Private Sub ListViewAgent_Click(sender As Object, e As EventArgs) Handles ListViewAgent.Click, ListViewAgent.KeyUp
        If ListViewAgent.Items.Count > 0 Then
            lblAgentID.Text = ListViewAgent.SelectedItems.Item(0).Text
            txtAgentName.Text = ListViewAgent.SelectedItems.Item(0).SubItems(2).Text + ", " + ListViewAgent.SelectedItems.Item(0).SubItems(1).Text
            txtAgentContact.Text = ListViewAgent.SelectedItems.Item(0).SubItems(3).Text
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        btnSearch.PerformClick()
    End Sub
End Class
