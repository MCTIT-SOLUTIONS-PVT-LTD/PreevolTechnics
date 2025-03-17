Imports Newtonsoft.Json

Public Class EWayBillClass
    Public Property EWayData As Object
    Public Property itemList As List(Of Item)
    Public Property VehiclListDetails As List(Of VehicleDetails)
    Public Property status_cd As String
    Public Property [error] As EwayErrorResp
    Public Property ErrorDetails() As Errordetail1()
End Class
Public Class EWayData
    Public Property ewbNo As Long
    Public Property ewayBillDate As String
    Public Property genMode As String
    Public Property userGstin As String
    Public Property supplyType As String
    Public Property subSupplyType As String
    Public Property docType As String
    Public Property docNo As String
    Public Property docDate As String
    Public Property fromGstin As String
    Public Property fromTrdName As String
    Public Property fromAddr1 As String
    Public Property fromAddr2 As String
    Public Property fromPlace As String
    Public Property fromPincode As Integer
    Public Property fromStateCode As Integer
    Public Property toGstin As String
    Public Property toTrdName As String
    Public Property toAddr1 As String
    Public Property toAddr2 As String
    Public Property toPlace As String
    Public Property toPincode As Integer
    Public Property toStateCode As Integer
    Public Property totalValue As Decimal
    Public Property totInvValue As Decimal
    Public Property cgstValue As Decimal
    Public Property sgstValue As Decimal
    Public Property igstValue As Decimal
    Public Property cessValue As Decimal
    Public Property transporterId As String
    Public Property transporterName As String
    Public Property status As String
    Public Property actualDist As Integer
    Public Property noValidDays As Integer
    Public Property validUpto As String
    Public Property extendedTimes As Integer
    Public Property rejectStatus As String
    Public Property vehicleType As String
    Public Property actFromStateCode As Integer
    Public Property actToStateCode As Integer
    Public Property transactionType As Integer
    Public Property otherValue As Decimal
    Public Property cessNonAdvolValue As Decimal
End Class
Public Class Item
    Public Property itemNo As Integer
    Public Property productId As Integer
    Public Property productName As String
    Public Property productDesc As String
    Public Property hsnCode As Integer
    Public Property quantity As Decimal
    Public Property qtyUnit As String
    Public Property cgstRate As Decimal
    Public Property sgstRate As Decimal
    Public Property igstRate As Decimal
    Public Property cessRate As Decimal
    Public Property cessNonAdvol As Decimal
    Public Property taxableAmount As Decimal
End Class

Public Class VehicleDetails
    Public Property updMode As String
    Public Property vehicleNo As String
    Public Property fromPlace As String
    Public Property fromState As Integer
    Public Property tripshtNo As Integer
    Public Property userGSTINTransin As String
    Public Property enteredDate As String
    Public Property transMode As String
    Public Property transDocNo As String
    Public Property transDocDate As String
    Public Property groupNo As String
End Class

Public Class Errordetail1
    Public Property ErrorCode As String
    Public Property ErrorMessage As String
End Class
Public Class EwayErrorResp
    Public Property error_cd As String
    Public Property message As String
End Class
