Module ModuleForm
    Public mFormUserProfile As New FormUserProfile
    Public mFormUserList As New FormUserList
    Public mFormImageCapture As FormImageCapture
    Public mFormPayment As FormPayment
    Public mFormProjectList As FormProjectList
    Public mFormRptTransaction As FormRptTransaction

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

    Public Function toDouble(control As ComboBox) As Double
        Return Double.Parse(control.Text)
    End Function

    Public Function downpaymentAmount(particular As ComboBox, dp As Label, equityAmount As TextBox) As Double
        Dim value As Double = 0
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = toDouble(dp)
            Case 1 'Equity
                value = toDouble(equityAmount)
        End Select
        Return value
    End Function

    Public Function BalanceMonthToPay(particular As ComboBox, dp As ComboBox, equityAmount As ComboBox) As String
        Dim value As String = ""
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = dp.Text.Trim()
            Case 1 'Equity
                value = equityAmount.Text.Trim()
        End Select
        Return value
    End Function

    Public Function monthlyAmortization(particular As ComboBox, dp As Label, equityAmount As Label) As Double
        Dim value As Double = 0
        Select Case particular.SelectedIndex
            Case 0 'Downpayment
                value = toDouble(dp)
            Case 1 'Equity
                value = toDouble(equityAmount)
        End Select
        Return value
    End Function
End Module
