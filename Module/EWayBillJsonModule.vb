
Public Class EWayBillJsonModule
    Public Class Address
        Public Property Nm As String
        Public Property Addr1 As String
        Public Property Addr2 As String
        Public Property Loc As String
        Public Property Pin As Integer
        Public Property Stcd As String
    End Class

    Public Class EWayBill
        Public Property Irn As String
        Public Property Distance As Integer
        Public Property TransMode As String
        Public Property TransId As String
        Public Property TransName As String
        Public Property TransDocDt As String
        Public Property TransDocNo As String
        Public Property VehNo As String
        Public Property VehType As String
        Public Property ExpShipDtls As Address
        Public Property DispDtls As Address
    End Class
End Class
