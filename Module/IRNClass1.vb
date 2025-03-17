Imports System.Collections.Generic
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Schema

Public Class IRNClass
    Public Property status_cd As String
    Public Property [error] As ErrorResp
    Public Property Data As Object
    Public Property Status As String
    Public Property ErrorDetails() As Errordetail()
    Public Property InfoDtls() As Infodtl()
    Public Class Errordetail
        Public Property ErrorCode As String
        Public Property ErrorMessage As String
    End Class
    Public Class Infodtl
        Public Property InfCd As String
        Public Property Desc As Object

    End Class
    Public Class Desc
        Public Property AckNo As Long
        Public Property AckDt As String
        Public Property Irn As String

    End Class
End Class
Public Class ErrorResp
    Public Property error_cd As String
    Public Property message As String
End Class
Public Class IRNData
    Public Property AckNo As String
    Public Property AckDt As String
    Public Property Irn As String
    Public Property SignedInvoice As String
    Public Property SignedQRCode As String
    Public Property EwbNo As String
    Public Property EwbDt As String
    Public Property EwbValidTill As String
    Public Property QrCodeImage As String
    Public Property JwtIssuer As String

End Class
Public Class ValidateSchema

End Class


