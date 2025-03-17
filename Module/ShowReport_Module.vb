#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraReports.UI' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraReports.UI
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraReports.UI' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraReports.Parameters' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraReports.Parameters
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraReports.Parameters' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports System.Windows.Forms
Imports System
Imports System.Data.SqlClient

Module ShowReport_Module
    Dim TempStr As String

#Disable Warning BC30002 ' Type 'DevExpress.XtraReports.UI.XtraReport' is not defined.
    Public Function ShowReport_Func(ByRef XtraReport As DevExpress.XtraReports.UI.XtraReport, ByRef BillID As Integer, ByRef TransportID As Integer) As Boolean
#Enable Warning BC30002 ' Type 'DevExpress.XtraReports.UI.XtraReport' is not defined.
        Try
            '' If InvoiceNo <> Nothing Then XtraReport.FilterString = "[InvoiceID] = [" & InvoiceNo & "]"
            'Dim DS As New DataSet
            ''  DS = New dsMain
            'DS.Clear()

            'Dim ada1 As New sqlDataAdapter(String.Format("SELECT        D_Bill.BillID, D_Bill.BillDate, D_Bill.BillNo, D_BillDetail.LRNo, D_BillDetail.BillDetailID, D_BillDetail.SrNo, D_BillDetail.LoadDate, D_BillDetail.TruckNo, D_BillDetail.Rate, D_BillDetail.LoadWt, D_BillDetail.UnloadWt, D_BillDetail.Shortage, D_BillDetail.TComm, D_BillDetail.Detention, D_BillDetail.Adv, D_BillDetail.Amount, M_Transport.TransName, D_Bill.NetTotal, M_Company.CompanyName, D_BillDetail.ShortAmt FROM (((D_Bill INNER JOIN D_BillDetail ON D_Bill.BillID = D_BillDetail.BillID) INNER JOIN M_Transport ON D_Bill.TransportID = M_Transport.TransportID) INNER JOIN M_Company ON D_Bill.CompanyID = M_Company.CompanyID) WHERE D_Bill.CompanyID={0} AND D_Bill.BillID={1} order by srno", PubCompanyID, BillID), CnnStrMiniStore)
            'ada1.Fill(DS, "DataTable1")
            'XtraReport.DataAdapter = ada1
            'XtraReport.DataSource = DS
            'XtraReport.DataMember = "DataTable1"

            'Dim GetBillNo As Integer = DS.Tables("DataTable1").Rows(0).Item("BillID")
            'Dim PreAmt As New Integer
            ''Dim CMDPP As New sqlCommand("SELECT SUM(Amount) FROM D_Transaction WHERE (TransactionTypeID=" & 1 & ") AND (TransportID=" & TransportID & ") AND (CompanyID=" & PubCompanyID & ") AND (BillID<" & GetBillNo & ")", CnnStrMiniStore)
            '' CMDPP.Parameters.AddWithValue("@TransactionTypeID", 1)
            '' CMDPP.Parameters.AddWithValue("@TransportID", TransportID)
            '' CMDPP.Parameters.AddWithValue("@CompanyID", PubCompanyID)
            '' CMDPP.Parameters.AddWithValue("@BillID", GetBillNo)

            'Dim CMDPR As New sqlCommand("SELECT SUM(Amount) FROM D_Transaction WHERE (TransactionTypeID=" & 2 & ") AND (TransportID=" & TransportID & ") AND (CompanyID=" & PubCompanyID & ") AND (BillID<" & GetBillNo & ")", CnnStrMiniStore)
            ''CMDPP.Parameters.AddWithValue("@TransactionTypeID", 2)
            ''CMDPP.Parameters.AddWithValue("@TransportID", TransportID)
            ''CMDPP.Parameters.AddWithValue("@CompanyID", PubCompanyID)
            ''CMDPP.Parameters.AddWithValue("@BillID", GetBillNo)

            '' Dim CMDEX As New sqlCommand("SELECT SUM(Amount) FROM D_Transaction WHERE (TransactionTypeID=" & 3 & ") AND (TransportID=" & TransportID & ") AND (CompanyID=" & PubCompanyID & ") AND (BillID<" & GetBillNo & ")", CnnStrMiniStore)
            ''CMDPP.Parameters.AddWithValue("@TransactionTypeID", 3)
            ''CMDPP.Parameters.AddWithValue("@TransportID", TransportID)
            ''CMDPP.Parameters.AddWithValue("@CompanyID", PubCompanyID)
            ''CMDPP.Parameters.AddWithValue("@BillID", GetBillNo)

            'CnnOpen()
            'Dim PR As New Integer
            'PR = Val(CMDPR.ExecuteScalar & "")
            'Dim PP As New Integer
            'PP = Val(CMDPP.ExecuteScalar & "")
            ''Dim EX As New Integer
            ''EX = Val(CMDEX.ExecuteScalar & "")
            'PreAmt = PP - PR

            'Dim Finl As Integer = DS.Tables(0).Rows.Count - 1

            'DS.Tables("DataTable1").Rows(Finl).Item("PreAmt") = PreAmt
            'DS.Tables("DataTable1").Rows(Finl).Item("GrandTotal") = DS.Tables("DataTable1").Rows(Finl).Item("NetTotal") + DS.Tables("DataTable1").Rows(Finl).Item("PreAmt")

            'Dim ReportPrintTool = New ReportPrintTool(XtraReport)
            'ReportPrintTool.PreviewRibbonForm.Text = String.Format("Billing Statement - {0}", PubTransportName)
            'End_Waiting()
            'XtraReport.ShowRibbonPreviewDialog()
        Catch ex As Exception
            ' ErtOccur(ex)
        End Try

        Return True
    End Function
End Module
