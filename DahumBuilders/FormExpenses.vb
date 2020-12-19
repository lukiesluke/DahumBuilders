Imports MySql.Data.MySqlClient

Public Class FormExpenses
    Private Sub FormExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSales()
    End Sub

    Private Sub loadSales()
        Connection()
        sql = "SELECT `proj_id`, (SELECT `proj_name` FROM `db_project_list` WHERE `id`= t.`proj_id`) proj_name,
              `date_paid`, SUM(`paid_amount`) totalCash FROM `db_transaction` t WHERE `payment_type`=0 GROUP BY `proj_id`"

        sqlCommand = New MySqlCommand(sql, sqlConnection)
        'sqlCommand.Parameters.Add("@Block", MySqlDbType.VarChar).Value = txtBlock.Text.Trim
        sqlDataReader = sqlCommand.ExecuteReader()
        Try
            Dim item As ListViewItem
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("proj_id").ToString)
                item.UseItemStyleForSubItems = False
                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("date_paid"))
                Dim totalCash As Double = sqlDataReader("totalCash")
                With item.SubItems.Add(totalCash.ToString("N2"))
                    .Font = New Font(ListView1.Font, FontStyle.Regular)
                    .ForeColor = Color.Red
                End With
                ListView1.Items.Add(item)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class