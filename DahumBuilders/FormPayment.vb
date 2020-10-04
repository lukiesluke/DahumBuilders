Imports MySql.Data.MySqlClient

Public Class FormPayment
    Dim userId As String = ""
    Dim userName As String = ""
    Dim userAddress As String = ""

    Public Sub ShowForm(id As String, name As String, address As String)
        userId = id
        userName = name
        userAddress = address
        Me.ShowDialog()
    End Sub

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(950, 500)
        lblName.Text = userName
        lblAddress.Text = userAddress
        load_userId_info()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If PanelPayment.Visible = True Then
            PanelPayment.Visible = False
        Else
            PanelPayment.Visible = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub load_userId_info()
        Dim table As New DataTable()

        sql = "SELECT * FROM `db_project_list` INNER JOIN `db_project_item` ON 
        db_project_list.`id`=db_project_item.`pro_id` WHERE `db_project_item`.`assigned_userid` = @userId"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = userId
            sqlDataReader = sqlCommand.ExecuteReader()

            Dim item As ListViewItem
            ListViewUserItem.Items.Clear()
            Do While sqlDataReader.Read = True
                item = New ListViewItem(sqlDataReader("id").ToString)
                Dim tcp As Double = sqlDataReader("total_contract_price")

                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("block_and_lot"))
                item.SubItems.Add(sqlDataReader("lot_area"))
                item.SubItems.Add(tcp.ToString("N2"))
                ListViewUserItem.Items.Add(item)
            Loop
            sqlDataReader.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

    End Sub

    Private Sub btnSearchProject_Click(sender As Object, e As EventArgs) Handles btnSearchProject.Click
        If Application.OpenForms().OfType(Of FormProjectList).Any Then
            If mFormUserProfile.WindowState = 1 Then
                mFormUserProfile.WindowState = 0
            End If
        Else
            mFormProjectList = New FormProjectList
            mFormProjectList.ShowDialog(Me)
        End If
    End Sub
End Class