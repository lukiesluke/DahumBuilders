Public Class FormPaymentMethod
    Public Property mProject As Project = New Project()
    Private Sub FormPaymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmountEQ.Text = mProject._itemID
        txtAmountMA.Text = mProject._projID & " user:" & mProject._userID
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class