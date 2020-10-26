﻿Public Class Project
    Public Property _itemID As String = ""
    Public Property _name As String = ""
    Public Property _block As String = ""
    Public Property _lot As String = ""
    Public Property _sqm As String = ""
    Public Property _tcp As Double = 0
    Public Property _total_balance As Double = 0
    Public Property _total_discount As Double = 0
    Public Property _total_paidAmount As Double = 0
    Public Property _payment_method As New Dictionary(Of String, PaymentMethod)
    Public Property _equity As Double = 0
    Public Property _amortization As Double = 0
    Public Property _projID As String = ""
    Public Property _description As String = ""
    Public Property _assignedToUserName As String = ""

End Class
