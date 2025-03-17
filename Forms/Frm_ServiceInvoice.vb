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
Public Class Frm_ServiceInvoice
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
    Dim AuthRespObj As Object, IRNResp As Object, IRNData As Object
    Dim serializer As New JavaScriptSerializer()
    Dim AuthToken As String, ASPID As String, ASPPwd As String, Gstin As String, eInvUserId As String, eInvPwd As String, SandboxURL As String, AppPath As String
    Shared ExMsg As String
    Dim IsDis As Boolean

    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PanelCtrlMain.Select()
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
        If PubInvoiceType = "Service Invoice" Or PubInvoiceType = "Service Invoice IGST" Then
            PubSupTyp = "B2B"
            ARNNoTextEdit.Enabled = False
            ARNDateDateEdit.Enabled = False
        ElseIf PubInvoiceType = "SEZ Service Invoice IGST" Then
            If PubWithLUT Then
                PubSupTyp = "SEZWOP"
            Else
                PubSupTyp = "SEZWP"
            End If
            ARNNoTextEdit.Enabled = True
            ARNDateDateEdit.Enabled = True
        ElseIf PubInvoiceType = "Export Service Invoice IGST" Then
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

        If PubInvoiceType = "Export Service Invoice IGST" Then
            bz = New CultureInfo("en-US")
            ciUSA = New CultureInfo("en-US")
        Else
            bz = New CultureInfo("hi-IN")
            ciUSA = New CultureInfo("hi-IN")
        End If
    End Sub

    Private Sub PanelCtrlMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles PanelCtrlMain.MouseWheel
        Dim myView As Point = Me.PanelCtrlMain.AutoScrollPosition
        myView.X = (myView.X + 50)
        myView.Y = (myView.Y + 50)
        Me.PanelCtrlMain.AutoScrollPosition = myView
    End Sub
    Sub SetDataTable()
        'ServiceInvoice
        DS.Tables.Add("ServiceInvoice")
        With DS.Tables("ServiceInvoice").Columns
            .Add("ServiceInvoiceID", GetType(Integer))
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
        End With

        With DS.Tables("ServiceInvoice").Columns("ServiceInvoiceID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With

        'ServiceInvoice Detail
        DS.Tables.Add("ServiceInvoiceDetail")
        With DS.Tables("ServiceInvoiceDetail").Columns
            .Add("ServiceInvoiceDetailID", GetType(Integer))
            .Add("ServiceInvoiceID", GetType(Integer))
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

        With DS.Tables("ServiceInvoiceDetail").Columns("ServiceInvoiceDetailID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetRelation()
        DS.Relations.Add(New DataRelation("RelationServiceInvoice", DS.Tables("ServiceInvoice").Columns("ServiceInvoiceID"), DS.Tables("ServiceInvoiceDetail").Columns("ServiceInvoiceID"), False))
        Dim FK_ServiceInvoiceDetail As New Global.System.Data.ForeignKeyConstraint("FK_ServiceInvoice", DS.Tables("ServiceInvoice").Columns("ServiceInvoiceID"), DS.Tables("ServiceInvoiceDetail").Columns("ServiceInvoiceID"))
        DS.Tables("ServiceInvoiceDetail").Constraints.Add(FK_ServiceInvoiceDetail)
        With FK_ServiceInvoiceDetail
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = DS
        BS.DataMember = "ServiceInvoice"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "RelationServiceInvoice"

        InvoiceDetailGridControl.DataSource = BSDetails
    End Sub

    Sub SetQuery()
        ' ServiceInvoice ......................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................
        DA.SelectCommand = New OleDbCommand("Select ServiceInvoiceID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,PartyDCNo,PartyDCDate,PO,PODate,ARNNo,ARNDate,TransportationMode,SupplyTo,SupplyStateCode,AgainstForm,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType,QRCode,IRNNo,AckNo,AckDate From ServiceInvoice Where ServiceInvoiceID=@ServiceInvoiceID", ConStr)
        DA.SelectCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")

        DA.InsertCommand = New OleDbCommand("Insert Into ServiceInvoice (InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,PartyDCNo,PartyDCDate,PO,PODate,ARNNo,ARNDate,TransportationMode,SupplyTo,SupplyStateCode,AgainstForm,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType,QRCode,IRNNo,AckNo,AckDate) Values (@InvoiceNo,@InvoiceDate,@ChallanNo,@ChallanDate,@PartyDCNo,@PartyDCDate,@PO,@PODate,@ARNNo,@ARNDate,@TransportationMode,@SupplyTo,@SupplyStateCode,@AgainstForm,@ReceiverName,@ReceiverAddress,@ReceiverGSTIN,@ReceiverState,@ReceiverStateCode,@ReceiverPanNo,@ConsigneeName,@ConsigneeAddress,@ConsigneeGSTIN,@ConsigneeState,@ConsigneeStateCode,@ConsigneePanNo,@IsSameAddress,@TotalAmtBeforeTax,@PackingCharge,@PCGSTRate,@PCGSTAmt,@PSGSTRate,@PSGSTAmt,@PIGSTRate,@PIGSTAmt,@CGST,@SGST,@IGST,@TotalGSTTax,@TotalAmtAfterTax,@GSTReverseCharge,@TotalInWords,@TaxInWords,@Remarks,@GrandTotalAmount,@RoundOff,@CreatedBy,@ModifiedBy,@Company,@InvoiceType,@QRCode,@IRNNo,@AckNo,@AckDate)", ConStr)
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

        DA.UpdateCommand = New OleDbCommand("Update ServiceInvoice Set InvoiceNo=@InvoiceNo,InvoiceDate=@InvoiceDate,ChallanNo=@ChallanNo,ChallanDate=@ChallanDate,PartyDCNo=@PartyDCNo,PartyDCDate=@PartyDCDate,PO=@PO,PODate=@PODate,ARNNo=@ARNNo,ARNDate=@ARNDate,TransportationMode=@TransportationMode,SupplyTo=@SupplyTo,SupplyStateCode=@SupplyStateCode,AgainstForm=@AgainstForm,ReceiverName=@ReceiverName,ReceiverAddress=@ReceiverAddress,ReceiverGSTIN=@ReceiverGSTIN,ReceiverState=@ReceiverState,ReceiverStateCode=@ReceiverStateCode,ReceiverPanNo=@ReceiverPanNo,ConsigneeName=@ConsigneeName,ConsigneeAddress=@ConsigneeAddress,ConsigneeGSTIN=@ConsigneeGSTIN,ConsigneeState=@ConsigneeState,ConsigneeStateCode=@ConsigneeStateCode,ConsigneePanNo=@ConsigneePanNo,IsSameAddress=@IsSameAddress,TotalAmtBeforeTax=@TotalAmtBeforeTax,PackingCharge=@PackingCharge,PCGSTRate=@PCGSTRate,PCGSTAmt=@PCGSTAmt,PSGSTRate=@PSGSTRate,PSGSTAmt=@PSGSTAmt,PIGSTRate=@PIGSTRate,PIGSTAmt=@PIGSTAmt,CGST=@CGST,SGST=@SGST,IGST=@IGST,TotalGSTTax=@TotalGSTTax,TotalAmtAfterTax=@TotalAmtAfterTax,GSTReverseCharge=@GSTReverseCharge,TotalInWords=@TotalInWords,TaxInWords=@TaxInWords,Remarks=@Remarks,GrandTotalAmount=@GrandTotalAmount,RoundOff=@RoundOff,ModifiedBy=@ModifiedBy,QRCode=@QRCode,IRNNo=@IRNNo,AckNo=@AckNo,AckDate=@AckDate Where ServiceInvoiceID=@ServiceInvoiceID", ConStr)
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
        DA.UpdateCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")

        DA.DeleteCommand = New OleDbCommand("Delete From ServiceInvoice Where ServiceInvoiceID=@ServiceInvoiceID", ConStr)
        DA.DeleteCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")

        ' Invoice Detail ..............................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................

        DADetails.SelectCommand = New OleDbCommand("Select ServiceInvoiceDetailID,ServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount From ServiceInvoiceDetail Where ServiceInvoiceID=@ServiceInvoiceID", ConStr)
        DADetails.SelectCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")

        DADetails.InsertCommand = New OleDbCommand("Insert Into ServiceInvoiceDetail (ServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
        DADetails.InsertCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")
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

        DADetails.UpdateCommand = New OleDbCommand("Update ServiceInvoiceDetail Set ServiceInvoiceID=@ServiceInvoiceID,ProductName=@ProductName,Description=@Description,HSNACS=@HSNACS,UOM=@UOM,Qty=@Qty,Rate=@Rate,IsService=@IsService,Amount=@Amount,Discount=@Discount,DiscountVal=@DiscountVal,TaxableValue=@TaxableValue,CGSTRate=@CGSTRate,CGSTAmt=@CGSTAmt,SGSTRate=@SGSTRate,SGSTAmt=@SGSTAmt,IGSTRate=@IGSTRate,IGSTAmt=@IGSTAmt,TotalAmount=@TotalAmount Where ServiceInvoiceDetailID=@ServiceInvoiceDetailID", ConStr)
        DADetails.UpdateCommand.Parameters.Add("@ServiceInvoiceID", OleDbType.Integer, 4, "ServiceInvoiceID")
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
        DADetails.UpdateCommand.Parameters.Add("@ServiceInvoiceDetailID", OleDbType.Integer, 4, "ServiceInvoiceDetailID")

        DADetails.DeleteCommand = New OleDbCommand("Delete From ServiceInvoiceDetail Where ServiceInvoiceDetailID=@ServiceInvoiceDetailID", ConStr)
        DADetails.DeleteCommand.Parameters.Add("@ServiceInvoiceDetailID", OleDbType.Integer, 4, "ServiceInvoiceDetailID")

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
    End Sub

    Sub InitLookup()
        If PubIGST = False Then
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ReceiverNameComboBoxEdit)
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ConsigneeNameComboBoxEdit)
        ElseIf PubIGST = True Then
            If PubInvoiceType = "SEZ Service Invoice IGST" Then
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ConsigneeNameComboBoxEdit)
            ElseIf PubInvoiceType = "Export Service Invoice IGST" Then
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where Country Not Like 'India'", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where Country Not Like 'India'", "Party", ConsigneeNameComboBoxEdit)
            Else
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ReceiverNameComboBoxEdit)
                SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ConsigneeNameComboBoxEdit)

                'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ReceiverNameComboBoxEdit)
                'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ConsigneeNameComboBoxEdit)
            End If
        End If
        'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ReceiverNameComboBoxEdit)
        'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ConsigneeNameComboBoxEdit)
        GridComboBoxFunc("Select DISTINCT ProductName FROM Product Where CategoryID = 15", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
        GridMemoEditFunc(InvoiceDetailGridControl, InvoiceDetailGridView, "Description")
    End Sub
    Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("ServiceInvoiceDetailID").Visible = False
            .Columns("ServiceInvoiceID").Visible = False
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
            '.Columns("Discount").Caption = "Dis.(%)"
            '.Columns("DiscountVal").Caption = "Dis.(Value)"
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
        'SetCurrencyFormat("Rate", "c", BillDetailGridView, BillDetailGridControl)
        'SetCurrencyFormat("Amount", "c", BillDetailGridView, BillDetailGridControl)
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
        'Dim bz As New CultureInfo("hi-IN")
        Dim GTotal As Double = BS.Current!GrandTotalAmount
        NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)

        InvoiceDateDateEdit.Focus()
        InitLookup()
    End Sub
    Function GetCurrentYear() As String
        Dim DACompany As New OleDbDataAdapter("Select CompanyID,FinancialYear From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As New DataTable
        DACompany.Fill(DTCompany)

        Dim FinancialYear As String = DTCompany.Rows(0).Item("FinancialYear").ToString
        Return FinancialYear
    End Function
    Function GenerateNo() As String
        Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,ServiceInvoiceCount From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        Dim DACompany As New OleDbDataAdapter("Select CompanyID,ServiceInvoicePrefix From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As New DataTable
        DACompany.Fill(DTCompany)

        'Dim FinancialYear As String = DTFinance.Rows(0).Item("FinancialYear").ToString
        Dim InvoiceNo As String = DTFinance.Rows(0).Item("ServiceInvoiceCount").ToString
        len = InvoiceNo.Length()
        'InvoiceNo = (Convert.ToInt32(InvoiceNo)).ToString.PadLeft(3, "0"c)

        Dim ServiceInvoicePrefix As String = DTCompany.Rows(0).Item("ServiceInvoicePrefix").ToString

        InvoiceCount = InvoiceNo

        Dim newPO As String = ServiceInvoicePrefix + "/" + InvoiceCount + "/" + GetCurrentYear()

        Return newPO
    End Function

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick

        'GetLastRecord()
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

        Dim ID = ShowRecord("SELECT * FROM ServiceInvoice Where InvoiceType='" + PubInvoiceType + "' AND (ServiceInvoice.InvoiceDate between #" & SubStart & "# And #" & SubEnd & "#) AND Company ='" + PubCompanyName + "' ORDER BY InvoiceDate DESC", "ServiceInvoiceID")
        'Dim ID = ShowRecord("SELECT * FROM ServiceInvoice Where InvoiceType='" + PubInvoiceType + "' AND Company = '" + PubCompanyName + "' ORDER BY InvoiceDate DESC", "ServiceInvoiceID")
        If ID > 0 Then
            Try
                DS.Tables("ServiceInvoiceDetail").Clear()
                DS.Tables("ServiceInvoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@ServiceInvoiceID").Value = ID
            DA.Fill(DS, "ServiceInvoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@ServiceInvoiceID").Value = ID
            DADetails.Fill(DS, "ServiceInvoiceDetail")
            'Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)

            CurrentInvoiceNo = ID
        End If
    End Sub

    Sub SetCurrentData()
        Dim ID = CurrentInvoiceNo
        If ID > 0 Then
            Try
                DS.Tables("ServiceInvoiceDetail").Clear()
                DS.Tables("ServiceInvoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@ServiceInvoiceID").Value = ID
            DA.Fill(DS, "ServiceInvoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@ServiceInvoiceID").Value = ID
            DADetails.Fill(DS, "ServiceInvoiceDetail")
            'Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record ?" + vbNewLine + "If You Delete This Record then Related Items Record also Delete..", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                For Each row In DS.Tables("ServiceInvoiceDetail").Select("ServiceInvoiceID =" & BS.Current!ServiceInvoiceID)
                    BSDetails.RemoveCurrent()
                    DADetails.Update(DS.Tables("ServiceInvoiceDetail"))
                Next

                BS.RemoveCurrent()
                DA.Update(DS.Tables("ServiceInvoice"))

                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("This Record Is Used In Another Record : Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ErtOccur(ex)
        End Try
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter ServiceInvoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("ServiceInvoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(ServiceInvoiceID) FROM ServiceInvoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into ServiceInvoiceDetail (ServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
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
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            End If
                        End If
                    Next
                    Dim myString As String = InvoiceCount
                    'Dim countOfZeros As String = ""
                    'For Each c As Char In myString
                    '    If c = "0"c Then
                    '        countOfZeros += "0"
                    '    Else
                    '        Exit For
                    '    End If
                    'Next

                    Dim X As Integer = CInt(myString) + 1
                    Dim reCount As String = (Convert.ToInt32(X)).ToString.PadLeft(len, "0"c)
                    'Dim reCount As String = countOfZeros + X.ToString

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set ServiceInvoiceCount=@ServiceInvoiceCount Where Company ='" + PubCompanyName + "'And FinancialYear = '" + GetCurrentYear() + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@ServiceInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("ServiceInvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            End If
                        End If
                    Next
                End If
                AddNew()
            End If
        End If

        'GetLastRecord()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter ServiceInvoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("ServiceInvoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(ServiceInvoiceID) FROM ServiceInvoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    CurrentInvoiceNo = CurrentID
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into ServiceInvoiceDetail (ServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,IsService,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@IsService,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
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
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            End If
                        End If
                    Next
                    Dim myString As String = InvoiceCount
                    'Dim countOfZeros As String = ""
                    'For Each c As Char In myString
                    '    If c = "0"c Then
                    '        countOfZeros += "0"
                    '    Else
                    '        Exit For
                    '    End If
                    'Next

                    Dim X As Integer = CInt(myString) + 1
                    Dim reCount As String = (Convert.ToInt32(X)).ToString.PadLeft(len, "0"c)
                    'Dim reCount As String = countOfZeros + X.ToString

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set ServiceInvoiceCount=@ServiceInvoiceCount Where Company ='" + PubCompanyName + "'And FinancialYear = '" + GetCurrentYear() + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@ServiceInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("ServiceInvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
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
                End If

                If e.Column.FieldName = "DiscountVal" Then
                    Dim Dis As Double = IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal) / IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal)
                    BSDetails.Current!Discount = Math.Round(Dis, 2)
                End If
                If PubInvoiceType = "SEZ Service Invoice IGST" Or PubInvoiceType = "Export Service Invoice IGST" Then
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
        If PubInvoiceType = "SEZ Service Invoice IGST" Or PubInvoiceType = "Export Service Invoice IGST" Then
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
        If PubInvoiceType = "Export Service Invoice IGST" Then
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

            Else
                BS.Current!ConsigneeName = ""
                BS.Current!ConsigneeAddress = ""
                BS.Current!ConsigneeGSTIN = ""
                BS.Current!ConsigneeState = ""
                BS.Current!ConsigneeStateCode = ""
                BS.Current!ConsigneePanNo = ""
            End If
            BS.EndEdit()
        Catch ex As Exception
        End Try
    End Sub

    Public Flag As Integer

    Private Sub PrintBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalPrintBarButtonItem.ItemClick
        'SimpleButton1.PerformClick()
        Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
        Flag = 4

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
    End Sub

    Private Sub PrintDuplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintDuplicateBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
        Flag = 5

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub

    Private Sub PrintTriplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintTriplicateBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
        Flag = 6

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub
    Private Sub PrintOriginalSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalSignBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
        Flag = 9

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
    End Sub

    Private Sub PrintTriplicateSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintTriplicateSignBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
        Flag = 10

        Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen

        Bank.ShowDialog()
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
                Dim CMD As New OleDbCommand("SELECT Count(ServiceInvoiceID) FROM ServiceInvoice WHERE InvoiceNo=@InvoiceNo AND ServiceInvoiceID<>@ServiceInvoiceID", ConStr)
                CMD.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@ServiceInvoiceID", IIf(BS.Current!ServiceInvoiceID Is DBNull.Value, -1, BS.Current!ServiceInvoiceID))
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
                Dim CMD As New OleDbCommand("SELECT Count(ServiceInvoiceID) FROM ServiceInvoice WHERE ChallanNo=@ChallanNo AND ServiceInvoiceID<>@ServiceInvoiceID", ConStr)
                CMD.Parameters.AddWithValue("@ChallanNo", ChallanNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@ServiceInvoiceID", IIf(BS.Current!ServiceInvoiceID Is DBNull.Value, -1, BS.Current!ServiceInvoiceID))
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
        'Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,StartDate,EndDate From FinancialSettings Where Company ='" + PubCompanyName + "'", ConStr)
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

    Private Sub SendEmailSimpleButton_Click(sender As Object, e As EventArgs) Handles SendEmailSimpleButton.Click
        Dim DAParty As New OleDbDataAdapter("Select Email From Party Where PartyName ='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
        Dim DTParty As New DataTable
        DAParty.Fill(DTParty)
        Dim partyEmail As String
        If DTParty.Rows(0).Item("Email") IsNot DBNull.Value Then
            partyEmail = DTParty.Rows(0).Item("Email").ToString()
            'Dim DACompany As New OleDbDataAdapter("Select EmailID1 From Company Where Name ='" + PubCompanyName + "'", ConStr)
            'Dim DTCompany As New DataTable
            'DACompany.Fill(DTCompany)

            'Dim fromEmail As String = DTCompany.Rows(0).Item("EmailID1").ToString
            Dim oMail As New SmtpMail("TryIt")
            oMail.From = ConfigurationManager.AppSettings("Username")
            oMail.To = partyEmail
            oMail.Subject = "Service Invoice Copy"
            oMail.TextBody = " Hi Team
                                Please find attachment of service invoice copy for your reference.
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
            'EInvoiceJson += JsonConvert.SerializeObject(Einvoice, Newtonsoft.Json.Formatting.Indented)
            '  Dim TranDtls As List(Of EInvoiceJsonModule.TranDtls) = New List(Of EInvoiceJsonModule.TranDtls)()
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
            'TranDtls.Add(TranDtl)
            Einvoice.TranDtls = TranDtl
            Dim InvoiceDate As DateTime = BS.Current!InvoiceDate
            Dim output As String = InvoiceDate.ToString("dd-MM-yyyy")
            output = output.Replace("-", "/")

            'Dim DocDtls As List(Of EInvoiceJsonModule.DocDtls) = New List(Of EInvoiceJsonModule.DocDtls)()
            Dim DocDtl As EInvoiceJsonModule.DocDtls = New EInvoiceJsonModule.DocDtls With {
                .Typ = "INV",
                .No = BS.Current!InvoiceNo,
                .Dt = output
                }
            'DocDtls.Add(DocDtl)
            '.Gstin = DTCompany.Rows(0).Item("GSTIN").ToString,
            '.Pin = Convert.ToInt32(DTCompany.Rows(0).Item("Pin").ToString),
            '.Stcd = DTCompany.Rows(0).Item("StateCode").ToString,
            Einvoice.DocDtls = DocDtl
            Dim DACompany As New OleDbDataAdapter("Select CompanyID,GSTIN,Address,StateCode,EmailID1,Phone2,Loc,Pin From Company Where Name ='" + PubCompanyName + "'", ConStr)
            Dim DTCompany As New DataTable
            DACompany.Fill(DTCompany)
            'Dim SellerDtls As List(Of EInvoiceJsonModule.SellerDtls) = New List(Of EInvoiceJsonModule.SellerDtls)()
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
            'SellerDtls.Add(SellerDtl)
            Einvoice.SellerDtls = SellerDtl
            Dim Radd As String
            Radd = BS.Current!ReceiverAddress
            Radd = Trim(Radd)
            If Radd.Length > 99 Then
                Radd = Radd.Substring(0, 99)
                Radd = Trim(Radd)
            End If
            Dim sba As New OleDbDataAdapter("Select Pin,City From Party Where PartyName='" + ReceiverNameComboBoxEdit.Text + "'", ConStr)
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

            Dim ShipDtl As EInvoiceJsonModule.ShipDtls = New EInvoiceJsonModule.ShipDtls With {
                .Gstin = BS.Current!ConsigneeGSTIN,
                .LglNm = BS.Current!ConsigneeName,
                .Addr1 = Cadd,
                .Loc = ccity,
                .Pin = cpin,
                .Stcd = BS.Current!ConsigneeStateCode
                }
            Einvoice.ShipDtls = ShipDtl

            Dim InvoiceNo As String = BS.Current!ServiceInvoiceID
            Dim DAInvDetail As New OleDbDataAdapter("SELECT * FROM SERVICEINVOICEDETAIL WHERE SERVICEINVOICEID =" + InvoiceNo, ConStr)
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

                ''Dim ItemList As EInvoiceJsonModule.ItemList = New EInvoiceJsonModule.ItemList With {
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
                ''Einvoice.ItemList = ItemList               
                'If i = DTInvDetail.Rows.Count - 1 Then
                '    If () Then
                '    End If ' This is the last record, perform the operation with the variable and TotItemVal
                '    ItemLists.Add(New EInvoiceJsonModule.ItemList With {
                '        .SlNo = i + 1,
                '        .IsServc = "N",
                '        .HsnCd = DTInvDetail.Rows(i)("HSNACS"),
                '        .Qty = DTInvDetail.Rows(i)("Qty"),
                '        .Unit = DTInvDetail.Rows(i)("UOM"),
                '        .UnitPrice = DTInvDetail.Rows(i)("Rate"),
                '        .TotAmt = DTInvDetail.Rows(i)("Amount"),
                '        .AssAmt = Convert.ToInt32(DTInvDetail.Rows(i)("TaxableValue")) + BS.Current!PackingCharge,
                '        .GstRt = gstRate,
                '        .TotItemVal = .AssAmt * gstRate / 100
                '    })
                'Else
                '        ' This is not the last record, add the item without modifying TotItemVal
                '        ItemLists.Add(New EInvoiceJsonModule.ItemList With {
                '        .SlNo = i + 1,
                '        .IsServc = "N",
                '        .HsnCd = DTInvDetail.Rows(i)("HSNACS"),
                '        .Qty = DTInvDetail.Rows(i)("Qty"),
                '        .Unit = DTInvDetail.Rows(i)("UOM"),
                '        .UnitPrice = DTInvDetail.Rows(i)("Rate"),
                '        .TotAmt = DTInvDetail.Rows(i)("Amount"),
                '        .AssAmt = DTInvDetail.Rows(i)("TaxableValue"),
                '        .GstRt = gstRate,
                '        .TotItemVal = DTInvDetail.Rows(i)("TotalAmount")
                '    })
                'End If

            Next
            Einvoice.ItemList = ItemLists
            'Dim Item As EInvoiceJsonModule.ItemList = New EInvoiceJsonModule.ItemList With {
            'Dim dt As DataTable = GetData(String.Format("Select InvoiceID, ProductName, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, DiscountVal, TaxableValue, CGSTRate, CGSTAmt, SGSTRate, SGSTAmt, IGSTRate, IGSTAmt, TotalAmount FROM InvoiceDetail Where InvoiceId ='{0}'", CurrentID))

            'SellerDtls.Add(SellerDtl)
            'Einvoice.ItemList = ItemLists

            'EInvoiceJson += JsonConvert.SerializeObject(Einvoice, Newtonsoft.Json.Formatting.Indented)
            Dim ValDtl As EInvoiceJsonModule.ValDtls = New EInvoiceJsonModule.ValDtls With {
                .AssVal = BS.Current!TotalAmtBeforeTax,
                .TotInvVal = BS.Current!GrandTotalAmount,
                .CgstVal = BS.Current!CGST,
                .SgstVal = BS.Current!SGST,
                .IgstVal = BS.Current!IGST
            }
            Einvoice.ValDtls = ValDtl


            EInvoiceJson = JsonConvert.SerializeObject(Einvoice, Newtonsoft.Json.Formatting.Indented)
            TxtBoxResp.Text = EInvoiceJson
            Dim FilePath = ConfigurationManager.AppSettings("AppPath") + "\GenIRN.txt"
            Dim InvPaylod = TxtBoxResp.Text
            File.WriteAllText(FilePath, InvPaylod)
            'Dim buyers As List(Of EInvoiceJsonModule.BuyerDtls) = New List(Of EInvoiceJsonModule.BuyerDtls)()
            'Dim buyer As EInvoiceJsonModule.BuyerDtls = New EInvoiceJsonModule.BuyerDtls With {
            '    .Gstin = Convert.ToString(BS.Current!ReceiverGSTIN),
            '    .LglNm = Convert.ToString(BS.Current!ReceiverName)
            '}
            'buyers.Add(buyer)
            'Dim json As String = JsonConvert.SerializeObject(buyers, Newtonsoft.Json.Formatting.Indented)
            'BS.Current!InvoiceJson = json
            'BS.EndEdit()

        Catch ex As Exception

        End Try

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

        ASPID = ConfigurationManager.AppSettings("ASPID")
        ASPPwd = ConfigurationManager.AppSettings("ASPPwd")
        Gstin = ConfigurationManager.AppSettings("Gstin")
        eInvUserId = ConfigurationManager.AppSettings("TaxproUserName")
        eInvPwd = ConfigurationManager.AppSettings("eInvPwd")
        SandboxURL = ConfigurationManager.AppSettings("TaxproSandboxURL")
        AppPath = ConfigurationManager.AppSettings("AppPath")
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
        'Desearializing Responce in Auth Class
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
        'Call GetAuthToken()
        ''Dim c As New CustomersRest
        ''c.FirstName = "Bill"
        ''c.LastName = "Gates"
        ''c.CustomerID = Guid.Empty
        'Dim RestURL As String = "https://example.com/api/customers/"
        'Dim client As New Http.HttpClient
        'Dim JsonData As String = BS.Current!InvoiceJson
        'Dim RestContent As New System.Net.WebRequestMethods.Http.StringContent(JsonData, Encoding.UTF8, "application/json")
        'Dim RestResponse As Http.HttpResponseMessage = Await client.PostAsync(RestURL, RestContent)
        'Label1.Text = RestResponse.StatusCode.ToString()

        Dim client = New RestClient()
        Dim request = New RestRequest()
        Dim response = New RestResponse()
        AuthToken = Label1.Text
        ASPID = ConfigurationManager.AppSettings("ASPID")
        ASPPwd = ConfigurationManager.AppSettings("ASPPwd")
        Gstin = ConfigurationManager.AppSettings("Gstin")
        eInvUserId = ConfigurationManager.AppSettings("TaxproUserName")
        eInvPwd = ConfigurationManager.AppSettings("eInvPwd")
        SandboxURL = ConfigurationManager.AppSettings("TaxproSandboxURL")
        AppPath = ConfigurationManager.AppSettings("AppPath")
        TxtBoxError.Text = ""
        'TxtBoxResp.Text = File.ReadAllText(Application.StartupPath + "\GenIRN.txt")
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
        If IRNResp.InfoDtls <> Nothing Then
            Dim ErrResp = serializer.Serialize(IRNResp.InfoDtls(0).Desc)
            Dim EwbErrDesc() As IRNClass.Errordetail = serializer.Deserialize(Of IRNClass.Errordetail())(ErrResp)
            TxtBoxError.Text = "InfoCD: " + IRNResp.InfoDtls(0).InfCd + ": " + EwbErrDesc(0).ErrorMessage
        End If
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

End Class