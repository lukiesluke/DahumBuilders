Module ModuleForm
    Public mFormUserProfile As New FormUserProfile
    Public mFormUserList As New FormUserList
    Public mFormImageCapture As FormImageCapture
    Public mFormPayment As FormPayment
    Public mFormProjectList As FormProjectList


    Public Function computePercentage(totalPrice As Double, value As ComboBox) As Double
        Dim percentageDownpayment As Double = Double.Parse(value.Text) / 100
        Return totalPrice * percentageDownpayment
    End Function

    Public Function toDouble(control As Label) As Double
        Return Double.Parse(control.Text.Trim())
    End Function

    Public Function toDouble(control As TextBox) As Double
        Return Double.Parse(control.Text.Trim())
    End Function

End Module
