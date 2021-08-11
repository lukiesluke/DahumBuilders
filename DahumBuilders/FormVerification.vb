Public Class FormVerification
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        mVerification = False
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If userLogon._password.Equals(txtPassword.Text) Then
            lblErrorMessage.Visible = False
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
End Class