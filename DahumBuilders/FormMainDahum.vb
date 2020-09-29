Public Class FormMainDahum

    Dim formUser As New FormUserProfile
    Dim formUserList As New FormUserList

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRegistrationToolStripMenuItem.Click

        If formUser.Visible = False Then
            formUser = New FormUserProfile
            formUser.MdiParent = Me
            formUser.Show()
        End If
        'formUser.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        If formUserList.Visible = False Then
            formUserList = New FormUserList
            formUserList.MdiParent = Me
            formUserList.Show()
        End If
        'formUserList.WindowState = FormWindowState.Maximized
    End Sub
End Class