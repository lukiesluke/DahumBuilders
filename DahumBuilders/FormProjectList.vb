Imports MySql.Data.MySqlClient

Public Class FormProjectList
    Private Sub FormProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_project_list()
    End Sub

    Private Sub load_project_list()
        Dim table As New DataTable()

        sql = "SELECT id, proj_name, block , lot, sqm, price, 
IFNULL((SELECT CONCAT(last_name , ', ', first_name ) FROM `db_user_profile` WHERE `db_user_profile`.`id`= assigned_userid),'') AS assigned_name  
FROM `db_project_list` INNER JOIN `db_project_item` ON `db_project_list`.id=`db_project_item`.`pro_id`"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            'sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = userId
            sqlDataReader = sqlCommand.ExecuteReader()

            Dim item As ListViewItem
            ListViewProject.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                Dim price As Double = sqlDataReader("price")

                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("block"))
                item.SubItems.Add(sqlDataReader("lot"))
                item.SubItems.Add(sqlDataReader("sqm"))
                item.SubItems.Add(price.ToString("N2"))
                item.SubItems.Add(sqlDataReader("assigned_name"))
                ListViewProject.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub
End Class