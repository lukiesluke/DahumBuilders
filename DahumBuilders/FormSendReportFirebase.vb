Imports MySql.Data.MySqlClient

Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class FormSendReportFirebase

    Private client As IFirebaseClient

    Private Sub FormSendReportFirebase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
        Try
            client = New FireSharp.FirebaseClient(fireCon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSendReport_Click(sender As Object, e As EventArgs) Handles btnSendReport.Click
        btnSendReport.Enabled = False

        Try
            'Dim setter = client.Set("summaryTest/", summaryReport)
            'client.Push("summaryTest/", summaryReport)
            generateSummaryReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub generateSummaryReport()

        sql = "SELECT `date_paid` DatePaid,  
        SUM(CASE WHEN `payment_type`=0 THEN `paid_amount` ELSE 0 END) TotalCash,
        SUM(CASE WHEN `payment_type`=1 THEN `paid_amount` ELSE 0 END) TotalCheck,
        SUM(CASE WHEN `payment_type`=2 THEN `paid_amount` ELSE 0 END) TotalBankTransfer,
        SUM(`commission`) AS Expenses, 
        SUM(IF(`payment_type` = 0, `paid_amount`-`commission`,0)) AS TotalCashOnHand
        FROM `db_transaction` t GROUP BY `date_paid` ORDER BY `date_paid` DESC"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlDataReader = sqlCommand.ExecuteReader()

            Dim summaryList As New List(Of FirebaseSummaryReport)()
            Do While sqlDataReader.Read = True
                Dim dateVal As String = Format(sqlDataReader("DatePaid"), "yyyy-MM-dd").ToString
                Dim summaryReport As New FirebaseSummaryReport() With {
                    .datePaid = dateVal,
                    .totalCash = sqlDataReader("TotalCash"),
                    .totalCheck = sqlDataReader("TotalCheck"),
                    .totalBankTransfer = sqlDataReader("TotalBankTransfer"),
                    .expenses = sqlDataReader("Expenses")
                }
                summaryList.Add(summaryReport)
            Loop

            sqlCommand.Dispose()
            sqlConnection.Close()

            For Each summary In summaryList
                summary.details = generateDetailReport(summary.datePaid)
            Next

            client.Set(pathSummaryTest, summaryList)

            sqlDataReader.Dispose()
            lblStatus.Text = "Report Successfully submitted."

        Catch ex As Exception
            lblStatus.Text = ex.Message
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try

    End Sub

    Function generateDetailReport(ByRef dateVale As String) As List(Of FirebaseDetail)
        Dim detailList As New List(Of FirebaseDetail)()

        sql = "SELECT l.`id`, IFNULL(t.`date_paid`,0) 'DatePaid', l.`proj_name`,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=0 AND it.`date_paid` BETWEEN @Date AND @Date) AS cash,
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=1 AND it.`date_paid` BETWEEN @Date AND @Date) AS 'check',
        (SELECT IFNULL(SUM(it.`paid_amount`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=2 AND it.`date_paid` BETWEEN @Date AND @Date) AS 'bankTransfer',
        (SELECT IFNULL(SUM(it.`commission`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND it.`date_paid` BETWEEN @Date AND @Date) AS 'expenses',
        (SELECT IFNULL(SUM(it.`paid_amount`)-SUM(it.`commission`),0) FROM `db_transaction` it WHERE it.`proj_id`=t.`proj_id` AND  it.`payment_type`=0 AND it.`date_paid` BETWEEN @Date AND @Date) AS 'total'
        FROM `db_project_list` l LEFT JOIN `db_transaction` t ON l.id = t.`proj_id` GROUP BY l.`id` ORDER BY l.`proj_name` ASC"

        Connection()
        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@Date", MySqlDbType.VarChar).Value = dateVale
            sqlDataReader = sqlCommand.ExecuteReader()

            Do While sqlDataReader.Read = True
                Dim detail = New FirebaseDetail() With {
                        .projName = sqlDataReader("proj_name"),
                        .cash = sqlDataReader("cash"),
                        .check = sqlDataReader("check"),
                        .bankTransfer = sqlDataReader("bankTransfer"),
                        .expenses = sqlDataReader("expenses"),
                        .total = sqlDataReader("total")
                    }
                detailList.Add(detail)
            Loop
            Return detailList
        Catch ex As Exception
            Return New List(Of FirebaseDetail)()
            MessageBox.Show(ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Function

End Class