Public Class Transaction
    Public Property _id As String = ""
    Public Property _or As String = ""
    Public Property _voucher As String = ""
    Public Property _datePaid As Date = New Date
    Public Property _clientName As String = ""
    Public Property _tcp As String = ""
    Public Property _paidAmount As Double = 0
    Public Property _commission As Double = 0

    Public Property _penalty As Double = 0
    Public Property _discountAmount As Double = 0
    Public Property _particular As Integer = 0
    Public Property _particular_str As String = ""
    Public Property _partNo As String = ""
    Public Property _paymentType As String = ""
    Public Property _description As String = ""
    Public Property _clientId As String = ""
    Public Property _projectId As String = ""
    Public Property _projectItemId As String = ""
    Public Property _check_bank_name As String = ""
    Public Property _check_amount As Double
    Public Property _check_number As String = ""
    Public Property _check_date As Date = Nothing
    Public Property _created_by As Integer = 0
    Public Property _createdBy As String = ""
    Public Property _updatedBy As String = ""
End Class
