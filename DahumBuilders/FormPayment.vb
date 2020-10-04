Public Class FormPayment


    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If PanelPayment.Visible = True Then
            PanelPayment.Visible = False
        Else
            PanelPayment.Visible = True
        End If
    End Sub


    Public Sub ShowForm(formType As String, id As String)
        Me.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Me.Close()
    End Sub

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(900, 500)
    End Sub
End Class