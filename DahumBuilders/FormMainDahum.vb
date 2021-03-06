Imports MySql.Data.MySqlClient
Imports FireSharp.Interfaces
Imports FireSharp.Config
Imports FireSharp.Response

Imports System.Linq

Public Class FormMainDahum

    Private client As IFirebaseClient

    Private Sub FormMainDahum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ModuleConnection.CompanyName
        DahumConfiguration()
        showLoginForm()

        If userLogon IsNot Nothing Then
            ToolStripStatusUsername.Text = userLogon._username
        End If

        ToolStripStatusIP.Text = String.Format("IP: {0}", serverSetting._ip)

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

    Private Sub OfficialRecieptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficialRecieptToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FormMyOREntries).Any Then
            mFormMyOREntries.Focus()
        Else
            mFormMyOREntries = New FormMyOREntries
            mFormMyOREntries.ShowDialog()
        End If
    End Sub

    Function generateProjectList(id As Integer) As List(Of FirebaseProjectList)
        sql = "SELECT `block`,`lot`,`sqm`,`price`,`assigned_userid` FROM `db_project_item` WHERE `proj_id`=@ID ORDER BY `block`, `lot` ASC"
        Dim projectList As New List(Of FirebaseProjectList)()

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id
            sqlDataReader = sqlCommand.ExecuteReader()

            Do While sqlDataReader.Read = True
                Dim project = New FirebaseProjectList() With {
                        .block = sqlDataReader("block"),
                        .lot = sqlDataReader("lot"),
                        .sqm = sqlDataReader("sqm"),
                        .tcp = sqlDataReader("price"),
                        .assignStat = sqlDataReader("assigned_userid")
                    }
                projectList.Add(project)
            Loop
            Return projectList
        Catch ex As Exception
            Return New List(Of FirebaseProjectList)()
        End Try
    End Function

    Private Sub ProjectPriceListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectPriceListToolStripMenuItem.Click
        Dim m = New FormProjectPriceList
        m.ShowDialog()
    End Sub

    Private Sub SummaryReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SummaryReportToolStripMenuItem1.Click
        Dim form As New FormSendReportFirebase
        form.ShowDialog()
    End Sub

    Private Sub ProjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectListToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            client = New FireSharp.FirebaseClient(fireCon)
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        Dim projectList As New List(Of FirebaseProject)()
        sql = "SELECT `id`,`proj_name`,`proj_address` FROM `db_project_list` ORDER BY `proj_name` ASC"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            Do While sqlDataReader.Read = True
                Dim project = New FirebaseProject() With {
                        .id = sqlDataReader("id"),
                        .projName = sqlDataReader("proj_name"),
                        .address = sqlDataReader("proj_address")
                    }
                projectList.Add(project)
            Loop

            For Each project In projectList
                project.projectList = generateProjectList(project.id)
            Next

            client.Set(pathProjectTest, projectList)

            Cursor = Cursors.Default
            MessageBox.Show("Successfully synce to live database.")
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EntriesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntriesToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of FormExpenses).Any Then
            mFormExpenses.Focus()
        Else
            mFormExpenses = New FormExpenses
            mFormExpenses.Show()
        End If
    End Sub
End Class