Imports MySql.Data.MySqlClient

Public Class FormVerification
    Public Property deleteExpensesEntry As String = ""
    Public Property mId As String = ""
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mVerification = False
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If userLogon._password.Equals(txtPassword.Text) Then
            lblErrorMessage.Visible = False

            If deleteExpensesEntry.Equals(delExpensesID) Then
                deleteExpenses(mId)
            End If
            Me.Close()
            mVerification = True
        Else
            mVerification = False
            lblErrorMessage.Visible = True
            lblErrorMessage.Text = "Invalid password. Please try again."
        End If
    End Sub

    Private Sub FormVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblErrorMessage.Visible = False
        mVerification = False
    End Sub

    Function deleteExpenses(mId As String)
        Connection()
        sql = "INSERT INTO `db_history_delete` (`OR`,`amount`,`userID`,`name`) 
        SELECT CONCAT('EXP_OR:',`official_receipt_no`, ':EXP_VOU:', `voucher_no`), `paid_amount`, @UserID, @Name FROM `db_transaction` WHERE id=@ID;
        DELETE FROM `db_transaction` WHERE `id`=@ID"

        Try
            sqlCommand = New MySqlCommand(sql, sqlConnection)
            sqlCommand.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = userLogon._id
            sqlCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = userLogon._name
            sqlCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = mId

            If sqlCommand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Successfully Delete")
                mFormExpenses.btnSearchDate.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show("DELETE Official Reciept ERROR: " & ex.Message)
        Finally
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Function
End Class