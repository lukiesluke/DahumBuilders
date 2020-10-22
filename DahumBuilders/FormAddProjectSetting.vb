Imports MySql.Data.MySqlClient

Public Class FormAddProjectSetting
    Private Sub FormProjectSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ProjectName_combobox()
        cbbProjectName.SelectedIndex = 0
    End Sub

    Private Sub load_ProjectName_combobox()
        sql = "SELECT proj_name FROM `db_project_list`"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()
            cbbProjectName.Items.Clear()
            Do While sqlDataReader.Read = True
                cbbProjectName.Items.Add(sqlDataReader("proj_name"))
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class