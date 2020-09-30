Imports System.Linq

Public Class FormMainDahum

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRegistrationToolStripMenuItem.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            formUser.Focus()
        Else
            formUser = New FormUserProfile
            formUser.MdiParent = Me
            formUser.Show()
        End If
    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click

        If Application.OpenForms().OfType(Of FormUserList).Any Then
            FormUserList.Focus()
        Else
            FormUserList.MdiParent = Me
            FormUserList.Show()
        End If
    End Sub
End Class