Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports EASendMail
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class Frm_ProformaServiceInvoice

    Dim DS As New DataSet
    Dim DA As New OleDbDataAdapter
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim BSDetails As New BindingSource
    Dim Status As Integer = 0
    Dim NetAmtLabel As New LabelControl
    Dim invoiceCount As String = ""
    Dim len As Integer = 0
    Dim CurrentInvoiceNo As Integer = 0
    Dim IsDis As Boolean
    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PanelCtrlMain.Select()
        SetDataTable()
        SetRelation()
        SetQuery()
        SetBinding()
        SetGrid()
        InitLookup()

        AddNew()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub
    Private Sub PanelCtrlMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles PanelCtrlMain.MouseWheel
        Dim myView As Point = Me.PanelCtrlMain.AutoScrollPosition
        myView.X = (myView.X + 50)
        myView.Y = (myView.Y + 50)
        Me.PanelCtrlMain.AutoScrollPosition = myView
    End Sub
    Sub SetDataTable()
        'Proforma Invoice
        DS.Tables.Add("ProformaServiceInvoice")
        With DS.Tables("ProformaServiceInvoice").Columns
            .Add("ProformaServiceInvoiceID", GetType(Integer))
            .Add("InvoiceNo", GetType(String))
            .Add("InvoiceDate", GetType(Date))
            .Item("InvoiceDate").DefaultValue = Date.Today
            '.Add("ChallanNo", GetType(String))
            '.Add("ChallanDate", GetType(Date))
            .Add("PartyDCNo", GetType(String))
            .Add("PartyDCDate", GetType(Date))
            .Add("PO", GetType(String))
            .Add("PODate", GetType(Date))
            .Add("TransportationMode", GetType(String))
            .Add("SupplyTo", GetType(String))
            .Add("AgainstForm", GetType(String))
            .Add("Packing", GetType(String))
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
        End With

        With DS.Tables("ProformaServiceInvoice").Columns("ProformaServiceInvoiceID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With

        'Proforma Service Invoice Detail
        DS.Tables.Add("ProformaServiceInvoiceDetail")
        With DS.Tables("ProformaServiceInvoiceDetail").Columns
            .Add("ProformaServiceInvoiceDetailID", GetType(Integer))
            .Add("ProformaServiceInvoiceID", GetType(Integer))
            .Add("ProductName", GetType(String))
            .Add("Description", GetType(String))
            .Add("HSNACS", GetType(String))
            .Add("UOM", GetType(String))
            .Add("Qty", GetType(Double))
            .Add("Rate", GetType(Double))
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

        With DS.Tables("ProformaServiceInvoiceDetail").Columns("ProformaServiceInvoiceDetailID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetRelation()
        DS.Relations.Add(New DataRelation("RelationProformaServiceInvoice", DS.Tables("ProformaServiceInvoice").Columns("ProformaServiceInvoiceID"), DS.Tables("ProformaServiceInvoiceDetail").Columns("ProformaServiceInvoiceID"), False))
        Dim FK_ProformaServiceInvoiceDetail As New Global.System.Data.ForeignKeyConstraint("FK_ProformaServiceInvoice", DS.Tables("ProformaServiceInvoice").Columns("ProformaServiceInvoiceID"), DS.Tables("ProformaServiceInvoiceDetail").Columns("ProformaServiceInvoiceID"))
        DS.Tables("ProformaServiceInvoiceDetail").Constraints.Add(FK_ProformaServiceInvoiceDetail)
        With FK_ProformaServiceInvoiceDetail
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = DS
        BS.DataMember = "ProformaServiceInvoice"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "RelationProformaServiceInvoice"

        InvoiceDetailGridControl.DataSource = BSDetails
    End Sub

    Sub SetQuery()
        ' Profroma Service Invoice ......................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................
        DA.SelectCommand = New OleDbCommand("Select ProformaServiceInvoiceID,InvoiceNo,InvoiceDate,PartyDCNo,PartyDCDate,PO,PODate,TransportationMode,SupplyTo,AgainstForm,Packing,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType From ProformaServiceInvoice Where ProformaServiceInvoiceID=@ProformaServiceInvoiceID", ConStr)
        DA.SelectCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")

        DA.InsertCommand = New OleDbCommand("Insert Into ProformaServiceInvoice (InvoiceNo,InvoiceDate,PartyDCNo,PartyDCDate,PO,PODate,TransportationMode,SupplyTo,AgainstForm,Packing,ReceiverName,ReceiverAddress,ReceiverGSTIN,ReceiverState,ReceiverStateCode,ReceiverPanNo,ConsigneeName,ConsigneeAddress,ConsigneeGSTIN,ConsigneeState,ConsigneeStateCode,ConsigneePanNo,IsSameAddress,TotalAmtBeforeTax,PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt,PIGSTRate,PIGSTAmt,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,InvoiceType) Values (@InvoiceNo,@InvoiceDate,@PartyDCNo,@PartyDCDate,@PO,@PODate,@TransportationMode,@SupplyTo,@AgainstForm,@Packing,@ReceiverName,@ReceiverAddress,@ReceiverGSTIN,@ReceiverState,@ReceiverStateCode,@ReceiverPanNo,@ConsigneeName,@ConsigneeAddress,@ConsigneeGSTIN,@ConsigneeState,@ConsigneeStateCode,@ConsigneePanNo,@IsSameAddress,@TotalAmtBeforeTax,@PackingCharge,@PCGSTRate,@PCGSTAmt,@PSGSTRate,@PSGSTAmt,@PIGSTRate,@PIGSTAmt,@CGST,@SGST,@IGST,@TotalGSTTax,@TotalAmtAfterTax,@GSTReverseCharge,@TotalInWords,@TaxInWords,@Remarks,@GrandTotalAmount,@RoundOff,@CreatedBy,@ModifiedBy,@Company,@InvoiceType)", ConStr)
        DA.InsertCommand.Parameters.Add("@InvoiceNo", OleDbType.VarChar, 50, "InvoiceNo")
        DA.InsertCommand.Parameters.Add("@InvoiceDate", OleDbType.Date, 3, "InvoiceDate")
        DA.InsertCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.InsertCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.InsertCommand.Parameters.Add("@PO", OleDbType.VarChar, 50, "PO")
        DA.InsertCommand.Parameters.Add("@PODate", OleDbType.Date, 3, "PODate")
        DA.InsertCommand.Parameters.Add("@TransportationMode", OleDbType.VarChar, 50, "TransportationMode")
        DA.InsertCommand.Parameters.Add("@SupplyTo", OleDbType.VarChar, 50, "SupplyTo")
        DA.InsertCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.InsertCommand.Parameters.Add("@Packing", OleDbType.VarChar, 50, "Packing")
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

        DA.UpdateCommand = New OleDbCommand("Update ProformaServiceInvoice Set InvoiceNo=@InvoiceNo,InvoiceDate=@InvoiceDate,PartyDCNo=@PartyDCNo,PartyDCDate=@PartyDCDate,PO=@PO,PODate=@PODate,TransportationMode=@TransportationMode,SupplyTo=@SupplyTo,AgainstForm=@AgainstForm,Packing=@Packing,ReceiverName=@ReceiverName,ReceiverAddress=@ReceiverAddress,ReceiverGSTIN=@ReceiverGSTIN,ReceiverState=@ReceiverState,ReceiverStateCode=@ReceiverStateCode,ReceiverPanNo=@ReceiverPanNo,ConsigneeName=@ConsigneeName,ConsigneeAddress=@ConsigneeAddress,ConsigneeGSTIN=@ConsigneeGSTIN,ConsigneeState=@ConsigneeState,ConsigneeStateCode=@ConsigneeStateCode,ConsigneePanNo=@ConsigneePanNo,IsSameAddress=@IsSameAddress,TotalAmtBeforeTax=@TotalAmtBeforeTax,PackingCharge=@PackingCharge,PCGSTRate=@PCGSTRate,PCGSTAmt=@PCGSTAmt,PSGSTRate=@PSGSTRate,PSGSTAmt=@PSGSTAmt,PIGSTRate=@PIGSTRate,PIGSTAmt=@PIGSTAmt,CGST=@CGST,SGST=@SGST,IGST=@IGST,TotalGSTTax=@TotalGSTTax,TotalAmtAfterTax=@TotalAmtAfterTax,GSTReverseCharge=@GSTReverseCharge,TotalInWords=@TotalInWords,TaxInWords=@TaxInWords,Remarks=@Remarks,GrandTotalAmount=@GrandTotalAmount,RoundOff=@RoundOff,ModifiedBy=@ModifiedBy Where ProformaServiceInvoiceID=@ProformaServiceInvoiceID", ConStr)
        DA.UpdateCommand.Parameters.Add("@InvoiceNo", OleDbType.VarChar, 50, "InvoiceNo")
        DA.UpdateCommand.Parameters.Add("@InvoiceDate", OleDbType.Date, 3, "InvoiceDate")
        DA.UpdateCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.UpdateCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.UpdateCommand.Parameters.Add("@PO", OleDbType.VarChar, 50, "PO")
        DA.UpdateCommand.Parameters.Add("@PODate", OleDbType.Date, 3, "PODate")
        DA.UpdateCommand.Parameters.Add("@TransportationMode", OleDbType.VarChar, 50, "TransportationMode")
        DA.UpdateCommand.Parameters.Add("@SupplyTo", OleDbType.VarChar, 50, "SupplyTo")
        DA.UpdateCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.UpdateCommand.Parameters.Add("@Packing", OleDbType.VarChar, 50, "Packing")
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
        DA.UpdateCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")

        DA.DeleteCommand = New OleDbCommand("Delete From ProformaServiceInvoice Where ProformaServiceInvoiceID=@ProformaServiceInvoiceID", ConStr)
        DA.DeleteCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")

        ' Proforma Service Invoice Detail ..............................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................

        DADetails.SelectCommand = New OleDbCommand("Select ProformaServiceInvoiceDetailID,ProformaServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount From ProformaServiceInvoiceDetail Where ProformaServiceInvoiceID=@ProformaServiceInvoiceID", ConStr)
        DADetails.SelectCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")

        DADetails.InsertCommand = New OleDbCommand("Insert Into ProformaServiceInvoiceDetail (ProformaServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ProformaServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
        DADetails.InsertCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")
        DADetails.InsertCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.InsertCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.InsertCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.InsertCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
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

        DADetails.UpdateCommand = New OleDbCommand("Update ProformaServiceInvoiceDetail Set ProformaServiceInvoiceID=@ProformaServiceInvoiceID,ProductName=@ProductName,Description=@Description,HSNACS=@HSNACS,UOM=@UOM,Qty=@Qty,Rate=@Rate,Amount=@Amount,Discount=@Discount,DiscountVal=@DiscountVal,TaxableValue=@TaxableValue,CGSTRate=@CGSTRate,CGSTAmt=@CGSTAmt,SGSTRate=@SGSTRate,SGSTAmt=@SGSTAmt,IGSTRate=@IGSTRate,IGSTAmt=@IGSTAmt,TotalAmount=@TotalAmount Where ProformaServiceInvoiceDetailID=@ProformaServiceInvoiceDetailID", ConStr)
        DADetails.UpdateCommand.Parameters.Add("@ProformaServiceInvoiceID", OleDbType.Integer, 4, "ProformaServiceInvoiceID")
        DADetails.UpdateCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.UpdateCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.UpdateCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.UpdateCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.UpdateCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
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
        DADetails.UpdateCommand.Parameters.Add("@ProformaServiceInvoiceDetailID", OleDbType.Integer, 4, "ProformaServiceInvoiceDetailID")

        DADetails.DeleteCommand = New OleDbCommand("Delete From ProformaServiceInvoiceDetail Where ProformaServiceInvoiceDetailID=@ProformaServiceInvoiceDetailID", ConStr)
        DADetails.DeleteCommand.Parameters.Add("@ProformaServiceInvoiceDetailID", OleDbType.Integer, 4, "ProformaServiceInvoiceDetailID")
    End Sub

    Sub SetBinding()
        InvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "InvoiceNo"))
        InvoiceDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "InvoiceDate"))
        PartyDCNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCNo"))
        PartyDCDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCDate"))
        POTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PO"))
        PODateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "PODate"))
        TransportationModeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TransportationMode"))
        SupplyToTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SupplyTo"))
        AgainstFormTextEdit.DataBindings.Add(New Binding("EditValue", BS, "AgainstForm"))
        PackingTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Packing"))
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
        PackingChargeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PackingCharge"))
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
    End Sub

    Sub InitLookup()
        If PubIGST = False Then
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ReceiverNameComboBoxEdit)
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", ConsigneeNameComboBoxEdit)
        ElseIf PubIGST = True Then
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ReceiverNameComboBoxEdit)
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", ConsigneeNameComboBoxEdit)
        End If
        'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ReceiverNameComboBoxEdit)
        'SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", ConsigneeNameComboBoxEdit)
        GridComboBoxFunc("Select DISTINCT ProductName FROM Product", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
        GridMemoEditFunc(InvoiceDetailGridControl, InvoiceDetailGridView, "Description")
        'GridButtonEditFunc(InvoiceDetailGridControl, InvoiceDetailGridView, "AddProduct")
    End Sub

    Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("ProformaServiceInvoiceDetailID").Visible = False
            .Columns("ProformaServiceInvoiceID").Visible = False
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
            .Columns("HSNACS").Caption = "HSN"
            .Columns("Discount").Caption = "Dis.(%)"
            .Columns("DiscountVal").Caption = "Dis.(Value)"
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
        ElseIf POTextEdit.EditValue Is DBNull.Value Then
            POTextEdit.Focus()
            Return False
        ElseIf PODateDateEdit.EditValue Is DBNull.Value Then
            PODateDateEdit.Focus()
            Return False
        ElseIf SupplyToTextEdit.EditValue Is DBNull.Value Then
            SupplyToTextEdit.Focus()
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
        BS.Current!InvoiceType = PubProformaInvoiceType
        BS.Current!InvoiceNo = GenerateNo()
        BS.Current!InvoiceDate = Date.Today
        BS.Current!PODate = Date.Today()
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
        BS.Current!RoundOff = 0
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
        Dim bz As New CultureInfo("hi-IN")
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

        Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,FinancialYear,ProformaServiceInvoiceCount From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)
        Dim DACompany As New OleDbDataAdapter("Select CompanyID,ProformaServiceInvoicePrefix From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As New DataTable
        DACompany.Fill(DTCompany)

        Dim FinancialYear As String = DTFinance.Rows(0).Item("FinancialYear").ToString
        Dim InvoiceNo As String = DTFinance.Rows(0).Item("ProformaServiceInvoiceCount").ToString
        len = InvoiceNo.Length()
        'InvoiceNo = (Convert.ToInt32(InvoiceNo)).ToString.PadLeft(4, "0"c)

        Dim SalesInvoicePrefix As String = DTCompany.Rows(0).Item("ProformaServiceInvoicePrefix").ToString

        invoiceCount = InvoiceNo

        Dim newPO As String = SalesInvoicePrefix + "/" + invoiceCount + "/" + FinancialYear

        Return newPO
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

        'Dim ID = ShowRecord("SELECT * FROM ProformaInvoice Where InvoiceType='" + PubProformaInvoiceType + "' AND (Invoice.InvoiceDate between #" & SubStart & "# And #" & SubEnd & "#) AND Company ='" + PubCompanyName + "' ORDER BY InvoiceDate DESC", "ProformaInvoiceID")
        Dim ID = ShowRecord("SELECT * FROM ProformaServiceInvoice Where InvoiceType='" + PubProformaInvoiceType + "' AND (ProformaServiceInvoice.InvoiceDate between #" & SubStart & "# And #" & SubEnd & "#) AND Company ='" + PubCompanyName + "' ORDER BY InvoiceDate DESC", "ProformaServiceInvoiceID")
        If ID > 0 Then
            Try
                DS.Tables("ProformaServiceInvoiceDetail").Clear()
                DS.Tables("ProformaServiceInvoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@ProformaServiceInvoiceID").Value = ID
            DA.Fill(DS, "ProformaServiceInvoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@ProformaServiceInvoiceID").Value = ID
            DADetails.Fill(DS, "ProformaServiceInvoiceDetail")

            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)

            CurrentInvoiceNo = ID
        End If
    End Sub

    Sub SetCurrentData()
        Dim ID = CurrentInvoiceNo
        If ID > 0 Then
            Try
                DS.Tables("ProformaServiceInvoiceDetail").Clear()
                DS.Tables("ProformaServiceInvoice").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@ProformaServiceInvoiceID").Value = ID
            DA.Fill(DS, "ProformaServiceInvoice")
            Status = 1
            DADetails.SelectCommand.Parameters("@ProformaServiceInvoiceID").Value = ID
            DADetails.Fill(DS, "ProformaServiceInvoiceDetail")

            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)
        End If
    End Sub


    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record ?" + vbNewLine + "If You Delete This Record then Related Items Record also Delete..", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                For Each row In DS.Tables("ProformaServiceInvoiceDetail").Select("ProformaServiceInvoiceID =" & BS.Current!ProformaServiceInvoiceID)
                    BSDetails.RemoveCurrent()
                    DADetails.Update(DS.Tables("ProformaServiceInvoiceDetail"))
                Next

                BS.RemoveCurrent()
                DA.Update(DS.Tables("ProformaServiceInvoice"))

                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ErtOccur(ex)
        End Try
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveNewSimpleButton.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter Proforma Invoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("ProformaServiceInvoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(ProformaServiceInvoiceID) FROM ProformaServiceInvoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into ProformaServiceInvoiceDetail (ProformaServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ProformaServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@ProformaServiceInvoiceID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
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
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                    Dim myString As String = invoiceCount
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

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set ProformaServiceInvoiceCount=@ProformaServiceInvoiceCount Where Company ='" + PubCompanyName + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@ProformaServiceInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("ProformaServiceInvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
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
                XtraMessageBox.Show("Please Enter Proforma Invoice Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("ProformaServiceInvoice"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(ProformaServiceInvoiceID) FROM ProformaServiceInvoice", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    CurrentInvoiceNo = CurrentID
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into ProformaServiceInvoiceDetail (ProformaServiceInvoiceID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@ProformaServiceInvoiceID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@ProformaServiceInvoiceID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
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
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                    Dim myString As String = invoiceCount
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

                    Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set ProformaServiceInvoiceCount=@ProformaServiceInvoiceCount Where Company ='" + PubCompanyName + "'", ConStr)
                    CmpCmd.Parameters.AddWithValue("@ProformaServiceInvoiceCount", reCount)
                    CnnOpen()
                    CmpCmd.ExecuteNonQuery()
                    CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("ProformaServiceInvoiceDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                End If
                XtraMessageBox.Show("Proforma Service Invoice Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

                BSDetails.Current!CGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!CGSTRate Is DBNull.Value, 0, BSDetails.Current!CGSTRate) / 100
                BSDetails.Current!SGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!SGSTRate Is DBNull.Value, 0, BSDetails.Current!SGSTRate) / 100
                BSDetails.Current!IGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!IGSTRate Is DBNull.Value, 0, BSDetails.Current!IGSTRate) / 100

                BSDetails.Current!TotalAmount = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) + IIf(BSDetails.Current!CGSTAmt Is DBNull.Value, 0, BSDetails.Current!CGSTAmt) + IIf(BSDetails.Current!SGSTAmt Is DBNull.Value, 0, BSDetails.Current!SGSTAmt) + IIf(BSDetails.Current!IGSTAmt Is DBNull.Value, 0, BSDetails.Current!IGSTAmt)
                BSDetails.EndEdit()
            End If

            If e.Column.FieldName = "ProductName" Then
                Dim Pname As String
                Pname = DirectCast(BSDetails.Current, DataRowView).Item("ProductName").ToString

                Dim sda As New OleDbDataAdapter("Select UOM, HSNNoOrSACNo, Price, ProductName From Product Where ProductName='" + Pname + "'", ConStr)
                Dim dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count > 0 Then
                    BSDetails.Current!UOM = dt.Rows(0).Item("UOM").ToString
                    BSDetails.Current!HSNACS = dt.Rows(0).Item("HSNNoOrSACNo").ToString
                    BSDetails.Current!Rate = dt.Rows(0).Item("Price").ToString
                    BSDetails.Current!ProductName = dt.Rows(0).Item("ProductName").ToString
                End If
                BSDetails.EndEdit()
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
            Dim bz As New CultureInfo("hi-In")
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

    Dim ciUSA As CultureInfo

    Private Sub InvoiceDetailGridView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs) Handles InvoiceDetailGridView.CustomColumnDisplayText
        If PubInvoiceType = "Export Service Proforma Invoice IGST" Then
            ciUSA = New CultureInfo("en-US")
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
        Else
            ciUSA = New CultureInfo("hi-IN")
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
        End If
        'Try
        '    Dim view As ColumnView = TryCast(sender, ColumnView)
        '    If e.Column.FieldName = "Rate" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim Rate As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", Rate)
        '    End If
        '    If e.Column.FieldName = "Amount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim Amt As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", Amt)
        '    End If
        '    If e.Column.FieldName = "TaxableValue" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim TV As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", TV)
        '    End If
        '    If e.Column.FieldName = "CGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim CGST As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", CGST)
        '    End If
        '    If e.Column.FieldName = "SGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim SGST As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", SGST)
        '    End If
        '    If e.Column.FieldName = "IGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim IGST As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", IGST)
        '    End If
        '    If e.Column.FieldName = "TotalAmount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '        Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
        '        Dim TAmt As Decimal = Convert.ToDecimal(e.Value)
        '        e.DisplayText = String.Format(ciUSA, "{0:c}", TAmt)
        '    End If
        'Catch
        'End Try
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
    Private Sub PCGSTRateTextEdit_LostFocus(sender As Object, e As EventArgs) Handles PCGSTRateTextEdit.LostFocus, PSGSTRateTextEdit.LostFocus, PIGSTRateTextEdit.LostFocus, PackingChargeTextEdit.LostFocus
        BS.EndEdit()
        Calc()
    End Sub

    'Private Sub PackingTextEdit_Leave(sender As Object, e As EventArgs) Handles PCGSTRateTextEdit.Leave, PSGSTRateTextEdit.Leave, PIGSTRateTextEdit.Leave, PackingTextEdit.Leave
    '    Calc()
    'End Sub

    Private Sub Calc()
        Try
            BS.Current!TotalAmtBeforeTax = Math.Round(IIf(InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue Is DBNull.Value, 0, InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue) + IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge), 2)

            BS.Current!PCGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PCGSTRate Is DBNull.Value, 0, BS.Current!PCGSTRate) / 100
            BS.Current!PSGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PSGSTRate Is DBNull.Value, 0, BS.Current!PSGSTRate) / 100
            BS.Current!PIGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PIGSTRate Is DBNull.Value, 0, BS.Current!PIGSTRate) / 100

            BS.Current!CGST = Math.Round(InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue + BS.Current!PCGSTAmt, 2)
            BS.Current!SGST = Math.Round(InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue + BS.Current!PSGSTAmt, 2)
            BS.Current!IGST = Math.Round(InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue + BS.Current!PIGSTAmt, 2)

            BS.Current!TotalGSTTax = Math.Round(BS.Current!CGST + BS.Current!SGST + BS.Current!IGST, 2)
            BS.Current!TotalAmtAfterTax = Math.Round(BS.Current!TotalAmtBeforeTax + BS.Current!TotalGSTTax, 2)

            BS.Current!GrandTotalAmount = Math.Round(BS.Current!TotalAmtAfterTax)

            BS.Current!RoundOff = BS.Current!GrandTotalAmount - BS.Current!TotalAmtAfterTax


            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            Dim TotalTax As Double = BS.Current!TotalGSTTax
            NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)

            'BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal.ToString("c", bz).Remove(0, 1)))
            'BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax.ToString("c", bz).Remove(0, 1)))
            BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal))
            BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax))

            BS.EndEdit()
        Catch

        End Try

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
        Dim InvoiceNo As String = BS.Current!ProformaServiceInvoiceID
        Flag = 1
        Dim Bank As New Frm_SelectBankForProforma(InvoiceNo, Flag, PubIGST, PubProformaInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
    End Sub

    Private Sub PrintOriginalSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalSignBarButtonItem.ItemClick
        Dim InvoiceNo As String = BS.Current!ProformaServiceInvoiceID
        Flag = 2
        Dim Bank As New Frm_SelectBankForProforma(InvoiceNo, Flag, PubIGST, PubProformaInvoiceType, IsDis)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
    End Sub
    'Private Sub PrintTriplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintTriplicateBarButtonItem.ItemClick
    '    Dim InvoiceNo As String = BS.Current!InvoiceID
    '    Flag = 3
    '    Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType, IsDis)
    '    Bank.StartPosition = FormStartPosition.CenterScreen

    '    Bank.ShowDialog()
    'End Sub
    'Dim DACompany As New OleDbDataAdapter
    'Dim DTCompany As New DataTable
    'Dim InvoiceNo As String = BS.Current!ProformaInvoiceID

    'DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo,SupplyFrom From Company Where Name='" + PubCompanyName + "'", ConStr)
    'DACompany.Fill(DTCompany)

    'If PubIGST = False Then
    '    Dim Rpt As New XR_ProformaInvoice
    '    Rpt.Invoice.Value = InvoiceNo
    '    Rpt.Invoice.Visible = False
    '    Rpt.FillDataSource()

    '    'Company Info----
    '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
    '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
    '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
    '    Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
    '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
    '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
    '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
    '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
    '    Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString


    '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
    '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Proforma Invoice -")
    '    End_Waiting()

    '    Rpt.ShowRibbonPreviewDialog()
    'Else
    '    Dim Rpt As New XR_ProformaInvoice
    '    Rpt.Invoice.Value = InvoiceNo
    '    Rpt.Invoice.Visible = False
    '    Rpt.FillDataSource()

    '    'Company Info----
    '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
    '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
    '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
    '    Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
    '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
    '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
    '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
    '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
    '    Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString

    '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
    '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Proforma Invoice-")
    '    End_Waiting()

    '    Rpt.ShowRibbonPreviewDialog()
    'End If
    'End Sub


    'Private Sub PrintDuplicateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintDuplicateBarButtonItem.ItemClick
    '    Dim InvoiceNo As String = BS.Current!InvoiceID
    '    Flag = 2
    '    Dim Bank As New Frm_SelectBank(InvoiceNo, Flag, PubIGST, PubInvoiceType)
    '    Bank.StartPosition = FormStartPosition.CenterScreen

    '    Bank.ShowDialog()
    Private Sub ReceiverNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReceiverNameComboBoxEdit.SelectedIndexChanged

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
                Dim CMD As New OleDbCommand("SELECT Count(ProformaServiceInvoiceID) FROM ProformaServiceInvoice WHERE InvoiceNo=@InvoiceNo AND ProformaServiceInvoiceID<>@ProformaServiceInvoiceID", ConStr)
                CMD.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@ProformaServiceInvoiceID", IIf(BS.Current!ProformaServiceInvoiceID Is DBNull.Value, -1, BS.Current!ProformaServiceInvoiceID))
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SendEmailSimpleButton_Click(sender As Object, e As EventArgs) Handles SendEmailSimpleButton.Click
        Dim DAParty As New OleDbDataAdapter("Select Email From Party Where PartyName ='" + ConsigneeNameComboBoxEdit.Text + "'", ConStr)
        Dim DTParty As New DataTable
        DAParty.Fill(DTParty)
        Dim partyEmail As String = DTParty.Rows(0).Item("Email").ToString()
        If DTParty.Rows(0).Item("Email") IsNot DBNull.Value Then
            partyEmail = DTParty.Rows(0).Item("Email").ToString()
            'Dim DACompany As New OleDbDataAdapter("Select EmailID1 From Company Where Name ='" + PubCompanyName + "'", ConStr)
            'Dim DTCompany As New DataTable
            'DACompany.Fill(DTCompany)

            'Dim fromEmail As String = DTCompany.Rows(0).Item("EmailID1").ToString


            Dim oMail As New SmtpMail("TryIt")
            oMail.From = ConfigurationManager.AppSettings("Username")
            oMail.To = partyEmail
            oMail.Subject = "Invoice Copy"
            oMail.TextBody = " Hi Team
                                Please find attachment of invoice copy for your reference.
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
                MsgBox("Email was sent successfully!")
                Threading.Thread.Sleep(3000)
            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        Else
            XtraMessageBox.Show("Please enter party's email to send email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each filePath As String In OpenFileDialog1.FileNames
            If File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                lblAttachment.Text += fileName + Environment.NewLine
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub



    'Private Sub ChallanNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
    '    If Not ChallanNoTextEdit.EditValue Is DBNull.Value Then
    '        Try
    '            Dim CMD As New OleDbCommand("SELECT Count(InvoiceID) FROM Invoice WHERE ChallanNo=@ChallanNo AND InvoiceID<>@InvoiceID", ConStr)
    '            CMD.Parameters.AddWithValue("@ChallanNo", ChallanNoTextEdit.EditValue)
    '            CMD.Parameters.AddWithValue("@InvoiceID", IIf(BS.Current!InvoiceID Is DBNull.Value, -1, BS.Current!InvoiceID))
    '            CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
    '            If Verify <> 0 Then
    '                XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                ChallanNoTextEdit.Focus()
    '                e.Cancel = True
    '            End If
    '        Catch ex As Exception
    '            'ErtOccur(ex)
    '        End Try
    '    End If
    'End Sub
End Class

