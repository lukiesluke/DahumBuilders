Public Class FirebaseSummaryReport
    Public Property datePaid() As String = ""
    Public Property totalCash() As Double = 0
    Public Property totalCheck() As Double = 0
    Public Property totalBankTransfer() As Double = 0
    Public Property expenses() As Double = 0
    Public Property details() As New List(Of FirebaseDetail)()
End Class
