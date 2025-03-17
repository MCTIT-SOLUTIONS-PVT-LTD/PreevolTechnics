Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports EASendMail
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Imports RestSharp
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Schema
Imports System.Xml
Imports System.Xml.Linq
Imports System.Web
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json.Linq
Public Class Frm_Invoice
    Dim DS As New DataSet
    Dim DA As New OleDbDataAdapter
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim BSDetails As New BindingSource
    Dim Status As Integer = 0
    Dim NetAmtLabel As New LabelControl
    Dim InvoiceCount As String = ""
    Dim len As Integer = 0
    Dim CurrentInvoiceNo As Integer = 0
    Dim bz As CultureInfo
    Dim ciUSA As CultureInfo
    Dim AuthRespObj As Object, IRNResp As Object, IRNData As Object, GSTResp As Object, GSTData As Object, EwayResp As Object, Ewaydata As Object
    Dim serializer As New JavaScriptSerializer()
    Dim AuthToken As String, ASPID As String, ASPPwd As String, Gstin As String, eInvUserId As String, eInvPwd As String, SandboxURL As String, AppPath As String
    Shared ExMsg As String
    Dim IsDis As Boolean

    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PanelCtrlMain.Select()
        AppPath = ConfigurationManager.AppSettings("AppPath")
        ASPID = ConfigurationManager.AppSettings("ASPID")
        ASPPwd = ConfigurationManager.AppSettings("ASPPwd")
        Gstin = ConfigurationManager.AppSettings("Gstin")
        eInvUserId = ConfigurationManager.AppSettings("TaxproUserName")
        eInvPwd = ConfigurationManager.AppSettings("eInvPwd")
        SandboxURL = ConfigurationManager.AppSettings("TaxproSandboxURL")
        AppPath = ConfigurationManager.AppSettings("AppPath")
        Dim fs As FileStream
        If My.Computer.FileSystem.FileExists(AppPath + "\AuthToken.txt") Then
            Label1.Text = File.ReadAllText(AppPath + "\AuthToken.txt")
        Else
            fs = File.Create(AppPath + "\AuthToken.txt")
            fs.Close()
            File.WriteAllText(AppPath + "\AuthToken.txt", "zrkQcAHjsPbzWS3KJAEchOBJX")
            Label1.Text = File.ReadAllText(AppPath + "\AuthToken.txt")
        End If

        If My.Computer.FileSystem.FileExists(AppPath + "\GenIRN.txt") Then
            TxtBoxResp.Text = File.ReadAllText(AppPath + "\GenIRN.txt")
        Else
            fs = File.Create(AppPath + "\GenIRN.txt")
            fs.Close()
            TxtBoxResp.Text = File.ReadAllText(AppPath + "\GenIRN.txt")
        End If
        If My.Computer.FileSystem.FileExists(AppPath + "\IRNData.txt") Then
        Else
            fs = File.Create(AppPath + "\IRNData.txt")
            fs.Close()
        End If
        SetDataTable()
        SetRelation()
        SetQuery()
        SetBinding()
        SetGrid()
        InitLookup()
        CreatedByTextEdit.Text = CurrentUserName.ToString()
        ModifiedByTextEdit.Text = CurrentUserName.ToString()

        AddNew()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        If PubInvoiceType = "Sales Invoice" Or PubInvoiceType = "Sales Invoice IGST" Then
            PubSupTyp = "B2B"
            ARNNoTextEdit.Enabled = False
            ARNDateDateEdit.Enabled = False
        ElseIf PubInvoiceType = "SEZ Sales Invoice IGST" Then
            If PubWithLUT Then
                PubSupTyp = "SEZWOP"
            Else
                PubSupTyp = "SEZWP"
            End If
            ARNNoTextEdit.Enabled = True
            ARNDateDateEdit.Enabled = True
        ElseIf PubInvoiceType = "Export Sales Invoice IGST" Then
            If PubWithLUT Then
                PubSupTyp = "EXPWOP"
            Else
                PubSupTyp = "EXPWP"
            End If
            ARNNoTextEdit.Enabled = True
            ARNDateDateEdit.Enabled = True
        Else
            ARNNoTextEdit.Enabled = False
            ARNDateDateEdit.Enabled = False
        End If
        If PubInvoiceType = "Export Sales Invoice IGST" Then
            bz = New CultureInfo("en-US")
            ciUSA = New CultureInfo("en-US")
        Else
            bz = New CultureInfo("hi-In")
            ciUSA = New CultureInfo("hi-In")
        End If
        If AddressCheckEdit.Checked = True Then
            ConsigneeGSTINTextEdit.Enabled = True
        Else
            ConsigneeGSTINTextEdit.Enabled = False
        End If
        TransportModeComboBoxEdit.SelectedIndex = 0
        VehTypeRadioGroup.SelectedIndex = 1
    End Sub
    'Get All Data of Company 
    Function GetCompanyData() As DataTable
        Dim DTCompany As New DataTable()
        Try
            Using DACompany As New OleDbDataAdapter("Select CompanyID,FinancialYear,SalesInvoicePrefix,Name,Address,Phone1,Phone2,State,StateCode,EmailID1,Website,GSTIN,PANNo,ISOText,State,Loc,Pin From Company Where Name ='" + PubCompanyName + "'", ConStr)
                DACompany.Fill(DTCompany)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching company data: " & ex.Message)
        End Try
        Return DTCompany
    End Function
    Private Sub PanelCtrlMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles PanelCtrlMain.MouseWheel
        Dim myView As Point = Me.PanelCtrlMain.AutoScrollPosition
        myView.X = (myView.X + 50)
        myView.Y = (myView.Y + 50)
        Me.PanelCtrlMain.AutoScrollPosition = myView
    End Sub
    Sub SetDataTable()
        'Invoice
        DS.Tables.Add("Invoice")
        With DS.Tables("Invoice").Columns
            .Add("InvoiceID", GetType(Integer))
            .Add("InvoiceNo", GetType(String))
            .Add("InvoiceDate", GetType(Date))
            .Item("InvoiceDate").DefaultValue = Date.Today
            .Add("ChallanNo", GetType(String))
            .Add("ChallanDate", GetType(Date))
            .Add("PartyDCNo", GetType(String))
            .Add("PartyDCDate", GetType(Date))
            .Add("PO", GetType(String))
            .Add("PODate", GetType(Date))
            .Add("ARNNo", GetType(String))
            .Add("ARNDate", GetType(Date))
            .Add("TransportationMode", GetType(String))
            .Add("SupplyTo", GetType(String))
            .Add("SupplyStateCode", GetType(Integer))
            .Add("ModelNo", GetType(String))
            .Add("AgainstForm", GetType(String))
            .Add("ReceiverName", GetType(String))
            .Add("ReceiverAddress", GetType(String))
            .Add("ReceiverGSTIN", GetType(String))
            .Add("ReceiverState", GetType(String))
            .Add("ReceiverStateCode", GetType(String))
            .Add("ReceiverPanNo", GetType(String))
            .Add("ConsigneeName", GetType(String))
            .Add("ConsigneeAddress", GetType(String))
            .Add("ConsigneeGSTIN", GetType(String))
            .Add("ConsigneeState", GetType(String))
            .Add("ConsigneeStateCode", GetType(String))
            .Add("ConsigneePanNo", GetType(String))
            .Add("IsSameAddress", GetType(Boolean))
            .Item("IsSameAddress").DefaultValue = False
            .Add("TotalAmtBeforeTax", GetType(Double))
            .Add("PackingCharge", GetType(Double))
            .Add("PCGSTRate", GetType(Double))
            .Add("PCGSTAmt", GetType(Double))
            .Add("PSGSTRate", GetType(Double))
            .Add("PSGSTAmt", GetType(Double))
            .Add("PIGSTRate", GetType(Double))
            .Add("PIGSTAmt", GetType(Double))
            .Add("CGST", GetType(Double))
            .Add("SGST", GetType(Double))
            .Add("IGST", GetType(Double))
            .Add("TotalGSTTax", GetType(Double))
            .Add("TotalAmtAfterTax", GetType(Double))
            .Add("GSTReverseCharge", GetType(Double))
            .Add("TotalInWords", GetType(String))
            .Add("TaxInWords", GetType(String))
            .Add("Remarks", GetType(String))
            .Add("GrandTotalAmount", GetType(Double))
            .Add("RoundOff", GetType(Double))
            .Add("CreatedBy", GetType(String))
            .Add("ModifiedBy", GetType(String))
            .Add("Company", GetType(String))
            .Add("InvoiceType", GetType(String))
            .Add("QRCode", GetType(String))
            .Add("IRNNo", GetType(String))
            .Add("AckNo", GetType(String))
            .Add("AckDate", GetType(Date))
            .Add("TransId", GetType(String))
            .Add("TransName", GetType(String))
            .Add("TransMode", GetType(String))
            .Add("Distance", GetType(String))
            .Add("VehNo", GetType(String))
            .Add("VehType", GetType(String))
            .Add("EwbNo", GetType(String))
            .Add("EwbDt", GetType(Date))
            .Add("EwbValidTill", GetType(Date))
            .Add("CEWBNo", GetType(String))
            .Add("MultiVehInfo", GetType(String))

        End With

        With DS.Tables("Invoice").Columns("InvoiceID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With

        'Invoice Detail
        DS.Tables.Add("InvoiceDetail")
        With DS.Tables("InvoiceDetail").Columns
            .Add("InvoiceDetailID", GetType(Integer))
            .Add("InvoiceID", GetType(Integer))
            .Add("ProductName", GetType(String))
            .Add("Description", GetType(String))
            .Add("HSNACS", GetType(String))
            .Add("UOM", GetType(String))
            .Add("Qty", GetType(Double))
            .Add("Rate", GetType(Double))
            .Add("IsService", GetType(String))
            .Add("Amount", GetType(Double))
            .Add("Discount", GetType(Double))
            .Add("DiscountVal", GetType(Double))
            .Add("TaxableValue", GetType(Double))
            .Add("CGSTRate", GetType(Double))
            .Add("CGSTAmt", GetType(Double))
            .Add("SGSTRate", GetType(Double))
            .Add("SGSTAmt", GetType(Double))
            .Add("IGSTRate", GetType(Double))
            .Add("IGSTAmt", GetType(Double))
            .Add("TotalAmount", GetType(Double))
        End With

        With DS.Tables("InvoiceDetail").Columns("InvoiceDetailID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetRelation()
        DS.Relations.Add(New DataRelation("RelationInvoice", DS.Tables("Invoice").Columns("InvoiceID"), DS.Tables("InvoiceDetail").Columns("InvoiceID"), False))
        Dim FK_InvoiceDetail As New Global.System.Data.ForeignKeyConstraint("FK_Invoice", DS.Tables("Invoice").Columns("InvoiceID"), DS.Tables("InvoiceDetail").Columns("InvoiceID"))
        DS.Tables("InvoiceDetail").Constraints.Add(FK_InvoiceDetail)
        With FK_InvoiceDetail
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = DS
        BS.DataMember = "Invoice"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "RelationInvoice"

        InvoiceDetailGridControl.DataSource = BSDetails
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select InvoiceID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,PartyDCNo,PartyDCDate,PO,PODate,ARNNo,ARNDate,TransportationMode,SupplyTo,SupplyStateCode,AgainstForm,ModelNo,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType,QRCode,IRNNo,AckNo,AckDate,TransId, TransName,TransMode,Distance,VehNo,VehType,EwbNo,EwbDt,EwbValidTill,CEWBNo,MultiVehInfo From Invoice Where InvoiceID=@InvoiceID", ConStr)
        DA.SelectCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")

        DA.InsertCommand = New OleDbCommand("Insert Into Invoice (InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,PartyDCNo,PartyDCDate,PO,PODate,ARNNo,ARNDate,TransportationMode,SupplyTo,SupplyStateCode,AgainstForm,ModelNo,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType,QRCode,IRNNo,AckNo,AckDate,TransId, TransName,TransMode,Distance,VehNo,VehType,EwbNo,EwbDt,EwbValidTill,CEWBNo,MultiVehInfo) Values (@InvoiceNo,@InvoiceDate,@ChallanNo,@ChallanDate,@PartyDCNo,@PartyDCDate,@PO,@PODate,@ARNNo,@ARNDate,@TransportationMode,@SupplyTo,@SupplyStateCode,@AgainstForm,@ModelNo,@ReceiverName,@ReceiverAddress,@ReceiverGSTIN,@ReceiverState,@ReceiverStateCode,@ReceiverPanNo,@ConsigneeName,@ConsigneeAddress,@ConsigneeGSTIN,@ConsigneeState,@ConsigneeStateCode,@ConsigneePanNo,@IsSameAddress,@TotalAmtBeforeTax,@PackingCharge,@PCGSTRate,@PCGSTAmt,@PSGSTRate,@PSGSTAmt,@PIGSTRate,@PIGSTAmt,@CGST,@SGST,@IGST,@TotalGSTTax,@TotalAmtAfterTax,@GSTReverseCharge,@TotalInWords,@TaxInWords,@Remarks,@GrandTotalAmount,@RoundOff,@CreatedBy,@ModifiedBy,@Company,@InvoiceType,@QRCode,@IRNNo,@AckNo,@AckDate,@TransId, @TransName,@TransMode,@Distance,@VehNo,@VehType,@EwbNo,@EwbDt,@EwbValidTill,@CEWBNo,@MultiVehInfo)", ConStr)
        DA.InsertCommand.Parameters.Add("@InvoiceNo", OleDbType.VarChar, 50, "InvoiceNo")
        DA.InsertCommand.Parameters.Add("@InvoiceDate", OleDbType.Date, 3, "InvoiceDate")
        DA.InsertCommand.Parameters.Add("@ChallanNo", OleDbType.VarChar, 50, "ChallanNo")
        DA.InsertCommand.Parameters.Add("@ChallanDate", OleDbType.Date, 3, "ChallanDate")
        DA.InsertCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.InsertCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.InsertCommand.Parameters.Add("@PO", OleDbType.VarChar, 50, "PO")
        DA.InsertCommand.Parameters.Add("@PODate", OleDbType.Date, 3, "PODate")
        DA.InsertCommand.Parameters.Add("@ARNNo", OleDbType.VarChar, 50, "ARNNo")
        DA.InsertCommand.Parameters.Add("@ARNDate", OleDbType.Date, 3, "ARNDate")
        DA.InsertCommand.Parameters.Add("@TransportationMode", OleDbType.VarChar, 50, "TransportationMode")
        DA.InsertCommand.Parameters.Add("@SupplyTo", OleDbType.VarChar, 50, "SupplyTo")
        DA.InsertCommand.Parameters.Add("@SupplyStateCode", OleDbType.Integer, 4, "SupplyStateCode")
        DA.InsertCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.InsertCommand.Parameters.Add("@ModelNo", OleDbType.VarChar, 50, "ModelNo")
        DA.InsertCommand.Parameters.Add("@ReceiverName", OleDbType.VarChar, 100, "ReceiverName")
        DA.InsertCommand.Parameters.Add("@ReceiverAddress", OleDbType.VarChar, 200, "ReceiverAddress")
        DA.InsertCommand.Parameters.Add("@ReceiverGSTIN", OleDbType.VarChar, 50, "ReceiverGSTIN")
        DA.InsertCommand.Parameters.Add("@ReceiverState", OleDbType.VarChar, 50, "ReceiverState")
        DA.InsertCommand.Parameters.Add("@ReceiverStateCode", OleDbType.VarChar, 50, "ReceiverStateCode")
        DA.InsertCommand.Parameters.Add("@ReceiverPanNo", OleDbType.VarChar, 50, "ReceiverPanNo")
        DA.InsertCommand.Parameters.Add("@ConsigneeName", OleDbType.VarChar, 100, "ConsigneeName")
        DA.InsertCommand.Parameters.Add("@ConsigneeAddress", OleDbType.VarChar, 200, "ConsigneeAddress")
        DA.InsertCommand.Parameters.Add("@ConsigneeGSTIN", OleDbType.VarChar, 50, "ConsigneeGSTIN")
        DA.InsertCommand.Parameters.Add("@ConsigneeState", OleDbType.VarChar, 50, "ConsigneeState")
        DA.InsertCommand.Parameters.Add("@ConsigneeStateCode", OleDbType.VarChar, 50, "ConsigneeStateCode")
        DA.InsertCommand.Parameters.Add("@ConsigneePanNo", OleDbType.VarChar, 50, "ConsigneePanNo")
        DA.InsertCommand.Parameters.Add("@IsSameAddress", OleDbType.Boolean, 1, "IsSameAddress")
        DA.InsertCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.InsertCommand.Parameters.Add("@PackingCharge", OleDbType.Double, 8, "PackingCharge")
        DA.InsertCommand.Parameters.Add("@PCGSTRate", OleDbType.Double, 8, "PCGSTRate")
        DA.InsertCommand.Parameters.Add("@PCGSTAmt", OleDbType.Double, 8, "PCGSTAmt")
        DA.InsertCommand.Parameters.Add("@PSGSTRate", OleDbType.Double, 8, "PSGSTRate")
        DA.InsertCommand.Parameters.Add("@PSGSTAmt", OleDbType.Double, 8, "PSGSTAmt")
        DA.InsertCommand.Parameters.Add("@PIGSTRate", OleDbType.Double, 8, "PIGSTRate")
        DA.InsertCommand.Parameters.Add("@PIGSTAmt", OleDbType.Double, 8, "PIGSTAmt")
        DA.InsertCommand.Parameters.Add("@CGST", OleDbType.Double, 8, "CGST")
        DA.InsertCommand.Parameters.Add("@SGST", OleDbType.Double, 8, "SGST")
        DA.InsertCommand.Parameters.Add("@IGST", OleDbType.Double, 8, "IGST")
        DA.InsertCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.InsertCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.InsertCommand.Parameters.Add("@GSTReverseCharge", OleDbType.Double, 8, "GSTReverseCharge")
        DA.InsertCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.InsertCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.InsertCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.InsertCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.InsertCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.InsertCommand.Parameters.Add("@CreatedBy", OleDbType.VarChar, 50, "CreatedBy")
        DA.InsertCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")
        DA.InsertCommand.Parameters.Add("@InvoiceType", OleDbType.VarChar, 50, "InvoiceType")
        DA.InsertCommand.Parameters.Add("@QRCode", OleDbType.VarChar, 30000, "QRCode")
        DA.InsertCommand.Parameters.Add("@IRNNo", OleDbType.VarChar, 200, "IRNNo")
        DA.InsertCommand.Parameters.Add("@AckNo", OleDbType.VarChar, 50, "AckNo")
        DA.InsertCommand.Parameters.Add("@AckDate", OleDbType.Date, 3, "AckDate")
        DA.InsertCommand.Parameters.Add("@TransId", OleDbType.VarChar, 15, "TransId")
        DA.InsertCommand.Parameters.Add("@TransName", OleDbType.VarChar, 100, "TransName")
        DA.InsertCommand.Parameters.Add("@TransMode", OleDbType.VarChar, 10, "TransMode")
        DA.InsertCommand.Parameters.Add("@Distance", OleDbType.VarChar, 6, "Distance")
        DA.InsertCommand.Parameters.Add("@VehNo", OleDbType.VarChar, 20, "VehNo")
        DA.InsertCommand.Parameters.Add("@VehType", OleDbType.VarChar, 1, "VehType")
        DA.InsertCommand.Parameters.Add("@EwbNo", OleDbType.VarChar, 20, "EwbNo")
        DA.InsertCommand.Parameters.Add("@EwbDt", OleDbType.Date, 3, "EwbDt")
        DA.InsertCommand.Parameters.Add("@EwbValidTill", OleDbType.Date, 3, "EwbValidTill")
        DA.InsertCommand.Parameters.Add("@CEWBNo", OleDbType.VarChar, 20, "CEWBNo")
        DA.InsertCommand.Parameters.Add("@MultiVehInfo", OleDbType.VarChar, 20, "MultiVehInfo")

        DA.UpdateCommand = New OleDbCommand("Update Invoice Set InvoiceNo=@InvoiceNo,InvoiceDate=@InvoiceDate,ChallanNo=@ChallanNo,ChallanDate=@ChallanDate,PartyDCNo=@PartyDCNo,PartyDCDate=@PartyDCDate,PO=@PO,PODate=@PODate,ARNNo=@ARNNo,ARNDate=@ARNDate,TransportationMode=@TransportationMode,SupplyTo=@SupplyTo,SupplyStateCode=@SupplyStateCode,AgainstForm=@AgainstForm,ModelNo=@ModelNo,ReceiverName=@ReceiverName,ReceiverAddress=@ReceiverAddress,ReceiverGSTIN=@ReceiverGSTIN,ReceiverState=@ReceiverState,ReceiverStateCode=@ReceiverStateCode,ReceiverPanNo=@ReceiverPanNo,ConsigneeName=@ConsigneeName,ConsigneeAddress=@ConsigneeAddress,ConsigneeGSTIN=@ConsigneeGSTIN,ConsigneeState=@ConsigneeState,ConsigneeStateCode=@ConsigneeStateCode,ConsigneePanNo=@ConsigneePanNo,IsSameAddress=@IsSameAddress,TotalAmtBeforeTax=@TotalAmtBeforeTax,PackingCharge=@PackingCharge,PCGSTRate=@PCGSTRate,PCGSTAmt=@PCGSTAmt,PSGSTRate=@PSGSTRate,PSGSTAmt=@PSGSTAmt,PIGSTRate=@PIGSTRate,PIGSTAmt=@PIGSTAmt,CGST=@CGST,SGST=@SGST,IGST=@IGST,TotalGSTTax=@TotalGSTTax,TotalAmtAfterTax=@TotalAmtAfterTax,GSTReverseCharge=@GSTReverseCharge,TotalInWords=@TotalInWords,TaxInWords=@TaxInWords,Remarks=@Remarks,GrandTotalAmount=@GrandTotalAmount,RoundOff=@RoundOff,ModifiedBy=@ModifiedBy,QRCode=@QRCode,IRNNo=@IRNNo,AckNo=@AckNo,AckDate=@AckDate,TransId=@TransId,TransName=@TransName,TransMode=@TransMode,Distance=@Distance,VehNo=@VehNo,VehType=@VehType,EwbNo=@EwbNo,EwbDt=@EwbDt,EwbValidTill=@EwbValidTill,CEWBNo=@CEWBNo,MultiVehInfo=@MultiVehInfo Where InvoiceID=@InvoiceID", ConStr)
        DA.UpdateCommand.Parameters.Add("@InvoiceNo", OleDbType.VarChar, 50, "InvoiceNo")
        DA.UpdateCommand.Parameters.Add("@InvoiceDate", OleDbType.Date, 3, "InvoiceDate")
        DA.UpdateCommand.Parameters.Add("@ChallanNo", OleDbType.VarChar, 50, "ChallanNo")
        DA.UpdateCommand.Parameters.Add("@ChallanDate", OleDbType.Date, 3, "ChallanDate")
        DA.UpdateCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.UpdateCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.UpdateCommand.Parameters.Add("@PO", OleDbType.VarChar, 50, "PO")
        DA.UpdateCommand.Parameters.Add("@PODate", OleDbType.Date, 3, "PODate")
        DA.UpdateCommand.Parameters.Add("@ARNNo", OleDbType.VarChar, 50, "ARNNo")
        DA.UpdateCommand.Parameters.Add("@ARNDate", OleDbType.Date, 3, "ARNDate")
        DA.UpdateCommand.Parameters.Add("@TransportationMode", OleDbType.VarChar, 50, "TransportationMode")
        DA.UpdateCommand.Parameters.Add("@SupplyTo", OleDbType.VarChar, 50, "SupplyTo")
        DA.UpdateCommand.Parameters.Add("@SupplyStateCode", OleDbType.Integer, 4, "SupplyStateCode")
        DA.UpdateCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.UpdateCommand.Parameters.Add("@ModelNo", OleDbType.VarChar, 50, "ModelNo")
        DA.UpdateCommand.Parameters.Add("@ReceiverName", OleDbType.VarChar, 100, "ReceiverName")
        DA.UpdateCommand.Parameters.Add("@ReceiverAddress", OleDbType.VarChar, 200, "ReceiverAddress")
        DA.UpdateCommand.Parameters.Add("@ReceiverGSTIN", OleDbType.VarChar, 50, "ReceiverGSTIN")
        DA.UpdateCommand.Parameters.Add("@ReceiverState", OleDbType.VarChar, 50, "ReceiverState")
        DA.UpdateCommand.Parameters.Add("@ReceiverStateCode", OleDbType.VarChar, 50, "ReceiverStateCode")
        DA.UpdateCommand.Parameters.Add("@ReceiverPanNo", OleDbType.VarChar, 50, "ReceiverPanNo")
        DA.UpdateCommand.Parameters.Add("@ConsigneeName", OleDbType.VarChar, 100, "ConsigneeName")
        DA.UpdateCommand.Parameters.Add("@ConsigneeAddress", OleDbType.VarChar, 200, "ConsigneeAddress")
        DA.UpdateCommand.Parameters.Add("@ConsigneeGSTIN", OleDbType.VarChar, 50, "ConsigneeGSTIN")
        DA.UpdateCommand.Parameters.Add("@ConsigneeState", OleDbType.VarChar, 50, "ConsigneeState")
        DA.UpdateCommand.Parameters.Add("@ConsigneeStateCode", OleDbType.VarChar, 50, "ConsigneeStateCode")
        DA.UpdateCommand.Parameters.Add("@ConsigneePanNo", OleDbType.VarChar, 50, "ConsigneePanNo")
        DA.UpdateCommand.Parameters.Add("@IsSameAddress", OleDbType.Boolean, 1, "IsSameAddress")
        DA.UpdateCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.UpdateCommand.Parameters.Add("@PackingCharge", OleDbType.Double, 8, "PackingCharge")
        DA.UpdateCommand.Parameters.Add("@PCGSTRate", OleDbType.Double, 8, "PCGSTRate")
        DA.UpdateCommand.Parameters.Add("@PCGSTAmt", OleDbType.Double, 8, "PCGSTAmt")
        DA.UpdateCommand.Parameters.Add("@PSGSTRate", OleDbType.Double, 8, "PSGSTRate")
        DA.UpdateCommand.Parameters.Add("@PSGSTAmt", OleDbType.Double, 8, "PSGSTAmt")
        DA.UpdateCommand.Parameters.Add("@PIGSTRate", OleDbType.Double, 8, "PIGSTRate")
        DA.UpdateCommand.Parameters.Add("@PIGSTAmt", OleDbType.Double, 8, "PIGSTAmt")
        DA.UpdateCommand.Parameters.Add("@CGST", OleDbType.Double, 8, "CGST")
        DA.UpdateCommand.Parameters.Add("@SGST", OleDbType.Double, 8, "SGST")
        DA.UpdateCommand.Parameters.Add("@IGST", OleDbType.Double, 8, "IGST")
        DA.UpdateCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.UpdateCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.UpdateCommand.Parameters.Add("@GSTReverseCharge", OleDbType.Double, 8, "GSTReverseCharge")
        DA.UpdateCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.UpdateCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.UpdateCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.UpdateCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.UpdateCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.UpdateCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.UpdateCommand.Parameters.Add("@QRCode", OleDbType.VarChar, 30000, "QRCode")
        DA.UpdateCommand.Parameters.Add("@IRNNo", OleDbType.VarChar, 200, "IRNNo")
        DA.UpdateCommand.Parameters.Add("@AckNo", OleDbType.VarChar, 50, "AckNo")
        DA.UpdateCommand.Parameters.Add("@AckDate", OleDbType.Date, 3, "AckDate")
        DA.UpdateCommand.Parameters.Add("@TransId", OleDbType.VarChar, 15, "TransId")
        DA.UpdateCommand.Parameters.Add("@TransName", OleDbType.VarChar, 100, "TransName")
        DA.UpdateCommand.Parameters.Add("@TransMode", OleDbType.VarChar, 10, "TransMode")
        DA.UpdateCommand.Parameters.Add("@Distance", OleDbType.VarChar, 6, "Distance")
        DA.UpdateCommand.Parameters.Add("@VehNo", OleDbType.VarChar, 20, "VehNo")
        DA.UpdateCommand.Parameters.Add("@VehType", OleDbType.VarChar, 1, "VehType")
        DA.UpdateCommand.Parameters.Add("@EwbNo", OleDbType.VarChar, 20, "EwbNo")
        DA.UpdateCommand.Parameters.Add("@EwbDt", OleDbType.Date, 3, "EwbDt")
        DA.UpdateCommand.Parameters.Add("@EwbValidTill", OleDbType.Date, 3, "EwbValidTill")
        DA.UpdateCommand.Parameters.Add("@CEWBNo", OleDbType.VarChar, 20, "CEWBNo")
        DA.UpdateCommand.Parameters.Add("@MultiVehInfo", OleDbType.VarChar, 20, "MultiVehInfo")
        DA.UpdateCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")

        DA.DeleteCommand = New OleDbCommand("Delete From Invoice Where InvoiceID=@InvoiceID", ConStr)
        DA.DeleteCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")

        ' Invoice Detail .............................................................................................................................................................................
        DADetails.SelectCommand = New OleDbCommand("Select InvoiceDetailID,InvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount From InvoiceDetail Where InvoiceID=@InvoiceID", ConStr)
        DADetails.SelectCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")

        DADetails.InsertCommand = New OleDbCommand("Insert Into InvoiceDetail (InvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@InvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
        DADetails.InsertCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")
        DADetails.InsertCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.InsertCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.InsertCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.InsertCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.InsertCommand.Parameters.Add("@IsService", OleDbType.VarChar, 1, "IsService")
        DADetails.InsertCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.InsertCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.InsertCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.InsertCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.InsertCommand.Parameters.Add("@CGSTRate", OleDbType.Double, 8, "CGSTRate")
        DADetails.InsertCommand.Parameters.Add("@CGSTAmt", OleDbType.Double, 8, "CGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@SGSTRate", OleDbType.Double, 8, "SGSTRate")
        DADetails.InsertCommand.Parameters.Add("@SGSTAmt", OleDbType.Double, 8, "SGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@IGSTRate", OleDbType.Double, 8, "IGSTRate")
        DADetails.InsertCommand.Parameters.Add("@IGSTAmt", OleDbType.Double, 8, "IGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")

        DADetails.UpdateCommand = New OleDbCommand("Update InvoiceDetail Set InvoiceID=@InvoiceID,ProductName=@ProductName,Description=@Description,HSNACS=@HSNACS,UOM=@UOM,Qty=@Qty,Rate=@Rate,IsService=@IsService,Amount=@Amount,Discount=@Discount,DiscountVal=@DiscountVal,TaxableValue=@TaxableValue,CGSTRate=@CGSTRate,CGSTAmt=@CGSTAmt,SGSTRate=@SGSTRate,SGSTAmt=@SGSTAmt,IGSTRate=@IGSTRate,IGSTAmt=@IGSTAmt,TotalAmount=@TotalAmount Where InvoiceDetailID=@InvoiceDetailID", ConStr)
        DADetails.UpdateCommand.Parameters.Add("@InvoiceID", OleDbType.Integer, 4, "InvoiceID")
        DADetails.UpdateCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.UpdateCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.UpdateCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.UpdateCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.UpdateCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.UpdateCommand.Parameters.Add("@IsService", OleDbType.VarChar, 1, "IsService")
        DADetails.UpdateCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.UpdateCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.UpdateCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.UpdateCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.UpdateCommand.Parameters.Add("@CGSTRate", OleDbType.Double, 8, "CGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@CGSTAmt", OleDbType.Double, 8, "CGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@SGSTRate", OleDbType.Double, 8, "SGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@SGSTAmt", OleDbType.Double, 8, "SGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@IGSTRate", OleDbType.Double, 8, "IGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@IGSTAmt", OleDbType.Double, 8, "IGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")
        DADetails.UpdateCommand.Parameters.Add("@InvoiceDetailID", OleDbType.Integer, 4, "InvoiceDetailID")

        DADetails.DeleteCommand = New OleDbCommand("Delete From InvoiceDetail Where InvoiceDetailID=@InvoiceDetailID", ConStr)
        DADetails.DeleteCommand.Parameters.Add("@InvoiceDetailID", OleDbType.Integer, 4, "InvoiceDetailID")
    End Sub

    Sub SetBinding()
        InvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "InvoiceNo"))
        InvoiceDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "InvoiceDate"))
        ChallanNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ChallanNo"))
        ChallanDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "ChallanDate"))
        PartyDCNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCNo"))
        PartyDCDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCDate"))
        POTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PO"))
        PODateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "PODate"))
        ARNNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ARNNo"))
        ARNDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "ARNDate"))
        TransportationModeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TransportationMode"))
        SupplyToTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SupplyTo"))
        SSCTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SupplyStateCode"))
        AgainstFormTextEdit.DataBindings.Add(New Binding("EditValue", BS, "AgainstForm"))
        ModelNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ModelNo"))
        ReceiverNameComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverName"))
        ReceiverAddressTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverAddress"))
        ReceiverGSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverGSTIN"))
        ReceiverStateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverState"))
        ReceiverStateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverStateCode"))
        ReceiverPANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReceiverPanNo"))
        ConsigneeNameComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneeName"))
        ConsigneeAddressTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneeAddress"))
        ConsigneeGSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneeGSTIN"))
        ConsigneeStateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneeState"))
        ConsigneeStateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneeStateCode"))
        ConsigneePANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsigneePanNo"))
        AddressCheckEdit.DataBindings.Add(New Binding("EditValue", BS, "IsSameAddress"))
        TotalAmtBeforeTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtBeforeTax"))
        PackingTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PackingCharge"))
        PCGSTRateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PCGSTRate"))
        PCGSTAmt.DataBindings.Add(New Binding("EditValue", BS, "PCGSTAmt"))
        PSGSTRateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PSGSTRate"))
        PSGSTAmt.DataBindings.Add(New Binding("EditValue", BS, "PSGSTAmt"))
        PIGSTRateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PIGSTRate"))
        PIGSTAmt.DataBindings.Add(New Binding("EditValue", BS, "PIGSTAmt"))
        CGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "CGST"))
        SGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SGST"))
        IGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "IGST"))
        TotalGSTTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalGSTTax"))
        TotalAmtAfterTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtAfterTax"))
        GSTReverseChargeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GSTReverseCharge"))
        TotalInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalInWords"))
        TaxInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TaxInWords"))
        RemarksTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Remarks"))
        NetAmtLabel.DataBindings.Add(New Binding("Text", BS, "GrandTotalAmount"))
        CreatedByTextEdit.DataBindings.Add(New Binding("Text", BS, "CreatedBy"))
        ModifiedByTextEdit.DataBindings.Add(New Binding("Text", BS, "ModifiedBy"))
        QRCodeMemoEdit.DataBindings.Add(New Binding("Text", BS, "QRCode"))
        txtIRN.DataBindings.Add(New Binding("Text", BS, "IRNNo"))
        AckNoTextEdit.DataBindings.Add(New Binding("Text", BS, "AckNo"))
        AckDateDateEdit.DataBindings.Add(New Binding("Text", BS, "AckDate"))
        TransIDTextEdit.DataBindings.Add(New Binding("Text", BS, "TransId"))
        TransNMTextEdit.DataBindings.Add(New Binding("Text", BS, "TransName"))
        TransportModeComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "TransMode"))
        DistanceTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Distance"))
        VehNoTextEdit.DataBindings.Add(New Binding("Text", BS, "VehNo"))
        VehTypeRadioGroup.DataBindings.Add(New Binding("Editvalue", BS, "VehType"))
        EwbNoTextEdit.DataBindings.Add(New Binding("Text", BS, "EwbNo"))
        EwbDateDateEdit.DataBindings.Add(New Binding("Text", BS, "EwbDt"))
        EwbValidTillDateEdit.DataBindings.Add(New Binding("Text", BS, "EwbValidTill"))
        CEWBNoTextEdit.DataBindings.Add(New Binding("Text", BS, "CEWBNo"))
        MultiVehInfoTextEdit.DataBindings.Add(New Binding("Text", BS, "MultiVehInfo"))
    End Sub

    Sub InitLookup()
        If PubIGST = False Then
            SetGridCommboBox("Select DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ReceiverNameComboBoxEdit)
            SetGridCommboBox("Select DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ConsigneeNameComboBoxEdit)
        ElseIf PubIGST = True Then
            If PubInvoiceType = "SEZ Sales Invoice IGST" Then
                SetGridCommboBox("Select DISTINCT PartyName FROM Party", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("Select DISTINCT PartyName FROM Party", "Party", ConsigneeNameComboBoxEdit)
            ElseIf PubInvoiceType = "Export Sales Invoice IGST" Then
                SetGridCommboBox("Select DISTINCT PartyName FROM Party Where Country Not Like 'India'", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where Country Not Like 'India'", "Party", ConsigneeNameComboBoxEdit)
            Else
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ConsigneeNameComboBoxEdit)
            End If
        End If
        GridComboBoxFunc("Select DISTINCT ProductName FROM Product Where CategoryID <> 15 ", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
        GridMemoEditFunc(InvoiceDetailGridControl, InvoiceDetailGridView, "Description")
    End Sub
    Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("InvoiceDetailID").Visible = False
            .Columns("InvoiceID").Visible = False
            .Columns("Amount").OptionsColumn.AllowFocus = False
            .Columns("Amount").OptionsColumn.ReadOnly = True
            .Columns("TaxableValue").OptionsColumn.AllowFocus = False
            .Columns("TaxableValue").OptionsColumn.ReadOnly = True
            .Columns("CGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("CGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("SGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("SGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("IGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("IGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("TotalAmount").OptionsColumn.AllowFocus = False
            .Columns("TotalAmount").OptionsColumn.ReadOnly = True
            .Columns("ProductName").Width = 200
            .Columns("ProductName").Caption = "Product"
            .Columns("Description").Caption = "Description"
            .Columns("Description").Width = 200
            .Columns("HSNACS").Caption = "SAC"
            .Columns("Discount").Visible = True
            .Columns("DiscountVal").Visible = True
            .Columns("IsService").Visible = False
            .Columns("CGSTRate").Caption = "CGST(%)"
            .Columns("SGSTRate").Caption = "SGST(%)"
            .Columns("IGSTRate").Caption = "IGST(%)"

            .OptionsView.ShowFooter = True
            .Columns("TaxableValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("CGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("SGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("IGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("TotalAmount").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum

            .Columns("Qty").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("DiscountVal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With

        InvoiceDetailGridView.BestFitColumns()
        InvoiceDetailGridView.FocusedColumn = InvoiceDetailGridView.Columns(2)
        BSDetails.ResetBindings(True)

        If PubIGST = False Then
            InvoiceDetailGridView.Columns("IGSTRate").Visible = False
            InvoiceDetailGridView.Columns("IGSTAmt").Visible = False
        ElseIf PubIGST = True Then
            InvoiceDetailGridView.Columns("CGSTRate").Visible = False
            InvoiceDetailGridView.Columns("CGSTAmt").Visible = False
            InvoiceDetailGridView.Columns("SGSTRate").Visible = False
            InvoiceDetailGridView.Columns("SGSTAmt").Visible = False
        End If
    End Sub

    Function Validation() As Boolean
        If InvoiceNoTextEdit.EditValue Is DBNull.Value Then
            InvoiceNoTextEdit.Focus()
            Return False
        ElseIf InvoiceDateDateEdit.EditValue Is DBNull.Value Then
            InvoiceDateDateEdit.Focus()
            Return False
        ElseIf ChallanNoTextEdit.EditValue Is DBNull.Value Then
            ChallanNoTextEdit.Focus()
            Return False
        ElseIf ChallanDateDateEdit.EditValue Is DBNull.Value Then
            ChallanDateDateEdit.Focus()
            Return False
        ElseIf POTextEdit.EditValue Is DBNull.Value Then
            POTextEdit.Focus()
            Return False
        ElseIf PODateDateEdit.EditValue Is DBNull.Value Then
            PODateDateEdit.Focus()
            Return False
        ElseIf SupplyToTextEdit.EditValue Is DBNull.Value Then
            SupplyToTextEdit.Focus()
            Return False
        ElseIf SSCTextEdit.EditValue Is DBNull.Value Then
            SSCTextEdit.Focus()
            Return False
        ElseIf ReceiverNameComboBoxEdit.EditValue Is DBNull.Value Then
            ReceiverNameComboBoxEdit.Focus()
            Return False
        ElseIf ConsigneeNameComboBoxEdit.EditValue Is DBNull.Value Then
            ConsigneeNameComboBoxEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Sub AddNew()

        BS.AddNew()
        BS.Current!CreatedBy = CurrentUserName
        BS.Current!ModifiedBy = CurrentUserName
        BS.Current!Company = PubCompanyName
        BS.Current!InvoiceType = PubInvoiceType
        BS.Current!InvoiceNo = GenerateNo()
        BS.Current!InvoiceDate = Date.Today
        BS.Current!ChallanNo = GenerateNo()
        BS.Current!ChallanDate = Date.Today()
        'BS.Current!PartyDCDate = Date.Today()
        BS.Current!PODate = Date.Today()
        BS.Current!ARNDate = Date.Today()
        BS.Current!PackingCharge = 0
        BS.Current!PCGSTRate = 0
        BS.Current!PCGSTAmt = 0
        BS.Current!PSGSTRate = 0
        BS.Current!PSGSTAmt = 0
        BS.Current!PIGSTRate = 0
        BS.Current!PIGSTAmt = 0
        BS.Current!TotalAmtBeforeTax = 0
        BS.Current!CGST = 0
        BS.Current!SGST = 0
        BS.Current!IGST = 0
        BS.Current!TotalGSTTax = 0
        BS.Current!TotalAmtAfterTax = 0
        BS.Current!GSTReverseCharge = 0
        BS.Current!GrandTotalAmount = 0
        BS.EndEdit()

        If PubIGST = False Then
            PIGSTRateTextEdit.Properties.ReadOnly = True
            PIGSTRateTextEdit.TabStop = False
        ElseIf PubIGST = True Then
            PCGSTRateTextEdit.Properties.ReadOnly = True
            PCGSTRateTextEdit.TabStop = False
            PSGSTRateTextEdit.Properties.ReadOnly = True
            PSGSTRateTextEdit.TabStop = False
        End If

        Status = 0
        Dim GTotal As Double = BS.Current!GrandTotalAmount
        NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)

        InvoiceDateDateEdit.Focus()
        InitLookup()
    End Sub
    Function GetCurrentYear() As String
        ' Dim DACompany As New OleDbDataAdapter("Select CompanyID,FinancialYear From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As DataTable = GetCompanyData()
        If DTCompany.Rows.Count > 0 Then
            Dim FinancialYear As String = DTCompany.Rows(0).Item("FinancialYear").ToString
            Return FinancialYear
        End If

    End Function
    Function GenerateNo() As String
        Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,SalesInvoiceCount From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        'Dim DACompany As New OleDbDataAdapter("Select CompanyID,SalesInvoicePrefix From Company Where Name ='" + PubCompanyName + "'", ConStr)
        'Dim DTCompany As New DataTable
        'DACompany.Fill(DTCompany)
        Dim DTCompany As DataTable = GetCompanyData()
        If DTCompany.Rows.Count > 0 Then


            Dim InvoiceNo As String = DTFinance.Rows(0).Item("SalesInvoiceCount").ToString
            len = InvoiceNo.Length()

            Dim SalesInvoicePrefix As String = DTCompany.Rows(0).Item("SalesInvoicePrefix").ToString

            InvoiceCount = InvoiceNo

            Dim newPO As String = SalesInvoicePrefix + "/" + InvoiceCount + "/" + GetCurrentYear()

            Return newPO
        End If
    End Function

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick

        BS.CancelEdit()
        BSDetails.CancelEdit()
        DS.RejectChanges()
        AddNew()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        Dim ID = ShowRecord("SELECT * FROM Invoice Where InvoiceType='" + PubInvoiceType + "' AND (Invoice.InvoiceDate between #" & SubStart & "# And #" & SubEnd & "#) AND Company ='" + PubCompanyName + "' ORDER BY InvoiceDate DESC", "InvoiceID")
        If ID > 0 Then
            Try
                DS.Tables("InvoiceDetail").Clear()
                DS.Tables("Invoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@InvoiceID").Value = ID
            DA.Fill(DS, "Invoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@InvoiceID").Value = ID
            DADetails.Fill(DS, "InvoiceDetail")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)

            CurrentInvoiceNo = ID
        End If
    End Sub

    Sub SetCurrentData()
        Dim ID = CurrentInvoiceNo
        If ID > 0 Then
            Try
                DS.Tables("InvoiceDetail").Clear()
                DS.Tables("Invoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@InvoiceID").Value = ID
            DA.Fill(DS, "Invoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@InvoiceID").Value = ID
            DADetails.Fill(DS, "InvoiceDetail")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record ?" + vbNewLine + "If You Delete This Record then Related Items Record also Delete..", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                For Each row In DS.Tables("InvoiceDetail").Select("InvoiceID =" & BS.Current!InvoiceID)
                    BSDetails.RemoveCurrent()
                    DADetails.Update(DS.Tables("InvoiceDetail"))
                Next

                BS.RemoveCurrent()
                DA.Update(DS.Tables("Invoice"))

                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("This Record Is Used In Another Record : Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter Invoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.Current!ModelNo = ModelNoTextEdit.Text
                BS.EndEdit()
                DA.Update(DS.Tables("Invoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(InvoiceID) FROM Invoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into InvoiceDetail (InvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@InvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@InvoiceID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
                        InsertCMD.Parameters.AddWithValue("@IsService", BSDetails.Current!IsService)
                        InsertCMD.Parameters.AddWithValue("@Amount", BSDetails.Current!Amount)
                        InsertCMD.Parameters.AddWithValue("@Discount", BSDetails.Current!Discount)
                        InsertCMD.Parameters.AddWithValue("@DiscountVal", BSDetails.Current!DiscountVal)
                        InsertCMD.Parameters.AddWithValue("@TaxableValue", BSDetails.Current!TaxableValue)
                        InsertCMD.Parameters.AddWithValue("@CGSTRate", BSDetails.Current!CGSTRate)
                        InsertCMD.Parameters.AddWithValue("@CGSTAmt", BSDetails.Current!CGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@SGSTRate", BSDetails.Current!SGSTRate)
                        InsertCMD.Parameters.AddWithValue("@SGSTAmt", BSDetails.Current!SGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@IGSTRate", BSDetails.Current!IGSTRate)
                        InsertCMD.Parameters.AddWithValue("@IGSTAmt", BSDetails.Current!IGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@TotalAmount", BSDetails.Current!TotalAmount)

                        CnnOpen() : InsertCMD.ExecuteNonQuery() : CnnClose()

                        BSDetails.MoveNext()
                    Next
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount"))
                            'Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                    Dim myString As String = InvoiceCount


                    Dim X As Integer = CInt(myString) + 1
                    Dim reCount As String = (Convert.ToInt32(X)).ToString.PadLeft(len, "0"c)

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set SalesInvoiceCount=@SalesInvoiceCount Where Company ='" + PubCompanyName + "'And FinancialYear = '" + GetCurrentYear() + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@SalesInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("InvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount"))
                            'Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                End If
                AddNew()
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter Invoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.Current!ModelNo = ModelNoTextEdit.Text
                BS.EndEdit()
                DA.Update(DS.Tables("Invoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(InvoiceID) FROM Invoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    CurrentInvoiceNo = CurrentID
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into InvoiceDetail (InvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@InvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@InvoiceID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
                        InsertCMD.Parameters.AddWithValue("@IsService", BSDetails.Current!IsService)
                        InsertCMD.Parameters.AddWithValue("@Amount", BSDetails.Current!Amount)
                        InsertCMD.Parameters.AddWithValue("@Discount", BSDetails.Current!Discount)
                        InsertCMD.Parameters.AddWithValue("@DiscountVal", BSDetails.Current!DiscountVal)
                        InsertCMD.Parameters.AddWithValue("@TaxableValue", BSDetails.Current!TaxableValue)
                        InsertCMD.Parameters.AddWithValue("@CGSTRate", BSDetails.Current!CGSTRate)
                        InsertCMD.Parameters.AddWithValue("@CGSTAmt", BSDetails.Current!CGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@SGSTRate", BSDetails.Current!SGSTRate)
                        InsertCMD.Parameters.AddWithValue("@SGSTAmt", BSDetails.Current!SGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@IGSTRate", BSDetails.Current!IGSTRate)
                        InsertCMD.Parameters.AddWithValue("@IGSTAmt", BSDetails.Current!IGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@TotalAmount", BSDetails.Current!TotalAmount)

                        CnnOpen() : InsertCMD.ExecuteNonQuery() : CnnClose()

                        BSDetails.MoveNext()
                    Next
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount"))
                            'Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                    Dim myString As String = InvoiceCount

                    Dim X As Integer = CInt(myString) + 1
                    Dim reCount As String = (Convert.ToInt32(X)).ToString.PadLeft(len, "0"c)

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set SalesInvoiceCount=@SalesInvoiceCount Where Company ='" + PubCompanyName + "'And FinancialYear = '" + GetCurrentYear() + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@SalesInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("InvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount"))
                            'Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If

                    Next
                End If
                XtraMessageBox.Show("Invoice Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AddNew()
                SetCurrentData()
            End If
        End If
    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub InvoiceDetailGridControl_Leave(sender As Object, e As EventArgs) Handles InvoiceDetailGridControl.Leave

        BS.Current!TotalAmtBeforeTax = InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue

        BS.Current!CGST = InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue
        BS.Current!SGST = InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue
        BS.Current!IGST = InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue

        BS.Current!TotalGSTTax = BS.Current!CGST + BS.Current!SGST + BS.Current!IGST
        BS.Current!TotalAmtAfterTax = InvoiceDetailGridView.Columns("TotalAmount").SummaryItem.SummaryValue
        BS.EndEdit()
        Calc()
    End Sub

    Private Sub InvoiceDetailGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles InvoiceDetailGridView.CellValueChanged
        Try
            If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "DiscountVal" Or e.Column.FieldName = "CGSTRate" Or e.Column.FieldName = "SGSTRate" Or e.Column.FieldName = "IGSTRate" Then
                Dim qty As Double = IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)
                BSDetails.Current!Qty = Math.Round(qty, 2)

                BSDetails.Current!Amount = IIf(BSDetails.Current!Rate Is DBNull.Value, 0, BSDetails.Current!Rate) * IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)

                If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "CGSTRate" Or e.Column.FieldName = "SGSTRate" Or e.Column.FieldName = "IGSTRate" Then
                    Dim Amt As Double = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount) / 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - Amt
                    BSDetails.Current!DiscountVal = Math.Round(Amt, 2)
                    'New change for cal dis
                    BSDetails.Current!Discount = IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount)

                    'Dim Dis As Double = IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal) / IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * 100
                    'BSDetails.Current!Discount = Math.Round(Dis, 2)
                End If

                If e.Column.FieldName = "DiscountVal" Then
                    Dim Dis As Double = IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal) / IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal)
                    BSDetails.Current!Discount = Math.Round(Dis, 2)
                End If
                If PubInvoiceType = "SEZ Sales Invoice IGST" Or PubInvoiceType = "Export Sales Invoice IGST" Then
                    BSDetails.Current!CGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * 0 / 100
                    BSDetails.Current!SGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * 0 / 100
                    BSDetails.Current!IGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * 0 / 100
                Else
                    BSDetails.Current!CGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!CGSTRate Is DBNull.Value, 0, BSDetails.Current!CGSTRate) / 100
                    BSDetails.Current!SGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!SGSTRate Is DBNull.Value, 0, BSDetails.Current!SGSTRate) / 100
                    BSDetails.Current!IGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!IGSTRate Is DBNull.Value, 0, BSDetails.Current!IGSTRate) / 100
                End If
                BSDetails.Current!TotalAmount = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) + IIf(BSDetails.Current!CGSTAmt Is DBNull.Value, 0, BSDetails.Current!CGSTAmt) + IIf(BSDetails.Current!SGSTAmt Is DBNull.Value, 0, BSDetails.Current!SGSTAmt) + IIf(BSDetails.Current!IGSTAmt Is DBNull.Value, 0, BSDetails.Current!IGSTAmt)
                BSDetails.EndEdit()
            End If

            If e.Column.FieldName = "ProductName" Then
                Dim Pname As String
                Pname = DirectCast(BSDetails.Current, DataRowView).Item("ProductName").ToString

                Dim sda As New OleDbDataAdapter("Select UOM, HSNNoOrSACNo, Price, ProductName, IsService From Product Where ProductName='" + Pname + "'", ConStr)
                Dim dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count > 0 Then
                    BSDetails.Current!UOM = dt.Rows(0).Item("UOM").ToString
                    BSDetails.Current!HSNACS = dt.Rows(0).Item("HSNNoOrSACNo").ToString
                    If Not dt.Rows(0).Item("Price") Is DBNull.Value Then
                        BSDetails.Current!Rate = Convert.ToDecimal(dt.Rows(0).Item("Price"))
                    End If
                    BSDetails.Current!ProductName = dt.Rows(0).Item("ProductName").ToString
                    BSDetails.Current!IsService = dt.Rows(0).Item("IsService").ToString
                    BSDetails.EndEdit()
                End If
            End If

        Catch ex As Exception
            'ErtOccur(ex)
        End Try
    End Sub

    Private Sub InvoiceDetailGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles InvoiceDetailGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            BSDetails.RemoveCurrent()
            BSDetails.EndEdit()
        End If
    End Sub

    Private Sub InvoiceDetailGridView_LostFocus(sender As Object, e As EventArgs) Handles InvoiceDetailGridView.LostFocus
        Try
            BS.Current!GrandTotalAmount = Math.Round((IIf(BS.Current!TotalAmtAfterTax Is DBNull.Value, 0, BS.Current!TotalAmtAfterTax))) ' + IIf(BS.Current!IntAmt Is DBNull.Value, 0, BS.Current!IntAmt)))
            BS.EndEdit()
            Calc()
            'Dim bz As New CultureInfo("hi-In")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)


        Catch ex As Exception
            'ErtOccur(ex)
        End Try
    End Sub

    'Private Sub InvoiceDetailGridView_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles InvoiceDetailGridView.FocusedColumnChanged
    '    If e.FocusedColumn.FieldName = "Rate" Then
    '        If InvoiceDetailGridView.GetFocusedRowCellDisplayText("Qty") = "" Then
    '            InvoiceDetailGridControl.Focus()
    '            SendKeys.Send("{TAB}")
    '            SendKeys.Send("{TAB}")
    '        End If
    '    End If
    'End Sub

    Private Sub InvoiceDetailGridView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs) Handles InvoiceDetailGridView.CustomColumnDisplayText
        Try
            Dim view As ColumnView = TryCast(sender, ColumnView)
            If e.Column.FieldName = "Rate" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim Rate As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", Rate)
            End If
            If e.Column.FieldName = "Amount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim Amt As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", Amt)
            End If
            If e.Column.FieldName = "TaxableValue" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim TV As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", TV)
            End If
            If e.Column.FieldName = "CGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim CGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", CGST)
            End If
            If e.Column.FieldName = "SGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim SGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", SGST)
            End If
            If e.Column.FieldName = "IGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim IGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", IGST)
            End If
            If e.Column.FieldName = "TotalAmount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim TAmt As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", TAmt)
            End If
        Catch
        End Try
    End Sub

    'Private Sub PackingTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PackingTextEdit.Validating
    '    Dim iNumber As Integer
    '    If PackingTextEdit IsNot DBNull.Value Then
    '        If Not Integer.TryParse(PackingTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Valid Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            PackingTextEdit.Focus()
    '        End If
    '    End If

    'End Sub
    Private Sub PCGSTRateTextEdit_LostFocus(sender As Object, e As EventArgs) Handles PCGSTRateTextEdit.LostFocus, PSGSTRateTextEdit.LostFocus, PIGSTRateTextEdit.LostFocus, PackingTextEdit.LostFocus
        BS.EndEdit()
        Calc()
    End Sub

    Private Sub Calc()
        BS.Current!TotalAmtBeforeTax = Math.Round(IIf(InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue Is DBNull.Value, 0, InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue) + IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge), 2)
        If PubInvoiceType = "SEZ Sales Invoice IGST" Or PubInvoiceType = "Export Sales Invoice IGST" Then
            BS.Current!PCGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * 0 / 100
            BS.Current!PSGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * 0 / 100
            BS.Current!PIGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * 0 / 100
        Else
            BS.Current!PCGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PCGSTRate Is DBNull.Value, 0, BS.Current!PCGSTRate) / 100
            BS.Current!PSGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PSGSTRate Is DBNull.Value, 0, BS.Current!PSGSTRate) / 100
            BS.Current!PIGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PIGSTRate Is DBNull.Value, 0, BS.Current!PIGSTRate) / 100
        End If
        BS.Current!CGST = Math.Round(InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue + BS.Current!PCGSTAmt, 2)
        BS.Current!SGST = Math.Round(InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue + BS.Current!PSGSTAmt, 2)
        BS.Current!IGST = Math.Round(InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue + BS.Current!PIGSTAmt, 2)

        BS.Current!TotalGSTTax = Math.Round(BS.Current!CGST + BS.Current!SGST + BS.Current!IGST, 2)
        BS.Current!TotalAmtAfterTax = Math.Round(BS.Current!TotalAmtBeforeTax + BS.Current!TotalGSTTax, 2)

        BS.Current!GrandTotalAmount = Math.Round(BS.Current!TotalAmtAfterTax)

        BS.Current!RoundOff = BS.Current!GrandTotalAmount - BS.Current!TotalAmtAfterTax

        'Dim bz As New CultureInfo("hi-IN")
        Dim GTotal As Double = BS.Current!GrandTotalAmount
        Dim TotalTax As Double = BS.Current!TotalGSTTax
        NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)


        'BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal.ToString("c", bz).Remove(0, 1)))
        'BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax.ToString("c", bz).Remove(0, 1)))
        If PubInvoiceType = "Export Sales Invoice IGST" Then
            BS.Current!TotalInWords = USAmtInWord(Convert.ToDecimal(GTotal))
            If Not TotalGSTTaxTextEdit.Text = 0 Then
                BS.Current!TaxInWords = USAmtInWord(Convert.ToDecimal(TotalTax))
            Else
                BS.Current!TaxInWords = "Zero"
            End If
        Else
            BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal))
            If Not TotalGSTTaxTextEdit.Text = 0 Then
                BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax))
            Else
                BS.Current!TaxInWords = "Zero"
            End If
            'BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax))
        End If

        BS.EndEdit()
    End Sub
    Private Sub AddressCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles AddressCheckEdit.CheckedChanged
        Try
            BS.EndEdit()
            If AddressCheckEdit.Checked = True Then
                BS.Current!ConsigneeName = BS.Current!ReceiverName
                BS.Current!ConsigneeAddress = BS.Current!ReceiverAddress
                BS.Current!ConsigneeGSTIN = BS.Current!ReceiverGSTIN
                BS.Current!ConsigneeState = BS.Current!ReceiverState
                BS.Current!ConsigneeStateCode = BS.Current!ReceiverStateCode
                BS.Current!ConsigneePanNo = BS.Current!ReceiverPanNo
                ConsigneeGSTINTextEdit.Enabled = True

            Else
                BS.Current!ConsigneeName = ""
                BS.Current!ConsigneeAddress = ""
                BS.Current!ConsigneeGSTIN = ""
                BS.Current!ConsigneeState = ""
                BS.Current!ConsigneeStateCode = ""
                BS.Current!ConsigneePanNo = ""
                ConsigneeGSTINTextEdit.Enabled = False
            End If
            BS.EndEdit()
        Catch ex As Exception
        End Try
    End Sub

    Public Flag As Integer

    Private Sub PrintBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalPrintBarButtonItem.ItemClick
        'SimpleButton1.PerformClick()
        Dim InvoiceNo As String = BS.Current!InvoiceID
        Flag = 1

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
    End Sub

    Private Sub PrintDuplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintDuplicateBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!InvoiceID
        Flag = 2

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub

    Private Sub PrintTriplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintTriplicateBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!InvoiceID
        Flag = 3

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub
    Private Sub PrintOriginalSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalSignBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!InvoiceID
        Flag = 7

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub

    Private Sub PrintTriplicateSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintTriplicateSignBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!InvoiceID
        Flag = 8

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub
    Private Sub PrintEWBillBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintEWBillBarButtonItem.ItemClick

        Dim InvoiceNo As String = BS.Current!InvoiceID


        Dim DTCompany As DataTable = GetCompanyData()
        If DTCompany.Rows.Count > 0 Then
            Dim daHSN As OleDbDataAdapter
            Dim dtHSN As New DataTable
            Dim sqlHSN As String
            sqlHSN = "SELECT DISTINCT HSNACS from InvoiceDetail Where InvoiceID = " + InvoiceNo
            daHSN = New OleDbDataAdapter(sqlHSN, ConStr)
            daHSN.Fill(dtHSN)
            Dim i As Integer
            Dim HSN As String
            For i = 0 To dtHSN.Rows.Count - 1
                If Not dtHSN.Rows(i).Item(0) Is DBNull.Value Then
                    HSN += dtHSN.Rows(i).Item(0) + " "
                End If
            Next

            Dim Rpt As New XR_EWayBillA
            Rpt.Invoice.Value = InvoiceNo
            Rpt.Invoice.Visible = False
            Rpt.FillDataSource()

            Rpt.UniqXrLabel.Text = BS.Current!EwbNo
            Rpt.EntDtXrLabel.Text = BS.Current!EwbDt
            Rpt.EntByXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString + ", " + DTCompany.Rows(0).Item("Name").ToString
            Rpt.ValidXrLabel.Text = "Not Valid for Movement as Part B is not entered [" + BS.Current!Distance + "]"
            Rpt.SupGSTXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString + ", " + DTCompany.Rows(0).Item("Name").ToString
            Rpt.DispXrLabel.Text = DTCompany.Rows(0).Item("Loc").ToString + ", " + DTCompany.Rows(0).Item("State").ToString + "-" + DTCompany.Rows(0).Item("Pin").ToString
            Rpt.RecGSTXrLabel.Text = BS.Current!ReceiverGSTIN + ", " + BS.Current!ReceiverName
            Dim sdc As New OleDbDataAdapter("Select Pin,City From Party Where PartyName='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
            Dim dtc As New DataTable()
            sdc.Fill(dtc)
            Dim cpin, ccity As String
            If (dtc.Rows.Count > 0) Then
                If Not dtc.Rows(0).Item("Pin") Is DBNull.Value Then
                    cpin = dtc.Rows(0).Item("Pin")
                Else
                    MsgBox("Please enter Consignee Pin number in party table")
                End If

                ccity = dtc.Rows(0).Item("City").ToString
            End If
            Rpt.DelXrLabel.Text = ccity + ", " + BS.Current!ReceiverState + "-" + cpin
            Rpt.DocNoXrLabel.Text = BS.Current!InvoiceNo
            Rpt.DocDtXrLabel.Text = BS.Current!InvoiceDate
            If BS.Current!VehType = "R" Then
                Rpt.TransTypeXrLabel.Text = "Regular"
            Else BS.Current!VehType = "O"
                Rpt.TransTypeXrLabel.Text = "ODC"
            End If


            Rpt.ValGoodsXrLabel.Text = BS.Current!GrandTotalAmount
            Rpt.HSNXrLabel.Text = HSN + " " + BS.Current!ModelNo
            Rpt.ReaTransportationXrLabel.Text = "Outward-Supply"
            If TransIDTextEdit.Text.Trim() <> "" Then
                Rpt.TransporterXrLabel.Text = BS.Current!TransId + " & " + BS.Current!TransName
            End If
            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- E-Way Bill PART-A -")
            End_Waiting()

            Rpt.ShowRibbonPreviewDialog()
        End If
    End Sub

    Private Sub EWayBillABBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EWayBillABBarButtonItem.ItemClick

        Dim InvoiceNo As String = BS.Current!InvoiceID


        Dim DTCompany As DataTable = GetCompanyData()
        If DTCompany.Rows.Count > 0 Then
            Dim daHSN As OleDbDataAdapter
            Dim dtHSN As New DataTable
            Dim sqlHSN As String
            sqlHSN = "SELECT DISTINCT HSNACS from InvoiceDetail Where InvoiceID = " + InvoiceNo
            daHSN = New OleDbDataAdapter(sqlHSN, ConStr)
            daHSN.Fill(dtHSN)
            Dim i As Integer
            Dim HSN As String
            For i = 0 To dtHSN.Rows.Count - 1
                If Not dtHSN.Rows(i).Item(0) Is DBNull.Value Then
                    HSN += dtHSN.Rows(i).Item(0) + " "
                End If
            Next

            Dim Rpt As New XR_EWayBillB
            Rpt.Invoice.Value = InvoiceNo
            Rpt.Invoice.Visible = False
            Rpt.FillDataSource()

            Rpt.UniqXrLabel.Text = BS.Current!EwbNo
            Rpt.EntDtXrLabel.Text = BS.Current!EwbDt
            Rpt.EntByXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString + ", " + DTCompany.Rows(0).Item("Name").ToString

            Rpt.ValidXrLabel.Text = BS.Current!EwbDt + " [" + BS.Current!Distance + "]"
            If EwbValidTillDateEdit.Text <> "" Then
                Rpt.ValidTilXrLabel.Text = BS.Current!EwbValidTill
            End If


            Rpt.SupGSTXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString + ", " + DTCompany.Rows(0).Item("Name").ToString
            Rpt.DispXrLabel.Text = DTCompany.Rows(0).Item("Loc").ToString + ", " + DTCompany.Rows(0).Item("State").ToString + "-" + DTCompany.Rows(0).Item("Pin").ToString
            Rpt.RecGSTXrLabel.Text = BS.Current!ReceiverGSTIN + ", " + BS.Current!ReceiverName
            Dim sdc As New OleDbDataAdapter("Select Pin,City From Party Where PartyName='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
            Dim dtc As New DataTable()
            sdc.Fill(dtc)
            Dim cpin, ccity As String
            If (dtc.Rows.Count > 0) Then
                If Not dtc.Rows(0).Item("Pin") Is DBNull.Value Then
                    cpin = dtc.Rows(0).Item("Pin")
                Else
                    MsgBox("Please enter Consignee Pin number in party table")
                End If

                ccity = dtc.Rows(0).Item("City").ToString
            End If
            Rpt.DelXrLabel.Text = ccity + ", " + BS.Current!ReceiverState + "-" + cpin
            Rpt.DocNoXrLabel.Text = BS.Current!InvoiceNo
            Rpt.DocDtXrLabel.Text = BS.Current!InvoiceDate
            If BS.Current!VehType = "R" Then
                Rpt.TransTypeXrLabel.Text = "Regular"
            Else BS.Current!VehType = "O"
                Rpt.TransTypeXrLabel.Text = "ODC"
            End If

            Rpt.ValGoodsXrLabel.Text = BS.Current!GrandTotalAmount
            Rpt.HSNXrLabel.Text = HSN + " " + BS.Current!ModelNo
            Rpt.ReaTransportationXrLabel.Text = "Outward-Supply"
            If TransIDTextEdit.Text.Trim() <> "" Then
                Rpt.TransporterXrLabel.Text = BS.Current!TransId + " & " + BS.Current!TransName
            Else
                Rpt.TransporterXrLabel.Text = ""
            End If

            Rpt.ModeValueXrTableCell.Text = BS.Current!TransMode
            If VehNoTextEdit.Text.Trim() <> "" Then
                Rpt.VehicleDetailsValueXrTableCell.Text = BS.Current!VehNo
            End If
            Rpt.FromValueXrTableCell.Text = DTCompany.Rows(0).Item("Loc").ToString
            Rpt.EnteredDateValurXrTableCell.Text = BS.Current!EwbDt
            Rpt.EnteredByValueXrTableCell.Text = DTCompany.Rows(0).Item("GSTIN").ToString
            Rpt.CEWBvalueXrTableCell.Text = BS.Current!CEWBNo
            Rpt.MultiVehValueXrTableCell.Text = BS.Current!MultiVehInfo
            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- E-Way Bill PART-AB -")
            End_Waiting()

            Rpt.ShowRibbonPreviewDialog()
        End If
    End Sub

    Private Sub PrintDetailedBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintDetailedBarButtonItem.ItemClick

        Dim InvoiceNo As String = BS.Current!InvoiceID


        Dim DTCompany As DataTable = GetCompanyData()
        If DTCompany.Rows.Count > 0 Then

            Dim daHSN As OleDbDataAdapter
        Dim dtHSN As New DataTable
        Dim sqlHSN As String
        sqlHSN = "SELECT DISTINCT HSNACS from InvoiceDetail Where InvoiceID = " + InvoiceNo
        daHSN = New OleDbDataAdapter(sqlHSN, ConStr)
        daHSN.Fill(dtHSN)
        Dim i As Integer
        Dim HSN As String
        For i = 0 To dtHSN.Rows.Count - 1
            If Not dtHSN.Rows(i).Item(0) Is DBNull.Value Then
                HSN += dtHSN.Rows(i).Item(0) + " "
            End If
        Next

        Dim Rpt As New XR_EWayDetailed

        Rpt.Invoice.Value = InvoiceNo
        Rpt.Invoice.Visible = False
        Rpt.FillDataSource()

            Rpt.UniqXrLabel.Text = BS.Current!EwbNo
        Rpt.EntDtXrLabel.Text = BS.Current!EwbDt
        Rpt.EntByXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString
        If EwbValidTillDateEdit.Text <> "" Then
            Rpt.ValidTilXrLabel.Text = BS.Current!EwbValidTill
        End If

        Rpt.ModeXrLabel.Text = BS.Current!TransMode
        Rpt.DistanceXrLabel.Text = BS.Current!Distance
        Rpt.TypeXrLabel.Text = "Outward-Supply"
        Rpt.DocNoXrLabel.Text = "Tax Invoice - " + BS.Current!InvoiceNo
        Rpt.DocDtXrLabel.Text = BS.Current!InvoiceDate
        If BS.Current!VehType = "R" Then
            Rpt.TransTypeXrLabel.Text = "Regular"
        Else BS.Current!VehType = "O"
            Rpt.TransTypeXrLabel.Text = "ODC"
        End If

        Rpt.FromGSTXrLabel.Text = DTCompany.Rows(0).Item("GSTIN").ToString
        Rpt.FromPartyXrLabel.Text = DTCompany.Rows(0).Item("Name").ToString
        Rpt.FromStateXrLabel.Text = DTCompany.Rows(0).Item("State").ToString
        Rpt.FromAddXrLabel.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")

        Rpt.ToGstXrLabel.Text = BS.Current!ConsigneeGSTIN
        Rpt.ToPartyXrLabel.Text = BS.Current!ConsigneeName
        Rpt.ToStateXrLabel.Text = BS.Current!ConsigneeState
        Rpt.ToAddXrLabel.Text = BS.Current!ConsigneeAddress



            If TransIDTextEdit.Text.Trim() <> "" Then
            Rpt.TrIdNameXrLabel.Text = BS.Current!TransId + " - " + BS.Current!TransName
        End If
        If VehNoTextEdit.Text.Trim() <> "" Then
            Rpt.VehicleDetailsValueXrTableCell.Text = BS.Current!VehNo
        End If


        Rpt.TraDocDtXrLabel.Text = BS.Current!InvoiceNo + "-" + BS.Current!InvoiceDate
        Rpt.ModeValueXrTableCell.Text = BS.Current!TransMode
        Rpt.FromValueXrTableCell.Text = DTCompany.Rows(0).Item("Loc").ToString
        Rpt.EnteredDateValurXrTableCell.Text = BS.Current!EwbDt
        Rpt.EnteredByValueXrTableCell.Text = DTCompany.Rows(0).Item("GSTIN").ToString
        Rpt.CEWBvalueXrTableCell.Text = BS.Current!CEWBNo
        Rpt.MultiVehValueXrTableCell.Text = BS.Current!MultiVehInfo
        Rpt.TaxValXrTableCell.Text = BS.Current!TotalAmtBeforeTax
        Rpt.CAmtXrTableCell.Text = BS.Current!CGST
        Rpt.SAmtXrTableCell.Text = BS.Current!SGST
        Rpt.IAmtXrTableCell.Text = BS.Current!IGST
        Rpt.CessXrTableCell.Text = "0.00"
        Rpt.CessNonXrTableCell.Text = "0.00"
        Rpt.OtherXrTableCell.Text = BS.Current!RoundOff
        Rpt.TotXrTableCell.Text = BS.Current!GrandTotalAmount

            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
        ReportPrintTool.PreviewRibbonForm.Text = String.Format("- E-Way Bill Detailed -")
        End_Waiting()

            Rpt.ShowRibbonPreviewDialog()
        End If
    End Sub

    Private Sub ReceiverNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReceiverNameComboBoxEdit.SelectedIndexChanged
        InitLookup()
        Dim sda As New OleDbDataAdapter("Select Address,State,StateCode,GSTIN,PANNo From Party Where PartyName='" + ReceiverNameComboBoxEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            ReceiverAddressTextEdit.Text = dt.Rows(0).Item("Address").ToString
            ReceiverStateTextEdit.Text = dt.Rows(0).Item("State").ToString
            ReceiverStateCodeTextEdit.Text = dt.Rows(0).Item("StateCode").ToString
            ReceiverGSTINTextEdit.Text = dt.Rows(0).Item("GSTIN").ToString
            ReceiverPANNoTextEdit.Text = dt.Rows(0).Item("PANNo").ToString
        End If
    End Sub
    Private Sub ConsigneeNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConsigneeNameComboBoxEdit.SelectedIndexChanged
        InitLookup()
        Dim sda As New OleDbDataAdapter("Select Address,State,StateCode,GSTIN,PANNo From Party Where PartyName='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            ConsigneeAddressTextEdit.Text = dt.Rows(0).Item("Address").ToString
            ConsigneeStateTextEdit.Text = dt.Rows(0).Item("State").ToString
            ConsigneeStateCodeTextEdit.Text = dt.Rows(0).Item("StateCode").ToString
            ConsigneeGSTINTextEdit.Text = dt.Rows(0).Item("GSTIN").ToString
            ConsigneePANNoTextEdit.Text = dt.Rows(0).Item("PANNo").ToString
        End If
    End Sub

    Private Sub AddNewProduct_Click(sender As Object, e As EventArgs) Handles AddNewProductSimpleButton.Click
        Frm_AddProduct.StartPosition = FormStartPosition.CenterParent
        Frm_AddProduct.ShowDialog()
        If Frm_AddProduct.DialogResult = DialogResult.OK Then
            GridComboBoxFunc("Select DISTINCT ProductName FROM Product", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
            Frm_AddProduct.Close()
        Else
            Frm_AddProduct.Close()
        End If
    End Sub


    Private Sub InvoiceDetailGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles InvoiceDetailGridView.InitNewRow
        BSDetails.EndEdit()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub RemarksTextEdit_Leave(sender As Object, e As EventArgs) Handles RemarksTextEdit.Leave
        If RemarksTextEdit.EditValue IsNot DBNull.Value Then
            If RemarksTextEdit.Text.Length > 111 Then
                XtraMessageBox.Show("You can enter upto 110 characters.", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemarksTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub ConsigneePANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles ConsigneePANNoTextEdit.Leave
        If ConsigneePANNoTextEdit.EditValue IsNot DBNull.Value Then
            If ConsigneePANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConsigneePANNoTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub ReceiverPANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles ReceiverPANNoTextEdit.Leave
        If ReceiverPANNoTextEdit.EditValue IsNot DBNull.Value Then
            If ReceiverPANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ReceiverPANNoTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub AddNewPartySimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewPartySimpleButton.Click
        Frm_AddParty.StartPosition = FormStartPosition.CenterParent
        Frm_AddParty.ShowDialog()
        If Frm_AddParty.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddParty.Close()
        Else
            Frm_AddParty.Close()
        End If
    End Sub

    Private Sub ReceiverNameComboBoxEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReceiverNameComboBoxEdit.KeyPress, ConsigneeNameComboBoxEdit.KeyPress
        InitLookup()
    End Sub

    Private Sub InvoiceNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InvoiceNoTextEdit.Validating
        If Not InvoiceNoTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(InvoiceID) FROM Invoice WHERE InvoiceNo=@InvoiceNo AND InvoiceID<>@InvoiceID", ConStr)
                CMD.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@InvoiceID", IIf(BS.Current!InvoiceID Is DBNull.Value, -1, BS.Current!InvoiceID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    InvoiceNoTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub

    Private Sub ChallanNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ChallanNoTextEdit.Validating
        If Not ChallanNoTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(InvoiceID) FROM Invoice WHERE ChallanNo=@ChallanNo AND InvoiceID<>@InvoiceID", ConStr)
                CMD.Parameters.AddWithValue("@ChallanNo", ChallanNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@InvoiceID", IIf(BS.Current!InvoiceID Is DBNull.Value, -1, BS.Current!InvoiceID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ChallanNoTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub

    Private Sub InvoiceDateDateEdit_Leave(sender As Object, e As EventArgs) Handles InvoiceDateDateEdit.Leave
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)
        Dim iDate As String = InvoiceDateDateEdit.Text
        Dim oDate As DateTime = Convert.ToDateTime(iDate)
        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        If iDate >= SubStart And iDate <= SubEnd Then

        Else
            XtraMessageBox.Show("Date is out of Range! Please Enter a Valid Date or check your Financial Period.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Not between")
            InvoiceDateDateEdit.Focus()
        End If
    End Sub

    Private Sub ChallanDateDateEdit_Leave(sender As Object, e As EventArgs) Handles ChallanDateDateEdit.Leave
        'Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,StartDate,EndDate From FinancialSettings Where Company ='" + PubCompanyName + "'", ConStr)
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)
        Dim iDate As String = ChallanDateDateEdit.Text
        Dim oDate As DateTime = Convert.ToDateTime(iDate)
        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        If iDate >= SubStart And iDate <= SubEnd Then

        Else
            XtraMessageBox.Show("Date is out of Range! Please Enter a Valid Date or check your Financial Period.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Not between")
            ChallanDateDateEdit.Focus()
        End If
    End Sub

    Private Sub CloseBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseBarButtonItem.ItemClick
        Me.Close()
    End Sub

    Private Sub TransIDTextEdit_Leave(sender As Object, e As EventArgs) Handles TransIDTextEdit.Leave
        If TransIDTextEdit.Text.Trim() <> "" Then
            Dim client = New RestClient()
            Dim request = New RestRequest()
            Dim response = New RestResponse()
            AuthToken = Label1.Text

            Dim strUrl = SandboxURL + "/eivital/dec/v1.04/Master/gstin/" + TransIDTextEdit.Text + "?&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_Name=" + eInvUserId + "&AuthToken=" + AuthToken
            MaskedTextBox1.Text = strUrl
            client.BaseUrl = New Uri(strUrl).ToString()
            request.Method = Method.GET
            response = client.Execute(request)

            If response.Content = "" Then
                XtraMessageBox.Show(response.ErrorMessage)
                Exit Sub
            End If
            GSTResp = serializer.Deserialize(Of GSTResponse)(response.Content)
            If GSTResp.status_cd <> Nothing Then
                If GSTResp.status_cd = "0" And GSTResp.error.error_cd = "GSP752" Then
                    Dim result As DialogResult = MessageBox.Show("AuthToken is Expired, Do you want to regenerate AuthToken?", "TaxPro GST", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        Exit Sub
                    ElseIf result = DialogResult.Yes Then
                        Call GetAuthToken()
                        TransIDTextEdit_Leave(TransIDTextEdit, EventArgs.Empty)
                    End If
                Else
                    TxtBoxError.Text = GSTResp.error.message
                    Exit Sub
                End If
            End If
            If GSTResp.Status = "0" Then
                If GSTResp.ErrorDetails(0).ErrorCode = 3001 Then
                    TxtBoxError.Text = "Error Code: " + GSTResp.ErrorDetails(0).ErrorCode + ": " + GSTResp.ErrorDetails(0).ErrorMessage
                    XtraMessageBox.Show("Error Code: " + GSTResp.ErrorDetails(0).ErrorCode + ": " + GSTResp.ErrorDetails(0).ErrorMessage, "Info")
                    'File.WriteAllText(FilePath, InvPaylod)
                    Exit Sub
                Else
                    XtraMessageBox.Show("Error Code: " + GSTResp.ErrorDetails(0).ErrorCode + ": " + GSTResp.ErrorDetails(0).ErrorMessage, "Info")
                    Exit Sub
                End If
            End If

            If GSTResp.Status = "1" Then
                Try
                    ' Deserialize outer JSON
                    Dim outerResponse As GSTResponse = JsonConvert.DeserializeObject(Of GSTResponse)(response.Content)

                    If outerResponse IsNot Nothing AndAlso outerResponse.Status = "1" AndAlso Not String.IsNullOrEmpty(outerResponse.Data) Then
                        ' Deserialize inner JSON string (Data)
                        Dim innerData As GSTData = JsonConvert.DeserializeObject(Of GSTData)(outerResponse.Data)

                        ' Assign TradeName to Textbox
                        TransNMTextEdit.Text = innerData.TradeName
                    Else
                        'MsgBox("Invalid API response or no data found.")
                    End If
                Catch ex As Exception
                    MsgBox("Error processing response: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub GenerateEWBSimpleButton_Click(sender As Object, e As EventArgs) Handles GenerateEWBSimpleButton.Click
        '    updateJson1()
        '    Dim client = New RestClient()
        '    Dim request = New RestRequest()
        '    Dim response = New RestResponse()
        '    AuthToken = Label1.Text
        '    ASPID = ConfigurationManager.AppSettings("ASPID")
        '    ASPPwd = ConfigurationManager.AppSettings("ASPPwd")
        '    Gstin = ConfigurationManager.AppSettings("Gstin")
        '    eInvUserId = ConfigurationManager.AppSettings("TaxproUserName")
        '    eInvPwd = ConfigurationManager.AppSettings("eInvPwd")
        '    SandboxURL = ConfigurationManager.AppSettings("TaxproSandboxURL")
        '    AppPath = ConfigurationManager.AppSettings("AppPath")
        '    TxtBoxError.Text = ""
        '    'TxtBoxResp.Text = File.ReadAllText(Application.StartupPath + "\GenIRN.txt")
        '    Dim FilePath = AppPath + "\GenEWay.txt"
        '    TxtBoxResp.Text = File.ReadAllText(AppPath + "\GenEWay.txt")
        '    Dim InvPaylod = TxtBoxResp.Text

        '    'validate Json file data with predefine schema format by TaxPro
        '    Dim ShemaResponse As JSonValidatorResponse = ValidateJsonAgainstEWBSchema(TxtBoxResp.Text)
        '    If ShemaResponse IsNot Nothing Then
        '        TxtBoxError.Text = ""
        '        If ShemaResponse.ErrorList IsNot Nothing Then
        '            If ShemaResponse.ErrorList.Count > 1 Then
        '                Dim i As Integer = 0
        '                For Each err As String In ShemaResponse.ErrorList
        '                    'MsgBox(ShemaResponse.ErrorList(0))
        '                    TxtBoxError.Text += (ShemaResponse.ErrorList(i))
        '                    TxtBoxError.Text += (" " + vbCrLf)
        '                    i += 1
        '                Next
        '                Exit Sub
        '            Else
        '                If ShemaResponse.Valid = False Then
        '                    TxtBoxError.Text = ShemaResponse.ErrorList(0)
        '                    TxtBoxError.Text += (" " + vbCrLf)
        '                    XtraMessageBox.Show("Something seems to be entered wrong in JSON Field Values, Please check your Payload and try again!!")
        '                    Exit Sub
        '                End If
        '            End If

        '        End If
        '    Else
        '        Exit Sub
        '    End If

        '    'For Sandbox

        '    'Dim strUrl = "https://gstsandbox.charteredinfo.com/eiewb/dec/v1.03/ewaybill?&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&user_name=" + eInvUserId + "&AuthToken=" + AuthToken + "&irp='NIC1'&irpurl='1'"
        '    Dim strUrl = SandboxURL + "/eiewb/dec/v1.03/ewaybill?&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_Name=" + eInvUserId + "&AuthToken=" + AuthToken + "&irp=NIC1&irpurl=1"
        '    MaskedTextBox1.Text = strUrl
        '    client.BaseUrl = New Uri(strUrl).ToString()
        '    request.Method = Method.POST
        '    request.RequestFormat = DataFormat.Json
        '    request.AddHeader("Content-Type", "application/json; charset=utf-8")
        '    'request.AddBody(InvDetails)`

        '    request.AddParameter("application/json", InvPaylod, ParameterType.RequestBody)
        '    response = client.Execute(request)
        '    'Dim RespGenIRN = response.Content
        '    If response.Content = "" Then
        '        XtraMessageBox.Show(response.ErrorMessage)
        '        Exit Sub
        '        File.WriteAllText(FilePath, InvPaylod)
        '    End If
        '    EWBResp = serializer.Deserialize(Of EWBClass)(response.Content)
        '    'MsgBox(EWBResp.error.error_cd)

        '    If EWBResp.status_cd <> Nothing Then
        '        If EWBResp.status_cd = "0" And EWBResp.error.error_cd = "GSP752" Then
        '            Dim result As DialogResult = MessageBox.Show("AuthToken is Expired, Do you want to regenerate AuthToken?", "TaxPro GST", MessageBoxButtons.YesNo)
        '            If result = DialogResult.No Then
        '                File.WriteAllText(FilePath, InvPaylod)
        '                Exit Sub
        '            ElseIf result = DialogResult.Yes Then
        '                Call GetAuthToken()
        '                GenerateEWBSimpleButton.PerformClick()
        '            End If
        '        Else
        '            TxtBoxError.Text = EWBResp.error.message
        '            File.WriteAllText(FilePath, InvPaylod)
        '            Exit Sub
        '        End If
        '    End If
        '    If EWBResp.Status = "0" Then
        '        If EWBResp.ErrorDetails(0).ErrorCode <> 5002 Then
        '            TxtBoxError.Text = "Error Code: " + EWBResp.ErrorDetails(0).ErrorCode + ": " + EWBResp.ErrorDetails(0).ErrorMessage
        '            XtraMessageBox.Show("Error Code: " + EWBResp.ErrorDetails(0).ErrorCode + ": " + EWBResp.ErrorDetails(0).ErrorMessage, "Info")
        '            'File.WriteAllText(FilePath, InvPaylod)
        '            Exit Sub
        '        Else
        '            XtraMessageBox.Show("Error Code: " + EWBResp.ErrorDetails(0).ErrorCode + ": " + EWBResp.ErrorDetails(0).ErrorMessage, "Info")
        '            Exit Sub
        '        End If
        '    End If
        '    If EWBResp.Status <> "1" Then
        '        Dim DupIRN = serializer.Serialize(EWBResp.InfoDtls(0).Desc)
        '        Dim Desc As EWBClass.Desc = serializer.Deserialize(Of EWBClass.Desc)(DupIRN)
        '        TxtBoxError.Text = "Error Code: " + EWBResp.ErrorDetails(0).ErrorCode + ": " + EWBResp.ErrorDetails(0).ErrorMessage
        '        txtIRN.Text = Desc.EwbNo
        '        TxtBoxError.Text = "Error Code: " + EWBResp.ErrorDetails(0).ErrorCode + ": " + EWBResp.ErrorDetails(0).ErrorMessage
        '        'File.WriteAllText(FilePath, InvPaylod)
        '        Exit Sub
        '    End If
        '    'If EWBResp.InfoDtls <> Nothing Then
        '    '    Dim ErrResp = serializer.Serialize(EWBResp.InfoDtls(0).Desc)
        '    '    Dim EwbErrDesc() As EWBClass.Errordetail = serializer.Deserialize(Of EWBClass.Errordetail())(ErrResp)
        '    '    TxtBoxError.Text = "InfoCD: " + EWBResp.InfoDtls(0).InfCd + ": " + EwbErrDesc(0).ErrorMessage
        '    'End If

        '    'If EWBResp.InfoDtls IsNot Nothing AndAlso EWBResp.InfoDtls.Length > 0 Then
        '    '    ' Directly access the properties
        '    '    TxtBoxError.Text = "InfoCD: " & EWBResp.InfoDtls(0).InfCd & ": " & EWBResp.InfoDtls(0).Desc
        '    'End If
        '    EWBData = serializer.Deserialize(Of EWBData)(EWBResp.Data)
        '    If EWBResp.Status = "1" Then
        '        TxtBoxResp.Text = response.Content
        '        TxtBoxError.Text = ""
        '        EwbNoTextEdit.Text = EWBData.EWBNO
        '        'BS.Current!EwbNo = EwbNoTextEdit.Text
        '        EwbDateDateEdit.Text = EWBData.EWBDT
        '        'BS.Current!EwbDt = EwbDateDateEdit.Text
        '        EwbValidTillDateEdit.Text = EWBData.EWBVALIDTILL
        '        'BS.Current!EwbValidTill = EwbValidTillDateEdit.Text
        '        'MsgBox(IRNData.IRN)
        '        'Dim imageBytes As Byte() = Convert.FromBase64String(IRNData.QRCodeImage)
        '        ''QRCodeMemoEdit.Text = imageBytes.ToString

        '        '' Convert the byte array to a Base64 encoded string
        '        'Dim base64String As String = Convert.ToBase64String(imageBytes)

        '        '' Set the text of QRCodeMemoEdit with the Base64 encoded string
        '        'QRCodeMemoEdit.Text = base64String
        '        'BS.Current!QRCode = QRCodeMemoEdit.Text
        '        'MsgBox(IRNData.QRCodeImage)
        '        'File.WriteAllBytes(Application.StartupPath & "/QR.jpg", imageBytes)
        '        'PictureBox2.Image = Image.FromFile(Application.StartupPath & "/QR.jpg")
        '        XtraMessageBox.Show("Your E-WAY Bill created successfully. Now you can take a print", "Info")
        '        SimpleButton1.PerformClick()
        '    End If
        '    File.WriteAllText(FilePath, InvPaylod)
        '    File.WriteAllText(AppPath & "/EWBData.txt", EWBResp.Data)
    End Sub

    Private Sub EWayBillPrintBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EWayBillPrintBarButtonItem.ItemClick
        Frm_SelectPrintAction.StartPosition = FormStartPosition.CenterParent
        Frm_SelectPrintAction.ControlBox = True
        Frm_SelectPrintAction.ShowDialog()

        Dim client = New RestClient()
        Dim request = New RestRequest()
        Dim response = New RestResponse()
        AuthToken = Label1.Text

        TxtBoxError.Text = ""
        If EwbNoTextEdit.Text <> "" Then
            Dim ewbNo As String = EwbNoTextEdit.Text
            'Dim strUrl = "https://gstsandbox.charteredinfo.com/ewaybillapi/dec/v1.03/ewayapi?action=GetEwayBill&ewbNo=" + ewbNo + "&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_Name=" + eInvUserId + "&AuthToken=" + AuthToken

            Dim strUrl = SandboxURL + "/v1.03/dec/ewayapi?action=GetEwayBill&ewbNo=" + ewbNo + "&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&AuthToken=" + AuthToken
            MaskedTextBox1.Text = strUrl
            client.BaseUrl = New Uri(strUrl).ToString()
            request.Method = Method.GET
            request.RequestFormat = DataFormat.Json
            request.AddHeader("Content-Type", "application/json; charset=utf-8")
            response = client.Execute(request)
            If response.Content = "" Then
                XtraMessageBox.Show(response.ErrorMessage)
                Exit Sub
            End If
            Dim strResp As String
            strResp = response.Content
            If strResp.Contains("status_cd") Then
                EwayResp = JsonConvert.DeserializeObject(Of EWayBillClass)(response.Content)
                If EwayResp.status_cd <> Nothing Then
                    If EwayResp.status_cd = "0" And EwayResp.error.error_cd = "GSP102" Then
                        Dim result As DialogResult = MessageBox.Show("AuthToken is Expired, Do you want to regenerate AuthToken?", "TaxPro GST", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            Exit Sub
                        ElseIf result = DialogResult.Yes Then
                            Call GetAuthToken()
                            EWayBillPrintBarButtonItem.PerformClick()
                        End If
                    Else
                        TxtBoxError.Text = EwayResp.error.message
                        Exit Sub
                    End If
                End If
            ElseIf strResp.Contains("ewbNo") Then
                Dim ewayBillData As String = JsonConvert.DeserializeObject(Of String)(response.Content)
                Dim EwayResp As EWayBillClass = JsonConvert.DeserializeObject(Of EWayBillClass)(ewayBillData)
                'Dim postUrl As String = "https://einvapi.charteredinfo.com/aspapi/v1.0/printcewb?aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=24AACFP2257Q1ZX"

                Dim postUrl As String = SandboxURL + "/aspapi/v1.0/" + PubPrintAction + "?aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin
                Task.Run(Function() SendDataToApi(postUrl, ewayBillData)).Wait()
            End If
        Else
            XtraMessageBox.Show("Please generate eWay Bill first!", "Info")
        End If
    End Sub

    Private Sub TransportModeComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TransportModeComboBoxEdit.SelectedIndexChanged
        'TransportationModeTextEdit.Text = TransportModeComboBoxEdit.Text
    End Sub

    Private Sub TransIDTextEdit_TextChanged(sender As Object, e As EventArgs) Handles TransIDTextEdit.TextChanged
        'If TransIDTextEdit.Text.Trim() <> "" Then
        '    VehNoTextEdit.Enabled = False
        '    VehTypeRadioGroup.Enabled = False
        'Else
        '    TransNMTextEdit.Text = ""
        '    VehNoTextEdit.Enabled = True
        '    VehTypeRadioGroup.Enabled = True
        'End If
    End Sub

    Async Function SendDataToApi(ByVal url As String, ByVal jsonData As String) As Task
        Using client As New HttpClient()
            Try
                ' Set content type
                Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

                ' Make POST request
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                ' Read response
                Dim responseString As String = Await response.Content.ReadAsStringAsync()
                Dim responseBytes As Byte() = Await response.Content.ReadAsByteArrayAsync()
                'Dim pdfFolderPath As String = "MyeWaybillDoc\"
                Dim pdfFolderPath = ConfigurationManager.AppSettings("AppPath") + "\Preevol-EWayBillDoc\"
                'Dim pdfPath As String = Path.Combine(pdfFolderPath, "Response.pdf")
                Dim jsonObject As JObject = JObject.Parse(jsonData)
                Dim eNo As String = jsonObject("ewbNo").ToString()
                Dim pdfPath As String = ""
                If PubPrintAction = "printewb" Then
                    pdfPath = pdfFolderPath & eNo.ToString() & "_PartA" & ".pdf"
                ElseIf PubPrintAction = "printcewb" Then
                    pdfPath = pdfFolderPath & eNo.ToString() & "_PartAB" & ".pdf"
                ElseIf PubPrintAction = "printdetailewb" Then
                    pdfPath = pdfFolderPath & eNo.ToString() & "_Detailed" & ".pdf"

                End If

                If Not Directory.Exists(pdfFolderPath) Then
                    Directory.CreateDirectory(pdfFolderPath)
                End If

                ' Write byte array to PDF file
                File.WriteAllBytes(pdfPath, responseBytes)

                ' Output response status
                'Console.WriteLine("Response Status Code: " & response.StatusCode)
                'Console.WriteLine("PDF saved at: " & pdfPath)

                ' Open the PDF file
                Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
                ' Output response
                'Console.WriteLine("Response Status Code: " & response.StatusCode)
                'Console.WriteLine("Response Body: " & responseString)
            Catch ex As Exception
                XtraMessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function
    Private Sub SendEmailSimpleButton_Click(sender As Object, e As EventArgs) Handles SendEmailSimpleButton.Click
        Dim DAParty As New OleDbDataAdapter("Select Email From Party Where PartyName ='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
        Dim DTParty As New DataTable
        DAParty.Fill(DTParty)
        Dim partyEmail As String
        If DTParty.Rows(0).Item("Email") IsNot DBNull.Value Then
            partyEmail = DTParty.Rows(0).Item("Email").ToString()

            Dim oMail As New SmtpMail("TryIt")
            oMail.From = ConfigurationManager.AppSettings("Username")
            oMail.To = partyEmail
            oMail.Subject = "Sales Invoice Copy"
            oMail.TextBody = " Hi Team
                                Please find attachment of sales invoice copy for your reference.
                                Let me know if you have any query.
                                Regards,
                                For, Preevol Technics
                                MS Brahmbhatt
                                Mob. 93270 11740"
            For Each filePath As String In OpenFileDialog1.FileNames
                If File.Exists(filePath) Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    oMail.AddAttachment(filePath)
                End If
            Next
            Dim oServer As New SmtpServer("smtp.mail.yahoo.com")
            oServer.User = ConfigurationManager.AppSettings("Username")
            oServer.Password = ConfigurationManager.AppSettings("Password")
            oServer.Port = 465
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
            'Console.WriteLine("start to send email over SSL ...")
            Dim oSmtp As New SmtpClient()

            Try
                oSmtp.SendMail(oServer, oMail)
                XtraMessageBox.Show("Email was sent successfully!", "Info")
                Threading.Thread.Sleep(3000)
            Catch error_t As Exception
                XtraMessageBox.Show(error_t.ToString, "Info")
            End Try
        Else
            XtraMessageBox.Show("Please enter party's email to send email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each filePath As String In OpenFileDialog1.FileNames
            If File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                lblAttachment.Text += fileName + Environment.NewLine
            End If
        Next
    End Sub

    'Mittal Added after EInvoice Implement on 01 August 23
    Private Sub updateJson()
        Try
            Dim EInvoiceJson As String
            EInvoiceJson = ""

            Dim Einvoice As New EInvoiceJsonModule.EInvoice
            Einvoice.Version = "1.1"

            Dim IOI, RegRev As String
            If PubIGST = True Then
                If BS.Current!SupplyStateCode = 24 Then
                    IOI = "Y"
                    RegRev = "N"
                Else
                    IOI = "N"
                    RegRev = "N"
                End If
            Else
                IOI = "N"
                RegRev = "N"
            End If
            Dim TranDtl As EInvoiceJsonModule.TranDtls = New EInvoiceJsonModule.TranDtls With {
                .TaxSch = "GST",
                .SupTyp = PubSupTyp,
                .IgstOnIntra = IOI,
                .RegRev = RegRev
            }
            Einvoice.TranDtls = TranDtl
            Dim InvoiceDate As DateTime = BS.Current!InvoiceDate
            Dim output As String = InvoiceDate.ToString("dd-MM-yyyy")
            output = output.Replace("-", "/")


            Dim DocDtl As EInvoiceJsonModule.DocDtls = New EInvoiceJsonModule.DocDtls With {
                .Typ = "INV",
                .No = BS.Current!InvoiceNo,
                .Dt = output
                }

            Einvoice.DocDtls = DocDtl

            Dim DTCompany As DataTable = GetCompanyData()
            If DTCompany.Rows.Count > 0 Then
                Dim SellerDtl As EInvoiceJsonModule.SellerDtls = New EInvoiceJsonModule.SellerDtls With {
                .Gstin = ConfigurationManager.AppSettings("Gstin"),
                .LglNm = PubCompanyName,
                .Addr1 = DTCompany.Rows(0).Item("Address").ToString,
                .Loc = DTCompany.Rows(0).Item("Loc").ToString,
                .Pin = Convert.ToInt32(DTCompany.Rows(0).Item("Pin")),
                .Stcd = DTCompany.Rows(0).Item("StateCode").ToString,
                .Ph = DTCompany.Rows(0).Item("Phone2").ToString,
                .Em = DTCompany.Rows(0).Item("EmailID1").ToString
                }
                'For Sandbox API Data testing
                'Dim SellerDtl As EInvoiceJsonModule.SellerDtls = New EInvoiceJsonModule.SellerDtls With {
                '    .Gstin = ConfigurationManager.AppSettings("Gstin"),
                '    .LglNm = "NIC company pvt ltd",
                '    .Addr1 = "5th block, kuvempu layout",
                '    .Loc = "GANDHINAGAR",
                '    .Pin = 605001,
                '    .Stcd = "34",
                '    .Ph = "9000000000",
                '    .Em = "abc@gmail.com"
                '    }
                'SellerDtls.Add(SellerDtl)
                Einvoice.SellerDtls = SellerDtl
            End If


            Dim Radd As String
            Radd = BS.Current!ReceiverAddress
            Radd = Trim(Radd)
            If Radd.Length > 99 Then
                Radd = Radd.Substring(0, 99)
                Radd = Trim(Radd)
            End If
            Dim sba As New OleDbDataAdapter("Select Pin,city From Party Where PartyName='" + ReceiverNameComboBoxEdit.Text + "'", ConStr)
            Dim dtb As New DataTable()
            sba.Fill(dtb)
            Dim pin As Integer, city As String
            If (dtb.Rows.Count > 0) Then
                If Not dtb.Rows(0).Item("Pin") Is DBNull.Value Then
                    pin = Convert.ToInt32(dtb.Rows(0).Item("Pin"))
                Else
                    MsgBox("Please enter Receiver Pin number in party table")
                End If

                city = dtb.Rows(0).Item("City").ToString
            End If

            Dim BuyerDtl As EInvoiceJsonModule.BuyerDtls = New EInvoiceJsonModule.BuyerDtls With {
                .Gstin = BS.Current!ReceiverGSTIN,
                .LglNm = BS.Current!ReceiverName,
                .Pos = BS.Current!SupplyStateCode,
                .Addr1 = Radd,
                .Loc = city,
                .Pin = pin,
                .Stcd = BS.Current!ReceiverStateCode
            }
            Einvoice.BuyerDtls = BuyerDtl

            Dim Cadd As String
            Cadd = BS.Current!ConsigneeAddress
            Cadd = Trim(Cadd)
            If Cadd.Length > 99 Then
                Cadd = Cadd.Substring(0, 99)
                Cadd = Trim(Cadd)
            End If
            Dim sdc As New OleDbDataAdapter("Select Pin,City From Party Where PartyName='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
            Dim dtc As New DataTable()
            sdc.Fill(dtc)
            Dim cpin As Integer, ccity As String
            If (dtc.Rows.Count > 0) Then
                If Not dtc.Rows(0).Item("Pin") Is DBNull.Value Then
                    cpin = Convert.ToInt32(dtc.Rows(0).Item("Pin"))
                Else
                    MsgBox("Please enter Consignee Pin number in party table")
                End If

                ccity = dtc.Rows(0).Item("City").ToString
            End If
            If AddressCheckEdit.Checked = True Then
                Dim ShipDtl As EInvoiceJsonModule.ShipDtls = New EInvoiceJsonModule.ShipDtls With {
                .Gstin = BS.Current!ConsigneeGSTIN,
                .LglNm = BS.Current!ConsigneeName,
                .Addr1 = Cadd,
                .Loc = ccity,
                .Pin = cpin,
                .Stcd = BS.Current!ConsigneeStateCode
                }
                Einvoice.ShipDtls = ShipDtl
            Else
                Dim ShipDtl As EInvoiceJsonModule.ShipDtls = New EInvoiceJsonModule.ShipDtls With {
                .LglNm = BS.Current!ConsigneeName,
                .Addr1 = Cadd,
                .Loc = ccity,
                .Pin = cpin,
                .Stcd = BS.Current!ConsigneeStateCode
                }
                Einvoice.ShipDtls = ShipDtl

            End If

            Dim InvoiceNo As String = BS.Current!InvoiceID
            Dim DAInvDetail As New OleDbDataAdapter("SELECT * FROM INVOICEDETAIL WHERE INVOICEID =" + InvoiceNo, ConStr)
            Dim DTInvDetail As New DataTable
            DAInvDetail.Fill(DTInvDetail)
            Dim gstRate As Integer
            If Not DTInvDetail.Rows(0).Item("CGSTRate") Is DBNull.Value Then
                gstRate = Math.Round(Convert.ToInt32(DTInvDetail.Rows(0)("CGSTRate")) + Convert.ToInt32(DTInvDetail.Rows(0)("SGSTRate")), 2)
            ElseIf Not DTInvDetail.Rows(0).Item("IGSTRate") Is DBNull.Value Then
                gstRate = Math.Round(Convert.ToInt32(DTInvDetail.Rows(0)("IGSTRate")), 2)
            End If
            Dim ItemLists As List(Of EInvoiceJsonModule.ItemList) = New List(Of EInvoiceJsonModule.ItemList)()
            For i As Integer = 0 To DTInvDetail.Rows.Count - 1

                ItemLists.Add(New EInvoiceJsonModule.ItemList With {
                              .SlNo = i + 1,
                               .IsServc = DTInvDetail.Rows(i)("IsService"),
                              .HsnCd = DTInvDetail.Rows(i)("HSNACS"),
                              .Qty = DTInvDetail.Rows(i)("Qty"),
                              .Unit = DTInvDetail.Rows(i)("UOM"),
                              .UnitPrice = DTInvDetail.Rows(i)("Rate"),
                              .Discount = Math.Round(DTInvDetail.Rows(i)("DiscountVal"), 2),
                              .TotAmt = Math.Round(DTInvDetail.Rows(i)("Amount"), 2),
                              .AssAmt = Math.Round(DTInvDetail.Rows(i)("TaxableValue"), 2),
                              .GstRt = gstRate,
                              .CgstAmt = Math.Round(DTInvDetail.Rows(i)("CGSTAmt"), 2),
                              .SgstAmt = Math.Round(DTInvDetail.Rows(i)("SGSTAmt"), 2),
                              .IgstAmt = Math.Round(DTInvDetail.Rows(i)("IGSTAmt"), 2),
                              .TotItemVal = Math.Round(DTInvDetail.Rows(i)("TotalAmount"), 2)
                    })
            Next
            Einvoice.ItemList = ItemLists

            Dim ValDtl As EInvoiceJsonModule.ValDtls = New EInvoiceJsonModule.ValDtls With {
                .AssVal = BS.Current!TotalAmtBeforeTax,
                .TotInvVal = BS.Current!GrandTotalAmount,
                .CgstVal = BS.Current!CGST,
                .SgstVal = BS.Current!SGST,
                .IgstVal = BS.Current!IGST
            }
            Einvoice.ValDtls = ValDtl


            Dim TrMode As Char
            If TransportModeComboBoxEdit.SelectedIndex = 0 Then
                TrMode = "1"
            ElseIf TransportModeComboBoxEdit.SelectedIndex = 1 Then
                TrMode = "2"
            ElseIf TransportModeComboBoxEdit.SelectedIndex = 2 Then
                TrMode = "3"
            ElseIf TransportModeComboBoxEdit.SelectedIndex = 3 Then
                TrMode = "4"
            End If

            If TransIDTextEdit.Text.Trim() <> "" AndAlso VehNoTextEdit.Text.Trim <> "" Then
                Dim EwbDtl As EInvoiceJsonModule.EwbDtls = New EInvoiceJsonModule.EwbDtls With {
                .TransId = BS.Current!TransId,
                .TransName = BS.Current!TransName,
                .Distance = "0",
                .TransDocNo = BS.Current!InvoiceNo,
                .TransDocDt = output,
                .VehNo = BS.Current!VehNo,
                .VehType = BS.Current!VehType,
                .TransMode = TrMode
            }
                Einvoice.EwbDtls = EwbDtl
            ElseIf TransIDTextEdit.Text.Trim() <> "" Then
                Dim EwbDtl As EInvoiceJsonModule.EwbDtls = New EInvoiceJsonModule.EwbDtls With {
                .TransId = BS.Current!TransId,
                .TransName = BS.Current!TransName,
                .Distance = "0",
                .TransDocDt = output,
                .VehType = BS.Current!VehType
            }
                Einvoice.EwbDtls = EwbDtl
            ElseIf VehNoTextEdit.Text.Trim <> "" Then
                Dim EwbDtl As EInvoiceJsonModule.EwbDtls = New EInvoiceJsonModule.EwbDtls With {
                .Distance = "0",
                .TransDocDt = output,
                .TransDocNo = BS.Current!InvoiceNo,
                .VehNo = BS.Current!VehNo,
                .VehType = BS.Current!VehType,
                .TransMode = TrMode
            }
                Einvoice.EwbDtls = EwbDtl
            ElseIf TransIDTextEdit.Text = "" And VehNoTextEdit.Text = "" Then
                'XtraMessageBox.Show("No Eway bill", "Info")


            End If



            EInvoiceJson = JsonConvert.SerializeObject(Einvoice, Newtonsoft.Json.Formatting.Indented)
            TxtBoxResp.Text = EInvoiceJson
            Dim FilePath = ConfigurationManager.AppSettings("AppPath") + "\GenIRN.txt"
            Dim InvPaylod = TxtBoxResp.Text
            File.WriteAllText(FilePath, InvPaylod)


        Catch ex As Exception

        End Try

    End Sub
    Private Sub updateJson1()
        'Try
        '    Dim EWayBillJson As String
        '    EWayBillJson = ""

        '    Dim EWayBill As New EWayBillJsonModule.EWayBill
        '    'EWayBill.Irn = txtIRN.Text
        '    EWayBill.Irn = "17875eeafe404d494b50ee8daefe9328fefa6fcf3f80fe09fb9863d976d10d31"
        '    EWayBill.Distance = 0
        '    EWayBill.TransMode = "1"
        '    EWayBill.TransId = "12AWGPV7107B1Z1"
        '    EWayBill.TransName = "Maruti transport"
        '    EWayBill.TransDocDt = "06/02/2025"
        '    EWayBill.TransDocNo = "Tra/Doc/01"   
        '    EWayBill.VehNo = "KA12ER1234"
        '    EWayBill.VehType = "R"
        '    Dim ExpShipDtl As EWayBillJsonModule.Address = New EWayBillJsonModule.Address With {
        '        .Addr1 = "7th block, kuvempu layout",
        '        .Addr2 = "Channapatna",
        '        .Loc = "Banagalore",
        '        .Pin = 562160,
        '        .Stcd = "29"
        '    }
        '    EWayBill.ExpShipDtls = ExpShipDtl
        '    Dim DispDtl As EWayBillJsonModule.Address = New EWayBillJsonModule.Address With {
        '        .Nm = "TestABC company",
        '        .Addr1 = "7th block, kuvempu layout",
        '        .Addr2 = "Dasanapura",
        '        .Loc = "Banagalore",
        '        .Pin = 562162,
        '        .Stcd = "29"
        '    }
        '    EWayBill.DispDtls = DispDtl

        '    EWayBillJson = JsonConvert.SerializeObject(EWayBill, Newtonsoft.Json.Formatting.Indented)
        '    TxtBoxResp.Text = EWayBillJson
        '    Dim FilePath = ConfigurationManager.AppSettings("AppPath") + "\GenEWay.txt"
        '    Dim InvPaylod = TxtBoxResp.Text
        '    File.WriteAllText(FilePath, InvPaylod)

        'Catch ex As Exception

        'End Try

    End Sub
    'Private Function GetData(ByVal query As String) As DataTable
    '    Dim conString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Dim cmd As SqlCommand = New SqlCommand(query)
    '    Using con As SqlConnection = New SqlConnection(conString)
    '        Using sda As SqlDataAdapter = New SqlDataAdapter()
    '            cmd.Connection = con
    '            sda.SelectCommand = cmd
    '            Using dt As DataTable = New DataTable()
    '                sda.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using
    'End Function
    Private Sub GetAuthToken()
        ' ==============Api Call using RestSharp==================

        Dim client = New RestClient()
        Dim request = New RestRequest()
        Dim response = New RestResponse()


        Dim FilePath = AppPath + "\AuthToken.txt"
        'Production(AuthUrl)
        'Dim strAuthUrl = "https://einvapi.charteredinfo.com/eivital/dec/v1.04/auth?aspid=********&password=********&Gstin=********&User_name=*******&eInvPwd=******"

        'SandBox Auth URL
        'Dim strUrl = "https://gstsandbox.charteredinfo.com/eivital/dec/v1.04/auth?aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_name=" + eInvUserId + "&eInvPwd=" + eInvPwd
        Dim strUrl = SandboxURL + "/eivital/dec/v1.04/auth?aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_name=" + eInvUserId + "&eInvPwd=" + eInvPwd
        MaskedTextBox1.Text = strUrl
        client.BaseUrl = New Uri(strUrl).ToString()
        request.Method = Method.GET
        response = client.Execute(request)
        If response.Content = "" Then
            MsgBox(response.ErrorMessage)
            Exit Sub
        End If
        'Desearializing Response in Auth Class
        AuthRespObj = serializer.Deserialize(Of AuthClass)(response.Content)
        If AuthRespObj.status_cd = "0" Then
            TxtBoxResp.Text = AuthRespObj.[error].message
            Exit Sub
        End If
        'Displaying AuthToken

        Label1.Text = AuthRespObj.Data.AuthToken
        XtraMessageBox.Show("Auth Token refreshed Succesfully", "Info")
        File.WriteAllText(FilePath, Label1.Text)
    End Sub
    Private Sub GenerateEInvoiceSimpleButton_Click(sender As Object, e As EventArgs) Handles GenerateEInvoiceSimpleButton.Click
        updateJson()

        Dim client = New RestClient()
        Dim request = New RestRequest()
        Dim response = New RestResponse()
        AuthToken = Label1.Text

        TxtBoxError.Text = ""
        Dim FilePath = AppPath + "\GenIRN.txt"
        TxtBoxResp.Text = File.ReadAllText(AppPath + "\GenIRN.txt")
        Dim InvPaylod = TxtBoxResp.Text

        Dim ShemaResponse As JSonValidatorResponse = ValidateJsonAgainstSchema(TxtBoxResp.Text)
        If ShemaResponse IsNot Nothing Then
            TxtBoxError.Text = ""
            If ShemaResponse.ErrorList IsNot Nothing Then
                If ShemaResponse.ErrorList.Count > 1 Then
                    Dim i As Integer = 0
                    For Each err As String In ShemaResponse.ErrorList

                        TxtBoxError.Text += (ShemaResponse.ErrorList(i))
                        TxtBoxError.Text += (" " + vbCrLf)
                        i += 1
                    Next
                    Exit Sub
                Else
                    If ShemaResponse.Valid = False Then
                        TxtBoxError.Text = ShemaResponse.ErrorList(0)
                        TxtBoxError.Text += (" " + vbCrLf)
                        XtraMessageBox.Show("Something seems to be entered wrong in JSON Field Values, Please check your Payload and try again!!")
                        Exit Sub
                    End If
                End If

            End If
        Else
            Exit Sub
        End If

        'For Sandbox

        'Dim strUrl = "https://gstsandbox.charteredinfo.com/eicore/dec/v1.03/Invoice?&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_Name=" + eInvUserId + "&AuthToken=" + AuthToken + "&QrCodeSize=250"
        Dim strUrl = SandboxURL + "/eicore/dec/v1.03/Invoice?&aspid=" + ASPID + "&password=" + ASPPwd + "&Gstin=" + Gstin + "&User_Name=" + eInvUserId + "&AuthToken=" + AuthToken + "&QrCodeSize=250"
        MaskedTextBox1.Text = strUrl
        client.BaseUrl = New Uri(strUrl).ToString()
        request.Method = Method.POST
        request.RequestFormat = DataFormat.Json
        request.AddHeader("Content-Type", "application/json; charset=utf-8")
        'request.AddBody(InvDetails)

        request.AddParameter("application/json", InvPaylod, ParameterType.RequestBody)
        response = client.Execute(request)
        'Dim RespGenIRN = response.Content
        If response.Content = "" Then
            XtraMessageBox.Show(response.ErrorMessage)
            Exit Sub
            File.WriteAllText(FilePath, InvPaylod)
        End If
        IRNResp = serializer.Deserialize(Of IRNClass)(response.Content)

        'MsgBox(IRNResp.error.error_cd)

        If IRNResp.status_cd <> Nothing Then
            If IRNResp.status_cd = "0" And IRNResp.error.error_cd = "GSP752" Then
                Dim result As DialogResult = MessageBox.Show("AuthToken is Expired, Do you want to regenerate AuthToken?", "TaxPro GST", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    File.WriteAllText(FilePath, InvPaylod)
                    Exit Sub
                ElseIf result = DialogResult.Yes Then
                    Call GetAuthToken()
                    GenerateEInvoiceSimpleButton.PerformClick()
                End If
            Else
                TxtBoxError.Text = IRNResp.error.message
                File.WriteAllText(FilePath, InvPaylod)
                Exit Sub
            End If
        End If
        If IRNResp.Status = "0" Then
            If IRNResp.ErrorDetails(0).ErrorCode <> 5002 Then
                TxtBoxError.Text = "Error Code: " + IRNResp.ErrorDetails(0).ErrorCode + ": " + IRNResp.ErrorDetails(0).ErrorMessage
                XtraMessageBox.Show("Error Code: " + IRNResp.ErrorDetails(0).ErrorCode + ": " + IRNResp.ErrorDetails(0).ErrorMessage, "Info")
                'File.WriteAllText(FilePath, InvPaylod)
                Exit Sub
            Else
                XtraMessageBox.Show("Error Code: " + IRNResp.ErrorDetails(0).ErrorCode + ": " + IRNResp.ErrorDetails(0).ErrorMessage, "Info")
                Exit Sub
            End If
        End If
        If IRNResp.Status <> "1" Then
            Dim DupIRN = serializer.Serialize(IRNResp.InfoDtls(0).Desc)
            Dim Desc As IRNClass.Desc = serializer.Deserialize(Of IRNClass.Desc)(DupIRN)
            TxtBoxError.Text = "Error Code: " + IRNResp.ErrorDetails(0).ErrorCode + ": " + IRNResp.ErrorDetails(0).ErrorMessage
            txtIRN.Text = Desc.Irn
            TxtBoxError.Text = "Error Code: " + IRNResp.ErrorDetails(0).ErrorCode + ": " + IRNResp.ErrorDetails(0).ErrorMessage
            'File.WriteAllText(FilePath, InvPaylod)
            Exit Sub
        End If
        'If IRNResp.InfoDtls <> Nothing Then
        '    Dim ErrResp = serializer.Serialize(IRNResp.InfoDtls(0).Desc)
        '    Dim EwbErrDesc() As IRNClass.Errordetail = serializer.Deserialize(Of IRNClass.Errordetail())(ErrResp)
        '    TxtBoxError.Text = "InfoCD: " + IRNResp.InfoDtls(0).InfCd + ": " + EwbErrDesc(0).ErrorMessage
        'End If
        IRNData = serializer.Deserialize(Of IRNData)(IRNResp.Data)
        If IRNResp.Status = "1" Then
            TxtBoxResp.Text = response.Content
            TxtBoxError.Text = ""
            txtIRN.Text = IRNData.IRN
            BS.Current!IRNNo = txtIRN.Text
            AckNoTextEdit.Text = IRNData.ACKNO
            BS.Current!AckNo = AckNoTextEdit.Text
            AckDateDateEdit.Text = IRNData.ACKDT
            BS.Current!AckDate = AckDateDateEdit.Text

            If IRNData.EwbNo <> "" Then
                EwbNoTextEdit.Text = IRNData.EwbNo
                BS.Current!EwbNo = EwbNoTextEdit.Text
                AgainstFormTextEdit.Text = IRNData.EwbNo
                BS.Current!AgainstForm = AgainstFormTextEdit.Text

                EwbDateDateEdit.Text = IRNData.EwbDt
                BS.Current!EwbDt = EwbDateDateEdit.Text
            End If
            If IRNData.EwbValidTill <> "" Then
                EwbValidTillDateEdit.Text = IRNData.EwbValidTill
                BS.Current!EwbValidTill = EwbValidTillDateEdit.Text
            End If
            If IRNResp.InfoDtls IsNot "" Then
                If IRNResp.InfoDtls IsNot Nothing Then
                    If IRNResp.InfoDtls.Length = 1 Then
                        Dim inputText As String = IRNResp.InfoDtls(0).Desc.ToString()
                        If inputText.Contains("Pin-Pin calc distance") Then
                            ' Use Regex to extract the number and "KM"
                            Dim match As Match = Regex.Match(inputText, "(\d+KM)")

                            Dim distanceValue As String = ""
                            If match.Success Then
                                distanceValue = match.Groups(1).Value
                                DistanceTextEdit.Text = distanceValue
                                BS.Current!Distance = DistanceTextEdit.Text
                                Console.WriteLine("Extracted Distance: " & distanceValue) ' Output: 1811KM
                            End If
                        Else
                            XtraMessageBox.Show("Error Code: " + IRNResp.InfoDtls(0).InfCd + ": " + IRNResp.InfoDtls(0).Desc, "Info")
                        End If
                    End If
                End If
            End If
            'XtraMessageBox.Show("Distance: " + IRNResp.InfoDtls(0).InfCd + ": " + IRNResp.InfoDtls(0).Desc, "Info")

            'MsgBox(IRNData.IRN)
            Dim imageBytes As Byte() = Convert.FromBase64String(IRNData.QRCodeImage)
                'QRCodeMemoEdit.Text = imageBytes.ToString

                ' Convert the byte array to a Base64 encoded string
                Dim base64String As String = Convert.ToBase64String(imageBytes)

                ' Set the text of QRCodeMemoEdit with the Base64 encoded string
                QRCodeMemoEdit.Text = base64String
                BS.Current!QRCode = QRCodeMemoEdit.Text
                'MsgBox(IRNData.QRCodeImage)
                'File.WriteAllBytes(Application.StartupPath & "/QR.jpg", imageBytes)
                'PictureBox2.Image = Image.FromFile(Application.StartupPath & "/QR.jpg")
                XtraMessageBox.Show("Your E-Invoice created successfully. Now you can take a print", "Info")
                SimpleButton1.PerformClick()
            End If
            File.WriteAllText(FilePath, InvPaylod)
        File.WriteAllText(AppPath & "/IRNData.txt", IRNResp.Data)
        'SimpleButton1.PerformClick()
    End Sub
    Private Sub TxtBoxResp_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxResp.TextChanged
        TxtBoxError.Text = ""
        Dim ShemaResponse As JSonValidatorResponse = ValidateJsonAgainstSchema(TxtBoxResp.Text)
        If ShemaResponse IsNot Nothing Then
            TxtBoxError.Text = ""
            If ShemaResponse.ErrorList IsNot Nothing Then
                If ShemaResponse.ErrorList.Count > 1 Then
                    Dim i As Integer = 0
                    For Each err As String In ShemaResponse.ErrorList
                        'MsgBox(ShemaResponse.ErrorList(0))
                        TxtBoxError.Text += (ShemaResponse.ErrorList(i))
                        TxtBoxError.Text += (" " + vbCrLf)
                        i += 1
                    Next
                    Exit Sub
                Else
                    If ShemaResponse.Valid = False Then
                        TxtBoxError.Text = ShemaResponse.ErrorList(0)
                        TxtBoxError.Text += (" " + vbCrLf)
                        'MsgBox("Something seems to be entered wrong in JSON Field Values, Please check your Payload and try again!!")
                        Exit Sub
                    End If
                End If
            End If
        Else
            Exit Sub
        End If
        If ExMsg <> "" Then
            TxtBoxError.Text = ExMsg
        Else
            TxtBoxError.Text = "Valid JSon File"
        End If
    End Sub
    Public Function ValidateJsonAgainstSchema(ByVal strPayLoad As String) As JSonValidatorResponse
        ExMsg = ""
        AppPath = ConfigurationManager.AppSettings("AppPath")

        Try
            If My.Computer.FileSystem.FileExists(AppPath + "\IrnSchema.json") Then
                Dim strSchema As String = File.ReadAllText(AppPath + "\IrnSchema.json")

                Using file As New StreamReader(AppPath + "\IrnSchema.json")

                    Using reader As New JsonTextReader(file)
                        Dim resolver As New JSchemaUrlResolver()
                        Dim schema As JSchema = JSchema.Load(reader, New JSchemaReaderSettings With {
                        .Resolver = resolver,
                        .BaseUri = New Uri(Application.StartupPath + "\IrnSchema.json")
                    })
                        Dim jobj As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(strPayLoad)
                        Dim errors As IList(Of String) = Nothing
                        Dim valid As Boolean = jobj.IsValid(schema, errors)
                        Return New JSonValidatorResponse() With {
                        .Valid = valid,
                        .ErrorList = errors
                    }
                    End Using
                End Using
            Else
                XtraMessageBox.Show("Please maintain the json file to compare your data againt E-Invoice standard.")
            End If
        Catch ex As Exception
            Dim [error] As String = ex.Message
            ExMsg = ex.Message
            Return New JSonValidatorResponse() With {
                .Valid = False,
                .ErrorList = Nothing
            }
        End Try
    End Function
    Public Class JSonValidatorResponse
        Inherits EventArgs

        Public Property Valid As Boolean
        Public Property ErrorList As IList(Of String)
    End Class
    Public Function ValidateJsonAgainstEWBSchema(ByVal strPayLoad As String) As JSonValidatorResponse
        'ExMsg = ""
        'AppPath = ConfigurationManager.AppSettings("AppPath")

        'Try
        '    If My.Computer.FileSystem.FileExists(AppPath + "\EWBSchema.json") Then
        '        Dim strSchema As String = File.ReadAllText(AppPath + "\EWBSchema.json")

        '        Using file As New StreamReader(AppPath + "\EWBSchema.json")

        '            Using reader As New JsonTextReader(file)
        '                Dim resolver As New JSchemaUrlResolver()
        '                Dim schema As JSchema = JSchema.Load(reader, New JSchemaReaderSettings With {
        '                .Resolver = resolver,
        '                .BaseUri = New Uri(Application.StartupPath + "\EWBSchema.json")
        '            })
        '                Dim jobj As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(strPayLoad)
        '                Dim errors As IList(Of String) = Nothing
        '                Dim valid As Boolean = jobj.IsValid(schema, errors)
        '                Return New JSonValidatorResponse() With {
        '                .Valid = valid,
        '                .ErrorList = errors
        '            }
        '            End Using
        '        End Using
        '    Else
        '        XtraMessageBox.Show("Please maintain the json file to compare your data againt E-Invoice standard.")
        '    End If
        'Catch ex As Exception
        '    Dim [error] As String = ex.Message
        '    ExMsg = ex.Message
        '    Return New JSonValidatorResponse() With {
        '        .Valid = False,
        '        .ErrorList = Nothing
        '    }
        'End Try
    End Function
End Class