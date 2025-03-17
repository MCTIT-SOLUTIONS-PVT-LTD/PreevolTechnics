Public Class AuthClass
    Public Property status_cd As String
    Public Property [error] As AuthError
    Public Property Data As Data
    Public Property ErrorDetails As Object
    Public Property InfoDtls As Object
    Public Property Status As Integer
End Class
Public Class Data
    Public AuthToken As String
    Public Property ClientId As String
    Public Property UserName As String
    Public Property Sek As String
    Public Property TokenExpiry As String

End Class

Public Class AuthError
    Public Property error_cd As String
    Public Property message As String
End Class


