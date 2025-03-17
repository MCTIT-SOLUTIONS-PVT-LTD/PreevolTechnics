Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports EASendMail
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Public Class Frm_Quotation

    Dim DS As New DataSet
    Dim DA As New OleDbDataAdapter
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim BSDetails As New BindingSource
    Dim Status As Integer = 0
    Dim NetAmtLabel As New LabelControl
    Dim quoCount As String = ""
    Dim len As Integer = 0
    Dim CurrentQuotationNo As Integer = 0
    Private Sub Frm_Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PanelCtrlMain.Select()
    End Sub
    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Sub SetDataTable()
        'Quotation
        DS.Tables.Add("Quotation")
        With DS.Tables("Quotation").Columns
            .Add("QuotationID", GetType(Integer))
            .Add("QuotationNo", GetType(String))
            .Add("QuotationDate", GetType(Date))
            .Item("QuotationDate").DefaultValue = Date.Today
            .Add("InquiryNo", GetType(String))
            .Add("InquiryDate", GetType(Date))
            .Item("InquiryDate").DefaultValue = Date.Today
            .Add("PartyDCNo", GetType(String))
            .Add("PartyDCDate", GetType(Date))
            .Item("PartyDCDate").DefaultValue = Date.Today
            .Add("BuyerName", GetType(String))
            .Add("BuyerAddress", GetType(String))
            .Add("BuyerGSTIN", GetType(String))
            .Add("BuyerState", GetType(String))
            .Add("BuyerStateCode", GetType(String))
            .Add("BuyerPanNo", GetType(String))
            .Add("KindlyAttentionTo", GetType(String))
            .Add("TotalAmtBeforeTax", GetType(Double))
            .Add("GST", GetType(Double))
            .Add("TotalGSTTax", GetType(Double))
            .Add("TotalAmtAfterTax", GetType(Double))
            .Add("TotalInWords", GetType(String))
            .Add("TaxInWords", GetType(String))
            .Add("Remarks", GetType(String))
            .Add("GrandTotalAmount", GetType(Double))
            .Add("RoundOff", GetType(Double))
            .Add("CreatedBy", GetType(String))
            .Add("ModifiedBy", GetType(String))
            .Add("PreparedBy", GetType(String))
            .Add("Mobile", GetType(String))
            .Add("PackingCharge", GetType(String))
            .Add("IsGST", GetType(Boolean))
            .Item("IsGST").DefaultValue = False
            .Add("DeliveryTime", GetType(String))
            .Add("NewFOR", GetType(String))
            .Add("PaymentTerm", GetType(String))
            .Add("Warranty", GetType(String))
            .Add("Validity", GetType(String))
            .Add("Company", GetType(String))
            .Add("QuotationType", GetType(String))
            .Add("FormType", GetType(String))
            .Add("ModelNo", GetType(String))

        End With

        With DS.Tables("Quotation").Columns("QuotationID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With

        'Quotation Detail
        DS.Tables.Add("QuotationDetail")
        With DS.Tables("QuotationDetail").Columns
            .Add("QuotationDetailID", GetType(Integer))
            .Add("QuotationID", GetType(Integer))
            .Add("ProductName", GetType(String))
            .Add("CategoryID", GetType(Integer))
            .Add("Description", GetType(String))
            .Add("HSNACS", GetType(String))
            .Add("UOM", GetType(String))
            .Add("Qty", GetType(Double))
            .Add("Rate", GetType(Double))
            .Add("Amount", GetType(Double))
            .Add("Discount", GetType(Double))
            .Add("DiscountVal", GetType(Double))
            .Add("TaxableValue", GetType(Double))
            .Add("GSTRate", GetType(Double))
            .Add("GSTAmt", GetType(Double))
            .Add("TotalAmount", GetType(Double))
        End With

        With DS.Tables("QuotationDetail").Columns("QuotationDetailID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetRelation()
        DS.Relations.Add(New DataRelation("RelationQuotation", DS.Tables("Quotation").Columns("QuotationID"), DS.Tables("QuotationDetail").Columns("QuotationID"), False))
        Dim FK_QuotationDetail As New Global.System.Data.ForeignKeyConstraint("FK_Quotation", DS.Tables("Quotation").Columns("QuotationID"), DS.Tables("QuotationDetail").Columns("QuotationID"))
        DS.Tables("QuotationDetail").Constraints.Add(FK_QuotationDetail)
        With FK_QuotationDetail
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = DS
        BS.DataMember = "Quotation"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "RelationQuotation"

        InvoiceDetailGridControl.DataSource = BSDetails
    End Sub

    Sub SetQuery()
        ' Quotation ......................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................
        DA.SelectCommand = New OleDbCommand("Select QuotationID,QuotationNo,QuotationDate,InquiryNo,InquiryDate,PartyDCNo,PartyDCDate,BuyerName,BuyerAddress,BuyerGSTIN,BuyerState,BuyerStateCode,BuyerPanNo,KindlyAttentionTo,TotalAmtBeforeTax,GST,TotalGSTTax,TotalAmtAfterTax,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,PreparedBy,Mobile,PackingCharge,IsGST,DeliveryTime,NewFOR,PaymentTerm,Warranty,Validity,Company,QuotationType,FormType,ModelNo From Quotation Where QuotationID=@QuotationID", ConStr)
        DA.SelectCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")

        DA.InsertCommand = New OleDbCommand("Insert Into Quotation (QuotationNo,QuotationDate,InquiryNo,InquiryDate,PartyDCNo,PartyDCDate,BuyerName,BuyerAddress,BuyerGSTIN,BuyerState,BuyerStateCode,BuyerPanNo,KindlyAttentionTo,TotalAmtBeforeTax,GST,TotalGSTTax,TotalAmtAfterTax,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,PreparedBy,Mobile,PackingCharge,IsGST,DeliveryTime,NewFOR,PaymentTerm,Warranty,Validity,Company,QuotationType,FormType,ModelNo) Values (@QuotationNo,@QuotationDate,@InquiryNo,@InquiryDate,@PartyDCNo,@PartyDCDate,@BuyerName,@BuyerAddress,@BuyerGSTIN,@BuyerState,@BuyerStateCode,@BuyerPanNo,@KindlyAttentionTo,@TotalAmtBeforeTax,@GST,@TotalGSTTax,@TotalAmtAfterTax,@TotalInWords,@TaxInWords,@Remarks,@GrandTotalAmount,@RoundOff,@CreatedBy,@ModifiedBy,@PreparedBy,@Mobile,@PackingCharge,@IsGST,@DeliveryTime,@NewFOR,@PaymentTerm,@Warranty,@Validity,@Company,@QuotationType,@FormType,@ModelNo)", ConStr)
        DA.InsertCommand.Parameters.Add("@QuotationNo", OleDbType.VarChar, 50, "QuotationNo")
        DA.InsertCommand.Parameters.Add("@QuotationDate", OleDbType.Date, 3, "QuotationDate")
        DA.InsertCommand.Parameters.Add("@InquiryNo", OleDbType.VarChar, 50, "InquiryNo")
        DA.InsertCommand.Parameters.Add("@InquiryDate", OleDbType.Date, 3, "InquiryDate")
        DA.InsertCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.InsertCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.InsertCommand.Parameters.Add("@BuyerName", OleDbType.VarChar, 50, "BuyerName")
        DA.InsertCommand.Parameters.Add("@BuyerAddress", OleDbType.VarChar, 200, "BuyerAddress")
        DA.InsertCommand.Parameters.Add("@BuyerGSTIN", OleDbType.VarChar, 50, "BuyerGSTIN")
        DA.InsertCommand.Parameters.Add("@BuyerState", OleDbType.VarChar, 50, "BuyerState")
        DA.InsertCommand.Parameters.Add("@BuyerStateCode", OleDbType.VarChar, 50, "BuyerStateCode")
        DA.InsertCommand.Parameters.Add("@BuyerPanNo", OleDbType.VarChar, 50, "BuyerPanNo")
        DA.InsertCommand.Parameters.Add("@KindlyAttentionTo", OleDbType.VarChar, 50, "KindlyAttentionTo")
        DA.InsertCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.InsertCommand.Parameters.Add("@GST", OleDbType.Double, 8, "GST")
        DA.InsertCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.InsertCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.InsertCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.InsertCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.InsertCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.InsertCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.InsertCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.InsertCommand.Parameters.Add("@CreatedBy", OleDbType.VarChar, 50, "CreatedBy")
        DA.InsertCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.InsertCommand.Parameters.Add("@PreparedBy", OleDbType.VarChar, 50, "PreparedBy")
        DA.InsertCommand.Parameters.Add("@Mobile", OleDbType.VarChar, 12, "Mobile")
        DA.InsertCommand.Parameters.Add("@PackingCharge", OleDbType.VarChar, 50, "PackingCharge")
        DA.InsertCommand.Parameters.Add("@IsGST", OleDbType.Boolean, 1, "IsGST")
        DA.InsertCommand.Parameters.Add("@DeliveryTime", OleDbType.VarChar, 50, "DeliveryTime")
        DA.InsertCommand.Parameters.Add("@NewFOR", OleDbType.VarChar, 50, "NewFOR")
        DA.InsertCommand.Parameters.Add("@PaymentTerm", OleDbType.VarChar, 100, "PaymentTerm")
        DA.InsertCommand.Parameters.Add("@Warranty", OleDbType.VarChar, 100, "Warranty")
        DA.InsertCommand.Parameters.Add("@Validity", OleDbType.VarChar, 100, "Validity")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")
        DA.InsertCommand.Parameters.Add("@QuotationType", OleDbType.VarChar, 50, "QuotationType")
        DA.InsertCommand.Parameters.Add("@FormType", OleDbType.VarChar, 50, "FormType")
        DA.InsertCommand.Parameters.Add("@ModelNo", OleDbType.VarChar, 50, "ModelNo")


        DA.UpdateCommand = New OleDbCommand("Update Quotation Set QuotationNo=@QuotationNo,QuotationDate=@QuotationDate,InquiryNo=@InquiryNo,InquiryDate=@InquiryDate,PartyDCNo=@PartyDCNo,PartyDCDate=@PartyDCDate,BuyerName=@BuyerName,BuyerAddress=@BuyerAddress,BuyerGSTIN=@BuyerGSTIN,BuyerState=@BuyerState,BuyerStateCode=@BuyerStateCode,BuyerPanNo=@BuyerPanNo,KindlyAttentionTo=@KindlyAttentionTo,TotalAmtBeforeTax=@TotalAmtBeforeTax,GST=@GST,TotalGSTTax=@TotalGSTTax,TotalAmtAfterTax=@TotalAmtAfterTax,TotalInWords=@TotalInWords,TaxInWords=@TaxInWords,Remarks=@Remarks,GrandTotalAmount=@GrandTotalAmount,RoundOff=@RoundOff,ModifiedBy=@ModifiedBy,PreparedBy=@PreparedBy,Mobile=@Mobile,PackingCharge=@PackingCharge,IsGST=@IsGST,DeliveryTime=@DeliveryTime,NewFOR=@NewFOR,PaymentTerm=@PaymentTerm,Warranty=@Warranty,Validity=@Validity,ModelNo=@ModelNo Where QuotationID=@QuotationID", ConStr)
        DA.UpdateCommand.Parameters.Add("@QuotationNo", OleDbType.VarChar, 50, "QuotationNo")
        DA.UpdateCommand.Parameters.Add("@QuotationDate", OleDbType.Date, 3, "QuotationDate")
        DA.UpdateCommand.Parameters.Add("@InquiryNo", OleDbType.VarChar, 50, "InquiryNo")
        DA.UpdateCommand.Parameters.Add("@InquiryDate", OleDbType.Date, 3, "InquiryDate")
        DA.UpdateCommand.Parameters.Add("@PartyDCNo", OleDbType.VarChar, 50, "PartyDCNo")
        DA.UpdateCommand.Parameters.Add("@PartyDCDate", OleDbType.Date, 3, "PartyDCDate")
        DA.UpdateCommand.Parameters.Add("@BuyerName", OleDbType.VarChar, 50, "BuyerName")
        DA.UpdateCommand.Parameters.Add("@BuyerAddress", OleDbType.VarChar, 200, "BuyerAddress")
        DA.UpdateCommand.Parameters.Add("@BuyerGSTIN", OleDbType.VarChar, 50, "BuyerGSTIN")
        DA.UpdateCommand.Parameters.Add("@BuyerState", OleDbType.VarChar, 50, "BuyerState")
        DA.UpdateCommand.Parameters.Add("@BuyerStateCode", OleDbType.VarChar, 50, "BuyerStateCode")
        DA.UpdateCommand.Parameters.Add("@BuyerPanNo", OleDbType.VarChar, 50, "BuyerPanNo")
        DA.UpdateCommand.Parameters.Add("@KindlyAttentionTo", OleDbType.VarChar, 50, "KindlyAttentionTo")
        DA.UpdateCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.UpdateCommand.Parameters.Add("@GST", OleDbType.Double, 8, "GST")
        DA.UpdateCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.UpdateCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.UpdateCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.UpdateCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.UpdateCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.UpdateCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.UpdateCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.UpdateCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.UpdateCommand.Parameters.Add("@PreparedBy", OleDbType.VarChar, 50, "PreparedBy")
        DA.UpdateCommand.Parameters.Add("@Mobile", OleDbType.VarChar, 50, "Mobile")
        DA.UpdateCommand.Parameters.Add("@PackingCharge", OleDbType.VarChar, 50, "PackingCharge")
        DA.UpdateCommand.Parameters.Add("@IsGST", OleDbType.Boolean, 1, "IsGST")
        DA.UpdateCommand.Parameters.Add("@DeliveryTime", OleDbType.VarChar, 50, "DeliveryTime")
        DA.UpdateCommand.Parameters.Add("@NewFOR", OleDbType.VarChar, 50, "NewFOR")
        DA.UpdateCommand.Parameters.Add("@PaymentTerm", OleDbType.VarChar, 100, "PaymentTerm")
        DA.UpdateCommand.Parameters.Add("@Warranty", OleDbType.VarChar, 100, "Warranty")
        DA.UpdateCommand.Parameters.Add("@Validity", OleDbType.VarChar, 100, "Validity")
        DA.UpdateCommand.Parameters.Add("@ModelNo", OleDbType.VarChar, 50, "ModelNo")
        DA.UpdateCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")

        DA.DeleteCommand = New OleDbCommand("Delete From Quotation Where QuotationID=@QuotationID", ConStr)
        DA.DeleteCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")

        'Quotation Detail ..............................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................

        DADetails.SelectCommand = New OleDbCommand("Select QuotationDetailID,QuotationID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,GSTRate,GSTAmt,TotalAmount From QuotationDetail Where QuotationID=@QuotationID", ConStr)
        DADetails.SelectCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")

        DADetails.InsertCommand = New OleDbCommand("Insert Into QuotationDetail (QuotationID,ProductName,CategoryID,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,GSTRate,GSTAmt,TotalAmount) Values (@QuotationID,@ProductName,@CategoryID,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@GSTRate,@GSTAmt,@TotalAmount)", ConStr)
        DADetails.InsertCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")
        DADetails.InsertCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.InsertCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DADetails.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.InsertCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.InsertCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.InsertCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.InsertCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.InsertCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.InsertCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.InsertCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.InsertCommand.Parameters.Add("@GSTRate", OleDbType.Double, 8, "GSTRate")
        DADetails.InsertCommand.Parameters.Add("@GSTAmt", OleDbType.Double, 8, "GSTAmt")
        DADetails.InsertCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")

        DADetails.UpdateCommand = New OleDbCommand("Update QuotationDetail Set QuotationID=@QuotationID,ProductName=@ProductName,CategoryID=@CategoryID,Description=@Description,HSNACS=@HSNACS,UOM=@UOM,Qty=@Qty,Rate=@Rate,Amount=@Amount,Discount=@Discount,DiscountVal=@DiscountVal,TaxableValue=@TaxableValue,GSTRate=@GSTRate,GSTAmt=@GSTAmt,TotalAmount=@TotalAmount Where QuotationDetailID=@QuotationDetailID", ConStr)
        DADetails.UpdateCommand.Parameters.Add("@QuotationID", OleDbType.Integer, 4, "QuotationID")
        DADetails.UpdateCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.UpdateCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DADetails.UpdateCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.UpdateCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.UpdateCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.UpdateCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.UpdateCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.UpdateCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.UpdateCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.UpdateCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.UpdateCommand.Parameters.Add("@GSTRate", OleDbType.Double, 8, "GSTRate")
        DADetails.UpdateCommand.Parameters.Add("@GSTAmt", OleDbType.Double, 8, "GSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")
        DADetails.UpdateCommand.Parameters.Add("@QuotationDetailID", OleDbType.Integer, 4, "QuotationDetailID")

        DADetails.DeleteCommand = New OleDbCommand("Delete From QuotationDetail Where QuotationDetailID=@QuotationDetailID", ConStr)
        DADetails.DeleteCommand.Parameters.Add("@QuotationDetailID", OleDbType.Integer, 4, "QuotationDetailID")
    End Sub

    Sub SetBinding()
        InvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotationNo"))
        InvoiceDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotationDate"))
        InquiryTextEdit.DataBindings.Add(New Binding("EditValue", BS, "InquiryNo"))
        InquiryDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "InquiryDate"))
        PartyDCNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCNo"))
        PartyDCDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyDCDate"))
        BuyerNameComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerName"))
        BuyerAddressTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerAddress"))
        BuyerGSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerGSTIN"))
        BuyerStateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerState"))
        BuyerStateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerStateCode"))
        BuyerPANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BuyerPanNo"))
        KindlyAttentionTextEdit.DataBindings.Add(New Binding("EditValue", BS, "KindlyAttentionTo"))
        TotalAmtBeforeTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtBeforeTax"))
        PackingTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PackingCharge"))
        WithGSTCheckEdit.DataBindings.Add(New Binding("EditValue", BS, "IsGST"))
        DeliveryTimeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "DeliveryTime"))
        FORTextEdit.DataBindings.Add(New Binding("EditValue", BS, "NewFOR"))
        PaymentTermTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PaymentTerm"))
        WarrantyTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Warranty"))
        ValidityTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Validity"))
        GSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GST"))
        TotalGSTTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalGSTTax"))
        TotalAmtAfterTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtAfterTax"))
        TotalInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalInWords"))
        TaxInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TaxInWords"))
        RemarksTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Remarks"))
        NetAmtLabel.DataBindings.Add(New Binding("Text", BS, "GrandTotalAmount"))
        CreatedByTextEdit.DataBindings.Add(New Binding("Text", BS, "CreatedBy"))
        ModifiedByTextEdit.DataBindings.Add(New Binding("Text", BS, "ModifiedBy"))
        PreparedByTextEdit.DataBindings.Add(New Binding("Text", BS, "PreparedBy"))
        MobileTextEdit.DataBindings.Add(New Binding("Text", BS, "Mobile"))
        ModelNoTextEdit.DataBindings.Add(New Binding("Text", BS, "ModelNo"))


    End Sub

    Sub InitLookup()
        If PubIGST = False Then
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode = 24 ", "Party", BuyerNameComboBoxEdit)
        ElseIf PubIGST = True Then
            SetGridCommboBox("SELECT DISTINCT PartyName FROM Party Where StateCode <> 24 ", "Party", BuyerNameComboBoxEdit)
        End If
        GridComboBoxFunc("Select DISTINCT ProductName FROM Product", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
        GridMemoEditFunc(InvoiceDetailGridControl, InvoiceDetailGridView, "Description")
    End Sub

    Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("QuotationDetailID").Visible = False
            .Columns("QuotationID").Visible = False
            .Columns("CategoryID").Visible = False
            .Columns("Amount").OptionsColumn.AllowFocus = False
            .Columns("Amount").OptionsColumn.ReadOnly = True
            .Columns("TaxableValue").OptionsColumn.AllowFocus = False
            .Columns("TaxableValue").OptionsColumn.ReadOnly = True
            .Columns("GSTAmt").OptionsColumn.AllowFocus = False
            .Columns("GSTAmt").OptionsColumn.ReadOnly = True
            .Columns("TotalAmount").OptionsColumn.AllowFocus = False
            .Columns("TotalAmount").OptionsColumn.ReadOnly = True
            .Columns("ProductName").Width = 200
            .Columns("ProductName").Caption = "Product"
            .Columns("Description").Caption = "Description"
            .Columns("Description").Width = 200
            .Columns("HSNACS").Caption = "HSN"
            .Columns("Discount").Caption = "Dis.(%)"
            .Columns("DiscountVal").Caption = "Dis.(Value)"
            .Columns("GSTRate").Caption = "GST(%)"
            .OptionsView.ShowFooter = True
            .Columns("TaxableValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("GSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("TotalAmount").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum

            .Columns("Qty").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("DiscountVal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With

        InvoiceDetailGridView.BestFitColumns()
        InvoiceDetailGridView.FocusedColumn = InvoiceDetailGridView.Columns(2)
        BSDetails.ResetBindings(True)

        If PubDis = False Then
            InvoiceDetailGridView.Columns("Discount").Visible = True
            InvoiceDetailGridView.Columns("DiscountVal").Visible = True
        ElseIf PubDis = True Then
            InvoiceDetailGridView.Columns("Discount").Visible = False
            InvoiceDetailGridView.Columns("DiscountVal").Visible = False
        End If
    End Sub

    Function Validation() As Boolean
        If InvoiceNoTextEdit.EditValue Is DBNull.Value Then
            InvoiceNoTextEdit.Focus()
            Return False
        ElseIf InvoiceDateDateEdit.EditValue Is DBNull.Value Then
            InvoiceDateDateEdit.Focus()
            Return False
        ElseIf BuyerNameComboBoxEdit.EditValue Is DBNull.Value Then
            BuyerNameComboBoxEdit.Focus()
            Return False
        ElseIf PackingTextEdit.EditValue Is DBNull.Value And DeliveryTimeTextEdit.EditValue Is DBNull.Value And FORTextEdit.EditValue Is DBNull.Value And PaymentTermTextEdit.EditValue Is DBNull.Value And WarrantyTextEdit.EditValue Is DBNull.Value And ValidityTextEdit.EditValue Is DBNull.Value Then
            PackingTextEdit.Focus()
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
        BS.Current!QuotationType = PubQuotationType
        BS.Current!FormType = PubFormType
        BS.Current!QuotationNo = GenerateNo()
        BS.Current!QuotationDate = Date.Today()
        BS.Current!InquiryDate = Date.Today()
        BS.Current!PartyDCDate = Date.Today()
        BS.Current!TotalAmtBeforeTax = 0
        BS.Current!GST = 0
        BS.Current!TotalGSTTax = 0
        BS.Current!TotalAmtAfterTax = 0
        BS.Current!RoundOff = 0
        BS.Current!GrandTotalAmount = 0
        BS.EndEdit()

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

        Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,QuotationCount From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        Dim DACompany As New OleDbDataAdapter("Select CompanyID,QuotationPrefix From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As New DataTable
        DACompany.Fill(DTCompany)
        'Dim FinancialYear As String = DTCompany.Rows(0).Item("FinancialYear").ToString
        Dim QuoNo As String = DTFinance.Rows(0).Item("QuotationCount").ToString
        len = QuoNo.Length()

        'QuoNo = (Convert.ToInt32(QuoNo)).ToString.PadLeft(4, "0"c)

        Dim QuoPrefix As String = DTCompany.Rows(0).Item("QuotationPrefix").ToString

        quoCount = QuoNo

        Dim newPO As String = QuoPrefix + "/" + quoCount + "/" + GetCurrentYear()

        Return newPO
        'Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,FinancialYear From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        'Dim DTFinance As New DataTable
        'DAFinance.Fill(DTFinance)

        'Dim POCMD As New OleDbCommand("SELECT COUNT(QuotationID) FROM Quotation Where Company = '" + PubCompanyName + "'", ConStr)
        'CnnOpen() : Dim autoPO = Val(POCMD.ExecuteScalar & "") : CnnClose()
        'autoPO = autoPO + 1

        'Dim FinancialYear As String = DTFinance.Rows(0).Item("FinancialYear").ToString
        'Dim QuotationPrefix As String = "Quo"

        'Dim newPO As String = QuotationPrefix + "/" + autoPO.ToString() + "/" + FinancialYear
        'Return newPO
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

        Dim ID = ShowRecord("SELECT * FROM Quotation Where QuotationType='" + PubQuotationType + "'AND FormType='" + PubFormType + "' AND (Quotation.QuotationDate between #" & SubStart & "# And #" & SubEnd & "#) AND Company ='" + PubCompanyName + "' ORDER BY QuotationDate DESC", "QuotationID")
        If ID > 0 Then
            Try
                DS.Tables("QuotationDetail").Clear()
                DS.Tables("Quotation").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@QuotationID").Value = ID
            DA.Fill(DS, "Quotation")
            Status = 1
            DADetails.SelectCommand.Parameters("@QuotationID").Value = ID
            DADetails.Fill(DS, "QuotationDetail")
            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)

            CurrentQuotationNo = ID
        End If
    End Sub


    Sub SetCurrentData()
        Dim ID = CurrentQuotationNo
        If ID > 0 Then
            Try
                DS.Tables("QuotationDetail").Clear()
                DS.Tables("Quotation").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@QuotationID").Value = ID
            DA.Fill(DS, "Quotation")
            Status = 1
            DADetails.SelectCommand.Parameters("@QuotationID").Value = ID
            DADetails.Fill(DS, "QuotationDetail")

            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record ?" + vbNewLine + "If You Delete This Record then Related Items Record also Delete..", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                For Each row In DS.Tables("QuotationDetail").Select("QuotationID =" & BS.Current!QuotationID)
                    BSDetails.RemoveCurrent()
                    DADetails.Update(DS.Tables("QuotationDetail"))
                Next

                BS.RemoveCurrent()
                DA.Update(DS.Tables("Quotation"))

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
                XtraMessageBox.Show("Please Enter Quotation Items", "Info")
            Else
                SaveQuo()
                'If Not PubDis Then
                '    Dim count As Integer = 0
                '    Dim st As Boolean
                '    st = False
                '    For count = 0 To BSDetails.Count - 1
                '        If BSDetails.Current!Discount > 0 Then
                '            st = True
                '            Exit For
                '        End If
                '    Next

                '    If st = False Then
                '        Dim result As DialogResult = XtraMessageBox.Show("You have select With Discount but not entered any discount value. Do u still want to continue to save?" & vbCrLf & vbCrLf & "Click Yes to Save and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                '        If result = DialogResult.Yes Then
                '            SaveQuo()
                '            'SetCurrentData()
                '        End If
                '    Else
                '        SaveQuo()
                '        'SetCurrentData()
                '    End If
                'Else
                '    SaveQuo()
                '    'SetCurrentData()
                'End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter Quotation Items", "Info")
            Else
                'If Not PubDis Then
                '    Dim count As Integer = 0
                '    Dim st As Boolean
                '    st = False
                '    For count = 0 To BSDetails.Count - 1
                '        If BSDetails.Current!Discount > 0 Then
                '            st = True
                '            Exit For
                '        End If
                '    Next

                '    If st = False Then
                '        Dim result As DialogResult = XtraMessageBox.Show("You have select With Discount but not entered any discount value. Do u still want to continue to save?" & vbCrLf & vbCrLf & "Click Yes to Save and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                '        If result = DialogResult.Yes Then
                '            SaveQuo()
                '            SetCurrentData()
                '        End If
                '    Else
                '        SaveQuo()
                '        SetCurrentData()
                '    End If
                'Else
                '    SaveQuo()
                '    SetCurrentData()
                'End If
                SaveQuo()
                SetCurrentData()
            End If
        End If
    End Sub
    Private Sub SaveQuo()
        BS.Current!ModifiedBy = CurrentUserName
        BS.EndEdit()
        DA.Update(DS.Tables("Quotation"))

        If Status = 0 Then
            Dim NewCMD As New OleDbCommand("SELECT MAX(QuotationID) FROM Quotation", ConStr)
            CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
            BSDetails.MoveFirst()
            CurrentQuotationNo = CurrentID
            For item As Integer = 0 To BSDetails.Count - 1
                Dim InsertCMD As New OleDbCommand("Insert Into QuotationDetail (QuotationID,ProductName,CategoryID,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,GSTRate,GSTAmt,TotalAmount) Values (@QuotationID,@ProductName,@CategoryID,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@GSTRate,@GSTAmt,@TotalAmount)", ConStr)
                InsertCMD.Parameters.AddWithValue("@QuotationID", CurrentID)
                InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                InsertCMD.Parameters.AddWithValue("@CategoryID", BSDetails.Current!CategoryID)
                InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
                InsertCMD.Parameters.AddWithValue("@Amount", BSDetails.Current!Amount)
                InsertCMD.Parameters.AddWithValue("@Discount", BSDetails.Current!Discount)
                InsertCMD.Parameters.AddWithValue("@DiscountVal", BSDetails.Current!DiscountVal)
                InsertCMD.Parameters.AddWithValue("@TaxableValue", BSDetails.Current!TaxableValue)
                InsertCMD.Parameters.AddWithValue("@GSTRate", BSDetails.Current!GSTRate)
                InsertCMD.Parameters.AddWithValue("@GSTAmt", BSDetails.Current!GSTAmt)
                InsertCMD.Parameters.AddWithValue("@TotalAmount", BSDetails.Current!TotalAmount)

                CnnOpen() : InsertCMD.ExecuteNonQuery() : CnnClose()

                BSDetails.MoveNext()
            Next
            Dim myString As String = quoCount
            Dim X As Integer = CInt(myString) + 1
            Dim reCount As String = (Convert.ToInt32(X)).ToString.PadLeft(len, "0"c)
            Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set QuotationCount=@QuotationCount Where Company ='" + PubCompanyName + "' And FinancialYear = '" + GetCurrentYear() + "'", ConStr)
            CmpCmd.Parameters.AddWithValue("@QuotationCount", reCount)
            CnnOpen()
            CmpCmd.ExecuteNonQuery()
            CnnClose()
        ElseIf Status = 1 Then
            BSDetails.EndEdit()
            DADetails.Update(DS.Tables("QuotationDetail"))
        End If
        XtraMessageBox.Show("Quotation Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        AddNew()
        'SetCurrentData()
    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub InvoiceDetailGridControl_Leave(sender As Object, e As EventArgs) Handles InvoiceDetailGridControl.Leave
        BS.Current!TotalAmtBeforeTax = InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue

        BS.Current!GST = InvoiceDetailGridView.Columns("GSTAmt").SummaryItem.SummaryValue
        'BS.Current!SGST = InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue
        'BS.Current!IGST = InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue

        BS.Current!TotalGSTTax = BS.Current!GST
        BS.Current!TotalAmtAfterTax = InvoiceDetailGridView.Columns("TotalAmount").SummaryItem.SummaryValue
        BS.EndEdit()
        Calc()
    End Sub
    Private Sub InvoiceDetailGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles InvoiceDetailGridView.CellValueChanged
        Try
            If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "DiscountVal" Or e.Column.FieldName = "GSTRate" Then
                Dim qty As Double = IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)
                BSDetails.Current!Qty = Math.Round(qty, 2)

                BSDetails.Current!Amount = IIf(BSDetails.Current!Rate Is DBNull.Value, 0, BSDetails.Current!Rate) * IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)

                If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "GSTRate" Then
                    Dim Amt As Double = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount) / 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - Amt
                    'New change for cal dis
                    BSDetails.Current!Discount = IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount)
                End If

                If e.Column.FieldName = "DiscountVal" Then
                    Dim Dis As Double = IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal) / IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal)
                    BSDetails.Current!Discount = Math.Round(Dis, 2)
                End If

                BSDetails.Current!GSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!GSTRate Is DBNull.Value, 0, BSDetails.Current!GSTRate) / 100

                BSDetails.Current!TotalAmount = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) + IIf(BSDetails.Current!GSTAmt Is DBNull.Value, 0, BSDetails.Current!GSTAmt)
                BSDetails.EndEdit()
            End If

            If e.Column.FieldName = "ProductName" Or e.Column.FieldName = "Description" Or e.Column.FieldName = "HSNACS" Or e.Column.FieldName = "UOM" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Rate" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "DiscountVal" Or e.Column.FieldName = "GSTRate" Then
                If e.Column.FieldName = "ProductName" Then
                    Dim Pname As String
                    Pname = DirectCast(BSDetails.Current, DataRowView).Item("ProductName").ToString
                    Dim sda As New OleDbDataAdapter("Select UOM, HSNNoOrSACNo, Price, ProductName,CategoryID From Product Where ProductName='" + Pname + "'", ConStr)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        BSDetails.Current!UOM = dt.Rows(0).Item("UOM").ToString
                        BSDetails.Current!HSNACS = dt.Rows(0).Item("HSNNoOrSACNo").ToString
                        If dt.Rows(0).Item("Price").ToString = "" Then

                        Else
                            BSDetails.Current!Rate = dt.Rows(0).Item("Price").ToString
                        End If
                        BSDetails.Current!ProductName = dt.Rows(0).Item("ProductName").ToString
                        BSDetails.Current!CategoryID = dt.Rows(0).Item("CategoryID")
                    End If
                    BSDetails.EndEdit()
                Else
                    Dim Pname1 As String
                    Pname1 = DirectCast(BSDetails.Current, DataRowView).Item("ProductName").ToString
                    Dim sda1 As New OleDbDataAdapter("Select CategoryID From Product Where ProductName='" + Pname1 + "'", ConStr)
                    Dim dt1 As New DataTable()
                    sda1.Fill(dt1)
                    If dt1.Rows.Count > 0 Then
                        'BSDetails.Current!UOM = dt.Rows(0).Item("UOM").ToString
                        'BSDetails.Current!HSNACS = dt.Rows(0).Item("HSNNoOrSACNo").ToString
                        'If dt.Rows(0).Item("Price").ToString = "" Then

                        'Else
                        '    BSDetails.Current!Rate = dt.Rows(0).Item("Price").ToString
                        'End If
                        'BSDetails.Current!ProductName = dt.Rows(0).Item("ProductName").ToString
                        BSDetails.Current!CategoryID = dt1.Rows(0).Item("CategoryID")
                    End If
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

    Dim ciUSA As CultureInfo = New CultureInfo("hi-IN")

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
            If e.Column.FieldName = "GSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim GST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", GST)
            End If
            'If e.Column.FieldName = "SGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            '    Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
            '    Dim SGST As Decimal = Convert.ToDecimal(e.Value)
            '    e.DisplayText = String.Format(ciUSA, "{0:c}", SGST)
            'End If
            'If e.Column.FieldName = "IGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            '    Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
            '    Dim IGST As Decimal = Convert.ToDecimal(e.Value)
            '    e.DisplayText = String.Format(ciUSA, "{0:c}", IGST)
            'End If
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
    Private Sub PCGSTRateTextEdit_LostFocus(sender As Object, e As EventArgs)
        BS.EndEdit()
        Calc()
    End Sub

    Private Sub PackingTextEdit_Leave(sender As Object, e As EventArgs) Handles PackingTextEdit.Leave
        Calc()
    End Sub

    Private Sub Calc()
        Try
            'BS.Current!TotalAmtBeforeTax = Math.Round(IIf(InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue Is DBNull.Value, 0, InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue) + IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge), 2)
            BS.Current!TotalAmtBeforeTax = Math.Round(IIf(InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue Is DBNull.Value, 0, InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue), 2)

            'BS.Current!PCGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PCGSTRate Is DBNull.Value, 0, BS.Current!PCGSTRate) / 100
            'BS.Current!PSGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PSGSTRate Is DBNull.Value, 0, BS.Current!PSGSTRate) / 100
            'BS.Current!PIGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PIGSTRate Is DBNull.Value, 0, BS.Current!PIGSTRate) / 100

            'BS.Current!CGST = Math.Round(InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue + BS.Current!PCGSTAmt, 2)
            'BS.Current!SGST = Math.Round(InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue + BS.Current!PSGSTAmt, 2)
            'BS.Current!IGST = Math.Round(InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue + BS.Current!PIGSTAmt, 2)

            BS.Current!GST = Math.Round(InvoiceDetailGridView.Columns("GSTAmt").SummaryItem.SummaryValue, 2)
            'BS.Current!SGST = Math.Round(InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue, 2)
            'BS.Current!IGST = Math.Round(InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue, 2)

            BS.Current!TotalGSTTax = Math.Round(BS.Current!GST, 2)
            BS.Current!TotalAmtAfterTax = Math.Round(BS.Current!TotalAmtBeforeTax + BS.Current!TotalGSTTax, 2)

            BS.Current!GrandTotalAmount = Math.Round(BS.Current!TotalAmtAfterTax)

            BS.Current!RoundOff = Math.Round(BS.Current!GrandTotalAmount - BS.Current!TotalAmtAfterTax, 2)


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
    Public Flag As Integer

    Private Sub PrintBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalPrintBarButtonItem.ItemClick
        Dim QuotationNo As String = BS.Current!QuotationID
        Flag = 1
        Dim Bank As New Frm_SelectBankForQuotation(QuotationNo, Flag, PubDis, PubQuotationType)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
        'Dim DACompany As New OleDbDataAdapter
        'Dim DTCompany As New DataTable
        'Dim QuoNo As String = BS.Current!QuotationID

        'DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo From Company Where Name='" + PubCompanyName + "'", ConStr)
        'DACompany.Fill(DTCompany)

        'If PubIGST = False Then
        '    Dim Rpt As New XR_Quotation
        '    Rpt.Invoice.Value = QuoNo
        '    Rpt.Invoice.Visible = False
        '    Rpt.FillDataSource()
        '    'Rpt.XrLabel76.Text = "✔"
        '    'Company Info----
        '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
        '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
        '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
        '    Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
        '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
        '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
        '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
        '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
        '    If WithGSTCheckEdit.Checked = True Then
        '        Rpt.lblAddGST.Text = "+ GST"
        '    Else
        '        Rpt.lblAddGST.Text = ""
        '    End If

        '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
        '        ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
        '        End_Waiting()

        '        Rpt.ShowRibbonPreviewDialog()
        '    Else
        '        Dim Rpt As New XR_Quotation
        '    Rpt.Invoice.Value = QuoNo
        '    Rpt.Invoice.Visible = False
        '    Rpt.FillDataSource()
        '    'Rpt.XrLabel76.Text = "✔"
        '    'Company Info----
        '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
        '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
        '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
        '    Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
        '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
        '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
        '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
        '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString

        '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
        '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
        '    End_Waiting()

        '    Rpt.ShowRibbonPreviewDialog()
        'End If
    End Sub
    Private Sub PrintSignOriginalBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintSignOriginalBarButtonItem.ItemClick
        Dim QuotationNo As String = BS.Current!QuotationID
        Flag = 2
        Dim Bank As New Frm_SelectBankForQuotation(QuotationNo, Flag, PubDis, PubQuotationType)
        Bank.StartPosition = FormStartPosition.CenterScreen
        Bank.ShowDialog()
    End Sub

    Private Sub BuyerNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuyerNameComboBoxEdit.SelectedIndexChanged
        Dim sda As New OleDbDataAdapter("Select Address,State,StateCode,GSTIN,PANNo From Party Where PartyName='" + BuyerNameComboBoxEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            BuyerAddressTextEdit.Text = dt.Rows(0).Item("Address").ToString
            BuyerStateTextEdit.Text = dt.Rows(0).Item("State").ToString
            BuyerStateCodeTextEdit.Text = dt.Rows(0).Item("StateCode").ToString
            BuyerGSTINTextEdit.Text = dt.Rows(0).Item("GSTIN").ToString
            BuyerPANNoTextEdit.Text = dt.Rows(0).Item("PANNo").ToString
        End If
    End Sub
    Private Sub AddNewProduct_Click(sender As Object, e As EventArgs)
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
    Private Sub BuyerPANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles BuyerPANNoTextEdit.Leave
        If BuyerPANNoTextEdit.EditValue IsNot DBNull.Value Then
            If BuyerPANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BuyerPANNoTextEdit.Focus()
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

    Private Sub BuyerNameComboBoxEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuyerNameComboBoxEdit.KeyPress
        InitLookup()
    End Sub

    Private Sub InvoiceNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InvoiceNoTextEdit.Validating
        If Not InvoiceNoTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(QuotationID) FROM Quotation WHERE QuotationNo=@QuotationNo AND QuotationID<>@QuotationID", ConStr)
                CMD.Parameters.AddWithValue("@QuotationNo", InvoiceNoTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@QuotationID", IIf(BS.Current!QuotationID Is DBNull.Value, -1, BS.Current!QuotationID))
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
    Private Sub InvoiceDateDateEdit_Leave(sender As Object, e As EventArgs)
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
    Private Sub InquiryDateDateEdit_Leave(sender As Object, e As EventArgs) Handles InvoiceDateDateEdit.Leave
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)
        Dim iDate As String = InquiryDateDateEdit.Text
        Dim oDate As DateTime = Convert.ToDateTime(iDate)

        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        If iDate >= SubStart And iDate <= SubEnd Then
        Else
            XtraMessageBox.Show("Date is out of Range! Please Enter a Valid Date or check your Financial Period.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Not between")
            InquiryDateDateEdit.Focus()
        End If
    End Sub

    Private Sub PanelCtrlMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles PanelCtrlMain.MouseWheel
        Dim myView As Point = Me.PanelCtrlMain.AutoScrollPosition
        myView.X = (myView.X + 50)
        myView.Y = (myView.Y + 50)
        Me.PanelCtrlMain.AutoScrollPosition = myView
    End Sub

    Private Sub AddNewProductSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewProductSimpleButton.Click
        Frm_AddProduct.StartPosition = FormStartPosition.CenterParent
        Frm_AddProduct.ShowDialog()
        If Frm_AddProduct.DialogResult = DialogResult.OK Then
            GridComboBoxFunc("Select DISTINCT ProductName FROM Product", "Product", InvoiceDetailGridControl, InvoiceDetailGridView, "ProductName", "Product")
            Frm_AddProduct.Close()
        Else
            Frm_AddProduct.Close()
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SendEmailSimpleButton_Click(sender As Object, e As EventArgs) Handles SendEmailSimpleButton.Click
        Dim DAParty As New OleDbDataAdapter("Select Email From Party Where PartyName ='" + BuyerNameComboBoxEdit.Text + "'", ConStr)
        Dim DTParty As New DataTable
        DAParty.Fill(DTParty)
        Dim partyEmail As String
        If DTParty.Rows(0).Item("Email") IsNot DBNull.Value Then
            partyEmail = DTParty.Rows(0).Item("Email").ToString()

            'Dim DACompany As New OleDbDataAdapter("Select EmailID1,Password From Company Where Name ='" + PubCompanyName + "'", ConStr)
            'Dim DTCompany As New DataTable
            'DACompany.Fill(DTCompany)

            'Dim fromEmail As String = DTCompany.Rows(0).Item("EmailID1").ToString

            Dim oMail As New SmtpMail("TryIt")
            oMail.From = ConfigurationManager.AppSettings("Username")
            oMail.To = partyEmail
            oMail.Subject = "Quotation Copy"
            oMail.TextBody = " Hi Team
                        Please find attachment of quotation copy for your reference.
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

    Private Sub InvoiceDetailGridControl_Click(sender As Object, e As EventArgs) Handles InvoiceDetailGridControl.Click

    End Sub

    Private Sub CloseBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseBarButtonItem.ItemClick
        Me.Close()
    End Sub



    'Dim iNumber As Integer
    'Private Sub MobileTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MobileTextEdit.Validating
    '    If MobileTextEdit.EditValue IsNot DBNull.Value Then
    '        If MobileTextEdit.Text.Length > 12 Then
    '            If Not Integer.TryParse(MobileTextEdit.Text, iNumber) Then
    '                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                MobileTextEdit.Focus()
    '            End If
    '        End If
    '    End If
    'End Sub


    'Private Sub MobileTextEdit_Leave(sender As Object, e As EventArgs) Handles MobileTextEdit.Leave
    '    If MobileTextEdit.EditValue IsNot DBNull.Value Then
    '        If MobileTextEdit.Text.Length <> 10 Then
    '            XtraMessageBox.Show("Please Enter Valid Mobile Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            MobileTextEdit.Focus()
    '        End If
    '    End If
    'End Sub
End Class

