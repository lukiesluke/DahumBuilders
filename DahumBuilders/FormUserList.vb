﻿Imports MySql.Data.MySqlClient

Public Class FormUserList
    Dim formUser As New FormUserProfile

    Private Sub FormUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ComboBoxSearch.Items
            .Add("Surname")
            .Add("Name")
        End With
        ComboBoxSearch.SelectedIndex = 0
        labelRows.Text = "Row's: " & ListViewUser.Items.Count
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

    Private Sub ListViewUser_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewUser.MouseClick
        Dim a As String = ListViewUser.SelectedItems(0).SubItems(1).Text

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            formUser.Focus()
            formUser.txtUserId.Text = ListViewUser.SelectedItems(0).Text
            formUser.btnSearch.PerformClick()
        Else
            formUser = New FormUserProfile
            formUser.MdiParent = FormMainDahum
            formUser.Show()
            formUser.WindowState = FormWindowState.Normal
            formUser.txtUserId.Text = ListViewUser.SelectedItems(0).Text
            formUser.btnSearch.PerformClick()
        End If

        'If formUser.Visible = False Then
        '    formUser = New FormUserProfile
        '    formUser.MdiParent = FormMainDahum

        '    formUser.Show()
        '    formUser.WindowState = FormWindowState.Normal
        '    formUser.txtUserId.Text = ListViewUser.SelectedItems(0).Text
        '    formUser.btnSearch.PerformClick()
        'Else
        '    formUser.WindowState = FormWindowState.Normal
        '    formUser.txtUserId.Text = ListViewUser.SelectedItems(0).Text
        '    formUser.btnSearch.PerformClick()
        'End If

    End Sub

    Private Sub ListViewUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewUser.SelectedIndexChanged

    End Sub
End Class