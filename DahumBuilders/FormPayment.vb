Imports MySql.Data.MySqlClient

Public Class FormPayment
    Dim userId As String = ""
    Dim userName As String = ""
    Dim userAddress As String = ""
    Dim sumOfTotalContractPrice As Double = 0

    Public Sub ShowForm(id As String, name As String, address As String)
        userId = id
        userName = name
        userAddress = address
        Me.ShowDialog()
    End Sub

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (20)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.Size = New Size(950, 650)
        lblName.Text = userName
        lblAddress.Text = userAddress
        'load_userId_info()
        load_userId_info_data_reader()
        cbParticular.SelectedIndex = -1
        PanelDownpayment.Visible = False
        PanelEquity.Visible = False

        Dim totalEquityAmount As Double = txtEquityAmount.Text
        txtEquityAmount.Text = totalEquityAmount.ToString("N2")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
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
                Dim price As Double = sqlDataReader("price")

                item.SubItems.Add(sqlDataReader("proj_name"))
                item.SubItems.Add(sqlDataReader("block"))
                item.SubItems.Add(sqlDataReader("lot"))
                item.SubItems.Add(sqlDataReader("sqm"))
                item.SubItems.Add(price.ToString("N2"))
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

    Private Sub load_userId_info_data_reader()

        sql = "SELECT * FROM `db_project_list` INNER JOIN `db_project_item` ON 
        db_project_list.`id`=db_project_item.`pro_id` WHERE `db_project_item`.`assigned_userid` = @userId"

        Connection()
        Try
            Dim table As New DataTable()

            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@userId", MySqlDbType.Int64).Value = userId
            sqlAdapter = New MySqlDataAdapter
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(table)
            End With

            Dim item As ListViewItem
            For i = 0 To table.Rows.Count - 1
                item = New ListViewItem(table.Rows(i)("id").ToString)
                item.SubItems.Add(table.Rows(i)("proj_name"))
                item.SubItems.Add(table.Rows(i)("block"))
                item.SubItems.Add(table.Rows(i)("lot"))
                item.SubItems.Add(table.Rows(i)("sqm"))
                item.SubItems.Add(String.Format("{0:n}", table.Rows(i)("price")))
                ListViewUserItem.Items.Add(item)

            Next

            sumOfTotalContractPrice = Convert.ToDouble(table.Compute("SUM(price)", String.Empty))
            With ListViewUserItem
                .Items.Add("")
                With .Items(.Items.Count - 1).SubItems
                    .Add("")
                    .Add("")
                    .Add("")
                    .Add("")
                    .Add("")
                    .Add(String.Format("{0:n}", sumOfTotalContractPrice))
                End With
            End With

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

    Private Sub cbDownpaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDownpaymentType.SelectedIndexChanged

        If cbDownpaymentType.SelectedIndex > -1 Then
            lblAmountDownpayment.Text = computeDownpayment(sumOfTotalContractPrice, Double.Parse(cbDownpaymentType.Text)).ToString("N2")
        End If
        If cbDiscountType.SelectedIndex < 0 Then
            cbDiscountType.SelectedIndex = 0
        End If
        amountToPay()
    End Sub

    Private Sub cbDiscountType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbDiscountType.SelectedIndexChanged
        If cbDiscountType.SelectedIndex > -1 Then
            lblAmountDiscount.Text = computeDiscount(Double.Parse(lblAmountDownpayment.Text), Double.Parse(cbDiscountType.Text)).ToString("N2")
        End If
        amountToPay()
    End Sub

    Private Function computeDownpayment(totalPrice As Double, downPayment As Double) As Double
        Dim percentageDownpayment As Double = downPayment / 100
        Return totalPrice * percentageDownpayment
    End Function

    Private Function computeDiscount(totalPrice As Double, discount As Double) As Double
        Dim percentageDiscount As Double = discount / 100
        Return totalPrice * percentageDiscount
    End Function

    Private Sub cbMonthsToPay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonthsToPay.SelectedIndexChanged
        amountToPay()
    End Sub
    Private Sub amountToPay()
        'Downpayment
        lblAmountToPay.Text = (Double.Parse(lblAmountDownpayment.Text) - Double.Parse(lblAmountDiscount.Text)).ToString("N2")
        lblBalance.Text = (sumOfTotalContractPrice - Convert.ToDouble(lblAmountDownpayment.Text)).ToString("N2")
        If cbMonthsToPay.SelectedIndex > -1 Then
            lblMonthly.Text = (Double.Parse(lblBalance.Text) / Integer.Parse(cbMonthsToPay.Text)).ToString("N2")
        End If

        'Equity
        Dim totalEquityAmount As Double = txtEquityAmount.Text
        If cbEquityMonthsToPay.SelectedIndex > -1 Then
            lblMonthlyEquity.Text = (totalEquityAmount / Integer.Parse(cbEquityMonthsToPay.Text)).ToString("N2")
        End If
        lblEquityBalanceToPay.Text = (sumOfTotalContractPrice - Double.Parse(txtEquityAmount.Text)).ToString("N2")
        txtEquityAmount.Text = totalEquityAmount.ToString("N2")

        If cbEquityBalanceMonthToPay.SelectedIndex > -1 Then
            lblEquityMonthlyAmortization.Text = (Double.Parse(lblEquityBalanceToPay.Text) / Integer.Parse(cbEquityBalanceMonthToPay.Text)).ToString("N2")
        End If
    End Sub

    Private Sub cbEquityMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEquityMonthsToPay.SelectedIndexChanged
        amountToPay()
    End Sub

    Private Sub cbEquityBalanceMonthToPay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEquityBalanceMonthToPay.SelectedIndexChanged
        amountToPay()
    End Sub

    Private Sub cbParticular_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbParticular.SelectedIndexChanged
        Select Case cbParticular.SelectedIndex
            Case -1
                PanelDownpayment.Visible = False
                PanelEquity.Visible = False
            Case 0 'Downpayment
                PanelEquity.Visible = False
                If PanelDownpayment.Visible = False Then
                    PanelDownpayment.Visible = True
                End If

            Case 1 'Equity
                PanelDownpayment.Visible = False
                If PanelEquity.Visible = False Then
                    PanelEquity.Visible = True
                End If
        End Select

    End Sub

End Class