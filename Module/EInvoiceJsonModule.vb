
Public Class EInvoiceJsonModule

    Public Class TranDtls
        Public Property TaxSch As String
        Public Property SupTyp As String
        Public Property IgstOnIntra As String
        Public Property RegRev As String
    End Class

    Public Class DocDtls
        Public Property Typ As String
        Public Property No As String
        Public Property Dt As String
    End Class

    Public Class SellerDtls
        Public Property Gstin As String
        Public Property LglNm As String
        Public Property Addr1 As String
        Public Property Loc As String
        Public Property Pin As Integer
        Public Property Stcd As String
        Public Property Ph As String
        Public Property Em As String
    End Class

    Public Class BuyerDtls
        Public Property Gstin As String
        Public Property LglNm As String
        Public Property Pos As String
        Public Property Addr1 As String
        Public Property Loc As String
        Public Property Pin As Integer
        Public Property Stcd As String

    End Class

    Public Class ShipDtls
        Public Property Gstin As String
        Public Property LglNm As String

        Public Property Addr1 As String
        Public Property Loc As String
        Public Property Pin As Integer
        Public Property Stcd As String

    End Class

    Public Class ItemList
        Public Property SlNo As String
        Public Property IsServc As String
        Public Property HsnCd As String
        Public Property Qty As Double
        Public Property Unit As String
        Public Property UnitPrice As Double
        Public Property TotAmt As Double
        Public Property Discount As Double
        Public Property AssAmt As Double
        Public Property GstRt As Double
        Public Property IgstAmt As Double
        Public Property CgstAmt As Double
        Public Property SgstAmt As Double

        Public Property TotItemVal As Double
    End Class

    Public Class ValDtls
        Public Property AssVal As Double
        Public Property TotInvVal As Integer
        Public Property CgstVal As Double
        Public Property SgstVal As Double
        Public Property IgstVal As Double
        Public Property Discount As Double

    End Class
    Public Class EwbDtls
        Public Property TransId As String
        Public Property TransName As String
        Public Property TransMode As String
        Public Property Distance As String
        Public Property TransDocNo As String
        Public Property TransDocDt As String
        Public Property VehNo As String
        Public Property VehType As String

    End Class

    Public Class EInvoice
        Public Property Version As String
        Public Property TranDtls As TranDtls
        Public Property DocDtls As DocDtls
        Public Property SellerDtls As SellerDtls
        Public Property BuyerDtls As BuyerDtls
        Public Property ShipDtls As ShipDtls
        Public Property ItemList As List(Of ItemList)
        Public Property ValDtls As ValDtls
        Public Property EwbDtls As EwbDtls
    End Class
End Class
