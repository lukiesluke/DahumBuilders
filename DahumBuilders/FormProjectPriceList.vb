Imports MySql.Data.MySqlClient

Public Class FormProjectPriceList
    Private Sub FormProjectPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ProjectName_combobox()
    End Sub
    Private Sub cbbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProjectName.SelectedIndexChanged

        Dim key As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Value
        lblProjectName.Text = value
        load_price_list(key)
    End Sub

    Private Sub load_price_list(ByVal value As String)
        'Refrence source http://vb.net-informations.com/dataset/bind-combobox.htm

        Dim item As ListViewItem

        sql = "SELECT `id`,`sqm`,`tcp` FROM `db_project_list_price` WHERE `lid`=@listID"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@listID", MySqlDbType.Int32).Value = value
            sqlDataReader = sqlCommand.ExecuteReader()

            ListView1.Items.Clear()

            Do While sqlDataReader.Read = True

                'Add to list view
                item = New ListViewItem(sqlDataReader("id").ToString)
                Dim tcp As Double = sqlDataReader("tcp")
                item.SubItems.Add(sqlDataReader("sqm"))
                item.SubItems.Add(tcp.ToString("N2"))
                ListView1.Items.Add(item)
            Loop

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub load_ProjectName_combobox()

        sql = "SELECT `id`, `proj_name` FROM `db_project_list`"
        Connection()
        Try
            Cursor = Cursors.WaitCursor
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            cbbProjectName.DataSource = Nothing
            cbbProjectName.Items.Clear()

            Dim comboSourceProjectName As New Dictionary(Of String, String)()
            Do While sqlDataReader.Read = True
                comboSourceProjectName.Add(sqlDataReader("id"), sqlDataReader("proj_name"))
            Loop

            cbbProjectName.DataSource = New BindingSource(comboSourceProjectName, Nothing)
            cbbProjectName.DisplayMember = "Value"
            cbbProjectName.ValueMember = "Key"

            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtTcp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTcp.KeyPress, txtSQM.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim key As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(cbbProjectName.SelectedItem, KeyValuePair(Of String, String)).Value

        sql = "INSERT INTO `db_project_list_price` (`sqm`, `tcp`,`lid`) VALUES (@SQM, @TCP,@LID)"
        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@SQM", MySqlDbType.Int32).Value = txtSQM.Text.Trim
            sqlCommand.Parameters.Add("@TCP", MySqlDbType.Double).Value = txtTcp.Text.Trim
            sqlCommand.Parameters.Add("@LID", MySqlDbType.Int32).Value = key

            If sqlCommand.ExecuteNonQuery() = 1 Then
                txtSQM.Text = String.Empty
                txtTcp.Text = String.Empty
                MessageBox.Show("Successfully added new project name.")
            Else
                MessageBox.Show("Data NOT Inserted. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Project Add: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

        load_price_list(key)
    End Sub
End Class