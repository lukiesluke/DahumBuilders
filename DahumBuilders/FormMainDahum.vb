﻿Imports System.Linq

Public Class FormMainDahum

    Private Sub FormMainDahum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of FormUserList).Any Then
            mFormUserList.Focus()
        Else
            mFormUserList = New FormUserList
            mFormUserList.MdiParent = Me
            mFormUserList.Show()
        End If
    End Sub

    Private Sub ClientRegistrationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientRegistrationFormToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormUserProfile).Any Then
            mFormUserProfile.WindowState = FormWindowState.Normal
            mFormUserProfile.Focus()
        Else
            mFormUserProfile = New FormUserProfile
            mFormUserProfile.ShowForm("NEW", Nothing)
        End If
    End Sub

    Private Sub CientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CientListToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormUserList).Any Then
            mFormUserList.Focus()
        Else
            mFormUserList = New FormUserList
            mFormUserList.MdiParent = Me
            mFormUserList.Show()
        End If
    End Sub
End Class