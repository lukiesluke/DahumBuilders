﻿Imports System.Linq

Public Class FormMainDahum

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRegistrationToolStripMenuItem.Click

        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            mFormUserProfile.Focus()
        Else
            mFormUserProfile = New FormUserProfile("")
            mFormUserProfile.ShowDialog()
        End If
    End Sub

    Private Sub FormMainDahum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of FormUserList).Any Then
            mFormUserList.Focus()
        Else
            mFormUserList = New FormUserList
            mFormUserList.MdiParent = Me
            mFormUserList.Show()
        End If
    End Sub

End Class