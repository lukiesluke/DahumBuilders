Public Class FormPaymentMethod
    Public Property mProject As Project = New Project()
    Private Sub FormPaymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmountEQ.Text = mProject._itemID
        txtAmountMA.Text = mProject._projID & " user:" & mProject._userID
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpEquityStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpEquityStart.ValueChanged
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(txtEquityTerm.Text)
        End If
    End Sub

    Private Sub txtEquityTerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEquityTerm.KeyUp
        If txtEquityTerm.Text.Trim IsNot String.Empty Then
            dtpEquityEnd.Value = dtpEquityStart.Value
            dtpEquityEnd.Value = dtpEquityEnd.Value.AddMonths(txtEquityTerm.Text)
        End If
    End Sub

    Private Sub txtMATerm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMATerm.KeyUp
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(txtMATerm.Text)
        End If
    End Sub

    Private Sub dtpMonthlyStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthlyStart.ValueChanged
        If txtMATerm.Text.Trim IsNot String.Empty Then
            dtpMonthlyEnd.Value = dtpMonthlyStart.Value
            dtpMonthlyEnd.Value = dtpMonthlyEnd.Value.AddMonths(txtMATerm.Text)
        End If
    End Sub

    Private Sub txtEquityTerm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEquityTerm.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMATerm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMATerm.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class