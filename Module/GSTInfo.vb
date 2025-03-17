Public Class GSTResponse
    Public Property status_cd As String
    Public Property [error] As GSTError
    Public Property Status As String
    Public Property Data As String
    Public Property ErrorDetails() As Errordetail()
    Public Property InfoDtls As Object
End Class
Public Class Errordetail
    Public Property ErrorCode As String
    Public Property ErrorMessage As String
End Class
Public Class ErrorResp1
    Public Property error_cd As String
    Public Property message As String
End Class
Public Class GSTData
    Public Property Gstin As String
    Public Property TradeName As String
    Public Property LegalName As String
    Public Property AddrBnm As String
    Public Property AddrBno As String
    Public Property AddrFlno As String
    Public Property AddrSt As String
    Public Property AddrLoc As String
    Public Property StateCode As Integer
    Public Property AddrPncd As Integer
    Public Property TxpType As String
    Public Property Status As String
    Public Property BlkStatus As String
    Public Property DtReg As String
    Public Property DtDReg As String
End Class
Public Class GSTError
    Public Property error_cd As String
    Public Property message As String
End Class