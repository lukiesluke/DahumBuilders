Public Class FormMainDahum

    Dim formUser As New FormUserProfile

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRegistrationToolStripMenuItem.Click


        If formUser.Visible = False Then
            formUser = New FormUserProfile
            formUser.MdiParent = Me
            formUser.Show()
        End If
        formUser.WindowState = FormWindowState.Maximized
    End Sub

End Class