﻿Imports System.Linq

Public Class FormMainDahum

    Private Sub FormMainDahum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DahumConfiguration()
        showLoginForm()

        If userLogon IsNot Nothing Then
            ToolStripStatusUsername.Text = userLogon._username
        End If

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

    Private Sub AddProjectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddProjectToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of FormAddProjectSetting).Any Then
            mFormAddProjectSetting.Focus()
        Else
            mFormAddProjectSetting = New FormAddProjectSetting
            mFormAddProjectSetting.ShowDialog(Me)
        End If
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormCRptSalesReport).Any Then
            mFormSalesReport.Focus()
        Else
            mFormSalesReport = New FormCRptSalesReport
            mFormSalesReport.Show()
        End If
    End Sub

    Private Sub SummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryReportToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormCRptSummaryReport).Any Then
            mFormCRptSummaryReport.Focus()
        Else
            mFormCRptSummaryReport = New FormCRptSummaryReport
            mFormCRptSummaryReport.Show()
        End If
    End Sub

    Private Sub showLoginForm()
        If Application.OpenForms().OfType(Of FormLogin).Any Then
            mFormLogin.Focus()
        Else
            mFormLogin = New FormLogin
            mFormLogin.ShowDialog()
        End If
    End Sub

    Private Sub EmployeeRegistrationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeRegistrationFormToolStripMenuItem.Click

        If Application.OpenForms().OfType(Of FormEmployeeRegistration).Any Then
            mFormEmployeeRegistration.Focus()
        Else
            mFormEmployeeRegistration = New FormEmployeeRegistration
            mFormEmployeeRegistration.ShowDialog()
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormEmployeeRegistration).Any Then
            mFormEmployeeRegistration.Focus()
        Else
            mFormEmployeeRegistration = New FormEmployeeRegistration
            mFormEmployeeRegistration.mUpdate = True
            mFormEmployeeRegistration.ShowDialog()
        End If
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormExpenses).Any Then
            mFormExpenses.Focus()
        Else
            mFormExpenses = New FormExpenses
            mFormExpenses.Show()
        End If
    End Sub
End Class